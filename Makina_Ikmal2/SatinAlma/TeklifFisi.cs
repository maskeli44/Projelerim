// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TeklifFisi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Win;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Popup;
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
using Makina_Ikmal.SatinAlma.TeklifRaporlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TeklifFisi : XtraForm
  {
    public int guncelID = 0;
    private int talepID = 0;
    public int secim = 0;
    private int refresh = 0;
    private MuayeneTutanagi1 yeniMuayene = new MuayeneTutanagi1();
    private TeklifTekArac yeniTeklifRapor = new TeklifTekArac();
    private TeklifTekCokArac yeniTeklifCokRapor = new TeklifTekCokArac();
    private AlimKarari1 yeniAlimKarariRapor = new AlimKarari1();
    private HizmetTeslim yeniHizmet = new HizmetTeslim();
    private bellEntities db = new bellEntities();
    private string[] firmalar = new string[8];
    private KullaniciSonId son = new KullaniciSonId();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem KayitBulButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private BarButtonItem teklifEkleButton;
    private BarButtonItem talepCikarButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup3;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private BarButtonItem duzenleButton;
    private RibbonPageGroup ribbonPageGroup6;
    private ComboBoxEdit atolyeBolumCombo;
    private TextEdit sakNoTxt;
    private DateEdit sakDateEdit;
    private TextEdit konusuTxt;
    private TextEdit fisKoduTxt;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControl layoutControl2;
    private SimpleButton simpleButton4;
    private SimpleButton simpleButton3;
    private SimpleButton simpleButton2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem9;
    private SimpleButton simpleButton11;
    private SimpleButton simpleButton21;
    private SimpleButton simpleButton31;
    private SimpleButton simpleButton41;
    private LayoutControlGroup Root1;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem17;
    private TextEdit olurIlgisiTxt;
    private LayoutControlItem layoutControlItem18;
    private TextEdit toplamTutarTxt;
    private TextEdit kdvTxt;
    private TextEdit tutarTxt;
    private TextEdit talepNoTxt;
    private TextEdit ftrNoTxt;
    private DateEdit ftrDateEdit;
    private DateEdit tarihDateEdit;
    private LayoutControlItem layoutControlItem;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem24;
    private SearchLookUpEdit firma6SluEdit;
    private GridView searchLookUpEdit6View;
    private SearchLookUpEdit firma5SluEdit;
    private GridView searchLookUpEdit5View;
    private SearchLookUpEdit firma4SluEdit;
    private GridView searchLookUpEdit4View;
    private SearchLookUpEdit firma3SluEdit;
    private GridView searchLookUpEdit3View;
    private SearchLookUpEdit firma2SluEdit;
    private GridView searchLookUpEdit2View;
    private SearchLookUpEdit firma1SluEdit;
    private GridView searchLookUpEdit1View;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem26;
    private LayoutControlItem layoutControlItem27;
    private LayoutControlItem layoutControlItem28;
    private LayoutControlItem layoutControlItem29;
    private LayoutControlItem layoutControlItem30;
    private SearchLookUpEdit mkBaskanSluEdit;
    private GridView searchLookUpEdit18View;
    private SearchLookUpEdit mkUye2;
    private GridView searchLookUpEdit17View;
    private SearchLookUpEdit mkUye1SluEdit;
    private GridView searchLookUpEdit16View;
    private SearchLookUpEdit paBaskanSluEdit;
    private GridView searchLookUpEdit15View;
    private SearchLookUpEdit paUye2SluEdit;
    private GridView searchLookUpEdit14View;
    private SearchLookUpEdit paUye1SluEdit;
    private GridView searchLookUpEdit13View;
    private SearchLookUpEdit satinAlmaSluEdit;
    private GridView searchLookUpEdit12View;
    private SearchLookUpEdit mudurSluEdit;
    private GridView searchLookUpEdit11View;
    private SearchLookUpEdit daireBaskaniSluEdit;
    private GridView searchLookUpEdit10View;
    private SearchLookUpEdit kznFirmaSluEdit;
    private GridView searchLookUpEdit9View;
    private SearchLookUpEdit firma8SluEdit;
    private GridView searchLookUpEdit8View;
    private SearchLookUpEdit firma7SluEdit;
    private GridView searchLookUpEdit7View;
    private LayoutControlItem layoutControlItem31;
    private LayoutControlItem layoutControlItem32;
    private LayoutControlItem layoutControlItem33;
    private LayoutControlItem layoutControlItem34;
    private LayoutControlItem layoutControlItem35;
    private LayoutControlItem layoutControlItem36;
    private LayoutControlItem layoutControlItem37;
    private LayoutControlItem layoutControlItem38;
    private LayoutControlItem layoutControlItem39;
    private LayoutControlItem layoutControlItem40;
    private LayoutControlItem layoutControlItem41;
    private LayoutControlItem layoutControlItem42;
    private SimpleButton simpleButton111;
    private LayoutControlItem layoutControlItem11;
    private BarEditItem barEditItem1;
    private BarSubItem raporlarButton;
    private BarButtonItem teklifRaporlariButton;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem alimKarariButton;
    private BarButtonItem barButtonItem11;
    private BarButtonItem muayeneButton;
    private BarButtonItem barButtonItem13;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private GridControl gridControl1;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem6;
    private GridControl gridControl3;
    private GridView gridView3;
    private GridControl gridControl2;
    private GridView gridView2;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLTEKLIFHRKTBindingSource;
    private TBLTEKLIFHRKTTableAdapter tBLTEKLIFHRKTTableAdapter;
    private RepositoryItemLookUpEdit plaka;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemLookUpEdit malzemeAd;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private RepositoryItemLookUpEdit malMbirim;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private RepositoryItemLookUpEdit firmaAd;
    private BindingSource tBLFIRMALARBindingSource;
    private TBLFIRMALARTableAdapter tBLFIRMALARTableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn gridColumn10;
    private GridColumn gridColumn9;
    private GridColumn gridColumn8;
    private GridColumn gridColumn7;
    private GridColumn gridColumn6;
    private GridColumn gridColumn5;
    private GridColumn gridColumn4;
    private GridColumn gridColumn3;
    private GridColumn gridColumn2;
    private GridColumn gridColumn1;
    private BindingSource dataTable1BindingSource;
    private BindingSource subeMuduruBindingSource;
    private subeMuduru subeMuduru;
    private Makina_Ikmal.Model.subeMuduruTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn gridColumn17;
    private GridColumn gridColumn16;
    private GridColumn gridColumn15;
    private GridColumn gridColumn14;
    private GridColumn gridColumn13;
    private GridColumn gridColumn12;
    private GridColumn gridColumn11;
    private BindingSource tBLTEKLIFIDARISARTBindingSource;
    private TBLTEKLIFIDARISARTTableAdapter tBLTEKLIFIDARISARTTableAdapter;
    private GridColumn colID;
    private GridColumn colTEKLIFID1;
    private GridColumn colSIRANO;
    private GridColumn colACIKLAMA;
    private BindingSource dataTable1BindingSource1;
    private TalepCekmeTeklifteGorunme talepCekmeTeklifteGorunme;
    private Makina_Ikmal.Model.TalepCekmeTeklifteGorunmeTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private GridColumn colID1;
    private GridColumn colARACID;
    private GridColumn colMARKA;
    private GridColumn colBIRIMFIYAT;
    private GridColumn colBIRIMID;
    private GridColumn colMALZEMEADI;
    private GridColumn colFIRMA1ID;
    private GridColumn colF1BIRIMFIYAT;
    private GridColumn colF1TUTAR;
    private GridColumn colFIRMA2ID;
    private GridColumn colF2BIRIMFIYAT;
    private GridColumn colF2TUTAR;
    private GridColumn colFIRMA3ID;
    private GridColumn colF3BIRIMFIYAT;
    private GridColumn colF3TUTAR;
    private GridColumn colFIRMA4ID;
    private GridColumn colF4BIRIMFIYAT;
    private GridColumn colF4TUTAR;
    private GridColumn colFIRMA5ID;
    private GridColumn colF5BIRIMFIYAT;
    private GridColumn colF5TUTAR;
    private GridColumn colFIRMA6ID;
    private GridColumn colF6BIRIMFIYAT;
    private GridColumn colF6TUTAR;
    private GridColumn colFIRMA7ID;
    private GridColumn colF7BIRIMFIYAT;
    private GridColumn colF7TUTAR;
    private GridColumn colFIRMA8ID;
    private GridColumn colF8BIRIMFIYAT;
    private GridColumn colF8TUTAR;
    private GridColumn colMALZEMEID;
    private GridColumn colTalepID;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colMIKTAR;
    private GridColumn colTUTAR;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private RepositoryItemMemoEdit repositoryItemMemoEdit1;
    private GridColumn colHRKTID;
    private GridColumn gridColumn18;
    private RepositoryItemTextEdit tutarMask;
    private GridColumn gridColumn19;

    public TeklifFisi() => this.InitializeComponent();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void raporlarButton_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 2 || this.secim == 4)
      {
        this.Duzenle();
        this.liste();
      }
      if (this.secim == 1)
      {
        this.Kaydet();
        this.liste();
      }
      if (this.secim == 3)
        this.Sil();
      ((TeklifListesi) Application.OpenForms["TeklifListesi"])?.Listele();
      ((TalepListesi) Application.OpenForms["TalepListesi"])?.listele();
    }

    private bool BoslukKontrol() => false;

    private void Kaydet()
    {
      int num1 = 0;
      if (this.gridView1.DataRowCount != 0)
      {
        this.fisKoduTxt.Text = this.son.teklifKod();
        try
        {
          TBLTEKLIF entity1 = new TBLTEKLIF();
          entity1.KOD = this.fisKoduTxt.Text;
          entity1.TEKLIFKONUSU = this.konusuTxt.Text;
          entity1.OLURILGISI = this.olurIlgisiTxt.Text;
          if (this.sakNoTxt.Text != "")
            entity1.SAKARARTARIHI = new DateTime?(this.sakDateEdit.DateTime);
          if (this.sakNoTxt.Text != "")
            entity1.SAKARARNO = new int?(Convert.ToInt32(this.sakNoTxt.Text));
          if (this.tarihDateEdit.Text != "")
            entity1.TARIH = new DateTime?(this.tarihDateEdit.DateTime);
          entity1.AITOLDBIRIM = new int?(Convert.ToInt32(this.atolyeBolumCombo.SelectedIndex));
          if (this.ftrDateEdit.Text != "")
            entity1.FATURATARIHI = new DateTime?(this.ftrDateEdit.DateTime);
          if (this.ftrNoTxt.Text != "")
            entity1.FATURANO = this.ftrNoTxt.Text;
          if (this.tutarTxt.Text != "")
            entity1.FATURATUTAR = new Decimal?(Convert.ToDecimal(this.tutarTxt.Text));
          if (this.kdvTxt.Text != "")
            entity1.KDVTUTAR = new Decimal?(Convert.ToDecimal(this.kdvTxt.Text));
          if (this.toplamTutarTxt.Text != "")
            entity1.TOPLAMTUTAR = new Decimal?(Convert.ToDecimal(this.toplamTutarTxt.Text));
          entity1.FIRMA1ID = new int?(Convert.ToInt32(this.firma1SluEdit.EditValue));
          entity1.FIRMA2ID = new int?(Convert.ToInt32(this.firma2SluEdit.EditValue));
          entity1.FIRMA3ID = new int?(Convert.ToInt32(this.firma3SluEdit.EditValue));
          entity1.FIRMA4ID = new int?(Convert.ToInt32(this.firma4SluEdit.EditValue));
          entity1.FIRMA5ID = new int?(Convert.ToInt32(this.firma5SluEdit.EditValue));
          entity1.FIRMA6ID = new int?(Convert.ToInt32(this.firma6SluEdit.EditValue));
          entity1.FIRMA7ID = new int?(Convert.ToInt32(this.firma7SluEdit.EditValue));
          entity1.FIRMA8ID = new int?(Convert.ToInt32(this.firma8SluEdit.EditValue));
          entity1.KAZANANFIRMAID = Convert.ToString(this.kznFirmaSluEdit.EditValue);
          entity1.DAIREBSKID = new int?(Convert.ToInt32(this.daireBaskaniSluEdit.EditValue));
          entity1.IMZAMUDURID = new int?(Convert.ToInt32(this.mudurSluEdit.EditValue));
          entity1.PIYASAUYE1ID = new int?(Convert.ToInt32(this.paUye1SluEdit.EditValue));
          entity1.PIYASAUYE2ID = new int?(Convert.ToInt32(this.paUye2SluEdit.EditValue));
          entity1.PIYASABSKID = new int?(Convert.ToInt32(this.paBaskanSluEdit.EditValue));
          entity1.KOMUYE1ID = new int?(Convert.ToInt32(this.mkUye1SluEdit.EditValue));
          entity1.KOMUYE2ID = new int?(Convert.ToInt32(this.mkUye2.EditValue));
          entity1.KOMBSKID = new int?(Convert.ToInt32(this.mkBaskanSluEdit.EditValue));
          entity1.TALEPID = new int?(this.talepID);
          this.db.TBLTEKLIF.Add(entity1);
          this.db.SaveChanges();
          TBLTEKLIFHRKT entity2 = new TBLTEKLIFHRKT();
          num1 = int.Parse(this.db.TBLTEKLIF.OrderByDescending<TBLTEKLIF, int>((Expression<System.Func<TBLTEKLIF, int>>) (p => p.ID)).Select<TBLTEKLIF, int>((Expression<System.Func<TBLTEKLIF, int>>) (r => r.ID)).First<int>().ToString());
          YetkiClass.secim_id = num1;
          this.guncelID = num1;
          for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
          {
            entity2.TEKLIFID = new int?(num1);
            if (this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA").ToString() != "")
              entity2.MALZACIKLAMA = this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA").ToString();
            entity2.MALZEMEID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colMALZEMEID)));
            entity2.MIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colMIKTAR)));
            entity2.TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colTUTAR)));
            entity2.ARACID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colARACID)));
            entity2.BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMFIYAT)));
            entity2.BIRIMID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMID)));
            entity2.F1BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1BIRIMFIYAT)));
            entity2.F1TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1TUTAR)));
            entity2.FIRMA1ID = new int?(Convert.ToInt32(this.firma1SluEdit.EditValue));
            entity2.F2BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2BIRIMFIYAT)));
            entity2.F2TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2TUTAR)));
            entity2.FIRMA2ID = new int?(Convert.ToInt32(this.firma2SluEdit.EditValue));
            entity2.F3BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3BIRIMFIYAT)));
            entity2.F3TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3TUTAR)));
            entity2.FIRMA3ID = new int?(Convert.ToInt32(this.firma3SluEdit.EditValue));
            entity2.F4BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4BIRIMFIYAT)));
            entity2.F4TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4TUTAR)));
            entity2.FIRMA4ID = new int?(Convert.ToInt32(this.firma4SluEdit.EditValue));
            entity2.F5BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            entity2.F5TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            entity2.FIRMA5ID = new int?(Convert.ToInt32(this.firma5SluEdit.EditValue));
            entity2.F6BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6BIRIMFIYAT)));
            entity2.F6TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6TUTAR)));
            entity2.FIRMA6ID = new int?(Convert.ToInt32(this.firma6SluEdit.EditValue));
            entity2.F7BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7BIRIMFIYAT)));
            entity2.F7TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7TUTAR)));
            entity2.FIRMA7ID = new int?(Convert.ToInt32(this.firma7SluEdit.EditValue));
            entity2.F8BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8BIRIMFIYAT)));
            entity2.F8TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8TUTAR)));
            entity2.FIRMA8ID = new int?(Convert.ToInt32(this.firma8SluEdit.EditValue));
            this.db.TBLTEKLIFHRKT.Add(entity2);
            this.db.SaveChanges();
            this.guncelID = num1;
          }
          this.secim = 2;
          int num2 = (int) XtraMessageBox.Show("Veriler Başarı İle Kaydedildi");
        }
        catch (Exception ex)
        {
          int num3 = (int) XtraMessageBox.Show("Veri tabanı ile ilgili hata oluştu");
          int num4 = (int) XtraMessageBox.Show(ex.ToString());
        }
        try
        {
          this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.talepID)).TEKLIFID = new int?(num1);
          this.db.SaveChanges();
        }
        catch
        {
        }
      }
      else
      {
        int num5 = (int) XtraMessageBox.Show("Talebi Olmayan Teklifler Kaydedilemez");
      }
    }

    private void Duzenle()
    {
      if (this.fisKoduTxt.Text == null)
        return;
      TBLTEKLIF tblteklif = this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID));
      try
      {
        tblteklif.TEKLIFKONUSU = this.konusuTxt.Text;
        tblteklif.OLURILGISI = this.olurIlgisiTxt.Text;
        if (this.sakNoTxt.Text != "")
          tblteklif.SAKARARTARIHI = new DateTime?(this.sakDateEdit.DateTime);
        if (this.sakNoTxt.Text != "")
          tblteklif.SAKARARNO = new int?(Convert.ToInt32(this.sakNoTxt.Text));
        if (this.tarihDateEdit.Text != "")
          tblteklif.TARIH = new DateTime?(this.tarihDateEdit.DateTime);
        tblteklif.AITOLDBIRIM = new int?(Convert.ToInt32(this.atolyeBolumCombo.SelectedIndex));
        if (this.ftrDateEdit.Text != "")
          tblteklif.FATURATARIHI = new DateTime?(this.ftrDateEdit.DateTime);
        if (this.ftrNoTxt.Text != "")
          tblteklif.FATURANO = this.ftrNoTxt.Text;
        if (this.tutarTxt.Text != "")
          tblteklif.FATURATUTAR = new Decimal?(Convert.ToDecimal(this.tutarTxt.Text));
        if (this.kdvTxt.Text != "")
          tblteklif.KDVTUTAR = new Decimal?(Convert.ToDecimal(this.kdvTxt.Text));
        if (this.toplamTutarTxt.Text != "")
          tblteklif.TOPLAMTUTAR = new Decimal?(Convert.ToDecimal(this.toplamTutarTxt.Text));
        tblteklif.FIRMA1ID = new int?(Convert.ToInt32(this.firma1SluEdit.EditValue));
        tblteklif.FIRMA2ID = new int?(Convert.ToInt32(this.firma2SluEdit.EditValue));
        tblteklif.FIRMA3ID = new int?(Convert.ToInt32(this.firma3SluEdit.EditValue));
        tblteklif.FIRMA4ID = new int?(Convert.ToInt32(this.firma4SluEdit.EditValue));
        tblteklif.FIRMA5ID = new int?(Convert.ToInt32(this.firma5SluEdit.EditValue));
        tblteklif.FIRMA6ID = new int?(Convert.ToInt32(this.firma6SluEdit.EditValue));
        tblteklif.FIRMA7ID = new int?(Convert.ToInt32(this.firma7SluEdit.EditValue));
        tblteklif.FIRMA8ID = new int?(Convert.ToInt32(this.firma8SluEdit.EditValue));
        tblteklif.KAZANANFIRMAID = Convert.ToString(this.kznFirmaSluEdit.EditValue);
        tblteklif.DAIREBSKID = new int?(Convert.ToInt32(this.daireBaskaniSluEdit.EditValue));
        tblteklif.IMZAMUDURID = new int?(Convert.ToInt32(this.mudurSluEdit.EditValue));
        tblteklif.PIYASAUYE1ID = new int?(Convert.ToInt32(this.paUye1SluEdit.EditValue));
        tblteklif.PIYASAUYE2ID = new int?(Convert.ToInt32(this.paUye2SluEdit.EditValue));
        tblteklif.PIYASABSKID = new int?(Convert.ToInt32(this.paBaskanSluEdit.EditValue));
        tblteklif.KOMUYE1ID = new int?(Convert.ToInt32(this.mkUye1SluEdit.EditValue));
        tblteklif.KOMUYE2ID = new int?(Convert.ToInt32(this.mkUye2.EditValue));
        tblteklif.KOMBSKID = new int?(Convert.ToInt32(this.mkBaskanSluEdit.EditValue));
        tblteklif.TALEPID = new int?(this.talepID);
        this.db.SaveChanges();
        for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
        {
          string str = "";
          int hareketID = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
          try
          {
            str = this.db.TBLTEKLIFHRKT.FirstOrDefault<TBLTEKLIFHRKT>((Expression<System.Func<TBLTEKLIFHRKT, bool>>) (x => x.ID == hareketID)).TEKLIFID.ToString();
          }
          catch (Exception ex)
          {
          }
          if (str != "")
          {
            TBLTEKLIFHRKT tblteklifhrkt = this.db.TBLTEKLIFHRKT.FirstOrDefault<TBLTEKLIFHRKT>((Expression<System.Func<TBLTEKLIFHRKT, bool>>) (x => x.ID == hareketID));
            try
            {
              tblteklifhrkt.MALZACIKLAMA = this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA").ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
              tblteklifhrkt.MALZEMEID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colMALZEMEID)));
            }
            catch (Exception ex)
            {
            }
            try
            {
              tblteklifhrkt.MIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colMIKTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colTUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.ARACID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colARACID)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.BIRIMID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMID)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F1BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F1TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA1ID = new int?(Convert.ToInt32(this.firma1SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F2BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F2TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA2ID = new int?(Convert.ToInt32(this.firma2SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F3BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F3TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA3ID = new int?(Convert.ToInt32(this.firma3SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F4BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F4TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA4ID = new int?(Convert.ToInt32(this.firma4SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F5BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F5TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA5ID = new int?(Convert.ToInt32(this.firma5SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F6BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F6TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA6ID = new int?(Convert.ToInt32(this.firma6SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F7BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F7TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA7ID = new int?(Convert.ToInt32(this.firma7SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F8BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.F8TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8TUTAR)));
            }
            catch
            {
            }
            try
            {
              tblteklifhrkt.FIRMA8ID = new int?(Convert.ToInt32(this.firma8SluEdit.EditValue));
            }
            catch
            {
            }
            this.db.SaveChanges();
          }
          else if (str == "0" || str == "")
          {
            TBLTEKLIFHRKT entity = new TBLTEKLIFHRKT();
            entity.TEKLIFID = new int?(this.guncelID);
            try
            {
              entity.MALZACIKLAMA = this.gridView1.GetRowCellValue(rowHandle, "MALZACIKLAMA").ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
              entity.MALZEMEID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colMALZEMEID)));
            }
            catch (Exception ex)
            {
            }
            try
            {
              entity.MIKTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colMIKTAR)));
            }
            catch
            {
            }
            try
            {
              entity.TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colTUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.ARACID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colARACID)));
            }
            catch
            {
            }
            try
            {
              entity.BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.BIRIMID = new int?(Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, this.colBIRIMID)));
            }
            catch
            {
            }
            try
            {
              entity.F1BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F1TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF1TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA1ID = new int?(Convert.ToInt32(this.firma1SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F2BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F2TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF2TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA2ID = new int?(Convert.ToInt32(this.firma2SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F3BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F3TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF3TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA3ID = new int?(Convert.ToInt32(this.firma3SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F4BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F4TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF4TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA4ID = new int?(Convert.ToInt32(this.firma4SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F5BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F5TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF5BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA5ID = new int?(Convert.ToInt32(this.firma5SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F6BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F6TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF6TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA6ID = new int?(Convert.ToInt32(this.firma6SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F7BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F7TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF7TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA7ID = new int?(Convert.ToInt32(this.firma7SluEdit.EditValue));
            }
            catch
            {
            }
            try
            {
              entity.F8BIRIMFIYAT = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8BIRIMFIYAT)));
            }
            catch
            {
            }
            try
            {
              entity.F8TUTAR = new Decimal?(Convert.ToDecimal(this.gridView1.GetRowCellValue(rowHandle, this.colF8TUTAR)));
            }
            catch
            {
            }
            try
            {
              entity.FIRMA8ID = new int?(Convert.ToInt32(this.firma8SluEdit.EditValue));
            }
            catch
            {
            }
            this.db.TBLTEKLIFHRKT.Add(entity);
            this.db.SaveChanges();
          }
        }
        try
        {
          this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.talepID)).TEKLIFID = new int?(this.guncelID);
          this.db.SaveChanges();
        }
        catch (Exception ex)
        {
        }
        int num = (int) XtraMessageBox.Show("Veriler Başarı İle Kaydedildi");
      }
      catch (Exception ex)
      {
        int num1 = (int) XtraMessageBox.Show("Veri tabanı ile ilgili hata oluştu");
        int num2 = (int) XtraMessageBox.Show(ex.ToString());
      }
      int num3;
      if (tblteklif.FATURANO != "" && tblteklif.FATURATARIHI.HasValue)
      {
        Decimal? kdvtutar = tblteklif.KDVTUTAR;
        Decimal num4 = 0M;
        if (!(kdvtutar.GetValueOrDefault() == num4 & kdvtutar.HasValue))
        {
          int? nullable = tblteklif.KOMBSKID;
          int num5 = 0;
          if (!(nullable.GetValueOrDefault() == num5 & nullable.HasValue))
          {
            nullable = tblteklif.KOMUYE1ID;
            int num6 = 0;
            if (!(nullable.GetValueOrDefault() == num6 & nullable.HasValue))
            {
              nullable = tblteklif.KOMUYE2ID;
              int num7 = 0;
              num3 = !(nullable.GetValueOrDefault() == num7 & nullable.HasValue) ? 1 : 0;
              goto label_224;
            }
          }
        }
      }
      num3 = 0;
label_224:
      if (num3 != 0)
      {
        tblteklif.KESINLESTIR = "1";
        this.secim = 4;
        this.db.SaveChanges();
      }
      else
      {
        tblteklif.KESINLESTIR = "0";
        this.secim = 2;
        this.db.SaveChanges();
      }
    }

    private void Sil()
    {
      if (this.secim == 4)
        return;
      if (this.guncelID != 0)
      {
        try
        {
          try
          {
            this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.TEKLIFID == (int?) this.guncelID)).TEKLIFID = new int?(0);
            for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
            {
              int getirID = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
              this.db.TBLTEKLIFHRKT.Remove(this.db.TBLTEKLIFHRKT.FirstOrDefault<TBLTEKLIFHRKT>((Expression<System.Func<TBLTEKLIFHRKT, bool>>) (x => x.ID == getirID)));
            }
            this.db.SaveChanges();
          }
          catch
          {
          }
          this.db.TBLTEKLIF.Remove(this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID)));
          this.db.SaveChanges();
          this.Close();
        }
        catch (Exception ex)
        {
          int num1 = (int) XtraMessageBox.Show("Veritabanı Hatası");
          int num2 = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
    }

    public void Getir(int gecerliID)
    {
      this.guncelID = gecerliID;
      try
      {
        TBLTEKLIF ise = this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID));
        this.fisKoduTxt.Text = ise.KOD;
        this.konusuTxt.Text = ise.TEKLIFKONUSU;
        this.olurIlgisiTxt.Text = ise.OLURILGISI;
        this.sakDateEdit.DateTime = Convert.ToDateTime((object) ise.SAKARARTARIHI);
        this.sakNoTxt.Text = ise.SAKARARNO.ToString();
        this.atolyeBolumCombo.SelectedIndex = Convert.ToInt32((object) ise.AITOLDBIRIM);
        this.ftrDateEdit.DateTime = Convert.ToDateTime((object) ise.FATURATARIHI);
        this.ftrNoTxt.Text = ise.FATURANO;
        this.tarihDateEdit.DateTime = Convert.ToDateTime((object) ise.TARIH);
        this.talepNoTxt.Text = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => (int?) x.ID == ise.TALEPID)).KOD;
        this.tutarTxt.Text = ise.FATURATUTAR.ToString();
        this.kdvTxt.Text = ise.KDVTUTAR.ToString();
        this.toplamTutarTxt.Text = ise.TOPLAMTUTAR.ToString();
        this.firma1SluEdit.EditValue = (object) ise.FIRMA1ID;
        this.firma2SluEdit.EditValue = (object) ise.FIRMA2ID;
        this.firma3SluEdit.EditValue = (object) ise.FIRMA3ID;
        this.firma4SluEdit.EditValue = (object) ise.FIRMA4ID;
        this.firma5SluEdit.EditValue = (object) ise.FIRMA5ID;
        this.firma6SluEdit.EditValue = (object) ise.FIRMA6ID;
        this.firma7SluEdit.EditValue = (object) ise.FIRMA7ID;
        this.firma8SluEdit.EditValue = (object) ise.FIRMA8ID;
        this.kznFirmaSluEdit.EditValue = (object) ise.KAZANANFIRMAID;
        this.daireBaskaniSluEdit.EditValue = (object) ise.DAIREBSKID;
        this.mudurSluEdit.EditValue = (object) ise.IMZAMUDURID;
        this.paUye1SluEdit.EditValue = (object) ise.PIYASAUYE1ID;
        this.paUye2SluEdit.EditValue = (object) ise.PIYASAUYE2ID;
        this.paBaskanSluEdit.EditValue = (object) ise.PIYASABSKID;
        this.mkUye1SluEdit.EditValue = (object) ise.KOMUYE1ID;
        this.mkUye2.EditValue = (object) ise.KOMUYE2ID;
        this.mkBaskanSluEdit.EditValue = (object) ise.KOMBSKID;
        this.talepID = Convert.ToInt32((object) ise.TALEPID);
      }
      catch
      {
      }
    }

    private void simpleButton2_Click(object sender, EventArgs e) => this.gridView2.AddNewRow();

    private void TeklifFisi_Load(object sender, EventArgs e)
    {
      this.fisKoduTxt.Enabled = false;
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLFIRMALARTableAdapter.Fill(this.bellDataSet5.TBLFIRMALAR);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet5.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet5.TBLMALZEMELER);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      this.tBLTEKLIFHRKTTableAdapter.Fill(this.bellDataSet5.TBLTEKLIFHRKT);
      try
      {
        this.SartnameGelen();
      }
      catch (Exception ex)
      {
      }
      if (this.secim == 1)
        this.tarihDateEdit.DateTime = DateTime.Now;
      this.konusuTxt.Text = "Mal Alımı";
      this.olurIlgisiTxt.Text = "01.01.2022 Tarih ve E. 0000 Sayılı Yazısı";
      this.firma1SluEdit.EditValue = (object) 0;
      this.firma2SluEdit.EditValue = (object) 0;
      this.firma3SluEdit.EditValue = (object) 0;
      this.firma4SluEdit.EditValue = (object) 0;
      this.firma5SluEdit.EditValue = (object) 0;
      this.firma6SluEdit.EditValue = (object) 0;
      this.firma7SluEdit.EditValue = (object) 0;
      this.firma8SluEdit.EditValue = (object) 0;
      this.mudurSluEdit.EditValue = (object) 1180;
      this.daireBaskaniSluEdit.EditValue = (object) 196;
      this.kznFirmaSluEdit.EditValue = (object) 0;
      this.paUye1SluEdit.EditValue = (object) 0;
      this.paUye2SluEdit.EditValue = (object) 0;
      this.paBaskanSluEdit.EditValue = (object) 0;
      this.mkUye1SluEdit.EditValue = (object) 0;
      this.mkUye2.EditValue = (object) 0;
      this.mkBaskanSluEdit.EditValue = (object) 0;
      this.refresh = YetkiClass.secim_id;
      if (this.secim == 1)
        return;
      this.liste();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void teklifEkleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 2)
      {
        if (this.gridView1.DataRowCount > 0)
        {
          int num = (int) XtraMessageBox.Show("Bir Teklife bir talep eklenebilir...");
        }
        else
          new TalepeEkle().Show();
      }
      if (this.secim != 1)
        return;
      new TalepeEkle().Show();
      this.gridControl1.DataSource = (object) null;
    }

    public void liste2(int gelenTalepID)
    {
      this.talepID = gelenTalepID;
      this.gridControl1.DataSource = (object) this.db.TBLTALEPHRKT.Join((IEnumerable<TBLTALEPFIS>) this.db.TBLTALEPFIS, (Expression<System.Func<TBLTALEPHRKT, int?>>) (hd => hd.TALEPFISID), (Expression<System.Func<TBLTALEPFIS, int?>>) (ht => (int?) ht.ID), (hd, ht) => new
      {
        hd = hd,
        ht = ht
      }).Join((IEnumerable<TBLTALEP>) this.db.TBLTALEP, data => data.ht.TALEPKAYITID, (Expression<System.Func<TBLTALEP, int?>>) (hy => (int?) hy.ID), (data, hy) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        hy = hy
      }).Join((IEnumerable<TBLISEMRI>) this.db.TBLISEMRI, data => data.\u003C\u003Eh__TransparentIdentifier0.ht.ISEMRIID, (Expression<System.Func<TBLISEMRI, int?>>) (hx => (int?) hx.ID), (data, hx) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        hx = hx
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TALEPID == (int?) YetkiClass.secim_id).Select(data => new
      {
        ARACID = data.hx.ARACID,
        MALZEMEID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MALZEMEID,
        MALZACIKLAMA = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MALZACIKLAMA,
        BIRIMID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.BIRIMID,
        MIKTAR = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MIKTAR,
        FIYAT = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.FIYAT,
        TUTAR = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TUTAR,
        KOD = data.\u003C\u003Eh__TransparentIdentifier1.hy.KOD,
        ID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ID
      }).OrderBy(x => x.ID).ToList();
      this.talepNoTxt.Text = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == YetkiClass.secim_id)).KOD;
    }

    public void liste()
    {
      try
      {
        this.gridControl1.DataSource = (object) this.db.TBLTEKLIFHRKT.Where<TBLTEKLIFHRKT>((Expression<System.Func<TBLTEKLIFHRKT, bool>>) (d => d.TEKLIFID == (int?) this.guncelID)).OrderBy<TBLTEKLIFHRKT, int>((Expression<System.Func<TBLTEKLIFHRKT, int>>) (x => x.ID)).ToList<TBLTEKLIFHRKT>();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 3)
        this.Sil();
      ((TeklifListesi) Application.OpenForms["TeklifListesi"])?.Listele();
    }

    private void duzenleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 2)
      {
        int num1 = (int) XtraMessageBox.Show("Teklif Fişi Düzenleme Modundadır");
      }
      else
      {
        try
        {
          if (Convert.ToInt32((object) this.db.TBLTEKLIF.Where<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID)).Select<TBLTEKLIF, int>((Expression<System.Func<TBLTEKLIF, int>>) (x => x.ID))) != 0)
          {
            int num2 = (int) XtraMessageBox.Show("Teklif Fişi Düzenleme Modundadır");
          }
          else
          {
            int num3 = (int) XtraMessageBox.Show("Teklif Kayıtlı Olmalıdır.");
          }
        }
        catch
        {
          int num4 = (int) XtraMessageBox.Show("Teklif Kayıtlı Olmalıdır.");
        }
      }
    }

    private void simpleButton111_Click(object sender, EventArgs e)
    {
      if (this.guncelID != 0)
      {
        int num = (int) new IdariSartname()
        {
          teklifID = this.guncelID
        }.ShowDialog();
        this.secim = 2;
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Teklif Kaydedilmelidir");
      }
    }

    private void gridView1_Click(object sender, EventArgs e) => this.SartnameGelen();

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      TBLTEKLIFIDARISART entity = new TBLTEKLIFIDARISART();
      ParameterExpression parameterExpression;
      // ISSUE: method reference
      int num1 = this.db.TBLTEKLIFIDARISART.Where<TBLTEKLIFIDARISART>(Expression.Lambda<System.Func<TBLTEKLIFIDARISART, bool>>((Expression) Expression.Equal(x.TEKLIFID, (Expression) Expression.Call(this.guncelID, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.ToString)), Array.Empty<Expression>())), parameterExpression)).Count<TBLTEKLIFIDARISART>();
      if (this.guncelID == 0)
        return;
      try
      {
        this.db.TAHARACTIPI.ToList<TAHARACTIPI>();
        for (int rowHandle = num1; rowHandle < this.gridControl2.MainView.DataRowCount; ++rowHandle)
        {
          int num2 = num1 + 1;
          entity.TEKLIFID = this.guncelID.ToString();
          entity.SIRANO = num2.ToString();
          entity.ACIKLAMA = this.gridView2.GetRowCellValue(rowHandle, this.colACIKLAMA).ToString();
          this.db.TBLTEKLIFIDARISART.Add(entity);
          this.db.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        int num3 = (int) XtraMessageBox.Show(ex.ToString());
        Console.WriteLine(ex.ToString());
      }
      this.tBLTEKLIFIDARISARTTableAdapter.FillBy(this.bellDataSet5.TBLTEKLIFIDARISART, this.guncelID.ToString());
    }

    private void simpleButton4_Click(object sender, EventArgs e)
    {
      int rowID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      TBLTEKLIFIDARISART entity = this.db.TBLTEKLIFIDARISART.FirstOrDefault<TBLTEKLIFIDARISART>((Expression<System.Func<TBLTEKLIFIDARISART, bool>>) (x => x.ID == rowID));
      if (entity != null)
        this.db.TBLTEKLIFIDARISART.Remove(entity);
      this.db.SaveChanges();
      this.SartnameGelen();
    }

    public void SartnameGelen()
    {
      this.repositoryItemMemoEdit1.MaxLength = 1000;
      string sor = this.guncelID.ToString();
      this.gridControl2.DataSource = (object) this.db.TBLTEKLIFIDARISART.Where<TBLTEKLIFIDARISART>((Expression<System.Func<TBLTEKLIFIDARISART, bool>>) (hd => hd.TEKLIFID == sor)).ToList<TBLTEKLIFIDARISART>();
    }

    private void muayeneButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim != 2 && this.secim != 4)
        return;
      this.yeniMuayene.Parameters["teklifID"].Value = (object) this.guncelID;
      this.yeniMuayene.Parameters["teklifID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniMuayene).ShowPreviewDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniTeklifCokRapor.Parameters["teklifID"].Value = (object) 0;
        this.yeniTeklifCokRapor.Parameters["teklifID"].Visible = false;
        this.yeniTeklifCokRapor.Parameters["talepID"].Value = (object) 0;
        this.yeniTeklifCokRapor.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniTeklifCokRapor).ShowPreviewDialog();
      }
      if (this.secim != 2 && this.secim != 4)
        return;
      this.yeniTeklifCokRapor.Parameters["teklifID"].Value = (object) this.guncelID;
      this.yeniTeklifCokRapor.Parameters["teklifID"].Visible = false;
      this.yeniTeklifCokRapor.Parameters["talepID"].Value = (object) this.talepID;
      this.yeniTeklifCokRapor.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniTeklifCokRapor).ShowPreviewDialog();
    }

    private void teklifRaporlariButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniTeklifRapor.Parameters["teklifID"].Value = (object) 0;
        this.yeniTeklifRapor.Parameters["teklifID"].Visible = false;
        this.yeniTeklifRapor.Parameters["talepID"].Value = (object) 0;
        this.yeniTeklifRapor.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniTeklifRapor).ShowPreviewDialog();
      }
      if (this.secim != 2 && this.secim != 4)
        return;
      this.yeniTeklifRapor.Parameters["teklifID"].Value = (object) this.guncelID;
      this.yeniTeklifRapor.Parameters["teklifID"].Visible = false;
      this.yeniTeklifRapor.Parameters["talepID"].Value = (object) this.talepID;
      this.yeniTeklifRapor.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniTeklifRapor).ShowPreviewDialog();
    }

    private void alimKarariButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1 || this.secim == 4)
      {
        this.yeniAlimKarariRapor.Parameters["teklifID"].Value = (object) 0;
        this.yeniAlimKarariRapor.Parameters["teklifID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniAlimKarariRapor).ShowPreviewDialog();
      }
      if (this.secim != 2 && this.secim != 4)
        return;
      string str = new KullaniciSonId().paratoyazi(Convert.ToDecimal((object) this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID)).FATURATUTAR));
      this.yeniAlimKarariRapor.Parameters["teklifID"].Value = (object) this.guncelID;
      this.yeniAlimKarariRapor.Parameters["teklifID"].Visible = false;
      this.yeniAlimKarariRapor.Parameters["yaziyla"].Value = (object) str;
      this.yeniAlimKarariRapor.Parameters["yaziyla"].Visible = false;
      new ReportPrintTool((IReport) this.yeniAlimKarariRapor).ShowPreviewDialog();
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      new TeklifFisi().Show();
      this.Close();
    }

    private void talepCikarButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Talep Çıkarılacaktır", "Talep Çıkar", MessageBoxButtons.YesNo))
        return;
      this.TalepCikar();
    }

    private void TalepCikar()
    {
      int silinecekFis = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (this.guncelID == 0 || this.secim == 4)
        return;
      try
      {
        this.db.TBLTEKLIF.FirstOrDefault<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (x => x.ID == this.guncelID)).TALEPID = new int?(0);
        this.db.SaveChanges();
        for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
        {
          int silinecek2 = Convert.ToInt32(this.gridView1.GetRowCellValue(rowHandle, "ID"));
          TBLTEKLIFHRKT entity = this.db.TBLTEKLIFHRKT.FirstOrDefault<TBLTEKLIFHRKT>((Expression<System.Func<TBLTEKLIFHRKT, bool>>) (x => x.ID == silinecek2));
          this.db.TBLTEKLIFHRKT.Remove(entity);
          this.db.SaveChanges();
          silinecekFis = Convert.ToInt32((object) entity.TEKLIFID);
        }
        this.db.SaveChanges();
        IQueryable<TBLTALEP> source = this.db.TBLTALEP.Where<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (hd => hd.TEKLIFID == (int?) silinecekFis));
        if (source.Count<TBLTALEP>() > 0)
        {
          foreach (TBLTALEP tbltalep in (IEnumerable<TBLTALEP>) source)
            tbltalep.TEKLIFID = new int?(0);
          this.db.SaveChanges();
        }
        this.gridControl1.DataSource = (object) null;
        int num = (int) XtraMessageBox.Show("fiş silme işlemi gerçekleşmiştir");
        this.Close();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
        Console.WriteLine(ex.ToString());
      }
    }

    private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      if (e.Column.FieldName == "FIYAT")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "FIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "TUTAR", (object) num);
      }
      else if (e.Column.FieldName == "MIKTAR")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "FIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "TUTAR", (object) num);
      }
      else if (e.Column.FieldName == "F1BIRIMFIYAT")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "F1BIRIMFIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "F1TUTAR", (object) num);
      }
      else if (e.Column.FieldName == "F2BIRIMFIYAT")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "F2BIRIMFIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "F2TUTAR", (object) num);
      }
      else if (e.Column.FieldName == "F3BIRIMFIYAT")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "F3BIRIMFIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "F3TUTAR", (object) num);
      }
      else if (e.Column.FieldName == "F4BIRIMFIYAT")
      {
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "F4BIRIMFIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "F4TUTAR", (object) num);
      }
      else
      {
        if (!(e.Column.FieldName == "F5BIRIMFIYAT"))
          return;
        GridView gridView = sender as GridView;
        Decimal num = Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "F5BIRIMFIYAT")) * Convert.ToDecimal(this.gridView1.GetRowCellValue(e.RowHandle, "MIKTAR"));
        this.gridView1.SetRowCellValue(e.RowHandle, "F5TUTAR", (object) num);
      }
    }

    private void gridView1_CustomColumnDisplayText(
      object sender,
      CustomColumnDisplayTextEventArgs e)
    {
      if (!(e.Column.Caption == "S. No"))
        return;
      e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniHizmet.Parameters["teklifID"].Value = (object) 0;
        this.yeniHizmet.Parameters["teklifID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniTeklifRapor).ShowPreviewDialog();
      }
      if (this.secim != 2 && this.secim != 4)
        return;
      this.yeniHizmet.Parameters["teklifID"].Value = (object) this.guncelID;
      this.yeniHizmet.Parameters["teklifID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniHizmet).ShowPreviewDialog();
    }

    private void Firmagetir(object sender, AddNewValueEventArgs e, int i)
    {
      string text = ((sender as IPopupControl).PopupWindow as PopupSearchLookUpEditForm).Controls.Find("teFind", true)[0].Text;
      this.firmalar[i] = text;
    }

    private void firma1SluEdit_Properties_AddNewValue(object sender, AddNewValueEventArgs e) => this.Firmagetir(sender, e, 0);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TeklifFisi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.KayitBulButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.teklifEkleButton = new BarButtonItem();
      this.talepCikarButton = new BarButtonItem();
      this.duzenleButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.raporlarButton = new BarSubItem();
      this.teklifRaporlariButton = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.alimKarariButton = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.muayeneButton = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.talepCekmeTeklifteGorunme = new TalepCekmeTeklifteGorunme();
      this.gridView1 = new GridView();
      this.gridColumn18 = new GridColumn();
      this.colID1 = new GridColumn();
      this.colARACID = new GridColumn();
      this.plaka = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colMARKA = new GridColumn();
      this.colBIRIMFIYAT = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.malMbirim = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.colMALZEMEADI = new GridColumn();
      this.colFIRMA1ID = new GridColumn();
      this.firmaAd = new RepositoryItemLookUpEdit();
      this.tBLFIRMALARBindingSource = new BindingSource(this.components);
      this.colF1BIRIMFIYAT = new GridColumn();
      this.colF1TUTAR = new GridColumn();
      this.colFIRMA2ID = new GridColumn();
      this.colF2BIRIMFIYAT = new GridColumn();
      this.colF2TUTAR = new GridColumn();
      this.colFIRMA3ID = new GridColumn();
      this.colF3BIRIMFIYAT = new GridColumn();
      this.colF3TUTAR = new GridColumn();
      this.colFIRMA4ID = new GridColumn();
      this.colF4BIRIMFIYAT = new GridColumn();
      this.colF4TUTAR = new GridColumn();
      this.colFIRMA5ID = new GridColumn();
      this.colF5BIRIMFIYAT = new GridColumn();
      this.colF5TUTAR = new GridColumn();
      this.colFIRMA6ID = new GridColumn();
      this.colF6BIRIMFIYAT = new GridColumn();
      this.colF6TUTAR = new GridColumn();
      this.colFIRMA7ID = new GridColumn();
      this.colF7BIRIMFIYAT = new GridColumn();
      this.colF7TUTAR = new GridColumn();
      this.colFIRMA8ID = new GridColumn();
      this.colF8BIRIMFIYAT = new GridColumn();
      this.colF8TUTAR = new GridColumn();
      this.colMALZEMEID = new GridColumn();
      this.malzemeAd = new RepositoryItemLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.colTalepID = new GridColumn();
      this.colMALZACIKLAMA = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colHRKTID = new GridColumn();
      this.tutarMask = new RepositoryItemTextEdit();
      this.gridControl3 = new GridControl();
      this.gridView3 = new GridView();
      this.gridControl2 = new GridControl();
      this.tBLTEKLIFIDARISARTBindingSource = new BindingSource(this.components);
      this.gridView2 = new GridView();
      this.colACIKLAMA = new GridColumn();
      this.repositoryItemMemoEdit1 = new RepositoryItemMemoEdit();
      this.colID = new GridColumn();
      this.colTEKLIFID1 = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.mkBaskanSluEdit = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.searchLookUpEdit18View = new GridView();
      this.gridColumn17 = new GridColumn();
      this.mkUye2 = new SearchLookUpEdit();
      this.searchLookUpEdit17View = new GridView();
      this.gridColumn16 = new GridColumn();
      this.mkUye1SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit16View = new GridView();
      this.gridColumn15 = new GridColumn();
      this.paBaskanSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit15View = new GridView();
      this.gridColumn14 = new GridColumn();
      this.paUye2SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit14View = new GridView();
      this.gridColumn13 = new GridColumn();
      this.paUye1SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit13View = new GridView();
      this.gridColumn12 = new GridColumn();
      this.satinAlmaSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit12View = new GridView();
      this.gridColumn11 = new GridColumn();
      this.mudurSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit11View = new GridView();
      this.gridColumn10 = new GridColumn();
      this.daireBaskaniSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit10View = new GridView();
      this.gridColumn9 = new GridColumn();
      this.kznFirmaSluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit9View = new GridView();
      this.gridColumn8 = new GridColumn();
      this.firma8SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit8View = new GridView();
      this.gridColumn7 = new GridColumn();
      this.firma7SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit7View = new GridView();
      this.gridColumn6 = new GridColumn();
      this.firma6SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit6View = new GridView();
      this.gridColumn19 = new GridColumn();
      this.firma5SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit5View = new GridView();
      this.gridColumn5 = new GridColumn();
      this.firma4SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.gridColumn4 = new GridColumn();
      this.firma3SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn3 = new GridColumn();
      this.firma2SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.firma1SluEdit = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.toplamTutarTxt = new TextEdit();
      this.kdvTxt = new TextEdit();
      this.tutarTxt = new TextEdit();
      this.talepNoTxt = new TextEdit();
      this.ftrNoTxt = new TextEdit();
      this.ftrDateEdit = new DateEdit();
      this.tarihDateEdit = new DateEdit();
      this.olurIlgisiTxt = new TextEdit();
      this.layoutControl2 = new LayoutControl();
      this.simpleButton4 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton111 = new SimpleButton();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.atolyeBolumCombo = new ComboBoxEdit();
      this.sakNoTxt = new TextEdit();
      this.sakDateEdit = new DateEdit();
      this.konusuTxt = new TextEdit();
      this.fisKoduTxt = new TextEdit();
      this.simpleButton11 = new SimpleButton();
      this.simpleButton21 = new SimpleButton();
      this.simpleButton31 = new SimpleButton();
      this.simpleButton41 = new SimpleButton();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.Root1 = new LayoutControlGroup();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem24 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem27 = new LayoutControlItem();
      this.layoutControlItem28 = new LayoutControlItem();
      this.layoutControlItem29 = new LayoutControlItem();
      this.layoutControlItem30 = new LayoutControlItem();
      this.layoutControlItem31 = new LayoutControlItem();
      this.layoutControlItem32 = new LayoutControlItem();
      this.layoutControlItem33 = new LayoutControlItem();
      this.layoutControlItem34 = new LayoutControlItem();
      this.layoutControlItem35 = new LayoutControlItem();
      this.layoutControlItem36 = new LayoutControlItem();
      this.layoutControlItem37 = new LayoutControlItem();
      this.layoutControlItem38 = new LayoutControlItem();
      this.layoutControlItem39 = new LayoutControlItem();
      this.layoutControlItem40 = new LayoutControlItem();
      this.layoutControlItem41 = new LayoutControlItem();
      this.layoutControlItem42 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.tBLTEKLIFHRKTBindingSource = new BindingSource(this.components);
      this.tBLTEKLIFHRKTTableAdapter = new TBLTEKLIFHRKTTableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLFIRMALARTableAdapter = new TBLFIRMALARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.subeMuduru = new subeMuduru();
      this.subeMuduruBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.subeMuduruTableAdapters.DataTable1TableAdapter();
      this.tBLTEKLIFIDARISARTTableAdapter = new TBLTEKLIFIDARISARTTableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.TalepCekmeTeklifteGorunmeTableAdapters.DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.talepCekmeTeklifteGorunme.BeginInit();
      this.gridView1.BeginInit();
      this.plaka.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.malMbirim.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.firmaAd.BeginInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).BeginInit();
      this.malzemeAd.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.tutarMask.BeginInit();
      this.gridControl3.BeginInit();
      this.gridView3.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFIDARISARTBindingSource).BeginInit();
      this.gridView2.BeginInit();
      this.repositoryItemMemoEdit1.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.mkBaskanSluEdit.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.searchLookUpEdit18View.BeginInit();
      this.mkUye2.Properties.BeginInit();
      this.searchLookUpEdit17View.BeginInit();
      this.mkUye1SluEdit.Properties.BeginInit();
      this.searchLookUpEdit16View.BeginInit();
      this.paBaskanSluEdit.Properties.BeginInit();
      this.searchLookUpEdit15View.BeginInit();
      this.paUye2SluEdit.Properties.BeginInit();
      this.searchLookUpEdit14View.BeginInit();
      this.paUye1SluEdit.Properties.BeginInit();
      this.searchLookUpEdit13View.BeginInit();
      this.satinAlmaSluEdit.Properties.BeginInit();
      this.searchLookUpEdit12View.BeginInit();
      this.mudurSluEdit.Properties.BeginInit();
      this.searchLookUpEdit11View.BeginInit();
      this.daireBaskaniSluEdit.Properties.BeginInit();
      this.searchLookUpEdit10View.BeginInit();
      this.kznFirmaSluEdit.Properties.BeginInit();
      this.searchLookUpEdit9View.BeginInit();
      this.firma8SluEdit.Properties.BeginInit();
      this.searchLookUpEdit8View.BeginInit();
      this.firma7SluEdit.Properties.BeginInit();
      this.searchLookUpEdit7View.BeginInit();
      this.firma6SluEdit.Properties.BeginInit();
      this.searchLookUpEdit6View.BeginInit();
      this.firma5SluEdit.Properties.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.firma4SluEdit.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.firma3SluEdit.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.firma2SluEdit.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.firma1SluEdit.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.toplamTutarTxt.Properties.BeginInit();
      this.kdvTxt.Properties.BeginInit();
      this.tutarTxt.Properties.BeginInit();
      this.talepNoTxt.Properties.BeginInit();
      this.ftrNoTxt.Properties.BeginInit();
      this.ftrDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.ftrDateEdit.Properties.BeginInit();
      this.tarihDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.tarihDateEdit.Properties.BeginInit();
      this.olurIlgisiTxt.Properties.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControl2.SuspendLayout();
      this.layoutControlGroup1.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.atolyeBolumCombo.Properties.BeginInit();
      this.sakNoTxt.Properties.BeginInit();
      this.sakDateEdit.Properties.CalendarTimeProperties.BeginInit();
      this.sakDateEdit.Properties.BeginInit();
      this.konusuTxt.Properties.BeginInit();
      this.fisKoduTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.Root1.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem24.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem27.BeginInit();
      this.layoutControlItem28.BeginInit();
      this.layoutControlItem29.BeginInit();
      this.layoutControlItem30.BeginInit();
      this.layoutControlItem31.BeginInit();
      this.layoutControlItem32.BeginInit();
      this.layoutControlItem33.BeginInit();
      this.layoutControlItem34.BeginInit();
      this.layoutControlItem35.BeginInit();
      this.layoutControlItem36.BeginInit();
      this.layoutControlItem37.BeginInit();
      this.layoutControlItem38.BeginInit();
      this.layoutControlItem39.BeginInit();
      this.layoutControlItem40.BeginInit();
      this.layoutControlItem41.BeginInit();
      this.layoutControlItem42.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFHRKTBindingSource).BeginInit();
      this.subeMuduru.BeginInit();
      ((ISupportInitialize) this.subeMuduruBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[27]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.KayitBulButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.teklifEkleButton,
        (BarItem) this.talepCikarButton,
        (BarItem) this.duzenleButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.raporlarButton,
        (BarItem) this.teklifRaporlariButton,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.alimKarariButton,
        (BarItem) this.barButtonItem11,
        (BarItem) this.muayeneButton,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 28;
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
      this.ribbonControl1.Size = new Size(1577, 100);
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
      this.YeniDosyaButton.LargeWidth = 100;
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
      this.teklifEkleButton.Caption = "Talebi Ekle";
      this.teklifEkleButton.Id = 9;
      this.teklifEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("teklifEkleButton.ImageOptions.Image");
      this.teklifEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("teklifEkleButton.ImageOptions.LargeImage");
      this.teklifEkleButton.LargeWidth = 100;
      this.teklifEkleButton.Name = "teklifEkleButton";
      this.teklifEkleButton.RibbonStyle = RibbonItemStyles.Large;
      this.teklifEkleButton.ItemClick += new ItemClickEventHandler(this.teklifEkleButton_ItemClick);
      this.talepCikarButton.Caption = "Talebi Çıkar";
      this.talepCikarButton.Id = 10;
      this.talepCikarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("talepCikarButton.ImageOptions.Image");
      this.talepCikarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("talepCikarButton.ImageOptions.LargeImage");
      this.talepCikarButton.LargeWidth = 100;
      this.talepCikarButton.Name = "talepCikarButton";
      this.talepCikarButton.RibbonStyle = RibbonItemStyles.Large;
      this.talepCikarButton.ItemClick += new ItemClickEventHandler(this.talepCikarButton_ItemClick);
      this.duzenleButton.Caption = "Düzenle";
      this.duzenleButton.Id = 11;
      this.duzenleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.Image");
      this.duzenleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("duzenleButton.ImageOptions.LargeImage");
      this.duzenleButton.LargeWidth = 100;
      this.duzenleButton.Name = "duzenleButton";
      this.duzenleButton.ItemClick += new ItemClickEventHandler(this.duzenleButton_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.Id = 27;
      this.barEditItem1.Name = "barEditItem1";
      this.raporlarButton.Caption = "Raporlar";
      this.raporlarButton.Id = 13;
      this.raporlarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("raporlarButton.ImageOptions.Image");
      this.raporlarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("raporlarButton.ImageOptions.LargeImage");
      this.raporlarButton.LargeWidth = 100;
      this.raporlarButton.LinksPersistInfo.AddRange(new LinkPersistInfo[12]
      {
        new LinkPersistInfo((BarItem) this.teklifRaporlariButton),
        new LinkPersistInfo((BarItem) this.barButtonItem3),
        new LinkPersistInfo((BarItem) this.barButtonItem4),
        new LinkPersistInfo((BarItem) this.barButtonItem8),
        new LinkPersistInfo((BarItem) this.barButtonItem9),
        new LinkPersistInfo((BarItem) this.alimKarariButton),
        new LinkPersistInfo((BarItem) this.barButtonItem11),
        new LinkPersistInfo((BarItem) this.muayeneButton),
        new LinkPersistInfo((BarItem) this.barButtonItem13),
        new LinkPersistInfo((BarItem) this.barButtonItem14),
        new LinkPersistInfo((BarItem) this.barButtonItem15),
        new LinkPersistInfo((BarItem) this.barButtonItem16)
      });
      this.raporlarButton.Name = "raporlarButton";
      this.raporlarButton.RibbonStyle = RibbonItemStyles.Large;
      this.teklifRaporlariButton.Caption = "Teklif Tek Araç";
      this.teklifRaporlariButton.Id = 14;
      this.teklifRaporlariButton.Name = "teklifRaporlariButton";
      this.teklifRaporlariButton.ItemClick += new ItemClickEventHandler(this.teklifRaporlariButton_ItemClick);
      this.barButtonItem3.Caption = "Teklif Çoklu Araç";
      this.barButtonItem3.Id = 15;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Teklif Muhtelif";
      this.barButtonItem4.Id = 16;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.teklifRaporlariButton_ItemClick);
      this.barButtonItem8.Caption = "Piyasa Araştırma Tutanağı 1";
      this.barButtonItem8.Id = 18;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "Piyasa Araştırma Tutanağı 2";
      this.barButtonItem9.Id = 19;
      this.barButtonItem9.Name = "barButtonItem9";
      this.alimKarariButton.Caption = "Alım Kararı";
      this.alimKarariButton.Id = 20;
      this.alimKarariButton.Name = "alimKarariButton";
      this.alimKarariButton.ItemClick += new ItemClickEventHandler(this.alimKarariButton_ItemClick);
      this.barButtonItem11.Caption = "Komisyon Raporu";
      this.barButtonItem11.Id = 21;
      this.barButtonItem11.Name = "barButtonItem11";
      this.muayeneButton.Caption = "Muayene Kabul Tutanağı";
      this.muayeneButton.Id = 22;
      this.muayeneButton.Name = "muayeneButton";
      this.muayeneButton.ItemClick += new ItemClickEventHandler(this.muayeneButton_ItemClick);
      this.barButtonItem13.Caption = "Teslim Tesellüm Formu";
      this.barButtonItem13.Id = 23;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barButtonItem14.Caption = "Ödeme Emri Yazısı";
      this.barButtonItem14.Id = 24;
      this.barButtonItem14.Name = "barButtonItem14";
      this.barButtonItem15.Caption = "İdari Şartname";
      this.barButtonItem15.Id = 25;
      this.barButtonItem15.Name = "barButtonItem15";
      this.barButtonItem16.Caption = "Sözleşme";
      this.barButtonItem16.Id = 26;
      this.barButtonItem16.Name = "barButtonItem16";
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 17;
      this.barButtonItem5.Name = "barButtonItem5";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[6]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup6,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.KayitBulButton);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.teklifEkleButton);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.talepCikarButton);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.duzenleButton);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.raporlarButton);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Controls.Add((Control) this.gridControl3);
      this.layoutControl1.Controls.Add((Control) this.gridControl2);
      this.layoutControl1.Controls.Add((Control) this.mkBaskanSluEdit);
      this.layoutControl1.Controls.Add((Control) this.mkUye2);
      this.layoutControl1.Controls.Add((Control) this.mkUye1SluEdit);
      this.layoutControl1.Controls.Add((Control) this.paBaskanSluEdit);
      this.layoutControl1.Controls.Add((Control) this.paUye2SluEdit);
      this.layoutControl1.Controls.Add((Control) this.paUye1SluEdit);
      this.layoutControl1.Controls.Add((Control) this.satinAlmaSluEdit);
      this.layoutControl1.Controls.Add((Control) this.mudurSluEdit);
      this.layoutControl1.Controls.Add((Control) this.daireBaskaniSluEdit);
      this.layoutControl1.Controls.Add((Control) this.kznFirmaSluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma8SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma7SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma6SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma5SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma4SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma3SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma2SluEdit);
      this.layoutControl1.Controls.Add((Control) this.firma1SluEdit);
      this.layoutControl1.Controls.Add((Control) this.toplamTutarTxt);
      this.layoutControl1.Controls.Add((Control) this.kdvTxt);
      this.layoutControl1.Controls.Add((Control) this.tutarTxt);
      this.layoutControl1.Controls.Add((Control) this.talepNoTxt);
      this.layoutControl1.Controls.Add((Control) this.ftrNoTxt);
      this.layoutControl1.Controls.Add((Control) this.ftrDateEdit);
      this.layoutControl1.Controls.Add((Control) this.tarihDateEdit);
      this.layoutControl1.Controls.Add((Control) this.olurIlgisiTxt);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.atolyeBolumCombo);
      this.layoutControl1.Controls.Add((Control) this.sakNoTxt);
      this.layoutControl1.Controls.Add((Control) this.sakDateEdit);
      this.layoutControl1.Controls.Add((Control) this.konusuTxt);
      this.layoutControl1.Controls.Add((Control) this.fisKoduTxt);
      this.layoutControl1.Controls.Add((Control) this.simpleButton11);
      this.layoutControl1.Controls.Add((Control) this.simpleButton21);
      this.layoutControl1.Controls.Add((Control) this.simpleButton31);
      this.layoutControl1.Controls.Add((Control) this.simpleButton41);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1167, 461, 650, 400));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1577, 683);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl1.Location = new Point(12, 156);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.plaka,
        (RepositoryItem) this.malzemeAd,
        (RepositoryItem) this.malMbirim,
        (RepositoryItem) this.firmaAd,
        (RepositoryItem) this.tutarMask
      });
      this.gridControl1.Size = new Size(1553, 331);
      this.gridControl1.TabIndex = 39;
      this.gridControl1.UseEmbeddedNavigator = true;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.talepCekmeTeklifteGorunme;
      this.talepCekmeTeklifteGorunme.DataSetName = "TalepCekmeTeklifteGorunme";
      this.talepCekmeTeklifteGorunme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[37]
      {
        this.gridColumn18,
        this.colID1,
        this.colARACID,
        this.colMARKA,
        this.colBIRIMFIYAT,
        this.colBIRIMID,
        this.colMALZEMEADI,
        this.colFIRMA1ID,
        this.colF1BIRIMFIYAT,
        this.colF1TUTAR,
        this.colFIRMA2ID,
        this.colF2BIRIMFIYAT,
        this.colF2TUTAR,
        this.colFIRMA3ID,
        this.colF3BIRIMFIYAT,
        this.colF3TUTAR,
        this.colFIRMA4ID,
        this.colF4BIRIMFIYAT,
        this.colF4TUTAR,
        this.colFIRMA5ID,
        this.colF5BIRIMFIYAT,
        this.colF5TUTAR,
        this.colFIRMA6ID,
        this.colF6BIRIMFIYAT,
        this.colF6TUTAR,
        this.colFIRMA7ID,
        this.colF7BIRIMFIYAT,
        this.colF7TUTAR,
        this.colFIRMA8ID,
        this.colF8BIRIMFIYAT,
        this.colF8TUTAR,
        this.colMALZEMEID,
        this.colTalepID,
        this.colMALZACIKLAMA,
        this.colMIKTAR,
        this.colTUTAR,
        this.colHRKTID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.AutoWidth = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.ShowFooter = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colMALZEMEADI, ColumnSortOrder.Ascending)
      });
      this.gridView1.CellValueChanged += new CellValueChangedEventHandler(this.gridView1_CellValueChanged);
      this.gridView1.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.gridColumn18.Caption = "S. No";
      this.gridColumn18.MinWidth = 21;
      this.gridColumn18.Name = "gridColumn18";
      this.gridColumn18.Visible = true;
      this.gridColumn18.VisibleIndex = 0;
      this.gridColumn18.Width = 43;
      this.colID1.Caption = "S. No";
      this.colID1.FieldName = "ID";
      this.colID1.Name = "colID1";
      this.colID1.OptionsColumn.AllowEdit = false;
      this.colID1.OptionsColumn.ReadOnly = true;
      this.colARACID.Caption = "Plaka";
      this.colARACID.ColumnEdit = (RepositoryItem) this.plaka;
      this.colARACID.FieldName = "ARACID";
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 3;
      this.plaka.AutoHeight = false;
      this.plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plaka.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("PLAKA", "Plaka", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.plaka.DataSource = (object) this.tBLARACLARBindingSource;
      this.plaka.DisplayMember = "PLAKA";
      this.plaka.Name = "plaka";
      this.plaka.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colMARKA.FieldName = "MARKA";
      this.colMARKA.Name = "colMARKA";
      this.colMARKA.OptionsColumn.AllowEdit = false;
      this.colMARKA.OptionsColumn.ReadOnly = true;
      this.colBIRIMFIYAT.Caption = "Fiyat";
      this.colBIRIMFIYAT.FieldName = "BIRIMFIYAT";
      this.colBIRIMFIYAT.Name = "colBIRIMFIYAT";
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.malMbirim;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 4;
      this.malMbirim.AutoHeight = false;
      this.malMbirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.malMbirim.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("BIRIMADI", "Birim Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.malMbirim.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.malMbirim.DisplayMember = "BIRIMADI";
      this.malMbirim.Name = "malMbirim";
      this.malMbirim.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colMALZEMEADI.Caption = "Malzme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colFIRMA1ID.Caption = "Firma 1";
      this.colFIRMA1ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA1ID.FieldName = "FIRMA1ID";
      this.colFIRMA1ID.Name = "colFIRMA1ID";
      this.colFIRMA1ID.Visible = true;
      this.colFIRMA1ID.VisibleIndex = 6;
      this.firmaAd.AutoHeight = false;
      this.firmaAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firmaAd.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("FIRMAADI", "Firma Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.firmaAd.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firmaAd.DisplayMember = "FIRMAADI";
      this.firmaAd.Name = "firmaAd";
      this.firmaAd.NullText = "";
      this.firmaAd.ValueMember = "ID";
      this.tBLFIRMALARBindingSource.DataMember = "TBLFIRMALAR";
      this.tBLFIRMALARBindingSource.DataSource = (object) this.bellDataSet5;
      this.colF1BIRIMFIYAT.Caption = "Fiyat";
      this.colF1BIRIMFIYAT.FieldName = "F1BIRIMFIYAT";
      this.colF1BIRIMFIYAT.Name = "colF1BIRIMFIYAT";
      this.colF1BIRIMFIYAT.Visible = true;
      this.colF1BIRIMFIYAT.VisibleIndex = 7;
      this.colF1TUTAR.Caption = "Tutar";
      this.colF1TUTAR.DisplayFormat.FormatString = "c2";
      this.colF1TUTAR.FieldName = "F1TUTAR";
      this.colF1TUTAR.Name = "colF1TUTAR";
      this.colF1TUTAR.OptionsColumn.AllowEdit = false;
      this.colF1TUTAR.OptionsColumn.AllowFocus = false;
      this.colF1TUTAR.OptionsColumn.ReadOnly = true;
      this.colF1TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F1TUTAR", "{0:c2}")
      });
      this.colF1TUTAR.Visible = true;
      this.colF1TUTAR.VisibleIndex = 8;
      this.colFIRMA2ID.Caption = "Firma 2";
      this.colFIRMA2ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA2ID.FieldName = "FIRMA2ID";
      this.colFIRMA2ID.Name = "colFIRMA2ID";
      this.colFIRMA2ID.Visible = true;
      this.colFIRMA2ID.VisibleIndex = 9;
      this.colF2BIRIMFIYAT.Caption = "Fiyat";
      this.colF2BIRIMFIYAT.FieldName = "F2BIRIMFIYAT";
      this.colF2BIRIMFIYAT.Name = "colF2BIRIMFIYAT";
      this.colF2BIRIMFIYAT.Visible = true;
      this.colF2BIRIMFIYAT.VisibleIndex = 10;
      this.colF2TUTAR.Caption = "Tutar";
      this.colF2TUTAR.DisplayFormat.FormatString = "c2";
      this.colF2TUTAR.FieldName = "F2TUTAR";
      this.colF2TUTAR.Name = "colF2TUTAR";
      this.colF2TUTAR.OptionsColumn.AllowEdit = false;
      this.colF2TUTAR.OptionsColumn.AllowFocus = false;
      this.colF2TUTAR.OptionsColumn.ReadOnly = true;
      this.colF2TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F2TUTAR", "{0:c2}")
      });
      this.colF2TUTAR.Visible = true;
      this.colF2TUTAR.VisibleIndex = 11;
      this.colFIRMA3ID.Caption = "Firama 3";
      this.colFIRMA3ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA3ID.FieldName = "FIRMA3ID";
      this.colFIRMA3ID.Name = "colFIRMA3ID";
      this.colFIRMA3ID.Visible = true;
      this.colFIRMA3ID.VisibleIndex = 12;
      this.colF3BIRIMFIYAT.Caption = "Fiyat";
      this.colF3BIRIMFIYAT.FieldName = "F3BIRIMFIYAT";
      this.colF3BIRIMFIYAT.Name = "colF3BIRIMFIYAT";
      this.colF3BIRIMFIYAT.Visible = true;
      this.colF3BIRIMFIYAT.VisibleIndex = 13;
      this.colF3TUTAR.Caption = "Tutar";
      this.colF3TUTAR.DisplayFormat.FormatString = "c2";
      this.colF3TUTAR.FieldName = "F3TUTAR";
      this.colF3TUTAR.Name = "colF3TUTAR";
      this.colF3TUTAR.OptionsColumn.AllowEdit = false;
      this.colF3TUTAR.OptionsColumn.AllowFocus = false;
      this.colF3TUTAR.OptionsColumn.ReadOnly = true;
      this.colF3TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F3TUTAR", "{0:c2}")
      });
      this.colF3TUTAR.Visible = true;
      this.colF3TUTAR.VisibleIndex = 14;
      this.colFIRMA4ID.Caption = "Firma 4";
      this.colFIRMA4ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA4ID.FieldName = "FIRMA4ID";
      this.colFIRMA4ID.Name = "colFIRMA4ID";
      this.colFIRMA4ID.Visible = true;
      this.colFIRMA4ID.VisibleIndex = 15;
      this.colF4BIRIMFIYAT.Caption = "Fiyat";
      this.colF4BIRIMFIYAT.FieldName = "F4BIRIMFIYAT";
      this.colF4BIRIMFIYAT.Name = "colF4BIRIMFIYAT";
      this.colF4BIRIMFIYAT.Visible = true;
      this.colF4BIRIMFIYAT.VisibleIndex = 16;
      this.colF4TUTAR.Caption = "Tutar";
      this.colF4TUTAR.DisplayFormat.FormatString = "c2";
      this.colF4TUTAR.FieldName = "F4TUTAR";
      this.colF4TUTAR.Name = "colF4TUTAR";
      this.colF4TUTAR.OptionsColumn.AllowEdit = false;
      this.colF4TUTAR.OptionsColumn.AllowFocus = false;
      this.colF4TUTAR.OptionsColumn.ReadOnly = true;
      this.colF4TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F4TUTAR", "{0:c2}")
      });
      this.colF4TUTAR.Visible = true;
      this.colF4TUTAR.VisibleIndex = 17;
      this.colFIRMA5ID.Caption = "Firma 5";
      this.colFIRMA5ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA5ID.FieldName = "FIRMA5ID";
      this.colFIRMA5ID.Name = "colFIRMA5ID";
      this.colFIRMA5ID.Visible = true;
      this.colFIRMA5ID.VisibleIndex = 18;
      this.colF5BIRIMFIYAT.Caption = "Fiyat";
      this.colF5BIRIMFIYAT.FieldName = "F5BIRIMFIYAT";
      this.colF5BIRIMFIYAT.Name = "colF5BIRIMFIYAT";
      this.colF5BIRIMFIYAT.Visible = true;
      this.colF5BIRIMFIYAT.VisibleIndex = 19;
      this.colF5TUTAR.Caption = "Tutar";
      this.colF5TUTAR.DisplayFormat.FormatString = "c2";
      this.colF5TUTAR.FieldName = "F5TUTAR";
      this.colF5TUTAR.Name = "colF5TUTAR";
      this.colF5TUTAR.OptionsColumn.AllowEdit = false;
      this.colF5TUTAR.OptionsColumn.AllowFocus = false;
      this.colF5TUTAR.OptionsColumn.ReadOnly = true;
      this.colF5TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F5TUTAR", "{0:c2}")
      });
      this.colF5TUTAR.Visible = true;
      this.colF5TUTAR.VisibleIndex = 20;
      this.colFIRMA6ID.Caption = "Firma 6";
      this.colFIRMA6ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA6ID.FieldName = "FIRMA6ID";
      this.colFIRMA6ID.Name = "colFIRMA6ID";
      this.colFIRMA6ID.Visible = true;
      this.colFIRMA6ID.VisibleIndex = 21;
      this.colF6BIRIMFIYAT.Caption = "Fiyat";
      this.colF6BIRIMFIYAT.FieldName = "F6BIRIMFIYAT";
      this.colF6BIRIMFIYAT.Name = "colF6BIRIMFIYAT";
      this.colF6BIRIMFIYAT.Visible = true;
      this.colF6BIRIMFIYAT.VisibleIndex = 22;
      this.colF6TUTAR.Caption = "Tutar";
      this.colF6TUTAR.DisplayFormat.FormatString = "c2";
      this.colF6TUTAR.FieldName = "F6TUTAR";
      this.colF6TUTAR.Name = "colF6TUTAR";
      this.colF6TUTAR.OptionsColumn.AllowEdit = false;
      this.colF6TUTAR.OptionsColumn.AllowFocus = false;
      this.colF6TUTAR.OptionsColumn.ReadOnly = true;
      this.colF6TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F6TUTAR", "{0:c2}")
      });
      this.colF6TUTAR.Visible = true;
      this.colF6TUTAR.VisibleIndex = 23;
      this.colFIRMA7ID.Caption = "Firma 7";
      this.colFIRMA7ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA7ID.FieldName = "FIRMA7ID";
      this.colFIRMA7ID.Name = "colFIRMA7ID";
      this.colFIRMA7ID.Visible = true;
      this.colFIRMA7ID.VisibleIndex = 24;
      this.colF7BIRIMFIYAT.Caption = "Fiyat";
      this.colF7BIRIMFIYAT.FieldName = "F7BIRIMFIYAT";
      this.colF7BIRIMFIYAT.Name = "colF7BIRIMFIYAT";
      this.colF7BIRIMFIYAT.Visible = true;
      this.colF7BIRIMFIYAT.VisibleIndex = 25;
      this.colF7TUTAR.Caption = "Tutar";
      this.colF7TUTAR.DisplayFormat.FormatString = "c2";
      this.colF7TUTAR.FieldName = "F7TUTAR";
      this.colF7TUTAR.Name = "colF7TUTAR";
      this.colF7TUTAR.OptionsColumn.AllowEdit = false;
      this.colF7TUTAR.OptionsColumn.AllowFocus = false;
      this.colF7TUTAR.OptionsColumn.ReadOnly = true;
      this.colF7TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F7TUTAR", "{0:c2}")
      });
      this.colF7TUTAR.Visible = true;
      this.colF7TUTAR.VisibleIndex = 26;
      this.colFIRMA8ID.Caption = "Firma 8";
      this.colFIRMA8ID.ColumnEdit = (RepositoryItem) this.firmaAd;
      this.colFIRMA8ID.FieldName = "FIRMA8ID";
      this.colFIRMA8ID.Name = "colFIRMA8ID";
      this.colFIRMA8ID.Visible = true;
      this.colFIRMA8ID.VisibleIndex = 27;
      this.colF8BIRIMFIYAT.Caption = "Fiyat";
      this.colF8BIRIMFIYAT.FieldName = "F8BIRIMFIYAT";
      this.colF8BIRIMFIYAT.Name = "colF8BIRIMFIYAT";
      this.colF8BIRIMFIYAT.Visible = true;
      this.colF8BIRIMFIYAT.VisibleIndex = 28;
      this.colF8TUTAR.Caption = "Tutar";
      this.colF8TUTAR.DisplayFormat.FormatString = "c2";
      this.colF8TUTAR.FieldName = "F8TUTAR";
      this.colF8TUTAR.Name = "colF8TUTAR";
      this.colF8TUTAR.OptionsColumn.AllowEdit = false;
      this.colF8TUTAR.OptionsColumn.AllowFocus = false;
      this.colF8TUTAR.OptionsColumn.ReadOnly = true;
      this.colF8TUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "F8TUTAR", "{0:c2}")
      });
      this.colF8TUTAR.Visible = true;
      this.colF8TUTAR.VisibleIndex = 29;
      this.colMALZEMEID.Caption = "Malzeme Adı";
      this.colMALZEMEID.ColumnEdit = (RepositoryItem) this.malzemeAd;
      this.colMALZEMEID.FieldName = "MALZEMEID";
      this.colMALZEMEID.Name = "colMALZEMEID";
      this.colMALZEMEID.OptionsColumn.AllowEdit = false;
      this.colMALZEMEID.OptionsColumn.ReadOnly = true;
      this.colMALZEMEID.Visible = true;
      this.colMALZEMEID.VisibleIndex = 1;
      this.malzemeAd.AutoHeight = false;
      this.malzemeAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.malzemeAd.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("MALZEMEADI", "Malzeme Adı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.malzemeAd.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.malzemeAd.DisplayMember = "MALZEMEADI";
      this.malzemeAd.Name = "malzemeAd";
      this.malzemeAd.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet5;
      this.colTalepID.FieldName = "TalepID";
      this.colTalepID.Name = "colTalepID";
      this.colMALZACIKLAMA.Caption = "Malzeme Açıklama";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colMALZACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 2;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.AllowFocus = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 5;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.Name = "colTUTAR";
      this.colHRKTID.Caption = "gridColumn18";
      this.colHRKTID.FieldName = "HRKTID";
      this.colHRKTID.MinWidth = 21;
      this.colHRKTID.Name = "colHRKTID";
      this.colHRKTID.Width = 81;
      this.tutarMask.AutoHeight = false;
      this.tutarMask.Mask.EditMask = "c2";
      this.tutarMask.Mask.MaskType = MaskType.Numeric;
      this.tutarMask.Mask.UseMaskAsDisplayFormat = true;
      this.tutarMask.Name = "tutarMask";
      this.gridControl3.Location = new Point(1084, 491);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.Size = new Size(481, 180);
      this.gridControl3.TabIndex = 41;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridControl2.DataSource = (object) this.tBLTEKLIFIDARISARTBindingSource;
      this.gridControl2.Location = new Point(110, 491);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemMemoEdit1
      });
      this.gridControl2.Size = new Size(881, 180);
      this.gridControl2.TabIndex = 40;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLTEKLIFIDARISARTBindingSource.DataMember = "TBLTEKLIFIDARISART";
      this.tBLTEKLIFIDARISARTBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridView2.AutoFillColumn = this.colACIKLAMA;
      this.gridView2.Columns.AddRange(new GridColumn[4]
      {
        this.colID,
        this.colTEKLIFID1,
        this.colSIRANO,
        this.colACIKLAMA
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsView.ShowAutoFilterRow = true;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.colACIKLAMA.AppearanceCell.Options.UseTextOptions = true;
      this.colACIKLAMA.AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;
      this.colACIKLAMA.Caption = "Açıklama";
      this.colACIKLAMA.ColumnEdit = (RepositoryItem) this.repositoryItemMemoEdit1;
      this.colACIKLAMA.FieldName = "ACIKLAMA";
      this.colACIKLAMA.MinWidth = 500;
      this.colACIKLAMA.Name = "colACIKLAMA";
      this.colACIKLAMA.UnboundType = UnboundColumnType.String;
      this.colACIKLAMA.Visible = true;
      this.colACIKLAMA.VisibleIndex = 1;
      this.colACIKLAMA.Width = 500;
      this.repositoryItemMemoEdit1.LinesCount = 300;
      this.repositoryItemMemoEdit1.MaxLength = 1000;
      this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colTEKLIFID1.FieldName = "TEKLIFID";
      this.colTEKLIFID1.Name = "colTEKLIFID1";
      this.colSIRANO.Caption = "Sıra No";
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.Visible = true;
      this.colSIRANO.VisibleIndex = 0;
      this.colSIRANO.Width = 84;
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.mkBaskanSluEdit.EditValue = (object) "";
      this.mkBaskanSluEdit.Location = new Point(1398, 132);
      this.mkBaskanSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mkBaskanSluEdit.Name = "mkBaskanSluEdit";
      this.mkBaskanSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mkBaskanSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.mkBaskanSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.mkBaskanSluEdit.Properties.NullText = "";
      this.mkBaskanSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit18View;
      this.mkBaskanSluEdit.Properties.ValueMember = "ID";
      this.mkBaskanSluEdit.Size = new Size(167, 20);
      this.mkBaskanSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.mkBaskanSluEdit.TabIndex = 38;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.searchLookUpEdit18View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn17
      });
      this.searchLookUpEdit18View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit18View.Name = "searchLookUpEdit18View";
      this.searchLookUpEdit18View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit18View.OptionsView.ShowGroupPanel = false;
      this.gridColumn17.Caption = "ADI SOYADI";
      this.gridColumn17.FieldName = "ADISOYADI";
      this.gridColumn17.Name = "gridColumn17";
      this.gridColumn17.Visible = true;
      this.gridColumn17.VisibleIndex = 0;
      this.mkUye2.EditValue = (object) "";
      this.mkUye2.Location = new Point(1398, 108);
      this.mkUye2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mkUye2.Name = "mkUye2";
      this.mkUye2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mkUye2.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.mkUye2.Properties.DisplayMember = "ADISOYADI";
      this.mkUye2.Properties.NullText = "";
      this.mkUye2.Properties.PopupView = (ColumnView) this.searchLookUpEdit17View;
      this.mkUye2.Properties.ValueMember = "ID";
      this.mkUye2.Size = new Size(167, 20);
      this.mkUye2.StyleController = (IStyleController) this.layoutControl1;
      this.mkUye2.TabIndex = 37;
      this.searchLookUpEdit17View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn16
      });
      this.searchLookUpEdit17View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit17View.Name = "searchLookUpEdit17View";
      this.searchLookUpEdit17View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit17View.OptionsView.ShowGroupPanel = false;
      this.gridColumn16.Caption = "ADI SOYADI";
      this.gridColumn16.FieldName = "ADISOYADI";
      this.gridColumn16.Name = "gridColumn16";
      this.gridColumn16.Visible = true;
      this.gridColumn16.VisibleIndex = 0;
      this.mkUye1SluEdit.EditValue = (object) "";
      this.mkUye1SluEdit.Location = new Point(1398, 84);
      this.mkUye1SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mkUye1SluEdit.Name = "mkUye1SluEdit";
      this.mkUye1SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mkUye1SluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.mkUye1SluEdit.Properties.DisplayMember = "ADISOYADI";
      this.mkUye1SluEdit.Properties.NullText = "";
      this.mkUye1SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit16View;
      this.mkUye1SluEdit.Properties.ValueMember = "ID";
      this.mkUye1SluEdit.Size = new Size(167, 20);
      this.mkUye1SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.mkUye1SluEdit.TabIndex = 36;
      this.searchLookUpEdit16View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn15
      });
      this.searchLookUpEdit16View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit16View.Name = "searchLookUpEdit16View";
      this.searchLookUpEdit16View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit16View.OptionsView.ShowGroupPanel = false;
      this.gridColumn15.Caption = "ADI SOYADI";
      this.gridColumn15.FieldName = "ADISOYADI";
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 0;
      this.paBaskanSluEdit.EditValue = (object) "";
      this.paBaskanSluEdit.Location = new Point(1398, 60);
      this.paBaskanSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.paBaskanSluEdit.Name = "paBaskanSluEdit";
      this.paBaskanSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.paBaskanSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.paBaskanSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.paBaskanSluEdit.Properties.NullText = "";
      this.paBaskanSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit15View;
      this.paBaskanSluEdit.Properties.ValueMember = "ID";
      this.paBaskanSluEdit.Size = new Size(167, 20);
      this.paBaskanSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.paBaskanSluEdit.TabIndex = 35;
      this.searchLookUpEdit15View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn14
      });
      this.searchLookUpEdit15View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit15View.Name = "searchLookUpEdit15View";
      this.searchLookUpEdit15View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit15View.OptionsView.ShowGroupPanel = false;
      this.gridColumn14.Caption = "ADI SOYADI";
      this.gridColumn14.FieldName = "ADISOYADI";
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 0;
      this.paUye2SluEdit.EditValue = (object) "";
      this.paUye2SluEdit.Location = new Point(1398, 36);
      this.paUye2SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.paUye2SluEdit.Name = "paUye2SluEdit";
      this.paUye2SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.paUye2SluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.paUye2SluEdit.Properties.DisplayMember = "ADISOYADI";
      this.paUye2SluEdit.Properties.NullText = "";
      this.paUye2SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit14View;
      this.paUye2SluEdit.Properties.ValueMember = "ID";
      this.paUye2SluEdit.Size = new Size(167, 20);
      this.paUye2SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.paUye2SluEdit.TabIndex = 34;
      this.searchLookUpEdit14View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn13
      });
      this.searchLookUpEdit14View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit14View.Name = "searchLookUpEdit14View";
      this.searchLookUpEdit14View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit14View.OptionsView.ShowGroupPanel = false;
      this.gridColumn13.Caption = "ADI SOYADI";
      this.gridColumn13.FieldName = "ADISOYADI";
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 0;
      this.paUye1SluEdit.EditValue = (object) "";
      this.paUye1SluEdit.Location = new Point(1398, 12);
      this.paUye1SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.paUye1SluEdit.Name = "paUye1SluEdit";
      this.paUye1SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.paUye1SluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.paUye1SluEdit.Properties.DisplayMember = "ADISOYADI";
      this.paUye1SluEdit.Properties.NullText = "";
      this.paUye1SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit13View;
      this.paUye1SluEdit.Properties.ValueMember = "ID";
      this.paUye1SluEdit.Size = new Size(167, 20);
      this.paUye1SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.paUye1SluEdit.TabIndex = 33;
      this.searchLookUpEdit13View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn12
      });
      this.searchLookUpEdit13View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit13View.Name = "searchLookUpEdit13View";
      this.searchLookUpEdit13View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit13View.OptionsView.ShowGroupPanel = false;
      this.gridColumn12.Caption = "ADI SOYADI";
      this.gridColumn12.FieldName = "ADISOYADI";
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 0;
      this.satinAlmaSluEdit.EditValue = (object) "";
      this.satinAlmaSluEdit.Location = new Point(1106, 132);
      this.satinAlmaSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.satinAlmaSluEdit.Name = "satinAlmaSluEdit";
      this.satinAlmaSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.satinAlmaSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.satinAlmaSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.satinAlmaSluEdit.Properties.NullText = "";
      this.satinAlmaSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit12View;
      this.satinAlmaSluEdit.Properties.ValueMember = "ID";
      this.satinAlmaSluEdit.Size = new Size(193, 20);
      this.satinAlmaSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.satinAlmaSluEdit.TabIndex = 32;
      this.searchLookUpEdit12View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn11
      });
      this.searchLookUpEdit12View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit12View.Name = "searchLookUpEdit12View";
      this.searchLookUpEdit12View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit12View.OptionsView.ShowGroupPanel = false;
      this.gridColumn11.Caption = "ADI SOYADI";
      this.gridColumn11.FieldName = "ADISOYADI";
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 0;
      this.mudurSluEdit.EditValue = (object) "";
      this.mudurSluEdit.Location = new Point(1106, 108);
      this.mudurSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurSluEdit.Name = "mudurSluEdit";
      this.mudurSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.mudurSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.mudurSluEdit.Properties.NullText = "";
      this.mudurSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit11View;
      this.mudurSluEdit.Properties.ValueMember = "ID";
      this.mudurSluEdit.Size = new Size(193, 20);
      this.mudurSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.mudurSluEdit.TabIndex = 31;
      this.searchLookUpEdit11View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn10
      });
      this.searchLookUpEdit11View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit11View.Name = "searchLookUpEdit11View";
      this.searchLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit11View.OptionsView.ShowGroupPanel = false;
      this.gridColumn10.Caption = "Adı Soyadı";
      this.gridColumn10.FieldName = "ADISOYADI";
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 0;
      this.daireBaskaniSluEdit.EditValue = (object) "";
      this.daireBaskaniSluEdit.Location = new Point(1106, 84);
      this.daireBaskaniSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.daireBaskaniSluEdit.Name = "daireBaskaniSluEdit";
      this.daireBaskaniSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.daireBaskaniSluEdit.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.daireBaskaniSluEdit.Properties.DisplayMember = "ADISOYADI";
      this.daireBaskaniSluEdit.Properties.NullText = "";
      this.daireBaskaniSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit10View;
      this.daireBaskaniSluEdit.Properties.ValueMember = "ID";
      this.daireBaskaniSluEdit.Size = new Size(193, 20);
      this.daireBaskaniSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.daireBaskaniSluEdit.TabIndex = 30;
      this.searchLookUpEdit10View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn9
      });
      this.searchLookUpEdit10View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit10View.Name = "searchLookUpEdit10View";
      this.searchLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit10View.OptionsView.ShowGroupPanel = false;
      this.gridColumn9.Caption = "Adı Soyadı";
      this.gridColumn9.FieldName = "ADISOYADI";
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 0;
      this.kznFirmaSluEdit.EditValue = (object) "";
      this.kznFirmaSluEdit.Location = new Point(1106, 60);
      this.kznFirmaSluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kznFirmaSluEdit.Name = "kznFirmaSluEdit";
      this.kznFirmaSluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kznFirmaSluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.kznFirmaSluEdit.Properties.DisplayMember = "FIRMAADI";
      this.kznFirmaSluEdit.Properties.NullText = "";
      this.kznFirmaSluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit9View;
      this.kznFirmaSluEdit.Properties.ValueMember = "ID";
      this.kznFirmaSluEdit.Size = new Size(193, 20);
      this.kznFirmaSluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.kznFirmaSluEdit.TabIndex = 29;
      this.searchLookUpEdit9View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn8
      });
      this.searchLookUpEdit9View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit9View.Name = "searchLookUpEdit9View";
      this.searchLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit9View.OptionsView.ShowGroupPanel = false;
      this.gridColumn8.Caption = "Firma Adı";
      this.gridColumn8.FieldName = "FIRMAADI";
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 0;
      this.firma8SluEdit.EditValue = (object) "";
      this.firma8SluEdit.Location = new Point(1106, 36);
      this.firma8SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma8SluEdit.Name = "firma8SluEdit";
      this.firma8SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma8SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma8SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma8SluEdit.Properties.NullText = "";
      this.firma8SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit8View;
      this.firma8SluEdit.Properties.ValueMember = "ID";
      this.firma8SluEdit.Size = new Size(193, 20);
      this.firma8SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma8SluEdit.TabIndex = 28;
      this.searchLookUpEdit8View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn7
      });
      this.searchLookUpEdit8View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit8View.Name = "searchLookUpEdit8View";
      this.searchLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit8View.OptionsView.ShowGroupPanel = false;
      this.gridColumn7.Caption = "Firma Adı";
      this.gridColumn7.FieldName = "FIRMAADI";
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 0;
      this.firma7SluEdit.EditValue = (object) "";
      this.firma7SluEdit.Location = new Point(1106, 12);
      this.firma7SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma7SluEdit.Name = "firma7SluEdit";
      this.firma7SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma7SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma7SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma7SluEdit.Properties.NullText = "";
      this.firma7SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit7View;
      this.firma7SluEdit.Properties.ValueMember = "ID";
      this.firma7SluEdit.Size = new Size(193, 20);
      this.firma7SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma7SluEdit.TabIndex = 27;
      this.searchLookUpEdit7View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn6
      });
      this.searchLookUpEdit7View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit7View.Name = "searchLookUpEdit7View";
      this.searchLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit7View.OptionsView.ShowGroupPanel = false;
      this.gridColumn6.Caption = "Firma Adı";
      this.gridColumn6.FieldName = "FIRMAADI";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.firma6SluEdit.EditValue = (object) "";
      this.firma6SluEdit.Location = new Point(817, 132);
      this.firma6SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma6SluEdit.Name = "firma6SluEdit";
      this.firma6SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma6SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma6SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma6SluEdit.Properties.NullText = "";
      this.firma6SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit6View;
      this.firma6SluEdit.Properties.ValueMember = "ID";
      this.firma6SluEdit.Size = new Size(190, 20);
      this.firma6SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma6SluEdit.TabIndex = 26;
      this.searchLookUpEdit6View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn19
      });
      this.searchLookUpEdit6View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit6View.Name = "searchLookUpEdit6View";
      this.searchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
      this.gridColumn19.Caption = "Firma Adı";
      this.gridColumn19.FieldName = "FIRMAADI";
      this.gridColumn19.Name = "gridColumn19";
      this.gridColumn19.Visible = true;
      this.gridColumn19.VisibleIndex = 0;
      this.firma5SluEdit.EditValue = (object) "";
      this.firma5SluEdit.Location = new Point(817, 108);
      this.firma5SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma5SluEdit.Name = "firma5SluEdit";
      this.firma5SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma5SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma5SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma5SluEdit.Properties.NullText = "";
      this.firma5SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.firma5SluEdit.Properties.ValueMember = "ID";
      this.firma5SluEdit.Size = new Size(190, 20);
      this.firma5SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma5SluEdit.TabIndex = 25;
      this.searchLookUpEdit5View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Firma Adı";
      this.gridColumn5.FieldName = "FIRMAADI";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.firma4SluEdit.EditValue = (object) "";
      this.firma4SluEdit.Location = new Point(817, 84);
      this.firma4SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma4SluEdit.Name = "firma4SluEdit";
      this.firma4SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma4SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma4SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma4SluEdit.Properties.NullText = "";
      this.firma4SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.firma4SluEdit.Properties.ValueMember = "ID";
      this.firma4SluEdit.Size = new Size(190, 20);
      this.firma4SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma4SluEdit.TabIndex = 24;
      this.searchLookUpEdit4View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Firma Adı";
      this.gridColumn4.FieldName = "FIRMAADI";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.firma3SluEdit.EditValue = (object) "";
      this.firma3SluEdit.Location = new Point(816, 60);
      this.firma3SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma3SluEdit.Name = "firma3SluEdit";
      this.firma3SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma3SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma3SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma3SluEdit.Properties.NullText = "";
      this.firma3SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.firma3SluEdit.Properties.ValueMember = "ID";
      this.firma3SluEdit.Size = new Size(191, 20);
      this.firma3SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma3SluEdit.TabIndex = 23;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Firma Adı";
      this.gridColumn3.FieldName = "FIRMAADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.firma2SluEdit.EditValue = (object) "";
      this.firma2SluEdit.Location = new Point(816, 36);
      this.firma2SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma2SluEdit.Name = "firma2SluEdit";
      this.firma2SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma2SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma2SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma2SluEdit.Properties.NullText = "";
      this.firma2SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.firma2SluEdit.Properties.ValueMember = "ID";
      this.firma2SluEdit.Size = new Size(191, 20);
      this.firma2SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma2SluEdit.TabIndex = 22;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Firma Adı";
      this.gridColumn2.FieldName = "FIRMAADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.firma1SluEdit.EditValue = (object) "";
      this.firma1SluEdit.Location = new Point(816, 12);
      this.firma1SluEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.firma1SluEdit.Name = "firma1SluEdit";
      this.firma1SluEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.firma1SluEdit.Properties.DataSource = (object) this.tBLFIRMALARBindingSource;
      this.firma1SluEdit.Properties.DisplayMember = "FIRMAADI";
      this.firma1SluEdit.Properties.NullText = "";
      this.firma1SluEdit.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.firma1SluEdit.Properties.ShowAddNewButton = true;
      this.firma1SluEdit.Properties.ValueMember = "ID";
      this.firma1SluEdit.Properties.AddNewValue += new AddNewValueEventHandler(this.firma1SluEdit_Properties_AddNewValue);
      this.firma1SluEdit.Size = new Size(191, 20);
      this.firma1SluEdit.StyleController = (IStyleController) this.layoutControl1;
      this.firma1SluEdit.TabIndex = 21;
      this.firma1SluEdit.AddNewValue += new AddNewValueEventHandler(this.firma1SluEdit_Properties_AddNewValue);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Firma Adı";
      this.gridColumn1.FieldName = "FIRMAADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.toplamTutarTxt.Location = new Point(587, 132);
      this.toplamTutarTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.toplamTutarTxt.Name = "toplamTutarTxt";
      this.toplamTutarTxt.Properties.Mask.EditMask = "n";
      this.toplamTutarTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.toplamTutarTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.toplamTutarTxt.Size = new Size(131, 20);
      this.toplamTutarTxt.StyleController = (IStyleController) this.layoutControl1;
      this.toplamTutarTxt.TabIndex = 20;
      this.kdvTxt.Location = new Point(587, 108);
      this.kdvTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kdvTxt.Name = "kdvTxt";
      this.kdvTxt.Properties.Mask.EditMask = "n";
      this.kdvTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.kdvTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.kdvTxt.Size = new Size(131, 20);
      this.kdvTxt.StyleController = (IStyleController) this.layoutControl1;
      this.kdvTxt.TabIndex = 19;
      this.tutarTxt.Location = new Point(587, 84);
      this.tutarTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tutarTxt.Name = "tutarTxt";
      this.tutarTxt.Properties.Mask.EditMask = "n";
      this.tutarTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.tutarTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.tutarTxt.Size = new Size(131, 20);
      this.tutarTxt.StyleController = (IStyleController) this.layoutControl1;
      this.tutarTxt.TabIndex = 18;
      this.talepNoTxt.Location = new Point(341, 132);
      this.talepNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.talepNoTxt.Name = "talepNoTxt";
      this.talepNoTxt.Size = new Size(147, 20);
      this.talepNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.talepNoTxt.TabIndex = 17;
      this.ftrNoTxt.Location = new Point(341, 108);
      this.ftrNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ftrNoTxt.Name = "ftrNoTxt";
      this.ftrNoTxt.Size = new Size(147, 20);
      this.ftrNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.ftrNoTxt.TabIndex = 16;
      this.ftrDateEdit.EditValue = (object) null;
      this.ftrDateEdit.Location = new Point(341, 84);
      this.ftrDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ftrDateEdit.Name = "ftrDateEdit";
      this.ftrDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ftrDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ftrDateEdit.Size = new Size(147, 20);
      this.ftrDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.ftrDateEdit.TabIndex = 15;
      this.tarihDateEdit.EditValue = (object) null;
      this.tarihDateEdit.Location = new Point(450, 12);
      this.tarihDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihDateEdit.Name = "tarihDateEdit";
      this.tarihDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihDateEdit.Properties.Mask.EditMask = "g";
      this.tarihDateEdit.Size = new Size(267, 20);
      this.tarihDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.tarihDateEdit.TabIndex = 14;
      this.olurIlgisiTxt.Location = new Point(107, 60);
      this.olurIlgisiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.olurIlgisiTxt.Name = "olurIlgisiTxt";
      this.olurIlgisiTxt.Size = new Size(610, 20);
      this.olurIlgisiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.olurIlgisiTxt.TabIndex = 13;
      this.layoutControl2.Controls.Add((Control) this.simpleButton4);
      this.layoutControl2.Controls.Add((Control) this.simpleButton3);
      this.layoutControl2.Controls.Add((Control) this.simpleButton2);
      this.layoutControl2.Controls.Add((Control) this.simpleButton111);
      this.layoutControl2.Location = new Point(12, 491);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(94, 180);
      this.layoutControl2.TabIndex = 12;
      this.layoutControl2.Text = "layoutControl2";
      this.simpleButton4.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton4.ImageOptions.Image");
      this.simpleButton4.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton4.Location = new Point(12, 132);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.PaintStyle = PaintStyles.Light;
      this.simpleButton4.Size = new Size(70, 36);
      this.simpleButton4.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton4.TabIndex = 7;
      this.simpleButton4.Click += new EventHandler(this.simpleButton4_Click);
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton3.Location = new Point(12, 92);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(70, 36);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton3.TabIndex = 6;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton2.Location = new Point(12, 52);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(70, 36);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton2.TabIndex = 5;
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton111.BackgroundImageLayout = ImageLayout.Center;
      this.simpleButton111.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton111.ImageOptions.Image");
      this.simpleButton111.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton111.Location = new Point(12, 12);
      this.simpleButton111.Name = "simpleButton111";
      this.simpleButton111.PaintStyle = PaintStyles.Light;
      this.simpleButton111.Size = new Size(70, 36);
      this.simpleButton111.StyleController = (IStyleController) this.layoutControl2;
      this.simpleButton111.TabIndex = 4;
      this.simpleButton111.Click += new EventHandler(this.simpleButton111_Click);
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem11
      });
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new Size(94, 180);
      this.layoutControlGroup1.TextVisible = false;
      this.layoutControlItem12.Control = (Control) this.simpleButton2;
      this.layoutControlItem12.Location = new Point(0, 40);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(74, 40);
      this.layoutControlItem12.TextSize = new Size(0, 0);
      this.layoutControlItem12.TextVisible = false;
      this.layoutControlItem13.Control = (Control) this.simpleButton3;
      this.layoutControlItem13.Location = new Point(0, 80);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(74, 40);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem14.Control = (Control) this.simpleButton4;
      this.layoutControlItem14.Location = new Point(0, 120);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(74, 40);
      this.layoutControlItem14.TextSize = new Size(0, 0);
      this.layoutControlItem14.TextVisible = false;
      this.layoutControlItem11.Control = (Control) this.simpleButton111;
      this.layoutControlItem11.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
      this.layoutControlItem11.ImageOptions.Alignment = ContentAlignment.MiddleCenter;
      this.layoutControlItem11.Location = new Point(0, 0);
      this.layoutControlItem11.MinSize = new Size(42, 40);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(74, 40);
      this.layoutControlItem11.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem11.TextSize = new Size(0, 0);
      this.layoutControlItem11.TextVisible = false;
      this.atolyeBolumCombo.Location = new Point(107, 132);
      this.atolyeBolumCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyeBolumCombo.Name = "atolyeBolumCombo";
      this.atolyeBolumCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyeBolumCombo.Properties.Items.AddRange(new object[10]
      {
        (object) "Akaryakı İstasyonu",
        (object) "Binek Araç Atolyesi",
        (object) "Destek Hizmetleri",
        (object) "Elektirik Atölyesi",
        (object) "İş Makine Atölyesi",
        (object) "Kmyon Atolyesi",
        (object) "Kaynak & Şase Atölyesi",
        (object) "Lastik Atölyesi",
        (object) "Makina İkamal",
        (object) "Torna Atölyesi"
      });
      this.atolyeBolumCombo.Size = new Size(135, 20);
      this.atolyeBolumCombo.StyleController = (IStyleController) this.layoutControl1;
      this.atolyeBolumCombo.TabIndex = 8;
      this.sakNoTxt.Location = new Point(107, 108);
      this.sakNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sakNoTxt.Name = "sakNoTxt";
      this.sakNoTxt.Properties.Mask.EditMask = "d";
      this.sakNoTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.sakNoTxt.Size = new Size(135, 20);
      this.sakNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.sakNoTxt.TabIndex = 7;
      this.sakDateEdit.EditValue = (object) null;
      this.sakDateEdit.Location = new Point(107, 84);
      this.sakDateEdit.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sakDateEdit.Name = "sakDateEdit";
      this.sakDateEdit.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sakDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sakDateEdit.Size = new Size(135, 20);
      this.sakDateEdit.StyleController = (IStyleController) this.layoutControl1;
      this.sakDateEdit.TabIndex = 6;
      this.konusuTxt.Location = new Point(107, 36);
      this.konusuTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.konusuTxt.Name = "konusuTxt";
      this.konusuTxt.Size = new Size(610, 20);
      this.konusuTxt.StyleController = (IStyleController) this.layoutControl1;
      this.konusuTxt.TabIndex = 5;
      this.fisKoduTxt.Location = new Point(107, 12);
      this.fisKoduTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisKoduTxt.Name = "fisKoduTxt";
      this.fisKoduTxt.Size = new Size(244, 20);
      this.fisKoduTxt.StyleController = (IStyleController) this.layoutControl1;
      this.fisKoduTxt.TabIndex = 4;
      this.simpleButton11.BackgroundImageLayout = ImageLayout.Center;
      this.simpleButton11.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton11.ImageOptions.Image");
      this.simpleButton11.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton11.Location = new Point(1005, 501);
      this.simpleButton11.Name = "simpleButton11";
      this.simpleButton11.PaintStyle = PaintStyles.Light;
      this.simpleButton11.Size = new Size(65, 36);
      this.simpleButton11.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton11.TabIndex = 4;
      this.simpleButton21.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton21.ImageOptions.Image");
      this.simpleButton21.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton21.Location = new Point(1005, 541);
      this.simpleButton21.Name = "simpleButton21";
      this.simpleButton21.PaintStyle = PaintStyles.Light;
      this.simpleButton21.Size = new Size(65, 36);
      this.simpleButton21.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton21.TabIndex = 5;
      this.simpleButton31.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton31.ImageOptions.Image");
      this.simpleButton31.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton31.Location = new Point(1005, 581);
      this.simpleButton31.Name = "simpleButton31";
      this.simpleButton31.PaintStyle = PaintStyles.Light;
      this.simpleButton31.Size = new Size(65, 36);
      this.simpleButton31.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton31.TabIndex = 6;
      this.simpleButton41.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton41.ImageOptions.Image");
      this.simpleButton41.ImageOptions.Location = ImageLocation.TopCenter;
      this.simpleButton41.Location = new Point(1005, 621);
      this.simpleButton41.Name = "simpleButton41";
      this.simpleButton41.PaintStyle = PaintStyles.Light;
      this.simpleButton41.Size = new Size(65, 36);
      this.simpleButton41.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton41.TabIndex = 7;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[36]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.Root1,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem24,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem27,
        (BaseLayoutItem) this.layoutControlItem28,
        (BaseLayoutItem) this.layoutControlItem29,
        (BaseLayoutItem) this.layoutControlItem30,
        (BaseLayoutItem) this.layoutControlItem31,
        (BaseLayoutItem) this.layoutControlItem32,
        (BaseLayoutItem) this.layoutControlItem33,
        (BaseLayoutItem) this.layoutControlItem34,
        (BaseLayoutItem) this.layoutControlItem35,
        (BaseLayoutItem) this.layoutControlItem36,
        (BaseLayoutItem) this.layoutControlItem37,
        (BaseLayoutItem) this.layoutControlItem38,
        (BaseLayoutItem) this.layoutControlItem39,
        (BaseLayoutItem) this.layoutControlItem40,
        (BaseLayoutItem) this.layoutControlItem41,
        (BaseLayoutItem) this.layoutControlItem42,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1577, 683);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.fisKoduTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.MinSize = new Size(100, 24);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(343, 24);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Fiş Kodu";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(90, 18);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.konusuTxt;
      this.layoutControlItem2.Location = new Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(709, 24);
      this.layoutControlItem2.Text = "Konusu";
      this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem2.TextLocation = Locations.Left;
      this.layoutControlItem2.TextSize = new Size(90, 18);
      this.layoutControlItem2.TextToControlDistance = 5;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.sakDateEdit;
      this.layoutControlItem3.Location = new Point(0, 72);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(234, 24);
      this.layoutControlItem3.Text = "S.A.K. Tarihi";
      this.layoutControlItem3.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem3.TextLocation = Locations.Left;
      this.layoutControlItem3.TextSize = new Size(90, 18);
      this.layoutControlItem3.TextToControlDistance = 5;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.sakNoTxt;
      this.layoutControlItem4.Location = new Point(0, 96);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(234, 24);
      this.layoutControlItem4.Text = "S.A.K. No";
      this.layoutControlItem4.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem4.TextLocation = Locations.Left;
      this.layoutControlItem4.TextSize = new Size(90, 18);
      this.layoutControlItem4.TextToControlDistance = 5;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.atolyeBolumCombo;
      this.layoutControlItem5.Location = new Point(0, 120);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(234, 24);
      this.layoutControlItem5.Text = "Atölye Bölüm";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem5.TextLocation = Locations.Left;
      this.layoutControlItem5.TextSize = new Size(90, 18);
      this.layoutControlItem5.TextToControlDistance = 5;
      this.layoutControlItem9.Control = (Control) this.layoutControl2;
      this.layoutControlItem9.Location = new Point(0, 479);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(98, 184);
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.Root1.CustomizationFormText = "Root";
      this.Root1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root1.GroupBordersVisible = false;
      this.Root1.Items.AddRange(new BaseLayoutItem[4]
      {
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem17
      });
      this.Root1.Location = new Point(983, 479);
      this.Root1.Name = "Root1";
      this.Root1.OptionsItemText.AlignControlsWithHiddenText = true;
      this.Root1.Size = new Size(89, 184);
      this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.Root1.Text = "Root";
      this.Root1.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.simpleButton11;
      this.layoutControlItem10.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem10.CustomizationFormText = "layoutControlItem11";
      this.layoutControlItem10.Location = new Point(0, 0);
      this.layoutControlItem10.MaxSize = new Size(69, 40);
      this.layoutControlItem10.MinSize = new Size(69, 40);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(69, 40);
      this.layoutControlItem10.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem10.Text = "layoutControlItem11";
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.simpleButton21;
      this.layoutControlItem15.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem15.CustomizationFormText = "layoutControlItem12";
      this.layoutControlItem15.Location = new Point(0, 40);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(69, 40);
      this.layoutControlItem15.Text = "layoutControlItem12";
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.layoutControlItem16.Control = (Control) this.simpleButton31;
      this.layoutControlItem16.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem16.CustomizationFormText = "layoutControlItem13";
      this.layoutControlItem16.Location = new Point(0, 80);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(69, 40);
      this.layoutControlItem16.Text = "layoutControlItem13";
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.layoutControlItem17.Control = (Control) this.simpleButton41;
      this.layoutControlItem17.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem17.CustomizationFormText = "layoutControlItem14";
      this.layoutControlItem17.Location = new Point(0, 120);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.Size = new Size(69, 44);
      this.layoutControlItem17.Text = "layoutControlItem14";
      this.layoutControlItem17.TextSize = new Size(0, 0);
      this.layoutControlItem17.TextVisible = false;
      this.layoutControlItem18.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem18.Control = (Control) this.olurIlgisiTxt;
      this.layoutControlItem18.Location = new Point(0, 48);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(709, 24);
      this.layoutControlItem18.Text = "Olur İlgisi";
      this.layoutControlItem18.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem18.TextLocation = Locations.Left;
      this.layoutControlItem18.TextSize = new Size(90, 18);
      this.layoutControlItem18.TextToControlDistance = 5;
      this.layoutControlItem.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem.Control = (Control) this.tarihDateEdit;
      this.layoutControlItem.Location = new Point(343, 0);
      this.layoutControlItem.Name = "layoutControlItem";
      this.layoutControlItem.Size = new Size(366, 24);
      this.layoutControlItem.Text = "Tarih / Saat";
      this.layoutControlItem.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem.TextLocation = Locations.Left;
      this.layoutControlItem.TextSize = new Size(90, 18);
      this.layoutControlItem.TextToControlDistance = 5;
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.ftrDateEdit;
      this.layoutControlItem19.Location = new Point(234, 72);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(246, 24);
      this.layoutControlItem19.Text = "Ftr. Tarih";
      this.layoutControlItem19.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem19.TextLocation = Locations.Left;
      this.layoutControlItem19.TextSize = new Size(90, 18);
      this.layoutControlItem19.TextToControlDistance = 5;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.ftrNoTxt;
      this.layoutControlItem20.Location = new Point(234, 96);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.Size = new Size(246, 24);
      this.layoutControlItem20.Text = "Ftr. No";
      this.layoutControlItem20.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem20.TextLocation = Locations.Left;
      this.layoutControlItem20.TextSize = new Size(90, 18);
      this.layoutControlItem20.TextToControlDistance = 5;
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.Control = (Control) this.talepNoTxt;
      this.layoutControlItem21.Location = new Point(234, 120);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(246, 24);
      this.layoutControlItem21.Text = "Talep No";
      this.layoutControlItem21.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem21.TextLocation = Locations.Left;
      this.layoutControlItem21.TextSize = new Size(90, 18);
      this.layoutControlItem21.TextToControlDistance = 5;
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.tutarTxt;
      this.layoutControlItem22.Location = new Point(480, 72);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(230, 24);
      this.layoutControlItem22.Text = "Tutar";
      this.layoutControlItem22.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem22.TextLocation = Locations.Left;
      this.layoutControlItem22.TextSize = new Size(90, 18);
      this.layoutControlItem22.TextToControlDistance = 5;
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.kdvTxt;
      this.layoutControlItem23.Location = new Point(480, 96);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(230, 24);
      this.layoutControlItem23.Text = "KDV";
      this.layoutControlItem23.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem23.TextLocation = Locations.Left;
      this.layoutControlItem23.TextSize = new Size(90, 18);
      this.layoutControlItem23.TextToControlDistance = 5;
      this.layoutControlItem24.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem24.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem24.Control = (Control) this.toplamTutarTxt;
      this.layoutControlItem24.Location = new Point(480, 120);
      this.layoutControlItem24.Name = "layoutControlItem24";
      this.layoutControlItem24.Size = new Size(230, 24);
      this.layoutControlItem24.Text = "Top. Tutar";
      this.layoutControlItem24.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem24.TextLocation = Locations.Left;
      this.layoutControlItem24.TextSize = new Size(90, 18);
      this.layoutControlItem24.TextToControlDistance = 5;
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.firma1SluEdit;
      this.layoutControlItem25.Location = new Point(709, 0);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(290, 24);
      this.layoutControlItem25.Text = "1. Firma";
      this.layoutControlItem25.TextSize = new Size(92, 18);
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.firma2SluEdit;
      this.layoutControlItem26.Location = new Point(709, 24);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.Size = new Size(290, 24);
      this.layoutControlItem26.Text = "2. Firma";
      this.layoutControlItem26.TextSize = new Size(92, 18);
      this.layoutControlItem27.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem27.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem27.Control = (Control) this.firma3SluEdit;
      this.layoutControlItem27.Location = new Point(709, 48);
      this.layoutControlItem27.Name = "layoutControlItem27";
      this.layoutControlItem27.Size = new Size(290, 24);
      this.layoutControlItem27.Text = "3. Firma";
      this.layoutControlItem27.TextSize = new Size(92, 18);
      this.layoutControlItem28.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem28.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem28.Control = (Control) this.firma4SluEdit;
      this.layoutControlItem28.Location = new Point(710, 72);
      this.layoutControlItem28.Name = "layoutControlItem28";
      this.layoutControlItem28.Size = new Size(289, 24);
      this.layoutControlItem28.Text = "4. Firma";
      this.layoutControlItem28.TextSize = new Size(92, 18);
      this.layoutControlItem29.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem29.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem29.Control = (Control) this.firma5SluEdit;
      this.layoutControlItem29.Location = new Point(710, 96);
      this.layoutControlItem29.Name = "layoutControlItem29";
      this.layoutControlItem29.Size = new Size(289, 24);
      this.layoutControlItem29.Text = "5.  Firma";
      this.layoutControlItem29.TextSize = new Size(92, 18);
      this.layoutControlItem30.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem30.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem30.Control = (Control) this.firma6SluEdit;
      this.layoutControlItem30.Location = new Point(710, 120);
      this.layoutControlItem30.Name = "layoutControlItem30";
      this.layoutControlItem30.Size = new Size(289, 24);
      this.layoutControlItem30.Text = "6.  Firma";
      this.layoutControlItem30.TextSize = new Size(92, 18);
      this.layoutControlItem31.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem31.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem31.Control = (Control) this.firma7SluEdit;
      this.layoutControlItem31.Location = new Point(999, 0);
      this.layoutControlItem31.Name = "layoutControlItem31";
      this.layoutControlItem31.Size = new Size(292, 24);
      this.layoutControlItem31.Text = "7.  Firma";
      this.layoutControlItem31.TextSize = new Size(92, 18);
      this.layoutControlItem32.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem32.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem32.Control = (Control) this.firma8SluEdit;
      this.layoutControlItem32.Location = new Point(999, 24);
      this.layoutControlItem32.Name = "layoutControlItem32";
      this.layoutControlItem32.Size = new Size(292, 24);
      this.layoutControlItem32.Text = "8.  Firma";
      this.layoutControlItem32.TextSize = new Size(92, 18);
      this.layoutControlItem33.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem33.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem33.Control = (Control) this.kznFirmaSluEdit;
      this.layoutControlItem33.Location = new Point(999, 48);
      this.layoutControlItem33.Name = "layoutControlItem33";
      this.layoutControlItem33.Size = new Size(292, 24);
      this.layoutControlItem33.Text = "Kzn.  Firma";
      this.layoutControlItem33.TextSize = new Size(92, 18);
      this.layoutControlItem34.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem34.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem34.Control = (Control) this.daireBaskaniSluEdit;
      this.layoutControlItem34.Location = new Point(999, 72);
      this.layoutControlItem34.Name = "layoutControlItem34";
      this.layoutControlItem34.Size = new Size(292, 24);
      this.layoutControlItem34.Text = "Daire Başkanı";
      this.layoutControlItem34.TextSize = new Size(92, 18);
      this.layoutControlItem35.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem35.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem35.Control = (Control) this.mudurSluEdit;
      this.layoutControlItem35.Location = new Point(999, 96);
      this.layoutControlItem35.Name = "layoutControlItem35";
      this.layoutControlItem35.Size = new Size(292, 24);
      this.layoutControlItem35.Text = "Müdür";
      this.layoutControlItem35.TextSize = new Size(92, 18);
      this.layoutControlItem36.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem36.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem36.Control = (Control) this.satinAlmaSluEdit;
      this.layoutControlItem36.Location = new Point(999, 120);
      this.layoutControlItem36.Name = "layoutControlItem36";
      this.layoutControlItem36.Size = new Size(292, 24);
      this.layoutControlItem36.Text = "Satın Alma";
      this.layoutControlItem36.TextSize = new Size(92, 18);
      this.layoutControlItem37.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem37.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem37.Control = (Control) this.paUye1SluEdit;
      this.layoutControlItem37.Location = new Point(1291, 0);
      this.layoutControlItem37.Name = "layoutControlItem37";
      this.layoutControlItem37.Size = new Size(266, 24);
      this.layoutControlItem37.Text = "P.A Üye1";
      this.layoutControlItem37.TextSize = new Size(92, 18);
      this.layoutControlItem38.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem38.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem38.Control = (Control) this.paUye2SluEdit;
      this.layoutControlItem38.Location = new Point(1291, 24);
      this.layoutControlItem38.Name = "layoutControlItem38";
      this.layoutControlItem38.Size = new Size(266, 24);
      this.layoutControlItem38.Text = "P.A Üye2";
      this.layoutControlItem38.TextSize = new Size(92, 18);
      this.layoutControlItem39.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem39.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem39.Control = (Control) this.paBaskanSluEdit;
      this.layoutControlItem39.Location = new Point(1291, 48);
      this.layoutControlItem39.Name = "layoutControlItem39";
      this.layoutControlItem39.Size = new Size(266, 24);
      this.layoutControlItem39.Text = "P.A Başkan";
      this.layoutControlItem39.TextSize = new Size(92, 18);
      this.layoutControlItem40.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem40.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem40.Control = (Control) this.mkUye1SluEdit;
      this.layoutControlItem40.Location = new Point(1291, 72);
      this.layoutControlItem40.Name = "layoutControlItem40";
      this.layoutControlItem40.Size = new Size(266, 24);
      this.layoutControlItem40.Text = "M.K. Üye1";
      this.layoutControlItem40.TextSize = new Size(92, 18);
      this.layoutControlItem41.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem41.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem41.Control = (Control) this.mkUye2;
      this.layoutControlItem41.Location = new Point(1291, 96);
      this.layoutControlItem41.Name = "layoutControlItem41";
      this.layoutControlItem41.Size = new Size(266, 24);
      this.layoutControlItem41.Text = "M.K. Üye2";
      this.layoutControlItem41.TextSize = new Size(92, 18);
      this.layoutControlItem42.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem42.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem42.Control = (Control) this.mkBaskanSluEdit;
      this.layoutControlItem42.Location = new Point(1291, 120);
      this.layoutControlItem42.Name = "layoutControlItem42";
      this.layoutControlItem42.Size = new Size(266, 24);
      this.layoutControlItem42.Text = "M.K. Başkan";
      this.layoutControlItem42.TextSize = new Size(92, 18);
      this.layoutControlItem6.Control = (Control) this.gridControl1;
      this.layoutControlItem6.Location = new Point(0, 144);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(1557, 335);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem7.Control = (Control) this.gridControl2;
      this.layoutControlItem7.Location = new Point(98, 479);
      this.layoutControlItem7.MaxSize = new Size(885, 184);
      this.layoutControlItem7.MinSize = new Size(885, 184);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(885, 184);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.layoutControlItem8.Control = (Control) this.gridControl3;
      this.layoutControlItem8.Location = new Point(1072, 479);
      this.layoutControlItem8.MaxSize = new Size(485, 184);
      this.layoutControlItem8.MinSize = new Size(485, 184);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(485, 184);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.tBLTEKLIFHRKTBindingSource.DataMember = "TBLTEKLIFHRKT";
      this.tBLTEKLIFHRKTBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLTEKLIFHRKTTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLFIRMALARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.subeMuduru.DataSetName = "subeMuduru";
      this.subeMuduru.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.subeMuduruBindingSource.DataSource = (object) this.subeMuduru;
      this.subeMuduruBindingSource.Position = 0;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.subeMuduruBindingSource;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLTEKLIFIDARISARTTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1577, 783);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (TeklifFisi);
      this.Text = nameof (TeklifFisi);
      this.Load += new EventHandler(this.TeklifFisi_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.talepCekmeTeklifteGorunme.EndInit();
      this.gridView1.EndInit();
      this.plaka.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.malMbirim.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.firmaAd.EndInit();
      ((ISupportInitialize) this.tBLFIRMALARBindingSource).EndInit();
      this.malzemeAd.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.tutarMask.EndInit();
      this.gridControl3.EndInit();
      this.gridView3.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLTEKLIFIDARISARTBindingSource).EndInit();
      this.gridView2.EndInit();
      this.repositoryItemMemoEdit1.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.mkBaskanSluEdit.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.searchLookUpEdit18View.EndInit();
      this.mkUye2.Properties.EndInit();
      this.searchLookUpEdit17View.EndInit();
      this.mkUye1SluEdit.Properties.EndInit();
      this.searchLookUpEdit16View.EndInit();
      this.paBaskanSluEdit.Properties.EndInit();
      this.searchLookUpEdit15View.EndInit();
      this.paUye2SluEdit.Properties.EndInit();
      this.searchLookUpEdit14View.EndInit();
      this.paUye1SluEdit.Properties.EndInit();
      this.searchLookUpEdit13View.EndInit();
      this.satinAlmaSluEdit.Properties.EndInit();
      this.searchLookUpEdit12View.EndInit();
      this.mudurSluEdit.Properties.EndInit();
      this.searchLookUpEdit11View.EndInit();
      this.daireBaskaniSluEdit.Properties.EndInit();
      this.searchLookUpEdit10View.EndInit();
      this.kznFirmaSluEdit.Properties.EndInit();
      this.searchLookUpEdit9View.EndInit();
      this.firma8SluEdit.Properties.EndInit();
      this.searchLookUpEdit8View.EndInit();
      this.firma7SluEdit.Properties.EndInit();
      this.searchLookUpEdit7View.EndInit();
      this.firma6SluEdit.Properties.EndInit();
      this.searchLookUpEdit6View.EndInit();
      this.firma5SluEdit.Properties.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.firma4SluEdit.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.firma3SluEdit.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.firma2SluEdit.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.firma1SluEdit.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.toplamTutarTxt.Properties.EndInit();
      this.kdvTxt.Properties.EndInit();
      this.tutarTxt.Properties.EndInit();
      this.talepNoTxt.Properties.EndInit();
      this.ftrNoTxt.Properties.EndInit();
      this.ftrDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.ftrDateEdit.Properties.EndInit();
      this.tarihDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.tarihDateEdit.Properties.EndInit();
      this.olurIlgisiTxt.Properties.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControl2.ResumeLayout(false);
      this.layoutControlGroup1.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem11.EndInit();
      this.atolyeBolumCombo.Properties.EndInit();
      this.sakNoTxt.Properties.EndInit();
      this.sakDateEdit.Properties.CalendarTimeProperties.EndInit();
      this.sakDateEdit.Properties.EndInit();
      this.konusuTxt.Properties.EndInit();
      this.fisKoduTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem9.EndInit();
      this.Root1.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem24.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem27.EndInit();
      this.layoutControlItem28.EndInit();
      this.layoutControlItem29.EndInit();
      this.layoutControlItem30.EndInit();
      this.layoutControlItem31.EndInit();
      this.layoutControlItem32.EndInit();
      this.layoutControlItem33.EndInit();
      this.layoutControlItem34.EndInit();
      this.layoutControlItem35.EndInit();
      this.layoutControlItem36.EndInit();
      this.layoutControlItem37.EndInit();
      this.layoutControlItem38.EndInit();
      this.layoutControlItem39.EndInit();
      this.layoutControlItem40.EndInit();
      this.layoutControlItem41.EndInit();
      this.layoutControlItem42.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      ((ISupportInitialize) this.tBLTEKLIFHRKTBindingSource).EndInit();
      this.subeMuduru.EndInit();
      ((ISupportInitialize) this.subeMuduruBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
