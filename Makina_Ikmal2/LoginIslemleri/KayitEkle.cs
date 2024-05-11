// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.KayitEkle
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class KayitEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId kullan = new KullaniciSonId();
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
    private LookUpEdit AdiTxt;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl5;
    private LayoutControlGroup layoutControlGroup4;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem13;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLMENUBindingSource;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn Kodu;
    private DataGridViewTextBoxColumn Başlık;
    private DataGridViewCheckBoxColumn Menu;
    private DataGridViewCheckBoxColumn Kayıt;
    private DataGridViewCheckBoxColumn Sil;
    private DataGridViewCheckBoxColumn Düzenle;
    private DataGridViewCheckBoxColumn Okuma;
    private DataGridViewCheckBoxColumn Hepsi;
    private LayoutControlItem layoutControlItem3;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private TextEdit kullaniciAdiTxt;
    private TextEdit sifre_txt;
    private TextEdit sifre_tekrar_txt;

    public KayitEkle() => this.InitializeComponent();

    private void AracZimmetKaydi_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.dataGridView2.Visible = false;
      this.YetkiListele();
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelleload();
    }

    private void kayit()
    {
      int num1 = 0;
      int per_id = Convert.ToInt32(this.AdiTxt.EditValue);
      if (this.db.TBLKULLANICILAR.Where<TBLKULLANICILAR>((Expression<System.Func<TBLKULLANICILAR, bool>>) (p => p.PERSONELID == (int?) per_id)).Any<TBLKULLANICILAR>())
      {
        int num2 = (int) MessageBox.Show("Böyle bir kullanıcı mevcuttur");
      }
      else
      {
        try
        {
          TBLKULLANICILAR entity1 = new TBLKULLANICILAR()
          {
            KULLANICIADI = this.kullaniciAdiTxt.Text,
            PERSONELID = new int?(per_id),
            SIFRE = this.sifre_txt.Text,
            SIFRETEKRAR = this.sifre_tekrar_txt.Text
          };
          entity1.PERSONELID = new int?(per_id);
          entity1.ID = new int?(this.kullan.KullanicSonId());
          TBLPERSONEL tblpersonel = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == per_id));
          int unvan_id = Convert.ToInt32((object) tblpersonel.UNVANID);
          TBLPERSUNVAN tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<System.Func<TBLPERSUNVAN, bool>>) (x => x.ID == unvan_id));
          entity1.GOREVYERI = tblpersonel.GOREVYERI;
          entity1.UNVANI = tblpersunvan.UNVAN;
          TBLFORMKULLANICI entity2 = new TBLFORMKULLANICI();
          foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
          {
            if (num1 < 67)
            {
              try
              {
                entity2.KOMUTADI = row.Cells[1].Value.ToString();
                entity2.KULLANICIID = entity1.PERSONELID;
                entity2.SALTOKUNUR = !(bool) row.Cells[2].Value ? "Evet" : "Hayır";
                entity2.KAYIT = new bool?((bool) row.Cells[3].Value);
                entity2.SİL = new bool?((bool) row.Cells[4].Value);
                entity2.GUNCELLEME = new bool?((bool) row.Cells[5].Value);
                entity2.LISTELEME = new bool?((bool) row.Cells[6].Value);
                this.db.TBLFORMKULLANICI.Add(entity2);
                this.db.SaveChanges();
              }
              catch (Exception ex)
              {
                int num3 = (int) MessageBox.Show(ex?.ToString() + " offf ya hata");
              }
            }
            ++num1;
          }
          this.db.TBLKULLANICILAR.Add(entity1);
          this.db.SaveChanges();
          int num4 = (int) MessageBox.Show("İşleminiz Başarılı bir şekilde gerçekleşti");
        }
        catch (Exception ex)
        {
          int num5 = (int) XtraMessageBox.Show("Hata Var.." + ex?.ToString());
        }
      }
    }

    private void Guncelle()
    {
    }

    private void YetkiListele()
    {
      IQueryable<TBLMENU> queryable = this.db.TBLMENU.Select<TBLMENU, TBLMENU>((Expression<System.Func<TBLMENU, TBLMENU>>) (s => s));
      this.dataGridView2.Rows.Clear();
      this.dataGridView2.ColumnCount = 8;
      foreach (TBLMENU tblmenu in (IEnumerable<TBLMENU>) queryable)
        this.dataGridView2.Rows.Add((object) tblmenu.ID, (object) tblmenu.KOMUTADI, (object) false, (object) false, (object) false, (object) false, (object) false, (object) false);
      this.dataGridView2.AllowUserToAddRows = false;
    }

    private void guncelleload()
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.kayit();
      Anasayfa openForm = (Anasayfa) Application.OpenForms["Anasayfa"];
      if (openForm != null)
      {
        openForm.Yenile();
        openForm.Focus();
      }
      this.Close();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 7)
        return;
      try
      {
        if ((bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) false;
        else if (!(bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) true;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KayitEkle));
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
      this.AdiTxt = new LookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.layoutControl1 = new LayoutControl();
      this.dataGridView2 = new DataGridView();
      this.Kodu = new DataGridViewTextBoxColumn();
      this.Başlık = new DataGridViewTextBoxColumn();
      this.Menu = new DataGridViewCheckBoxColumn();
      this.Kayıt = new DataGridViewCheckBoxColumn();
      this.Sil = new DataGridViewCheckBoxColumn();
      this.Düzenle = new DataGridViewCheckBoxColumn();
      this.Okuma = new DataGridViewCheckBoxColumn();
      this.Hepsi = new DataGridViewCheckBoxColumn();
      this.layoutControl5 = new LayoutControl();
      this.layoutControlGroup4 = new LayoutControlGroup();
      this.kullaniciAdiTxt = new TextEdit();
      this.sifre_txt = new TextEdit();
      this.sifre_tekrar_txt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.tBLMENUBindingSource = new BindingSource(this.components);
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.AdiTxt.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.layoutControl5.BeginInit();
      this.layoutControlGroup4.BeginInit();
      this.kullaniciAdiTxt.Properties.BeginInit();
      this.sifre_txt.Properties.BeginInit();
      this.sifre_tekrar_txt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem3.BeginInit();
      ((ISupportInitialize) this.tBLMENUBindingSource).BeginInit();
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
      this.ribbonControl1.MaxItemId = 9;
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
      this.barButtonItem2.Caption = "Kayıt";
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
      this.AdiTxt.Location = new Point(92, 10);
      this.AdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AdiTxt.Name = "AdiTxt";
      this.AdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AdiTxt.Properties.Appearance.Options.UseFont = true;
      this.AdiTxt.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AdiTxt.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("ADISOYADI", "Personel Adı Soyadı")
      });
      this.AdiTxt.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AdiTxt.Properties.DisplayMember = "ADISOYADI";
      this.AdiTxt.Properties.NullText = "";
      this.AdiTxt.Properties.ValueMember = "ID";
      this.AdiTxt.Size = new Size(294, 24);
      this.AdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.AdiTxt.TabIndex = 4;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.layoutControl1.Controls.Add((Control) this.dataGridView2);
      this.layoutControl1.Controls.Add((Control) this.layoutControl5);
      this.layoutControl1.Controls.Add((Control) this.AdiTxt);
      this.layoutControl1.Controls.Add((Control) this.kullaniciAdiTxt);
      this.layoutControl1.Controls.Add((Control) this.sifre_txt);
      this.layoutControl1.Controls.Add((Control) this.sifre_tekrar_txt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 96);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1329, 767);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      gridViewCellStyle.BackColor = Color.Silver;
      this.dataGridView2.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange((DataGridViewColumn) this.Kodu, (DataGridViewColumn) this.Başlık, (DataGridViewColumn) this.Menu, (DataGridViewColumn) this.Kayıt, (DataGridViewColumn) this.Sil, (DataGridViewColumn) this.Düzenle, (DataGridViewColumn) this.Okuma, (DataGridViewColumn) this.Hepsi);
      this.dataGridView2.Location = new Point(390, 10);
      this.dataGridView2.Margin = new Padding(3, 2, 3, 2);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView2.RowTemplate.Height = 30;
      this.dataGridView2.Size = new Size(928, 747);
      this.dataGridView2.TabIndex = 139;
      this.dataGridView2.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      this.Kodu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      this.Kodu.FillWeight = 214.6786f;
      this.Kodu.HeaderText = "kodu";
      this.Kodu.Name = "Kodu";
      this.Kodu.Width = 40;
      this.Başlık.FillWeight = 173.7409f;
      this.Başlık.HeaderText = "Başlık";
      this.Başlık.Name = "Başlık";
      this.Başlık.Width = 416;
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
      this.layoutControl5.Location = new Point(11, 122);
      this.layoutControl5.Name = "layoutControl5";
      this.layoutControl5.Root = this.layoutControlGroup4;
      this.layoutControl5.Size = new Size(375, 635);
      this.layoutControl5.TabIndex = 16;
      this.layoutControl5.Text = "layoutControl5";
      this.layoutControlGroup4.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup4.GroupBordersVisible = false;
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new Size(375, 635);
      this.layoutControlGroup4.TextVisible = false;
      this.kullaniciAdiTxt.Location = new Point(92, 38);
      this.kullaniciAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
      this.kullaniciAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kullaniciAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.kullaniciAdiTxt.Properties.DisplayFormat.FormatString = "d";
      this.kullaniciAdiTxt.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.kullaniciAdiTxt.Properties.EditFormat.FormatString = "d";
      this.kullaniciAdiTxt.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.kullaniciAdiTxt.Size = new Size(294, 24);
      this.kullaniciAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.kullaniciAdiTxt.TabIndex = 5;
      this.sifre_txt.Location = new Point(92, 66);
      this.sifre_txt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sifre_txt.Name = "sifre_txt";
      this.sifre_txt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sifre_txt.Properties.Appearance.Options.UseFont = true;
      this.sifre_txt.Size = new Size(294, 24);
      this.sifre_txt.StyleController = (IStyleController) this.layoutControl1;
      this.sifre_txt.TabIndex = 7;
      this.sifre_tekrar_txt.Location = new Point(92, 94);
      this.sifre_tekrar_txt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sifre_tekrar_txt.Name = "sifre_tekrar_txt";
      this.sifre_tekrar_txt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sifre_tekrar_txt.Properties.Appearance.Options.UseFont = true;
      this.sifre_tekrar_txt.Size = new Size(294, 24);
      this.sifre_tekrar_txt.StyleController = (IStyleController) this.layoutControl1;
      this.sifre_tekrar_txt.TabIndex = 8;
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
      this.Root.Size = new Size(1329, 767);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.AdiTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.MinSize = new Size(154, 28);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(379, 28);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Adı Soyadı";
      this.layoutControlItem1.TextSize = new Size(78, 18);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.kullaniciAdiTxt;
      this.layoutControlItem2.Location = new Point(0, 28);
      this.layoutControlItem2.MinSize = new Size(43, 20);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(379, 28);
      this.layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "Kullanıcı Adı";
      this.layoutControlItem2.TextSize = new Size(78, 18);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.sifre_txt;
      this.layoutControlItem4.Location = new Point(0, 56);
      this.layoutControlItem4.MinSize = new Size(43, 20);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(379, 28);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Şifre";
      this.layoutControlItem4.TextSize = new Size(78, 18);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.sifre_tekrar_txt;
      this.layoutControlItem5.Location = new Point(0, 84);
      this.layoutControlItem5.MinSize = new Size(43, 20);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(379, 28);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "Şifre Tekrar";
      this.layoutControlItem5.TextSize = new Size(78, 18);
      this.layoutControlItem13.Control = (Control) this.layoutControl5;
      this.layoutControlItem13.Location = new Point(0, 112);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(379, 639);
      this.layoutControlItem13.TextSize = new Size(0, 0);
      this.layoutControlItem13.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.dataGridView2;
      this.layoutControlItem3.Location = new Point(379, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(932, 751);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.tBLMENUBindingSource.DataMember = "TBLMENU";
      this.tBLMENUBindingSource.DataSource = (object) this.bellDataSet7;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1329, 863);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (KayitEkle);
      this.Text = "AracZimmetKaydi";
      this.Load += new EventHandler(this.AracZimmetKaydi_Load);
      this.ribbonControl1.EndInit();
      this.AdiTxt.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.layoutControl5.EndInit();
      this.layoutControlGroup4.EndInit();
      this.kullaniciAdiTxt.Properties.EndInit();
      this.sifre_txt.Properties.EndInit();
      this.sifre_tekrar_txt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem3.EndInit();
      ((ISupportInitialize) this.tBLMENUBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
