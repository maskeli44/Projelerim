// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.TalepEkle
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
using DevExpress.XtraLayout.Converter;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.SatinAlma.TalepRaporlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class TalepEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int control = 0;
    public int secim = 0;
    private int talepFisID = 0;
    private int guncelID = 0;
    private KullaniciSonId son = new KullaniciSonId();
    private TalepTekArac1 yeniRapor = new TalepTekArac1();
    private IhaleOnay1 yeniIhale = new IhaleOnay1();
    private TalepCokluArac1 yeniCoklu = new TalepCokluArac1();
    private TalepMuhtelif2 yeniMuhtelif = new TalepMuhtelif2();
    private OlurYazisi1 yeniOlur = new OlurYazisi1();
    private OdenekIzınBelgesi1 yeniOdenek = new OdenekIzınBelgesi1();
    private TeknikSartnameGoruntu yeniTeknik = new TeknikSartnameGoruntu();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private BindingSource dataTable1BindingSource;
    private Makina_Ikmal.Model.AraclarListesiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private LayoutControl layoutControl1;
    private TextEdit konuCombo;
    private TextEdit butceCombo;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem25;
    private LayoutControlItem layoutControlItem26;
    private BindingSource dataTable1BindingSource1;
    private MemoEdit belgeCombo;
    private EmptySpaceItem emptySpaceItem1;
    private DateEdit belgeTarihCombo;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem14;
    private BarButtonItem YeniDosyaButton;
    private RibbonPageGroup ribbonPageGroup3;
    private BarButtonItem FisEkleButton;
    private BarButtonItem FisiCikarButton;
    private RibbonPageGroup ribbonPageGroup5;
    private TextEdit fisKoduCombo;
    private DateEdit tarihCombo;
    private TextEdit ismiktariCombo;
    private TextEdit ihaleCombo;
    private TextEdit maliyetCombo;
    private TextEdit odenekCombo;
    private SearchLookUpEdit yetkiliCombo;
    private GridView searchLookUpEdit1View;
    private SearchLookUpEdit sefCombo;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem11;
    private SearchLookUpEdit baskanCombo;
    private GridView gridView3;
    private SearchLookUpEdit gsyCombo;
    private GridView gridView4;
    private SearchLookUpEdit sekreterCombo;
    private GridView gridView5;
    private LayoutControlItem layoutControlItem6;
    private SearchLookUpEdit mudurCombo;
    private GridView gridView6;
    private LayoutConverter layoutConverter1;
    private GridControl gridControl1;
    private GridView gridView7;
    private GridControl gridControl2;
    private GridView gridView8;
    private bellDataSet bellDataSet;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLMALZEMELERBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLTALEPFISBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPFISTableAdapter tBLTALEPFISTableAdapter;
    private BindingSource tBLTALEPTEKNIKSARTBindingSource;
    private Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPTEKNIKSARTTableAdapter tBLTALEPTEKNIKSARTTableAdapter;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem15;
    private SimpleButton simpleButton3;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private SimpleButton tenikEkleButton;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem17;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem19;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem13;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLTEKLIFIDARISARTBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFIDARISARTTableAdapter tBLTEKLIFIDARISARTTableAdapter;
    private BindingSource talepToplaBindingSource;
    private TalepTopla talepTopla;
    private BindingSource tBLTALEPTEKNIKSARTBindingSource1;
    private RepositoryItemLookUpEdit malAd;
    private RepositoryItemLookUpEdit talepFisKod;
    private RepositoryItemLookUpEdit personel;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private BindingSource tBLARACLARBindingSource1;
    private aracBul aracBul;
    private Makina_Ikmal.Model.aracBulTableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter1;
    private BindingSource tBLISEMRIBindingSource1;
    private RepositoryItemLookUpEdit isemri;
    private TextEdit isyeriTxt;
    private GridColumn adSoyad;
    private GridColumn gridColumn2;
    private GridColumn gridColumn1;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private RepositoryItemButtonEdit repositoryItemButtonEdit1;
    private PopupMenu popupMenu1;
    private BindingSource dataTable1BindingSource2;
    private TalepKayitTabloCek talepKayitTabloCek;
    private Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private BindingSource dataTable2BindingSource;
    private GridColumn colISEMRIID;
    private GridColumn colMALZEMEADI;
    private GridColumn colMALZACIKLAMA;
    private GridColumn colPLAKA;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn colTALEPFISID;
    private GridColumn colTALEPKAYITID;
    private Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
    private RepositoryItemLookUpEdit talepKod;
    private BarButtonItem tekaracButon;
    private BarButtonItem cokluAracButon;
    private BarButtonItem talepMuhtelif;
    private BarButtonItem olurButon;
    private BarButtonItem odenekButon;
    private BarButtonItem ihaleButon;
    private BarButtonItem teknikButon;
    private BindingSource tBLTALEPTEKNIKSARTBindingSource2;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTEKNIKSARTTableAdapter tBLTALEPTEKNIKSARTTableAdapter1;
    private GridColumn colID;
    private GridColumn colTALEPID;
    private GridColumn colSIRANO;
    private GridColumn colACIKLAMA;
    private Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
    private BindingSource tBLTALEPBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter tBLTALEPTableAdapter;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private RibbonPageGroup ribbonPageGroup6;
    private GridColumn gridColumn6;
    private GridColumn gridColumn7;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMALZBIRIMBindingSource1;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter1;
    private RepositoryItemLookUpEdit ARAC;
    private BindingSource tBLARACLARBindingSource2;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter2;
    private GridColumn gridColumn8;
    private GridColumn gridColumn9;

    public TalepEkle() => this.InitializeComponent();

    private void TalepEkle_Load(object sender, EventArgs e)
    {
      if (this.secim == 1)
      {
        this.tarihCombo.DateTime = DateTime.Now;
        this.belgeTarihCombo.DateTime = DateTime.Now;
        this.SilButton.Enabled = false;
      }
      this.fisKoduCombo.Enabled = false;
      this.isyeriTxt.Text = "Makine İkmal Şb. Md.";
      this.butceCombo.Text = "46630131-0139-4-037103";
      this.ihaleCombo.Text = "22/D";
      this.butceCombo.Text = "466301-0139-4-037103";
      this.ARAC.ValueMember = "ID";
      this.ARAC.DisplayMember = "PLAKA";
      this.ARAC.DataSource = (object) this.db.TBLARACLAR.ToList<TBLARACLAR>();
      List<TBLPERSONEL> list = this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.sefCombo.Properties.ValueMember = "ID";
      this.sefCombo.Properties.DisplayMember = "ADISOYADI";
      this.sefCombo.Properties.DataSource = (object) list;
      this.mudurCombo.Properties.ValueMember = "ID";
      this.mudurCombo.Properties.DisplayMember = "ADISOYADI";
      this.mudurCombo.Properties.DataSource = (object) list;
      this.talepFisKod.ValueMember = "ID";
      this.talepFisKod.DisplayMember = "KOD";
      this.talepFisKod.DataSource = (object) this.db.TBLTALEPFIS.ToList<TBLTALEPFIS>();
      this.malAd.ValueMember = "ID";
      this.malAd.DisplayMember = "MALZEMEADI";
      this.malAd.DataSource = (object) this.db.TBLMALZEMELER.ToList<TBLMALZEMELER>();
      this.isemri.ValueMember = "ID";
      this.isemri.DisplayMember = "KOD";
      this.isemri.DataSource = (object) this.db.TBLISEMRI.ToList<TBLISEMRI>();
      this.yetkiliCombo.Properties.ValueMember = "ID";
      this.yetkiliCombo.Properties.DisplayMember = "ADISOYADI";
      this.yetkiliCombo.Properties.DataSource = (object) list;
      this.baskanCombo.Properties.ValueMember = "ID";
      this.baskanCombo.Properties.DisplayMember = "ADISOYADI";
      this.baskanCombo.Properties.DataSource = (object) list;
      this.sekreterCombo.Properties.ValueMember = "ID";
      this.sekreterCombo.Properties.DisplayMember = "ADISOYADI";
      this.sekreterCombo.Properties.DataSource = (object) list;
      this.gsyCombo.Properties.ValueMember = "ID";
      this.gsyCombo.Properties.DisplayMember = "ADISOYADI";
      this.gsyCombo.Properties.DataSource = (object) list;
      talepFisAktarma.list.Clear();
      this.yetkiliCombo.EditValue = (object) sorumlu.depoyetkilisi;
      this.sefCombo.EditValue = (object) sorumlu.atolyesefi;
      this.mudurCombo.EditValue = (object) sorumlu.subemuduru;
      this.baskanCombo.EditValue = (object) sorumlu.dairebaskani;
      this.sekreterCombo.EditValue = (object) sorumlu.genelsekreter;
      this.gsyCombo.EditValue = (object) sorumlu.genelsekreteryardimcisi;
      this.guncelID = YetkiClass.secim_id;
    }

    public void liste()
    {
    }

    public void liste2(int gelenID)
    {
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
    {
      talepFisAktarma.list.Clear();
      this.Close();
    }

    private void FisEkleButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 2)
      {
        IQueryable<\u003C\u003Ef__AnonymousType61<int?>> source = this.db.TBLTALEP.Where<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (hd => hd.ID == this.guncelID)).Select(hd => new
        {
          TEKLIFID = hd.TEKLIFID
        });
        if (source.Count() <= 0)
        {
          try
          {
            FisEkle fisEkle = new FisEkle();
            fisEkle.secim = 2;
            fisEkle.talepID = this.guncelID;
            YetkiClass.secim_id = this.guncelID;
            int num = (int) fisEkle.ShowDialog();
          }
          catch (Exception ex)
          {
          }
        }
        else
        {
          foreach (var data in source)
          {
            int? teklifid = data.TEKLIFID;
            int num1;
            if (teklifid.HasValue)
            {
              teklifid = data.TEKLIFID;
              int num2 = 0;
              num1 = teklifid.GetValueOrDefault() == num2 & teklifid.HasValue ? 1 : 0;
            }
            else
              num1 = 1;
            if (num1 != 0)
            {
              try
              {
                int num3 = (int) new FisEkle()
                {
                  secim = 2,
                  talepID = this.guncelID
                }.ShowDialog();
              }
              catch (Exception ex)
              {
              }
            }
            else
            {
              int num4 = (int) XtraMessageBox.Show("Teklife Atılan Talepler Düzenlenemez. Düzenleme İçin Teklif Silinmelidir.");
            }
          }
        }
      }
      if (this.secim != 1)
        return;
      if (this.fisKoduCombo.Text == "")
      {
        if (DialogResult.Yes == MessageBox.Show("Talep Kaydedilecektir", "Talep Kaydet", MessageBoxButtons.YesNo))
        {
          this.secim = 2;
          try
          {
            this.fisKoduCombo.Text = this.son.talepKod();
            this.db.TBLTALEP.Add(new TBLTALEP()
            {
              KOD = this.fisKoduCombo.Text,
              SAAT = new DateTime?(this.tarihCombo.DateTime),
              BELGESAYI = this.belgeCombo.Text,
              ISINADI = this.konuCombo.Text,
              BELGETARIH = new DateTime?(this.belgeTarihCombo.DateTime),
              ISINTURUMIKTARI = this.ismiktariCombo.Text,
              ISINYAPYERI = this.isyeriTxt.Text,
              BUTCETERTIBI = this.butceCombo.Text,
              IHALEUSULU = this.ihaleCombo.Text,
              YAKLASIKMALIYET = this.maliyetCombo.Text,
              KULLODENEKTUTAR = this.odenekCombo.Text,
              DEPOYETKILIID = new int?(Convert.ToInt32(this.yetkiliCombo.EditValue)),
              ATOLYESEFID = new int?(Convert.ToInt32(this.sefCombo.EditValue)),
              MUDURID = new int?(Convert.ToInt32(this.mudurCombo.EditValue)),
              DAIREBSKID = new int?(Convert.ToInt32(this.baskanCombo.EditValue)),
              GENELSEKRETERID = new int?(Convert.ToInt32(this.sekreterCombo.EditValue)),
              GENELSEKYRDID = new int?(Convert.ToInt32(this.gsyCombo.EditValue))
            });
            this.db.SaveChanges();
            int num = int.Parse(this.db.TBLTALEP.OrderByDescending<TBLTALEP, int>((Expression<System.Func<TBLTALEP, int>>) (p => p.ID)).Select<TBLTALEP, int>((Expression<System.Func<TBLTALEP, int>>) (r => r.ID)).First<int>().ToString());
            this.guncelID = num;
            YetkiClass.secim_id = num;
          }
          catch
          {
          }
          int num5 = (int) new FisEkle()
          {
            secim = 1,
            talepID = this.guncelID
          }.ShowDialog();
        }
      }
      else
      {
        try
        {
          FisEkle fisEkle = new FisEkle();
          fisEkle.secim = 2;
          this.guncelID = Convert.ToInt32((object) this.db.TBLTALEP.Where<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.KOD == this.fisKoduCombo.Text)).Select<TBLTALEP, int>((Expression<System.Func<TBLTALEP, int>>) (x => x.ID)));
          fisEkle.talepID = this.guncelID;
          int num = (int) fisEkle.ShowDialog();
        }
        catch (Exception ex)
        {
        }
      }
    }

    private void GelenListe()
    {
      this.gridControl1.DataSource = (object) this.db.TBLTALEPHRKT.Where<TBLTALEPHRKT>((Expression<System.Func<TBLTALEPHRKT, bool>>) (hd => hd.TALEPID == (int?) YetkiClass.secim_id)).ToList<TBLTALEPHRKT>();
      this.Listele();
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      new TalepeEkle().Show();
      this.Close();
    }

    private void indirButton_Click(object sender, EventArgs e)
    {
      if (this.secim == 2)
      {
        TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
        int num1;
        if (tbltalep.TEKLIFID.HasValue)
        {
          int? teklifid = tbltalep.TEKLIFID;
          int num2 = 0;
          num1 = teklifid.GetValueOrDefault() == num2 & teklifid.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
        if (num1 != 0)
        {
          if (this.fisKoduCombo.Text != "")
          {
            int num3 = (int) new TalepTeknikSartname().ShowDialog();
          }
          else
          {
            int num4 = (int) XtraMessageBox.Show("Talebi Kaydet");
          }
        }
        else
        {
          int num5 = (int) XtraMessageBox.Show("Teklife Atılan Talepler Düzenlenemez. Düzenleme İçin Teklif Silinmelidir.");
        }
      }
      if (this.secim != 1)
        return;
      if (this.fisKoduCombo.Text != "")
      {
        int num6 = (int) new TalepTeknikSartname().ShowDialog();
      }
      else
      {
        int num7 = (int) XtraMessageBox.Show("Talebi Kaydet");
      }
    }

    private void YazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView7_Click(object sender, EventArgs e)
    {
    }

    private void gridControl2_Click(object sender, EventArgs e)
    {
    }

    private void gridConrol1_Update()
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e) => this.gridView8.AddNewRow();

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      if (this.secim == 1)
      {
        TBLTALEPTEKNIKSART entity = new TBLTALEPTEKNIKSART();
        int num1 = this.db.TBLTALEPTEKNIKSART.Where<TBLTALEPTEKNIKSART>((Expression<System.Func<TBLTALEPTEKNIKSART, bool>>) (x => x.TALEPID == (int?) this.guncelID)).Count<TBLTALEPTEKNIKSART>();
        if (this.guncelID != 0)
        {
          try
          {
            for (int rowHandle = 0; rowHandle < this.gridControl2.MainView.DataRowCount; ++rowHandle)
            {
              int num2 = num1 + 1;
              entity.TALEPID = new int?(this.guncelID);
              entity.SIRANO = num2.ToString();
              entity.ACIKLAMA = this.gridView8.GetRowCellValue(rowHandle, this.colACIKLAMA).ToString();
              this.db.TBLTALEPTEKNIKSART.Add(entity);
              this.db.SaveChanges();
            }
          }
          catch (Exception ex)
          {
            int num3 = (int) XtraMessageBox.Show(ex.ToString());
            Console.WriteLine(ex.ToString());
          }
          this.tBLTALEPTEKNIKSARTTableAdapter1.FillBy(this.bellDataSet5.TBLTALEPTEKNIKSART, this.guncelID);
        }
      }
      if (this.secim != 2)
        return;
      TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
      int? teklifid = tbltalep.TEKLIFID;
      int num4;
      if (teklifid.HasValue)
      {
        teklifid = tbltalep.TEKLIFID;
        int num5 = 0;
        num4 = teklifid.GetValueOrDefault() == num5 & teklifid.HasValue ? 1 : 0;
      }
      else
        num4 = 1;
      if (num4 != 0)
      {
        TBLTALEPTEKNIKSART entity = new TBLTALEPTEKNIKSART();
        int num6 = this.db.TBLTALEPTEKNIKSART.Where<TBLTALEPTEKNIKSART>((Expression<System.Func<TBLTALEPTEKNIKSART, bool>>) (x => x.TALEPID == (int?) this.guncelID)).Count<TBLTALEPTEKNIKSART>();
        if (this.guncelID != 0)
        {
          try
          {
            for (int rowHandle = num6; rowHandle < this.gridControl2.MainView.DataRowCount; ++rowHandle)
            {
              int num7 = num6 + 1;
              entity.TALEPID = new int?(this.guncelID);
              entity.SIRANO = num7.ToString();
              entity.ACIKLAMA = this.gridView8.GetRowCellValue(rowHandle, this.colACIKLAMA).ToString();
              this.db.TBLTALEPTEKNIKSART.Add(entity);
              this.db.SaveChanges();
            }
          }
          catch (Exception ex)
          {
            int num8 = (int) XtraMessageBox.Show(ex.ToString());
            Console.WriteLine(ex.ToString());
          }
          this.tBLTALEPTEKNIKSARTTableAdapter1.FillBy(this.bellDataSet5.TBLTALEPTEKNIKSART, this.guncelID);
        }
      }
      else
      {
        int num9 = (int) XtraMessageBox.Show("Teklife Atılan Talepler Düzenlenemez. Düzenleme İçin Teklif Silinmelidir.");
      }
    }

    public void Listele()
    {
      this.gridControl2.DataSource = (object) this.db.TBLTALEPTEKNIKSART.Where<TBLTALEPTEKNIKSART>((Expression<System.Func<TBLTALEPTEKNIKSART, bool>>) (hd => hd.TALEPID == (int?) this.guncelID)).ToList<TBLTALEPTEKNIKSART>();
      this.gridControl1.DataSource = (object) this.db.TBLTALEPHRKT.Where<TBLTALEPHRKT>((Expression<System.Func<TBLTALEPHRKT, bool>>) (hc => hc.TALEPID == (int?) this.guncelID)).ToList<TBLTALEPHRKT>();
      this.konuCombo.Text = YetkiClass.secim;
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
      if (this.guncelID == 0)
        return;
      int? teklifid = tbltalep.TEKLIFID;
      int num1 = 0;
      if (teklifid.GetValueOrDefault() == num1 & teklifid.HasValue || !tbltalep.TEKLIFID.HasValue)
      {
        int satirSil = Convert.ToInt32(this.gridView8.GetFocusedRowCellValue("ID"));
        if (satirSil != 0)
        {
          try
          {
            this.db.TBLTALEPTEKNIKSART.Remove(this.db.TBLTALEPTEKNIKSART.FirstOrDefault<TBLTALEPTEKNIKSART>((Expression<System.Func<TBLTALEPTEKNIKSART, bool>>) (x => x.ID == satirSil)));
            this.db.SaveChanges();
            this.Listele();
          }
          catch (Exception ex)
          {
            int num2 = (int) XtraMessageBox.Show("Satırlar Zaten Boş");
          }
        }
        else
        {
          int num3 = (int) XtraMessageBox.Show("Silinecek Satır Yok");
        }
      }
      else
      {
        int num4 = (int) XtraMessageBox.Show("Teklife Atılan Talep Düzenlenemez");
      }
    }

    private void FisiCikarButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Talep Fişi Çıkarılacaktır", "Talep Fişi Çıkar", MessageBoxButtons.YesNo))
        return;
      this.FisCikar();
    }

    private void FisCikar()
    {
      int siinecekFis = Convert.ToInt32(this.gridView7.GetFocusedRowCellValue(this.colTALEPFISID));
      int int32 = Convert.ToInt32((object) this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID)).TEKLIFID);
      if (this.guncelID != 0 && int32 == 0)
      {
        try
        {
          this.db = new bellEntities();
          TBLTALEPFIS tbltalepfis = this.db.TBLTALEPFIS.First<TBLTALEPFIS>((Expression<System.Func<TBLTALEPFIS, bool>>) (x => x.ID == siinecekFis));
          int? talepkayitid = tbltalepfis.TALEPKAYITID;
          int num1 = 0;
          if (!(talepkayitid.GetValueOrDefault() == num1 & talepkayitid.HasValue))
          {
            tbltalepfis.TALEPKAYITID = new int?(Convert.ToInt32(0));
            this.db.SaveChanges();
            IQueryable<TBLTALEPHRKT> source = this.db.TBLTALEPHRKT.Where<TBLTALEPHRKT>((Expression<System.Func<TBLTALEPHRKT, bool>>) (hc => hc.TALEPFISID == (int?) siinecekFis));
            if (source.Count<TBLTALEPHRKT>() > 0)
            {
              foreach (TBLTALEPHRKT tbltalephrkt in (IEnumerable<TBLTALEPHRKT>) source)
              {
                TBLTALEPHRKT item = tbltalephrkt;
                this.db.TBLTALEPHRKT.Remove(this.db.TBLTALEPHRKT.FirstOrDefault<TBLTALEPHRKT>((Expression<System.Func<TBLTALEPHRKT, bool>>) (x => x.ID == item.ID)));
              }
              this.db.SaveChanges();
              this.Listele();
            }
            this.db.SaveChanges();
            int num2 = (int) XtraMessageBox.Show("fiş SİLME TAMAM");
            this.dataTable2TableAdapter.Fill(this.talepKayitTabloCek.DataTable2, new int?(this.guncelID));
          }
          else
          {
            int num3 = (int) XtraMessageBox.Show("Lütfen Silinecek Fişi Şeçin");
          }
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
          Console.WriteLine(ex.ToString());
        }
      }
      else
      {
        int num4 = (int) XtraMessageBox.Show("Teklife Atılan Talepte Değişiklik Yapılamaz");
      }
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 2)
        this.Duzenle();
      if (this.secim == 1)
        this.Kaydet();
      ((TalepListesi) Application.OpenForms["TalepListesi"]).listele();
    }

    private void Kaydet()
    {
      try
      {
        if (this.fisKoduCombo.Text == null || this.fisKoduCombo.Text == "")
        {
          this.fisKoduCombo.Text = this.son.talepKod();
          TBLTALEP entity = new TBLTALEP();
          entity.KOD = this.fisKoduCombo.Text;
          entity.SAAT = new DateTime?(Convert.ToDateTime(this.tarihCombo.DateTime));
          entity.BELGESAYI = this.belgeCombo.Text;
          entity.ISINADI = this.konuCombo.Text;
          entity.BELGETARIH = new DateTime?(Convert.ToDateTime(this.belgeTarihCombo.DateTime));
          entity.ISINTURUMIKTARI = this.ismiktariCombo.Text;
          entity.ISINYAPYERI = this.isyeriTxt.Text;
          entity.BUTCETERTIBI = this.butceCombo.Text;
          entity.IHALEUSULU = this.ihaleCombo.Text;
          entity.YAKLASIKMALIYET = this.maliyetCombo.Text;
          entity.KULLODENEKTUTAR = this.odenekCombo.Text;
          entity.DEPOYETKILIID = new int?(Convert.ToInt32(this.yetkiliCombo.EditValue));
          entity.ATOLYESEFID = new int?(Convert.ToInt32(this.sefCombo.EditValue));
          entity.MUDURID = new int?(Convert.ToInt32(this.mudurCombo.EditValue));
          entity.DAIREBSKID = new int?(Convert.ToInt32(this.baskanCombo.EditValue));
          entity.GENELSEKRETERID = new int?(Convert.ToInt32(this.sekreterCombo.EditValue));
          entity.GENELSEKYRDID = new int?(Convert.ToInt32(this.gsyCombo.EditValue));
          this.db.TBLTALEP.Add(entity);
          this.db.SaveChanges();
          YetkiClass.secim_id = entity.ID;
          this.guncelID = entity.ID;
          int num = (int) XtraMessageBox.Show("Talep Kaydedilmiştir.");
          this.secim = 2;
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Talep Zaten Kaydedilmiştir.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void Duzenle()
    {
      if (this.fisKoduCombo.Text == null)
        return;
      try
      {
        TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
        tbltalep.KOD = this.fisKoduCombo.Text;
        tbltalep.SAAT = new DateTime?(this.tarihCombo.DateTime);
        tbltalep.BELGESAYI = this.belgeCombo.Text;
        tbltalep.ISINADI = this.konuCombo.Text;
        tbltalep.BELGETARIH = new DateTime?(this.belgeTarihCombo.DateTime);
        tbltalep.ISINTURUMIKTARI = this.ismiktariCombo.Text;
        tbltalep.ISINYAPYERI = this.isyeriTxt.Text;
        tbltalep.BUTCETERTIBI = this.butceCombo.Text;
        tbltalep.IHALEUSULU = this.ihaleCombo.Text;
        tbltalep.YAKLASIKMALIYET = this.maliyetCombo.Text;
        tbltalep.KULLODENEKTUTAR = this.odenekCombo.Text;
        tbltalep.DEPOYETKILIID = new int?(Convert.ToInt32(this.yetkiliCombo.EditValue));
        tbltalep.ATOLYESEFID = new int?(Convert.ToInt32(this.sefCombo.EditValue));
        tbltalep.MUDURID = new int?(Convert.ToInt32(this.mudurCombo.EditValue));
        tbltalep.DAIREBSKID = new int?(Convert.ToInt32(this.baskanCombo.EditValue));
        tbltalep.GENELSEKRETERID = new int?(Convert.ToInt32(this.sekreterCombo.EditValue));
        tbltalep.GENELSEKYRDID = new int?(Convert.ToInt32(this.gsyCombo.EditValue));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Değişiklikler Başarı ile kaydedildi");
      }
      catch
      {
      }
    }

    private void Sil()
    {
      IQueryable<TBLTEKLIF> source = this.db.TBLTEKLIF.Where<TBLTEKLIF>((Expression<System.Func<TBLTEKLIF, bool>>) (hv => hv.TALEPID == (int?) this.guncelID));
      if (this.guncelID != 0 && source.Count<TBLTEKLIF>() == 0)
      {
        try
        {
          for (int rowHandle = 0; rowHandle < this.gridView7.DataRowCount; ++rowHandle)
          {
            int getirID = Convert.ToInt32(this.gridView7.GetRowCellValue(rowHandle, "ID"));
            Convert.ToInt32(this.gridView7.GetRowCellValue(rowHandle, "TALEPID"));
            DbSet<TBLTALEPFIS> tbltalepfis1 = this.db.TBLTALEPFIS;
            Expression<System.Func<TBLTALEPFIS, bool>> predicate1 = (Expression<System.Func<TBLTALEPFIS, bool>>) (hd => hd.TALEPKAYITID == (int?) this.guncelID);
            foreach (TBLTALEPFIS tbltalepfis2 in (IEnumerable<TBLTALEPFIS>) tbltalepfis1.Where<TBLTALEPFIS>(predicate1))
            {
              tbltalepfis2.TALEPKAYITID = new int?(0);
              tbltalepfis2.TALEPDURUMID = new int?(2);
            }
            DbSet<TBLTALEPHRKT> tbltalephrkt = this.db.TBLTALEPHRKT;
            Expression<System.Func<TBLTALEPHRKT, bool>> predicate2 = (Expression<System.Func<TBLTALEPHRKT, bool>>) (hd => hd.ID == getirID);
            foreach (TBLTALEPHRKT entity in (IEnumerable<TBLTALEPHRKT>) tbltalephrkt.Where<TBLTALEPHRKT>(predicate2))
              this.db.TBLTALEPHRKT.Remove(entity);
          }
          this.db.TBLTALEP.Remove(this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID)));
          this.db.SaveChanges();
          this.Close();
        }
        catch (Exception ex)
        {
          int num1 = (int) XtraMessageBox.Show("Veritabanı Hatası");
          int num2 = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Teklifi olan talepler silinemez");
      }
    }

    public void Getir(int gelenID)
    {
      this.guncelID = gelenID;
      TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
      this.fisKoduCombo.Enabled = false;
      if (this.secim == 2)
        this.SilButton.Enabled = false;
      this.YeniDosyaButton.Enabled = false;
      this.fisKoduCombo.Text = tbltalep.KOD;
      this.fisKoduCombo.IsAccessible = false;
      this.tarihCombo.DateTime = Convert.ToDateTime((object) tbltalep.SAAT);
      this.belgeCombo.Text = tbltalep.BELGESAYI;
      this.konuCombo.Text = tbltalep.ISINADI;
      this.belgeTarihCombo.DateTime = Convert.ToDateTime((object) tbltalep.BELGETARIH);
      this.ismiktariCombo.Text = tbltalep.ISINTURUMIKTARI;
      this.isyeriTxt.Text = tbltalep.ISINYAPYERI;
      this.butceCombo.EditValue = (object) tbltalep.BUTCETERTIBI;
      this.ihaleCombo.Text = tbltalep.IHALEUSULU;
      this.maliyetCombo.Text = tbltalep.YAKLASIKMALIYET;
      this.odenekCombo.EditValue = (object) tbltalep.KULLODENEKTUTAR;
      this.yetkiliCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.DEPOYETKILIID);
      this.sefCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.ATOLYESEFID);
      this.mudurCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.MUDURID);
      this.baskanCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.DAIREBSKID);
      this.sekreterCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.GENELSEKYRDID);
      this.gsyCombo.EditValue = (object) Convert.ToInt32((object) tbltalep.GENELSEKRETERID);
      this.Listele();
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim != 3)
        return;
      TBLTALEP tbltalep = this.db.TBLTALEP.FirstOrDefault<TBLTALEP>((Expression<System.Func<TBLTALEP, bool>>) (x => x.ID == this.guncelID));
      int? teklifid = tbltalep.TEKLIFID;
      int num1 = 0;
      if (teklifid.GetValueOrDefault() == num1 & teklifid.HasValue || !tbltalep.TEKLIFID.HasValue)
      {
        this.Sil();
        ((TalepListesi) Application.OpenForms["TalepListesi"]).listele();
      }
      else
      {
        int num2 = (int) XtraMessageBox.Show("Teklife Atılan Talepler Silinemez");
      }
    }

    public void SartnameGelen() => this.tBLTALEPTEKNIKSARTTableAdapter1.FillBy(this.bellDataSet5.TBLTALEPTEKNIKSART, this.guncelID);

    private void tekaracButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniRapor.Parameters["talepID"].Value = (object) this.guncelID;
        this.yeniRapor.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniRapor).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniRapor.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniRapor.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniRapor).ShowPreviewDialog();
    }

    private void cokluAracButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniCoklu.Parameters["talepID"].Value = (object) this.guncelID;
        this.yeniCoklu.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniCoklu).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniCoklu.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniCoklu.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniCoklu).ShowPreviewDialog();
    }

    private void talepMuhtelif_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniMuhtelif.Parameters["id"].Value = (object) 0;
        this.yeniMuhtelif.Parameters["id"].Visible = false;
        new ReportPrintTool((IReport) this.yeniMuhtelif).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniMuhtelif.Parameters["id"].Value = (object) this.guncelID;
      this.yeniMuhtelif.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) this.yeniMuhtelif).ShowPreviewDialog();
    }

    private void olurButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniOlur.Parameters["talepID"].Value = (object) 0;
        this.yeniOlur.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniOlur).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniOlur.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniOlur.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniOlur).ShowPreviewDialog();
    }

    private void odenekButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniOdenek.Parameters["talepID"].Value = (object) 0;
        this.yeniOdenek.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniOdenek).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniOdenek.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniOdenek.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniOdenek).ShowPreviewDialog();
    }

    private void ihaleButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniIhale.Parameters["talepID"].Value = (object) 0;
        this.yeniIhale.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniIhale).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniIhale.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniIhale.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniIhale).ShowPreviewDialog();
    }

    private void teknikButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.secim == 1)
      {
        this.yeniTeknik.Parameters["talepID"].Value = (object) 0;
        this.yeniTeknik.Parameters["talepID"].Visible = false;
        new ReportPrintTool((IReport) this.yeniTeknik).ShowPreviewDialog();
      }
      if (this.secim != 2)
        return;
      this.yeniTeknik.Parameters["talepID"].Value = (object) this.guncelID;
      this.yeniTeknik.Parameters["talepID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniTeknik).ShowPreviewDialog();
    }

    private void gridView7_CustomColumnDisplayText(
      object sender,
      CustomColumnDisplayTextEventArgs e)
    {
      if (!(e.Column.Caption == "S. No"))
        return;
      e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TalepEkle));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.tekaracButon = new BarButtonItem();
      this.cokluAracButon = new BarButtonItem();
      this.talepMuhtelif = new BarButtonItem();
      this.olurButon = new BarButtonItem();
      this.odenekButon = new BarButtonItem();
      this.ihaleButon = new BarButtonItem();
      this.teknikButon = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.FisEkleButton = new BarButtonItem();
      this.FisiCikarButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable2BindingSource = new BindingSource(this.components);
      this.talepKayitTabloCek = new TalepKayitTabloCek();
      this.gridView7 = new GridView();
      this.gridColumn9 = new GridColumn();
      this.colISEMRIID = new GridColumn();
      this.isemri = new RepositoryItemLookUpEdit();
      this.tBLISEMRIBindingSource1 = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colMALZEMEADI = new GridColumn();
      this.malAd = new RepositoryItemLookUpEdit();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.colMALZACIKLAMA = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.ARAC = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource2 = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridColumn6 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource1 = new BindingSource(this.components);
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.colTALEPFISID = new GridColumn();
      this.talepFisKod = new RepositoryItemLookUpEdit();
      this.tBLTALEPFISBindingSource = new BindingSource(this.components);
      this.colTALEPKAYITID = new GridColumn();
      this.talepKod = new RepositoryItemLookUpEdit();
      this.tBLTALEPBindingSource = new BindingSource(this.components);
      this.gridColumn8 = new GridColumn();
      this.personel = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.AraclarListesiTableAdapters.DataTable1TableAdapter();
      this.layoutControl1 = new LayoutControl();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.tenikEkleButton = new SimpleButton();
      this.gridControl2 = new GridControl();
      this.tBLTALEPTEKNIKSARTBindingSource2 = new BindingSource(this.components);
      this.gridView8 = new GridView();
      this.colID = new GridColumn();
      this.colTALEPID = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colACIKLAMA = new GridColumn();
      this.belgeTarihCombo = new DateEdit();
      this.konuCombo = new TextEdit();
      this.butceCombo = new TextEdit();
      this.belgeCombo = new MemoEdit();
      this.fisKoduCombo = new TextEdit();
      this.tarihCombo = new DateEdit();
      this.ismiktariCombo = new TextEdit();
      this.ihaleCombo = new TextEdit();
      this.maliyetCombo = new TextEdit();
      this.odenekCombo = new TextEdit();
      this.yetkiliCombo = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn3 = new GridColumn();
      this.sefCombo = new SearchLookUpEdit();
      this.gridView1 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.baskanCombo = new SearchLookUpEdit();
      this.gridView3 = new GridView();
      this.gridColumn4 = new GridColumn();
      this.gsyCombo = new SearchLookUpEdit();
      this.gridView4 = new GridView();
      this.gridColumn5 = new GridColumn();
      this.sekreterCombo = new SearchLookUpEdit();
      this.gridView5 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.mudurCombo = new SearchLookUpEdit();
      this.gridView6 = new GridView();
      this.adSoyad = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.isyeriTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem26 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.tBLTALEPTEKNIKSARTBindingSource1 = new BindingSource(this.components);
      this.talepTopla = new TalepTopla();
      this.dataTable1BindingSource2 = new BindingSource(this.components);
      this.tBLARACLARBindingSource1 = new BindingSource(this.components);
      this.aracBul = new aracBul();
      this.tBLTALEPTEKNIKSARTBindingSource = new BindingSource(this.components);
      this.tBLTEKLIFIDARISARTBindingSource = new BindingSource(this.components);
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutConverter1 = new LayoutConverter(this.components);
      this.bellDataSet = new bellDataSet();
      this.tBLMALZEMELERTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLMALZBIRIMTableAdapter();
      this.tBLTALEPFISTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPFISTableAdapter();
      this.tBLTALEPTEKNIKSARTTableAdapter = new Makina_Ikmal.bellDataSet2TableAdapters.TBLTALEPTEKNIKSARTTableAdapter();
      this.tBLTEKLIFIDARISARTTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTEKLIFIDARISARTTableAdapter();
      this.talepToplaBindingSource = new BindingSource(this.components);
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLARACLARTableAdapter();
      this.tBLARACLARTableAdapter1 = new Makina_Ikmal.Model.aracBulTableAdapters.TBLARACLARTableAdapter();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable1TableAdapter();
      this.dataTable2TableAdapter = new Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable2TableAdapter();
      this.tBLTALEPTEKNIKSARTTableAdapter1 = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTEKNIKSARTTableAdapter();
      this.dataTable1TableAdapter2 = new Makina_Ikmal.Model.TalepKayitTabloCekTableAdapters.DataTable1TableAdapter();
      this.tBLTALEPTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLTALEPTableAdapter();
      this.tBLMALZBIRIMTableAdapter1 = new Makina_Ikmal.bellDataSet7TableAdapters.TBLMALZBIRIMTableAdapter();
      this.tBLARACLARTableAdapter2 = new Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.popupMenu1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable2BindingSource).BeginInit();
      this.talepKayitTabloCek.BeginInit();
      this.gridView7.BeginInit();
      this.isemri.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).BeginInit();
      this.bellDataSet5.BeginInit();
      this.malAd.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.ARAC.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource2).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource1).BeginInit();
      this.talepFisKod.BeginInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).BeginInit();
      this.talepKod.BeginInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).BeginInit();
      this.personel.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.repositoryItemButtonEdit1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource2).BeginInit();
      this.gridView8.BeginInit();
      this.belgeTarihCombo.Properties.CalendarTimeProperties.BeginInit();
      this.belgeTarihCombo.Properties.BeginInit();
      this.konuCombo.Properties.BeginInit();
      this.butceCombo.Properties.BeginInit();
      this.belgeCombo.Properties.BeginInit();
      this.fisKoduCombo.Properties.BeginInit();
      this.tarihCombo.Properties.CalendarTimeProperties.BeginInit();
      this.tarihCombo.Properties.BeginInit();
      this.ismiktariCombo.Properties.BeginInit();
      this.ihaleCombo.Properties.BeginInit();
      this.maliyetCombo.Properties.BeginInit();
      this.odenekCombo.Properties.BeginInit();
      this.yetkiliCombo.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.sefCombo.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.baskanCombo.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.gsyCombo.Properties.BeginInit();
      this.gridView4.BeginInit();
      this.sekreterCombo.Properties.BeginInit();
      this.gridView5.BeginInit();
      this.mudurCombo.Properties.BeginInit();
      this.gridView6.BeginInit();
      this.isyeriTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem13.BeginInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource1).BeginInit();
      this.talepTopla.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).BeginInit();
      this.aracBul.BeginInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLTEKLIFIDARISARTBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.bellDataSet.BeginInit();
      ((ISupportInitialize) this.talepToplaBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
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
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.FisEkleButton,
        (BarItem) this.FisiCikarButton,
        (BarItem) this.tekaracButon,
        (BarItem) this.cokluAracButon,
        (BarItem) this.talepMuhtelif,
        (BarItem) this.olurButon,
        (BarItem) this.odenekButon,
        (BarItem) this.ihaleButon,
        (BarItem) this.teknikButon,
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 21;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1259, 100);
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
      this.YazdirButton.ActAsDropDown = true;
      this.YazdirButton.ButtonStyle = BarButtonStyle.DropDown;
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.DropDownControl = (PopupControl) this.popupMenu1;
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
      this.popupMenu1.ItemLinks.Add((BarItem) this.tekaracButon);
      this.popupMenu1.ItemLinks.Add((BarItem) this.cokluAracButon);
      this.popupMenu1.ItemLinks.Add((BarItem) this.talepMuhtelif);
      this.popupMenu1.ItemLinks.Add((BarItem) this.olurButon);
      this.popupMenu1.ItemLinks.Add((BarItem) this.odenekButon);
      this.popupMenu1.ItemLinks.Add((BarItem) this.ihaleButon);
      this.popupMenu1.ItemLinks.Add((BarItem) this.teknikButon);
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.tekaracButon.Caption = "Talep Tek Araç";
      this.tekaracButon.Id = 13;
      this.tekaracButon.Name = "tekaracButon";
      this.tekaracButon.ItemClick += new ItemClickEventHandler(this.tekaracButon_ItemClick);
      this.cokluAracButon.Caption = "Talep Çoklu Araç";
      this.cokluAracButon.Id = 14;
      this.cokluAracButon.Name = "cokluAracButon";
      this.cokluAracButon.ItemClick += new ItemClickEventHandler(this.cokluAracButon_ItemClick);
      this.talepMuhtelif.Caption = "Talep Muhtelif";
      this.talepMuhtelif.Id = 15;
      this.talepMuhtelif.Name = "talepMuhtelif";
      this.talepMuhtelif.ItemClick += new ItemClickEventHandler(this.talepMuhtelif_ItemClick);
      this.olurButon.Caption = "Olur Yazısı";
      this.olurButon.Id = 16;
      this.olurButon.Name = "olurButon";
      this.olurButon.ItemClick += new ItemClickEventHandler(this.olurButon_ItemClick);
      this.odenekButon.Caption = "Ödenek İzin Belgesi";
      this.odenekButon.Id = 17;
      this.odenekButon.Name = "odenekButon";
      this.odenekButon.ItemClick += new ItemClickEventHandler(this.odenekButon_ItemClick);
      this.ihaleButon.Caption = "İhale Onay Belgesi";
      this.ihaleButon.Id = 18;
      this.ihaleButon.Name = "ihaleButon";
      this.ihaleButon.ItemClick += new ItemClickEventHandler(this.ihaleButon_ItemClick);
      this.teknikButon.Caption = "Tenik Şartname";
      this.teknikButon.Id = 19;
      this.teknikButon.Name = "teknikButon";
      this.teknikButon.ItemClick += new ItemClickEventHandler(this.teknikButon_ItemClick);
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
      this.FisEkleButton.Caption = "Fiş Ekle";
      this.FisEkleButton.Id = 9;
      this.FisEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.Image");
      this.FisEkleButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisEkleButton.ImageOptions.LargeImage");
      this.FisEkleButton.LargeWidth = 100;
      this.FisEkleButton.Name = "FisEkleButton";
      this.FisEkleButton.RibbonStyle = RibbonItemStyles.Large;
      this.FisEkleButton.ItemClick += new ItemClickEventHandler(this.FisEkleButton_ItemClick);
      this.FisiCikarButton.Caption = "Fişi Çıkar";
      this.FisiCikarButton.Id = 10;
      this.FisiCikarButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.Image");
      this.FisiCikarButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("FisiCikarButton.ImageOptions.LargeImage");
      this.FisiCikarButton.LargeWidth = 100;
      this.FisiCikarButton.Name = "FisiCikarButton";
      this.FisiCikarButton.RibbonStyle = RibbonItemStyles.Large;
      this.FisiCikarButton.ItemClick += new ItemClickEventHandler(this.FisiCikarButton_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 20;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.dataTable2BindingSource;
      this.gridControl1.Location = new Point(12, 152);
      this.gridControl1.MainView = (BaseView) this.gridView7;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[7]
      {
        (RepositoryItem) this.malAd,
        (RepositoryItem) this.talepFisKod,
        (RepositoryItem) this.personel,
        (RepositoryItem) this.isemri,
        (RepositoryItem) this.talepKod,
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.ARAC
      });
      this.gridControl1.Size = new Size(1235, 337);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.UseEmbeddedNavigator = true;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView7
      });
      this.dataTable2BindingSource.DataMember = "DataTable2";
      this.dataTable2BindingSource.DataSource = (object) this.talepKayitTabloCek;
      this.talepKayitTabloCek.DataSetName = "TalepKayitTabloCek";
      this.talepKayitTabloCek.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView7.Columns.AddRange(new GridColumn[12]
      {
        this.gridColumn9,
        this.colISEMRIID,
        this.colMALZEMEADI,
        this.colMALZACIKLAMA,
        this.colPLAKA,
        this.gridColumn6,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.colTALEPFISID,
        this.colTALEPKAYITID,
        this.gridColumn8
      });
      this.gridView7.GridControl = this.gridControl1;
      this.gridView7.Name = "gridView7";
      this.gridView7.OptionsView.ShowGroupPanel = false;
      this.gridView7.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(this.gridView7_CustomColumnDisplayText);
      this.gridView7.Click += new EventHandler(this.gridView7_Click);
      this.gridColumn9.Caption = "S. No";
      this.gridColumn9.MinWidth = 21;
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 0;
      this.gridColumn9.Width = 81;
      this.colISEMRIID.ColumnEdit = (RepositoryItem) this.isemri;
      this.colISEMRIID.FieldName = "ISEMRIID";
      this.colISEMRIID.Name = "colISEMRIID";
      this.colISEMRIID.OptionsColumn.AllowEdit = false;
      this.colISEMRIID.OptionsColumn.ReadOnly = true;
      this.isemri.AutoHeight = false;
      this.isemri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isemri.DataSource = (object) this.tBLISEMRIBindingSource1;
      this.isemri.DisplayMember = "KOD";
      this.isemri.Name = "isemri";
      this.isemri.NullText = "";
      this.isemri.ValueMember = "ID";
      this.tBLISEMRIBindingSource1.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource1.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colMALZEMEADI.Caption = "Mal vea Hizemtin Adı";
      this.colMALZEMEADI.ColumnEdit = (RepositoryItem) this.malAd;
      this.colMALZEMEADI.FieldName = "MALZEMEID";
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 1;
      this.colMALZEMEADI.Width = 116;
      this.malAd.AutoHeight = false;
      this.malAd.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.malAd.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.malAd.DisplayMember = "MALZEMEADI";
      this.malAd.Name = "malAd";
      this.malAd.NullText = "";
      this.malAd.SuppressMouseEventOnOuterMouseClick = true;
      this.malAd.ValueMember = "ID";
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colMALZACIKLAMA.Caption = "Malzeme Açıklama";
      this.colMALZACIKLAMA.FieldName = "MALZACIKLAMA";
      this.colMALZACIKLAMA.Name = "colMALZACIKLAMA";
      this.colMALZACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colMALZACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colMALZACIKLAMA.Visible = true;
      this.colMALZACIKLAMA.VisibleIndex = 2;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.ColumnEdit = (RepositoryItem) this.ARAC;
      this.colPLAKA.FieldName = "ARACID";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 3;
      this.colPLAKA.Width = 116;
      this.ARAC.AutoHeight = false;
      this.ARAC.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ARAC.DataSource = (object) this.tBLARACLARBindingSource2;
      this.ARAC.DisplayMember = "PLAKA";
      this.ARAC.Name = "ARAC";
      this.ARAC.NullText = "";
      this.ARAC.ValueMember = "ID";
      this.tBLARACLARBindingSource2.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource2.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridColumn6.Caption = "Brim";
      this.gridColumn6.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn6.FieldName = "BIRIMID";
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 4;
      this.gridColumn6.Width = 116;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLMALZBIRIMBindingSource1;
      this.repositoryItemLookUpEdit1.DisplayMember = "BIRIMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource1.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource1.DataSource = (object) this.bellDataSet7;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.OptionsColumn.AllowEdit = false;
      this.colMIKTAR.OptionsColumn.ReadOnly = true;
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 5;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.OptionsColumn.AllowEdit = false;
      this.colFIYAT.OptionsColumn.ReadOnly = true;
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 6;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.OptionsColumn.AllowEdit = false;
      this.colTUTAR.OptionsColumn.ReadOnly = true;
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 7;
      this.colTALEPFISID.Caption = "Talep Fişi Kodu";
      this.colTALEPFISID.ColumnEdit = (RepositoryItem) this.talepFisKod;
      this.colTALEPFISID.FieldName = "TALEPFISID";
      this.colTALEPFISID.Name = "colTALEPFISID";
      this.colTALEPFISID.OptionsColumn.AllowEdit = false;
      this.colTALEPFISID.OptionsColumn.ReadOnly = true;
      this.colTALEPFISID.Visible = true;
      this.colTALEPFISID.VisibleIndex = 8;
      this.colTALEPFISID.Width = 116;
      this.talepFisKod.AutoHeight = false;
      this.talepFisKod.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.talepFisKod.DataSource = (object) this.tBLTALEPFISBindingSource;
      this.talepFisKod.DisplayMember = "KOD";
      this.talepFisKod.Name = "talepFisKod";
      this.talepFisKod.NullText = "";
      this.talepFisKod.ValueMember = "ID";
      this.tBLTALEPFISBindingSource.DataMember = "TBLTALEPFIS";
      this.tBLTALEPFISBindingSource.DataSource = (object) this.bellDataSet2;
      this.colTALEPKAYITID.Caption = "Talep Kodu";
      this.colTALEPKAYITID.ColumnEdit = (RepositoryItem) this.talepKod;
      this.colTALEPKAYITID.FieldName = "TALEPID";
      this.colTALEPKAYITID.Name = "colTALEPKAYITID";
      this.colTALEPKAYITID.OptionsColumn.AllowEdit = false;
      this.colTALEPKAYITID.OptionsColumn.ReadOnly = true;
      this.colTALEPKAYITID.Visible = true;
      this.colTALEPKAYITID.VisibleIndex = 9;
      this.colTALEPKAYITID.Width = (int) sbyte.MaxValue;
      this.talepKod.AutoHeight = false;
      this.talepKod.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.talepKod.DataSource = (object) this.tBLTALEPBindingSource;
      this.talepKod.DisplayMember = "KOD";
      this.talepKod.Name = "talepKod";
      this.talepKod.NullText = "";
      this.talepKod.ValueMember = "ID";
      this.tBLTALEPBindingSource.DataMember = "TBLTALEP";
      this.tBLTALEPBindingSource.DataSource = (object) this.bellDataSet5;
      this.gridColumn8.Caption = "gridColumn8";
      this.gridColumn8.FieldName = "ID";
      this.gridColumn8.MinWidth = 21;
      this.gridColumn8.Name = "gridColumn8";
      this.personel.AutoHeight = false;
      this.personel.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.personel.DataSource = (object) this.tBLPERSONELBindingSource;
      this.personel.DisplayMember = "ADISOYADI";
      this.personel.Name = "personel";
      this.personel.NullText = "";
      this.personel.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup3,
        this.ribbonPageGroup6
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
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.FisEkleButton);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.FisiCikarButton);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.YazdirButton, true);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.repositoryItemButtonEdit1.AutoHeight = false;
      this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton3);
      this.layoutControl1.Controls.Add((Control) this.simpleButton2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.tenikEkleButton);
      this.layoutControl1.Controls.Add((Control) this.gridControl2);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Controls.Add((Control) this.belgeTarihCombo);
      this.layoutControl1.Controls.Add((Control) this.konuCombo);
      this.layoutControl1.Controls.Add((Control) this.butceCombo);
      this.layoutControl1.Controls.Add((Control) this.belgeCombo);
      this.layoutControl1.Controls.Add((Control) this.fisKoduCombo);
      this.layoutControl1.Controls.Add((Control) this.tarihCombo);
      this.layoutControl1.Controls.Add((Control) this.ismiktariCombo);
      this.layoutControl1.Controls.Add((Control) this.ihaleCombo);
      this.layoutControl1.Controls.Add((Control) this.maliyetCombo);
      this.layoutControl1.Controls.Add((Control) this.odenekCombo);
      this.layoutControl1.Controls.Add((Control) this.yetkiliCombo);
      this.layoutControl1.Controls.Add((Control) this.sefCombo);
      this.layoutControl1.Controls.Add((Control) this.baskanCombo);
      this.layoutControl1.Controls.Add((Control) this.gsyCombo);
      this.layoutControl1.Controls.Add((Control) this.sekreterCombo);
      this.layoutControl1.Controls.Add((Control) this.mudurCombo);
      this.layoutControl1.Controls.Add((Control) this.isyeriTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(0, 100);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 324, 650, 400));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1259, 763);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl2.Location = new Point(647, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(600, 24);
      this.layoutControl2.TabIndex = 49;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(600, 24);
      this.layoutControlGroup1.TextVisible = false;
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton3.Location = new Point(12, 686);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(74, 65);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 48;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton2.Location = new Point(12, 621);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(74, 61);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton2.TabIndex = 47;
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton1.Location = new Point(12, 556);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(74, 61);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 46;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.tenikEkleButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("tenikEkleButton.ImageOptions.Image");
      this.tenikEkleButton.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.tenikEkleButton.Location = new Point(12, 493);
      this.tenikEkleButton.Name = "tenikEkleButton";
      this.tenikEkleButton.PaintStyle = PaintStyles.Light;
      this.tenikEkleButton.Size = new Size(74, 59);
      this.tenikEkleButton.StyleController = (IStyleController) this.layoutControl1;
      this.tenikEkleButton.TabIndex = 45;
      this.tenikEkleButton.Click += new EventHandler(this.indirButton_Click);
      this.gridControl2.DataSource = (object) this.tBLTALEPTEKNIKSARTBindingSource2;
      this.gridControl2.Location = new Point(90, 493);
      this.gridControl2.MainView = (BaseView) this.gridView8;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1157, 258);
      this.gridControl2.TabIndex = 8;
      this.gridControl2.UseEmbeddedNavigator = true;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView8
      });
      this.gridControl2.Click += new EventHandler(this.gridControl2_Click);
      this.tBLTALEPTEKNIKSARTBindingSource2.DataMember = "TBLTALEPTEKNIKSART";
      this.tBLTALEPTEKNIKSARTBindingSource2.DataSource = (object) this.bellDataSet5;
      this.gridView8.Columns.AddRange(new GridColumn[4]
      {
        this.colID,
        this.colTALEPID,
        this.colSIRANO,
        this.colACIKLAMA
      });
      this.gridView8.GridControl = this.gridControl2;
      this.gridView8.Name = "gridView8";
      this.gridView8.OptionsView.ShowGroupPanel = false;
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colTALEPID.FieldName = "TALEPID";
      this.colTALEPID.Name = "colTALEPID";
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.Visible = true;
      this.colSIRANO.VisibleIndex = 0;
      this.colSIRANO.Width = 83;
      this.colACIKLAMA.FieldName = "ACIKLAMA";
      this.colACIKLAMA.Name = "colACIKLAMA";
      this.colACIKLAMA.Visible = true;
      this.colACIKLAMA.VisibleIndex = 1;
      this.colACIKLAMA.Width = 536;
      this.belgeTarihCombo.EditValue = (object) null;
      this.belgeTarihCombo.Location = new Point(117, 124);
      this.belgeTarihCombo.Margin = new Padding(3, 2, 3, 2);
      this.belgeTarihCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.belgeTarihCombo.Name = "belgeTarihCombo";
      this.belgeTarihCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.belgeTarihCombo.Properties.Appearance.Options.UseFont = true;
      this.belgeTarihCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.belgeTarihCombo.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.belgeTarihCombo.Size = new Size(227, 24);
      this.belgeTarihCombo.StyleController = (IStyleController) this.layoutControl1;
      this.belgeTarihCombo.TabIndex = 33;
      this.konuCombo.Location = new Point(117, 68);
      this.konuCombo.Margin = new Padding(3, 2, 3, 2);
      this.konuCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.konuCombo.Name = "konuCombo";
      this.konuCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.konuCombo.Properties.Appearance.Options.UseFont = true;
      this.konuCombo.Size = new Size(227, 24);
      this.konuCombo.StyleController = (IStyleController) this.layoutControl1;
      this.konuCombo.TabIndex = 8;
      this.butceCombo.Location = new Point(471, 96);
      this.butceCombo.Margin = new Padding(3, 2, 3, 2);
      this.butceCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.butceCombo.Name = "butceCombo";
      this.butceCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.butceCombo.Properties.Appearance.Options.UseFont = true;
      this.butceCombo.Size = new Size(173, 24);
      this.butceCombo.StyleController = (IStyleController) this.layoutControl1;
      this.butceCombo.TabIndex = 29;
      this.belgeCombo.Location = new Point(117, 96);
      this.belgeCombo.Margin = new Padding(3, 2, 3, 2);
      this.belgeCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.belgeCombo.Name = "belgeCombo";
      this.belgeCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.belgeCombo.Properties.Appearance.Options.UseFont = true;
      this.belgeCombo.Properties.ScrollBars = ScrollBars.None;
      this.belgeCombo.Size = new Size(227, 24);
      this.belgeCombo.StyleController = (IStyleController) this.layoutControl1;
      this.belgeCombo.TabIndex = 6;
      this.fisKoduCombo.AllowDrop = true;
      this.fisKoduCombo.Location = new Point(118, 12);
      this.fisKoduCombo.Margin = new Padding(3, 2, 3, 2);
      this.fisKoduCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.fisKoduCombo.Name = "fisKoduCombo";
      this.fisKoduCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.fisKoduCombo.Properties.Appearance.Options.UseFont = true;
      this.fisKoduCombo.Size = new Size(525, 24);
      this.fisKoduCombo.StyleController = (IStyleController) this.layoutControl1;
      this.fisKoduCombo.TabIndex = 4;
      this.tarihCombo.EditValue = (object) null;
      this.tarihCombo.Location = new Point(117, 40);
      this.tarihCombo.Margin = new Padding(3, 2, 3, 2);
      this.tarihCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.tarihCombo.Name = "tarihCombo";
      this.tarihCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tarihCombo.Properties.Appearance.Options.UseFont = true;
      this.tarihCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihCombo.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tarihCombo.Properties.DisplayFormat.FormatString = "";
      this.tarihCombo.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.tarihCombo.Properties.EditFormat.FormatString = "";
      this.tarihCombo.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.tarihCombo.Properties.Mask.EditMask = "g";
      this.tarihCombo.Size = new Size(227, 24);
      this.tarihCombo.StyleController = (IStyleController) this.layoutControl1;
      this.tarihCombo.TabIndex = 13;
      this.ismiktariCombo.Location = new Point(470, 40);
      this.ismiktariCombo.Margin = new Padding(3, 2, 3, 2);
      this.ismiktariCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ismiktariCombo.Name = "ismiktariCombo";
      this.ismiktariCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ismiktariCombo.Properties.Appearance.Options.UseFont = true;
      this.ismiktariCombo.Size = new Size(174, 24);
      this.ismiktariCombo.StyleController = (IStyleController) this.layoutControl1;
      this.ismiktariCombo.TabIndex = 12;
      this.ihaleCombo.Location = new Point(469, 124);
      this.ihaleCombo.Margin = new Padding(3, 2, 3, 2);
      this.ihaleCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.ihaleCombo.Name = "ihaleCombo";
      this.ihaleCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.ihaleCombo.Properties.Appearance.Options.UseFont = true;
      this.ihaleCombo.Size = new Size(175, 24);
      this.ihaleCombo.StyleController = (IStyleController) this.layoutControl1;
      this.ihaleCombo.TabIndex = 5;
      this.maliyetCombo.Location = new Point(770, 40);
      this.maliyetCombo.Margin = new Padding(3, 2, 3, 2);
      this.maliyetCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.maliyetCombo.Name = "maliyetCombo";
      this.maliyetCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.maliyetCombo.Properties.Appearance.Options.UseFont = true;
      this.maliyetCombo.Properties.Mask.EditMask = "c2";
      this.maliyetCombo.Properties.Mask.MaskType = MaskType.Numeric;
      this.maliyetCombo.Size = new Size(166, 24);
      this.maliyetCombo.StyleController = (IStyleController) this.layoutControl1;
      this.maliyetCombo.TabIndex = 28;
      this.odenekCombo.EditValue = (object) "";
      this.odenekCombo.Location = new Point(768, 68);
      this.odenekCombo.Margin = new Padding(3, 2, 3, 2);
      this.odenekCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.odenekCombo.Name = "odenekCombo";
      this.odenekCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.odenekCombo.Properties.Appearance.Options.UseFont = true;
      this.odenekCombo.Properties.Mask.EditMask = "c0";
      this.odenekCombo.Properties.Mask.MaskType = MaskType.Numeric;
      this.odenekCombo.Size = new Size(168, 24);
      this.odenekCombo.StyleController = (IStyleController) this.layoutControl1;
      this.odenekCombo.TabIndex = 38;
      this.yetkiliCombo.Location = new Point(768, 96);
      this.yetkiliCombo.Margin = new Padding(3, 2, 3, 2);
      this.yetkiliCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.yetkiliCombo.Name = "yetkiliCombo";
      this.yetkiliCombo.Properties.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yetkiliCombo.Properties.Appearance.Options.UseFont = true;
      this.yetkiliCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yetkiliCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.yetkiliCombo.Properties.DisplayMember = "ADISOYADI";
      this.yetkiliCombo.Properties.NullText = "";
      this.yetkiliCombo.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.yetkiliCombo.Properties.ValueMember = "ID";
      this.yetkiliCombo.Size = new Size(168, 24);
      this.yetkiliCombo.StyleController = (IStyleController) this.layoutControl1;
      this.yetkiliCombo.TabIndex = 40;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Adı Soyadı";
      this.gridColumn3.FieldName = "ADISOYADI";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.sefCombo.EditValue = (object) 0;
      this.sefCombo.Location = new Point(752, 124);
      this.sefCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sefCombo.Name = "sefCombo";
      this.sefCombo.Properties.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sefCombo.Properties.Appearance.Options.UseFont = true;
      this.sefCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sefCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.sefCombo.Properties.DisplayMember = "ADISOYADI";
      this.sefCombo.Properties.NullText = "";
      this.sefCombo.Properties.PopupView = (ColumnView) this.gridView1;
      this.sefCombo.Properties.ValueMember = "ID";
      this.sefCombo.Size = new Size(184, 24);
      this.sefCombo.StyleController = (IStyleController) this.layoutControl1;
      this.sefCombo.TabIndex = 41;
      this.gridView1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Adı Soyadı";
      this.gridColumn2.FieldName = "ADISOYADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.baskanCombo.EditValue = (object) "";
      this.baskanCombo.Location = new Point(1044, 68);
      this.baskanCombo.Name = "baskanCombo";
      this.baskanCombo.Properties.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.baskanCombo.Properties.Appearance.Options.UseFont = true;
      this.baskanCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.baskanCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.baskanCombo.Properties.DisplayMember = "ADISOYADI";
      this.baskanCombo.Properties.NullText = "";
      this.baskanCombo.Properties.PopupView = (ColumnView) this.gridView3;
      this.baskanCombo.Properties.ValueMember = "ID";
      this.baskanCombo.Size = new Size(203, 24);
      this.baskanCombo.StyleController = (IStyleController) this.layoutControl1;
      this.baskanCombo.TabIndex = 42;
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Adı Soyadı";
      this.gridColumn4.FieldName = "ADISOYADI";
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.gsyCombo.Location = new Point(1044, 96);
      this.gsyCombo.Name = "gsyCombo";
      this.gsyCombo.Properties.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gsyCombo.Properties.Appearance.Options.UseFont = true;
      this.gsyCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gsyCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.gsyCombo.Properties.DisplayMember = "ADISOYADI";
      this.gsyCombo.Properties.NullText = "";
      this.gsyCombo.Properties.PopupView = (ColumnView) this.gridView4;
      this.gsyCombo.Properties.ValueMember = "ID";
      this.gsyCombo.Size = new Size(203, 24);
      this.gsyCombo.StyleController = (IStyleController) this.layoutControl1;
      this.gsyCombo.TabIndex = 42;
      this.gridView4.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Adı Soyadı";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.sekreterCombo.Location = new Point(1044, 124);
      this.sekreterCombo.Name = "sekreterCombo";
      this.sekreterCombo.Properties.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sekreterCombo.Properties.Appearance.Options.UseFont = true;
      this.sekreterCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.sekreterCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.sekreterCombo.Properties.DisplayMember = "ADISOYADI";
      this.sekreterCombo.Properties.NullText = "";
      this.sekreterCombo.Properties.PopupView = (ColumnView) this.gridView5;
      this.sekreterCombo.Properties.ValueMember = "ID";
      this.sekreterCombo.Size = new Size(203, 24);
      this.sekreterCombo.StyleController = (IStyleController) this.layoutControl1;
      this.sekreterCombo.TabIndex = 42;
      this.gridView5.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Adı Soyadı";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.mudurCombo.EditValue = (object) "0";
      this.mudurCombo.Location = new Point(1044, 40);
      this.mudurCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.mudurCombo.Name = "mudurCombo";
      this.mudurCombo.Properties.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mudurCombo.Properties.Appearance.Options.UseFont = true;
      this.mudurCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.mudurCombo.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.mudurCombo.Properties.DisplayMember = "ADISOYADI";
      this.mudurCombo.Properties.NullText = "";
      this.mudurCombo.Properties.PopupView = (ColumnView) this.gridView6;
      this.mudurCombo.Properties.ValueMember = "ID";
      this.mudurCombo.Size = new Size(203, 24);
      this.mudurCombo.StyleController = (IStyleController) this.layoutControl1;
      this.mudurCombo.TabIndex = 43;
      this.gridView6.Columns.AddRange(new GridColumn[2]
      {
        this.adSoyad,
        this.gridColumn7
      });
      this.gridView6.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.adSoyad.Caption = "Adı Soyadı";
      this.adSoyad.FieldName = "ADISOYADI";
      this.adSoyad.Name = "adSoyad";
      this.adSoyad.Visible = true;
      this.adSoyad.VisibleIndex = 0;
      this.gridColumn7.Caption = "gridColumn7";
      this.gridColumn7.FieldName = "ID";
      this.gridColumn7.Name = "gridColumn7";
      this.isyeriTxt.Location = new Point(470, 68);
      this.isyeriTxt.Margin = new Padding(3, 2, 3, 2);
      this.isyeriTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isyeriTxt.Name = "isyeriTxt";
      this.isyeriTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isyeriTxt.Properties.Appearance.Options.UseFont = true;
      this.isyeriTxt.Size = new Size(174, 24);
      this.isyeriTxt.StyleController = (IStyleController) this.layoutControl1;
      this.isyeriTxt.TabIndex = 11;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[24]
      {
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem26,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem13
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1259, 763);
      this.Root.TextVisible = false;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.konuCombo;
      this.layoutControlItem5.Location = new Point(0, 56);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(336, 28);
      this.layoutControlItem5.Text = "Konu/İşin Adı";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem5.TextSize = new Size(103, 13);
      this.layoutControlItem5.TextToControlDistance = 2;
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.tarihCombo;
      this.layoutControlItem10.Location = new Point(0, 28);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(336, 28);
      this.layoutControlItem10.Text = "Tarih/ Saat";
      this.layoutControlItem10.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem10.TextSize = new Size(103, 13);
      this.layoutControlItem10.TextToControlDistance = 2;
      this.layoutControlItem25.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem25.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem25.Control = (Control) this.maliyetCombo;
      this.layoutControlItem25.Location = new Point(636, 28);
      this.layoutControlItem25.MinSize = new Size(142, 28);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(292, 28);
      this.layoutControlItem25.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem25.Text = "Yaklaşık Maliyet";
      this.layoutControlItem25.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem25.TextSize = new Size(120, 13);
      this.layoutControlItem25.TextToControlDistance = 2;
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.odenekCombo;
      this.layoutControlItem22.Location = new Point(636, 56);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(292, 28);
      this.layoutControlItem22.Text = "Ödenek Tutarı";
      this.layoutControlItem22.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem22.TextSize = new Size(100, 13);
      this.layoutControlItem22.TextToControlDistance = 20;
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.isyeriTxt;
      this.layoutControlItem8.Location = new Point(336, 56);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(300, 28);
      this.layoutControlItem8.Text = "İşin Yapıldığı Yer";
      this.layoutControlItem8.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem8.TextSize = new Size(120, 16);
      this.layoutControlItem8.TextToControlDistance = 2;
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.ismiktariCombo;
      this.layoutControlItem9.Location = new Point(336, 28);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(300, 28);
      this.layoutControlItem9.Text = "İşin Türü Miktarı";
      this.layoutControlItem9.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem9.TextSize = new Size(120, 16);
      this.layoutControlItem9.TextToControlDistance = 2;
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.belgeTarihCombo;
      this.layoutControlItem20.Location = new Point(0, 112);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem20.Size = new Size(336, 28);
      this.layoutControlItem20.Text = "Belge Tarihi";
      this.layoutControlItem20.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem20.TextSize = new Size(103, 13);
      this.layoutControlItem20.TextToControlDistance = 2;
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.belgeCombo;
      this.layoutControlItem3.Location = new Point(0, 84);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem3.Size = new Size(336, 28);
      this.layoutControlItem3.Text = "Belge Sayı";
      this.layoutControlItem3.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem3.TextSize = new Size(103, 13);
      this.layoutControlItem3.TextToControlDistance = 2;
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.butceCombo;
      this.layoutControlItem26.Location = new Point(336, 84);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem26.Size = new Size(300, 28);
      this.layoutControlItem26.Text = "Bütçe Tertipi";
      this.layoutControlItem26.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem26.TextSize = new Size(118, 13);
      this.layoutControlItem26.TextToControlDistance = 5;
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.yetkiliCombo;
      this.layoutControlItem14.Location = new Point(636, 84);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(292, 28);
      this.layoutControlItem14.Text = "Depo Yetkilisi";
      this.layoutControlItem14.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem14.TextSize = new Size(100, 13);
      this.layoutControlItem14.TextToControlDistance = 20;
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.ihaleCombo;
      this.layoutControlItem2.Location = new Point(336, 112);
      this.layoutControlItem2.MinSize = new Size(142, 28);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(300, 28);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "İhale Usulü         ";
      this.layoutControlItem2.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem2.TextSize = new Size(86, 13);
      this.layoutControlItem2.TextToControlDistance = 35;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.sefCombo;
      this.layoutControlItem4.Location = new Point(636, 112);
      this.layoutControlItem4.MinSize = new Size(158, 24);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(292, 28);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Atolye Şefi";
      this.layoutControlItem4.TextSize = new Size(101, 16);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.baskanCombo;
      this.layoutControlItem7.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem7.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem7.Location = new Point(928, 56);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(311, 28);
      this.layoutControlItem7.Text = "Daire Başkanı";
      this.layoutControlItem7.TextSize = new Size(101, 16);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.gsyCombo;
      this.layoutControlItem11.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem11.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem11.Location = new Point(928, 84);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(311, 28);
      this.layoutControlItem11.Text = "Genel Sek. Yard.";
      this.layoutControlItem11.TextSize = new Size(101, 16);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.sekreterCombo;
      this.layoutControlItem12.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem12.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem12.Location = new Point(928, 112);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(311, 28);
      this.layoutControlItem12.Text = "Genel Sekreter";
      this.layoutControlItem12.TextSize = new Size(101, 16);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.mudurCombo;
      this.layoutControlItem6.Location = new Point(928, 28);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(311, 28);
      this.layoutControlItem6.Text = "Şube Müdürü";
      this.layoutControlItem6.TextSize = new Size(101, 16);
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.fisKoduCombo;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem1.Size = new Size(635, 28);
      this.layoutControlItem1.Text = "Fiş Kodu";
      this.layoutControlItem1.TextAlignMode = TextAlignModeItem.CustomSize;
      this.layoutControlItem1.TextLocation = Locations.Left;
      this.layoutControlItem1.TextSize = new Size(101, 17);
      this.layoutControlItem1.TextToControlDistance = 5;
      this.layoutControlItem23.Control = (Control) this.gridControl2;
      this.layoutControlItem23.Location = new Point(78, 481);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(1161, 262);
      this.layoutControlItem23.TextSize = new Size(0, 0);
      this.layoutControlItem23.TextVisible = false;
      this.layoutControlItem15.Control = (Control) this.gridControl1;
      this.layoutControlItem15.Location = new Point(0, 140);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(1239, 341);
      this.layoutControlItem15.TextSize = new Size(0, 0);
      this.layoutControlItem15.TextVisible = false;
      this.layoutControlItem16.Control = (Control) this.tenikEkleButton;
      this.layoutControlItem16.Location = new Point(0, 481);
      this.layoutControlItem16.MaxSize = new Size(78, 63);
      this.layoutControlItem16.MinSize = new Size(78, 63);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(78, 63);
      this.layoutControlItem16.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem16.TextSize = new Size(0, 0);
      this.layoutControlItem16.TextVisible = false;
      this.layoutControlItem17.Control = (Control) this.simpleButton1;
      this.layoutControlItem17.Location = new Point(0, 544);
      this.layoutControlItem17.MaxSize = new Size(78, 65);
      this.layoutControlItem17.MinSize = new Size(78, 65);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.Size = new Size(78, 65);
      this.layoutControlItem17.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem17.TextSize = new Size(0, 0);
      this.layoutControlItem17.TextVisible = false;
      this.layoutControlItem18.Control = (Control) this.simpleButton2;
      this.layoutControlItem18.Location = new Point(0, 609);
      this.layoutControlItem18.MaxSize = new Size(78, 65);
      this.layoutControlItem18.MinSize = new Size(78, 65);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(78, 65);
      this.layoutControlItem18.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem18.TextSize = new Size(0, 0);
      this.layoutControlItem18.TextVisible = false;
      this.layoutControlItem19.Control = (Control) this.simpleButton3;
      this.layoutControlItem19.Location = new Point(0, 674);
      this.layoutControlItem19.MaxSize = new Size(78, 69);
      this.layoutControlItem19.MinSize = new Size(78, 69);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(78, 69);
      this.layoutControlItem19.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem19.TextSize = new Size(0, 0);
      this.layoutControlItem19.TextVisible = false;
      this.layoutControlItem13.Control = (Control) this.layoutControl2;
      this.layoutControlItem13.Location = new Point(635, 0);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(604, 28);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.tBLTALEPTEKNIKSARTBindingSource1.DataMember = "TBLTALEPTEKNIKSART";
      this.tBLTALEPTEKNIKSARTBindingSource1.DataSource = (object) this.talepTopla;
      this.talepTopla.DataSetName = "TalepTopla";
      this.talepTopla.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.talepKayitTabloCek;
      this.tBLARACLARBindingSource1.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource1.DataSource = (object) this.aracBul;
      this.aracBul.DataSetName = "aracBul";
      this.aracBul.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLTALEPTEKNIKSARTBindingSource.DataMember = "TBLTALEPTEKNIKSART";
      this.tBLTALEPTEKNIKSARTBindingSource.DataSource = (object) this.bellDataSet2;
      this.tBLTEKLIFIDARISARTBindingSource.DataMember = "TBLTEKLIFIDARISART";
      this.tBLTEKLIFIDARISARTBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet2;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.bellDataSet.DataSetName = "bellDataSet";
      this.bellDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPFISTableAdapter.ClearBeforeFill = true;
      this.tBLTALEPTEKNIKSARTTableAdapter.ClearBeforeFill = true;
      this.tBLTEKLIFIDARISARTTableAdapter.ClearBeforeFill = true;
      this.talepToplaBindingSource.DataSource = (object) this.talepTopla;
      this.talepToplaBindingSource.Position = 0;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter1.ClearBeforeFill = true;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.dataTable2TableAdapter.ClearBeforeFill = true;
      this.tBLTALEPTEKNIKSARTTableAdapter1.ClearBeforeFill = true;
      this.dataTable1TableAdapter2.ClearBeforeFill = true;
      this.tBLTALEPTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter1.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter2.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1259, 863);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (TalepEkle);
      this.Text = "Talep Kayıt";
      this.Load += new EventHandler(this.TalepEkle_Load);
      this.ribbonControl1.EndInit();
      this.popupMenu1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable2BindingSource).EndInit();
      this.talepKayitTabloCek.EndInit();
      this.gridView7.EndInit();
      this.isemri.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).EndInit();
      this.bellDataSet5.EndInit();
      this.malAd.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.ARAC.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource2).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource1).EndInit();
      this.talepFisKod.EndInit();
      ((ISupportInitialize) this.tBLTALEPFISBindingSource).EndInit();
      this.talepKod.EndInit();
      ((ISupportInitialize) this.tBLTALEPBindingSource).EndInit();
      this.personel.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.repositoryItemButtonEdit1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource2).EndInit();
      this.gridView8.EndInit();
      this.belgeTarihCombo.Properties.CalendarTimeProperties.EndInit();
      this.belgeTarihCombo.Properties.EndInit();
      this.konuCombo.Properties.EndInit();
      this.butceCombo.Properties.EndInit();
      this.belgeCombo.Properties.EndInit();
      this.fisKoduCombo.Properties.EndInit();
      this.tarihCombo.Properties.CalendarTimeProperties.EndInit();
      this.tarihCombo.Properties.EndInit();
      this.ismiktariCombo.Properties.EndInit();
      this.ihaleCombo.Properties.EndInit();
      this.maliyetCombo.Properties.EndInit();
      this.odenekCombo.Properties.EndInit();
      this.yetkiliCombo.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.sefCombo.Properties.EndInit();
      this.gridView1.EndInit();
      this.baskanCombo.Properties.EndInit();
      this.gridView3.EndInit();
      this.gsyCombo.Properties.EndInit();
      this.gridView4.EndInit();
      this.sekreterCombo.Properties.EndInit();
      this.gridView5.EndInit();
      this.mudurCombo.Properties.EndInit();
      this.gridView6.EndInit();
      this.isyeriTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem25.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem26.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem13.EndInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource1).EndInit();
      this.talepTopla.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource1).EndInit();
      this.aracBul.EndInit();
      ((ISupportInitialize) this.tBLTALEPTEKNIKSARTBindingSource).EndInit();
      ((ISupportInitialize) this.tBLTEKLIFIDARISARTBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.emptySpaceItem1.EndInit();
      this.bellDataSet.EndInit();
      ((ISupportInitialize) this.talepToplaBindingSource).EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
