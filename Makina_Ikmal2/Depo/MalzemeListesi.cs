// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Depo.MalzemeListesi
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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Depo
{
  public class MalzemeListesi : XtraForm
  {
    private bellEntities db = new bellEntities();
    private string secme = "";
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
    private RibbonPageGroup ribbonPageGroup4;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
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
    private BarButtonItem barButtonItem17;
    private BarButtonItem barButtonItem18;
    private BarButtonItem barButtonItem19;
    private BarButtonItem barButtonItem20;
    private GridControl gridControl1;
    private GridView gridView1;
    private RepositoryItemLookUpEdit birim;
    private RepositoryItemLookUpEdit grup2;
    private RepositoryItemLookUpEdit bolum;
    private RepositoryItemLookUpEdit arizanedeni;
    private RepositoryItemLookUpEdit kdv;
    private RepositoryItemLookUpEdit grub1;
    private RepositoryItemLookUpEdit bakimturu;
    private RepositoryItemLookUpEdit bakimderece;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
    private RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit2;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLMALZEMELERBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private GridColumn colID;
    private GridColumn colKOD;
    private GridColumn colUFKOD;
    private GridColumn colOEMKOD;
    private GridColumn colMALZEMEADI;
    private GridColumn colDIGERADI;
    private GridColumn colKULLANIMYERI;
    private GridColumn colBIRIMID;
    private GridColumn colGRUPID;
    private GridColumn colGRUPID2;
    private GridColumn colKDVID;
    private GridColumn colBOLUMID;
    private GridColumn colRAFNO;
    private GridColumn colGOZNO;
    private GridColumn colBARKOD;
    private GridColumn colTARIHKONTROL;
    private GridColumn colSERINOKONTROL;
    private GridColumn colKMKONTROL;
    private GridColumn colMALZEMEFOTO;
    private GridColumn colKAYITTIPIID;
    private GridColumn colGIRIS;
    private GridColumn colCIKIS;
    private GridColumn colKALAN;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLMALZGRUPBindingSource;
    private TBLMALZGRUPTableAdapter tBLMALZGRUPTableAdapter;
    private BindingSource tBLMALZGRUP2BindingSource;
    private TBLMALZGRUP2TableAdapter tBLMALZGRUP2TableAdapter;
    private BindingSource tBLMALZKDVBindingSource;
    private TBLMALZKDVTableAdapter tBLMALZKDVTableAdapter;
    private BindingSource tBLMALZBOLUMBindingSource;
    private TBLMALZBOLUMTableAdapter tBLMALZBOLUMTableAdapter;

    public MalzemeListesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLMALZBOLUMTableAdapter.Fill(this.bellDataSet5.TBLMALZBOLUM);
      this.tBLMALZKDVTableAdapter.Fill(this.bellDataSet5.TBLMALZKDV);
      this.tBLMALZGRUP2TableAdapter.Fill(this.bellDataSet5.TBLMALZGRUP2);
      this.tBLMALZGRUPTableAdapter.Fill(this.bellDataSet5.TBLMALZGRUP);
      this.tBLMALZBIRIMTableAdapter.Fill(this.bellDataSet5.TBLMALZBIRIM);
      this.tBLMALZEMELERTableAdapter.Fill(this.bellDataSet5.TBLMALZEMELER);
      this.listele();
      this.sayfa();
      MalzemeDegerAktarma.list = (BindingList<ElemanlarDurum1>) null;
    }

    public void listele()
    {
    }

    private void filtre()
    {
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) XtraMessageBox.Show("id:" + this.gridView1.GetFocusedRowCellValue("ID")?.ToString());
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
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "KALAN"));
      if (Convert.ToInt32(gridView.GetRowCellValue(e.RowHandle, "KALAN")) > 1)
        return;
      e.Appearance.BackColor = Color.Red;
    }

    private void gridControl1_DoubleClick_1(object sender, EventArgs e) => YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

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
    }

    private void sayfa()
    {
    }

    private void gridView1_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      try
      {
        Convert.ToDecimal(gridView.GetRowCellValue(e.RowHandle, "KALAN"));
        if (!(Convert.ToDecimal(gridView.GetRowCellValue(e.RowHandle, "KALAN")) <= 0M))
          return;
        e.Appearance.BackColor = Color.Red;
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_DoubleClick_2(object sender, EventArgs e)
    {
      MalzemeDegerAktarma.list.Add(new ElemanlarDurum1()
      {
        MALZEMEID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID")),
        MALZACIKLAMA = "",
        BIRIMID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("BIRIMID")),
        FIYAT = 0M,
        MIKTAR = 0M,
        TUTAR = 0M
      });
      if ((CikisFisEkle) Application.OpenForms["CikisFisEkle"] == null)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MalzemeListesi));
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
      this.gridControl1 = new GridControl();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colKOD = new GridColumn();
      this.colUFKOD = new GridColumn();
      this.colOEMKOD = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colDIGERADI = new GridColumn();
      this.colKULLANIMYERI = new GridColumn();
      this.colBIRIMID = new GridColumn();
      this.birim = new RepositoryItemLookUpEdit();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.colGRUPID = new GridColumn();
      this.grub1 = new RepositoryItemLookUpEdit();
      this.tBLMALZGRUPBindingSource = new BindingSource(this.components);
      this.colGRUPID2 = new GridColumn();
      this.grup2 = new RepositoryItemLookUpEdit();
      this.tBLMALZGRUP2BindingSource = new BindingSource(this.components);
      this.colKDVID = new GridColumn();
      this.kdv = new RepositoryItemLookUpEdit();
      this.tBLMALZKDVBindingSource = new BindingSource(this.components);
      this.colBOLUMID = new GridColumn();
      this.bolum = new RepositoryItemLookUpEdit();
      this.tBLMALZBOLUMBindingSource = new BindingSource(this.components);
      this.colRAFNO = new GridColumn();
      this.colGOZNO = new GridColumn();
      this.colBARKOD = new GridColumn();
      this.colTARIHKONTROL = new GridColumn();
      this.colSERINOKONTROL = new GridColumn();
      this.colKMKONTROL = new GridColumn();
      this.colMALZEMEFOTO = new GridColumn();
      this.colKAYITTIPIID = new GridColumn();
      this.colGIRIS = new GridColumn();
      this.colCIKIS = new GridColumn();
      this.colKALAN = new GridColumn();
      this.bakimderece = new RepositoryItemLookUpEdit();
      this.bakimturu = new RepositoryItemLookUpEdit();
      this.arizanedeni = new RepositoryItemLookUpEdit();
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
      this.barButtonItem18 = new BarButtonItem();
      this.barButtonItem19 = new BarButtonItem();
      this.barButtonItem20 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZGRUPTableAdapter = new TBLMALZGRUPTableAdapter();
      this.tBLMALZGRUP2TableAdapter = new TBLMALZGRUP2TableAdapter();
      this.tBLMALZKDVTableAdapter = new TBLMALZKDVTableAdapter();
      this.tBLMALZBOLUMTableAdapter = new TBLMALZBOLUMTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.birim.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      this.grub1.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).BeginInit();
      this.grup2.BeginInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).BeginInit();
      this.kdv.BeginInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).BeginInit();
      this.bolum.BeginInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).BeginInit();
      this.bakimderece.BeginInit();
      this.bakimturu.BeginInit();
      this.arizanedeni.BeginInit();
      this.repositoryItemTimeSpanEdit1.BeginInit();
      this.repositoryItemTimeSpanEdit2.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[29]
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
        (BarItem) this.barButtonItem20
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
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
      this.ribbonControl1.Size = new Size(1041, 96);
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
      this.aramaTxt.EditWidth = 140;
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
      this.gridControl1.DataSource = (object) this.tBLMALZEMELERBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 96);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[10]
      {
        (RepositoryItem) this.birim,
        (RepositoryItem) this.grub1,
        (RepositoryItem) this.grup2,
        (RepositoryItem) this.kdv,
        (RepositoryItem) this.bolum,
        (RepositoryItem) this.bakimderece,
        (RepositoryItem) this.bakimturu,
        (RepositoryItem) this.arizanedeni,
        (RepositoryItem) this.repositoryItemTimeSpanEdit1,
        (RepositoryItem) this.repositoryItemTimeSpanEdit2
      });
      this.gridControl1.Size = new Size(1041, 477);
      this.gridControl1.TabIndex = 6;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick_2);
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.tBLMALZEMELERBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.BackColor = Color.Gray;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 12f);
      this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.OddRow.BackColor = Color.Transparent;
      this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = Color.Transparent;
      this.gridView1.Appearance.Row.Font = new Font("Tahoma", 10.8f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.HeaderPanel.BackColor = Color.MediumSeaGreen;
      this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.gridView1.AppearancePrint.Row.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[23]
      {
        this.colID,
        this.colKOD,
        this.colUFKOD,
        this.colOEMKOD,
        this.colMALZEMEADI,
        this.colDIGERADI,
        this.colKULLANIMYERI,
        this.colBIRIMID,
        this.colGRUPID,
        this.colGRUPID2,
        this.colKDVID,
        this.colBOLUMID,
        this.colRAFNO,
        this.colGOZNO,
        this.colBARKOD,
        this.colTARIHKONTROL,
        this.colSERINOKONTROL,
        this.colKMKONTROL,
        this.colMALZEMEFOTO,
        this.colKAYITTIPIID,
        this.colGIRIS,
        this.colCIKIS,
        this.colKALAN
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle_1);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 19;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 70;
      this.colKOD.Caption = "Malzeme Kod";
      this.colKOD.FieldName = "KOD";
      this.colKOD.MinWidth = 19;
      this.colKOD.Name = "colKOD";
      this.colKOD.OptionsColumn.AllowEdit = false;
      this.colKOD.OptionsColumn.ReadOnly = true;
      this.colKOD.Visible = true;
      this.colKOD.VisibleIndex = 0;
      this.colKOD.Width = 70;
      this.colUFKOD.Caption = "Uf Kod";
      this.colUFKOD.FieldName = "UFKOD";
      this.colUFKOD.MinWidth = 19;
      this.colUFKOD.Name = "colUFKOD";
      this.colUFKOD.OptionsColumn.AllowEdit = false;
      this.colUFKOD.OptionsColumn.ReadOnly = true;
      this.colUFKOD.Width = 70;
      this.colOEMKOD.Caption = "Oem Kod";
      this.colOEMKOD.FieldName = "OEMKOD";
      this.colOEMKOD.MinWidth = 19;
      this.colOEMKOD.Name = "colOEMKOD";
      this.colOEMKOD.OptionsColumn.AllowEdit = false;
      this.colOEMKOD.OptionsColumn.ReadOnly = true;
      this.colOEMKOD.Width = 70;
      this.colMALZEMEADI.Caption = "Malzeme Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 19;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.OptionsColumn.AllowEdit = false;
      this.colMALZEMEADI.OptionsColumn.ReadOnly = true;
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 1;
      this.colMALZEMEADI.Width = 239;
      this.colDIGERADI.Caption = "Diğer Adı";
      this.colDIGERADI.FieldName = "DIGERADI";
      this.colDIGERADI.MinWidth = 19;
      this.colDIGERADI.Name = "colDIGERADI";
      this.colDIGERADI.OptionsColumn.AllowEdit = false;
      this.colDIGERADI.OptionsColumn.ReadOnly = true;
      this.colDIGERADI.Visible = true;
      this.colDIGERADI.VisibleIndex = 2;
      this.colDIGERADI.Width = 207;
      this.colKULLANIMYERI.Caption = "Kullanım Yeri";
      this.colKULLANIMYERI.FieldName = "KULLANIMYERI";
      this.colKULLANIMYERI.MinWidth = 19;
      this.colKULLANIMYERI.Name = "colKULLANIMYERI";
      this.colKULLANIMYERI.OptionsColumn.AllowEdit = false;
      this.colKULLANIMYERI.OptionsColumn.ReadOnly = true;
      this.colKULLANIMYERI.Visible = true;
      this.colKULLANIMYERI.VisibleIndex = 3;
      this.colKULLANIMYERI.Width = 249;
      this.colBIRIMID.Caption = "Birim";
      this.colBIRIMID.ColumnEdit = (RepositoryItem) this.birim;
      this.colBIRIMID.FieldName = "BIRIMID";
      this.colBIRIMID.MinWidth = 19;
      this.colBIRIMID.Name = "colBIRIMID";
      this.colBIRIMID.OptionsColumn.AllowEdit = false;
      this.colBIRIMID.OptionsColumn.ReadOnly = true;
      this.colBIRIMID.Visible = true;
      this.colBIRIMID.VisibleIndex = 7;
      this.colBIRIMID.Width = 70;
      this.birim.AutoHeight = false;
      this.birim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.birim.DataSource = (object) this.tBLMALZBIRIMBindingSource;
      this.birim.DisplayMember = "BIRIMADI";
      this.birim.Name = "birim";
      this.birim.NullText = "";
      this.birim.ValueMember = "ID";
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZBIRIMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colGRUPID.Caption = "Grup";
      this.colGRUPID.ColumnEdit = (RepositoryItem) this.grub1;
      this.colGRUPID.FieldName = "GRUPID";
      this.colGRUPID.MinWidth = 19;
      this.colGRUPID.Name = "colGRUPID";
      this.colGRUPID.OptionsColumn.AllowEdit = false;
      this.colGRUPID.OptionsColumn.ReadOnly = true;
      this.colGRUPID.Visible = true;
      this.colGRUPID.VisibleIndex = 8;
      this.colGRUPID.Width = 70;
      this.grub1.AutoHeight = false;
      this.grub1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grub1.DataSource = (object) this.tBLMALZGRUPBindingSource;
      this.grub1.DisplayMember = "MALZEMEGRUP";
      this.grub1.Name = "grub1";
      this.grub1.NullText = "";
      this.grub1.ValueMember = "ID";
      this.tBLMALZGRUPBindingSource.DataMember = "TBLMALZGRUP";
      this.tBLMALZGRUPBindingSource.DataSource = (object) this.bellDataSet5;
      this.colGRUPID2.Caption = "Grup2 ";
      this.colGRUPID2.ColumnEdit = (RepositoryItem) this.grup2;
      this.colGRUPID2.FieldName = "GRUPID2";
      this.colGRUPID2.MinWidth = 19;
      this.colGRUPID2.Name = "colGRUPID2";
      this.colGRUPID2.OptionsColumn.AllowEdit = false;
      this.colGRUPID2.OptionsColumn.ReadOnly = true;
      this.colGRUPID2.Visible = true;
      this.colGRUPID2.VisibleIndex = 9;
      this.colGRUPID2.Width = 70;
      this.grup2.AutoHeight = false;
      this.grup2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.grup2.DataSource = (object) this.tBLMALZGRUP2BindingSource;
      this.grup2.DisplayMember = "MALZEMEGRUP2";
      this.grup2.Name = "grup2";
      this.grup2.NullText = "";
      this.grup2.ValueMember = "ID";
      this.tBLMALZGRUP2BindingSource.DataMember = "TBLMALZGRUP2";
      this.tBLMALZGRUP2BindingSource.DataSource = (object) this.bellDataSet5;
      this.colKDVID.Caption = "Kdv";
      this.colKDVID.ColumnEdit = (RepositoryItem) this.kdv;
      this.colKDVID.FieldName = "KDVID";
      this.colKDVID.MinWidth = 19;
      this.colKDVID.Name = "colKDVID";
      this.colKDVID.OptionsColumn.AllowEdit = false;
      this.colKDVID.OptionsColumn.ReadOnly = true;
      this.colKDVID.Visible = true;
      this.colKDVID.VisibleIndex = 10;
      this.colKDVID.Width = 70;
      this.kdv.AutoHeight = false;
      this.kdv.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kdv.DataSource = (object) this.tBLMALZKDVBindingSource;
      this.kdv.DisplayMember = "KDVORAN";
      this.kdv.Name = "kdv";
      this.kdv.NullText = "";
      this.kdv.ValueMember = "ID";
      this.tBLMALZKDVBindingSource.DataMember = "TBLMALZKDV";
      this.tBLMALZKDVBindingSource.DataSource = (object) this.bellDataSet5;
      this.colBOLUMID.Caption = "Bölüm";
      this.colBOLUMID.ColumnEdit = (RepositoryItem) this.bolum;
      this.colBOLUMID.FieldName = "BOLUMID";
      this.colBOLUMID.MinWidth = 19;
      this.colBOLUMID.Name = "colBOLUMID";
      this.colBOLUMID.OptionsColumn.AllowEdit = false;
      this.colBOLUMID.OptionsColumn.ReadOnly = true;
      this.colBOLUMID.Visible = true;
      this.colBOLUMID.VisibleIndex = 11;
      this.colBOLUMID.Width = 70;
      this.bolum.AutoHeight = false;
      this.bolum.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bolum.DataSource = (object) this.tBLMALZBOLUMBindingSource;
      this.bolum.DisplayMember = "BOLUMADI";
      this.bolum.Name = "bolum";
      this.bolum.NullText = "";
      this.bolum.ValueMember = "ID";
      this.tBLMALZBOLUMBindingSource.DataMember = "TBLMALZBOLUM";
      this.tBLMALZBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.colRAFNO.Caption = "Raf No";
      this.colRAFNO.FieldName = "RAFNO";
      this.colRAFNO.MinWidth = 19;
      this.colRAFNO.Name = "colRAFNO";
      this.colRAFNO.OptionsColumn.AllowEdit = false;
      this.colRAFNO.OptionsColumn.ReadOnly = true;
      this.colRAFNO.Visible = true;
      this.colRAFNO.VisibleIndex = 12;
      this.colRAFNO.Width = 70;
      this.colGOZNO.Caption = "Göz No";
      this.colGOZNO.FieldName = "GOZNO";
      this.colGOZNO.MinWidth = 19;
      this.colGOZNO.Name = "colGOZNO";
      this.colGOZNO.OptionsColumn.AllowEdit = false;
      this.colGOZNO.OptionsColumn.ReadOnly = true;
      this.colGOZNO.Visible = true;
      this.colGOZNO.VisibleIndex = 13;
      this.colGOZNO.Width = 70;
      this.colBARKOD.Caption = "Barkod";
      this.colBARKOD.FieldName = "BARKOD";
      this.colBARKOD.MinWidth = 19;
      this.colBARKOD.Name = "colBARKOD";
      this.colBARKOD.OptionsColumn.AllowEdit = false;
      this.colBARKOD.OptionsColumn.ReadOnly = true;
      this.colBARKOD.Visible = true;
      this.colBARKOD.VisibleIndex = 14;
      this.colBARKOD.Width = 70;
      this.colTARIHKONTROL.Caption = "Tarih Kontrol";
      this.colTARIHKONTROL.FieldName = "TARIHKONTROL";
      this.colTARIHKONTROL.MinWidth = 19;
      this.colTARIHKONTROL.Name = "colTARIHKONTROL";
      this.colTARIHKONTROL.OptionsColumn.AllowEdit = false;
      this.colTARIHKONTROL.OptionsColumn.ReadOnly = true;
      this.colTARIHKONTROL.Visible = true;
      this.colTARIHKONTROL.VisibleIndex = 15;
      this.colTARIHKONTROL.Width = 70;
      this.colSERINOKONTROL.Caption = "Seri No Kontrol";
      this.colSERINOKONTROL.FieldName = "SERINOKONTROL";
      this.colSERINOKONTROL.MinWidth = 19;
      this.colSERINOKONTROL.Name = "colSERINOKONTROL";
      this.colSERINOKONTROL.OptionsColumn.AllowEdit = false;
      this.colSERINOKONTROL.OptionsColumn.ReadOnly = true;
      this.colSERINOKONTROL.Visible = true;
      this.colSERINOKONTROL.VisibleIndex = 16;
      this.colSERINOKONTROL.Width = 70;
      this.colKMKONTROL.Caption = "Km Kontrol";
      this.colKMKONTROL.FieldName = "KMKONTROL";
      this.colKMKONTROL.MinWidth = 19;
      this.colKMKONTROL.Name = "colKMKONTROL";
      this.colKMKONTROL.OptionsColumn.AllowEdit = false;
      this.colKMKONTROL.OptionsColumn.ReadOnly = true;
      this.colKMKONTROL.Visible = true;
      this.colKMKONTROL.VisibleIndex = 17;
      this.colKMKONTROL.Width = 70;
      this.colMALZEMEFOTO.Caption = "Malzeme Foto";
      this.colMALZEMEFOTO.FieldName = "MALZEMEFOTO";
      this.colMALZEMEFOTO.MinWidth = 19;
      this.colMALZEMEFOTO.Name = "colMALZEMEFOTO";
      this.colMALZEMEFOTO.OptionsColumn.AllowEdit = false;
      this.colMALZEMEFOTO.OptionsColumn.ReadOnly = true;
      this.colMALZEMEFOTO.Visible = true;
      this.colMALZEMEFOTO.VisibleIndex = 18;
      this.colMALZEMEFOTO.Width = 70;
      this.colKAYITTIPIID.Caption = "Kayit Tipi";
      this.colKAYITTIPIID.FieldName = "KAYITTIPIID";
      this.colKAYITTIPIID.MinWidth = 19;
      this.colKAYITTIPIID.Name = "colKAYITTIPIID";
      this.colKAYITTIPIID.OptionsColumn.AllowEdit = false;
      this.colKAYITTIPIID.OptionsColumn.ReadOnly = true;
      this.colKAYITTIPIID.Visible = true;
      this.colKAYITTIPIID.VisibleIndex = 19;
      this.colKAYITTIPIID.Width = 70;
      this.colGIRIS.Caption = "Giriş";
      this.colGIRIS.FieldName = "GIRIS";
      this.colGIRIS.MinWidth = 19;
      this.colGIRIS.Name = "colGIRIS";
      this.colGIRIS.OptionsColumn.AllowEdit = false;
      this.colGIRIS.OptionsColumn.ReadOnly = true;
      this.colGIRIS.Visible = true;
      this.colGIRIS.VisibleIndex = 4;
      this.colGIRIS.Width = 70;
      this.colCIKIS.Caption = "Çıkış";
      this.colCIKIS.FieldName = "CIKIS";
      this.colCIKIS.MinWidth = 19;
      this.colCIKIS.Name = "colCIKIS";
      this.colCIKIS.OptionsColumn.AllowEdit = false;
      this.colCIKIS.OptionsColumn.ReadOnly = true;
      this.colCIKIS.Visible = true;
      this.colCIKIS.VisibleIndex = 5;
      this.colCIKIS.Width = 70;
      this.colKALAN.Caption = "Kalan";
      this.colKALAN.FieldName = "KALAN";
      this.colKALAN.MinWidth = 19;
      this.colKALAN.Name = "colKALAN";
      this.colKALAN.OptionsColumn.AllowEdit = false;
      this.colKALAN.OptionsColumn.ReadOnly = true;
      this.colKALAN.Visible = true;
      this.colKALAN.VisibleIndex = 6;
      this.colKALAN.Width = 70;
      this.bakimderece.AutoHeight = false;
      this.bakimderece.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimderece.DisplayMember = "BAKIMDERECE";
      this.bakimderece.Name = "bakimderece";
      this.bakimderece.NullText = "";
      this.bakimderece.ValueMember = "ID";
      this.bakimturu.AutoHeight = false;
      this.bakimturu.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimturu.DisplayMember = "BAKIMTURU";
      this.bakimturu.Name = "bakimturu";
      this.bakimturu.NullText = "";
      this.bakimturu.ValueMember = "ID";
      this.arizanedeni.AutoHeight = false;
      this.arizanedeni.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizanedeni.DisplayMember = "ARIZANEDENI";
      this.arizanedeni.Name = "arizanedeni";
      this.arizanedeni.NullText = "";
      this.arizanedeni.ValueMember = "ID";
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
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) Resources.printdialog_16x16;
      this.barButtonItem17.ImageOptions.LargeImage = (Image) Resources.printdialog_32x32;
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem18.ItemClick += new ItemClickEventHandler(this.barButtonItem18_ItemClick);
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem19.ItemClick += new ItemClickEventHandler(this.barButtonItem19_ItemClick);
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.aramaTxt);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUPTableAdapter.ClearBeforeFill = true;
      this.tBLMALZGRUP2TableAdapter.ClearBeforeFill = true;
      this.tBLMALZKDVTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBOLUMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1041, 573);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderEffect = FormBorderEffect.None;
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (MalzemeListesi);
      this.Text = "Atölye Bölümü";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.birim.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      this.grub1.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUPBindingSource).EndInit();
      this.grup2.EndInit();
      ((ISupportInitialize) this.tBLMALZGRUP2BindingSource).EndInit();
      this.kdv.EndInit();
      ((ISupportInitialize) this.tBLMALZKDVBindingSource).EndInit();
      this.bolum.EndInit();
      ((ISupportInitialize) this.tBLMALZBOLUMBindingSource).EndInit();
      this.bakimderece.EndInit();
      this.bakimturu.EndInit();
      this.arizanedeni.EndInit();
      this.repositoryItemTimeSpanEdit1.EndInit();
      this.repositoryItemTimeSpanEdit2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
