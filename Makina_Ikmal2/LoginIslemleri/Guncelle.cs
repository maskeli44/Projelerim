// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.Guncelle
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
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class Guncelle : XtraForm
  {
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
    private RibbonPageGroup ribbonPageGroup4;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem13;
    private DataGridView dataGridView2;
    private LookUpEdit adiTxt;
    private TextEdit KulaniciAdiTxt;
    private TextEdit sifreTxt;
    private TextEdit sifreTkrTxt;
    private LayoutControlItem layoutControlItem3;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Başlık;
    private DataGridViewCheckBoxColumn Menu;
    private DataGridViewCheckBoxColumn Kayıt;
    private DataGridViewCheckBoxColumn Sil;
    private DataGridViewCheckBoxColumn Düzenle;
    private DataGridViewCheckBoxColumn Okuma;
    private DataGridViewCheckBoxColumn Hepsi;

    public Guncelle() => this.InitializeComponent();

    private void AracZimmetKaydi_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.guncelleload();
    }

    private void kayit()
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.guncellee();

    private void guncellee()
    {
      TBLKULLANICILAR tblkullanicilar = this.db.TBLKULLANICILAR.FirstOrDefault<TBLKULLANICILAR>((Expression<System.Func<TBLKULLANICILAR, bool>>) (x => x.PERSONELID == (int?) YetkiClass.secim_id));
      tblkullanicilar.KULLANICIADI = this.KulaniciAdiTxt.Text;
      tblkullanicilar.PERSONELID = new int?(YetkiClass.secim_id);
      tblkullanicilar.SIFRE = this.sifreTxt.Text;
      tblkullanicilar.ADISOYADI = this.adiTxt.Text;
      tblkullanicilar.SIFRETEKRAR = this.sifreTkrTxt.Text;
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
      {
        int den = Convert.ToInt32(row.Cells[0].Value);
        TBLFORMKULLANICI tblformkullanici = this.db.TBLFORMKULLANICI.FirstOrDefault<TBLFORMKULLANICI>((Expression<System.Func<TBLFORMKULLANICI, bool>>) (x => x.ID == den));
        try
        {
          try
          {
            tblformkullanici.SALTOKUNUR = !(bool) row.Cells[2].Value ? "Evet" : "Hayır";
          }
          catch (Exception ex)
          {
            tblformkullanici.SALTOKUNUR = "Evet";
          }
          try
          {
            tblformkullanici.KAYIT = new bool?((bool) row.Cells[3].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.KAYIT = new bool?(false);
          }
          try
          {
            tblformkullanici.GUNCELLEME = new bool?((bool) row.Cells[5].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.GUNCELLEME = new bool?(false);
          }
          try
          {
            tblformkullanici.SİL = new bool?((bool) row.Cells[4].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.SİL = new bool?(false);
          }
          try
          {
            tblformkullanici.LISTELEME = new bool?((bool) row.Cells[6].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.LISTELEME = new bool?(false);
          }
          this.db.SaveChanges();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex?.ToString() + "  Hata oluştu");
        }
      }
      this.db.SaveChanges();
      int num1 = (int) MessageBox.Show("Güncelleme İşleminiz Başarılı bir şekilde gerçekleşti");
      this.guncelleload();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void guncelleload()
    {
      TBLKULLANICILAR tblkullanicilar = this.db.TBLKULLANICILAR.FirstOrDefault<TBLKULLANICILAR>((Expression<System.Func<TBLKULLANICILAR, bool>>) (x => x.PERSONELID == (int?) YetkiClass.secim_id));
      this.KulaniciAdiTxt.Text = tblkullanicilar.KULLANICIADI;
      this.sifreTxt.Text = tblkullanicilar.SIFRE;
      this.adiTxt.EditValue = (object) YetkiClass.secim_id;
      int sorgu_id = Convert.ToInt32((object) tblkullanicilar.PERSONELID);
      this.sifreTkrTxt.Text = tblkullanicilar.SIFRETEKRAR;
      IQueryable<TBLFORMKULLANICI> queryable = this.db.TBLFORMKULLANICI.Where<TBLFORMKULLANICI>((Expression<System.Func<TBLFORMKULLANICI, bool>>) (hd => hd.KULLANICIID == (int?) sorgu_id));
      this.dataGridView2.Rows.Clear();
      this.dataGridView2.ColumnCount = 9;
      foreach (TBLFORMKULLANICI tblformkullanici in (IEnumerable<TBLFORMKULLANICI>) queryable)
      {
        bool flag = false;
        if (tblformkullanici.SALTOKUNUR == "Hayır")
          flag = true;
        this.dataGridView2.Rows.Add((object) tblformkullanici.ID, (object) tblformkullanici.KOMUTADI, (object) flag, (object) tblformkullanici.KAYIT, (object) tblformkullanici.SİL, (object) tblformkullanici.GUNCELLEME, (object) tblformkullanici.LISTELEME, (object) false);
      }
      this.dataGridView2.AllowUserToAddRows = false;
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLKULLANICILAR entity1 = this.db.TBLKULLANICILAR.FirstOrDefault<TBLKULLANICILAR>((Expression<System.Func<TBLKULLANICILAR, bool>>) (x => x.PERSONELID == (int?) YetkiClass.secim_id));
      DbSet<TBLFORMKULLANICI> tblformkullanici = this.db.TBLFORMKULLANICI;
      Expression<System.Func<TBLFORMKULLANICI, bool>> predicate = (Expression<System.Func<TBLFORMKULLANICI, bool>>) (hd => hd.KULLANICIID == (int?) YetkiClass.secim_id);
      foreach (TBLFORMKULLANICI entity2 in (IEnumerable<TBLFORMKULLANICI>) tblformkullanici.Where<TBLFORMKULLANICI>(predicate))
        this.db.TBLFORMKULLANICI.Remove(entity2);
      this.db.TBLKULLANICILAR.Remove(entity1);
      this.db.SaveChanges();
      Anasayfa openForm = (Anasayfa) Application.OpenForms["Anasayfa"];
      if (openForm != null)
      {
        openForm.Yenile();
        openForm.Focus();
      }
      this.Close();
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      bool flag = false;
      if (e.ColumnIndex != 7)
        return;
      try
      {
        if ((bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) false;
          flag = true;
        }
        else if (!(bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) true;
          flag = false;
        }
        if ((bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[2].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[3].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[4].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[5].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[6].Value = (object) true;
        }
        else if (!(bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[2].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[3].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[4].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[5].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[6].Value = (object) false;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Guncelle));
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
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
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.layoutControl1 = new LayoutControl();
      this.dataGridView2 = new DataGridView();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.adiTxt = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.KulaniciAdiTxt = new TextEdit();
      this.sifreTxt = new TextEdit();
      this.sifreTkrTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.ID = new DataGridViewTextBoxColumn();
      this.Başlık = new DataGridViewTextBoxColumn();
      this.Menu = new DataGridViewCheckBoxColumn();
      this.Kayıt = new DataGridViewCheckBoxColumn();
      this.Sil = new DataGridViewCheckBoxColumn();
      this.Düzenle = new DataGridViewCheckBoxColumn();
      this.Okuma = new DataGridViewCheckBoxColumn();
      this.Hepsi = new DataGridViewCheckBoxColumn();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.adiTxt.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.KulaniciAdiTxt.Properties.BeginInit();
      this.sifreTxt.Properties.BeginInit();
      this.sifreTkrTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem3.BeginInit();
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
      this.ribbonControl1.MaxItemId = 10;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 283;
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
      this.ribbonControl1.Size = new Size(1329, 96);
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
      this.barButtonItem2.Caption = "Güncelle";
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
      this.barButtonItem5.Caption = "Yazdır";
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
      this.barButtonItem8.Caption = "Yeni";
      this.barButtonItem8.Id = 8;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
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
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.layoutControl1.Controls.Add((Control) this.dataGridView2);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.adiTxt);
      this.layoutControl1.Controls.Add((Control) this.KulaniciAdiTxt);
      this.layoutControl1.Controls.Add((Control) this.sifreTxt);
      this.layoutControl1.Controls.Add((Control) this.sifreTkrTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1329, 443);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      gridViewCellStyle.BackColor = Color.Silver;
      this.dataGridView2.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.Başlık, (DataGridViewColumn) this.Menu, (DataGridViewColumn) this.Kayıt, (DataGridViewColumn) this.Sil, (DataGridViewColumn) this.Düzenle, (DataGridViewColumn) this.Okuma, (DataGridViewColumn) this.Hepsi);
      this.dataGridView2.Location = new Point(371, 12);
      this.dataGridView2.Margin = new Padding(3, 2, 3, 2);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView2.RowTemplate.Height = 30;
      this.dataGridView2.Size = new Size(946, 419);
      this.dataGridView2.TabIndex = 140;
      this.dataGridView2.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      this.layoutControl5.Location = new Point(12, 126);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(355, 305);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(355, 305);
      this.layoutControlGroup4.TextVisible = false;
      this.adiTxt.Location = new Point(93, 12);
      this.adiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.adiTxt.Name = "adiTxt";
      this.adiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.adiTxt.Properties.Appearance.Options.UseFont = true;
      this.adiTxt.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.adiTxt.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADISOYADI", "Adı Soyadı", 17, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.adiTxt.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.adiTxt.Properties.DisplayMember = "ADISOYADI";
      this.adiTxt.Properties.NullText = "";
      this.adiTxt.Properties.ValueMember = "ID";
      this.adiTxt.Size = new Size(274, 24);
      this.adiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.adiTxt.TabIndex = 4;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.KulaniciAdiTxt.Location = new Point(93, 41);
      this.KulaniciAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.KulaniciAdiTxt.Name = "KulaniciAdiTxt";
      this.KulaniciAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.KulaniciAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.KulaniciAdiTxt.Properties.DisplayFormat.FormatString = "d";
      this.KulaniciAdiTxt.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.KulaniciAdiTxt.Properties.EditFormat.FormatString = "d";
      this.KulaniciAdiTxt.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.KulaniciAdiTxt.Properties.Mask.EditMask = "d";
      this.KulaniciAdiTxt.Properties.Mask.MaskType = MaskType.DateTime;
      this.KulaniciAdiTxt.Size = new Size(274, 24);
      this.KulaniciAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.KulaniciAdiTxt.TabIndex = 5;
      this.sifreTxt.Location = new Point(93, 68);
      this.sifreTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sifreTxt.Name = "sifreTxt";
      this.sifreTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sifreTxt.Properties.Appearance.Options.UseFont = true;
      this.sifreTxt.Size = new Size(274, 24);
      this.sifreTxt.StyleController = (IStyleController) this.layoutControl1;
      this.sifreTxt.TabIndex = 7;
      this.sifreTkrTxt.Location = new Point(93, 99);
      this.sifreTkrTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sifreTkrTxt.Name = "sifreTkrTxt";
      this.sifreTkrTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sifreTkrTxt.Properties.Appearance.Options.UseFont = true;
      this.sifreTkrTxt.Size = new Size(274, 24);
      this.sifreTkrTxt.StyleController = (IStyleController) this.layoutControl1;
      this.sifreTkrTxt.TabIndex = 8;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[6]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem3
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1329, 443);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.adiTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.MinSize = new Size(43, 20);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(359, 29);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Adı Soaydı";
      this.layoutControlItem1.TextSize = new Size(78, 18);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.KulaniciAdiTxt;
      this.layoutControlItem2.Location = new Point(0, 29);
      this.layoutControlItem2.MinSize = new Size(43, 20);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(359, 27);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Kullanıcı Adı";
      this.layoutControlItem2.TextSize = new Size(78, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.sifreTxt;
      this.layoutControlItem4.Location = new Point(0, 56);
      this.layoutControlItem4.MinSize = new Size(43, 20);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(359, 31);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Şifre";
      this.layoutControlItem4.TextSize = new Size(78, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.sifreTkrTxt;
      this.layoutControlItem5.Location = new Point(0, 87);
      this.layoutControlItem5.MinSize = new Size(43, 20);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(359, 27);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Şifre Tekrar";
      this.layoutControlItem5.TextSize = new Size(78, 18);
      this.layoutControlItem13.Control = (Control) this.layoutControl5;
      this.layoutControlItem13.Location = new Point(0, 114);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(359, 309);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.dataGridView2;
      this.layoutControlItem3.Location = new Point(359, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(950, 423);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.Visible = false;
      this.Başlık.FillWeight = 173.7409f;
      this.Başlık.HeaderText = "Başlık";
      this.Başlık.Name = "Başlık";
      this.Başlık.Width = 300;
      this.Menu.FalseValue = (object) "0";
      this.Menu.FillWeight = 50.12064f;
      this.Menu.HeaderText = "Menu";
      this.Menu.Name = "Menu";
      this.Menu.Width = 120;
      this.Kayıt.FalseValue = (object) "0";
      this.Kayıt.FillWeight = 48.42142f;
      this.Kayıt.HeaderText = "Kayıt";
      this.Kayıt.Name = "Kayıt";
      this.Kayıt.Width = 116;
      this.Sil.FalseValue = (object) "0";
      this.Sil.FillWeight = 46.00843f;
      this.Sil.HeaderText = "Sil";
      this.Sil.Name = "Sil";
      this.Sil.Width = 110;
      this.Düzenle.FalseValue = (object) "0";
      this.Düzenle.FillWeight = 42.73159f;
      this.Düzenle.HeaderText = "Düzenle";
      this.Düzenle.Name = "Düzenle";
      this.Düzenle.Width = 102;
      this.Okuma.FalseValue = (object) "0";
      this.Okuma.FillWeight = 38.4127f;
      this.Okuma.HeaderText = "Okuma";
      this.Okuma.Name = "Okuma";
      this.Okuma.Width = 92;
      this.Hepsi.FalseValue = (object) "false";
      this.Hepsi.FillWeight = 32.84033f;
      this.Hepsi.HeaderText = "Hepsi";
      this.Hepsi.Name = "Hepsi";
      this.Hepsi.Resizable = DataGridViewTriState.True;
      this.Hepsi.SortMode = DataGridViewColumnSortMode.Automatic;
      this.Hepsi.Width = 79;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1329, 539);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (Guncelle);
      this.Text = "AracZimmetKaydi";
      this.Load += new EventHandler(this.AracZimmetKaydi_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.adiTxt.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.KulaniciAdiTxt.Properties.EndInit();
      this.sifreTxt.Properties.EndInit();
      this.sifreTkrTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem3.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
