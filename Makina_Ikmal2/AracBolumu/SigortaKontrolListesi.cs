﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AracBolumu.SigortaKontrolListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.AracBolumu
{
  public class SigortaKontrolListesi : Form
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
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
    private BarEditItem barEditItem5;
    private RepositoryItemSearchControl repositoryItemSearchControl2;
    private BarCheckItem barCheckItem7;
    private BarCheckItem barCheckItem9;
    private BarCheckItem barCheckItem10;
    private BarCheckItem barCheckItem11;
    private BarCheckItem barCheckItem12;
    private BarCheckItem barCheckItem13;
    private BarEditItem barEditItem3;
    private BarCheckItem barCheckItem8;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem12;
    private RibbonPageGroup ribbonPageGroup6;
    private RepositoryItemLookUpEdit BelediyeBirim;
    private RepositoryItemLookUpEdit BelediyeMudurluk;
    private BarButtonItem barButtonItem11;
    private RibbonPageGroup ribbonPageGroup1;
    private RepositoryItemSearchLookUpEdit marka;
    private GridView repositoryItemSearchLookUpEdit1View;
    private AracSigortaKontrol aracSigortaKontrol;
    private BindingSource tBLARACLARBindingSource;
    private Makina_Ikmal.Model.AracSigortaKontrolTableAdapters.TBLARACLARTableAdapter tBLARACLARTableAdapter;
    private GridColumn colAraçID;
    private GridColumn colPlaka;
    private GridColumn colMarka;
    private GridColumn colCinsi;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLARACMARKABindingSource;
    private TBLARACMARKATableAdapter tBLARACMARKATableAdapter;
    private BindingSource tBLBELDMUDURLUKBindingSource;
    private TBLBELDMUDURLUKTableAdapter tBLBELDMUDURLUKTableAdapter;
    private BindingSource tBLBELDBIRIMLERBindingSource;
    private TBLBELDBIRIMLERTableAdapter tBLBELDBIRIMLERTableAdapter;
    private GridColumn colARACGRUBUID;
    private GridColumn colKalanGun;
    private GridColumn colTRAFIKSGORTA2;
    private GridColumn colBelgeNo;
    private GridColumn colMotorNo;
    private GridColumn colŞaseNo;
    private BarEditItem barEditItem6;
    private RepositoryItemDateEdit repositoryItemDateEdit1;
    private BarEditItem barEditItem7;
    private RepositoryItemDateEdit repositoryItemDateEdit2;
    private RibbonPageGroup ribbonPageGroup4;

    public SigortaKontrolListesi() => this.InitializeComponent();

    private void Form6_Load(object sender, EventArgs e) => this.Listele();

    public void Listele()
    {
      this.tBLBELDBIRIMLERTableAdapter.Fill(this.bellDataSet7.TBLBELDBIRIMLER);
      this.tBLBELDMUDURLUKTableAdapter.Fill(this.bellDataSet7.TBLBELDMUDURLUK);
      this.tBLARACMARKATableAdapter.Fill(this.bellDataSet7.TBLARACMARKA);
      this.gridControl1.DataSource = (object) this.db.TBLARACLAR.Where<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (hd => (hd.ARACDURUMID == (int?) 1 || hd.ARACDURUMID == (int?) 3) && hd.ARACTIPIID == (int?) 1 && hd.ARACGRUBUID != (int?) 111 && hd.TRAFIKSGORTA2 != new DateTime?())).Select(hd => new
      {
        aracID = hd.ID,
        kalanGun = (int) SqlFunctions.DateDiff("day", (DateTime?) DateTime.Now, hd.TRAFIKSGORTA2),
        TRAFIKSGORTA2 = hd.TRAFIKSGORTA2,
        Plaka = hd.PLAKA,
        Marka = hd.MARKAID,
        Cinsi = hd.CINSI,
        saseNo = hd.SASENO,
        belgoNo = hd.BELGESERINO,
        motorNo = hd.MOTORNO
      }).ToList();
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
      int num = (int) MessageBox.Show("Dosya belgelerime kaydedildi.");
    }

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void gridControl1_Load(object sender, EventArgs e) => this.satirToplam();

    private void satirToplam()
    {
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView gridView = sender as GridView;
      try
      {
        DateTime dateTime = Convert.ToDateTime(this.gridView1.GetRowCellValue(e.RowHandle, this.colTRAFIKSGORTA2));
        DateTime now = DateTime.Now;
        if (dateTime.Month != now.Month || dateTime.Year != now.Year)
          return;
        e.Appearance.BackColor = Color.Red;
      }
      catch (Exception ex)
      {
      }
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void TarihSirala(BarEditItem a, BarEditItem b)
    {
      if (a.EditValue != null)
      {
        if (b.EditValue != null)
          this.SorguGetir(Convert.ToDateTime(a.EditValue), Convert.ToDateTime(b.EditValue));
        else
          this.SorguGetir(Convert.ToDateTime(a.EditValue), DateTime.MaxValue);
      }
      else if (b.EditValue != null)
        this.SorguGetir(DateTime.MinValue, Convert.ToDateTime(b.EditValue));
      else
        this.Listele();
    }

    private void SorguGetir(DateTime a, DateTime b) => this.gridControl1.DataSource = (object) this.db.TBLARACLAR.Where<TBLARACLAR>((Expression<System.Func<TBLARACLAR, bool>>) (hd => (hd.ARACDURUMID == (int?) 1 || hd.ARACDURUMID == (int?) 3) && hd.ARACTIPIID == (int?) 1 && hd.ARACGRUBUID != (int?) 111 && hd.TRAFIKSGORTA2 != new DateTime?() && hd.TRAFIKSGORTA2.Value >= a && hd.TRAFIKSGORTA2.Value <= b)).Select(hd => new
    {
      aracID = hd.ID,
      kalanGun = (int) SqlFunctions.DateDiff("day", (DateTime?) DateTime.Now, hd.TRAFIKSGORTA2),
      TRAFIKSGORTA2 = hd.TRAFIKSGORTA2,
      Plaka = hd.PLAKA,
      Marka = hd.MARKAID,
      Cinsi = hd.CINSI,
      saseNo = hd.SASENO,
      belgoNo = hd.BELGESERINO,
      motorNo = hd.MOTORNO
    }).ToList();

    private void barEditItem6_EditValueChanged(object sender, EventArgs e) => this.TarihSirala(this.barEditItem6, this.barEditItem7);

    private void barEditItem7_EditValueChanged(object sender, EventArgs e) => this.TarihSirala(this.barEditItem6, this.barEditItem7);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SigortaKontrolListesi));
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
      this.colAraçID = new GridColumn();
      this.colTRAFIKSGORTA2 = new GridColumn();
      this.colPlaka = new GridColumn();
      this.colARACGRUBUID = new GridColumn();
      this.colMarka = new GridColumn();
      this.marka = new RepositoryItemSearchLookUpEdit();
      this.tBLARACMARKABindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colKalanGun = new GridColumn();
      this.colCinsi = new GridColumn();
      this.colBelgeNo = new GridColumn();
      this.colMotorNo = new GridColumn();
      this.colŞaseNo = new GridColumn();
      this.BelediyeBirim = new RepositoryItemLookUpEdit();
      this.tBLBELDBIRIMLERBindingSource = new BindingSource(this.components);
      this.BelediyeMudurluk = new RepositoryItemLookUpEdit();
      this.tBLBELDMUDURLUKBindingSource = new BindingSource(this.components);
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
      this.barButtonItem12 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.barEditItem6 = new BarEditItem();
      this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
      this.barEditItem7 = new BarEditItem();
      this.repositoryItemDateEdit2 = new RepositoryItemDateEdit();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.repositoryItemRadioGroup2 = new RepositoryItemRadioGroup();
      this.tBLARACLARBindingSource = new BindingSource(this.components);
      this.aracSigortaKontrol = new AracSigortaKontrol();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.barEditItem3 = new BarEditItem();
      this.tBLARACLARTableAdapter = new Makina_Ikmal.Model.AracSigortaKontrolTableAdapters.TBLARACLARTableAdapter();
      this.tBLARACMARKATableAdapter = new TBLARACMARKATableAdapter();
      this.tBLBELDMUDURLUKTableAdapter = new TBLBELDMUDURLUKTableAdapter();
      this.tBLBELDBIRIMLERTableAdapter = new TBLBELDBIRIMLERTableAdapter();
      this.repositoryItemCheckEdit1.BeginInit();
      this.repositoryItemRadioGroup1.BeginInit();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl2.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.marka.BeginInit();
      ((ISupportInitialize) this.tBLARACMARKABindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.BelediyeBirim.BeginInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).BeginInit();
      this.BelediyeMudurluk.BeginInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).BeginInit();
      this.repositoryItemDateEdit1.BeginInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.BeginInit();
      this.repositoryItemDateEdit2.BeginInit();
      this.repositoryItemDateEdit2.CalendarTimeProperties.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.repositoryItemRadioGroup2.BeginInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).BeginInit();
      this.aracSigortaKontrol.BeginInit();
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
      this.ribbonControl1.Items.AddRange(new BarItem[33]
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
        (BarItem) this.barButtonItem12,
        (BarItem) this.barButtonItem11,
        (BarItem) this.barEditItem6,
        (BarItem) this.barEditItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 64;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.repositoryItemSearchControl1,
        (RepositoryItem) this.repositoryItemRadioGroup2,
        (RepositoryItem) this.repositoryItemSearchControl2,
        (RepositoryItem) this.repositoryItemDateEdit1,
        (RepositoryItem) this.repositoryItemDateEdit2
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1098, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.Id = 36;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem2.Id = 37;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem3.Id = 38;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem4.Id = 39;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem5.Id = 40;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem6.Id = 41;
      this.barButtonItem6.Name = "barButtonItem6";
      this.barButtonItem7.Id = 42;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.Id = 43;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem2.Edit = (RepositoryItem) null;
      this.barEditItem2.Id = 44;
      this.barEditItem2.Name = "barEditItem2";
      this.barEditItem4.Edit = (RepositoryItem) null;
      this.barEditItem4.Id = 45;
      this.barEditItem4.Name = "barEditItem4";
      this.barCheckItem1.Id = 46;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Id = 47;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Id = 48;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem4.Id = 49;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem5.Id = 50;
      this.barCheckItem5.Name = "barCheckItem5";
      this.barCheckItem6.Id = 51;
      this.barCheckItem6.Name = "barCheckItem6";
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
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.BelediyeBirim,
        (RepositoryItem) this.BelediyeMudurluk,
        (RepositoryItem) this.marka
      });
      this.gridControl1.Size = new Size(1098, 401);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Load += new EventHandler(this.gridControl1_Load);
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.gridView1.Appearance.EvenRow.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.BackColor = SystemColors.Control;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[10]
      {
        this.colAraçID,
        this.colTRAFIKSGORTA2,
        this.colPlaka,
        this.colARACGRUBUID,
        this.colMarka,
        this.colKalanGun,
        this.colCinsi,
        this.colBelgeNo,
        this.colMotorNo,
        this.colŞaseNo
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
        new GridColumnSortInfo(this.colTRAFIKSGORTA2, ColumnSortOrder.Ascending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.colAraçID.FieldName = "aracID";
      this.colAraçID.Name = "colAraçID";
      this.colTRAFIKSGORTA2.Caption = "Sigorta Tarihi";
      this.colTRAFIKSGORTA2.FieldName = "TRAFIKSGORTA2";
      this.colTRAFIKSGORTA2.Name = "colTRAFIKSGORTA2";
      this.colTRAFIKSGORTA2.Visible = true;
      this.colTRAFIKSGORTA2.VisibleIndex = 6;
      this.colTRAFIKSGORTA2.Width = 126;
      this.colPlaka.FieldName = "Plaka";
      this.colPlaka.Name = "colPlaka";
      this.colPlaka.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "Plaka", "Toplam Kayit= {0}")
      });
      this.colPlaka.Visible = true;
      this.colPlaka.VisibleIndex = 0;
      this.colPlaka.Width = 165;
      this.colARACGRUBUID.FieldName = "ARACGRUBUID";
      this.colARACGRUBUID.Name = "colARACGRUBUID";
      this.colARACGRUBUID.Width = 56;
      this.colMarka.ColumnEdit = (RepositoryItem) this.marka;
      this.colMarka.FieldName = "Marka";
      this.colMarka.Name = "colMarka";
      this.colMarka.Visible = true;
      this.colMarka.VisibleIndex = 2;
      this.colMarka.Width = 138;
      this.marka.AutoHeight = false;
      this.marka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.marka.DataSource = (object) this.tBLARACMARKABindingSource;
      this.marka.DisplayMember = "ARACMARKA";
      this.marka.Name = "marka";
      this.marka.NullText = "";
      this.marka.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.marka.ValueMember = "ID";
      this.tBLARACMARKABindingSource.DataMember = "TBLARACMARKA";
      this.tBLARACMARKABindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colKalanGun.Caption = "Kalan Gün";
      this.colKalanGun.FieldName = "kalanGun";
      this.colKalanGun.Name = "colKalanGun";
      this.colKalanGun.Visible = true;
      this.colKalanGun.VisibleIndex = 7;
      this.colKalanGun.Width = 82;
      this.colCinsi.FieldName = "Cinsi";
      this.colCinsi.Name = "colCinsi";
      this.colCinsi.Visible = true;
      this.colCinsi.VisibleIndex = 3;
      this.colCinsi.Width = 128;
      this.colBelgeNo.Caption = "Belge No";
      this.colBelgeNo.FieldName = "belgoNo";
      this.colBelgeNo.Name = "colBelgeNo";
      this.colBelgeNo.Visible = true;
      this.colBelgeNo.VisibleIndex = 1;
      this.colBelgeNo.Width = 123;
      this.colMotorNo.Caption = "Motor No";
      this.colMotorNo.FieldName = "motorNo";
      this.colMotorNo.Name = "colMotorNo";
      this.colMotorNo.Visible = true;
      this.colMotorNo.VisibleIndex = 4;
      this.colMotorNo.Width = 135;
      this.colŞaseNo.Caption = "Şase No";
      this.colŞaseNo.FieldName = "saseNo";
      this.colŞaseNo.Name = "colŞaseNo";
      this.colŞaseNo.Visible = true;
      this.colŞaseNo.VisibleIndex = 5;
      this.colŞaseNo.Width = 123;
      this.BelediyeBirim.AutoHeight = false;
      this.BelediyeBirim.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BelediyeBirim.DataSource = (object) this.tBLBELDBIRIMLERBindingSource;
      this.BelediyeBirim.DisplayMember = "BELDBIRIMADI";
      this.BelediyeBirim.Name = "BelediyeBirim";
      this.BelediyeBirim.NullText = "";
      this.BelediyeBirim.ValueMember = "ID";
      this.tBLBELDBIRIMLERBindingSource.DataMember = "TBLBELDBIRIMLER";
      this.tBLBELDBIRIMLERBindingSource.DataSource = (object) this.bellDataSet7;
      this.BelediyeMudurluk.AutoHeight = false;
      this.BelediyeMudurluk.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.BelediyeMudurluk.DataSource = (object) this.tBLBELDMUDURLUKBindingSource;
      this.BelediyeMudurluk.DisplayMember = "BELDMUDURLUK";
      this.BelediyeMudurluk.Name = "BelediyeMudurluk";
      this.BelediyeMudurluk.NullText = "";
      this.BelediyeMudurluk.ValueMember = "ID";
      this.tBLBELDMUDURLUKBindingSource.DataMember = "TBLBELDMUDURLUK";
      this.tBLBELDMUDURLUKBindingSource.DataSource = (object) this.bellDataSet7;
      this.barCheckItem7.Id = 52;
      this.barCheckItem7.Name = "barCheckItem7";
      this.barCheckItem9.Id = 53;
      this.barCheckItem9.Name = "barCheckItem9";
      this.barCheckItem10.Id = 54;
      this.barCheckItem10.Name = "barCheckItem10";
      this.barCheckItem11.Id = 55;
      this.barCheckItem11.Name = "barCheckItem11";
      this.barCheckItem12.Id = 56;
      this.barCheckItem12.Name = "barCheckItem12";
      this.barCheckItem13.Id = 57;
      this.barCheckItem13.Name = "barCheckItem13";
      this.barCheckItem8.Id = 58;
      this.barCheckItem8.Name = "barCheckItem8";
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 31;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Id = 59;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem10.Id = 60;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem12.Caption = "Excel";
      this.barButtonItem12.Id = 35;
      this.barButtonItem12.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.Image");
      this.barButtonItem12.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem12.ImageOptions.LargeImage");
      this.barButtonItem12.LargeWidth = 100;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem12.ItemClick += new ItemClickEventHandler(this.barButtonItem12_ItemClick);
      this.barButtonItem11.Caption = "Kapat";
      this.barButtonItem11.Id = 61;
      this.barButtonItem11.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.Image");
      this.barButtonItem11.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.LargeImage");
      this.barButtonItem11.LargeWidth = 100;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.barEditItem6.Edit = (RepositoryItem) this.repositoryItemDateEdit1;
      this.barEditItem6.EditHeight = 25;
      this.barEditItem6.EditWidth = 140;
      this.barEditItem6.Id = 62;
      this.barEditItem6.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.barEditItem6.ItemAppearance.Normal.Options.UseFont = true;
      this.barEditItem6.Name = "barEditItem6";
      this.barEditItem6.EditValueChanged += new EventHandler(this.barEditItem6_EditValueChanged);
      this.repositoryItemDateEdit1.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemDateEdit1.Appearance.Options.UseFont = true;
      this.repositoryItemDateEdit1.AutoHeight = false;
      this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
      this.repositoryItemDateEdit1.NullText = "Başlangıç";
      this.barEditItem7.Edit = (RepositoryItem) this.repositoryItemDateEdit2;
      this.barEditItem7.EditHeight = 25;
      this.barEditItem7.EditWidth = 140;
      this.barEditItem7.Id = 63;
      this.barEditItem7.Name = "barEditItem7";
      this.barEditItem7.EditValueChanged += new EventHandler(this.barEditItem7_EditValueChanged);
      this.repositoryItemDateEdit2.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.repositoryItemDateEdit2.Appearance.Options.UseFont = true;
      this.repositoryItemDateEdit2.AutoHeight = false;
      this.repositoryItemDateEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
      this.repositoryItemDateEdit2.NullText = "Bitiş";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[4]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup6,
        this.ribbonPageGroup1,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem5);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barButtonItem12);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup1.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem11);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barEditItem6);
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barEditItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
      this.tBLARACLARBindingSource.DataMember = "TBLARACLAR";
      this.tBLARACLARBindingSource.DataSource = (object) this.aracSigortaKontrol;
      this.aracSigortaKontrol.DataSetName = "AracSigortaKontrol";
      this.aracSigortaKontrol.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
      this.tBLARACLARTableAdapter.ClearBeforeFill = true;
      this.tBLARACMARKATableAdapter.ClearBeforeFill = true;
      this.tBLBELDMUDURLUKTableAdapter.ClearBeforeFill = true;
      this.tBLBELDBIRIMLERTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1098, 501);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(2);
      this.Name = nameof (SigortaKontrolListesi);
      this.Text = "Sigorta Kontrol  Listesi";
      this.Load += new EventHandler(this.Form6_Load);
      this.repositoryItemCheckEdit1.EndInit();
      this.repositoryItemRadioGroup1.EndInit();
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl2.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.marka.EndInit();
      ((ISupportInitialize) this.tBLARACMARKABindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.BelediyeBirim.EndInit();
      ((ISupportInitialize) this.tBLBELDBIRIMLERBindingSource).EndInit();
      this.BelediyeMudurluk.EndInit();
      ((ISupportInitialize) this.tBLBELDMUDURLUKBindingSource).EndInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit1.EndInit();
      this.repositoryItemDateEdit2.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit2.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.repositoryItemRadioGroup2.EndInit();
      ((ISupportInitialize) this.tBLARACLARBindingSource).EndInit();
      this.aracSigortaKontrol.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}