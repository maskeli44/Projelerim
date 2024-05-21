﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.malzemeGuncelle
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
using Makina_Ikmal.bellDataSet7TableAdapters;
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

namespace Makina_Ikmal.Aambar
{
  public class malzemeGuncelle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private SimpleButton kodVerButton;
    private TextEdit malzemeKodTextEdit;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem16;
    private TextEdit kullanimYeriTextEdit;
    private TextEdit gozNoTextEdit;
    private TextEdit rafNoTextEdit;
    private TextEdit barkodTextEdit;
    private TextEdit digerAdiTextEdit;
    private TextEdit malzemeAdiTextEdit;
    private TextEdit oemKodTextEdit;
    private TextEdit ureticiKodTextEdit;
    private SearchLookUpEdit grup2SluEdit;
    private GridView searchLookUpEdit1View;
    private SearchLookUpEdit grup1SluEdit;
    private GridView gridView1;
    private SearchLookUpEdit birimSluEdit;
    private GridView gridView2;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private SimpleButton bolumuEkleEdit;
    private ComboBoxEdit kiloMetreComboEdit;
    private ComboBoxEdit seriNoComboEdit;
    private ComboBoxEdit tarihComboEdit;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem22;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem24;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControl layoutControl7;
    private LayoutControlGroup layoutControlGroup6;
    private LayoutControl layoutControl6;
    private LayoutControlGroup layoutControlGroup5;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private SimpleButton grup1EkleButton;
    private SimpleButton grup2EkleButton;
    private SimpleButton birimEkleButton;
    private LayoutControlItem layoutControlItem26;
    private LayoutControlItem layoutControlItem27;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem28;
    private LayoutControlItem layoutControlItem29;
    private LayoutControlItem layoutControlItem30;
    private LayoutControlItem layoutControlItem31;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private GridColumn colID;
    private GridColumn colBIRIMADI;
    private BindingSource tBLMALZGRUPBindingSource;
    private TBLMALZGRUPTableAdapter tBLMALZGRUPTableAdapter;
    private GridColumn colID1;
    private GridColumn colMALZEMEGRUP;
    private BindingSource tBLMALZGRUP2BindingSource;
    private TBLMALZGRUP2TableAdapter tBLMALZGRUP2TableAdapter;
    private GridColumn colID2;
    private GridColumn colMALZEMEGRUP2;
    private SearchLookUpEdit bolumLook;
    private GridView gridView3;
    private LayoutControlItem layoutControlItem11;
    private BindingSource tBLMALZBOLUMBindingSource;
    private TBLMALZBOLUMTableAdapter tBLMALZBOLUMTableAdapter;
    private GridColumn colID3;
    private GridColumn colBOLUMADI;
    private BindingSource tBLMALZKDVBindingSource;
    private TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private SearchLookUpEdit KDVoranLook;
    private GridView searchLookUpEdit2View;
    private LayoutControlItem layoutControlItem10;
    private SearchLookUpEdit searchLookUpEdit1;
    private CheckEdit checkEdit11;
    private TextEdit miktarTxtEdit;
    private ComboBoxEdit comboBoxEdit11;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem cincik;
    private LayoutControlItem layoutControlItem18;

    public malzemeGuncelle() => this.InitializeComponent();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void checkButton1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      int num = (int) new MalzemeBolum().ShowDialog();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void birimEkleButton_Click(object sender, EventArgs e)
    {
      int num = (int) new MalzemeBirim().ShowDialog();
    }

    private void malzemeEkle_Load(object sender, EventArgs e)
    {
      this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet7.TBLMALZKDV);
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet7.TBLMALZBOLUM);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet7.TBLMALZGRUP2);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet7.TBLMALZGRUP);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet7.TBLMALZBIRIM);
      this.guncelle();
      this.comboBoxEdit11.Enabled = false;
      this.grup1EkleButton.Enabled = false;
    }

    private void grup1EkleButton_Click(object sender, EventArgs e)
    {
      int num = (int) new MalzemeGrup1().ShowDialog();
    }

    private void grup2EkleButton_Click(object sender, EventArgs e)
    {
      int num = (int) new MalzemeGrup2().ShowDialog();
    }

    private void birimSluEdit_Click(object sender, EventArgs e) => this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet7.TBLMALZBIRIM);

    private void grup1SluEdit_Click(object sender, EventArgs e) => this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet7.TBLMALZGRUP);

    private void grup2SluEdit_Click(object sender, EventArgs e) => this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet7.TBLMALZGRUP2);

    private void searchLookUpEdit1_Click(object sender, EventArgs e) => this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet7.TBLMALZBOLUM);

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.kayit();
      LogEkle.Logs("Guncelleme Yapti");
      ((malzemeListesi) Application.OpenForms["malzemeListesi"])?.Listele();
      this.Close();
    }

    private void kayit()
    {
      TBLMALZEMELER tblmalzemeler1 = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == YetkiClass.secim_id));
      try
      {
        tblmalzemeler1.KOD = this.malzemeKodTextEdit.Text;
        tblmalzemeler1.UFKOD = this.ureticiKodTextEdit.Text;
        tblmalzemeler1.OEMKOD = this.oemKodTextEdit.Text;
        tblmalzemeler1.MALZEMEADI = this.malzemeAdiTextEdit.Text;
        tblmalzemeler1.DIGERADI = this.digerAdiTextEdit.Text;
        tblmalzemeler1.BARKOD = this.barkodTextEdit.Text;
        tblmalzemeler1.BIRIMID = new int?(Convert.ToInt32(this.birimSluEdit.EditValue));
        tblmalzemeler1.GRUPID = new int?(Convert.ToInt32(this.grup1SluEdit.EditValue));
        tblmalzemeler1.GRUPID2 = new int?(Convert.ToInt32(this.grup2SluEdit.EditValue));
        tblmalzemeler1.BOLUMID = new int?(Convert.ToInt32(this.bolumLook.EditValue));
        tblmalzemeler1.KDVID = new int?(Convert.ToInt32(this.KDVoranLook.EditValue));
        tblmalzemeler1.RAFNO = this.rafNoTextEdit.Text;
        tblmalzemeler1.GOZNO = this.gozNoTextEdit.Text;
        tblmalzemeler1.KULLANIMYERI = this.kullanimYeriTextEdit.Text;
        tblmalzemeler1.TARIHKONTROL = Convert.ToString(this.tarihComboEdit.EditValue);
        tblmalzemeler1.SERINOKONTROL = Convert.ToString(this.seriNoComboEdit.EditValue);
        tblmalzemeler1.KMKONTROL = Convert.ToString(this.kiloMetreComboEdit.EditValue);
        TBLMALZEMELER tblmalzemeler2 = tblmalzemeler1;
        Decimal? giris = tblmalzemeler2.GIRIS;
        Decimal num1 = Convert.ToDecimal(this.miktarTxtEdit.Text);
        tblmalzemeler2.GIRIS = giris.HasValue ? new Decimal?(giris.GetValueOrDefault() + num1) : new Decimal?();
        Decimal num2 = Convert.ToDecimal((object) tblmalzemeler1.GIRIS) - Convert.ToDecimal((object) tblmalzemeler1.CIKIS);
        tblmalzemeler1.KALAN = new Decimal?(num2);
        this.db.SaveChanges();
        int num3 = (int) MessageBox.Show("Guncelleme başarlı bir şekilde alındı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " HATA");
      }
    }

    private void guncelle()
    {
      TBLMALZEMELER tblmalzemeler = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == YetkiClass.secim_id));
      this.malzemeKodTextEdit.Text = tblmalzemeler.KOD;
      this.ureticiKodTextEdit.Text = tblmalzemeler.UFKOD;
      this.oemKodTextEdit.Text = tblmalzemeler.OEMKOD;
      this.malzemeAdiTextEdit.Text = tblmalzemeler.MALZEMEADI;
      this.digerAdiTextEdit.Text = tblmalzemeler.DIGERADI;
      this.barkodTextEdit.Text = tblmalzemeler.BARKOD;
      this.birimSluEdit.EditValue = (object) tblmalzemeler.BIRIMID;
      this.grup1SluEdit.EditValue = (object) tblmalzemeler.GRUPID;
      this.grup2SluEdit.EditValue = (object) tblmalzemeler.GRUPID2;
      this.bolumLook.EditValue = (object) tblmalzemeler.BOLUMID;
      this.KDVoranLook.EditValue = (object) tblmalzemeler.KDVID;
      this.miktarTxtEdit.Text = tblmalzemeler.GIRIS.ToString();
      this.rafNoTextEdit.Text = tblmalzemeler.RAFNO;
      this.gozNoTextEdit.Text = tblmalzemeler.GOZNO;
      this.kullanimYeriTextEdit.Text = tblmalzemeler.KULLANIMYERI;
      this.tarihComboEdit.EditValue = (object) tblmalzemeler.TARIHKONTROL;
      this.seriNoComboEdit.EditValue = (object) tblmalzemeler.SERINOKONTROL;
      this.kiloMetreComboEdit.EditValue = (object) tblmalzemeler.KMKONTROL;
      this.miktarTxtEdit.Text = tblmalzemeler.KALAN.ToString();
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLMALZEMELER entity = this.db.TBLMALZEMELER.FirstOrDefault<TBLMALZEMELER>((Expression<System.Func<TBLMALZEMELER, bool>>) (x => x.ID == YetkiClass.secim_id));
      if (entity == null)
        return;
      this.db.TBLMALZEMELER.Remove(entity);
      this.db.SaveChanges();
      LogEkle.Logs("Guncelleme Yapti");
      ((malzemeListesi) Application.OpenForms["malzemeListesi"])?.Listele();
      this.Close();
    }

    private void checkEdit11_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkEdit11.Checked)
        ;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (malzemeGuncelle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.KDVoranLook = new SearchLookUpEdit();
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.searchLookUpEdit2View = new GridView();
      this.bolumLook = new SearchLookUpEdit();
      this.tBLMALZBOLUMBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.colID3 = new GridColumn();
      this.colBOLUMADI = new GridColumn();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.layoutControl7 = new LayoutControl();
      this.layoutControlGroup6 = new LayoutControlGroup();
      this.layoutControl6 = new LayoutControl();
      this.layoutControlGroup5 = new LayoutControlGroup();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.grup1EkleButton = new SimpleButton();
      this.grup2EkleButton = new SimpleButton();
      this.birimEkleButton = new SimpleButton();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.bolumuEkleEdit = new SimpleButton();
      this.kiloMetreComboEdit = new ComboBoxEdit();
      this.seriNoComboEdit = new ComboBoxEdit();
      this.tarihComboEdit = new ComboBoxEdit();
      this.kodVerButton = new SimpleButton();
      this.malzemeKodTextEdit = new TextEdit();
      this.kullanimYeriTextEdit = new TextEdit();
      this.gozNoTextEdit = new TextEdit();
      this.rafNoTextEdit = new TextEdit();
      this.barkodTextEdit = new TextEdit();
      this.digerAdiTextEdit = new TextEdit();
      this.malzemeAdiTextEdit = new TextEdit();
      this.oemKodTextEdit = new TextEdit();
      this.ureticiKodTextEdit = new TextEdit();
      this.grup2SluEdit = new SearchLookUpEdit();
      this.tBLMALZGRUP2BindingSource = new BindingSource(this.components);
      this.searchLookUpEdit1View = new GridView();
      this.colID2 = new GridColumn();
      this.colMALZEMEGRUP2 = new GridColumn();
      this.grup1SluEdit = new SearchLookUpEdit();
      this.tBLMALZGRUPBindingSource = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.colID1 = new GridColumn();
      this.colMALZEMEGRUP = new GridColumn();
      this.birimSluEdit = new SearchLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.colID = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.checkEdit11 = new CheckEdit();
      this.miktarTxtEdit = new TextEdit();
      this.comboBoxEdit11 = new ComboBoxEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem24 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem28 = new LayoutControlItem();
      this.layoutControlItem29 = new LayoutControlItem();
      this.layoutControlItem30 = new LayoutControlItem();
      this.layoutControlItem31 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.cincik = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZGRUPTableAdapter = new TBLMALZGRUPTableAdapter();
      this.tBLMALZGRUP2TableAdapter = new TBLMALZGRUP2TableAdapter();
      this.tBLMALZBOLUMTableAdapter = new TBLMALZBOLUMTableAdapter();
      this.tBLMALZKDVTableAdapter = new TBLMALZKDVTableAdapter();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.KDVoranLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.bolumLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.layoutControl7.BeginInit();
      this.layoutControlGroup6.BeginInit();
      this.layoutControl6.BeginInit();
      this.layoutControlGroup5.BeginInit();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.kiloMetreComboEdit.Properties.BeginInit();
      this.seriNoComboEdit.Properties.BeginInit();
      this.tarihComboEdit.Properties.BeginInit();
      this.malzemeKodTextEdit.Properties.BeginInit();
      this.kullanimYeriTextEdit.Properties.BeginInit();
      this.gozNoTextEdit.Properties.BeginInit();
      this.rafNoTextEdit.Properties.BeginInit();
      this.barkodTextEdit.Properties.BeginInit();
      this.digerAdiTextEdit.Properties.BeginInit();
      this.malzemeAdiTextEdit.Properties.BeginInit();
      this.oemKodTextEdit.Properties.BeginInit();
      this.ureticiKodTextEdit.Properties.BeginInit();
      this.grup2SluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.grup1SluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).BeginInit();
      this.gridView1.BeginInit();
      this.birimSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.checkEdit11.Properties.BeginInit();
      this.miktarTxtEdit.Properties.BeginInit();
      this.comboBoxEdit11.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem24.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem28.BeginInit();
      this.layoutControlItem29.BeginInit();
      this.layoutControlItem30.BeginInit();
      this.layoutControlItem31.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.cincik.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
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
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 11;
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
      this.ribbonControl1.Size = new Size(710, 96);
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
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.layoutControl1.Controls.Add((Control) this.KDVoranLook);
      this.layoutControl1.Controls.Add((Control) this.bolumLook);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.layoutControl7);
      this.layoutControl1.Controls.Add((Control) this.layoutControl6);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.grup1EkleButton);
      this.layoutControl1.Controls.Add((Control) this.grup2EkleButton);
      this.layoutControl1.Controls.Add((Control) this.birimEkleButton);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.bolumuEkleEdit);
      this.layoutControl1.Controls.Add((Control) this.kiloMetreComboEdit);
      this.layoutControl1.Controls.Add((Control) this.seriNoComboEdit);
      this.layoutControl1.Controls.Add((Control) this.tarihComboEdit);
      this.layoutControl1.Controls.Add((Control) this.kodVerButton);
      this.layoutControl1.Controls.Add((Control) this.malzemeKodTextEdit);
      this.layoutControl1.Controls.Add((Control) this.kullanimYeriTextEdit);
      this.layoutControl1.Controls.Add((Control) this.gozNoTextEdit);
      this.layoutControl1.Controls.Add((Control) this.rafNoTextEdit);
      this.layoutControl1.Controls.Add((Control) this.barkodTextEdit);
      this.layoutControl1.Controls.Add((Control) this.digerAdiTextEdit);
      this.layoutControl1.Controls.Add((Control) this.malzemeAdiTextEdit);
      this.layoutControl1.Controls.Add((Control) this.oemKodTextEdit);
      this.layoutControl1.Controls.Add((Control) this.ureticiKodTextEdit);
      this.layoutControl1.Controls.Add((Control) this.grup2SluEdit);
      this.layoutControl1.Controls.Add((Control) this.grup1SluEdit);
      this.layoutControl1.Controls.Add((Control) this.birimSluEdit);
      this.layoutControl1.Controls.Add((Control) this.checkEdit11);
      this.layoutControl1.Controls.Add((Control) this.miktarTxtEdit);
      this.layoutControl1.Controls.Add((Control) this.comboBoxEdit11);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(710, 441);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.KDVoranLook.EditValue = (object) "";
      this.KDVoranLook.Location = new Point(137, 311);
      this.KDVoranLook.Margin = new Padding(3, 2, 3, 2);
      this.KDVoranLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KDVoranLook.Name = "KDVoranLook";
      this.KDVoranLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.KDVoranLook.Properties.DataSource = (object) this.tBLMALZKDVBindingSource;
      this.KDVoranLook.Properties.DisplayMember = "KDVORAN";
      this.KDVoranLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.KDVoranLook.Properties.ValueMember = "ID";
      this.KDVoranLook.Size = new Size(206, 20);
      this.KDVoranLook.StyleController = (IStyleController) this.layoutControl1;
      this.KDVoranLook.TabIndex = 41;
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit2View.DetailHeight = 284;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.bolumLook.EditValue = (object) "c";
      this.bolumLook.Location = new Point(137, 287);
      this.bolumLook.Margin = new Padding(3, 2, 3, 2);
      this.bolumLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bolumLook.Name = "bolumLook";
      this.bolumLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bolumLook.Properties.DataSource = (object) this.tBLMALZBOLUMBindingSource;
      this.bolumLook.Properties.DisplayMember = "BOLUMADI";
      this.bolumLook.Properties.PopupView = (ColumnView) this.gridView3;
      this.bolumLook.Properties.ValueMember = "ID";
      this.bolumLook.Size = new Size(206, 20);
      this.bolumLook.StyleController = (IStyleController) this.layoutControl1;
      this.bolumLook.TabIndex = 40;
      this.bolumLook.Click += new EventHandler(this.searchLookUpEdit1_Click);
      this.tBLMALZBOLUMBindingSource.DataMember = "TBLMALZBOLUM";
      this.tBLMALZBOLUMBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView3.Columns.AddRange(new GridColumn[2]
      {
        this.colID3,
        this.colBOLUMADI
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.colID3.FieldName = "ID";
      this.colID3.MinWidth = 17;
      this.colID3.Name = "colID3";
      this.colID3.OptionsColumn.AllowEdit = false;
      this.colID3.OptionsColumn.ReadOnly = true;
      this.colID3.Width = 64;
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 17;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.OptionsColumn.AllowEdit = false;
      this.colBOLUMADI.OptionsColumn.ReadOnly = true;
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 0;
      this.colBOLUMADI.Width = 64;
      this.layoutControl5.Location = new Point(460, 10);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(239, 75);
      this.layoutControl5.TabIndex = 37;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(239, 75);
      this.layoutControlGroup4.TextVisible = false;
      this.layoutControl7.Location = new Point(400, 261);
      this.layoutControl7.Name = "layoutControl7";
      this.layoutControl7.Root = this.layoutControlGroup6;
      this.layoutControl7.Size = new Size(299, 22);
      this.layoutControl7.TabIndex = 36;
      this.layoutControl7.Text = "layoutControl7";
      this.layoutControlGroup6.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup6.GroupBordersVisible = false;
      this.layoutControlGroup6.Name = "layoutControlGroup6";
      this.layoutControlGroup6.Size = new Size(299, 22);
      this.layoutControlGroup6.TextVisible = false;
      this.layoutControl6.Location = new Point(400, 235);
      this.layoutControl6.Name = "layoutControl6";
      this.layoutControl6.Root = this.layoutControlGroup5;
      this.layoutControl6.Size = new Size(299, 22);
      this.layoutControl6.TabIndex = 35;
      this.layoutControl6.Text = "layoutControl6";
      this.layoutControlGroup5.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup5.GroupBordersVisible = false;
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new Size(299, 22);
      this.layoutControlGroup5.TextVisible = false;
      this.layoutControl4.Location = new Point(400, 209);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(299, 22);
      this.layoutControl4.TabIndex = 34;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(299, 22);
      this.layoutControlGroup3.TextVisible = false;
      this.grup1EkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("grup1EkleButton.ImageOptions.Image");
      this.grup1EkleButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.grup1EkleButton.Location = new Point(356, 235);
      this.grup1EkleButton.Name = "grup1EkleButton";
      this.grup1EkleButton.PaintStyle = PaintStyles.Light;
      this.grup1EkleButton.Size = new Size(40, 22);
      this.grup1EkleButton.StyleController = (IStyleController) this.layoutControl1;
      this.grup1EkleButton.TabIndex = 33;
      this.grup1EkleButton.Click += new EventHandler(this.grup1EkleButton_Click);
      this.grup2EkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("grup2EkleButton.ImageOptions.Image");
      this.grup2EkleButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.grup2EkleButton.Location = new Point(356, 261);
      this.grup2EkleButton.Name = "grup2EkleButton";
      this.grup2EkleButton.PaintStyle = PaintStyles.Light;
      this.grup2EkleButton.Size = new Size(40, 22);
      this.grup2EkleButton.StyleController = (IStyleController) this.layoutControl1;
      this.grup2EkleButton.TabIndex = 32;
      this.grup2EkleButton.Click += new EventHandler(this.grup2EkleButton_Click);
      this.birimEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("birimEkleButton.ImageOptions.Image");
      this.birimEkleButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.birimEkleButton.Location = new Point(356, 209);
      this.birimEkleButton.Name = "birimEkleButton";
      this.birimEkleButton.PaintStyle = PaintStyles.Light;
      this.birimEkleButton.Size = new Size(40, 22);
      this.birimEkleButton.StyleController = (IStyleController) this.layoutControl1;
      this.birimEkleButton.TabIndex = 31;
      this.birimEkleButton.Click += new EventHandler(this.birimEkleButton_Click);
      this.layoutControl3.Location = new Point(323, 359);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(37, 20);
      this.layoutControl3.TabIndex = 29;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(37, 20);
      this.layoutControlGroup2.TextVisible = false;
      this.layoutControl2.Location = new Point(323, 335);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(37, 20);
      this.layoutControl2.TabIndex = 28;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(37, 20);
      this.layoutControlGroup1.TextVisible = false;
      this.bolumuEkleEdit.BackgroundImageLayout = ImageLayout.Center;
      this.bolumuEkleEdit.ImageOptions.Image = (Image) componentResourceManager.GetObject("bolumuEkleEdit.ImageOptions.Image");
      this.bolumuEkleEdit.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.bolumuEkleEdit.Location = new Point(347, 287);
      this.bolumuEkleEdit.Name = "bolumuEkleEdit";
      this.bolumuEkleEdit.PaintStyle = PaintStyles.Light;
      this.bolumuEkleEdit.Size = new Size(23, 22);
      this.bolumuEkleEdit.StyleController = (IStyleController) this.layoutControl1;
      this.bolumuEkleEdit.TabIndex = 27;
      this.bolumuEkleEdit.Click += new EventHandler(this.simpleButton2_Click);
      this.kiloMetreComboEdit.Location = new Point(490, 359);
      this.kiloMetreComboEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kiloMetreComboEdit.Name = "kiloMetreComboEdit";
      this.kiloMetreComboEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kiloMetreComboEdit.Properties.Items.AddRange(new object[2]
      {
        (object) "VAR",
        (object) "YOK"
      });
      this.kiloMetreComboEdit.Size = new Size(209, 20);
      this.kiloMetreComboEdit.StyleController = (IStyleController) this.layoutControl1;
      this.kiloMetreComboEdit.TabIndex = 26;
      this.seriNoComboEdit.Location = new Point(490, 335);
      this.seriNoComboEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.seriNoComboEdit.Name = "seriNoComboEdit";
      this.seriNoComboEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.seriNoComboEdit.Properties.Items.AddRange(new object[2]
      {
        (object) "VAR",
        (object) "YOK"
      });
      this.seriNoComboEdit.Size = new Size(209, 20);
      this.seriNoComboEdit.StyleController = (IStyleController) this.layoutControl1;
      this.seriNoComboEdit.TabIndex = 25;
      this.tarihComboEdit.Location = new Point(500, 287);
      this.tarihComboEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihComboEdit.Name = "tarihComboEdit";
      this.tarihComboEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihComboEdit.Properties.Items.AddRange(new object[2]
      {
        (object) "VAR",
        (object) " YOK"
      });
      this.tarihComboEdit.Size = new Size(199, 20);
      this.tarihComboEdit.StyleController = (IStyleController) this.layoutControl1;
      this.tarihComboEdit.TabIndex = 24;
      this.kodVerButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("kodVerButton.ImageOptions.Image");
      this.kodVerButton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.kodVerButton.Location = new Point(401, 10);
      this.kodVerButton.Name = "kodVerButton";
      this.kodVerButton.PaintStyle = PaintStyles.Light;
      this.kodVerButton.Size = new Size(55, 75);
      this.kodVerButton.StyleController = (IStyleController) this.layoutControl1;
      this.kodVerButton.TabIndex = 21;
      this.kodVerButton.Click += new EventHandler(this.simpleButton1_Click);
      this.malzemeKodTextEdit.Location = new Point(146, 10);
      this.malzemeKodTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.malzemeKodTextEdit.Name = "malzemeKodTextEdit";
      this.malzemeKodTextEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.malzemeKodTextEdit.Properties.Appearance.Options.UseFont = true;
      this.malzemeKodTextEdit.Size = new Size(251, 36);
      this.malzemeKodTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.malzemeKodTextEdit.TabIndex = 20;
      this.kullanimYeriTextEdit.Location = new Point(137, 383);
      this.kullanimYeriTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kullanimYeriTextEdit.Name = "kullanimYeriTextEdit";
      this.kullanimYeriTextEdit.Size = new Size(562, 20);
      this.kullanimYeriTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.kullanimYeriTextEdit.TabIndex = 17;
      this.gozNoTextEdit.Location = new Point(137, 359);
      this.gozNoTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gozNoTextEdit.Name = "gozNoTextEdit";
      this.gozNoTextEdit.Size = new Size(182, 20);
      this.gozNoTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.gozNoTextEdit.TabIndex = 16;
      this.rafNoTextEdit.Location = new Point(137, 335);
      this.rafNoTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.rafNoTextEdit.Name = "rafNoTextEdit";
      this.rafNoTextEdit.Size = new Size(182, 20);
      this.rafNoTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.rafNoTextEdit.TabIndex = 15;
      this.barkodTextEdit.Location = new Point(137, 185);
      this.barkodTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.barkodTextEdit.Name = "barkodTextEdit";
      this.barkodTextEdit.Size = new Size(562, 20);
      this.barkodTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.barkodTextEdit.TabIndex = 9;
      this.digerAdiTextEdit.Location = new Point(137, 161);
      this.digerAdiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.digerAdiTextEdit.Name = "digerAdiTextEdit";
      this.digerAdiTextEdit.Size = new Size(562, 20);
      this.digerAdiTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.digerAdiTextEdit.TabIndex = 8;
      this.malzemeAdiTextEdit.Location = new Point(137, 137);
      this.malzemeAdiTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.malzemeAdiTextEdit.Name = "malzemeAdiTextEdit";
      this.malzemeAdiTextEdit.Size = new Size(562, 20);
      this.malzemeAdiTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.malzemeAdiTextEdit.TabIndex = 7;
      this.oemKodTextEdit.Location = new Point(137, 113);
      this.oemKodTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.oemKodTextEdit.Name = "oemKodTextEdit";
      this.oemKodTextEdit.Size = new Size(562, 20);
      this.oemKodTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.oemKodTextEdit.TabIndex = 6;
      this.ureticiKodTextEdit.Location = new Point(137, 89);
      this.ureticiKodTextEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ureticiKodTextEdit.Name = "ureticiKodTextEdit";
      this.ureticiKodTextEdit.Size = new Size(562, 20);
      this.ureticiKodTextEdit.StyleController = (IStyleController) this.layoutControl1;
      this.ureticiKodTextEdit.TabIndex = 5;
      this.grup2SluEdit.Location = new Point(137, 261);
      this.grup2SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.grup2SluEdit.Name = "grup2SluEdit";
      this.grup2SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grup2SluEdit.Properties.DataSource = (object) this.tBLMALZGRUP2BindingSource;
      this.grup2SluEdit.Properties.DisplayMember = "MALZEMEGRUP2";
      this.grup2SluEdit.Properties.NullText = "";
      this.grup2SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.grup2SluEdit.Properties.ValueMember = "ID";
      this.grup2SluEdit.Size = new Size(215, 20);
      this.grup2SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.grup2SluEdit.TabIndex = 12;
      this.grup2SluEdit.Click += new EventHandler(this.grup2SluEdit_Click);
      this.tBLMALZGRUP2BindingSource.DataMember = "TBLMALZGRUP2";
      this.tBLMALZGRUP2BindingSource.DataSource = (object) this.bellDataSet7;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[2]
      {
        this.colID2,
        this.colMALZEMEGRUP2
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colID2.FieldName = "ID";
      this.colID2.MinWidth = 17;
      this.colID2.Name = "colID2";
      this.colID2.OptionsColumn.AllowEdit = false;
      this.colID2.OptionsColumn.ReadOnly = true;
      this.colID2.Width = 64;
      this.colMALZEMEGRUP2.FieldName = "MALZEMEGRUP2";
      this.colMALZEMEGRUP2.MinWidth = 17;
      this.colMALZEMEGRUP2.Name = "colMALZEMEGRUP2";
      this.colMALZEMEGRUP2.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP2.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP2.Visible = true;
      this.colMALZEMEGRUP2.VisibleIndex = 0;
      this.colMALZEMEGRUP2.Width = 64;
      this.grup1SluEdit.Location = new Point(137, 235);
      this.grup1SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.grup1SluEdit.Name = "grup1SluEdit";
      this.grup1SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grup1SluEdit.Properties.DataSource = (object) this.tBLMALZGRUPBindingSource;
      this.grup1SluEdit.Properties.DisplayMember = "MALZEMEGRUP";
      this.grup1SluEdit.Properties.NullText = "";
      this.grup1SluEdit.Properties.PopupView = (ColumnView) this.gridView1;
      this.grup1SluEdit.Properties.ValueMember = "ID";
      this.grup1SluEdit.Size = new Size(215, 20);
      this.grup1SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.grup1SluEdit.TabIndex = 11;
      this.grup1SluEdit.Click += new EventHandler(this.grup1SluEdit_Click);
      this.tBLMALZGRUPBindingSource.DataMember = "TBLMALZGRUP";
      this.tBLMALZGRUPBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colID1,
        this.colMALZEMEGRUP
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.colID1.FieldName = "ID";
      this.colID1.MinWidth = 17;
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colID1.Width = 64;
      this.colMALZEMEGRUP.FieldName = "MALZEMEGRUP";
      this.colMALZEMEGRUP.MinWidth = 17;
      this.colMALZEMEGRUP.Name = "colMALZEMEGRUP";
      this.colMALZEMEGRUP.OptionsColumn.AllowEdit = false;
      this.colMALZEMEGRUP.OptionsColumn.ReadOnly = true;
      this.colMALZEMEGRUP.Visible = true;
      this.colMALZEMEGRUP.VisibleIndex = 0;
      this.colMALZEMEGRUP.Width = 64;
      this.birimSluEdit.Location = new Point(137, 209);
      this.birimSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.birimSluEdit.Name = "birimSluEdit";
      this.birimSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birimSluEdit.Properties.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.birimSluEdit.Properties.DisplayMember = "BIRIMADI";
      this.birimSluEdit.Properties.NullText = "";
      this.birimSluEdit.Properties.PopupView = (ColumnView) this.gridView2;
      this.birimSluEdit.Properties.ValueMember = "ID";
      this.birimSluEdit.Size = new Size(215, 20);
      this.birimSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.birimSluEdit.TabIndex = 10;
      this.birimSluEdit.Click += new EventHandler(this.birimSluEdit_Click);
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet7;
      this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colBIRIMADI
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 17;
      this.colID.Name = "colID";
      this.colID.Width = 64;
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 17;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 0;
      this.colBIRIMADI.Width = 64;
      this.checkEdit11.Location = new Point(11, 407);
      this.checkEdit11.Margin = new Padding(3, 2, 3, 2);
      this.checkEdit11.Name = "checkEdit11";
      this.checkEdit11.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkEdit11.Properties.Appearance.ForeColor = Color.Black;
      this.checkEdit11.Properties.Appearance.Options.UseFont = true;
      this.checkEdit11.Properties.Appearance.Options.UseForeColor = true;
      this.checkEdit11.Properties.Caption = "Açılış Fişi Oluştur";
      this.checkEdit11.Size = new Size(148, 21);
      this.checkEdit11.StyleController = (IStyleController) this.layoutControl1;
      this.checkEdit11.TabIndex = 42;
      this.checkEdit11.CheckedChanged += new EventHandler(this.checkEdit11_CheckedChanged);
      this.miktarTxtEdit.Location = new Point(197, 407);
      this.miktarTxtEdit.Margin = new Padding(3, 2, 3, 2);
      this.miktarTxtEdit.Name = "miktarTxtEdit";
      this.miktarTxtEdit.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.miktarTxtEdit.Properties.Appearance.Options.UseFont = true;
      this.miktarTxtEdit.Properties.Mask.EditMask = "d";
      this.miktarTxtEdit.Size = new Size(206, 24);
      this.miktarTxtEdit.StyleController = (IStyleController) this.layoutControl1;
      this.miktarTxtEdit.TabIndex = 43;
      this.comboBoxEdit11.Location = new Point(455, 407);
      this.comboBoxEdit11.Margin = new Padding(3, 2, 3, 2);
      this.comboBoxEdit11.Name = "comboBoxEdit11";
      this.comboBoxEdit11.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.comboBoxEdit11.Properties.Appearance.Options.UseFont = true;
      this.comboBoxEdit11.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.comboBoxEdit11.Properties.Items.AddRange(new object[4]
      {
        (object) "AMBAR",
        (object) "YAĞ(MOBİL)",
        (object) "YAĞ(MERKEZ)",
        (object) "FİLTRE DEPO"
      });
      this.comboBoxEdit11.Size = new Size(244, 24);
      this.comboBoxEdit11.StyleController = (IStyleController) this.layoutControl1;
      this.comboBoxEdit11.TabIndex = 44;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[31]
      {
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem24,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem28,
        (BaseLayoutItem) this.layoutControlItem29,
        (BaseLayoutItem) this.layoutControlItem30,
        (BaseLayoutItem) this.layoutControlItem31,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.cincik,
        (BaseLayoutItem) this.layoutControlItem18
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(710, 441);
      this.Root.TextVisible = false;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem2.Control = (Control) this.ureticiKodTextEdit;
      this.layoutControlItem2.Location = new Point(0, 79);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(692, 24);
      this.layoutControlItem2.Text = "Üretici Firma Kod";
      this.layoutControlItem2.TextSize = new Size(123, 18);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem3.Control = (Control) this.oemKodTextEdit;
      this.layoutControlItem3.Location = new Point(0, 103);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(692, 24);
      this.layoutControlItem3.Text = "Oem Kod";
      this.layoutControlItem3.TextSize = new Size(123, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem4.Control = (Control) this.malzemeAdiTextEdit;
      this.layoutControlItem4.Location = new Point(0, (int) sbyte.MaxValue);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(692, 24);
      this.layoutControlItem4.Text = "Malzeme Adı";
      this.layoutControlItem4.TextSize = new Size(123, 18);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem6.Control = (Control) this.barkodTextEdit;
      this.layoutControlItem6.Location = new Point(0, 175);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(692, 24);
      this.layoutControlItem6.Text = "BarKod";
      this.layoutControlItem6.TextSize = new Size(123, 18);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem8.Control = (Control) this.grup1SluEdit;
      this.layoutControlItem8.Location = new Point(0, 225);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(345, 26);
      this.layoutControlItem8.Text = "Grup 1";
      this.layoutControlItem8.TextSize = new Size(123, 18);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem9.Control = (Control) this.grup2SluEdit;
      this.layoutControlItem9.Location = new Point(0, 251);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(345, 26);
      this.layoutControlItem9.Text = "Grup 2";
      this.layoutControlItem9.TextSize = new Size(123, 18);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem12.Control = (Control) this.rafNoTextEdit;
      this.layoutControlItem12.Location = new Point(0, 325);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(312, 24);
      this.layoutControlItem12.Text = "Raf No";
      this.layoutControlItem12.TextSize = new Size(123, 18);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem13.Control = (Control) this.gozNoTextEdit;
      this.layoutControlItem13.Location = new Point(0, 349);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(312, 24);
      this.layoutControlItem13.Text = "Göz No";
      this.layoutControlItem13.TextSize = new Size(123, 18);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem14.Control = (Control) this.kullanimYeriTextEdit;
      this.layoutControlItem14.Location = new Point(0, 373);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(692, 24);
      this.layoutControlItem14.Text = "Kullanım Yeri";
      this.layoutControlItem14.TextSize = new Size(123, 18);
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem1.Control = (Control) this.malzemeKodTextEdit;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.MinSize = new Size(151, 24);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(390, 79);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Malzeme Kod";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(130, 20);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem16.Control = (Control) this.kodVerButton;
      this.layoutControlItem16.Location = new Point(390, 0);
      this.layoutControlItem16.MinSize = new Size(42, 40);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(59, 79);
      this.layoutControlItem16.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem20.Control = (Control) this.seriNoComboEdit;
      this.layoutControlItem20.Location = new Point(353, 325);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.Size = new Size(339, 24);
      this.layoutControlItem20.Text = "Seri No Kontrolü";
      this.layoutControlItem20.TextSize = new Size(123, 18);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem7.Control = (Control) this.birimSluEdit;
      this.layoutControlItem7.Location = new Point(0, 199);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(345, 26);
      this.layoutControlItem7.Text = "Birim";
      this.layoutControlItem7.TextSize = new Size(123, 18);
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem21.Control = (Control) this.kiloMetreComboEdit;
      this.layoutControlItem21.Location = new Point(353, 349);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(339, 24);
      this.layoutControlItem21.Text = "Kilo Metre Konrolü";
      this.layoutControlItem21.TextSize = new Size(123, 18);
      this.layoutControlItem22.Control = (Control) this.bolumuEkleEdit;
      this.layoutControlItem22.Location = new Point(336, 277);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(27, 48);
      this.layoutControlItem22.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem22.TextSize = new Size(0, 0);
      this.layoutControlItem22.TextToControlDistance = 0;
      this.layoutControlItem22.TextVisible = false;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem19.Control = (Control) this.tarihComboEdit;
      this.layoutControlItem19.Location = new Point(363, 277);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(329, 48);
      this.layoutControlItem19.Text = "Tarih Kontrolü";
      this.layoutControlItem19.TextSize = new Size(123, 18);
      this.layoutControlItem23.Control = (Control) this.layoutControl2;
      this.layoutControlItem23.Location = new Point(312, 325);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(41, 24);
      this.layoutControlItem23.TextSize = new Size(0, 0);
      this.layoutControlItem23.TextVisible = false;
      this.layoutControlItem24.Control = (Control) this.layoutControl3;
      this.layoutControlItem24.Location = new Point(312, 349);
      this.layoutControlItem24.Name = "layoutControlItem24";
      this.layoutControlItem24.Size = new Size(41, 24);
      this.layoutControlItem24.TextSize = new Size(0, 0);
      this.layoutControlItem24.TextVisible = false;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem5.Control = (Control) this.digerAdiTextEdit;
      this.layoutControlItem5.Location = new Point(0, 151);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(692, 24);
      this.layoutControlItem5.Text = "Diğer Adı";
      this.layoutControlItem5.TextSize = new Size(123, 18);
      this.layoutControlItem26.Control = (Control) this.birimEkleButton;
      this.layoutControlItem26.Location = new Point(345, 199);
      this.layoutControlItem26.MinSize = new Size(26, 26);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.Size = new Size(44, 26);
      this.layoutControlItem26.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem26.TextSize = new Size(0, 0);
      this.layoutControlItem26.TextVisible = false;
      this.layoutControlItem27.Control = (Control) this.grup2EkleButton;
      this.layoutControlItem27.Location = new Point(345, 251);
      this.layoutControlItem27.MinSize = new Size(26, 26);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(44, 26);
      this.layoutControlItem27.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem27.TextSize = new Size(0, 0);
      this.layoutControlItem27.TextVisible = false;
      this.layoutControlItem25.Control = (Control) this.grup1EkleButton;
      this.layoutControlItem25.Location = new Point(345, 225);
      this.layoutControlItem25.MinSize = new Size(26, 26);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(44, 26);
      this.layoutControlItem25.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem25.TextSize = new Size(0, 0);
      this.layoutControlItem25.TextVisible = false;
      this.layoutControlItem28.Control = (Control) this.layoutControl4;
      this.layoutControlItem28.Location = new Point(389, 199);
      this.layoutControlItem28.Name = "layoutControlItem28";
      this.layoutControlItem28.Size = new Size(303, 26);
      this.layoutControlItem28.TextSize = new Size(0, 0);
      this.layoutControlItem28.TextVisible = false;
      this.layoutControlItem29.Control = (Control) this.layoutControl6;
      this.layoutControlItem29.Location = new Point(389, 225);
      this.layoutControlItem29.Name = "layoutControlItem29";
      this.layoutControlItem29.Size = new Size(303, 26);
      this.layoutControlItem29.TextSize = new Size(0, 0);
      this.layoutControlItem29.TextVisible = false;
      this.layoutControlItem30.Control = (Control) this.layoutControl7;
      this.layoutControlItem30.Location = new Point(389, 251);
      this.layoutControlItem30.Name = "layoutControlItem30";
      this.layoutControlItem30.Size = new Size(303, 26);
      this.layoutControlItem30.TextSize = new Size(0, 0);
      this.layoutControlItem30.TextVisible = false;
      this.layoutControlItem31.Control = (Control) this.layoutControl5;
      this.layoutControlItem31.Location = new Point(449, 0);
      this.layoutControlItem31.Name = "layoutControlItem31";
      this.layoutControlItem31.Size = new Size(243, 79);
      this.layoutControlItem31.TextSize = new Size(0, 0);
      this.layoutControlItem31.TextVisible = false;
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem11.Control = (Control) this.bolumLook;
      this.layoutControlItem11.Location = new Point(0, 277);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(336, 24);
      this.layoutControlItem11.Text = "Bölümü";
      this.layoutControlItem11.TextSize = new Size(123, 17);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem10.Control = (Control) this.KDVoranLook;
      this.layoutControlItem10.Location = new Point(0, 301);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(336, 24);
      this.layoutControlItem10.Text = "KDV Oran";
      this.layoutControlItem10.TextSize = new Size(123, 17);
      this.layoutControlItem15.Control = (Control) this.checkEdit11;
      this.layoutControlItem15.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem15.CustomizationFormText = "layoutControlItem15";
      this.layoutControlItem15.Location = new Point(0, 397);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(152, 28);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.cincik.AppearanceItemCaption.ForeColor = Color.Black;
      this.cincik.AppearanceItemCaption.Options.UseForeColor = true;
      this.cincik.Control = (Control) this.miktarTxtEdit;
      this.cincik.ControlAlignment = ContentAlignment.TopLeft;
      this.cincik.CustomizationFormText = "Miktar";
      this.cincik.Location = new Point(152, 397);
      this.cincik.Name = "cincik";
      this.cincik.Size = new Size(244, 28);
      this.cincik.Text = "Miktar";
      this.cincik.TextAlignMode = TextAlignModeItem.AutoSize;
      this.cincik.TextSize = new Size(29, 13);
      this.cincik.TextToControlDistance = 5;
      this.layoutControlItem18.AppearanceItemCaption.ForeColor = Color.Black;
      this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
      this.layoutControlItem18.Control = (Control) this.comboBoxEdit11;
      this.layoutControlItem18.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem18.CustomizationFormText = "Depo Adı";
      this.layoutControlItem18.Location = new Point(396, 397);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(296, 28);
      this.layoutControlItem18.Text = "Depo Adı";
      this.layoutControlItem18.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem18.TextSize = new Size(43, 13);
      this.layoutControlItem18.TextToControlDistance = 5;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUPTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUP2TableAdapter.ClearBeforeFill = true;
      this.tBLMALZBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.searchLookUpEdit1.EditValue = (object) "";
      this.searchLookUpEdit1.Location = new Point(97, 12);
      this.searchLookUpEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.DisplayMember = "KDVORAN";
      this.searchLookUpEdit1.Properties.ValueMember = "ID";
      this.searchLookUpEdit1.Size = new Size(695, 20);
      this.searchLookUpEdit1.TabIndex = 4;
      this.Appearance.BackColor = Color.FromArgb(224, 224, 224);
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(710, 537);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (malzemeGuncelle);
      this.Text = "Malzeme Ekle";
      this.Load += new EventHandler(this.malzemeEkle_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.KDVoranLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.bolumLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).EndInit();
      this.gridView3.EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.layoutControl7.EndInit();
      this.layoutControlGroup6.EndInit();
      this.layoutControl6.EndInit();
      this.layoutControlGroup5.EndInit();
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.kiloMetreComboEdit.Properties.EndInit();
      this.seriNoComboEdit.Properties.EndInit();
      this.tarihComboEdit.Properties.EndInit();
      this.malzemeKodTextEdit.Properties.EndInit();
      this.kullanimYeriTextEdit.Properties.EndInit();
      this.gozNoTextEdit.Properties.EndInit();
      this.rafNoTextEdit.Properties.EndInit();
      this.barkodTextEdit.Properties.EndInit();
      this.digerAdiTextEdit.Properties.EndInit();
      this.malzemeAdiTextEdit.Properties.EndInit();
      this.oemKodTextEdit.Properties.EndInit();
      this.ureticiKodTextEdit.Properties.EndInit();
      this.grup2SluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.grup1SluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).EndInit();
      this.gridView1.EndInit();
      this.birimSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.gridView2.EndInit();
      this.checkEdit11.Properties.EndInit();
      this.miktarTxtEdit.Properties.EndInit();
      this.comboBoxEdit11.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem24.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem28.EndInit();
      this.layoutControlItem29.EndInit();
      this.layoutControlItem30.EndInit();
      this.layoutControlItem31.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem15.EndInit();
      this.cincik.EndInit();
      this.layoutControlItem18.EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}