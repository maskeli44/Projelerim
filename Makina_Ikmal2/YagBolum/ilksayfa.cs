// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.YagBolum.ilksayfa
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
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
using Makina_Ikmal.Classlar;
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

namespace Makina_Ikmal.YagBolum
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
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLISEMRIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter;
    private BindingSource tBLPERSONELBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource tBLISEMIRDURUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMIRDURUMTableAdapter tBLISEMIRDURUMTableAdapter;
    private BindingSource tBLBAKIMYERIBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLBAKIMYERITableAdapter tBLBAKIMYERITableAdapter;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private Makina_Ikmal.bellDataSet5TableAdapters.TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
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
    private YagAtolyesi yagAtolyesi;
    private BindingSource tBLISEMRIBindingSource2;
    private Makina_Ikmal.Model.YagAtolyesiTableAdapters.TBLISEMRITableAdapter tBLISEMRITableAdapter2;
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
    private RepositoryItemLookUpEdit ARACACIKLAMA1;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;

    public ilksayfa() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
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

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.yet.MenuYetkilendirme("Personel Listesi");
      this.listele();
      this.sayfa();
    }

    public void listele()
    {
      this.sarfAtolyeTableAdapter.Fill(this.atolye_yagListesi.sarfAtolye);
      this.yagMerkeziTableAdapter.Fill(this.atolye_yagListesi.yagMerkezi);
      this.tBLISEMRITableAdapter2.Fill(this.yagAtolyesi.TBLISEMRI);
      this.tAHARIZANEDENITableAdapter.Fill(this.aRIZANEDENI1.TAHARIZANEDENI);
      this.tAHBAKIMTURUTableAdapter.Fill(this.bAKIMTURU1.TAHBAKIMTURU);
      this.tAHBAKIMDERECETableAdapter.Fill(this.bAKIMDERECE1.TAHBAKIMDERECE);
      this.tBLATOLYEBOLUMTableAdapter.Fill(this.bellDataSet5.TBLATOLYEBOLUM);
      this.tBLBAKIMYERITableAdapter.Fill(this.bellDataSet5.TBLBAKIMYERI);
      this.tBLISEMIRDURUMTableAdapter.Fill(this.bellDataSet5.TBLISEMIRDURUM);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet5.TBLPERSONEL);
      this.tBLARACLARTableAdapter.Fill(this.bellDataSet7.TBLARACLAR);
      this.tBLISEMRITableAdapter.Fill(this.bellDataSet5.TBLISEMRI);
    }

    private void filtre()
    {
      this.gridView3.ActiveFilter.Clear();
      this.gridView3.ActiveFilterString = this.secmeislemi();
      this.gridView3.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      if (YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
        new YagEmri().Show();
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
      YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
      if (!this.db.TBLDEPOFISHRKT.Join((IEnumerable<TBLDEPOFIS>) this.db.TBLDEPOFIS, (Expression<System.Func<TBLDEPOFISHRKT, int?>>) (hd => hd.DEPOFISID), (Expression<System.Func<TBLDEPOFIS, int?>>) (hy => (int?) hy.ID), (hd, hy) => new
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
        ;
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
            e.Appearance.BackColor = Color.Purple;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.DarkBlue;
            break;
        }
      }
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e)
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

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));
      int num = (int) new isemirDetay_Yag().ShowDialog();
    }

    private void gridControl1_Click(object sender, EventArgs e) => YetkiClass.secim_id = Convert.ToInt32(this.gridView3.GetFocusedRowCellValue("ID"));

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

    private void sayfa() => this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl3;

    private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
    }

    private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e) => this.yazdir(this.gridControl3);

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

    private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
    {
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
        new YagEmri().Show();
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
    }

    private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView3_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
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
            e.Appearance.BackColor = Color.Purple;
            break;
          case 5:
            e.Appearance.BackColor = Color.Gray;
            break;
          case 6:
            e.Appearance.BackColor = Color.Green;
            break;
          case 7:
            e.Appearance.BackColor = Color.DarkBlue;
            break;
        }
      }
    }

    private void gridView3_DoubleClick_1(object sender, EventArgs e)
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
      this.barButtonItem23 = new BarButtonItem();
      this.barButtonItem24 = new BarButtonItem();
      this.barButtonItem25 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.popupMenu2 = new PopupMenu(this.components);
      this.tBLISEMRIBindingSource1 = new BindingSource(this.components);
      this.atolyeListesi = new AtolyeListesi();
      this.bellDataSet5 = new bellDataSet5();
      this.tBLISEMIRDURUMBindingSource = new BindingSource(this.components);
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.tAHARIZANEDENIBindingSource = new BindingSource(this.components);
      this.aRIZANEDENI1 = new ARIZANEDENI();
      this.tBLBAKIMYERIBindingSource = new BindingSource(this.components);
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.tAHBAKIMTURUBindingSource = new BindingSource(this.components);
      this.bAKIMTURU1 = new BAKIMTURU();
      this.tAHBAKIMDERECEBindingSource = new BindingSource(this.components);
      this.bAKIMDERECE1 = new BAKIMDERECE();
      this.sarfAtolyeBindingSource = new BindingSource(this.components);
      this.atolye_yagListesi = new atolye_yagListesi();
      this.tBLISEMRIBindingSource2 = new BindingSource(this.components);
      this.yagAtolyesi = new YagAtolyesi();
      this.yagMerkeziBindingSource = new BindingSource(this.components);
      this.tBLISEMRIBindingSource = new BindingSource(this.components);
      this.tBLISEMRITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMRITableAdapter();
      this.tBLPERSONELTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLPERSONELTableAdapter();
      this.tBLISEMIRDURUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLISEMIRDURUMTableAdapter();
      this.tBLBAKIMYERITableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLBAKIMYERITableAdapter();
      this.tBLATOLYEBOLUMTableAdapter = new Makina_Ikmal.bellDataSet5TableAdapters.TBLATOLYEBOLUMTableAdapter();
      this.tAHBAKIMDERECETableAdapter = new Makina_Ikmal.BAKIMDERECETableAdapters.TAHBAKIMDERECETableAdapter();
      this.tAHBAKIMTURUTableAdapter = new Makina_Ikmal.BAKIMTURUTableAdapters.TAHBAKIMTURUTableAdapter();
      this.tAHARIZANEDENITableAdapter = new Makina_Ikmal.ARIZANEDENITableAdapters.TAHARIZANEDENITableAdapter();
      this.tBLISEMRITableAdapter1 = new Makina_Ikmal.Model.AtolyeListesiTableAdapters.TBLISEMRITableAdapter();
      this.tBLISEMRITableAdapter2 = new Makina_Ikmal.Model.YagAtolyesiTableAdapters.TBLISEMRITableAdapter();
      this.yagMerkeziTableAdapter = new yagMerkeziTableAdapter();
      this.sarfAtolyeTableAdapter = new sarfAtolyeTableAdapter();
      this.gridControl3 = new GridControl();
      this.gridView3 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
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
      this.tBLARACLARTableAdapter = new Makina_Ikmal.bellDataSet7TableAdapters.TBLARACLARTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.popupMenu1.BeginInit();
      this.popupMenu2.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).BeginInit();
      this.atolyeListesi.BeginInit();
      this.bellDataSet5.BeginInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).BeginInit();
      this.aRIZANEDENI1.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      ((ISupportInitialize) this.tAHBAKIMTURUBindingSource).BeginInit();
      this.bAKIMTURU1.BeginInit();
      ((ISupportInitialize) this.tAHBAKIMDERECEBindingSource).BeginInit();
      this.bAKIMDERECE1.BeginInit();
      ((ISupportInitialize) this.sarfAtolyeBindingSource).BeginInit();
      this.atolye_yagListesi.BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource2).BeginInit();
      this.yagAtolyesi.BeginInit();
      ((ISupportInitialize) this.yagMerkeziBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).BeginInit();
      this.gridControl3.BeginInit();
      this.gridView3.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
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
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[35]
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
        (BarItem) this.barButtonItem26
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 34;
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
      this.ribbonControl1.Size = new Size(1042, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.Check;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
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
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
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
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem22);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem23);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem24);
      this.popupMenu2.ItemLinks.Add((BarItem) this.barButtonItem25);
      this.popupMenu2.Name = "popupMenu2";
      this.popupMenu2.Ribbon = this.ribbonControl1;
      this.tBLISEMRIBindingSource1.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource1.DataSource = (object) this.atolyeListesi;
      this.atolyeListesi.DataSetName = "AtolyeListesi";
      this.atolyeListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLISEMIRDURUMBindingSource.DataMember = "TBLISEMIRDURUM";
      this.tBLISEMIRDURUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.tAHARIZANEDENIBindingSource.DataMember = "TAHARIZANEDENI";
      this.tAHARIZANEDENIBindingSource.DataSource = (object) this.aRIZANEDENI1;
      this.aRIZANEDENI1.DataSetName = "ARIZANEDENI";
      this.aRIZANEDENI1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLBAKIMYERIBindingSource.DataMember = "TBLBAKIMYERI";
      this.tBLBAKIMYERIBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet5;
      this.tAHBAKIMTURUBindingSource.DataMember = "TAHBAKIMTURU";
      this.tAHBAKIMTURUBindingSource.DataSource = (object) this.bAKIMTURU1;
      this.bAKIMTURU1.DataSetName = "BAKIMTURU";
      this.bAKIMTURU1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tAHBAKIMDERECEBindingSource.DataMember = "TAHBAKIMDERECE";
      this.tAHBAKIMDERECEBindingSource.DataSource = (object) this.bAKIMDERECE1;
      this.bAKIMDERECE1.DataSetName = "BAKIMDERECE";
      this.bAKIMDERECE1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.sarfAtolyeBindingSource.DataMember = "sarfAtolye";
      this.sarfAtolyeBindingSource.DataSource = (object) this.atolye_yagListesi;
      this.atolye_yagListesi.DataSetName = "atolye_yagListesi";
      this.atolye_yagListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLISEMRIBindingSource2.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource2.DataSource = (object) this.yagAtolyesi;
      this.yagAtolyesi.DataSetName = "YagAtolyesi";
      this.yagAtolyesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.yagMerkeziBindingSource.DataMember = "yagMerkezi";
      this.yagMerkeziBindingSource.DataSource = (object) this.atolye_yagListesi;
      this.tBLISEMRIBindingSource.DataMember = "TBLISEMRI";
      this.tBLISEMRIBindingSource.DataSource = (object) this.bellDataSet5;
      this.tBLISEMRITableAdapter.ClearBeforeFill = true;
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
      this.gridControl3.DataSource = (object) this.yagMerkeziBindingSource;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.EmbeddedNavigator.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.EmbeddedNavigator.Appearance.Options.UseFont = true;
      this.gridControl3.EmbeddedNavigator.Buttons.Append.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
      this.gridControl3.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Edit.Enabled = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Edit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
      this.gridControl3.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
      this.gridControl3.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Remove.Enabled = false;
      this.gridControl3.EmbeddedNavigator.Buttons.Remove.Visible = false;
      this.gridControl3.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl3.EmbeddedNavigator.TextStringFormat = "Kayıt {0} of {1}";
      this.gridControl3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(0, 100);
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
      this.gridControl3.Size = new Size(1042, 473);
      this.gridControl3.TabIndex = 7;
      this.gridControl3.UseEmbeddedNavigator = true;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
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
      this.gridView3.RowCellStyle += new RowCellStyleEventHandler(this.gridView3_RowCellStyle_1);
      this.gridView3.DoubleClick += new EventHandler(this.gridView3_DoubleClick_1);
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
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.ARACACIKLAMA1.DisplayMember = "ARACACIKLAMA";
      this.ARACACIKLAMA1.Name = "ARACACIKLAMA1";
      this.ARACACIKLAMA1.ValueMember = "ID";
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1042, 573);
      this.Controls.Add((Control) this.gridControl3);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (ilksayfa);
      this.Text = "Atölye Bölümü";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.popupMenu1.EndInit();
      this.popupMenu2.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource1).EndInit();
      this.atolyeListesi.EndInit();
      this.bellDataSet5.EndInit();
      ((ISupportInitialize) this.tBLISEMIRDURUMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      ((ISupportInitialize) this.tAHARIZANEDENIBindingSource).EndInit();
      this.aRIZANEDENI1.EndInit();
      ((ISupportInitialize) this.tBLBAKIMYERIBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      ((ISupportInitialize) this.tAHBAKIMTURUBindingSource).EndInit();
      this.bAKIMTURU1.EndInit();
      ((ISupportInitialize) this.tAHBAKIMDERECEBindingSource).EndInit();
      this.bAKIMDERECE1.EndInit();
      ((ISupportInitialize) this.sarfAtolyeBindingSource).EndInit();
      this.atolye_yagListesi.EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource2).EndInit();
      this.yagAtolyesi.EndInit();
      ((ISupportInitialize) this.yagMerkeziBindingSource).EndInit();
      ((ISupportInitialize) this.tBLISEMRIBindingSource).EndInit();
      this.gridControl3.EndInit();
      this.gridView3.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
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
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
