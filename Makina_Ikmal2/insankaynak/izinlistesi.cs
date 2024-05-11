// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.izinlistesi
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
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.ModelYeni;
using Makina_Ikmal.ModelYeni.izinlistesiResimliTableAdapters;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class izinlistesi : Form
  {
    private bellEntities db = new bellEntities();
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
    private GridView gridView1;
    private GridControl gridControl1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELIZINBindingSource;
    private TBLPERSONELIZINTableAdapter tBLPERSONELIZINTableAdapter;
    private RepositoryItemLookUpEdit muduryerine;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private izinlistesiResimli izinlistesiResimli;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn colTCKIMLIKNO;
    private GridColumn colADISOYADI;
    private GridColumn colIZINTURU;
    private GridColumn colIZINYILLARI;
    private GridColumn colIZINSURESI;
    private GridColumn colBASLANGICTARIHI;
    private GridColumn colBITISTARIHI;
    private GridColumn colIZINGUNSAY;
    private GridColumn colGOREVEBASTARIH;
    private GridColumn colIZINDEBULADRES;
    private GridColumn colONAYTARIH;
    private GridColumn colIZINDURUM;
    private GridColumn colSBMUDURID;
    private GridColumn colDAIREBSKID;
    private GridColumn colINSANDAIREBSKID;
    private GridColumn colGENELSEKYRDID;
    private GridColumn colMUDURYERINE;
    private GridColumn colRESIMPER;
    private GridColumn colUNVAN;
    private GridColumn colADI;
    private GridColumn colID;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;

    public izinlistesi() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayıt";
      int num = (int) new PersoneIzin().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e) => this.listele();

    private void listele()
    {
      this.dataTable1TableAdapter.Fill(this.izinlistesiResimli.DataTable1);
      this.dataTable1TableAdapter.Fill(this.izinlistesiResimli.DataTable1);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLPERSONELIZINTableAdapter.Fill(this.bellDataSet2.TBLPERSONELIZIN);
    }

    public void tetikle()
    {
      this.tBLPERSONELIZINTableAdapter.Fill(this.bellDataSet2.TBLPERSONELIZIN);
      this.dataTable1TableAdapter.Fill(this.izinlistesiResimli.DataTable1);
      this.dataTable1TableAdapter.Fill(this.izinlistesiResimli.DataTable1);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new PersoneIzinDuzenleme().ShowDialog();
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      int num = (int) new PersoneIzinDuzenleme().ShowDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.SilYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.sil();
        ((izinlistesi) Application.OpenForms[nameof (izinlistesi)])?.tetikle();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Silme yetkiniz yok .Lütfen yöneticinizle irtibata geçiniz.");
      }
      LogEkle.Logs("Silme Yapti");
    }

    private void sil()
    {
      try
      {
        TBLPERSONELIZIN fir = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<System.Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
        IQueryable<TBLPERSIZINDURUM> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hf => hf.PERSONELIZINID == (int?) YetkiClass.secim_id)).Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hf => hf.PERSONELID == fir.PERSID));
        if (source.Count<TBLPERSIZINDURUM>() > 0)
        {
          foreach (TBLPERSIZINDURUM tblpersizindurum in (IEnumerable<TBLPERSIZINDURUM>) source)
          {
            TBLPERSIZINDURUM item = tblpersizindurum;
            this.db.TBLPERSIZINDURUM.Remove(this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == item.ID)));
          }
          this.db.TBLPERSONELIZIN.Remove(fir);
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayit İşlemi Başarlı bir şekilde gerçekleşti");
        }
        else
        {
          int num1 = (int) XtraMessageBox.Show("Silme işlemi gerçekleştirelmedi.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e) => this.listele();

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (izinlistesi));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.izinlistesiResimli = new izinlistesiResimli();
      this.gridView1 = new GridView();
      this.colTCKIMLIKNO = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colIZINTURU = new GridColumn();
      this.colIZINYILLARI = new GridColumn();
      this.colIZINSURESI = new GridColumn();
      this.colBASLANGICTARIHI = new GridColumn();
      this.colBITISTARIHI = new GridColumn();
      this.colIZINGUNSAY = new GridColumn();
      this.colGOREVEBASTARIH = new GridColumn();
      this.colIZINDEBULADRES = new GridColumn();
      this.colONAYTARIH = new GridColumn();
      this.colIZINDURUM = new GridColumn();
      this.colSBMUDURID = new GridColumn();
      this.muduryerine = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.colDAIREBSKID = new GridColumn();
      this.colINSANDAIREBSKID = new GridColumn();
      this.colGENELSEKYRDID = new GridColumn();
      this.colMUDURYERINE = new GridColumn();
      this.colRESIMPER = new GridColumn();
      this.colUNVAN = new GridColumn();
      this.colADI = new GridColumn();
      this.colID = new GridColumn();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.tBLPERSONELIZINBindingSource = new BindingSource(this.components);
      this.tBLPERSONELIZINTableAdapter = new TBLPERSONELIZINTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.izinlistesiResimli.BeginInit();
      this.gridView1.BeginInit();
      this.muduryerine.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELIZINBindingSource).BeginInit();
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
        (BarItem) this.barEditItem1
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 9;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 329;
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
      this.ribbonControl1.Size = new Size(1149, 122);
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
      this.barButtonItem4.Caption = "Excel";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) Resources.exporttoxls_16x16;
      this.barButtonItem4.ImageOptions.LargeImage = (Image) Resources.exporttoxls_32x32;
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
      this.barEditItem1.Id = 8;
      this.barEditItem1.Name = "barEditItem1";
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
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(0, 122);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.muduryerine
      });
      this.gridControl1.Size = new Size(1149, 583);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.izinlistesiResimli;
      this.izinlistesiResimli.DataSetName = "izinlistesiResimli";
      this.izinlistesiResimli.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[21]
      {
        this.colTCKIMLIKNO,
        this.colADISOYADI,
        this.colIZINTURU,
        this.colIZINYILLARI,
        this.colIZINSURESI,
        this.colBASLANGICTARIHI,
        this.colBITISTARIHI,
        this.colIZINGUNSAY,
        this.colGOREVEBASTARIH,
        this.colIZINDEBULADRES,
        this.colONAYTARIH,
        this.colIZINDURUM,
        this.colSBMUDURID,
        this.colDAIREBSKID,
        this.colINSANDAIREBSKID,
        this.colGENELSEKYRDID,
        this.colMUDURYERINE,
        this.colRESIMPER,
        this.colUNVAN,
        this.colADI,
        this.colID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.RowAutoHeight = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.RowHeight = 40;
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colTCKIMLIKNO.Caption = "T.C No";
      this.colTCKIMLIKNO.FieldName = "TCKIMLIKNO";
      this.colTCKIMLIKNO.MinWidth = 25;
      this.colTCKIMLIKNO.Name = "colTCKIMLIKNO";
      this.colTCKIMLIKNO.Visible = true;
      this.colTCKIMLIKNO.VisibleIndex = 1;
      this.colTCKIMLIKNO.Width = 149;
      this.colADISOYADI.Caption = "Adı Soyadı";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 25;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 2;
      this.colADISOYADI.Width = 199;
      this.colIZINTURU.Caption = "İzin Türü";
      this.colIZINTURU.FieldName = "IZINTURU";
      this.colIZINTURU.MinWidth = 25;
      this.colIZINTURU.Name = "colIZINTURU";
      this.colIZINTURU.Visible = true;
      this.colIZINTURU.VisibleIndex = 3;
      this.colIZINTURU.Width = 149;
      this.colIZINYILLARI.Caption = "İzin Yılları";
      this.colIZINYILLARI.FieldName = "IZINYILLARI";
      this.colIZINYILLARI.MinWidth = 25;
      this.colIZINYILLARI.Name = "colIZINYILLARI";
      this.colIZINYILLARI.Visible = true;
      this.colIZINYILLARI.VisibleIndex = 4;
      this.colIZINYILLARI.Width = 128;
      this.colIZINSURESI.Caption = "İzin Süresi";
      this.colIZINSURESI.FieldName = "IZINSURESI";
      this.colIZINSURESI.MinWidth = 25;
      this.colIZINSURESI.Name = "colIZINSURESI";
      this.colIZINSURESI.Visible = true;
      this.colIZINSURESI.VisibleIndex = 5;
      this.colIZINSURESI.Width = 94;
      this.colBASLANGICTARIHI.Caption = "Başlangıç Tarihi";
      this.colBASLANGICTARIHI.FieldName = "BASLANGICTARIHI";
      this.colBASLANGICTARIHI.MinWidth = 25;
      this.colBASLANGICTARIHI.Name = "colBASLANGICTARIHI";
      this.colBASLANGICTARIHI.Visible = true;
      this.colBASLANGICTARIHI.VisibleIndex = 6;
      this.colBASLANGICTARIHI.Width = 120;
      this.colBITISTARIHI.Caption = "Bitiş Tarihi";
      this.colBITISTARIHI.FieldName = "BITISTARIHI";
      this.colBITISTARIHI.MinWidth = 25;
      this.colBITISTARIHI.Name = "colBITISTARIHI";
      this.colBITISTARIHI.Visible = true;
      this.colBITISTARIHI.VisibleIndex = 7;
      this.colBITISTARIHI.Width = 94;
      this.colIZINGUNSAY.Caption = "İzin Gün Sayısı";
      this.colIZINGUNSAY.FieldName = "IZINGUNSAY";
      this.colIZINGUNSAY.MinWidth = 25;
      this.colIZINGUNSAY.Name = "colIZINGUNSAY";
      this.colIZINGUNSAY.Visible = true;
      this.colIZINGUNSAY.VisibleIndex = 8;
      this.colIZINGUNSAY.Width = 94;
      this.colGOREVEBASTARIH.Caption = "Göreve Başlama Tarihi";
      this.colGOREVEBASTARIH.FieldName = "GOREVEBASTARIH";
      this.colGOREVEBASTARIH.MinWidth = 25;
      this.colGOREVEBASTARIH.Name = "colGOREVEBASTARIH";
      this.colGOREVEBASTARIH.Visible = true;
      this.colGOREVEBASTARIH.VisibleIndex = 9;
      this.colGOREVEBASTARIH.Width = 94;
      this.colIZINDEBULADRES.Caption = "İzinde Bulunacağı Adres";
      this.colIZINDEBULADRES.FieldName = "IZINDEBULADRES";
      this.colIZINDEBULADRES.MinWidth = 25;
      this.colIZINDEBULADRES.Name = "colIZINDEBULADRES";
      this.colIZINDEBULADRES.Visible = true;
      this.colIZINDEBULADRES.VisibleIndex = 10;
      this.colIZINDEBULADRES.Width = 242;
      this.colONAYTARIH.Caption = "OnayTarihi";
      this.colONAYTARIH.FieldName = "ONAYTARIH";
      this.colONAYTARIH.MinWidth = 25;
      this.colONAYTARIH.Name = "colONAYTARIH";
      this.colONAYTARIH.Visible = true;
      this.colONAYTARIH.VisibleIndex = 11;
      this.colONAYTARIH.Width = 94;
      this.colIZINDURUM.Caption = "İzin Durumu";
      this.colIZINDURUM.FieldName = "IZINDURUM";
      this.colIZINDURUM.MinWidth = 25;
      this.colIZINDURUM.Name = "colIZINDURUM";
      this.colIZINDURUM.Visible = true;
      this.colIZINDURUM.VisibleIndex = 12;
      this.colIZINDURUM.Width = 94;
      this.colSBMUDURID.Caption = "Şube Müdürü";
      this.colSBMUDURID.ColumnEdit = (RepositoryItem) this.muduryerine;
      this.colSBMUDURID.FieldName = "SBMUDURID";
      this.colSBMUDURID.MinWidth = 25;
      this.colSBMUDURID.Name = "colSBMUDURID";
      this.colSBMUDURID.Visible = true;
      this.colSBMUDURID.VisibleIndex = 13;
      this.colSBMUDURID.Width = 200;
      this.muduryerine.AutoHeight = false;
      this.muduryerine.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.muduryerine.DataSource = (object) this.tBLPERSONELBindingSource;
      this.muduryerine.DisplayMember = "ADISOYADI";
      this.muduryerine.Name = "muduryerine";
      this.muduryerine.NullText = "";
      this.muduryerine.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.colDAIREBSKID.Caption = "Daire Başkanı";
      this.colDAIREBSKID.ColumnEdit = (RepositoryItem) this.muduryerine;
      this.colDAIREBSKID.FieldName = "DAIREBSKID";
      this.colDAIREBSKID.MinWidth = 25;
      this.colDAIREBSKID.Name = "colDAIREBSKID";
      this.colDAIREBSKID.Visible = true;
      this.colDAIREBSKID.VisibleIndex = 14;
      this.colDAIREBSKID.Width = 212;
      this.colINSANDAIREBSKID.Caption = "İnsan Kay. Daire Başkanı";
      this.colINSANDAIREBSKID.ColumnEdit = (RepositoryItem) this.muduryerine;
      this.colINSANDAIREBSKID.FieldName = "INSANDAIREBSKID";
      this.colINSANDAIREBSKID.MinWidth = 25;
      this.colINSANDAIREBSKID.Name = "colINSANDAIREBSKID";
      this.colINSANDAIREBSKID.Visible = true;
      this.colINSANDAIREBSKID.VisibleIndex = 15;
      this.colINSANDAIREBSKID.Width = 215;
      this.colGENELSEKYRDID.Caption = "Genel Sktr Yrdmcı";
      this.colGENELSEKYRDID.ColumnEdit = (RepositoryItem) this.muduryerine;
      this.colGENELSEKYRDID.FieldName = "GENELSEKYRDID";
      this.colGENELSEKYRDID.MinWidth = 25;
      this.colGENELSEKYRDID.Name = "colGENELSEKYRDID";
      this.colGENELSEKYRDID.Visible = true;
      this.colGENELSEKYRDID.VisibleIndex = 16;
      this.colGENELSEKYRDID.Width = 215;
      this.colMUDURYERINE.Caption = "Müdür Yerine Vakalet Eden";
      this.colMUDURYERINE.ColumnEdit = (RepositoryItem) this.muduryerine;
      this.colMUDURYERINE.FieldName = "MUDURYERINE";
      this.colMUDURYERINE.MinWidth = 25;
      this.colMUDURYERINE.Name = "colMUDURYERINE";
      this.colMUDURYERINE.Visible = true;
      this.colMUDURYERINE.VisibleIndex = 17;
      this.colMUDURYERINE.Width = 220;
      this.colRESIMPER.Caption = "Resim";
      this.colRESIMPER.FieldName = "RESIMPER";
      this.colRESIMPER.MinWidth = 25;
      this.colRESIMPER.Name = "colRESIMPER";
      this.colRESIMPER.Visible = true;
      this.colRESIMPER.VisibleIndex = 0;
      this.colRESIMPER.Width = 121;
      this.colUNVAN.Caption = "Ünvan";
      this.colUNVAN.FieldName = "UNVAN";
      this.colUNVAN.MinWidth = 25;
      this.colUNVAN.Name = "colUNVAN";
      this.colUNVAN.Visible = true;
      this.colUNVAN.VisibleIndex = 18;
      this.colUNVAN.Width = 182;
      this.colADI.Caption = "İstihdam Durumu";
      this.colADI.FieldName = "ADI";
      this.colADI.MinWidth = 25;
      this.colADI.Name = "colADI";
      this.colADI.Visible = true;
      this.colADI.VisibleIndex = 19;
      this.colADI.Width = 230;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Width = 94;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.tBLPERSONELIZINBindingSource.DataMember = "TBLPERSONELIZIN";
      this.tBLPERSONELIZINBindingSource.DataSource = (object) this.bellDataSet2;
      this.tBLPERSONELIZINTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1149, 705);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (izinlistesi);
      this.Text = "Personel İzin Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.izinlistesiResimli.EndInit();
      this.gridView1.EndInit();
      this.muduryerine.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      ((ISupportInitialize) this.tBLPERSONELIZINBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
