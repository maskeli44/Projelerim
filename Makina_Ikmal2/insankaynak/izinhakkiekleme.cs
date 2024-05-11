// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.izinhakkiekleme
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class izinhakkiekleme : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int id;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup4;
    private SearchLookUpEdit searchLookUpEdit1;
    private GridView searchLookUpEdit1View;
    private TextEdit izinsureTxt;
    private LabelControl labelControl1;
    private LabelControl labelControl2;
    private LabelControl labelControl3;
    private SimpleButton simpleButton1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private BindingSource bellEntitiesBindingSource;
    private bellDataSet3 bellDataSet3;
    private BindingSource tBLPERIZINYILLARIBindingSource;
    private Makina_Ikmal.bellDataSet3TableAdapters.TBLPERIZINYILLARITableAdapter tBLPERIZINYILLARITableAdapter;
    private GridColumn gridColumn1;
    private GridControl gridControl1;
    private GridView gridView1;
    private izinHakDuzenleme izinHakDuzenleme;
    private BindingSource tBLPERSIZINDURUMBindingSource;
    private Makina_Ikmal.izinHakDuzenlemeTableAdapters.TBLPERSIZINDURUMTableAdapter tBLPERSIZINDURUMTableAdapter;
    private GridColumn colID;
    private GridColumn colIZINYILI;
    private GridColumn colIZINHAKKI;
    private GridColumn colKULLANILANIZIN;
    private BarButtonItem barButtonItem8;
    private LookUpEdit searchLookUpEdit2;

    public izinhakkiekleme() => this.InitializeComponent();

    private void izinhakkiekleme_Load(object sender, EventArgs e)
    {
      this.listele();
      this.load();
    }

    private void listele()
    {
      this.tBLPERIZINYILLARITableAdapter.Fill(this.bellDataSet3.TBLPERIZINYILLARI);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
    }

    private void load()
    {
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.searchLookUpEdit1.EditValue = (object) YetkiClass.secim_id;
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      int perid = Convert.ToInt32(this.searchLookUpEdit1.EditValue);
      int yil = Convert.ToInt32(this.searchLookUpEdit2.Text);
      if (this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) perid && hd.IZINYILI == (int?) yil)).Count<TBLPERSIZINDURUM>() > 0)
      {
        int num1 = (int) XtraMessageBox.Show(this.searchLookUpEdit2.Text + " bu yıla ait izin hakkı eklenmiştir");
      }
      else
      {
        this.db.TBLPERSIZINDURUM.Add(new TBLPERSIZINDURUM()
        {
          PERSONELID = new int?(Convert.ToInt32(this.searchLookUpEdit1.EditValue)),
          IZINYILI = new int?(Convert.ToInt32(this.searchLookUpEdit2.Text)),
          IZINHAKKI = new int?(Convert.ToInt32(this.izinsureTxt.Text)),
          KULLANILANIZIN = new int?(0)
        });
        this.db.SaveChanges();
        int num2 = (int) XtraMessageBox.Show("Kayıt başarlı bir şekilde gerçekleştirilmiştir");
        LogEkle.Logs("Ekleme Yapti");
        this.listele();
      }
    }

    private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e) => this.tBLPERSIZINDURUMTableAdapter.Fill(this.izinHakDuzenleme.TBLPERSIZINDURUM, new int?(Convert.ToInt32(this.searchLookUpEdit1.EditValue)));

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      this.id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == this.id));
      this.searchLookUpEdit2.Text = this.gridView1.GetFocusedRowCellValue("IZINYILI").ToString();
      this.izinsureTxt.Text = tblpersizindurum.IZINHAKKI.ToString();
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new yilekle().ShowDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == this.id));
      tblpersizindurum.IZINHAKKI = new int?(Convert.ToInt32(this.izinsureTxt.Text));
      tblpersizindurum.KULLANILANIZIN = new int?(0);
      this.db.SaveChanges();
      int num = (int) XtraMessageBox.Show("Güncelleme başarlı bir şekilde gerçekleştirilmiştir");
      LogEkle.Logs("Guncelleme Yapti");
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridControl1_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      this.id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == this.id));
      this.searchLookUpEdit2.Text = this.gridView1.GetFocusedRowCellValue("IZINYILI").ToString();
      this.izinsureTxt.Text = tblpersizindurum.IZINHAKKI.ToString();
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.gridView1.GetFocusedRowCellValue("ID").ToString() == null)
        return;
      int say = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      this.db.TBLPERSIZINDURUM.Remove(this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (x => x.ID == say)));
      this.db.SaveChanges();
      this.listele();
    }

    private void searchLookUpEdit1_TextChanged(object sender, EventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (izinhakkiekleme));
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
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.searchLookUpEdit1View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.tBLPERIZINYILLARIBindingSource = new BindingSource(this.components);
      this.bellDataSet3 = new bellDataSet3();
      this.bellEntitiesBindingSource = new BindingSource(this.components);
      this.izinsureTxt = new TextEdit();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.simpleButton1 = new SimpleButton();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLPERIZINYILLARITableAdapter = new Makina_Ikmal.bellDataSet3TableAdapters.TBLPERIZINYILLARITableAdapter();
      this.gridControl1 = new GridControl();
      this.tBLPERSIZINDURUMBindingSource = new BindingSource(this.components);
      this.izinHakDuzenleme = new izinHakDuzenleme();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colIZINYILI = new GridColumn();
      this.colIZINHAKKI = new GridColumn();
      this.colKULLANILANIZIN = new GridColumn();
      this.tBLPERSIZINDURUMTableAdapter = new Makina_Ikmal.izinHakDuzenlemeTableAdapters.TBLPERSIZINDURUMTableAdapter();
      this.searchLookUpEdit2 = new LookUpEdit();
      this.ribbonControl1.BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet2.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource).BeginInit();
      this.bellDataSet3.BeginInit();
      ((ISupportInitialize) this.bellEntitiesBindingSource).BeginInit();
      this.izinsureTxt.Properties.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLPERSIZINDURUMBindingSource).BeginInit();
      this.izinHakDuzenleme.BeginInit();
      this.gridView1.BeginInit();
      this.searchLookUpEdit2.Properties.BeginInit();
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
      this.ribbonControl1.MaxItemId = 9;
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
      this.ribbonControl1.Size = new Size(883, 122);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem2.Caption = "Kayıt";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) Resources.saveto_16x16;
      this.barButtonItem2.ImageOptions.LargeImage = (Image) Resources.saveto_32x32;
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Düzenle";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) Resources.editdatasource_16x16;
      this.barButtonItem3.ImageOptions.LargeImage = (Image) Resources.editdatasource_32x32;
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
      this.barButtonItem8.Caption = "Sil";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) Resources.removesheetcolumns_16x16;
      this.barButtonItem8.ImageOptions.LargeImage = (Image) Resources.removesheetcolumns_32x32;
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.searchLookUpEdit1.Location = new Point(216, 165);
      this.searchLookUpEdit1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.searchLookUpEdit1.Properties.DisplayMember = "ADISOYADI";
      this.searchLookUpEdit1.Properties.NullText = "";
      this.searchLookUpEdit1.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.searchLookUpEdit1.Properties.ValueMember = "ID";
      this.searchLookUpEdit1.Size = new Size(245, 30);
      this.searchLookUpEdit1.TabIndex = 2;
      this.searchLookUpEdit1.EditValueChanged += new EventHandler(this.searchLookUpEdit1_EditValueChanged);
      this.searchLookUpEdit1.TextChanged += new EventHandler(this.searchLookUpEdit1_TextChanged);
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Adı Soyadı";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.tBLPERIZINYILLARIBindingSource.DataMember = "TBLPERIZINYILLARI";
      this.tBLPERIZINYILLARIBindingSource.DataSource = (object) this.bellDataSet3;
      this.bellDataSet3.DataSetName = "bellDataSet3";
      this.bellDataSet3.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.bellEntitiesBindingSource.DataSource = (object) typeof (bellEntities);
      this.izinsureTxt.Location = new Point(216, 266);
      this.izinsureTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.izinsureTxt.Name = "izinsureTxt";
      this.izinsureTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.izinsureTxt.Properties.Appearance.Options.UseFont = true;
      this.izinsureTxt.Size = new Size(125, 30);
      this.izinsureTxt.TabIndex = 4;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(106, 168);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(103, 22);
      this.labelControl1.TabIndex = 5;
      this.labelControl1.Text = "Personel Adı ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(152, 219);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(57, 22);
      this.labelControl2.TabIndex = 6;
      this.labelControl2.Text = "İzin Yılı";
      this.labelControl3.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(122, 272);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(87, 22);
      this.labelControl3.TabIndex = 7;
      this.labelControl3.Text = "İzin Miktarı";
      this.simpleButton1.ImageOptions.Image = (Image) Resources.add_32x32;
      this.simpleButton1.Location = new Point(348, 215);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(47, 29);
      this.simpleButton1.TabIndex = 8;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLPERIZINYILLARITableAdapter.ClearBeforeFill = true;
      this.gridControl1.DataSource = (object) this.tBLPERSIZINDURUMBindingSource;
      this.gridControl1.Dock = DockStyle.Bottom;
      this.gridControl1.Location = new Point(0, 302);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(883, 372);
      this.gridControl1.TabIndex = 10;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridControl1.DoubleClick += new EventHandler(this.gridControl1_DoubleClick);
      this.tBLPERSIZINDURUMBindingSource.DataMember = "TBLPERSIZINDURUM";
      this.tBLPERSIZINDURUMBindingSource.DataSource = (object) this.izinHakDuzenleme;
      this.izinHakDuzenleme.DataSetName = "izinHakDuzenleme";
      this.izinHakDuzenleme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[4]
      {
        this.colID,
        this.colIZINYILI,
        this.colIZINHAKKI,
        this.colKULLANILANIZIN
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 94;
      this.colIZINYILI.Caption = "İzin Yılı";
      this.colIZINYILI.FieldName = "IZINYILI";
      this.colIZINYILI.MinWidth = 25;
      this.colIZINYILI.Name = "colIZINYILI";
      this.colIZINYILI.OptionsColumn.AllowEdit = false;
      this.colIZINYILI.OptionsColumn.ReadOnly = true;
      this.colIZINYILI.Visible = true;
      this.colIZINYILI.VisibleIndex = 0;
      this.colIZINYILI.Width = 94;
      this.colIZINHAKKI.Caption = "İzin Hakkı";
      this.colIZINHAKKI.FieldName = "IZINHAKKI";
      this.colIZINHAKKI.MinWidth = 25;
      this.colIZINHAKKI.Name = "colIZINHAKKI";
      this.colIZINHAKKI.OptionsColumn.AllowEdit = false;
      this.colIZINHAKKI.OptionsColumn.ReadOnly = true;
      this.colIZINHAKKI.Visible = true;
      this.colIZINHAKKI.VisibleIndex = 1;
      this.colIZINHAKKI.Width = 94;
      this.colKULLANILANIZIN.Caption = "Kullanılan İzin";
      this.colKULLANILANIZIN.FieldName = "KULLANILANIZIN";
      this.colKULLANILANIZIN.MinWidth = 25;
      this.colKULLANILANIZIN.Name = "colKULLANILANIZIN";
      this.colKULLANILANIZIN.OptionsColumn.AllowEdit = false;
      this.colKULLANILANIZIN.OptionsColumn.ReadOnly = true;
      this.colKULLANILANIZIN.Visible = true;
      this.colKULLANILANIZIN.VisibleIndex = 2;
      this.colKULLANILANIZIN.Width = 94;
      this.tBLPERSIZINDURUMTableAdapter.ClearBeforeFill = true;
      this.searchLookUpEdit2.Location = new Point(216, 216);
      this.searchLookUpEdit2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.searchLookUpEdit2.Name = "searchLookUpEdit2";
      this.searchLookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit2.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit2.Properties.DataSource = (object) this.tBLPERIZINYILLARIBindingSource;
      this.searchLookUpEdit2.Properties.DisplayMember = "YIL";
      this.searchLookUpEdit2.Properties.NullText = "";
      this.searchLookUpEdit2.Properties.ValueMember = "ID";
      this.searchLookUpEdit2.Size = new Size(125, 30);
      this.searchLookUpEdit2.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(883, 674);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.simpleButton1);
      this.Controls.Add((Control) this.labelControl3);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.izinsureTxt);
      this.Controls.Add((Control) this.searchLookUpEdit1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Controls.Add((Control) this.searchLookUpEdit2);
      this.IconOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.Name = nameof (izinhakkiekleme);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "YILLIK İZİN HAKKI";
      this.Load += new EventHandler(this.izinhakkiekleme_Load);
      this.ribbonControl1.EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet2.EndInit();
      this.searchLookUpEdit1View.EndInit();
      ((ISupportInitialize) this.tBLPERIZINYILLARIBindingSource).EndInit();
      this.bellDataSet3.EndInit();
      ((ISupportInitialize) this.bellEntitiesBindingSource).EndInit();
      this.izinsureTxt.Properties.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLPERSIZINDURUMBindingSource).EndInit();
      this.izinHakDuzenleme.EndInit();
      this.gridView1.EndInit();
      this.searchLookUpEdit2.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
