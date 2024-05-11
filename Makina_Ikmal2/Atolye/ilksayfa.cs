// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.ilksayfa
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Depo;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.MoldelAtolye;
using Makina_Ikmal.Model.MoldelAtolye.atolye_yagListesiTableAdapters;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class ilksayfa : Form
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private TabNavigationPage tabNavigationPage3;
    private TabNavigationPage tabNavigationPage2;
    private TabNavigationPage tabNavigationPage1;
    private GridControl gridControl2;
    private GridView gridView2;
    private SimpleButton simpleButton1;
    private TabPane tabPane1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private RepositoryItemLookUpEdit plaka;
    private BindingSource tBLARACLARBindingSource;
    private TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private RepositoryItemLookUpEdit aracigetiren;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemLookUpEdit isemirdurum;
    private BindingSource tBLISEMIRDURUMBindingSource;
    private TBLISEMIRDURUMTableAdapter tBLISEMIRDURUMTableAdapter;
    private RepositoryItemLookUpEdit bakimyeri;
    private BindingSource tBLBAKIMYERIBindingSource;
    private TBLBAKIMYERITableAdapter tBLBAKIMYERITableAdapter;
    private RepositoryItemLookUpEdit atolye;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private RepositoryItemLookUpEdit bakimderece;
    private RepositoryItemLookUpEdit bakimturu;
    private RepositoryItemLookUpEdit arizanedeni;
    private BAKIMDERECE bAKIMDERECE1;
    private BindingSource tAHBAKIMDERECEBindingSource;
    private Makina_Ikmal.BAKIMDERECETableAdapters.TAHBAKIMDERECETableAdapter tAHBAKIMDERECETableAdapter;
    private BAKIMTURU bAKIMTURU1;
    private BindingSource tAHBAKIMTURUBindingSource;
    private Makina_Ikmal.BAKIMTURUTableAdapters.TAHBAKIMTURUTableAdapter tAHBAKIMTURUTableAdapter;
    private ARIZANEDENI aRIZANEDENI1;
    private BindingSource tAHARIZANEDENIBindingSource;
    private Makina_Ikmal.ARIZANEDENITableAdapters.TAHARIZANEDENITableAdapter tAHARIZANEDENITableAdapter;
    private AtolyeListesi atolyeListesi;
    private BindingSource tBLISEMRIBindingSource1;
    private Makina_Ikmal.Model.AtolyeListesiTableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter1;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colATOLYEID;
    private GridColumn colARACID;
    private GridColumn colGIRISTARIH;
    private GridColumn colGIRISSAAT;
    private GridColumn colCIKISTARIH;
    private GridColumn colCIKISSAAT;
    private GridColumn colARIZANEDENIID;
    private GridColumn colBILDIRILENARIZA;
    private GridColumn colISEMRIDURUMID;
    private GridColumn colBAKIMYERIID;
    private GridColumn colBAKIMYERACKLM;
    private GridColumn colARACIGETIREN;
    private GridColumn colBAKIMKMSI;
    private GridColumn colSONRAKIBKMKM;
    private GridColumn colSONRAKIBKMTRH;
    private GridColumn colBAKIMSAATI;
    private GridColumn colSONRAKIBKMSAAT;
    private GridColumn colISEMRISIRANO;
    private GridColumn colYAPILANBAKIMOZETI;
    private GridColumn colIMZAATOLYESEFID;
    private GridColumn colISBITIMORANI;
    private GridColumn colBAKIMTURUID;
    private GridColumn colBAKIMDERECESIID;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit2;
    private GridColumn Yılı;
    private GridColumn ARACACIKLAMA;
    private BarButtonItem barButtonItem13;
    private BarEditItem aramaTxt;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private BarCheckItem barCheckItem6;
    private RibbonPageGroup ribbonPageGroup3;
    private GridControl gridControl3;
    private GridView gridView3;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private GridColumn gridColumn7;
    private GridColumn gridColumn8;
    private GridColumn gridColumn9;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private GridColumn gridColumn10;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private GridColumn gridColumn11;
    private GridColumn gridColumn12;
    private GridColumn gridColumn13;
    private GridColumn gridColumn14;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    private GridColumn gridColumn15;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
    private GridColumn gridColumn16;
    private GridColumn gridColumn17;
    private GridColumn gridColumn18;
    private GridColumn gridColumn19;
    private GridColumn gridColumn20;
    private GridColumn gridColumn21;
    private GridColumn gridColumn22;
    private GridColumn gridColumn23;
    private GridColumn gridColumn24;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit6;
    private GridColumn gridColumn25;
    private GridColumn gridColumn26;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit7;
    private GridColumn gridColumn27;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit8;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit3;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit4;
    private YagAtolyesi yagAtolyesi;
    private BindingSource tBLISEMRIBindingSource2;
    private Makina_Ikmal.Model.YagAtolyesiTableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter2;
    private GridControl gridControl4;
    private GridView gridView4;
    private GridColumn gridColumn28;
    private GridColumn gridColumn29;
    private GridColumn gridColumn30;
    private GridColumn gridColumn31;
    private GridColumn gridColumn32;
    private GridColumn gridColumn33;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit9;
    private GridColumn gridColumn34;
    private GridColumn gridColumn35;
    private GridColumn gridColumn36;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit10;
    private GridColumn gridColumn37;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit11;
    private GridColumn gridColumn38;
    private GridColumn gridColumn39;
    private GridColumn gridColumn40;
    private GridColumn gridColumn41;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit12;
    private GridColumn gridColumn42;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit13;
    private GridColumn gridColumn43;
    private GridColumn gridColumn44;
    private GridColumn gridColumn45;
    private GridColumn gridColumn46;
    private GridColumn gridColumn47;
    private GridColumn gridColumn48;
    private GridColumn gridColumn49;
    private GridColumn gridColumn50;
    private GridColumn gridColumn51;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit14;
    private GridColumn gridColumn52;
    private GridColumn gridColumn53;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit15;
    private GridColumn gridColumn54;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit16;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit5;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit6;
    private BarButtonItem barButtonItem17;
    private PopupMenu popupMenu1;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private BarButtonItem barButtonItem21;
    private BarButtonItem barButtonItem22;
    private RibbonPageGroup ribbonPageGroup5;
    private BarButtonItem barButtonItem23;
    private BarButtonItem barButtonItem24;
    private BarButtonItem barButtonItem25;
    private PopupMenu popupMenu2;
    private atolye_yagListesi atolye_yagListesi;
    private BindingSource yagMerkeziBindingSource;
    private yagMerkeziTableAdapter yagMerkeziTableAdapter;
    private BindingSource sarfAtolyeBindingSource;
    private sarfAtolyeTableAdapter sarfAtolyeTableAdapter;
    private BarButtonItem barButtonItem26;
    private RepositoryItemLookUpEdit ARACACIKLAMA1;
    private BarCheckItem barCheckItem7;

    public ilksayfa() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.yet.MenuYetkilendirme("Personel Listesi");
      this.listele();
      this.sayfa();
    }

    public void listele()
    {
      this.sarfAtolyeTableAdapter.Fill(this.atolye_yagListesi.sarfAtolye);
      this.yagMerkeziTableAdapter.Fill(this.atolye_yagListesi.yagMerkezi);
      this.tBLISEMRITableAdapter2.Fill(this.yagAtolyesi.TBLISEMRI);
      this.gridControl1.DataSource = (object) this.db.TBLISEMRI.Join((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, (Expression<System.Func<TBLISEMRI, int?>>) (hi => hi.ARACID), (Expression<System.Func<TBLARACLAR, int?>>) (ha => (int?) ha.ID), (hi, ha) => new
      {
        hi = hi,
        ha = ha
      }).Where(data => data.hi.BAKIMYERIID == (int?) 2 || data.hi.BAKIMYERIID == (int?) 2 || data.hi.BAKIMYERIID == (int?) 3 || data.hi.BAKIMYERIID == (int?) 0).Select(data => new
      {
        YIL = data.hi.GIRISSAAT.Value.Year,
        ID = data.hi.ID,
        KOD = data.hi.KOD,
        ATOLYEID = data.hi.ATOLYEID,
        GIRISTARIH = data.hi.GIRISTARIH,
        GIRISSAAT = data.hi.GIRISSAAT,
        CIKISTARIH = data.hi.CIKISTARIH,
        CIKISSAAT = data.hi.CIKISSAAT,
        ARIZANEDENIID = data.hi.ARIZANEDENIID,
        BILDIRILENARIZA = data.hi.BILDIRILENARIZA,
        BAKIMDERECESIID = data.hi.BAKIMDERECESIID,
        ISEMRIDURUMID = data.hi.ISEMRIDURUMID,
        BAKIMYERIID = data.hi.BAKIMYERIID,
        ARACIGETIREN = data.hi.ARACIGETIREN,
        BAKIMKMSI = data.hi.BAKIMKMSI,
        SONRAKIBKMKM = data.hi.SONRAKIBKMKM,
        SONRAKIBKMTRH = data.hi.SONRAKIBKMTRH,
        BAKIMSAATI = data.hi.BAKIMSAATI,
        SONRAKIBKMSAAT = data.hi.SONRAKIBKMSAAT,
        ISEMRISIRANO = data.hi.ISEMRISIRANO,
        IMZAATOLYESEFID = data.hi.IMZAATOLYESEFID,
        ISBITIMORANI = data.hi.ISBITIMORANI,
        BAKIMTURUID = data.hi.BAKIMTURUID,
        PLAKA = data.ha.PLAKA,
        ARACACIKLAMA = data.ha.ARACACIKLAMA
      }).ToList();
      this.tAHARIZANEDENITableAdapter.Fill(this.aRIZANEDENI1.TAHARIZANEDENI);
      this.tAHBAKIMTURUTableAdapter.Fill(this.bAKIMTURU1.TAHBAKIMTURU);
      this.tAHBAKIMDERECETableAdapter.Fill(this.bAKIMDERECE1.TAHBAKIMDERECE);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
      this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet5.TBLBAKIMYERI);
      this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet5.TBLISEMIRDURUM);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet5.TBLARACLAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet5.TBLISEMRI);
    }

    private void filtre()
    {
      this.gridView3.ActiveFilter.Clear();
      this.gridView3.ActiveFilterString = this.secmeislemi();
      this.gridView3.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.gridView4.ActiveFilter.Clear();
      this.gridView4.ActiveFilterString = this.secmeislemi();
      this.gridView4.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        new EkleFormu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl2_DoubleClick_1(object sender, EventArgs e)
    {
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("ID"));
      if (this.db.TBLDEPOFISHRKT.Join((IEnumerable<TBLDEPOFIS>) this.db.TBLDEPOFIS, (Expression<System.Func<TBLDEPOFISHRKT, int?>>) (hd => hd.DEPOFISID), (Expression<System.Func<TBLDEPOFIS, int?>>) (hy => (int?) hy.ID), (hd, hy) => new
      {
        hd = hd,
        hy = hy
      }).Join((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.hd.MALZEMEID, (Expression<System.Func<TBLMALZEMELER, int?>>) (ht => (int?) ht.ID), (data, ht) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        ht = ht
      }).Join((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, data => data.\u003C\u003Eh__TransparentIdentifier0.hd.BIRIMID, (Expression<System.Func<TBLMALZBIRIM, int?>>) (hk => (int?) hk.ID), (data, hk) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        hk = hk
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.GCKOD == "C" && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hy.ISEMRIID == (int?) YetkiClass.secim_id).Select(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd).Any<TBLDEPOFISHRKT>())
      {
        bitenrapor bitenrapor = new bitenrapor();
        bitenrapor.Parameters["plaka"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["aracBilgisi"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["isEmirkod"].Value = this.gridView2.GetFocusedRowCellValue("KOD");
        bitenrapor.Parameters["bariza"].Value = this.gridView2.GetFocusedRowCellValue("BILDIRILENARIZA");
        bitenrapor.Parameters["ctarih"].Value = this.gridView2.GetFocusedRowCellValue("CIKISTARIH");
        bitenrapor.Parameters["gtarih"].Value = this.gridView2.GetFocusedRowCellValue("GIRISTARIH");
        bitenrapor.Parameters["csaat"].Value = this.gridView2.GetFocusedRowCellValue("CIKISSAAT");
        bitenrapor.Parameters["gsaat"].Value = this.gridView2.GetFocusedRowCellValue("GIRISSAAT");
        bitenrapor.Parameters["sofor"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["atolyesef"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["bakimyeri"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["km"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenrapor.Parameters["isemir_id"].Value = this.gridView2.GetFocusedRowCellValue("ID");
        bitenrapor.Parameters["isemir_id"].Visible = false;
        bitenrapor.Parameters["km"].Visible = false;
        bitenrapor.Parameters["bakimyeri"].Visible = false;
        bitenrapor.Parameters["gsaat"].Visible = false;
        bitenrapor.Parameters["csaat"].Visible = false;
        bitenrapor.Parameters["atolyesef"].Visible = false;
        bitenrapor.Parameters["sofor"].Visible = false;
        bitenrapor.Parameters["gtarih"].Visible = false;
        bitenrapor.Parameters["ctarih"].Visible = false;
        bitenrapor.Parameters["bariza"].Visible = false;
        bitenrapor.Parameters["isEmirkod"].Visible = false;
        bitenrapor.Parameters["aracBilgisi"].Visible = false;
        bitenrapor.Parameters["plaka"].Visible = false;
        new ReportPrintTool((IReport) bitenrapor).ShowPreviewDialog();
      }
      else
      {
        bitenrapor_verisiz bitenraporVerisiz = new bitenrapor_verisiz();
        bitenraporVerisiz.Parameters["plaka"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["aracBilgisi"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["isEmirkod"].Value = this.gridView2.GetFocusedRowCellValue("KOD");
        bitenraporVerisiz.Parameters["bariza"].Value = this.gridView2.GetFocusedRowCellValue("BILDIRILENARIZA");
        bitenraporVerisiz.Parameters["ctarih"].Value = this.gridView2.GetFocusedRowCellValue("CIKISTARIH");
        bitenraporVerisiz.Parameters["gtarih"].Value = this.gridView2.GetFocusedRowCellValue("GIRISTARIH");
        bitenraporVerisiz.Parameters["csaat"].Value = this.gridView2.GetFocusedRowCellValue("CIKISSAAT");
        bitenraporVerisiz.Parameters["gsaat"].Value = this.gridView2.GetFocusedRowCellValue("GIRISSAAT");
        bitenraporVerisiz.Parameters["sofor"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["atolyesef"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["bakimyeri"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["km"].Value = this.gridView2.GetFocusedRowCellValue("PLAKA");
        bitenraporVerisiz.Parameters["isemir_id"].Value = this.gridView2.GetFocusedRowCellValue("ID");
        bitenraporVerisiz.Parameters["isemir_id"].Visible = false;
        bitenraporVerisiz.Parameters["km"].Visible = false;
        bitenraporVerisiz.Parameters["bakimyeri"].Visible = false;
        bitenraporVerisiz.Parameters["gsaat"].Visible = false;
        bitenraporVerisiz.Parameters["csaat"].Visible = false;
        bitenraporVerisiz.Parameters["atolyesef"].Visible = false;
        bitenraporVerisiz.Parameters["sofor"].Visible = false;
        bitenraporVerisiz.Parameters["gtarih"].Visible = false;
        bitenraporVerisiz.Parameters["ctarih"].Visible = false;
        bitenraporVerisiz.Parameters["bariza"].Visible = false;
        bitenraporVerisiz.Parameters["isEmirkod"].Visible = false;
        bitenraporVerisiz.Parameters["aracBilgisi"].Visible = false;
        bitenraporVerisiz.Parameters["plaka"].Visible = false;
        new ReportPrintTool((IReport) bitenraporVerisiz).ShowPreviewDialog();
      }
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      int int32 = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID"));
      if (Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID")) == 1)
      {
        e.Appearance.BackColor = Color.Yellow;
      }
      else
      {
        switch (int32)
        {
          case 2:
            e.Appearance.BackColor = Color.LightBlue;
            break;
          case 3:
            e.Appearance.BackColor = Color.PaleGreen;
            break;
          case 4:
            e.Appearance.BackColor = Color.MediumPurple;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.AliceBlue;
            break;
        }
      }
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_kodu = this.gridView1.GetFocusedRowCellValue("KOD").ToString();
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        new EkleFormu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.tabPane1.SelectedPage.Name == "tabNavigationPage1")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        int num = (int) new isemirDetay().ShowDialog();
      }
      else if (this.tabPane1.SelectedPage.Name == "tabNavigationPage2")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
        int num = (int) new isemirDetay_Yag().ShowDialog();
      }
      else if (!(this.tabPane1.SelectedPage.Name == "tabNavigationPage3"))
        ;
    }

    private void gridControl1_Click(object sender, EventArgs e) => YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private string secmeislemi()
    {
      this.secme = "";
      string str = "";
      if (this.barCheckItem1.Checked)
        this.secme += "[ISEMRIDURUMID] = 1 OR";
      if (this.barCheckItem2.Checked)
        this.secme += "  [ISEMRIDURUMID] = 2 OR";
      if (this.barCheckItem3.Checked)
        this.secme += "[ISEMRIDURUMID] = 3 OR";
      if (this.barCheckItem4.Checked)
        this.secme += "[ISEMRIDURUMID] = 4 OR";
      if (this.barCheckItem5.Checked)
        this.secme += "[ISEMRIDURUMID] = 5 OR";
      if (this.barCheckItem6.Checked)
        this.secme += "[ISEMRIDURUMID] = 6 OR";
      if (this.barCheckItem7.Checked)
        this.secme += "[ISEMRIDURUMID] = 7 OR";
      try
      {
        str = this.secme.Substring(0, this.secme.Length - 2);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
    {
      biten_ana_ekran bitenAnaEkran = new biten_ana_ekran();
      bitenAnaEkran.Parameters["idemir"].Value = (object) Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      bitenAnaEkran.Parameters["idemir"].Visible = false;
      new ReportPrintTool((IReport) bitenAnaEkran).ShowPreviewDialog();
    }

    private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new isbitenEmirTarih().ShowDialog();
    }

    private void tabPane1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void tabPane1_Click(object sender, EventArgs e)
    {
    }

    private void tabPane1_Click_1(object sender, EventArgs e)
    {
      this.aramaTxt.EditValue = (object) "";
      this.sayfa();
    }

    private void sayfa()
    {
      if (this.tabPane1.SelectedPage.Name == "tabNavigationPage1")
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      else if (this.tabPane1.SelectedPage.Name == "tabNavigationPage2")
      {
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;
      }
      else
      {
        if (!(this.tabPane1.SelectedPage.Name == "tabNavigationPage3"))
          return;
        this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl4;
      }
    }

    private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      int int32 = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID"));
      if (Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID")) == 1)
      {
        e.Appearance.BackColor = Color.Yellow;
      }
      else
      {
        switch (int32)
        {
          case 2:
            e.Appearance.BackColor = Color.LightBlue;
            break;
          case 3:
            e.Appearance.BackColor = Color.PaleGreen;
            break;
          case 4:
            e.Appearance.BackColor = Color.MediumPurple;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.AliceBlue;
            break;
        }
      }
    }

    private void gridView4_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      int int32 = Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID"));
      if (Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "ISEMRIDURUMID")) == 1)
      {
        e.Appearance.BackColor = Color.Yellow;
      }
      else
      {
        switch (int32)
        {
          case 2:
            e.Appearance.BackColor = Color.LightBlue;
            break;
          case 3:
            e.Appearance.BackColor = Color.PaleGreen;
            break;
          case 4:
            e.Appearance.BackColor = Color.MediumPurple;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.AliceBlue;
            break;
        }
      }
    }

    private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        TalepKayıt talepKayıt = new TalepKayıt();
        YetkiClass.secim = "kayıt";
        int num = (int) talepKayıt.ShowDialog();
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e) => this.yazdir(this.gridControl1);

    private void yazdir(GridControl grid)
    {
      if (!grid.IsPrintingAvailable)
      {
        int num = (int) MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
      }
      else
        grid.ShowPrintPreview();
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.tabPane1.SelectedPage.Name == "tabNavigationPage1")
      {
        if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
        {
          YetkiClass.secim = "guncelle";
          YetkiClass.secim_kodu = this.gridView1.GetFocusedRowCellValue("KOD").ToString();
          YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
          new EkleFormu().Show();
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Burada yetkiniz yok");
        }
      }
      else if (this.tabPane1.SelectedPage.Name == "tabNavigationPage2")
      {
        if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
        {
          YetkiClass.secim = "guncelle";
          YetkiClass.secim_kodu = this.gridView3.GetFocusedRowCellValue("KOD").ToString();
          YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
          new YagEmri().Show();
        }
        else
        {
          int num2 = (int) XtraMessageBox.Show("Burada yetkiniz yok");
        }
      }
      else
      {
        if (!(this.tabPane1.SelectedPage.Name == "tabNavigationPage3"))
          return;
        if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
        {
          YetkiClass.secim = "guncelle";
          YetkiClass.secim_kodu = this.gridView4.GetFocusedRowCellValue("KOD").ToString();
          YetkiClass.secim_id = Convert.ToInt32(this.gridView4.GetFocusedRowCellValue("ID"));
          new isemriTalep().Show();
        }
        else
        {
          int num3 = (int) XtraMessageBox.Show("Burada yetkiniz yok");
        }
      }
    }

    private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new isemriTalep().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new YagEmri().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "kayıt";
        new EkleFormu().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void gridView3_DoubleClick(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_kodu = this.gridView3.GetFocusedRowCellValue("KOD").ToString();
        YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
        new YagEmri().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void gridView4_DoubleClick(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = Convert.ToInt32(this.gridView4.GetFocusedRowCellValue("ID"));
        YetkiClass.secim_kodu = this.gridView4.GetFocusedRowCellValue("KOD").ToString();
        new isemriTalep().Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barCheckItem7_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ilksayfa));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.popupMenu2 = new PopupMenu(this.components);
      this.barButtonItem23 = new BarButtonItem();
      this.barButtonItem24 = new BarButtonItem();
      this.barButtonItem25 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem13 = new BarButtonItem();
      this.aramaTxt = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLISEMRIBindingSource1 = new BindingSource(this.components);
      this.atolyeListesi = new AtolyeListesi();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.Yılı = new GridColumn();
      this.colGIRISTARIH = new GridColumn();
      this.colARACIGETIREN = new GridColumn();
      this.colARACID = new GridColumn();
      this.ARACACIKLAMA = new GridColumn();
      this.colBILDIRILENARIZA = new GridColumn();
      this.colISEMRIDURUMID = new GridColumn();
      this.isemirdurum = new RepositoryItemLookUpEdit();
      this.tBLISEMIRDURUMBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.colATOLYEID = new GridColumn();
      this.atolye = new RepositoryItemLookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.colGIRISSAAT = new GridColumn();
      this.colCIKISTARIH = new GridColumn();
      this.colCIKISSAAT = new GridColumn();
      this.colARIZANEDENIID = new GridColumn();
      this.arizanedeni = new RepositoryItemLookUpEdit();
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.aRIZANEDENI1 = new ARIZANEDENI();
      this.colBAKIMYERIID = new GridColumn();
      this.bakimyeri = new RepositoryItemLookUpEdit();
      this.tBLBAKIMYERIBindingSource = new BindingSource(this.components);
      this.colBAKIMYERACKLM = new GridColumn();
      this.colBAKIMKMSI = new GridColumn();
      this.colSONRAKIBKMKM = new GridColumn();
      this.colSONRAKIBKMTRH = new GridColumn();
      this.colBAKIMSAATI = new GridColumn();
      this.colSONRAKIBKMSAAT = new GridColumn();
      this.colISEMRISIRANO = new GridColumn();
      this.colYAPILANBAKIMOZETI = new GridColumn();
      this.colIMZAATOLYESEFID = new GridColumn();
      this.aracigetiren = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.colISBITIMORANI = new GridColumn();
      this.colBAKIMTURUID = new GridColumn();
      this.bakimturu = new RepositoryItemLookUpEdit();
      this.tAHBAKIMTURUBindingSource = new BindingSource(this.components);
      this.bAKIMTURU1 = new BAKIMTURU();
      this.colBAKIMDERECESIID = new GridColumn();
      this.bakimderece = new RepositoryItemLookUpEdit();
      this.tAHBAKIMDERECEBindingSource = new BindingSource(this.components);
      this.bAKIMDERECE1 = new BAKIMDERECE();
      this.plaka = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.repositoryItemTimeSpanEdit1 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit2 = new RepositoryItemTimeSpanEdit();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barButtonItem17 = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem26 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barButtonItem21 = new BarButtonItem();
      this.barButtonItem22 = new BarButtonItem();
      this.barCheckItem7 = new BarCheckItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.tabNavigationPage3 = new TabNavigationPage();
      this.gridControl4 = new GridControl();
      this.sarfAtolyeBindingSource = new BindingSource(this.components);
      this.atolye_yagListesi = new atolye_yagListesi();
      this.gridView4 = new GridView();
      this.gridColumn28 = new GridColumn();
      this.gridColumn29 = new GridColumn();
      this.gridColumn30 = new GridColumn();
      this.gridColumn31 = new GridColumn();
      this.gridColumn32 = new GridColumn();
      this.gridColumn33 = new GridColumn();
      this.repositoryItemLookUpEdit9 = new RepositoryItemLookUpEdit();
      this.gridColumn34 = new GridColumn();
      this.gridColumn35 = new GridColumn();
      this.gridColumn36 = new GridColumn();
      this.repositoryItemLookUpEdit10 = new RepositoryItemLookUpEdit();
      this.gridColumn37 = new GridColumn();
      this.repositoryItemLookUpEdit11 = new RepositoryItemLookUpEdit();
      this.gridColumn38 = new GridColumn();
      this.gridColumn39 = new GridColumn();
      this.gridColumn40 = new GridColumn();
      this.gridColumn41 = new GridColumn();
      this.repositoryItemLookUpEdit12 = new RepositoryItemLookUpEdit();
      this.gridColumn42 = new GridColumn();
      this.repositoryItemLookUpEdit13 = new RepositoryItemLookUpEdit();
      this.gridColumn43 = new GridColumn();
      this.gridColumn44 = new GridColumn();
      this.gridColumn45 = new GridColumn();
      this.gridColumn46 = new GridColumn();
      this.gridColumn47 = new GridColumn();
      this.gridColumn48 = new GridColumn();
      this.gridColumn49 = new GridColumn();
      this.gridColumn50 = new GridColumn();
      this.gridColumn51 = new GridColumn();
      this.repositoryItemLookUpEdit14 = new RepositoryItemLookUpEdit();
      this.gridColumn52 = new GridColumn();
      this.gridColumn53 = new GridColumn();
      this.repositoryItemLookUpEdit15 = new RepositoryItemLookUpEdit();
      this.gridColumn54 = new GridColumn();
      this.repositoryItemLookUpEdit16 = new RepositoryItemLookUpEdit();
      this.repositoryItemTimeSpanEdit5 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit6 = new RepositoryItemTimeSpanEdit();
      this.tBLISEMRIBindingSource2 = new BindingSource(this.components);
      this.yagAtolyesi = new YagAtolyesi();
      this.tabNavigationPage2 = new TabNavigationPage();
      this.gridControl3 = new GridControl();
      this.yagMerkeziBindingSource = new BindingSource(this.components);
      this.gridView3 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.gridColumn7 = new GridColumn();
      this.gridColumn8 = new GridColumn();
      this.gridColumn9 = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.gridColumn10 = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.gridColumn11 = new GridColumn();
      this.gridColumn12 = new GridColumn();
      this.gridColumn13 = new GridColumn();
      this.gridColumn14 = new GridColumn();
      this.repositoryItemLookUpEdit4 = new RepositoryItemLookUpEdit();
      this.gridColumn15 = new GridColumn();
      this.repositoryItemLookUpEdit5 = new RepositoryItemLookUpEdit();
      this.gridColumn16 = new GridColumn();
      this.gridColumn17 = new GridColumn();
      this.gridColumn18 = new GridColumn();
      this.gridColumn19 = new GridColumn();
      this.gridColumn20 = new GridColumn();
      this.gridColumn21 = new GridColumn();
      this.gridColumn22 = new GridColumn();
      this.gridColumn23 = new GridColumn();
      this.gridColumn24 = new GridColumn();
      this.repositoryItemLookUpEdit6 = new RepositoryItemLookUpEdit();
      this.gridColumn25 = new GridColumn();
      this.gridColumn26 = new GridColumn();
      this.repositoryItemLookUpEdit7 = new RepositoryItemLookUpEdit();
      this.gridColumn27 = new GridColumn();
      this.repositoryItemLookUpEdit8 = new RepositoryItemLookUpEdit();
      this.repositoryItemTimeSpanEdit3 = new RepositoryItemTimeSpanEdit();
      this.repositoryItemTimeSpanEdit4 = new RepositoryItemTimeSpanEdit();
      this.ARACACIKLAMA1 = new RepositoryItemLookUpEdit();
      this.tabNavigationPage1 = new TabNavigationPage();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.simpleButton1 = new SimpleButton();
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tabPane1 = new TabPane();
      this.tBLISEMRITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter();
      this.tBLARACLARTableAdapter = new TBLARACLARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLISEMIRDURUMTableAdapter = new TBLISEMIRDURUMTableAdapter();
      this.tBLBAKIMYERITableAdapter = new TBLBAKIMYERITableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.tAHBAKIMDERECETableAdapter = new Makina_Ikmal.BAKIMDERECETableAdapters.TAHBAKIMDERECETableAdapter();
      this.tAHBAKIMTURUTableAdapter = new Makina_Ikmal.BAKIMTURUTableAdapters.TAHBAKIMTURUTableAdapter();
      this.tAHARIZANEDENITableAdapter = new Makina_Ikmal.ARIZANEDENITableAdapters.TAHARIZANEDENITableAdapter();
      this.tBLISEMRITableAdapter1 = new Makina_Ikmal.Model.AtolyeListesiTableAdapters.TBLISEMRITableAdapter();
      this.tBLISEMRITableAdapter2 = new Makina_Ikmal.Model.YagAtolyesiTableAdapters.TBLISEMRITableAdapter();
      this.yagMerkeziTableAdapter = new yagMerkeziTableAdapter();
      this.sarfAtolyeTableAdapter = new sarfAtolyeTableAdapter();
      this.ribbonControl1.BeginInit();
      this.popupMenu2.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).BeginInit();
      this.atolyeListesi.BeginInit();
      this.gridView1.BeginInit();
      this.isemirdurum.BeginInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.atolye.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.arizanedeni.BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
      this.aRIZANEDENI1.BeginInit();
      this.bakimyeri.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).BeginInit();
      this.aracigetiren.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bakimturu.BeginInit();
      ((ISupportInitialize) this.tAHBAKIMTURUBindingSource).BeginInit();
      this.bAKIMTURU1.BeginInit();
      this.bakimderece.BeginInit();
      ((ISupportInitialize) this.tAHBAKIMDERECEBindingSource).BeginInit();
      this.bAKIMDERECE1.BeginInit();
      this.plaka.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.repositoryItemTimeSpanEdit1.BeginInit();
      this.repositoryItemTimeSpanEdit2.BeginInit();
      this.popupMenu1.BeginInit();
      this.tabNavigationPage3.SuspendLayout();
      this.gridControl4.BeginInit();
      ((ISupportInitialize) this.sarfAtolyeBindingSource).BeginInit();
      this.atolye_yagListesi.BeginInit();
      this.gridView4.BeginInit();
      this.repositoryItemLookUpEdit9.BeginInit();
      this.repositoryItemLookUpEdit10.BeginInit();
      this.repositoryItemLookUpEdit11.BeginInit();
      this.repositoryItemLookUpEdit12.BeginInit();
      this.repositoryItemLookUpEdit13.BeginInit();
      this.repositoryItemLookUpEdit14.BeginInit();
      this.repositoryItemLookUpEdit15.BeginInit();
      this.repositoryItemLookUpEdit16.BeginInit();
      this.repositoryItemTimeSpanEdit5.BeginInit();
      this.repositoryItemTimeSpanEdit6.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource2).BeginInit();
      this.yagAtolyesi.BeginInit();
      this.tabNavigationPage2.SuspendLayout();
      this.gridControl3.BeginInit();
      ((ISupportInitialize) this.yagMerkeziBindingSource).BeginInit();
      this.gridView3.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.repositoryItemLookUpEdit4.BeginInit();
      this.repositoryItemLookUpEdit5.BeginInit();
      this.repositoryItemLookUpEdit6.BeginInit();
      this.repositoryItemLookUpEdit7.BeginInit();
      this.repositoryItemLookUpEdit8.BeginInit();
      this.repositoryItemTimeSpanEdit3.BeginInit();
      this.repositoryItemTimeSpanEdit4.BeginInit();
      this.ARACACIKLAMA1.BeginInit();
      this.tabNavigationPage1.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView2.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      ((ISupportInitialize) this.tabPane1).BeginInit();
      this.tabPane1.SuspendLayout();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[36]
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
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem13,
        (BarItem) this.aramaTxt,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barButtonItem17,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barButtonItem21,
        (BarItem) this.barButtonItem22,
        (BarItem) this.barButtonItem23,
        (BarItem) this.barButtonItem24,
        (BarItem) this.barButtonItem25,
        (BarItem) this.barButtonItem26,
        (BarItem) this.barCheckItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 35;
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
      this.ribbonControl1.Size = new Size(1042, 96);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.DropDownControl = (PopupControl) this.popupMenu2;
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem23);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem24);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem25);
      this.popupMenu2.Name = "popupMenu2";
      this.popupMenu2.Ribbon = this.ribbonControl1;
      this.barButtonItem23.Caption = "Atölye";
      this.barButtonItem23.Id = 30;
      this.barButtonItem23.Name = "barButtonItem23";
      this.barButtonItem23.ItemClick += new ItemClickEventHandler(this.barButtonItem23_ItemClick);
      this.barButtonItem24.Caption = "Yağ Emri";
      this.barButtonItem24.Id = 31;
      this.barButtonItem24.Name = "barButtonItem24";
      this.barButtonItem24.ItemClick += new ItemClickEventHandler(this.barButtonItem24_ItemClick);
      this.barButtonItem25.Caption = "Atölye Talep";
      this.barButtonItem25.Id = 32;
      this.barButtonItem25.Name = "barButtonItem25";
      this.barButtonItem25.ItemClick += new ItemClickEventHandler(this.barButtonItem25_ItemClick);
      this.barButtonItem2.Caption = "Düzenle";
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
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.Caption = "Yenile";
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
      this.barButtonItem8.Caption = "barButtonItem8";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem9.Caption = "barButtonItem9";
      this.barButtonItem9.Id = 9;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "İş Emri Detay";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) Resources.alignfloatingobjectbottomright_16x16;
      this.barButtonItem13.ImageOptions.LargeImage = (Image) Resources.alignfloatingobjectbottomright_32x32;
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.aramaTxt.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.aramaTxt.EditHeight = 30;
      this.aramaTxt.EditWidth = 110;
      this.aramaTxt.Id = 14;
      this.aramaTxt.Name = "aramaTxt";
      this.aramaTxt.RibbonStyle = RibbonItemStyles.Large;
      this.repositoryItemSearchControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLISEMRIBindingSource1;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.EmbeddedNavigator.TextStringFormat = "Kayıt {0} den {1}";
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.plaka,
        (RepositoryItem) this.aracigetiren,
        (RepositoryItem) this.isemirdurum,
        (RepositoryItem) this.bakimyeri,
        (RepositoryItem) this.atolye,
        (RepositoryItem) this.bakimderece,
        (RepositoryItem) this.bakimturu,
        (RepositoryItem) this.arizanedeni,
        (RepositoryItem) this.repositoryItemTimeSpanEdit1,
        (RepositoryItem) this.repositoryItemTimeSpanEdit2
      });
      this.gridControl1.Size = new Size(1042, 440);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.UseEmbeddedNavigator = true;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_1);
      this.tBLISEMRIBindingSource1.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource1.DataSource = (object) this.atolyeListesi;
      this.atolyeListesi.DataSetName = "AtolyeListesi";
      this.atolyeListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Preview.BackColor = Color.FromArgb(224, 224, 224);
      this.gridView1.AppearancePrint.Preview.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[27]
      {
        this.colID,
        this.colKOD,
        this.Yılı,
        this.colGIRISTARIH,
        this.colARACIGETIREN,
        this.colARACID,
        this.ARACACIKLAMA,
        this.colBILDIRILENARIZA,
        this.colISEMRIDURUMID,
        this.colATOLYEID,
        this.colGIRISSAAT,
        this.colCIKISTARIH,
        this.colCIKISSAAT,
        this.colARIZANEDENIID,
        this.colBAKIMYERIID,
        this.colBAKIMYERACKLM,
        this.colBAKIMKMSI,
        this.colSONRAKIBKMKM,
        this.colSONRAKIBKMTRH,
        this.colBAKIMSAATI,
        this.colSONRAKIBKMSAAT,
        this.colISEMRISIRANO,
        this.colYAPILANBAKIMOZETI,
        this.colIMZAATOLYESEFID,
        this.colISBITIMORANI,
        this.colBAKIMTURUID,
        this.colBAKIMDERECESIID
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
      this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
      this.gridView1.OptionsPrint.PrintDetails = true;
      this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DefaultBoolean.True;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colID, ColumnSortOrder.Descending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 19;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colKOD.Caption = "İş Emir Kodu";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 19;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.Printable = DefaultBoolean.False;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 102;
      this.Yılı.Caption = "Yılı";
      this.Yılı.FieldName = "YIL";
      this.Yılı.MinWidth = 19;
      this.Yılı.Name = "Yılı";
      this.Yılı.Visible = true;
      this.Yılı.VisibleIndex = 1;
      this.Yılı.Width = 70;
      this.colGIRISTARIH.Caption = "Giriş Tarih";
      this.colGIRISTARIH.FieldName = "GIRISTARIH";
      this.colGIRISTARIH.MinWidth = 19;
      this.colGIRISTARIH.Name = "colGIRISTARIH";
      this.colGIRISTARIH.OptionsColumn.AllowEdit = false;
      this.colGIRISTARIH.OptionsColumn.ReadOnly = true;
      this.colGIRISTARIH.Visible = true;
      this.colGIRISTARIH.VisibleIndex = 3;
      this.colGIRISTARIH.Width = 133;
      this.colARACIGETIREN.Caption = "Aracı Getiren";
      this.colARACIGETIREN.FieldName = "ARACIGETIREN";
      this.colARACIGETIREN.MinWidth = 19;
      this.colARACIGETIREN.Name = "colARACIGETIREN";
      this.colARACIGETIREN.OptionsColumn.AllowEdit = false;
      this.colARACIGETIREN.OptionsColumn.ReadOnly = true;
      this.colARACIGETIREN.Visible = true;
      this.colARACIGETIREN.VisibleIndex = 13;
      this.colARACIGETIREN.Width = 169;
      this.colARACID.Caption = "Plaka";
      this.colARACID.FieldName = "PLAKA";
      this.colARACID.MinWidth = 19;
      this.colARACID.Name = "colARACID";
      this.colARACID.OptionsColumn.AllowEdit = false;
      this.colARACID.OptionsColumn.ReadOnly = true;
      this.colARACID.Visible = true;
      this.colARACID.VisibleIndex = 2;
      this.colARACID.Width = 154;
      this.ARACACIKLAMA.Caption = "Arac Acıklama";
      this.ARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.ARACACIKLAMA.MinWidth = 19;
      this.ARACACIKLAMA.Name = "ARACACIKLAMA";
      this.ARACACIKLAMA.OptionsColumn.Printable = DefaultBoolean.False;
      this.ARACACIKLAMA.Visible = true;
      this.ARACACIKLAMA.VisibleIndex = 5;
      this.ARACACIKLAMA.Width = 354;
      this.colBILDIRILENARIZA.Caption = "Bildirilen Arıza";
      this.colBILDIRILENARIZA.FieldName = "BILDIRILENARIZA";
      this.colBILDIRILENARIZA.MinWidth = 19;
      this.colBILDIRILENARIZA.Name = "colBILDIRILENARIZA";
      this.colBILDIRILENARIZA.OptionsColumn.AllowEdit = false;
      this.colBILDIRILENARIZA.OptionsColumn.ReadOnly = true;
      this.colBILDIRILENARIZA.Visible = true;
      this.colBILDIRILENARIZA.VisibleIndex = 9;
      this.colBILDIRILENARIZA.Width = 168;
      this.colISEMRIDURUMID.Caption = "İş Emir Durum";
      this.colISEMRIDURUMID.ColumnEdit = (RepositoryItem) this.isemirdurum;
      this.colISEMRIDURUMID.FieldName = "ISEMRIDURUMID";
      this.colISEMRIDURUMID.MinWidth = 19;
      this.colISEMRIDURUMID.Name = "colISEMRIDURUMID";
      this.colISEMRIDURUMID.OptionsColumn.AllowEdit = false;
      this.colISEMRIDURUMID.OptionsColumn.Printable = DefaultBoolean.False;
      this.colISEMRIDURUMID.OptionsColumn.ReadOnly = true;
      this.colISEMRIDURUMID.Visible = true;
      this.colISEMRIDURUMID.VisibleIndex = 10;
      this.colISEMRIDURUMID.Width = 196;
      this.isemirdurum.AutoHeight = false;
      this.isemirdurum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isemirdurum.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.isemirdurum.DisplayMember = "ADI";
      this.isemirdurum.Name = "isemirdurum";
      this.isemirdurum.NullText = "";
      this.isemirdurum.ValueMember = "ID";
      this.tBLISEMIRDURUMBindingSource.DataMember = "TBLISEMIRDURUM";
      this.tBLISEMIRDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colATOLYEID.Caption = "Atölye";
      this.colATOLYEID.ColumnEdit = (RepositoryItem) this.atolye;
      this.colATOLYEID.FieldName = "ATOLYEID";
      this.colATOLYEID.MinWidth = 19;
      this.colATOLYEID.Name = "colATOLYEID";
      this.colATOLYEID.OptionsColumn.AllowEdit = false;
      this.colATOLYEID.OptionsColumn.ReadOnly = true;
      this.colATOLYEID.Visible = true;
      this.colATOLYEID.VisibleIndex = 21;
      this.colATOLYEID.Width = 139;
      this.atolye.AutoHeight = false;
      this.atolye.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolye.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.atolye.DisplayMember = "BOLUMADI";
      this.atolye.Name = "atolye";
      this.atolye.NullText = "";
      this.atolye.ValueMember = "ID";
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colGIRISSAAT.Caption = "Giriş Saati";
      this.colGIRISSAAT.DisplayFormat.FormatString = "hh:mm";
      this.colGIRISSAAT.DisplayFormat.FormatType = FormatType.Custom;
      this.colGIRISSAAT.FieldName = "GIRISSAAT";
      this.colGIRISSAAT.MinWidth = 19;
      this.colGIRISSAAT.Name = "colGIRISSAAT";
      this.colGIRISSAAT.OptionsColumn.AllowEdit = false;
      this.colGIRISSAAT.OptionsColumn.Printable = DefaultBoolean.False;
      this.colGIRISSAAT.OptionsColumn.ReadOnly = true;
      this.colGIRISSAAT.Visible = true;
      this.colGIRISSAAT.VisibleIndex = 6;
      this.colGIRISSAAT.Width = 79;
      this.colCIKISTARIH.Caption = "Çıkış Tarihi";
      this.colCIKISTARIH.FieldName = "CIKISTARIH";
      this.colCIKISTARIH.MinWidth = 19;
      this.colCIKISTARIH.Name = "colCIKISTARIH";
      this.colCIKISTARIH.OptionsColumn.AllowEdit = false;
      this.colCIKISTARIH.OptionsColumn.ReadOnly = true;
      this.colCIKISTARIH.Visible = true;
      this.colCIKISTARIH.VisibleIndex = 4;
      this.colCIKISTARIH.Width = 157;
      this.colCIKISSAAT.Caption = "Çıkış Saati";
      this.colCIKISSAAT.DisplayFormat.FormatString = "hh:mm";
      this.colCIKISSAAT.DisplayFormat.FormatType = FormatType.DateTime;
      this.colCIKISSAAT.FieldName = "CIKISSAAT";
      this.colCIKISSAAT.MinWidth = 19;
      this.colCIKISSAAT.Name = "colCIKISSAAT";
      this.colCIKISSAAT.OptionsColumn.AllowEdit = false;
      this.colCIKISSAAT.OptionsColumn.Printable = DefaultBoolean.False;
      this.colCIKISSAAT.OptionsColumn.ReadOnly = true;
      this.colCIKISSAAT.Visible = true;
      this.colCIKISSAAT.VisibleIndex = 7;
      this.colCIKISSAAT.Width = 84;
      this.colARIZANEDENIID.Caption = "Arıza Nedeni";
      this.colARIZANEDENIID.ColumnEdit = (RepositoryItem) this.arizanedeni;
      this.colARIZANEDENIID.FieldName = "ARIZANEDENIID";
      this.colARIZANEDENIID.MinWidth = 19;
      this.colARIZANEDENIID.Name = "colARIZANEDENIID";
      this.colARIZANEDENIID.OptionsColumn.AllowEdit = false;
      this.colARIZANEDENIID.OptionsColumn.Printable = DefaultBoolean.False;
      this.colARIZANEDENIID.OptionsColumn.ReadOnly = true;
      this.colARIZANEDENIID.Visible = true;
      this.colARIZANEDENIID.VisibleIndex = 8;
      this.colARIZANEDENIID.Width = 248;
      this.arizanedeni.AutoHeight = false;
      this.arizanedeni.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizanedeni.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.arizanedeni.DisplayMember = "ARIZANEDENI";
      this.arizanedeni.Name = "arizanedeni";
      this.arizanedeni.NullText = "";
      this.arizanedeni.ValueMember = "ID";
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.aRIZANEDENI1;
      this.aRIZANEDENI1.DataSetName = "ARIZANEDENI";
      this.aRIZANEDENI1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colBAKIMYERIID.Caption = "Bakım Yeri";
      this.colBAKIMYERIID.ColumnEdit = (RepositoryItem) this.bakimyeri;
      this.colBAKIMYERIID.FieldName = "BAKIMYERIID";
      this.colBAKIMYERIID.MinWidth = 19;
      this.colBAKIMYERIID.Name = "colBAKIMYERIID";
      this.colBAKIMYERIID.OptionsColumn.AllowEdit = false;
      this.colBAKIMYERIID.OptionsColumn.Printable = DefaultBoolean.False;
      this.colBAKIMYERIID.OptionsColumn.ReadOnly = true;
      this.colBAKIMYERIID.Visible = true;
      this.colBAKIMYERIID.VisibleIndex = 11;
      this.colBAKIMYERIID.Width = 156;
      this.bakimyeri.AutoHeight = false;
      this.bakimyeri.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimyeri.DataSource = (object) this.tBLBAKIMYERIBindingSource;
      this.bakimyeri.DisplayMember = "ADI";
      this.bakimyeri.Name = "bakimyeri";
      this.bakimyeri.NullText = "";
      this.bakimyeri.ValueMember = "ID";
      this.tBLBAKIMYERIBindingSource.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBAKIMYERACKLM.Caption = "Bakım Acıklaması";
      this.colBAKIMYERACKLM.FieldName = "BAKIMYERACKLM";
      this.colBAKIMYERACKLM.MinWidth = 19;
      this.colBAKIMYERACKLM.Name = "colBAKIMYERACKLM";
      this.colBAKIMYERACKLM.OptionsColumn.AllowEdit = false;
      this.colBAKIMYERACKLM.OptionsColumn.ReadOnly = true;
      this.colBAKIMYERACKLM.Visible = true;
      this.colBAKIMYERACKLM.VisibleIndex = 12;
      this.colBAKIMYERACKLM.Width = 164;
      this.colBAKIMKMSI.Caption = "Bakım Km";
      this.colBAKIMKMSI.FieldName = "BAKIMKMSI";
      this.colBAKIMKMSI.MinWidth = 19;
      this.colBAKIMKMSI.Name = "colBAKIMKMSI";
      this.colBAKIMKMSI.OptionsColumn.AllowEdit = false;
      this.colBAKIMKMSI.OptionsColumn.Printable = DefaultBoolean.False;
      this.colBAKIMKMSI.OptionsColumn.ReadOnly = true;
      this.colBAKIMKMSI.Visible = true;
      this.colBAKIMKMSI.VisibleIndex = 14;
      this.colBAKIMKMSI.Width = 187;
      this.colSONRAKIBKMKM.Caption = "Sonraki Bakım Km";
      this.colSONRAKIBKMKM.FieldName = "SONRAKIBKMKM";
      this.colSONRAKIBKMKM.MinWidth = 19;
      this.colSONRAKIBKMKM.Name = "colSONRAKIBKMKM";
      this.colSONRAKIBKMKM.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMKM.OptionsColumn.Printable = DefaultBoolean.False;
      this.colSONRAKIBKMKM.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMKM.Visible = true;
      this.colSONRAKIBKMKM.VisibleIndex = 15;
      this.colSONRAKIBKMKM.Width = 194;
      this.colSONRAKIBKMTRH.Caption = "Sonraki Bakım Tarihi";
      this.colSONRAKIBKMTRH.FieldName = "SONRAKIBKMTRH";
      this.colSONRAKIBKMTRH.MinWidth = 19;
      this.colSONRAKIBKMTRH.Name = "colSONRAKIBKMTRH";
      this.colSONRAKIBKMTRH.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMTRH.OptionsColumn.Printable = DefaultBoolean.False;
      this.colSONRAKIBKMTRH.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMTRH.Visible = true;
      this.colSONRAKIBKMTRH.VisibleIndex = 16;
      this.colSONRAKIBKMTRH.Width = 199;
      this.colBAKIMSAATI.Caption = "Bakım Saati";
      this.colBAKIMSAATI.FieldName = "BAKIMSAATI";
      this.colBAKIMSAATI.MinWidth = 19;
      this.colBAKIMSAATI.Name = "colBAKIMSAATI";
      this.colBAKIMSAATI.OptionsColumn.AllowEdit = false;
      this.colBAKIMSAATI.OptionsColumn.Printable = DefaultBoolean.False;
      this.colBAKIMSAATI.OptionsColumn.ReadOnly = true;
      this.colBAKIMSAATI.Visible = true;
      this.colBAKIMSAATI.VisibleIndex = 17;
      this.colBAKIMSAATI.Width = 157;
      this.colSONRAKIBKMSAAT.Caption = "Sonraki Bakım Saati";
      this.colSONRAKIBKMSAAT.FieldName = "SONRAKIBKMSAAT";
      this.colSONRAKIBKMSAAT.MinWidth = 19;
      this.colSONRAKIBKMSAAT.Name = "colSONRAKIBKMSAAT";
      this.colSONRAKIBKMSAAT.OptionsColumn.AllowEdit = false;
      this.colSONRAKIBKMSAAT.OptionsColumn.Printable = DefaultBoolean.False;
      this.colSONRAKIBKMSAAT.OptionsColumn.ReadOnly = true;
      this.colSONRAKIBKMSAAT.Visible = true;
      this.colSONRAKIBKMSAAT.VisibleIndex = 18;
      this.colSONRAKIBKMSAAT.Width = 171;
      this.colISEMRISIRANO.FieldName = "ISEMRISIRANO";
      this.colISEMRISIRANO.MinWidth = 19;
      this.colISEMRISIRANO.Name = "colISEMRISIRANO";
      this.colISEMRISIRANO.OptionsColumn.AllowEdit = false;
      this.colISEMRISIRANO.OptionsColumn.Printable = DefaultBoolean.False;
      this.colISEMRISIRANO.OptionsColumn.ReadOnly = true;
      this.colISEMRISIRANO.Width = 149;
      this.colYAPILANBAKIMOZETI.Caption = "Yapılan Bakım Özeti";
      this.colYAPILANBAKIMOZETI.FieldName = "YAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.MinWidth = 19;
      this.colYAPILANBAKIMOZETI.Name = "colYAPILANBAKIMOZETI";
      this.colYAPILANBAKIMOZETI.OptionsColumn.AllowEdit = false;
      this.colYAPILANBAKIMOZETI.OptionsColumn.Printable = DefaultBoolean.False;
      this.colYAPILANBAKIMOZETI.OptionsColumn.ReadOnly = true;
      this.colYAPILANBAKIMOZETI.Width = 185;
      this.colIMZAATOLYESEFID.ColumnEdit = (RepositoryItem) this.aracigetiren;
      this.colIMZAATOLYESEFID.FieldName = "IMZAATOLYESEFID";
      this.colIMZAATOLYESEFID.MinWidth = 19;
      this.colIMZAATOLYESEFID.Name = "colIMZAATOLYESEFID";
      this.colIMZAATOLYESEFID.OptionsColumn.AllowEdit = false;
      this.colIMZAATOLYESEFID.OptionsColumn.ReadOnly = true;
      this.colIMZAATOLYESEFID.Visible = true;
      this.colIMZAATOLYESEFID.VisibleIndex = 19;
      this.colIMZAATOLYESEFID.Width = 199;
      this.aracigetiren.AutoHeight = false;
      this.aracigetiren.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.aracigetiren.DataSource = (object) this.tBLPERSONELBindingSource;
      this.aracigetiren.DisplayMember = "ADISOYADI";
      this.aracigetiren.Name = "aracigetiren";
      this.aracigetiren.NullText = "";
      this.aracigetiren.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.colISBITIMORANI.FieldName = "ISBITIMORANI";
      this.colISBITIMORANI.MinWidth = 19;
      this.colISBITIMORANI.Name = "colISBITIMORANI";
      this.colISBITIMORANI.OptionsColumn.AllowEdit = false;
      this.colISBITIMORANI.OptionsColumn.Printable = DefaultBoolean.False;
      this.colISBITIMORANI.OptionsColumn.ReadOnly = true;
      this.colISBITIMORANI.Width = 199;
      this.colBAKIMTURUID.Caption = "Bakım Türü";
      this.colBAKIMTURUID.ColumnEdit = (RepositoryItem) this.bakimturu;
      this.colBAKIMTURUID.FieldName = "BAKIMTURUID";
      this.colBAKIMTURUID.MinWidth = 19;
      this.colBAKIMTURUID.Name = "colBAKIMTURUID";
      this.colBAKIMTURUID.OptionsColumn.AllowEdit = false;
      this.colBAKIMTURUID.OptionsColumn.Printable = DefaultBoolean.False;
      this.colBAKIMTURUID.OptionsColumn.ReadOnly = true;
      this.colBAKIMTURUID.Visible = true;
      this.colBAKIMTURUID.VisibleIndex = 20;
      this.colBAKIMTURUID.Width = 153;
      this.bakimturu.AutoHeight = false;
      this.bakimturu.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimturu.DataSource = (object) this.tAHBAKIMTURUBindingSource;
      this.bakimturu.DisplayMember = "BAKIMTURU";
      this.bakimturu.Name = "bakimturu";
      this.bakimturu.NullText = "";
      this.bakimturu.ValueMember = "ID";
      this.tAHBAKIMTURUBindingSource.DataMember = "TAHBAKIMTURU";
      this.tAHBAKIMTURUBindingSource.DataSource = (object) this.bAKIMTURU1;
      this.bAKIMTURU1.DataSetName = "BAKIMTURU";
      this.bAKIMTURU1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colBAKIMDERECESIID.Caption = "Bakım Derecesi";
      this.colBAKIMDERECESIID.ColumnEdit = (RepositoryItem) this.bakimderece;
      this.colBAKIMDERECESIID.FieldName = "BAKIMDERECESIID";
      this.colBAKIMDERECESIID.MinWidth = 19;
      this.colBAKIMDERECESIID.Name = "colBAKIMDERECESIID";
      this.colBAKIMDERECESIID.OptionsColumn.AllowEdit = false;
      this.colBAKIMDERECESIID.OptionsColumn.Printable = DefaultBoolean.True;
      this.colBAKIMDERECESIID.OptionsColumn.ReadOnly = true;
      this.colBAKIMDERECESIID.Visible = true;
      this.colBAKIMDERECESIID.VisibleIndex = 22;
      this.colBAKIMDERECESIID.Width = 153;
      this.bakimderece.AutoHeight = false;
      this.bakimderece.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimderece.DataSource = (object) this.tAHBAKIMDERECEBindingSource;
      this.bakimderece.DisplayMember = "BAKIMDERECE";
      this.bakimderece.Name = "bakimderece";
      this.bakimderece.NullText = "";
      this.bakimderece.ValueMember = "ID";
      this.tAHBAKIMDERECEBindingSource.DataMember = "TAHBAKIMDERECE";
      this.tAHBAKIMDERECEBindingSource.DataSource = (object) this.bAKIMDERECE1;
      this.bAKIMDERECE1.DataSetName = "BAKIMDERECE";
      this.bAKIMDERECE1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.plaka.AutoHeight = false;
      this.plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plaka.DataSource = (object) this.tBLARACLARBindingSource;
      this.plaka.DisplayMember = "PLAKA";
      this.plaka.Name = "plaka";
      this.plaka.NullText = "";
      this.plaka.ValueMember = "ID";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet5;
      this.repositoryItemTimeSpanEdit1.AutoHeight = false;
      this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit1.Mask.EditMask = "t";
      this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
      this.repositoryItemTimeSpanEdit2.AutoHeight = false;
      this.repositoryItemTimeSpanEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit2.Name = "repositoryItemTimeSpanEdit2";
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem2.CheckedChanged += new ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.CheckedChanged += new ItemClickEventHandler(this.barCheckItem3_CheckedChanged);
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem4.CheckedChanged += new ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem5.CheckedChanged += new ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
      this.barButtonItem14.Caption = "İş Emri İptal";
      this.barButtonItem14.Id = 20;
      this.barButtonItem14.Name = "barButtonItem14";
      this.barButtonItem15.Caption = "barButtonItem15";
      this.barButtonItem15.Id = 21;
      this.barButtonItem15.Name = "barButtonItem15";
      this.barButtonItem16.Caption = "barButtonItem16";
      this.barButtonItem16.Id = 22;
      this.barButtonItem16.Name = "barButtonItem16";
      this.barCheckItem6.Caption = "İş Emri İptal";
      this.barCheckItem6.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem6.Id = 23;
      this.barCheckItem6.Name = "barCheckItem6";
      this.barCheckItem6.CheckedChanged += new ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
      this.barButtonItem17.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem17.Caption = "Raporlar";
      this.barButtonItem17.DropDownControl = (PopupControl) this.popupMenu1;
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) Resources.printdialog_16x16;
      this.barButtonItem17.ImageOptions.LargeImage = (Image) Resources.printdialog_32x32;
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem18);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem19);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem26);
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem18.ItemClick += new ItemClickEventHandler(this.barButtonItem18_ItemClick);
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.barButtonItem26.Caption = "Biten İş Emri";
      this.barButtonItem26.Id = 33;
      this.barButtonItem26.Name = "barButtonItem26";
      this.barButtonItem26.ItemClick += new ItemClickEventHandler(this.barButtonItem26_ItemClick);
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem21.Caption = "Talep Oluştur";
      this.barButtonItem21.Id = 28;
      this.barButtonItem21.ImageOptions.Image = (Image) Resources.addheader_16x16;
      this.barButtonItem21.ImageOptions.LargeImage = (Image) Resources.addheader_32x32;
      this.barButtonItem21.LargeWidth = 100;
      this.barButtonItem21.Name = "barButtonItem21";
      this.barButtonItem21.ItemClick += new ItemClickEventHandler(this.barButtonItem21_ItemClick);
      this.barButtonItem22.Caption = "Filtre Rapor";
      this.barButtonItem22.Id = 29;
      this.barButtonItem22.ImageOptions.Image = (Image) Resources.differentoddevenpages_16x16;
      this.barButtonItem22.ImageOptions.LargeImage = (Image) Resources.differentoddevenpages_32x32;
      this.barButtonItem22.Name = "barButtonItem22";
      this.barButtonItem22.ItemClick += new ItemClickEventHandler(this.barButtonItem22_ItemClick);
      this.barCheckItem7.Caption = "Malzeme Sipariş";
      this.barCheckItem7.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem7.Id = 34;
      this.barCheckItem7.Name = "barCheckItem7";
      this.barCheckItem7.CheckedChanged += new ItemClickEventHandler(this.barCheckItem7_CheckedChanged);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup3,
        this.ribbonPageGroup5
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.aramaTxt);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem21);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem1);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem2);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem3);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem4);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem5);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem6);
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barCheckItem7);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem22);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.tabNavigationPage3.Caption = "Atölye Talepleri";
      this.tabNavigationPage3.Controls.Add((Control) this.gridControl4);
      this.tabNavigationPage3.Margin = new Padding(2);
      this.tabNavigationPage3.Name = "tabNavigationPage3";
      this.tabNavigationPage3.Size = new Size(1042, 440);
      this.gridControl4.DataSource = (object) this.sarfAtolyeBindingSource;
      this.gridControl4.Dock = DockStyle.Fill;
      this.gridControl4.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl4.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl4.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl4.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl4.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl4.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl4.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl4.EmbeddedNavigator.TextStringFormat = "Kayıt {0} nin {1}";
      this.gridControl4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl4.Location = new Point(0, 0);
      this.gridControl4.MainView = (BaseView) this.gridView4;
      this.gridControl4.Margin = new Padding(2);
      this.gridControl4.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl4.Name = "gridControl4";
      this.gridControl4.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit9,
        (RepositoryItem) this.repositoryItemLookUpEdit14,
        (RepositoryItem) this.repositoryItemLookUpEdit10,
        (RepositoryItem) this.repositoryItemLookUpEdit13,
        (RepositoryItem) this.repositoryItemLookUpEdit11,
        (RepositoryItem) this.repositoryItemLookUpEdit16,
        (RepositoryItem) this.repositoryItemLookUpEdit15,
        (RepositoryItem) this.repositoryItemLookUpEdit12,
        (RepositoryItem) this.repositoryItemTimeSpanEdit5,
        (RepositoryItem) this.repositoryItemTimeSpanEdit6
      });
      this.gridControl4.Size = new Size(1042, 440);
      this.gridControl4.TabIndex = 7;
      this.gridControl4.UseEmbeddedNavigator = true;
      this.gridControl4.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView4
      });
      this.sarfAtolyeBindingSource.DataMember = "sarfAtolye";
      this.sarfAtolyeBindingSource.DataSource = (object) this.atolye_yagListesi;
      this.atolye_yagListesi.DataSetName = "atolye_yagListesi";
      this.atolye_yagListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView4.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView4.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView4.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView4.Appearance.Row.BackColor = Color.White;
      this.gridView4.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView4.Appearance.Row.Options.UseBackColor = true;
      this.gridView4.Appearance.Row.Options.UseFont = true;
      this.gridView4.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView4.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView4.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView4.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView4.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView4.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView4.Columns.AddRange(new GridColumn[27]
      {
        this.gridColumn28,
        this.gridColumn29,
        this.gridColumn30,
        this.gridColumn31,
        this.gridColumn32,
        this.gridColumn33,
        this.gridColumn34,
        this.gridColumn35,
        this.gridColumn36,
        this.gridColumn37,
        this.gridColumn38,
        this.gridColumn39,
        this.gridColumn40,
        this.gridColumn41,
        this.gridColumn42,
        this.gridColumn43,
        this.gridColumn44,
        this.gridColumn45,
        this.gridColumn46,
        this.gridColumn47,
        this.gridColumn48,
        this.gridColumn49,
        this.gridColumn50,
        this.gridColumn51,
        this.gridColumn52,
        this.gridColumn53,
        this.gridColumn54
      });
      this.gridView4.DetailHeight = 284;
      this.gridView4.GridControl = this.gridControl4;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsView.ColumnAutoWidth = false;
      this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView4.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn28, ColumnSortOrder.Descending)
      });
      this.gridView4.RowCellStyle += new RowCellStyleEventHandler(this.gridView4_RowCellStyle);
      this.gridView4.DoubleClick += new EventHandler(this.gridView4_DoubleClick);
      this.gridColumn28.FieldName = "ID";
      this.gridColumn28.MinWidth = 19;
      this.gridColumn28.Name = "gridColumn28";
      this.gridColumn28.OptionsColumn.AllowEdit = false;
      this.gridColumn28.OptionsColumn.ReadOnly = true;
      this.gridColumn29.Caption = "İş Emir Kodu";
      this.gridColumn29.FieldName = "KOD";
      this.gridColumn29.MinWidth = 19;
      this.gridColumn29.Name = "gridColumn29";
      this.gridColumn29.OptionsColumn.AllowEdit = false;
      this.gridColumn29.OptionsColumn.ReadOnly = true;
      this.gridColumn29.Visible = true;
      this.gridColumn29.VisibleIndex = 0;
      this.gridColumn29.Width = 102;
      this.gridColumn30.Caption = "Yılı";
      this.gridColumn30.FieldName = "YIL";
      this.gridColumn30.MinWidth = 19;
      this.gridColumn30.Name = "gridColumn30";
      this.gridColumn30.Visible = true;
      this.gridColumn30.VisibleIndex = 1;
      this.gridColumn30.Width = 70;
      this.gridColumn31.Caption = "Giriş Tarih";
      this.gridColumn31.FieldName = "GIRISTARIH";
      this.gridColumn31.MinWidth = 19;
      this.gridColumn31.Name = "gridColumn31";
      this.gridColumn31.OptionsColumn.AllowEdit = false;
      this.gridColumn31.OptionsColumn.ReadOnly = true;
      this.gridColumn31.Visible = true;
      this.gridColumn31.VisibleIndex = 3;
      this.gridColumn31.Width = 133;
      this.gridColumn32.Caption = "Aracı Getiren";
      this.gridColumn32.FieldName = "ARACIGETIREN";
      this.gridColumn32.MinWidth = 19;
      this.gridColumn32.Name = "gridColumn32";
      this.gridColumn32.OptionsColumn.AllowEdit = false;
      this.gridColumn32.OptionsColumn.ReadOnly = true;
      this.gridColumn32.Visible = true;
      this.gridColumn32.VisibleIndex = 13;
      this.gridColumn32.Width = 169;
      this.gridColumn33.Caption = "Plaka";
      this.gridColumn33.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit9;
      this.gridColumn33.FieldName = "ARACID";
      this.gridColumn33.MinWidth = 19;
      this.gridColumn33.Name = "gridColumn33";
      this.gridColumn33.OptionsColumn.AllowEdit = false;
      this.gridColumn33.OptionsColumn.ReadOnly = true;
      this.gridColumn33.Visible = true;
      this.gridColumn33.VisibleIndex = 2;
      this.gridColumn33.Width = 154;
      this.repositoryItemLookUpEdit9.AutoHeight = false;
      this.repositoryItemLookUpEdit9.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit9.DataSource = (object) this.tBLARACLARBindingSource;
      this.repositoryItemLookUpEdit9.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit9.Name = "repositoryItemLookUpEdit9";
      this.repositoryItemLookUpEdit9.NullText = "";
      this.repositoryItemLookUpEdit9.ValueMember = "ID";
      this.gridColumn34.Caption = "Arac Acıklama";
      this.gridColumn34.FieldName = "ARACACIKLAMA";
      this.gridColumn34.MinWidth = 19;
      this.gridColumn34.Name = "gridColumn34";
      this.gridColumn34.Visible = true;
      this.gridColumn34.VisibleIndex = 5;
      this.gridColumn34.Width = 354;
      this.gridColumn35.Caption = "Bildirilen Arıza";
      this.gridColumn35.FieldName = "BILDIRILENARIZA";
      this.gridColumn35.MinWidth = 19;
      this.gridColumn35.Name = "gridColumn35";
      this.gridColumn35.OptionsColumn.AllowEdit = false;
      this.gridColumn35.OptionsColumn.ReadOnly = true;
      this.gridColumn35.Visible = true;
      this.gridColumn35.VisibleIndex = 9;
      this.gridColumn35.Width = 168;
      this.gridColumn36.Caption = "İş Emir Durum";
      this.gridColumn36.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit10;
      this.gridColumn36.FieldName = "ISEMRIDURUMID";
      this.gridColumn36.MinWidth = 19;
      this.gridColumn36.Name = "gridColumn36";
      this.gridColumn36.OptionsColumn.AllowEdit = false;
      this.gridColumn36.OptionsColumn.ReadOnly = true;
      this.gridColumn36.Visible = true;
      this.gridColumn36.VisibleIndex = 10;
      this.gridColumn36.Width = 196;
      this.repositoryItemLookUpEdit10.AutoHeight = false;
      this.repositoryItemLookUpEdit10.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit10.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.repositoryItemLookUpEdit10.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit10.Name = "repositoryItemLookUpEdit10";
      this.repositoryItemLookUpEdit10.NullText = "";
      this.repositoryItemLookUpEdit10.ValueMember = "ID";
      this.gridColumn37.Caption = "Atölye";
      this.gridColumn37.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit11;
      this.gridColumn37.FieldName = "ATOLYEID";
      this.gridColumn37.MinWidth = 19;
      this.gridColumn37.Name = "gridColumn37";
      this.gridColumn37.OptionsColumn.AllowEdit = false;
      this.gridColumn37.OptionsColumn.ReadOnly = true;
      this.gridColumn37.Visible = true;
      this.gridColumn37.VisibleIndex = 22;
      this.gridColumn37.Width = 139;
      this.repositoryItemLookUpEdit11.AutoHeight = false;
      this.repositoryItemLookUpEdit11.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit11.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.repositoryItemLookUpEdit11.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit11.Name = "repositoryItemLookUpEdit11";
      this.repositoryItemLookUpEdit11.NullText = "";
      this.repositoryItemLookUpEdit11.ValueMember = "ID";
      this.gridColumn38.Caption = "Giriş Saati";
      this.gridColumn38.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn38.DisplayFormat.FormatType = FormatType.Custom;
      this.gridColumn38.FieldName = "GIRISSAAT";
      this.gridColumn38.MinWidth = 19;
      this.gridColumn38.Name = "gridColumn38";
      this.gridColumn38.OptionsColumn.AllowEdit = false;
      this.gridColumn38.OptionsColumn.ReadOnly = true;
      this.gridColumn38.Visible = true;
      this.gridColumn38.VisibleIndex = 6;
      this.gridColumn38.Width = 79;
      this.gridColumn39.Caption = "Çıkış Tarihi";
      this.gridColumn39.FieldName = "CIKISTARIH";
      this.gridColumn39.MinWidth = 19;
      this.gridColumn39.Name = "gridColumn39";
      this.gridColumn39.OptionsColumn.AllowEdit = false;
      this.gridColumn39.OptionsColumn.ReadOnly = true;
      this.gridColumn39.Visible = true;
      this.gridColumn39.VisibleIndex = 4;
      this.gridColumn39.Width = 157;
      this.gridColumn40.Caption = "Çıkış Saati";
      this.gridColumn40.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn40.DisplayFormat.FormatType = FormatType.DateTime;
      this.gridColumn40.FieldName = "CIKISSAAT";
      this.gridColumn40.MinWidth = 19;
      this.gridColumn40.Name = "gridColumn40";
      this.gridColumn40.OptionsColumn.AllowEdit = false;
      this.gridColumn40.OptionsColumn.ReadOnly = true;
      this.gridColumn40.Visible = true;
      this.gridColumn40.VisibleIndex = 7;
      this.gridColumn40.Width = 84;
      this.gridColumn41.Caption = "Arıza Nedeni";
      this.gridColumn41.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit12;
      this.gridColumn41.FieldName = "ARIZANEDENIID";
      this.gridColumn41.MinWidth = 19;
      this.gridColumn41.Name = "gridColumn41";
      this.gridColumn41.OptionsColumn.AllowEdit = false;
      this.gridColumn41.OptionsColumn.ReadOnly = true;
      this.gridColumn41.Visible = true;
      this.gridColumn41.VisibleIndex = 8;
      this.gridColumn41.Width = 248;
      this.repositoryItemLookUpEdit12.AutoHeight = false;
      this.repositoryItemLookUpEdit12.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit12.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.repositoryItemLookUpEdit12.DisplayMember = "ARIZANEDENI";
      this.repositoryItemLookUpEdit12.Name = "repositoryItemLookUpEdit12";
      this.repositoryItemLookUpEdit12.NullText = "";
      this.repositoryItemLookUpEdit12.ValueMember = "ID";
      this.gridColumn42.Caption = "Bakım Yeri";
      this.gridColumn42.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit13;
      this.gridColumn42.FieldName = "BAKIMYERIID";
      this.gridColumn42.MinWidth = 19;
      this.gridColumn42.Name = "gridColumn42";
      this.gridColumn42.OptionsColumn.AllowEdit = false;
      this.gridColumn42.OptionsColumn.ReadOnly = true;
      this.gridColumn42.Visible = true;
      this.gridColumn42.VisibleIndex = 11;
      this.gridColumn42.Width = 156;
      this.repositoryItemLookUpEdit13.AutoHeight = false;
      this.repositoryItemLookUpEdit13.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit13.DataSource = (object) this.tBLBAKIMYERIBindingSource;
      this.repositoryItemLookUpEdit13.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit13.Name = "repositoryItemLookUpEdit13";
      this.repositoryItemLookUpEdit13.NullText = "";
      this.repositoryItemLookUpEdit13.ValueMember = "ID";
      this.gridColumn43.Caption = "Bakım Acıklaması";
      this.gridColumn43.FieldName = "BAKIMYERACKLM";
      this.gridColumn43.MinWidth = 19;
      this.gridColumn43.Name = "gridColumn43";
      this.gridColumn43.OptionsColumn.AllowEdit = false;
      this.gridColumn43.OptionsColumn.ReadOnly = true;
      this.gridColumn43.Visible = true;
      this.gridColumn43.VisibleIndex = 12;
      this.gridColumn43.Width = 164;
      this.gridColumn44.Caption = "Bakım Km";
      this.gridColumn44.FieldName = "BAKIMKMSI";
      this.gridColumn44.MinWidth = 19;
      this.gridColumn44.Name = "gridColumn44";
      this.gridColumn44.OptionsColumn.AllowEdit = false;
      this.gridColumn44.OptionsColumn.ReadOnly = true;
      this.gridColumn44.Visible = true;
      this.gridColumn44.VisibleIndex = 14;
      this.gridColumn44.Width = 187;
      this.gridColumn45.Caption = "Sonraki Bakım Km";
      this.gridColumn45.FieldName = "SONRAKIBKMKM";
      this.gridColumn45.MinWidth = 19;
      this.gridColumn45.Name = "gridColumn45";
      this.gridColumn45.OptionsColumn.AllowEdit = false;
      this.gridColumn45.OptionsColumn.ReadOnly = true;
      this.gridColumn45.Visible = true;
      this.gridColumn45.VisibleIndex = 15;
      this.gridColumn45.Width = 194;
      this.gridColumn46.Caption = "Sonraki Bakım Tarihi";
      this.gridColumn46.FieldName = "SONRAKIBKMTRH";
      this.gridColumn46.MinWidth = 19;
      this.gridColumn46.Name = "gridColumn46";
      this.gridColumn46.OptionsColumn.AllowEdit = false;
      this.gridColumn46.OptionsColumn.ReadOnly = true;
      this.gridColumn46.Visible = true;
      this.gridColumn46.VisibleIndex = 16;
      this.gridColumn46.Width = 199;
      this.gridColumn47.Caption = "Bakım Saati";
      this.gridColumn47.FieldName = "BAKIMSAATI";
      this.gridColumn47.MinWidth = 19;
      this.gridColumn47.Name = "gridColumn47";
      this.gridColumn47.OptionsColumn.AllowEdit = false;
      this.gridColumn47.OptionsColumn.ReadOnly = true;
      this.gridColumn47.Visible = true;
      this.gridColumn47.VisibleIndex = 17;
      this.gridColumn47.Width = 157;
      this.gridColumn48.Caption = "Sonraki Bakım Saati";
      this.gridColumn48.FieldName = "SONRAKIBKMSAAT";
      this.gridColumn48.MinWidth = 19;
      this.gridColumn48.Name = "gridColumn48";
      this.gridColumn48.OptionsColumn.AllowEdit = false;
      this.gridColumn48.OptionsColumn.ReadOnly = true;
      this.gridColumn48.Visible = true;
      this.gridColumn48.VisibleIndex = 18;
      this.gridColumn48.Width = 171;
      this.gridColumn49.FieldName = "ISEMRISIRANO";
      this.gridColumn49.MinWidth = 19;
      this.gridColumn49.Name = "gridColumn49";
      this.gridColumn49.OptionsColumn.AllowEdit = false;
      this.gridColumn49.OptionsColumn.ReadOnly = true;
      this.gridColumn49.Width = 149;
      this.gridColumn50.Caption = "Yapılan Bakım Özeti";
      this.gridColumn50.FieldName = "YAPILANBAKIMOZETI";
      this.gridColumn50.MinWidth = 19;
      this.gridColumn50.Name = "gridColumn50";
      this.gridColumn50.OptionsColumn.AllowEdit = false;
      this.gridColumn50.OptionsColumn.ReadOnly = true;
      this.gridColumn50.Visible = true;
      this.gridColumn50.VisibleIndex = 19;
      this.gridColumn50.Width = 185;
      this.gridColumn51.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit14;
      this.gridColumn51.FieldName = "IMZAATOLYESEFID";
      this.gridColumn51.MinWidth = 19;
      this.gridColumn51.Name = "gridColumn51";
      this.gridColumn51.OptionsColumn.AllowEdit = false;
      this.gridColumn51.OptionsColumn.ReadOnly = true;
      this.gridColumn51.Visible = true;
      this.gridColumn51.VisibleIndex = 20;
      this.gridColumn51.Width = 199;
      this.repositoryItemLookUpEdit14.AutoHeight = false;
      this.repositoryItemLookUpEdit14.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit14.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit14.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit14.Name = "repositoryItemLookUpEdit14";
      this.repositoryItemLookUpEdit14.NullText = "";
      this.repositoryItemLookUpEdit14.ValueMember = "ID";
      this.gridColumn52.FieldName = "ISBITIMORANI";
      this.gridColumn52.MinWidth = 19;
      this.gridColumn52.Name = "gridColumn52";
      this.gridColumn52.OptionsColumn.AllowEdit = false;
      this.gridColumn52.OptionsColumn.ReadOnly = true;
      this.gridColumn52.Width = 199;
      this.gridColumn53.Caption = "Bakım Türü";
      this.gridColumn53.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit15;
      this.gridColumn53.FieldName = "BAKIMTURUID";
      this.gridColumn53.MinWidth = 19;
      this.gridColumn53.Name = "gridColumn53";
      this.gridColumn53.OptionsColumn.AllowEdit = false;
      this.gridColumn53.OptionsColumn.ReadOnly = true;
      this.gridColumn53.Visible = true;
      this.gridColumn53.VisibleIndex = 21;
      this.gridColumn53.Width = 153;
      this.repositoryItemLookUpEdit15.AutoHeight = false;
      this.repositoryItemLookUpEdit15.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit15.DataSource = (object) this.tAHBAKIMTURUBindingSource;
      this.repositoryItemLookUpEdit15.DisplayMember = "BAKIMTURU";
      this.repositoryItemLookUpEdit15.Name = "repositoryItemLookUpEdit15";
      this.repositoryItemLookUpEdit15.NullText = "";
      this.repositoryItemLookUpEdit15.ValueMember = "ID";
      this.gridColumn54.Caption = "Bakım Derecesi";
      this.gridColumn54.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit16;
      this.gridColumn54.FieldName = "BAKIMDERECESIID";
      this.gridColumn54.MinWidth = 19;
      this.gridColumn54.Name = "gridColumn54";
      this.gridColumn54.OptionsColumn.AllowEdit = false;
      this.gridColumn54.OptionsColumn.ReadOnly = true;
      this.gridColumn54.Visible = true;
      this.gridColumn54.VisibleIndex = 23;
      this.gridColumn54.Width = 153;
      this.repositoryItemLookUpEdit16.AutoHeight = false;
      this.repositoryItemLookUpEdit16.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit16.DataSource = (object) this.tAHBAKIMDERECEBindingSource;
      this.repositoryItemLookUpEdit16.DisplayMember = "BAKIMDERECE";
      this.repositoryItemLookUpEdit16.Name = "repositoryItemLookUpEdit16";
      this.repositoryItemLookUpEdit16.NullText = "";
      this.repositoryItemLookUpEdit16.ValueMember = "ID";
      this.repositoryItemTimeSpanEdit5.AutoHeight = false;
      this.repositoryItemTimeSpanEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit5.Mask.EditMask = "t";
      this.repositoryItemTimeSpanEdit5.Name = "repositoryItemTimeSpanEdit5";
      this.repositoryItemTimeSpanEdit6.AutoHeight = false;
      this.repositoryItemTimeSpanEdit6.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit6.Name = "repositoryItemTimeSpanEdit6";
      this.tBLISEMRIBindingSource2.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource2.DataSource = (object) this.yagAtolyesi;
      this.yagAtolyesi.DataSetName = "YagAtolyesi";
      this.yagAtolyesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tabNavigationPage2.Caption = "Yağ Emir Listesi";
      this.tabNavigationPage2.Controls.Add((Control) this.gridControl3);
      this.tabNavigationPage2.Margin = new Padding(2);
      this.tabNavigationPage2.Name = "tabNavigationPage2";
      this.tabNavigationPage2.Size = new Size(1042, 440);
      this.gridControl3.DataSource = (object) this.yagMerkeziBindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl3.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl3.EmbeddedNavigator.TextStringFormat = "Kayıt {0} nin {1}";
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 0);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.Margin = new Padding(2);
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[11]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit6,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit5,
        (RepositoryItem) this.repositoryItemLookUpEdit3,
        (RepositoryItem) this.repositoryItemLookUpEdit8,
        (RepositoryItem) this.repositoryItemLookUpEdit7,
        (RepositoryItem) this.repositoryItemLookUpEdit4,
        (RepositoryItem) this.repositoryItemTimeSpanEdit3,
        (RepositoryItem) this.repositoryItemTimeSpanEdit4,
        (RepositoryItem) this.ARACACIKLAMA1
      });
      this.gridControl3.Size = new Size(1042, 440);
      this.gridControl3.TabIndex = 6;
      this.gridControl3.UseEmbeddedNavigator = true;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.yagMerkeziBindingSource.DataMember = "yagMerkezi";
      this.yagMerkeziBindingSource.DataSource = (object) this.atolye_yagListesi;
      this.gridView3.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView3.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView3.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.BackColor = Color.White;
      this.gridView3.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView3.Appearance.Row.Options.UseBackColor = true;
      this.gridView3.Appearance.Row.Options.UseFont = true;
      this.gridView3.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView3.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView3.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView3.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView3.Columns.AddRange(new GridColumn[27]
      {
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
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
        this.gridColumn24,
        this.gridColumn25,
        this.gridColumn26,
        this.gridColumn27
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsView.ColumnAutoWidth = false;
      this.gridView3.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn1, ColumnSortOrder.Descending)
      });
      this.gridView3.RowCellStyle += new RowCellStyleEventHandler(this.gridView3_RowCellStyle);
      this.gridView3.DoubleClick += new EventHandler(this.gridView3_DoubleClick);
      this.gridColumn1.FieldName = "ID";
      this.gridColumn1.MinWidth = 19;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Caption = "İş Emir Kodu";
      this.gridColumn2.FieldName = "KOD";
      this.gridColumn2.MinWidth = 19;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn2.Width = 102;
      this.gridColumn3.Caption = "Yılı";
      this.gridColumn3.FieldName = "YIL";
      this.gridColumn3.MinWidth = 19;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.gridColumn3.Width = 70;
      this.gridColumn4.Caption = "Giriş Tarih";
      this.gridColumn4.FieldName = "GIRISTARIH";
      this.gridColumn4.MinWidth = 19;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.AllowEdit = false;
      this.gridColumn4.OptionsColumn.ReadOnly = true;
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      this.gridColumn4.Width = 133;
      this.gridColumn5.Caption = "Aracı Getiren";
      this.gridColumn5.FieldName = "ARACIGETIREN";
      this.gridColumn5.MinWidth = 19;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.OptionsColumn.AllowEdit = false;
      this.gridColumn5.OptionsColumn.ReadOnly = true;
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 13;
      this.gridColumn5.Width = 169;
      this.gridColumn6.Caption = "Plaka";
      this.gridColumn6.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn6.FieldName = "ARACID";
      this.gridColumn6.MinWidth = 19;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.OptionsColumn.AllowEdit = false;
      this.gridColumn6.OptionsColumn.ReadOnly = true;
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 2;
      this.gridColumn6.Width = 154;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLARACLARBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "PLAKA";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.NullText = "";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.gridColumn7.Caption = "Arac Acıklama";
      this.gridColumn7.FieldName = "ARACACIKLAMA";
      this.gridColumn7.MinWidth = 19;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 5;
      this.gridColumn7.Width = 354;
      this.gridColumn8.Caption = "Bildirilen Arıza";
      this.gridColumn8.FieldName = "BILDIRILENARIZA";
      this.gridColumn8.MinWidth = 19;
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.OptionsColumn.AllowEdit = false;
      this.gridColumn8.OptionsColumn.ReadOnly = true;
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 9;
      this.gridColumn8.Width = 168;
      this.gridColumn9.Caption = "İş Emir Durum";
      this.gridColumn9.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.gridColumn9.FieldName = "ISEMRIDURUMID";
      this.gridColumn9.MinWidth = 19;
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.OptionsColumn.AllowEdit = false;
      this.gridColumn9.OptionsColumn.ReadOnly = true;
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 10;
      this.gridColumn9.Width = 196;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLISEMIRDURUMBindingSource;
      this.repositoryItemLookUpEdit2.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.NullText = "";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.gridColumn10.Caption = "Atölye";
      this.gridColumn10.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.gridColumn10.FieldName = "ATOLYEID";
      this.gridColumn10.MinWidth = 19;
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.OptionsColumn.AllowEdit = false;
      this.gridColumn10.OptionsColumn.ReadOnly = true;
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 22;
      this.gridColumn10.Width = 139;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.repositoryItemLookUpEdit3.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.NullText = "";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.gridColumn11.Caption = "Giriş Saati";
      this.gridColumn11.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn11.DisplayFormat.FormatType = FormatType.Custom;
      this.gridColumn11.FieldName = "GIRISSAAT";
      this.gridColumn11.MinWidth = 19;
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.OptionsColumn.AllowEdit = false;
      this.gridColumn11.OptionsColumn.ReadOnly = true;
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 6;
      this.gridColumn11.Width = 79;
      this.gridColumn12.Caption = "Çıkış Tarihi";
      this.gridColumn12.FieldName = "CIKISTARIH";
      this.gridColumn12.MinWidth = 19;
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.OptionsColumn.AllowEdit = false;
      this.gridColumn12.OptionsColumn.ReadOnly = true;
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 4;
      this.gridColumn12.Width = 157;
      this.gridColumn13.Caption = "Çıkış Saati";
      this.gridColumn13.DisplayFormat.FormatString = "hh:mm";
      this.gridColumn13.DisplayFormat.FormatType = FormatType.DateTime;
      this.gridColumn13.FieldName = "CIKISSAAT";
      this.gridColumn13.MinWidth = 19;
      this.gridColumn13.Name = "gridColumn13";
      this.gridColumn13.OptionsColumn.AllowEdit = false;
      this.gridColumn13.OptionsColumn.ReadOnly = true;
      this.gridColumn13.Visible = true;
      this.gridColumn13.VisibleIndex = 7;
      this.gridColumn13.Width = 84;
      this.gridColumn14.Caption = "Arıza Nedeni";
      this.gridColumn14.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit4;
      this.gridColumn14.FieldName = "ARIZANEDENIID";
      this.gridColumn14.MinWidth = 19;
      this.gridColumn14.Name = "gridColumn14";
      this.gridColumn14.OptionsColumn.AllowEdit = false;
      this.gridColumn14.OptionsColumn.ReadOnly = true;
      this.gridColumn14.Visible = true;
      this.gridColumn14.VisibleIndex = 8;
      this.gridColumn14.Width = 248;
      this.repositoryItemLookUpEdit4.AutoHeight = false;
      this.repositoryItemLookUpEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit4.DataSource = (object) this.tAHARIZANEDENIBindingSource;
      this.repositoryItemLookUpEdit4.DisplayMember = "ARIZANEDENI";
      this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
      this.repositoryItemLookUpEdit4.NullText = "";
      this.repositoryItemLookUpEdit4.ValueMember = "ID";
      this.gridColumn15.Caption = "Bakım Yeri";
      this.gridColumn15.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit5;
      this.gridColumn15.FieldName = "BAKIMYERIID";
      this.gridColumn15.MinWidth = 19;
      this.gridColumn15.Name = "gridColumn15";
      this.gridColumn15.OptionsColumn.AllowEdit = false;
      this.gridColumn15.OptionsColumn.ReadOnly = true;
      this.gridColumn15.Visible = true;
      this.gridColumn15.VisibleIndex = 11;
      this.gridColumn15.Width = 156;
      this.repositoryItemLookUpEdit5.AutoHeight = false;
      this.repositoryItemLookUpEdit5.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit5.DataSource = (object) this.tBLBAKIMYERIBindingSource;
      this.repositoryItemLookUpEdit5.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
      this.repositoryItemLookUpEdit5.NullText = "";
      this.repositoryItemLookUpEdit5.ValueMember = "ID";
      this.gridColumn16.Caption = "Bakım Acıklaması";
      this.gridColumn16.FieldName = "BAKIMYERACKLM";
      this.gridColumn16.MinWidth = 19;
      this.gridColumn16.Name = "gridColumn16";
      this.gridColumn16.OptionsColumn.AllowEdit = false;
      this.gridColumn16.OptionsColumn.ReadOnly = true;
      this.gridColumn16.Visible = true;
      this.gridColumn16.VisibleIndex = 12;
      this.gridColumn16.Width = 164;
      this.gridColumn17.Caption = "Bakım Km";
      this.gridColumn17.FieldName = "BAKIMKMSI";
      this.gridColumn17.MinWidth = 19;
      this.gridColumn17.Name = "gridColumn17";
      this.gridColumn17.OptionsColumn.AllowEdit = false;
      this.gridColumn17.OptionsColumn.ReadOnly = true;
      this.gridColumn17.Visible = true;
      this.gridColumn17.VisibleIndex = 14;
      this.gridColumn17.Width = 187;
      this.gridColumn18.Caption = "Sonraki Bakım Km";
      this.gridColumn18.FieldName = "SONRAKIBKMKM";
      this.gridColumn18.MinWidth = 19;
      this.gridColumn18.Name = "gridColumn18";
      this.gridColumn18.OptionsColumn.AllowEdit = false;
      this.gridColumn18.OptionsColumn.ReadOnly = true;
      this.gridColumn18.Visible = true;
      this.gridColumn18.VisibleIndex = 15;
      this.gridColumn18.Width = 194;
      this.gridColumn19.Caption = "Sonraki Bakım Tarihi";
      this.gridColumn19.FieldName = "SONRAKIBKMTRH";
      this.gridColumn19.MinWidth = 19;
      this.gridColumn19.Name = "gridColumn19";
      this.gridColumn19.OptionsColumn.AllowEdit = false;
      this.gridColumn19.OptionsColumn.ReadOnly = true;
      this.gridColumn19.Visible = true;
      this.gridColumn19.VisibleIndex = 16;
      this.gridColumn19.Width = 199;
      this.gridColumn20.Caption = "Bakım Saati";
      this.gridColumn20.FieldName = "BAKIMSAATI";
      this.gridColumn20.MinWidth = 19;
      this.gridColumn20.Name = "gridColumn20";
      this.gridColumn20.OptionsColumn.AllowEdit = false;
      this.gridColumn20.OptionsColumn.ReadOnly = true;
      this.gridColumn20.Visible = true;
      this.gridColumn20.VisibleIndex = 17;
      this.gridColumn20.Width = 157;
      this.gridColumn21.Caption = "Sonraki Bakım Saati";
      this.gridColumn21.FieldName = "SONRAKIBKMSAAT";
      this.gridColumn21.MinWidth = 19;
      this.gridColumn21.Name = "gridColumn21";
      this.gridColumn21.OptionsColumn.AllowEdit = false;
      this.gridColumn21.OptionsColumn.ReadOnly = true;
      this.gridColumn21.Visible = true;
      this.gridColumn21.VisibleIndex = 18;
      this.gridColumn21.Width = 171;
      this.gridColumn22.FieldName = "ISEMRISIRANO";
      this.gridColumn22.MinWidth = 19;
      this.gridColumn22.Name = "gridColumn22";
      this.gridColumn22.OptionsColumn.AllowEdit = false;
      this.gridColumn22.OptionsColumn.ReadOnly = true;
      this.gridColumn22.Width = 149;
      this.gridColumn23.Caption = "Yapılan Bakım Özeti";
      this.gridColumn23.FieldName = "YAPILANBAKIMOZETI";
      this.gridColumn23.MinWidth = 19;
      this.gridColumn23.Name = "gridColumn23";
      this.gridColumn23.OptionsColumn.AllowEdit = false;
      this.gridColumn23.OptionsColumn.ReadOnly = true;
      this.gridColumn23.Visible = true;
      this.gridColumn23.VisibleIndex = 19;
      this.gridColumn23.Width = 185;
      this.gridColumn24.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit6;
      this.gridColumn24.FieldName = "IMZAATOLYESEFID";
      this.gridColumn24.MinWidth = 19;
      this.gridColumn24.Name = "gridColumn24";
      this.gridColumn24.OptionsColumn.AllowEdit = false;
      this.gridColumn24.OptionsColumn.ReadOnly = true;
      this.gridColumn24.Visible = true;
      this.gridColumn24.VisibleIndex = 20;
      this.gridColumn24.Width = 199;
      this.repositoryItemLookUpEdit6.AutoHeight = false;
      this.repositoryItemLookUpEdit6.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit6.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit6.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit6.Name = "repositoryItemLookUpEdit6";
      this.repositoryItemLookUpEdit6.NullText = "";
      this.repositoryItemLookUpEdit6.ValueMember = "ID";
      this.gridColumn25.FieldName = "ISBITIMORANI";
      this.gridColumn25.MinWidth = 19;
      this.gridColumn25.Name = "gridColumn25";
      this.gridColumn25.OptionsColumn.AllowEdit = false;
      this.gridColumn25.OptionsColumn.ReadOnly = true;
      this.gridColumn25.Width = 199;
      this.gridColumn26.Caption = "Bakım Türü";
      this.gridColumn26.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit7;
      this.gridColumn26.FieldName = "BAKIMTURUID";
      this.gridColumn26.MinWidth = 19;
      this.gridColumn26.Name = "gridColumn26";
      this.gridColumn26.OptionsColumn.AllowEdit = false;
      this.gridColumn26.OptionsColumn.ReadOnly = true;
      this.gridColumn26.Visible = true;
      this.gridColumn26.VisibleIndex = 21;
      this.gridColumn26.Width = 153;
      this.repositoryItemLookUpEdit7.AutoHeight = false;
      this.repositoryItemLookUpEdit7.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit7.DataSource = (object) this.tAHBAKIMTURUBindingSource;
      this.repositoryItemLookUpEdit7.DisplayMember = "BAKIMTURU";
      this.repositoryItemLookUpEdit7.Name = "repositoryItemLookUpEdit7";
      this.repositoryItemLookUpEdit7.NullText = "";
      this.repositoryItemLookUpEdit7.ValueMember = "ID";
      this.gridColumn27.Caption = "Bakım Derecesi";
      this.gridColumn27.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit8;
      this.gridColumn27.FieldName = "BAKIMDERECESIID";
      this.gridColumn27.MinWidth = 19;
      this.gridColumn27.Name = "gridColumn27";
      this.gridColumn27.OptionsColumn.AllowEdit = false;
      this.gridColumn27.OptionsColumn.ReadOnly = true;
      this.gridColumn27.Visible = true;
      this.gridColumn27.VisibleIndex = 23;
      this.gridColumn27.Width = 153;
      this.repositoryItemLookUpEdit8.AutoHeight = false;
      this.repositoryItemLookUpEdit8.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit8.DataSource = (object) this.tAHBAKIMDERECEBindingSource;
      this.repositoryItemLookUpEdit8.DisplayMember = "BAKIMDERECE";
      this.repositoryItemLookUpEdit8.Name = "repositoryItemLookUpEdit8";
      this.repositoryItemLookUpEdit8.NullText = "";
      this.repositoryItemLookUpEdit8.ValueMember = "ID";
      this.repositoryItemTimeSpanEdit3.AutoHeight = false;
      this.repositoryItemTimeSpanEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit3.Mask.EditMask = "t";
      this.repositoryItemTimeSpanEdit3.Name = "repositoryItemTimeSpanEdit3";
      this.repositoryItemTimeSpanEdit4.AutoHeight = false;
      this.repositoryItemTimeSpanEdit4.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeSpanEdit4.Name = "repositoryItemTimeSpanEdit4";
      this.ARACACIKLAMA1.AutoHeight = false;
      this.ARACACIKLAMA1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ARACACIKLAMA1.DataSource = (object) this.tBLARACLARBindingSource;
      this.ARACACIKLAMA1.DisplayMember = "ARACACIKLAMA";
      this.ARACACIKLAMA1.Name = "ARACACIKLAMA1";
      this.ARACACIKLAMA1.ValueMember = "ID";
      this.tabNavigationPage1.Caption = "İş Emir Listesi";
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl1);
      this.tabNavigationPage1.Controls.Add((Control) this.gridControl2);
      this.tabNavigationPage1.Controls.Add((Control) this.simpleButton1);
      this.tabNavigationPage1.Margin = new Padding(2);
      this.tabNavigationPage1.Name = "tabNavigationPage1";
      this.tabNavigationPage1.Size = new Size(1042, 440);
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(0, 0);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1042, 440);
      this.gridControl2.TabIndex = 4;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridControl2.DoubleClick += new EventHandler(this.gridControl2_DoubleClick_1);
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.DetailHeight = 284;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.Location = new Point(0, 2);
      this.simpleButton1.Margin = new Padding(2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(19, 20);
      this.simpleButton1.TabIndex = 3;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet5;
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage1);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage2);
      this.tabPane1.Controls.Add((Control) this.tabNavigationPage3);
      this.tabPane1.Dock = DockStyle.Fill;
      this.tabPane1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.Location = new Point(0, 96);
      this.tabPane1.Margin = new Padding(2);
      this.tabPane1.Name = "tabPane1";
      this.tabPane1.PageProperties.AppearanceCaption.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
      this.tabPane1.Pages.AddRange(new NavigationPageBase[3]
      {
        (NavigationPageBase) this.tabNavigationPage1,
        (NavigationPageBase) this.tabNavigationPage2,
        (NavigationPageBase) this.tabNavigationPage3
      });
      this.tabPane1.RegularSize = new Size(1042, 477);
      this.tabPane1.SelectedPage = this.tabNavigationPage1;
      this.tabPane1.Size = new Size(1042, 477);
      this.tabPane1.TabIndex = 3;
      this.tabPane1.Text = "İş Emir Listesi";
      this.tabPane1.Click += new EventHandler(this.tabPane1_Click_1);
      this.tabPane1.DoubleClick += new EventHandler(this.tabPane1_DoubleClick);
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLISEMIRDURUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMYERITableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tAHBAKIMDERECETableAdapter.ClearBeforeFill = true;
      this.tAHBAKIMTURUTableAdapter.ClearBeforeFill = true;
      this.tAHARIZANEDENITableAdapter.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter1.ClearBeforeFill = true;
      this.tBLISEMRITableAdapter2.ClearBeforeFill = true;
      this.yagMerkeziTableAdapter.ClearBeforeFill = true;
      this.sarfAtolyeTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1042, 573);
      this.Controls.Add((Control) this.tabPane1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (ilksayfa);
      this.Text = "Atölye Bölümü";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.popupMenu2.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).EndInit();
      this.atolyeListesi.EndInit();
      this.gridView1.EndInit();
      this.isemirdurum.EndInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.atolye.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.arizanedeni.EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
      this.aRIZANEDENI1.EndInit();
      this.bakimyeri.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).EndInit();
      this.aracigetiren.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bakimturu.EndInit();
      ((ISupportInitialize) this.tAHBAKIMTURUBindingSource).EndInit();
      this.bAKIMTURU1.EndInit();
      this.bakimderece.EndInit();
      ((ISupportInitialize) this.tAHBAKIMDERECEBindingSource).EndInit();
      this.bAKIMDERECE1.EndInit();
      this.plaka.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.repositoryItemTimeSpanEdit1.EndInit();
      this.repositoryItemTimeSpanEdit2.EndInit();
      this.popupMenu1.EndInit();
      this.tabNavigationPage3.ResumeLayout(false);
      this.gridControl4.EndInit();
      ((ISupportInitialize) this.sarfAtolyeBindingSource).EndInit();
      this.atolye_yagListesi.EndInit();
      this.gridView4.EndInit();
      this.repositoryItemLookUpEdit9.EndInit();
      this.repositoryItemLookUpEdit10.EndInit();
      this.repositoryItemLookUpEdit11.EndInit();
      this.repositoryItemLookUpEdit12.EndInit();
      this.repositoryItemLookUpEdit13.EndInit();
      this.repositoryItemLookUpEdit14.EndInit();
      this.repositoryItemLookUpEdit15.EndInit();
      this.repositoryItemLookUpEdit16.EndInit();
      this.repositoryItemTimeSpanEdit5.EndInit();
      this.repositoryItemTimeSpanEdit6.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource2).EndInit();
      this.yagAtolyesi.EndInit();
      this.tabNavigationPage2.ResumeLayout(false);
      this.gridControl3.EndInit();
      ((ISupportInitialize) this.yagMerkeziBindingSource).EndInit();
      this.gridView3.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.repositoryItemLookUpEdit4.EndInit();
      this.repositoryItemLookUpEdit5.EndInit();
      this.repositoryItemLookUpEdit6.EndInit();
      this.repositoryItemLookUpEdit7.EndInit();
      this.repositoryItemLookUpEdit8.EndInit();
      this.repositoryItemTimeSpanEdit3.EndInit();
      this.repositoryItemTimeSpanEdit4.EndInit();
      this.ARACACIKLAMA1.EndInit();
      this.tabNavigationPage1.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView2.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      ((ISupportInitialize) this.tabPane1).EndInit();
      this.tabPane1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
