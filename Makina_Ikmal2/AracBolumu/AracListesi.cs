// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.AracListesi
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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.AracBolumu.Raporlar;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class AracListesi : Form
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private KiralikArac1cs yeniKiralik = new KiralikArac1cs();
    private GrubaGoreAracListesi1 yeniAracListesi = new GrubaGoreAracListesi1();
    private string secme = "";
    private string secme2 = "";
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private GridView gridView1;
    private GridControl gridControl1;
    private RibbonPageGroup ribbonPageGroup2;
    private BarEditItem barEditItem1;
    private BarEditItem barEditItem2;
    private RepositoryItemCheckEdit repositoryItemCheckEdit1;
    private RepositoryItemRadioGroup repositoryItemRadioGroup1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarEditItem barEditItem4;
    private RepositoryItemRadioGroup repositoryItemRadioGroup2;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarCheckItem barCheckItem6;
    private RibbonPageGroup ribbonPageGroup3;
    private RibbonPageGroup ribbonPageGroup4;
    private BarEditItem barEditItem5;
    private RepositoryItemSearchControl repositoryItemSearchControl2;
    private BarCheckItem barCheckItem7;
    private BarCheckItem barCheckItem9;
    private BarCheckItem barCheckItem10;
    private BarCheckItem barCheckItem11;
    private BarCheckItem barCheckItem12;
    private BarCheckItem barCheckItem13;
    private RibbonPageGroup ribbonPageGroup5;
    private BarEditItem barEditItem3;
    private BarCheckItem barCheckItem8;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private RibbonPageGroup ribbonPageGroup6;
    private BarCheckItem barCheckItem14;
    private BarButtonItem barButtonItem13;
    private PopupMenu popupMenu1;
    private BarButtonItem barButtonItem14;
    private BarButtonItem barButtonItem15;
    private BarButtonItem barButtonItem16;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colVERILDIGIILILCE;
    private GridColumn colPLAKA;
    private GridColumn colARACACIKLAMA;
    private GridColumn colTAHSPLAKA;
    private GridColumn colTAHSPLKTARIH;
    private GridColumn colESKIPLAKA;
    private GridColumn colTESCILSIRANO;
    private GridColumn colILKTESCILTARIHI;
    private GridColumn colTESCILTARIHI;
    private GridColumn colMARKAID;
    private GridColumn colMODEL;
    private GridColumn colCINSI;
    private GridColumn colTICARIADI;
    private GridColumn colTIPI;
    private GridColumn colRENGI;
    private GridColumn colMOTORNO;
    private GridColumn colSASENO;
    private GridColumn colSILINDIRHACMI;
    private GridColumn colMOTORGUCU;
    private GridColumn colBEYGIRGUCU;
    private GridColumn colTEKERLEKADEDI;
    private GridColumn colYURUYENAKSAMI;
    private GridColumn colLASTIKEBADI;
    private GridColumn colDIGEROZELLIKLER;
    private GridColumn colMUAYENEGECSUR;
    private GridColumn colTRAFIKSGORTA;
    private GridColumn colKASKO;
    private GridColumn colBELGESERINO;
    private GridColumn colARACFIRMAID;
    private GridColumn colBELDBIRIMID;
    private GridColumn colBELDMUDURLUKID;
    private GridColumn colTAHSISEDILENID;
    private GridColumn colARACKULPERSID;
    private GridColumn colARACGRUBUID;
    private GridColumn colARACGRUBU2ID;
    private GridColumn colYAKITID;
    private GridColumn colYKTYAKMATURU;
    private GridColumn colSTDYKYAKIT;
    private GridColumn colARACDURUMID;
    private GridColumn colARACTIPIID;
    private GridColumn colTKPVARYOK;
    private GridColumn colYEDEKANAHTAR;
    private GridColumn colYEDEKANHTRACKLM;
    private GridColumn colGOREVBITIMTARIH;
    private GridColumn colGOREVDURUM;
    private GridColumn colILGILINOT;
    private GridColumn colSAVEUSER;
    private GridColumn colSAVEDATE;
    private GridColumn colEDITUSER;
    private GridColumn colEDITDATE;
    private GridColumn colSAVEMAC;
    private GridColumn colEDITMAC;
    private GridColumn colSAVEIP;
    private GridColumn colEDITIP;
    private GridColumn colARACRESIM1;
    private GridColumn colARACRESIM2;
    private GridColumn colTAKIPVARYOKID;
    private GridColumn colSIRANO;
    private GridColumn colGUNCELDEGERI;
    private GridColumn colYENIDEGERI;
    private GridColumn colPARABIRIMI;
    private GridColumn colGENELBAKIMKM;
    private GridColumn colMOTORYAGKM;
    private GridColumn colSANZIMANYAGKM;
    private GridColumn colDIFERANSIYELYAGKM;
    private GridColumn colHIDROLIKYAGKM;
    private GridColumn colRESIMON;
    private GridColumn colRESIMARKA;
    private GridColumn colYENIDEGERTARIH;
    private GridColumn colHGSVARYOK;
    private GridColumn colEGZOZKONTROL;
    private GridColumn colTRAFIKSGORTA2;
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private BarButtonItem barButtonItem21;
    private BarButtonItem barButtonItem22;
    private BarSubItem Kira;
    private BarSubItem basanlıgaGore;

    public AracListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new AracEkle().Show();
    }

    private void filtre()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private void filtre2()
    {
      this.gridView1.ActiveFilter.Clear();
      this.gridView1.ActiveFilterString = this.secmeislemi2();
      this.gridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
    }

    private string secmeislemi()
    {
      this.secme = "";
      string str = "";
      if (this.barCheckItem1.Checked)
        this.secme += "[ARACTIPIID] = 'Resmi' AND";
      if (this.barCheckItem4.Checked)
        this.secme += "  [ARACTIPIID] = 'Destek Kiralık' AND";
      if (this.barCheckItem6.Checked)
        this.secme += "[ARACTIPIID] = 'Diğer Kiralıklar' AND";
      if (this.barCheckItem5.Checked)
        this.secme += "[ARACTIPIID] = 'Ekipman' AND";
      if (this.barCheckItem7.Checked)
        this.secme += "[ARACDURUMID] = 'Aktif' OR";
      if (this.barCheckItem10.Checked)
        this.secme += "  [ARACDURUMID] = 'Göreve Giden' OR";
      if (this.barCheckItem9.Checked)
        this.secme += "[ARACDURUMID] = 'Görevli Gelen' OR";
      if (this.barCheckItem11.Checked)
        this.secme += "[ARACDURUMID] = 'Hurda' OR";
      if (this.barCheckItem12.Checked)
        this.secme += "[ARACDURUMID] = 'İş Görmez' OR";
      if (this.barCheckItem8.Checked)
        this.secme += "[ARACDURUMID] = 'Pasif Kiralık' OR";
      if (this.barCheckItem13.Checked)
        this.secme += "[ARACDURUMID] = 'Çalıntı' OR";
      try
      {
        str = this.secme.Substring(0, this.secme.Length - 3);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private string secmeislemi2()
    {
      this.secme2 = "";
      string str = "";
      if (this.barCheckItem7.Checked)
        this.secme2 += "[ARACTIPIID] = 1 OR";
      if (this.barCheckItem9.Checked)
        this.secme2 += "  [ARACTIPIID] = 2 OR";
      if (this.barCheckItem10.Checked)
        this.secme2 += "[ARACTIPIID] = 3 OR";
      if (this.barCheckItem11.Checked)
        this.secme2 += "[ARACTIPIID] = 4 OR";
      if (this.barCheckItem12.Checked)
        this.secme2 += "[ARACTIPIID] = 5 OR";
      if (this.barCheckItem13.Checked)
        this.secme2 += "[ARACTIPIID] = 6 OR";
      if (this.barCheckItem8.Checked)
        this.secme2 += "[ARACTIPIID] = 7 OR";
      try
      {
        str = this.secme2.Substring(0, this.secme2.Length - 2);
      }
      catch (Exception ex)
      {
      }
      return str;
    }

    private void Form6_Load(object sender, EventArgs e) => this.Yenile();

    public void Yenile()
    {
      // ISSUE: unable to decompile the method.
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new AracGuncelle().Show();
    }

    private void barCheckItem8_CheckedChanged(object sender, ItemClickEventArgs e) => this.Yenile();

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      YetkiClass.secim = "guncelle";
      new AracGuncelle().Show();
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.Yenile();

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new ZimmetKaydiEkle().Show();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.yet.yetkiislemleri("Araç Listesi");
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        this.db.TBLARACLAR.Remove(this.db.TBLARACLAR.Find(new object[1]
        {
          (object) YetkiClass.secim_id
        }));
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt başarı ile silindi.");
        LogEkle.Logs("Silme Yapti");
        this.Yenile();
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Silme yetkiniz bulunmamaktadır. Lutfen yetkili kişi ile iletişime geçiniz.");
      }
    }

    private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem7_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem9_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem10_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem11_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem12_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem13_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void barCheckItem8_CheckedChanged_1(object sender, ItemClickEventArgs e) => this.filtre();

    private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void KiralikArac()
    {
      this.yeniKiralik.Parameters["aracID"].Value = this.gridView1.GetFocusedRowCellValue(this.colID);
      this.yeniKiralik.Parameters["aracID"].Visible = false;
      new ReportPrintTool((IReport) this.yeniKiralik).ShowPreviewDialog();
    }

    private void AracGrupListesi()
    {
      for (int rowHandle = 0; rowHandle < this.gridView1.DataRowCount; ++rowHandle)
      {
        this.yeniKiralik.Parameters["aracID"].Value = this.gridView1.GetRowCellValue(rowHandle, this.colID);
        this.yeniKiralik.Parameters["aracID"].Visible = false;
      }
      new ReportPrintTool((IReport) this.yeniAracListesi).ShowPreviewDialog();
    }

    private void barCheckItem14_CheckedChanged(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private int AracTipiSec()
    {
      if (this.barCheckItem1.Checked)
        return 1;
      if (this.barCheckItem4.Checked)
        return 2;
      if (this.barCheckItem5.Checked)
        return 4;
      return this.barCheckItem6.Checked ? 3 : 0;
    }

    private int AracDurumSec()
    {
      if (this.barCheckItem7.Checked)
        return 1;
      if (this.barCheckItem8.Checked)
        return 7;
      if (this.barCheckItem9.Checked)
        return 2;
      if (this.barCheckItem10.Checked)
        return 3;
      if (this.barCheckItem11.Checked)
        return 4;
      if (this.barCheckItem12.Checked)
        return 5;
      return this.barCheckItem13.Checked ? 6 : 0;
    }

    private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
    {
      AracParkIcmalSayim aracParkIcmalSayim = new AracParkIcmalSayim();
      aracParkIcmalSayim.Parameters["aracDurumID"].Value = (object) this.AracDurumSec();
      aracParkIcmalSayim.Parameters["aracDurumID"].Visible = false;
      aracParkIcmalSayim.Parameters["aracTipID"].Value = (object) this.AracTipiSec();
      aracParkIcmalSayim.Parameters["aracTipID"].Visible = false;
      new ReportPrintTool((IReport) aracParkIcmalSayim).ShowPreviewDialog();
      PdfExportOptions options = new PdfExportOptions()
      {
        PdfACompatibility = PdfACompatibility.PdfA1b
      };
      string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\aracparikmalsayim.pdf";
      aracParkIcmalSayim.ExportToPdf(path, options);
      int num = (int) MessageBox.Show("Dosya kaydedildi.");
      Thread.Sleep(2000);
    }

    private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
    {
      AracIcmalPivot aracIcmalPivot = new AracIcmalPivot();
      new ReportPrintTool((IReport) aracIcmalPivot).ShowPreviewDialog();
      PdfExportOptions options = new PdfExportOptions()
      {
        PdfACompatibility = PdfACompatibility.PdfA1b
      };
      string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\aracparikmalsayim.pdf";
      aracIcmalPivot.ExportToPdf(path, options);
      int num = (int) MessageBox.Show("Dosya kaydedildi.");
      Thread.Sleep(2000);
    }

    private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
    {
      AracParkIcmal aracParkIcmal = new AracParkIcmal();
      new ReportPrintTool((IReport) aracParkIcmal).ShowPreviewDialog();
      PdfExportOptions options = new PdfExportOptions()
      {
        PdfACompatibility = PdfACompatibility.PdfA1b
      };
      string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\aracparikmalsayim.pdf";
      aracParkIcmal.ExportToPdf(path, options);
      int num = (int) MessageBox.Show("Dosya kaydedildi.");
      Thread.Sleep(2000);
    }

    private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e) => this.filtre();

    private void satirToplam()
    {
    }

    private void gridControl1_Load_1(object sender, EventArgs e) => this.satirToplam();

    private void gridControl1_DefaultViewChanged(object sender, EventArgs e) => this.satirToplam();

    private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) => this.satirToplam();

    private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new AracGrubunaGore()).ShowPreviewDialog();

    private void baskanlıgaGore_ItemClick(object sender, ItemClickEventArgs e)
    {
      BaskanliginaGore baskanliginaGore = new BaskanliginaGore();
      baskanliginaGore.Parameters["id"].Value = (object) e.Item.Name;
      baskanliginaGore.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) baskanliginaGore).ShowPreviewDialog();
    }

    private void Kira_ItemClick(object sender, ItemClickEventArgs e)
    {
      KamyonIsMakinesiKiralik isMakinesiKiralik = new KamyonIsMakinesiKiralik();
      isMakinesiKiralik.Parameters["id"].Value = (object) e.Item.Name;
      isMakinesiKiralik.Parameters["id"].Visible = false;
      new ReportPrintTool((IReport) isMakinesiKiralik).ShowPreviewDialog();
    }

    private void gridControl1_FocusedViewChanged(object sender, ViewFocusEventArgs e) => this.satirToplam();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracListesi));
      this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
      this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.barEditItem2 = new BarEditItem();
      this.barEditItem4 = new BarEditItem();
      this.repositoryItemRadioGroup2 = new RepositoryItemRadioGroup();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.barCheckItem3 = new BarCheckItem();
      this.barCheckItem4 = new BarCheckItem();
      this.barCheckItem5 = new BarCheckItem();
      this.barCheckItem6 = new BarCheckItem();
      this.barEditItem5 = new BarEditItem();
      this.repositoryItemSearchControl2 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colVERILDIGIILILCE = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colARACACIKLAMA = new GridColumn();
      this.colTAHSPLAKA = new GridColumn();
      this.colTAHSPLKTARIH = new GridColumn();
      this.colESKIPLAKA = new GridColumn();
      this.colTESCILSIRANO = new GridColumn();
      this.colILKTESCILTARIHI = new GridColumn();
      this.colTESCILTARIHI = new GridColumn();
      this.colMARKAID = new GridColumn();
      this.colMODEL = new GridColumn();
      this.colCINSI = new GridColumn();
      this.colTICARIADI = new GridColumn();
      this.colTIPI = new GridColumn();
      this.colRENGI = new GridColumn();
      this.colMOTORNO = new GridColumn();
      this.colSASENO = new GridColumn();
      this.colSILINDIRHACMI = new GridColumn();
      this.colMOTORGUCU = new GridColumn();
      this.colBEYGIRGUCU = new GridColumn();
      this.colTEKERLEKADEDI = new GridColumn();
      this.colYURUYENAKSAMI = new GridColumn();
      this.colLASTIKEBADI = new GridColumn();
      this.colDIGEROZELLIKLER = new GridColumn();
      this.colMUAYENEGECSUR = new GridColumn();
      this.colTRAFIKSGORTA2 = new GridColumn();
      this.colTRAFIKSGORTA = new GridColumn();
      this.colKASKO = new GridColumn();
      this.colBELGESERINO = new GridColumn();
      this.colARACFIRMAID = new GridColumn();
      this.colBELDBIRIMID = new GridColumn();
      this.colBELDMUDURLUKID = new GridColumn();
      this.colTAHSISEDILENID = new GridColumn();
      this.colARACKULPERSID = new GridColumn();
      this.colARACGRUBUID = new GridColumn();
      this.colARACGRUBU2ID = new GridColumn();
      this.colYAKITID = new GridColumn();
      this.colYKTYAKMATURU = new GridColumn();
      this.colSTDYKYAKIT = new GridColumn();
      this.colARACDURUMID = new GridColumn();
      this.colARACTIPIID = new GridColumn();
      this.colTKPVARYOK = new GridColumn();
      this.colYEDEKANAHTAR = new GridColumn();
      this.colYEDEKANHTRACKLM = new GridColumn();
      this.colGOREVBITIMTARIH = new GridColumn();
      this.colGOREVDURUM = new GridColumn();
      this.colILGILINOT = new GridColumn();
      this.colSAVEUSER = new GridColumn();
      this.colSAVEDATE = new GridColumn();
      this.colEDITUSER = new GridColumn();
      this.colEDITDATE = new GridColumn();
      this.colSAVEMAC = new GridColumn();
      this.colEDITMAC = new GridColumn();
      this.colSAVEIP = new GridColumn();
      this.colEDITIP = new GridColumn();
      this.colARACRESIM1 = new GridColumn();
      this.colARACRESIM2 = new GridColumn();
      this.colTAKIPVARYOKID = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colGUNCELDEGERI = new GridColumn();
      this.colYENIDEGERI = new GridColumn();
      this.colPARABIRIMI = new GridColumn();
      this.colGENELBAKIMKM = new GridColumn();
      this.colMOTORYAGKM = new GridColumn();
      this.colSANZIMANYAGKM = new GridColumn();
      this.colDIFERANSIYELYAGKM = new GridColumn();
      this.colHIDROLIKYAGKM = new GridColumn();
      this.colRESIMON = new GridColumn();
      this.colRESIMARKA = new GridColumn();
      this.colYENIDEGERTARIH = new GridColumn();
      this.colHGSVARYOK = new GridColumn();
      this.colEGZOZKONTROL = new GridColumn();
      this.barCheckItem7 = new BarCheckItem();
      this.barCheckItem9 = new BarCheckItem();
      this.barCheckItem10 = new BarCheckItem();
      this.barCheckItem11 = new BarCheckItem();
      this.barCheckItem12 = new BarCheckItem();
      this.barCheckItem13 = new BarCheckItem();
      this.barCheckItem8 = new BarCheckItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barButtonItem12 = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.barButtonItem14 = new BarButtonItem();
      this.barButtonItem15 = new BarButtonItem();
      this.barButtonItem16 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.Kira = new BarSubItem();
      this.basanlıgaGore = new BarSubItem();
      this.barCheckItem14 = new BarCheckItem();
      this.barButtonItem13 = new BarButtonItem();
      this.barButtonItem17 = new BarButtonItem();
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.barButtonItem21 = new BarButtonItem();
      this.barButtonItem22 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemCheckEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.popupMenu1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.SuspendLayout();
      this.repositoryItemCheckEdit1.AutoHeight = false;
      this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
      this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[44]
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
        (BarItem) this.barEditItem1,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem4,
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2,
        (BarItem) this.barCheckItem3,
        (BarItem) this.barCheckItem4,
        (BarItem) this.barCheckItem5,
        (BarItem) this.barCheckItem6,
        (BarItem) this.barEditItem5,
        (BarItem) this.barCheckItem7,
        (BarItem) this.barCheckItem9,
        (BarItem) this.barCheckItem10,
        (BarItem) this.barCheckItem11,
        (BarItem) this.barCheckItem12,
        (BarItem) this.barCheckItem13,
        (BarItem) this.barCheckItem8,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barButtonItem12,
        (BarItem) this.barCheckItem14,
        (BarItem) this.barButtonItem13,
        (BarItem) this.barButtonItem14,
        (BarItem) this.barButtonItem15,
        (BarItem) this.barButtonItem16,
        (BarItem) this.barButtonItem17,
        (BarItem) this.barButtonItem18,
        (BarItem) this.barButtonItem19,
        (BarItem) this.barButtonItem20,
        (BarItem) this.barButtonItem21,
        (BarItem) this.barButtonItem22,
        (BarItem) this.Kira,
        (BarItem) this.basanlıgaGore
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 53;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemRadioGroup2,
        (RepositoryItem) this.repositoryItemSearchControl2
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1455, 100);
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
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
      this.barEditItem1.Caption = "barEditItem1";
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemCheckEdit1;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem2.Caption = "barEditItem2";
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemRadioGroup1;
      this.barEditItem2.Id = 12;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem4.Caption = "barEditItem4";
      this.barEditItem4.Edit = (RepositoryItem) this.repositoryItemRadioGroup2;
      this.barEditItem4.Id = 14;
      this.barEditItem4.Name = "barEditItem4";
      this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
      this.barCheckItem1.Caption = "Resmi";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barCheckItem1.ItemAppearance.Disabled.Options.UseFont = true;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem1.CheckedChanged += new ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
      this.barCheckItem2.Caption = "barCheckItem2";
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "Diğer Kiralık";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barCheckItem4.Caption = "Destek Kiralık";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem4.CheckedChanged += new ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
      this.barCheckItem5.Caption = "Ekipman";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem5.CheckedChanged += new ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
      this.barCheckItem6.Caption = "Diğer Kiralık";
      this.barCheckItem6.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem6.Id = 20;
      this.barCheckItem6.Name = "barCheckItem6";
      this.barCheckItem6.CheckedChanged += new ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
      this.barEditItem5.Edit = (RepositoryItem) this.repositoryItemSearchControl2;
      this.barEditItem5.EditHeight = 30;
      this.barEditItem5.EditWidth = 140;
      this.barEditItem5.Hint = "Kayıt Bul...";
      this.barEditItem5.Id = 22;
      this.barEditItem5.ItemAppearance.Disabled.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Disabled.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Hovered.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Hovered.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Normal.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Normal.Options.UseFont = true;
      this.barEditItem5.ItemAppearance.Pressed.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem5.ItemAppearance.Pressed.Options.UseFont = true;
      this.barEditItem5.Name = "barEditItem5";
      this.repositoryItemSearchControl2.AllowNullInput = DefaultBoolean.True;
      this.repositoryItemSearchControl2.AutoHeight = false;
      this.repositoryItemSearchControl2.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl2.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl2.Name = "repositoryItemSearchControl2";
      this.repositoryItemSearchControl2.NullValuePrompt = "Kayıt Bul...";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1455, 618);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DefaultViewChanged += new EventHandler(this.gridControl1_DefaultViewChanged);
      this.gridControl1.Load += new EventHandler(this.gridControl1_Load_1);
      this.gridControl1.FocusedViewChanged += new ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.gridView1.Appearance.EvenRow.BackColor = Color.FromArgb(0, 192, 192);
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.White;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[74]
      {
        this.colID,
        this.colKOD,
        this.colVERILDIGIILILCE,
        this.colPLAKA,
        this.colARACACIKLAMA,
        this.colTAHSPLAKA,
        this.colTAHSPLKTARIH,
        this.colESKIPLAKA,
        this.colTESCILSIRANO,
        this.colILKTESCILTARIHI,
        this.colTESCILTARIHI,
        this.colMARKAID,
        this.colMODEL,
        this.colCINSI,
        this.colTICARIADI,
        this.colTIPI,
        this.colRENGI,
        this.colMOTORNO,
        this.colSASENO,
        this.colSILINDIRHACMI,
        this.colMOTORGUCU,
        this.colBEYGIRGUCU,
        this.colTEKERLEKADEDI,
        this.colYURUYENAKSAMI,
        this.colLASTIKEBADI,
        this.colDIGEROZELLIKLER,
        this.colMUAYENEGECSUR,
        this.colTRAFIKSGORTA2,
        this.colTRAFIKSGORTA,
        this.colKASKO,
        this.colBELGESERINO,
        this.colARACFIRMAID,
        this.colBELDBIRIMID,
        this.colBELDMUDURLUKID,
        this.colTAHSISEDILENID,
        this.colARACKULPERSID,
        this.colARACGRUBUID,
        this.colARACGRUBU2ID,
        this.colYAKITID,
        this.colYKTYAKMATURU,
        this.colSTDYKYAKIT,
        this.colARACDURUMID,
        this.colARACTIPIID,
        this.colTKPVARYOK,
        this.colYEDEKANAHTAR,
        this.colYEDEKANHTRACKLM,
        this.colGOREVBITIMTARIH,
        this.colGOREVDURUM,
        this.colILGILINOT,
        this.colSAVEUSER,
        this.colSAVEDATE,
        this.colEDITUSER,
        this.colEDITDATE,
        this.colSAVEMAC,
        this.colEDITMAC,
        this.colSAVEIP,
        this.colEDITIP,
        this.colARACRESIM1,
        this.colARACRESIM2,
        this.colTAKIPVARYOKID,
        this.colSIRANO,
        this.colGUNCELDEGERI,
        this.colYENIDEGERI,
        this.colPARABIRIMI,
        this.colGENELBAKIMKM,
        this.colMOTORYAGKM,
        this.colSANZIMANYAGKM,
        this.colDIFERANSIYELYAGKM,
        this.colHIDROLIKYAGKM,
        this.colRESIMON,
        this.colRESIMARKA,
        this.colYENIDEGERTARIH,
        this.colHGSVARYOK,
        this.colEGZOZKONTROL
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.GroupPanelText = "GRUPLA";
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.OptionsView.ShowFooter = true;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.colMOTORGUCU, ColumnSortOrder.Ascending)
      });
      this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colKOD.FieldName = "KOD";
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colVERILDIGIILILCE.Caption = "Verildiği İl İlçe";
      this.colVERILDIGIILILCE.FieldName = "VERILDIGIILILCE";
      this.colVERILDIGIILILCE.Name = "colVERILDIGIILILCE";
      this.colVERILDIGIILILCE.OptionsColumn.AllowEdit = false;
      this.colVERILDIGIILILCE.OptionsColumn.ReadOnly = true;
      this.colVERILDIGIILILCE.Visible = true;
      this.colVERILDIGIILILCE.VisibleIndex = 14;
      this.colVERILDIGIILILCE.Width = 134;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.OptionsColumn.AllowEdit = false;
      this.colPLAKA.OptionsColumn.ReadOnly = true;
      this.colPLAKA.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "PLAKA", "Kayıt Sayısı {0}")
      });
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 2;
      this.colPLAKA.Width = 128;
      this.colARACACIKLAMA.Caption = "Araç Açıklama";
      this.colARACACIKLAMA.FieldName = "ARACACIKLAMA";
      this.colARACACIKLAMA.Name = "colARACACIKLAMA";
      this.colARACACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colARACACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colARACACIKLAMA.Visible = true;
      this.colARACACIKLAMA.VisibleIndex = 13;
      this.colARACACIKLAMA.Width = 136;
      this.colTAHSPLAKA.Caption = "Tahsis Plaka";
      this.colTAHSPLAKA.FieldName = "TAHSPLAKA";
      this.colTAHSPLAKA.Name = "colTAHSPLAKA";
      this.colTAHSPLAKA.OptionsColumn.AllowEdit = false;
      this.colTAHSPLAKA.OptionsColumn.ReadOnly = true;
      this.colTAHSPLAKA.Visible = true;
      this.colTAHSPLAKA.VisibleIndex = 15;
      this.colTAHSPLAKA.Width = 128;
      this.colTAHSPLKTARIH.Caption = "Tahsis Plaka Tarih";
      this.colTAHSPLKTARIH.DisplayFormat.FormatString = "d";
      this.colTAHSPLKTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colTAHSPLKTARIH.FieldName = "TAHSPLKTARIH";
      this.colTAHSPLKTARIH.Name = "colTAHSPLKTARIH";
      this.colTAHSPLKTARIH.OptionsColumn.AllowEdit = false;
      this.colTAHSPLKTARIH.OptionsColumn.ReadOnly = true;
      this.colTAHSPLKTARIH.Visible = true;
      this.colTAHSPLKTARIH.VisibleIndex = 16;
      this.colTAHSPLKTARIH.Width = 135;
      this.colESKIPLAKA.Caption = "Eski Plaka";
      this.colESKIPLAKA.FieldName = "ESKIPLAKA";
      this.colESKIPLAKA.Name = "colESKIPLAKA";
      this.colESKIPLAKA.OptionsColumn.AllowEdit = false;
      this.colESKIPLAKA.OptionsColumn.ReadOnly = true;
      this.colESKIPLAKA.Visible = true;
      this.colESKIPLAKA.VisibleIndex = 17;
      this.colESKIPLAKA.Width = 144;
      this.colTESCILSIRANO.Caption = "Tescil Sıra No";
      this.colTESCILSIRANO.FieldName = "TESCILSIRANO";
      this.colTESCILSIRANO.Name = "colTESCILSIRANO";
      this.colTESCILSIRANO.OptionsColumn.AllowEdit = false;
      this.colTESCILSIRANO.OptionsColumn.ReadOnly = true;
      this.colTESCILSIRANO.Visible = true;
      this.colTESCILSIRANO.VisibleIndex = 18;
      this.colTESCILSIRANO.Width = 153;
      this.colILKTESCILTARIHI.Caption = "İlk Tescil Tarihi";
      this.colILKTESCILTARIHI.DisplayFormat.FormatString = "d";
      this.colILKTESCILTARIHI.DisplayFormat.FormatType = FormatType.DateTime;
      this.colILKTESCILTARIHI.FieldName = "ILKTESCILTARIHI";
      this.colILKTESCILTARIHI.Name = "colILKTESCILTARIHI";
      this.colILKTESCILTARIHI.OptionsColumn.AllowEdit = false;
      this.colILKTESCILTARIHI.OptionsColumn.ReadOnly = true;
      this.colILKTESCILTARIHI.Visible = true;
      this.colILKTESCILTARIHI.VisibleIndex = 19;
      this.colILKTESCILTARIHI.Width = 142;
      this.colTESCILTARIHI.Caption = "Tescil Tarihi";
      this.colTESCILTARIHI.DisplayFormat.FormatString = "d";
      this.colTESCILTARIHI.DisplayFormat.FormatType = FormatType.DateTime;
      this.colTESCILTARIHI.FieldName = "TESCILTARIHI";
      this.colTESCILTARIHI.Name = "colTESCILTARIHI";
      this.colTESCILTARIHI.OptionsColumn.AllowEdit = false;
      this.colTESCILTARIHI.OptionsColumn.ReadOnly = true;
      this.colTESCILTARIHI.Visible = true;
      this.colTESCILTARIHI.VisibleIndex = 20;
      this.colTESCILTARIHI.Width = 146;
      this.colMARKAID.Caption = "Marka";
      this.colMARKAID.FieldName = "MARKAID";
      this.colMARKAID.Name = "colMARKAID";
      this.colMARKAID.OptionsColumn.AllowEdit = false;
      this.colMARKAID.OptionsColumn.ReadOnly = true;
      this.colMARKAID.Visible = true;
      this.colMARKAID.VisibleIndex = 10;
      this.colMARKAID.Width = 137;
      this.colMODEL.Caption = "Model ";
      this.colMODEL.FieldName = "MODEL";
      this.colMODEL.Name = "colMODEL";
      this.colMODEL.OptionsColumn.AllowEdit = false;
      this.colMODEL.OptionsColumn.ReadOnly = true;
      this.colMODEL.Visible = true;
      this.colMODEL.VisibleIndex = 11;
      this.colMODEL.Width = 124;
      this.colCINSI.Caption = "Cinsi";
      this.colCINSI.FieldName = "CINSI";
      this.colCINSI.Name = "colCINSI";
      this.colCINSI.OptionsColumn.AllowEdit = false;
      this.colCINSI.OptionsColumn.ReadOnly = true;
      this.colCINSI.Visible = true;
      this.colCINSI.VisibleIndex = 21;
      this.colCINSI.Width = 142;
      this.colTICARIADI.Caption = "Ticari Adı";
      this.colTICARIADI.FieldName = "TICARIADI";
      this.colTICARIADI.Name = "colTICARIADI";
      this.colTICARIADI.OptionsColumn.AllowEdit = false;
      this.colTICARIADI.OptionsColumn.ReadOnly = true;
      this.colTICARIADI.Visible = true;
      this.colTICARIADI.VisibleIndex = 22;
      this.colTICARIADI.Width = 124;
      this.colTIPI.Caption = "Tipi";
      this.colTIPI.FieldName = "TIPI";
      this.colTIPI.Name = "colTIPI";
      this.colTIPI.OptionsColumn.AllowEdit = false;
      this.colTIPI.OptionsColumn.ReadOnly = true;
      this.colTIPI.Visible = true;
      this.colTIPI.VisibleIndex = 23;
      this.colTIPI.Width = 123;
      this.colRENGI.Caption = "Renk";
      this.colRENGI.FieldName = "RENGI";
      this.colRENGI.Name = "colRENGI";
      this.colRENGI.OptionsColumn.AllowEdit = false;
      this.colRENGI.OptionsColumn.ReadOnly = true;
      this.colRENGI.Visible = true;
      this.colRENGI.VisibleIndex = 12;
      this.colRENGI.Width = 124;
      this.colMOTORNO.Caption = "Motor No";
      this.colMOTORNO.FieldName = "MOTORNO";
      this.colMOTORNO.Name = "colMOTORNO";
      this.colMOTORNO.OptionsColumn.AllowEdit = false;
      this.colMOTORNO.OptionsColumn.ReadOnly = true;
      this.colMOTORNO.Visible = true;
      this.colMOTORNO.VisibleIndex = 24;
      this.colMOTORNO.Width = 118;
      this.colSASENO.Caption = "Şase No";
      this.colSASENO.FieldName = "SASENO";
      this.colSASENO.Name = "colSASENO";
      this.colSASENO.OptionsColumn.AllowEdit = false;
      this.colSASENO.OptionsColumn.ReadOnly = true;
      this.colSASENO.Visible = true;
      this.colSASENO.VisibleIndex = 25;
      this.colSASENO.Width = 115;
      this.colSILINDIRHACMI.Caption = "Silindir Hacmi";
      this.colSILINDIRHACMI.FieldName = "SILINDIRHACMI";
      this.colSILINDIRHACMI.Name = "colSILINDIRHACMI";
      this.colSILINDIRHACMI.OptionsColumn.AllowEdit = false;
      this.colSILINDIRHACMI.OptionsColumn.ReadOnly = true;
      this.colSILINDIRHACMI.Visible = true;
      this.colSILINDIRHACMI.VisibleIndex = 26;
      this.colSILINDIRHACMI.Width = 141;
      this.colMOTORGUCU.Caption = "Motor Gücü";
      this.colMOTORGUCU.FieldName = "MOTORGUCU";
      this.colMOTORGUCU.Name = "colMOTORGUCU";
      this.colMOTORGUCU.OptionsColumn.AllowEdit = false;
      this.colMOTORGUCU.OptionsColumn.ReadOnly = true;
      this.colMOTORGUCU.Visible = true;
      this.colMOTORGUCU.VisibleIndex = 28;
      this.colMOTORGUCU.Width = 117;
      this.colBEYGIRGUCU.Caption = "Beygir Gücü";
      this.colBEYGIRGUCU.FieldName = "BEYGIRGUCU";
      this.colBEYGIRGUCU.Name = "colBEYGIRGUCU";
      this.colBEYGIRGUCU.OptionsColumn.AllowEdit = false;
      this.colBEYGIRGUCU.OptionsColumn.ReadOnly = true;
      this.colBEYGIRGUCU.Visible = true;
      this.colBEYGIRGUCU.VisibleIndex = 29;
      this.colBEYGIRGUCU.Width = 126;
      this.colTEKERLEKADEDI.FieldName = "TEKERLEKADEDI";
      this.colTEKERLEKADEDI.Name = "colTEKERLEKADEDI";
      this.colTEKERLEKADEDI.OptionsColumn.AllowEdit = false;
      this.colTEKERLEKADEDI.OptionsColumn.ReadOnly = true;
      this.colYURUYENAKSAMI.FieldName = "YURUYENAKSAMI";
      this.colYURUYENAKSAMI.Name = "colYURUYENAKSAMI";
      this.colYURUYENAKSAMI.OptionsColumn.AllowEdit = false;
      this.colYURUYENAKSAMI.OptionsColumn.ReadOnly = true;
      this.colLASTIKEBADI.FieldName = "LASTIKEBADI";
      this.colLASTIKEBADI.Name = "colLASTIKEBADI";
      this.colLASTIKEBADI.OptionsColumn.AllowEdit = false;
      this.colLASTIKEBADI.OptionsColumn.ReadOnly = true;
      this.colDIGEROZELLIKLER.FieldName = "DIGEROZELLIKLER";
      this.colDIGEROZELLIKLER.Name = "colDIGEROZELLIKLER";
      this.colDIGEROZELLIKLER.OptionsColumn.AllowEdit = false;
      this.colDIGEROZELLIKLER.OptionsColumn.ReadOnly = true;
      this.colMUAYENEGECSUR.Caption = "Muayene Tarihi";
      this.colMUAYENEGECSUR.DisplayFormat.FormatString = "d";
      this.colMUAYENEGECSUR.DisplayFormat.FormatType = FormatType.DateTime;
      this.colMUAYENEGECSUR.FieldName = "MUAYENEGECSUR";
      this.colMUAYENEGECSUR.Name = "colMUAYENEGECSUR";
      this.colMUAYENEGECSUR.OptionsColumn.AllowEdit = false;
      this.colMUAYENEGECSUR.OptionsColumn.ReadOnly = true;
      this.colMUAYENEGECSUR.Visible = true;
      this.colMUAYENEGECSUR.VisibleIndex = 30;
      this.colMUAYENEGECSUR.Width = 142;
      this.colTRAFIKSGORTA2.Caption = "Trafik Sigorta";
      this.colTRAFIKSGORTA2.FieldName = "TRAFIKSGORTA2";
      this.colTRAFIKSGORTA2.Name = "colTRAFIKSGORTA2";
      this.colTRAFIKSGORTA2.Visible = true;
      this.colTRAFIKSGORTA2.VisibleIndex = 27;
      this.colTRAFIKSGORTA.Caption = "Trafik Sigorta";
      this.colTRAFIKSGORTA.DisplayFormat.FormatString = "d";
      this.colTRAFIKSGORTA.DisplayFormat.FormatType = FormatType.DateTime;
      this.colTRAFIKSGORTA.FieldName = "TRAFIKSGORTA";
      this.colTRAFIKSGORTA.Name = "colTRAFIKSGORTA";
      this.colTRAFIKSGORTA.OptionsColumn.AllowEdit = false;
      this.colTRAFIKSGORTA.OptionsColumn.ReadOnly = true;
      this.colTRAFIKSGORTA.Width = 116;
      this.colKASKO.Caption = "Kasko";
      this.colKASKO.DisplayFormat.FormatString = "d";
      this.colKASKO.DisplayFormat.FormatType = FormatType.DateTime;
      this.colKASKO.FieldName = "KASKO";
      this.colKASKO.Name = "colKASKO";
      this.colKASKO.OptionsColumn.AllowEdit = false;
      this.colKASKO.OptionsColumn.ReadOnly = true;
      this.colKASKO.Visible = true;
      this.colKASKO.VisibleIndex = 31;
      this.colKASKO.Width = 99;
      this.colBELGESERINO.Caption = "Belge Seri No";
      this.colBELGESERINO.FieldName = "BELGESERINO";
      this.colBELGESERINO.Name = "colBELGESERINO";
      this.colBELGESERINO.OptionsColumn.AllowEdit = false;
      this.colBELGESERINO.OptionsColumn.ReadOnly = true;
      this.colBELGESERINO.Visible = true;
      this.colBELGESERINO.VisibleIndex = 32;
      this.colBELGESERINO.Width = 130;
      this.colARACFIRMAID.Caption = "Araç Firma";
      this.colARACFIRMAID.FieldName = "ARACFIRMAID";
      this.colARACFIRMAID.Name = "colARACFIRMAID";
      this.colARACFIRMAID.OptionsColumn.AllowEdit = false;
      this.colARACFIRMAID.OptionsColumn.ReadOnly = true;
      this.colARACFIRMAID.Visible = true;
      this.colARACFIRMAID.VisibleIndex = 7;
      this.colARACFIRMAID.Width = 125;
      this.colBELDBIRIMID.Caption = "Belediye Birim";
      this.colBELDBIRIMID.FieldName = "BELDBIRIMID";
      this.colBELDBIRIMID.Name = "colBELDBIRIMID";
      this.colBELDBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBELDBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBELDBIRIMID.Visible = true;
      this.colBELDBIRIMID.VisibleIndex = 8;
      this.colBELDBIRIMID.Width = 140;
      this.colBELDMUDURLUKID.Caption = "Belediye Müdürlük";
      this.colBELDMUDURLUKID.FieldName = "BELDMUDURLUKID";
      this.colBELDMUDURLUKID.Name = "colBELDMUDURLUKID";
      this.colBELDMUDURLUKID.OptionsColumn.AllowEdit = false;
      this.colBELDMUDURLUKID.OptionsColumn.ReadOnly = true;
      this.colBELDMUDURLUKID.Visible = true;
      this.colBELDMUDURLUKID.VisibleIndex = 9;
      this.colBELDMUDURLUKID.Width = 125;
      this.colTAHSISEDILENID.FieldName = "TAHSISEDILENID";
      this.colTAHSISEDILENID.Name = "colTAHSISEDILENID";
      this.colTAHSISEDILENID.OptionsColumn.AllowEdit = false;
      this.colTAHSISEDILENID.OptionsColumn.ReadOnly = true;
      this.colARACKULPERSID.FieldName = "ARACKULPERSID";
      this.colARACKULPERSID.Name = "colARACKULPERSID";
      this.colARACKULPERSID.OptionsColumn.AllowEdit = false;
      this.colARACKULPERSID.OptionsColumn.ReadOnly = true;
      this.colARACGRUBUID.Caption = "Ana Grup";
      this.colARACGRUBUID.FieldName = "ARACGRUBUID";
      this.colARACGRUBUID.Name = "colARACGRUBUID";
      this.colARACGRUBUID.OptionsColumn.AllowEdit = false;
      this.colARACGRUBUID.OptionsColumn.ReadOnly = true;
      this.colARACGRUBUID.Visible = true;
      this.colARACGRUBUID.VisibleIndex = 5;
      this.colARACGRUBUID.Width = 150;
      this.colARACGRUBU2ID.Caption = "Alt Grup";
      this.colARACGRUBU2ID.FieldName = "ARACGRUBU2ID";
      this.colARACGRUBU2ID.Name = "colARACGRUBU2ID";
      this.colARACGRUBU2ID.OptionsColumn.AllowEdit = false;
      this.colARACGRUBU2ID.OptionsColumn.ReadOnly = true;
      this.colARACGRUBU2ID.Visible = true;
      this.colARACGRUBU2ID.VisibleIndex = 6;
      this.colARACGRUBU2ID.Width = 145;
      this.colYAKITID.FieldName = "YAKITID";
      this.colYAKITID.Name = "colYAKITID";
      this.colYAKITID.OptionsColumn.AllowEdit = false;
      this.colYAKITID.OptionsColumn.ReadOnly = true;
      this.colYKTYAKMATURU.FieldName = "YKTYAKMATURU";
      this.colYKTYAKMATURU.Name = "colYKTYAKMATURU";
      this.colYKTYAKMATURU.OptionsColumn.AllowEdit = false;
      this.colYKTYAKMATURU.OptionsColumn.ReadOnly = true;
      this.colSTDYKYAKIT.FieldName = "STDYKYAKIT";
      this.colSTDYKYAKIT.Name = "colSTDYKYAKIT";
      this.colSTDYKYAKIT.OptionsColumn.AllowEdit = false;
      this.colSTDYKYAKIT.OptionsColumn.ReadOnly = true;
      this.colARACDURUMID.Caption = "Araç Durumu";
      this.colARACDURUMID.FieldName = "ARACDURUMID";
      this.colARACDURUMID.Name = "colARACDURUMID";
      this.colARACDURUMID.OptionsColumn.AllowEdit = false;
      this.colARACDURUMID.OptionsColumn.ReadOnly = true;
      this.colARACDURUMID.Visible = true;
      this.colARACDURUMID.VisibleIndex = 4;
      this.colARACDURUMID.Width = 151;
      this.colARACTIPIID.Caption = "Araç Tipi";
      this.colARACTIPIID.FieldName = "ARACTIPIID";
      this.colARACTIPIID.Name = "colARACTIPIID";
      this.colARACTIPIID.OptionsColumn.AllowEdit = false;
      this.colARACTIPIID.OptionsColumn.ReadOnly = true;
      this.colARACTIPIID.Visible = true;
      this.colARACTIPIID.VisibleIndex = 3;
      this.colARACTIPIID.Width = 123;
      this.colTKPVARYOK.FieldName = "TKPVARYOK";
      this.colTKPVARYOK.Name = "colTKPVARYOK";
      this.colTKPVARYOK.OptionsColumn.AllowEdit = false;
      this.colTKPVARYOK.OptionsColumn.ReadOnly = true;
      this.colYEDEKANAHTAR.Caption = "Yedek Anahtar";
      this.colYEDEKANAHTAR.FieldName = "YEDEKANAHTAR";
      this.colYEDEKANAHTAR.Name = "colYEDEKANAHTAR";
      this.colYEDEKANAHTAR.OptionsColumn.AllowEdit = false;
      this.colYEDEKANAHTAR.OptionsColumn.ReadOnly = true;
      this.colYEDEKANAHTAR.Visible = true;
      this.colYEDEKANAHTAR.VisibleIndex = 33;
      this.colYEDEKANAHTAR.Width = 139;
      this.colYEDEKANHTRACKLM.Caption = "Yedek Anahtar Açıklama";
      this.colYEDEKANHTRACKLM.FieldName = "YEDEKANHTRACKLM";
      this.colYEDEKANHTRACKLM.Name = "colYEDEKANHTRACKLM";
      this.colYEDEKANHTRACKLM.OptionsColumn.AllowEdit = false;
      this.colYEDEKANHTRACKLM.OptionsColumn.ReadOnly = true;
      this.colYEDEKANHTRACKLM.Visible = true;
      this.colYEDEKANHTRACKLM.VisibleIndex = 34;
      this.colYEDEKANHTRACKLM.Width = 168;
      this.colGOREVBITIMTARIH.FieldName = "GOREVBITIMTARIH";
      this.colGOREVBITIMTARIH.Name = "colGOREVBITIMTARIH";
      this.colGOREVBITIMTARIH.OptionsColumn.AllowEdit = false;
      this.colGOREVBITIMTARIH.OptionsColumn.ReadOnly = true;
      this.colGOREVDURUM.FieldName = "GOREVDURUM";
      this.colGOREVDURUM.Name = "colGOREVDURUM";
      this.colGOREVDURUM.OptionsColumn.AllowEdit = false;
      this.colGOREVDURUM.OptionsColumn.ReadOnly = true;
      this.colILGILINOT.Caption = "İlgili Not";
      this.colILGILINOT.FieldName = "ILGILINOT";
      this.colILGILINOT.Name = "colILGILINOT";
      this.colILGILINOT.OptionsColumn.AllowEdit = false;
      this.colILGILINOT.OptionsColumn.ReadOnly = true;
      this.colILGILINOT.Visible = true;
      this.colILGILINOT.VisibleIndex = 40;
      this.colSAVEUSER.FieldName = "SAVEUSER";
      this.colSAVEUSER.Name = "colSAVEUSER";
      this.colSAVEUSER.OptionsColumn.AllowEdit = false;
      this.colSAVEUSER.OptionsColumn.ReadOnly = true;
      this.colSAVEDATE.FieldName = "SAVEDATE";
      this.colSAVEDATE.Name = "colSAVEDATE";
      this.colSAVEDATE.OptionsColumn.AllowEdit = false;
      this.colSAVEDATE.OptionsColumn.ReadOnly = true;
      this.colEDITUSER.FieldName = "EDITUSER";
      this.colEDITUSER.Name = "colEDITUSER";
      this.colEDITUSER.OptionsColumn.AllowEdit = false;
      this.colEDITUSER.OptionsColumn.ReadOnly = true;
      this.colEDITDATE.FieldName = "EDITDATE";
      this.colEDITDATE.Name = "colEDITDATE";
      this.colEDITDATE.OptionsColumn.AllowEdit = false;
      this.colEDITDATE.OptionsColumn.ReadOnly = true;
      this.colSAVEMAC.FieldName = "SAVEMAC";
      this.colSAVEMAC.Name = "colSAVEMAC";
      this.colSAVEMAC.OptionsColumn.AllowEdit = false;
      this.colSAVEMAC.OptionsColumn.ReadOnly = true;
      this.colEDITMAC.FieldName = "EDITMAC";
      this.colEDITMAC.Name = "colEDITMAC";
      this.colEDITMAC.OptionsColumn.AllowEdit = false;
      this.colEDITMAC.OptionsColumn.ReadOnly = true;
      this.colSAVEIP.FieldName = "SAVEIP";
      this.colSAVEIP.Name = "colSAVEIP";
      this.colSAVEIP.OptionsColumn.AllowEdit = false;
      this.colSAVEIP.OptionsColumn.ReadOnly = true;
      this.colEDITIP.FieldName = "EDITIP";
      this.colEDITIP.Name = "colEDITIP";
      this.colEDITIP.OptionsColumn.AllowEdit = false;
      this.colEDITIP.OptionsColumn.ReadOnly = true;
      this.colARACRESIM1.FieldName = "ARACRESIM1";
      this.colARACRESIM1.Name = "colARACRESIM1";
      this.colARACRESIM1.OptionsColumn.AllowEdit = false;
      this.colARACRESIM1.OptionsColumn.ReadOnly = true;
      this.colARACRESIM2.FieldName = "ARACRESIM2";
      this.colARACRESIM2.Name = "colARACRESIM2";
      this.colARACRESIM2.OptionsColumn.AllowEdit = false;
      this.colARACRESIM2.OptionsColumn.ReadOnly = true;
      this.colTAKIPVARYOKID.Caption = "Araç Takip";
      this.colTAKIPVARYOKID.FieldName = "TAKIPVARYOKID";
      this.colTAKIPVARYOKID.Name = "colTAKIPVARYOKID";
      this.colTAKIPVARYOKID.OptionsColumn.AllowEdit = false;
      this.colTAKIPVARYOKID.OptionsColumn.ReadOnly = true;
      this.colTAKIPVARYOKID.Width = 148;
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.OptionsColumn.AllowEdit = false;
      this.colSIRANO.OptionsColumn.ReadOnly = true;
      this.colGUNCELDEGERI.Caption = "Güncel Değer";
      this.colGUNCELDEGERI.FieldName = "GUNCELDEGERI";
      this.colGUNCELDEGERI.Name = "colGUNCELDEGERI";
      this.colGUNCELDEGERI.OptionsColumn.AllowEdit = false;
      this.colGUNCELDEGERI.OptionsColumn.ReadOnly = true;
      this.colGUNCELDEGERI.Visible = true;
      this.colGUNCELDEGERI.VisibleIndex = 35;
      this.colGUNCELDEGERI.Width = 136;
      this.colYENIDEGERI.Caption = "Yeni Değer";
      this.colYENIDEGERI.FieldName = "YENIDEGERI";
      this.colYENIDEGERI.Name = "colYENIDEGERI";
      this.colYENIDEGERI.OptionsColumn.AllowEdit = false;
      this.colYENIDEGERI.OptionsColumn.ReadOnly = true;
      this.colYENIDEGERI.Visible = true;
      this.colYENIDEGERI.VisibleIndex = 36;
      this.colYENIDEGERI.Width = 140;
      this.colPARABIRIMI.Caption = "Para Birimi";
      this.colPARABIRIMI.FieldName = "PARABIRIMI";
      this.colPARABIRIMI.Name = "colPARABIRIMI";
      this.colPARABIRIMI.OptionsColumn.AllowEdit = false;
      this.colPARABIRIMI.OptionsColumn.ReadOnly = true;
      this.colPARABIRIMI.Visible = true;
      this.colPARABIRIMI.VisibleIndex = 37;
      this.colPARABIRIMI.Width = 131;
      this.colGENELBAKIMKM.FieldName = "GENELBAKIMKM";
      this.colGENELBAKIMKM.Name = "colGENELBAKIMKM";
      this.colGENELBAKIMKM.OptionsColumn.AllowEdit = false;
      this.colGENELBAKIMKM.OptionsColumn.ReadOnly = true;
      this.colMOTORYAGKM.FieldName = "MOTORYAGKM";
      this.colMOTORYAGKM.Name = "colMOTORYAGKM";
      this.colMOTORYAGKM.OptionsColumn.AllowEdit = false;
      this.colMOTORYAGKM.OptionsColumn.ReadOnly = true;
      this.colSANZIMANYAGKM.FieldName = "SANZIMANYAGKM";
      this.colSANZIMANYAGKM.Name = "colSANZIMANYAGKM";
      this.colSANZIMANYAGKM.OptionsColumn.AllowEdit = false;
      this.colSANZIMANYAGKM.OptionsColumn.ReadOnly = true;
      this.colDIFERANSIYELYAGKM.FieldName = "DIFERANSIYELYAGKM";
      this.colDIFERANSIYELYAGKM.Name = "colDIFERANSIYELYAGKM";
      this.colDIFERANSIYELYAGKM.OptionsColumn.AllowEdit = false;
      this.colDIFERANSIYELYAGKM.OptionsColumn.ReadOnly = true;
      this.colHIDROLIKYAGKM.FieldName = "HIDROLIKYAGKM";
      this.colHIDROLIKYAGKM.Name = "colHIDROLIKYAGKM";
      this.colHIDROLIKYAGKM.OptionsColumn.AllowEdit = false;
      this.colHIDROLIKYAGKM.OptionsColumn.ReadOnly = true;
      this.colRESIMON.Caption = "Ön Resim";
      this.colRESIMON.FieldName = "RESIMON";
      this.colRESIMON.ImageOptions.Alignment = StringAlignment.Center;
      this.colRESIMON.Name = "colRESIMON";
      this.colRESIMON.OptionsColumn.AllowEdit = false;
      this.colRESIMON.OptionsColumn.ReadOnly = true;
      this.colRESIMON.Visible = true;
      this.colRESIMON.VisibleIndex = 0;
      this.colRESIMON.Width = 94;
      this.colRESIMARKA.Caption = "Arka Resim";
      this.colRESIMARKA.FieldName = "RESIMARKA";
      this.colRESIMARKA.Name = "colRESIMARKA";
      this.colRESIMARKA.OptionsColumn.AllowEdit = false;
      this.colRESIMARKA.OptionsColumn.ReadOnly = true;
      this.colRESIMARKA.Visible = true;
      this.colRESIMARKA.VisibleIndex = 1;
      this.colRESIMARKA.Width = 95;
      this.colYENIDEGERTARIH.Caption = "Yeni Değer";
      this.colYENIDEGERTARIH.DisplayFormat.FormatString = "d";
      this.colYENIDEGERTARIH.DisplayFormat.FormatType = FormatType.DateTime;
      this.colYENIDEGERTARIH.FieldName = "YENIDEGERTARIH";
      this.colYENIDEGERTARIH.Name = "colYENIDEGERTARIH";
      this.colYENIDEGERTARIH.OptionsColumn.AllowEdit = false;
      this.colYENIDEGERTARIH.OptionsColumn.ReadOnly = true;
      this.colYENIDEGERTARIH.Visible = true;
      this.colYENIDEGERTARIH.VisibleIndex = 38;
      this.colYENIDEGERTARIH.Width = 153;
      this.colHGSVARYOK.FieldName = "HGSVARYOK";
      this.colHGSVARYOK.Name = "colHGSVARYOK";
      this.colHGSVARYOK.OptionsColumn.AllowEdit = false;
      this.colHGSVARYOK.OptionsColumn.ReadOnly = true;
      this.colHGSVARYOK.Width = 120;
      this.colEGZOZKONTROL.Caption = "Egzoz Kontrol";
      this.colEGZOZKONTROL.DisplayFormat.FormatString = "d";
      this.colEGZOZKONTROL.DisplayFormat.FormatType = FormatType.DateTime;
      this.colEGZOZKONTROL.FieldName = "EGZOZKONTROL";
      this.colEGZOZKONTROL.Name = "colEGZOZKONTROL";
      this.colEGZOZKONTROL.OptionsColumn.AllowEdit = false;
      this.colEGZOZKONTROL.OptionsColumn.ReadOnly = true;
      this.colEGZOZKONTROL.Visible = true;
      this.colEGZOZKONTROL.VisibleIndex = 39;
      this.colEGZOZKONTROL.Width = 124;
      this.barCheckItem7.Caption = "Aktif";
      this.barCheckItem7.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem7.Id = 23;
      this.barCheckItem7.Name = "barCheckItem7";
      this.barCheckItem7.CheckedChanged += new ItemClickEventHandler(this.barCheckItem7_CheckedChanged);
      this.barCheckItem9.Caption = "Görevli Gelen";
      this.barCheckItem9.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem9.Id = 25;
      this.barCheckItem9.Name = "barCheckItem9";
      this.barCheckItem9.CheckedChanged += new ItemClickEventHandler(this.barCheckItem9_CheckedChanged);
      this.barCheckItem10.Caption = "Görevli Giden";
      this.barCheckItem10.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem10.Id = 26;
      this.barCheckItem10.Name = "barCheckItem10";
      this.barCheckItem10.CheckedChanged += new ItemClickEventHandler(this.barCheckItem10_CheckedChanged);
      this.barCheckItem11.Caption = "Hurda";
      this.barCheckItem11.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem11.Id = 27;
      this.barCheckItem11.Name = "barCheckItem11";
      this.barCheckItem11.CheckedChanged += new ItemClickEventHandler(this.barCheckItem11_CheckedChanged);
      this.barCheckItem12.Caption = "İş Görmez";
      this.barCheckItem12.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem12.Id = 28;
      this.barCheckItem12.Name = "barCheckItem12";
      this.barCheckItem12.CheckedChanged += new ItemClickEventHandler(this.barCheckItem12_CheckedChanged);
      this.barCheckItem13.Caption = "Çalıntı";
      this.barCheckItem13.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem13.Id = 29;
      this.barCheckItem13.Name = "barCheckItem13";
      this.barCheckItem13.CheckedChanged += new ItemClickEventHandler(this.barCheckItem13_CheckedChanged);
      this.barCheckItem8.Caption = "Pasif Kiralık";
      this.barCheckItem8.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem8.Id = 30;
      this.barCheckItem8.Name = "barCheckItem8";
      this.barCheckItem8.CheckedChanged += new ItemClickEventHandler(this.barCheckItem8_CheckedChanged_1);
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 31;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Caption = "Zimmet";
      this.barButtonItem9.Id = 32;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem10.Caption = "Yazdır";
      this.barButtonItem10.Id = 33;
      this.barButtonItem10.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.Image");
      this.barButtonItem10.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem10.ImageOptions.LargeImage");
      this.barButtonItem10.LargeWidth = 100;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem11.Caption = "Zimmet";
      this.barButtonItem11.Id = 34;
      this.barButtonItem11.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.Image");
      this.barButtonItem11.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.LargeImage");
      this.barButtonItem11.LargeWidth = 100;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barButtonItem12.ActAsDropDown = true;
      this.barButtonItem12.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem12.Caption = "Yazdır";
      this.barButtonItem12.DropDownControl = (PopupControl) this.popupMenu1;
      this.barButtonItem12.Id = 35;
      this.barButtonItem12.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.Image");
      this.barButtonItem12.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.LargeImage");
      this.barButtonItem12.LargeWidth = 100;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem12.ItemClick += new ItemClickEventHandler(this.barButtonItem12_ItemClick);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem14);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem15);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem16);
      this.popupMenu1.ItemLinks.Add((BarItem) this.barButtonItem19);
      this.popupMenu1.ItemLinks.Add((BarItem) this.Kira);
      this.popupMenu1.ItemLinks.Add((BarItem) this.basanlıgaGore);
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.barButtonItem14.Caption = "Araç Park İcmali";
      this.barButtonItem14.Id = 38;
      this.barButtonItem14.Name = "barButtonItem14";
      this.barButtonItem14.ItemClick += new ItemClickEventHandler(this.barButtonItem14_ItemClick);
      this.barButtonItem15.Caption = "Özet Raporu";
      this.barButtonItem15.Id = 39;
      this.barButtonItem15.Name = "barButtonItem15";
      this.barButtonItem15.ItemClick += new ItemClickEventHandler(this.barButtonItem15_ItemClick);
      this.barButtonItem16.Caption = "Araç İcmali özeti";
      this.barButtonItem16.Id = 40;
      this.barButtonItem16.Name = "barButtonItem16";
      this.barButtonItem16.ItemClick += new ItemClickEventHandler(this.barButtonItem16_ItemClick);
      this.barButtonItem19.Caption = "Araç Cinsine Göre Yazdır";
      this.barButtonItem19.Id = 44;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.Kira.Caption = "Kiralık Listesi";
      this.Kira.Id = 48;
      this.Kira.Name = "Kira";
      this.basanlıgaGore.Caption = "Başkanlığına Göre Yazdır";
      this.basanlıgaGore.Id = 51;
      this.basanlıgaGore.Name = "basanlıgaGore";
      this.barCheckItem14.Caption = "HGS Durum";
      this.barCheckItem14.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem14.Id = 36;
      this.barCheckItem14.Name = "barCheckItem14";
      this.barCheckItem14.CheckedChanged += new ItemClickEventHandler(this.barCheckItem14_CheckedChanged);
      this.barButtonItem13.Caption = "Excell";
      this.barButtonItem13.Id = 37;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
      this.barButtonItem17.Caption = "Resim Sil";
      this.barButtonItem17.Id = 42;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.ItemClick += new ItemClickEventHandler(this.barButtonItem17_ItemClick);
      this.barButtonItem18.Id = 49;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem20.Id = 52;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem21.Id = 50;
      this.barButtonItem21.Name = "barButtonItem21";
      this.barButtonItem22.Caption = "barButtonItem22";
      this.barButtonItem22.Id = 47;
      this.barButtonItem22.Name = "barButtonItem22";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup3,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup6
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem13);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem17);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem5);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barCheckItem1);
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barCheckItem4);
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barCheckItem6);
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barCheckItem5);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem7);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem9);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem10);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem11);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem12);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem13);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barCheckItem8);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup6.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem11);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem12);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.barEditItem3.Caption = "Kayıt Bul..";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 100;
      this.barEditItem3.Id = 13;
      this.barEditItem3.Name = "barEditItem3";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1455, 718);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (AracListesi);
      this.Text = "Araç Listesi";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form6_Load);
      this.repositoryItemCheckEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.popupMenu1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
