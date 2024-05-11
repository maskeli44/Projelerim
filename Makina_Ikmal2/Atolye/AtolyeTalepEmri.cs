// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.AtolyeTalepEmri
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
using DevExpress.XtraLayout;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class AtolyeTalepEmri : XtraForm
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId son = new KullaniciSonId();
    private int id = YetkiClass.secim_id;
    private string kod = YetkiClass.secim_kodu;
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
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private EmptySpaceItem emptySpaceItem1;
    private SimpleButton simpleButton2;
    private PanelControl panelControl1;
    private PanelControl panelControl2;
    private PanelControl panelControl4;
    public GridControl gridControl2;
    private GridView gridView6;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    private PanelControl panelControl3;
    private SimpleButton simpleButton1;
    private SimpleButton simpleButton3;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn7;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private LayoutControl layoutControl1;
    private LayoutControl layoutControl4;
    private LayoutControlGroup layoutControlGroup3;
    private LayoutControl layoutControl3;
    private LayoutControlGroup layoutControlGroup2;
    private SearchLookUpEdit bakimTuruLook;
    private GridView searchLookUpEdit6View;
    private SearchLookUpEdit isEmriDurumLook;
    private GridView searchLookUpEdit5View;
    private MemoEdit bakimOzetiText;
    private SearchLookUpEdit atolyeSefiLook;
    private GridView searchLookUpEdit4View;
    private TextEdit hidrolikYagText;
    private TextEdit diferansiyelYagText;
    private TextEdit sanzimanYagText;
    private SearchLookUpEdit arizaNedeniLook;
    private GridView searchLookUpEdit3View;
    private MemoEdit bildirilenArizaText;
    private TextEdit motorYagText;
    private TextEdit bakimKmSaatText;
    private TimeEdit cikisSaat;
    private DateEdit cikisTarihi;
    private TextEdit genelBakimText;
    private TextEdit bakimYerAdiText;
    private TimeEdit girisSaat;
    private DateEdit girisTarih;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LabelControl labelControl1;
    private SearchLookUpEdit bakimYeriLook;
    private GridView searchLookUpEdit2View;
    private TextEdit isEmriNoText;
    private TextEdit isEmriText;
    private SearchLookUpEdit atolyeBolumLook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem2;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private LayoutControlItem layoutControlItem10;
    private LayoutControlItem layoutControlItem11;
    private LayoutControlItem layoutControlItem12;
    private LayoutControlItem layoutControlItem13;
    private LayoutControlItem layoutControlItem14;
    private LayoutControlItem layoutControlItem15;
    private LayoutControlItem layoutControlItem16;
    private LayoutControlItem layoutControlItem17;
    private LayoutControlItem layoutControlItem20;
    private LayoutControlItem layoutControlItem21;
    private LayoutControlItem layoutControlItem22;
    private LayoutControlItem layoutControlItem23;
    private LayoutControlItem layoutControlItem19;
    private LayoutControlItem layoutControlItem24;
    private LayoutControlItem layoutControlItem18;
    private LayoutControlItem layoutControlItem25;
    private SearchLookUpEdit bakimDerecesiLook;
    private GridView gridView1;
    private LayoutControlItem layoutControlItem26;

    public AtolyeTalepEmri() => this.InitializeComponent();

    private void Ekle2_Load(object sender, EventArgs e)
    {
    }

    private void textEdit1_EditValueChanged(object sender, EventArgs e)
    {
      this.degerleri();
      switch (YetkiClass.secim)
      {
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void degerleri()
    {
      try
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void kayit()
    {
      try
      {
        TBLISEMRI entity = new TBLISEMRI();
        entity.KOD = this.son.isemirkod().ToString();
        try
        {
          entity.ATOLYEID = new int?(Convert.ToInt32(this.atolyeBolumLook.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.ISEMRISIRANO = new int?(Convert.ToInt32(this.isEmriNoText.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BAKIMYERIID = new int?(Convert.ToInt32(this.bakimYeriLook.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.GIRISTARIH = new DateTime?(Convert.ToDateTime(this.girisTarih.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.GIRISSAAT = new DateTime?(Convert.ToDateTime(this.girisSaat.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.CIKISTARIH = new DateTime?(Convert.ToDateTime(this.cikisTarihi.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.CIKISSAAT = new DateTime?(Convert.ToDateTime(this.cikisSaat.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BILDIRILENARIZA = this.bildirilenArizaText.Text;
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.ISEMRIDURUMID = new int?(Convert.ToInt32(this.isEmriDurumLook.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BAKIMTURUID = this.bakimTuruLook.Text;
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BAKIMYERACKLM = this.bakimYerAdiText.Text;
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BAKIMKMSI = this.bakimKmSaatText.Text;
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.ARIZANEDENIID = new int?(Convert.ToInt32(this.arizaNedeniLook.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.IMZAATOLYESEFID = new int?(Convert.ToInt32(this.atolyeSefiLook.EditValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.YAPILANBAKIMOZETI = this.bakimOzetiText.Text;
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.BAKIMDERECESIID = this.bakimDerecesiLook.Text;
        }
        catch (Exception ex)
        {
        }
        this.db.TBLISEMRI.Add(entity);
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt Tamam");
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void guncelle()
    {
      try
      {
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void sil()
    {
      TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<Func<TBLISEMRI, bool>>) (x => x.KOD == this.kod));
      IQueryable<TBLISEMRIBAKIMLAR> source = this.db.TBLISEMRIBAKIMLAR.Where<TBLISEMRIBAKIMLAR>((Expression<Func<TBLISEMRIBAKIMLAR, bool>>) (deg => deg.ISEMRIID == (int?) ise.ID));
      try
      {
        if (source.Any<TBLISEMRIBAKIMLAR>())
        {
          foreach (TBLISEMRIBAKIMLAR tblisemribakimlar in (IEnumerable<TBLISEMRIBAKIMLAR>) source)
          {
            TBLISEMRIBAKIMLAR item = tblisemribakimlar;
            TBLISEMRIBAKIMLAR entity = this.db.TBLISEMRIBAKIMLAR.FirstOrDefault<TBLISEMRIBAKIMLAR>((Expression<Func<TBLISEMRIBAKIMLAR, bool>>) (x => x.ID == item.ID));
            int num = (int) XtraMessageBox.Show(entity.ID.ToString());
            this.db.TBLISEMRIBAKIMLAR.Remove(entity);
          }
          this.db.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
      this.db.TBLISEMRI.Remove(ise);
      this.db.SaveChanges();
      ((ilksayfa) Application.OpenForms["ilksayfa"])?.listele();
      this.Close();
    }

    private void listele()
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
      {
        this.kayit();
        LogEkle.Logs("Ekleme Yapti");
      }
      else if (YetkiClass.secim == "guncelle")
      {
        this.guncelle();
        LogEkle.Logs("Guncelleme Yapti");
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Kayıt yokkkkkk");
      }
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.sil();

    private void guncelleload()
    {
      DegerAktarma.list.Clear();
      TBLISEMRI ise = this.db.TBLISEMRI.FirstOrDefault<TBLISEMRI>((Expression<Func<TBLISEMRI, bool>>) (x => x.KOD == this.kod));
      DbSet<TBLISEMRIBAKIMLAR> tblisemribakimlar1 = this.db.TBLISEMRIBAKIMLAR;
      Expression<Func<TBLISEMRIBAKIMLAR, bool>> predicate = (Expression<Func<TBLISEMRIBAKIMLAR, bool>>) (hd => hd.ISEMRIID == (int?) ise.ID);
      foreach (TBLISEMRIBAKIMLAR tblisemribakimlar2 in (IEnumerable<TBLISEMRIBAKIMLAR>) tblisemribakimlar1.Where<TBLISEMRIBAKIMLAR>(predicate))
        DegerAktarma.list.Add(new Makina_Ikmal.Classlar.ElemanlarDurum()
        {
          ID = tblisemribakimlar2.ID,
          ATOLYEID = tblisemribakimlar2.ATOLYEID.ToString(),
          BAKIMYAPUSTAID = tblisemribakimlar2.BAKIMYAPUSTAID.ToString(),
          BAKIMGRUBUID = tblisemribakimlar2.BAKIMGRUBUID.ToString(),
          YAPILANBAKIM = tblisemribakimlar2.YAPILANBAKIM
        });
      this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
      try
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new Ustalar().ShowDialog();
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
    }

    public void tetikle()
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
    }

    private void gridView6_ValidateRow(object sender, ValidateRowEventArgs e)
    {
      if (this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, this.gridView1.FocusedColumn) != null)
        return;
      if (this.gridView1.IsValidRowHandle(e.RowHandle))
        this.gridView1.DeleteRow(e.RowHandle);
      e.Valid = true;
    }

    private void simpleButton1_Click_1(object sender, EventArgs e)
    {
      int num = (int) new Ustalar().ShowDialog();
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void simpleButton1_Click_2(object sender, EventArgs e)
    {
      int num = (int) new Ustalar2().ShowDialog();
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      if (Convert.ToInt32(this.gridView6.GetFocusedRowCellValue("ID")) == 0 || this.gridView6.GetFocusedRowCellValue("ID") == null)
      {
        this.gridView1.DeleteSelectedRows();
        string id2 = Convert.ToString(this.gridView6.GetFocusedRowCellValue("BAKIMYAPUSTAID"));
        Makina_Ikmal.Classlar.ElemanlarDurum elemanlarDurum = DegerAktarma.list.FirstOrDefault<Makina_Ikmal.Classlar.ElemanlarDurum>((Func<Makina_Ikmal.Classlar.ElemanlarDurum, bool>) (x => x.BAKIMYAPUSTAID == id2));
        DegerAktarma.list.Remove(elemanlarDurum);
        this.gridControl2.DataSource = (object) DegerAktarma.list.ToList<Makina_Ikmal.Classlar.ElemanlarDurum>();
      }
      else
      {
        int id = Convert.ToInt32(this.gridView6.GetFocusedRowCellValue("ID"));
        this.db.TBLISEMRIBAKIMLAR.Remove(this.db.TBLISEMRIBAKIMLAR.FirstOrDefault<TBLISEMRIBAKIMLAR>((Expression<Func<TBLISEMRIBAKIMLAR, bool>>) (x => x.ID == id)));
        this.db.SaveChanges();
        this.guncelleload();
      }
    }

    private void searchLookUpEdit1View_CellValueChanged(object sender, CellValueChangedEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AtolyeTalepEmri));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barCheckItem1 = new BarCheckItem();
      this.barCheckItem2 = new BarCheckItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.simpleButton2 = new SimpleButton();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.panelControl1 = new PanelControl();
      this.panelControl2 = new PanelControl();
      this.panelControl4 = new PanelControl();
      this.gridControl2 = new GridControl();
      this.gridView6 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.gridColumn3 = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.gridColumn4 = new GridColumn();
      this.repositoryItemLookUpEdit3 = new RepositoryItemLookUpEdit();
      this.gridColumn5 = new GridColumn();
      this.gridColumn7 = new GridColumn();
      this.panelControl3 = new PanelControl();
      this.simpleButton3 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.layoutControl1 = new LayoutControl();
      this.layoutControl4 = new LayoutControl();
      this.layoutControlGroup3 = new LayoutControlGroup();
      this.layoutControl3 = new LayoutControl();
      this.layoutControlGroup2 = new LayoutControlGroup();
      this.bakimTuruLook = new SearchLookUpEdit();
      this.searchLookUpEdit6View = new GridView();
      this.isEmriDurumLook = new SearchLookUpEdit();
      this.searchLookUpEdit5View = new GridView();
      this.bakimOzetiText = new MemoEdit();
      this.atolyeSefiLook = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.hidrolikYagText = new TextEdit();
      this.diferansiyelYagText = new TextEdit();
      this.sanzimanYagText = new TextEdit();
      this.arizaNedeniLook = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.bildirilenArizaText = new MemoEdit();
      this.motorYagText = new TextEdit();
      this.bakimKmSaatText = new TextEdit();
      this.cikisSaat = new TimeEdit();
      this.cikisTarihi = new DateEdit();
      this.genelBakimText = new TextEdit();
      this.bakimYerAdiText = new TextEdit();
      this.girisSaat = new TimeEdit();
      this.girisTarih = new DateEdit();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.labelControl1 = new LabelControl();
      this.bakimYeriLook = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.isEmriNoText = new TextEdit();
      this.isEmriText = new TextEdit();
      this.atolyeBolumLook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem2 = new EmptySpaceItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.layoutControlItem11 = new LayoutControlItem();
      this.layoutControlItem12 = new LayoutControlItem();
      this.layoutControlItem13 = new LayoutControlItem();
      this.layoutControlItem14 = new LayoutControlItem();
      this.layoutControlItem15 = new LayoutControlItem();
      this.layoutControlItem16 = new LayoutControlItem();
      this.layoutControlItem17 = new LayoutControlItem();
      this.layoutControlItem20 = new LayoutControlItem();
      this.layoutControlItem21 = new LayoutControlItem();
      this.layoutControlItem22 = new LayoutControlItem();
      this.layoutControlItem23 = new LayoutControlItem();
      this.layoutControlItem19 = new LayoutControlItem();
      this.layoutControlItem24 = new LayoutControlItem();
      this.layoutControlItem18 = new LayoutControlItem();
      this.layoutControlItem25 = new LayoutControlItem();
      this.bakimDerecesiLook = new SearchLookUpEdit();
      this.layoutControlItem26 = new LayoutControlItem();
      this.gridView1 = new GridView();
      this.ribbonControl1.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.panelControl4.BeginInit();
      this.panelControl4.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView6.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      this.repositoryItemLookUpEdit3.BeginInit();
      this.panelControl3.BeginInit();
      this.panelControl3.SuspendLayout();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.layoutControl4.BeginInit();
      this.layoutControlGroup3.BeginInit();
      this.layoutControl3.BeginInit();
      this.layoutControlGroup2.BeginInit();
      this.bakimTuruLook.Properties.BeginInit();
      this.searchLookUpEdit6View.BeginInit();
      this.isEmriDurumLook.Properties.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.bakimOzetiText.Properties.BeginInit();
      this.atolyeSefiLook.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.hidrolikYagText.Properties.BeginInit();
      this.diferansiyelYagText.Properties.BeginInit();
      this.sanzimanYagText.Properties.BeginInit();
      this.arizaNedeniLook.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.bildirilenArizaText.Properties.BeginInit();
      this.motorYagText.Properties.BeginInit();
      this.bakimKmSaatText.Properties.BeginInit();
      this.cikisSaat.Properties.BeginInit();
      this.cikisTarihi.Properties.CalendarTimeProperties.BeginInit();
      this.cikisTarihi.Properties.BeginInit();
      this.genelBakimText.Properties.BeginInit();
      this.bakimYerAdiText.Properties.BeginInit();
      this.girisSaat.Properties.BeginInit();
      this.girisTarih.Properties.CalendarTimeProperties.BeginInit();
      this.girisTarih.Properties.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.bakimYeriLook.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.isEmriNoText.Properties.BeginInit();
      this.isEmriText.Properties.BeginInit();
      this.atolyeBolumLook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem2.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.layoutControlItem11.BeginInit();
      this.layoutControlItem12.BeginInit();
      this.layoutControlItem13.BeginInit();
      this.layoutControlItem14.BeginInit();
      this.layoutControlItem15.BeginInit();
      this.layoutControlItem16.BeginInit();
      this.layoutControlItem17.BeginInit();
      this.layoutControlItem20.BeginInit();
      this.layoutControlItem21.BeginInit();
      this.layoutControlItem22.BeginInit();
      this.layoutControlItem23.BeginInit();
      this.layoutControlItem19.BeginInit();
      this.layoutControlItem24.BeginInit();
      this.layoutControlItem18.BeginInit();
      this.layoutControlItem25.BeginInit();
      this.bakimDerecesiLook.Properties.BeginInit();
      this.layoutControlItem26.BeginInit();
      this.gridView1.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[11]
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
        (BarItem) this.barCheckItem1,
        (BarItem) this.barCheckItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 10;
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
      this.ribbonControl1.Size = new Size(1130, 118);
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
      this.barButtonItem3.Enabled = false;
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Önizle";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) Resources.preview_16x161;
      this.barButtonItem4.ImageOptions.LargeImage = (Image) Resources.preview_32x321;
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem5.Caption = "Yazdır";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) Resources.printer_16x161;
      this.barButtonItem5.ImageOptions.LargeImage = (Image) Resources.printer_32x321;
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
      this.barCheckItem1.Caption = "Fiş";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem1.Id = 8;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "A4";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.CheckStyle = BarCheckStyles.Radio;
      this.barCheckItem2.Id = 9;
      this.barCheckItem2.Name = "barCheckItem2";
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barCheckItem2);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barCheckItem1);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.simpleButton2.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton2.Appearance.Font = new Font("Tahoma", 16.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton2.Appearance.Options.UseBackColor = true;
      this.simpleButton2.Appearance.Options.UseBorderColor = true;
      this.simpleButton2.Appearance.Options.UseFont = true;
      this.simpleButton2.Appearance.Options.UseTextOptions = true;
      this.simpleButton2.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.simpleButton2.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(-17, 181);
      this.simpleButton2.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.PaintStyle = PaintStyles.Light;
      this.simpleButton2.Size = new Size(66, 62);
      this.simpleButton2.TabIndex = 49;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(736, 145);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(338, 10);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(63, 185);
      this.panelControl1.Margin = new Padding(3, 2, 3, 2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1065, 164);
      this.panelControl1.TabIndex = 5;
      this.panelControl2.Controls.Add((Control) this.panelControl4);
      this.panelControl2.Controls.Add((Control) this.panelControl1);
      this.panelControl2.Controls.Add((Control) this.panelControl3);
      this.panelControl2.Controls.Add((Control) this.simpleButton2);
      this.panelControl2.Dock = DockStyle.Bottom;
      this.panelControl2.Location = new Point(0, 449);
      this.panelControl2.Margin = new Padding(3, 2, 3, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(1130, 351);
      this.panelControl2.TabIndex = 6;
      this.panelControl4.Controls.Add((Control) this.gridControl2);
      this.panelControl4.Dock = DockStyle.Top;
      this.panelControl4.Location = new Point(63, 2);
      this.panelControl4.Margin = new Padding(3, 2, 3, 2);
      this.panelControl4.Name = "panelControl4";
      this.panelControl4.Size = new Size(1065, 181);
      this.panelControl4.TabIndex = 1;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Location = new Point(2, 2);
      this.gridControl2.MainView = (BaseView) this.gridView6;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.repositoryItemLookUpEdit2,
        (RepositoryItem) this.repositoryItemLookUpEdit3
      });
      this.gridControl2.Size = new Size(1061, 177);
      this.gridControl2.TabIndex = 5;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView6
      });
      this.gridView6.Appearance.GroupPanel.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView6.Appearance.GroupPanel.Options.UseFont = true;
      this.gridView6.Columns.AddRange(new GridColumn[5]
      {
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn7
      });
      this.gridView6.GridControl = this.gridControl2;
      this.gridView6.Name = "gridView6";
      this.gridView6.OptionsView.AllowHtmlDrawGroups = false;
      this.gridView6.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Atolye";
      this.gridColumn2.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn2.FieldName = "ATOLYEID";
      this.gridColumn2.MinWidth = 25;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn2.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DisplayMember = "BOLUMADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.gridColumn3.Caption = "Usta";
      this.gridColumn3.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit2;
      this.gridColumn3.FieldName = "BAKIMYAPUSTAID";
      this.gridColumn3.MinWidth = 25;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 1;
      this.gridColumn3.Width = 94;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DisplayMember = "USTAADISOYADI";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.gridColumn4.Caption = "Bakım Grubu";
      this.gridColumn4.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit3;
      this.gridColumn4.FieldName = "BAKIMGRUBUID";
      this.gridColumn4.MinWidth = 25;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 2;
      this.gridColumn4.Width = 94;
      this.repositoryItemLookUpEdit3.AutoHeight = false;
      this.repositoryItemLookUpEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit3.DisplayMember = "GRUPADI";
      this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
      this.repositoryItemLookUpEdit3.ValueMember = "ID";
      this.gridColumn5.Caption = "Yapılan Bakım";
      this.gridColumn5.FieldName = "YAPILANBAKIM";
      this.gridColumn5.MinWidth = 25;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 3;
      this.gridColumn5.Width = 94;
      this.gridColumn7.Caption = "gridColumn7";
      this.gridColumn7.FieldName = "ID";
      this.gridColumn7.MinWidth = 25;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Width = 94;
      this.panelControl3.Controls.Add((Control) this.simpleButton3);
      this.panelControl3.Controls.Add((Control) this.simpleButton1);
      this.panelControl3.Dock = DockStyle.Left;
      this.panelControl3.Location = new Point(2, 2);
      this.panelControl3.Margin = new Padding(3, 2, 3, 2);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new Size(61, 347);
      this.panelControl3.TabIndex = 0;
      this.simpleButton3.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton3.Appearance.Options.UseBackColor = true;
      this.simpleButton3.Appearance.Options.UseBorderColor = true;
      this.simpleButton3.Appearance.Options.UseFont = true;
      this.simpleButton3.AppearanceDisabled.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.AppearanceDisabled.Options.UseBorderColor = true;
      this.simpleButton3.AppearanceHovered.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton3.Location = new Point(-2, 96);
      this.simpleButton3.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(61, 85);
      this.simpleButton3.TabIndex = 50;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.simpleButton1.Appearance.BackColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.BackColor2 = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton1.Appearance.Options.UseBackColor = true;
      this.simpleButton1.Appearance.Options.UseBorderColor = true;
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.AppearanceDisabled.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.AppearanceDisabled.Options.UseBorderColor = true;
      this.simpleButton1.AppearanceHovered.BorderColor = Color.FromArgb(240, 240, 240);
      this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(0, 5);
      this.simpleButton1.Margin = new Padding(3, 2, 3, 2);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(61, 85);
      this.simpleButton1.TabIndex = 49;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click_2);
      this.layoutControl1.Controls.Add((Control) this.bakimDerecesiLook);
      this.layoutControl1.Controls.Add((Control) this.layoutControl4);
      this.layoutControl1.Controls.Add((Control) this.layoutControl3);
      this.layoutControl1.Controls.Add((Control) this.bakimTuruLook);
      this.layoutControl1.Controls.Add((Control) this.isEmriDurumLook);
      this.layoutControl1.Controls.Add((Control) this.bakimOzetiText);
      this.layoutControl1.Controls.Add((Control) this.atolyeSefiLook);
      this.layoutControl1.Controls.Add((Control) this.hidrolikYagText);
      this.layoutControl1.Controls.Add((Control) this.diferansiyelYagText);
      this.layoutControl1.Controls.Add((Control) this.sanzimanYagText);
      this.layoutControl1.Controls.Add((Control) this.arizaNedeniLook);
      this.layoutControl1.Controls.Add((Control) this.bildirilenArizaText);
      this.layoutControl1.Controls.Add((Control) this.motorYagText);
      this.layoutControl1.Controls.Add((Control) this.bakimKmSaatText);
      this.layoutControl1.Controls.Add((Control) this.cikisSaat);
      this.layoutControl1.Controls.Add((Control) this.cikisTarihi);
      this.layoutControl1.Controls.Add((Control) this.genelBakimText);
      this.layoutControl1.Controls.Add((Control) this.bakimYerAdiText);
      this.layoutControl1.Controls.Add((Control) this.girisSaat);
      this.layoutControl1.Controls.Add((Control) this.girisTarih);
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.labelControl1);
      this.layoutControl1.Controls.Add((Control) this.bakimYeriLook);
      this.layoutControl1.Controls.Add((Control) this.isEmriNoText);
      this.layoutControl1.Controls.Add((Control) this.isEmriText);
      this.layoutControl1.Controls.Add((Control) this.atolyeBolumLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1130, 331);
      this.layoutControl1.TabIndex = 10;
      this.layoutControl1.Text = "layoutControl1";
      this.layoutControl4.Location = new Point(567, 12);
      this.layoutControl4.Name = "layoutControl4";
      this.layoutControl4.Root = this.layoutControlGroup3;
      this.layoutControl4.Size = new Size(551, 28);
      this.layoutControl4.TabIndex = 30;
      this.layoutControl4.Text = "layoutControl4";
      this.layoutControlGroup3.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new Size(551, 28);
      this.layoutControlGroup3.TextVisible = false;
      this.layoutControl3.Location = new Point(848, 68);
      this.layoutControl3.Name = "layoutControl3";
      this.layoutControl3.Root = this.layoutControlGroup2;
      this.layoutControl3.Size = new Size(20, 185);
      this.layoutControl3.TabIndex = 29;
      this.layoutControl3.Text = "layoutControl3";
      this.layoutControlGroup2.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new Size(20, 185);
      this.layoutControlGroup2.TextVisible = false;
      this.bakimTuruLook.Location = new Point(147, 257);
      this.bakimTuruLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimTuruLook.Name = "bakimTuruLook";
      this.bakimTuruLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimTuruLook.Properties.Appearance.Options.UseFont = true;
      this.bakimTuruLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimTuruLook.Properties.NullText = "";
      this.bakimTuruLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit6View;
      this.bakimTuruLook.Size = new Size(376, 28);
      this.bakimTuruLook.StyleController = (IStyleController) this.layoutControl1;
      this.bakimTuruLook.TabIndex = 28;
      this.searchLookUpEdit6View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit6View.Name = "searchLookUpEdit6View";
      this.searchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
      this.isEmriDurumLook.Location = new Point(147, 225);
      this.isEmriDurumLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isEmriDurumLook.Name = "isEmriDurumLook";
      this.isEmriDurumLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isEmriDurumLook.Properties.Appearance.Options.UseFont = true;
      this.isEmriDurumLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.isEmriDurumLook.Properties.NullText = "";
      this.isEmriDurumLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.isEmriDurumLook.Size = new Size(376, 28);
      this.isEmriDurumLook.StyleController = (IStyleController) this.layoutControl1;
      this.isEmriDurumLook.TabIndex = 27;
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.bakimOzetiText.Enabled = false;
      this.bakimOzetiText.Location = new Point(662, 222);
      this.bakimOzetiText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimOzetiText.Name = "bakimOzetiText";
      this.bakimOzetiText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimOzetiText.Properties.Appearance.Options.UseFont = true;
      this.bakimOzetiText.Size = new Size(182, 31);
      this.bakimOzetiText.StyleController = (IStyleController) this.layoutControl1;
      this.bakimOzetiText.TabIndex = 26;
      this.atolyeSefiLook.Location = new Point(662, 190);
      this.atolyeSefiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyeSefiLook.Name = "atolyeSefiLook";
      this.atolyeSefiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyeSefiLook.Properties.Appearance.Options.UseFont = true;
      this.atolyeSefiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyeSefiLook.Properties.NullText = "";
      this.atolyeSefiLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.atolyeSefiLook.Size = new Size(182, 28);
      this.atolyeSefiLook.StyleController = (IStyleController) this.layoutControl1;
      this.atolyeSefiLook.TabIndex = 25;
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.hidrolikYagText.Location = new Point(1007, 257);
      this.hidrolikYagText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.hidrolikYagText.Name = "hidrolikYagText";
      this.hidrolikYagText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.hidrolikYagText.Properties.Appearance.Options.UseFont = true;
      this.hidrolikYagText.Size = new Size(111, 28);
      this.hidrolikYagText.StyleController = (IStyleController) this.layoutControl1;
      this.hidrolikYagText.TabIndex = 24;
      this.diferansiyelYagText.Location = new Point(1007, 225);
      this.diferansiyelYagText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.diferansiyelYagText.Name = "diferansiyelYagText";
      this.diferansiyelYagText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.diferansiyelYagText.Properties.Appearance.Options.UseFont = true;
      this.diferansiyelYagText.Size = new Size(111, 28);
      this.diferansiyelYagText.StyleController = (IStyleController) this.layoutControl1;
      this.diferansiyelYagText.TabIndex = 23;
      this.sanzimanYagText.Location = new Point(1007, 193);
      this.sanzimanYagText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.sanzimanYagText.Name = "sanzimanYagText";
      this.sanzimanYagText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sanzimanYagText.Properties.Appearance.Options.UseFont = true;
      this.sanzimanYagText.Size = new Size(111, 28);
      this.sanzimanYagText.StyleController = (IStyleController) this.layoutControl1;
      this.sanzimanYagText.TabIndex = 20;
      this.arizaNedeniLook.Enabled = false;
      this.arizaNedeniLook.Location = new Point(662, 158);
      this.arizaNedeniLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.arizaNedeniLook.Name = "arizaNedeniLook";
      this.arizaNedeniLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.arizaNedeniLook.Properties.Appearance.Options.UseFont = true;
      this.arizaNedeniLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.arizaNedeniLook.Properties.NullText = "";
      this.arizaNedeniLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.arizaNedeniLook.Size = new Size(182, 28);
      this.arizaNedeniLook.StyleController = (IStyleController) this.layoutControl1;
      this.arizaNedeniLook.TabIndex = 19;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.bildirilenArizaText.Location = new Point(147, 164);
      this.bildirilenArizaText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bildirilenArizaText.Name = "bildirilenArizaText";
      this.bildirilenArizaText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bildirilenArizaText.Properties.Appearance.Options.UseFont = true;
      this.bildirilenArizaText.Size = new Size(376, 57);
      this.bildirilenArizaText.StyleController = (IStyleController) this.layoutControl1;
      this.bildirilenArizaText.TabIndex = 18;
      this.motorYagText.Location = new Point(1007, 161);
      this.motorYagText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.motorYagText.Name = "motorYagText";
      this.motorYagText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.motorYagText.Properties.Appearance.Options.UseFont = true;
      this.motorYagText.Size = new Size(111, 28);
      this.motorYagText.StyleController = (IStyleController) this.layoutControl1;
      this.motorYagText.TabIndex = 17;
      this.bakimKmSaatText.Enabled = false;
      this.bakimKmSaatText.Location = new Point(662, 126);
      this.bakimKmSaatText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimKmSaatText.Name = "bakimKmSaatText";
      this.bakimKmSaatText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimKmSaatText.Properties.Appearance.Options.UseFont = true;
      this.bakimKmSaatText.Size = new Size(182, 28);
      this.bakimKmSaatText.StyleController = (IStyleController) this.layoutControl1;
      this.bakimKmSaatText.TabIndex = 16;
      this.cikisSaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.cikisSaat.Location = new Point(409, 132);
      this.cikisSaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikisSaat.Name = "cikisSaat";
      this.cikisSaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cikisSaat.Properties.Appearance.Options.UseFont = true;
      this.cikisSaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisSaat.Size = new Size(114, 28);
      this.cikisSaat.StyleController = (IStyleController) this.layoutControl1;
      this.cikisSaat.TabIndex = 15;
      this.cikisTarihi.EditValue = (object) null;
      this.cikisTarihi.Location = new Point(147, 132);
      this.cikisTarihi.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.cikisTarihi.Name = "cikisTarihi";
      this.cikisTarihi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cikisTarihi.Properties.Appearance.Options.UseFont = true;
      this.cikisTarihi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.cikisTarihi.Size = new Size(123, 28);
      this.cikisTarihi.StyleController = (IStyleController) this.layoutControl1;
      this.cikisTarihi.TabIndex = 14;
      this.genelBakimText.Enabled = false;
      this.genelBakimText.Location = new Point(1007, 129);
      this.genelBakimText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelBakimText.Name = "genelBakimText";
      this.genelBakimText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelBakimText.Properties.Appearance.Options.UseFont = true;
      this.genelBakimText.Size = new Size(111, 28);
      this.genelBakimText.StyleController = (IStyleController) this.layoutControl1;
      this.genelBakimText.TabIndex = 13;
      this.bakimYerAdiText.Enabled = false;
      this.bakimYerAdiText.Location = new Point(662, 94);
      this.bakimYerAdiText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimYerAdiText.Name = "bakimYerAdiText";
      this.bakimYerAdiText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimYerAdiText.Properties.Appearance.Options.UseFont = true;
      this.bakimYerAdiText.Size = new Size(182, 28);
      this.bakimYerAdiText.StyleController = (IStyleController) this.layoutControl1;
      this.bakimYerAdiText.TabIndex = 12;
      this.girisSaat.EditValue = (object) new DateTime(2022, 1, 1, 0, 0, 0, 0);
      this.girisSaat.Location = new Point(409, 100);
      this.girisSaat.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.girisSaat.Name = "girisSaat";
      this.girisSaat.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girisSaat.Properties.Appearance.Options.UseFont = true;
      this.girisSaat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girisSaat.Size = new Size(114, 28);
      this.girisSaat.StyleController = (IStyleController) this.layoutControl1;
      this.girisSaat.TabIndex = 11;
      this.girisTarih.EditValue = (object) null;
      this.girisTarih.Location = new Point(147, 100);
      this.girisTarih.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.girisTarih.Name = "girisTarih";
      this.girisTarih.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girisTarih.Properties.Appearance.Options.UseFont = true;
      this.girisTarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girisTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.girisTarih.Size = new Size(123, 28);
      this.girisTarih.StyleController = (IStyleController) this.layoutControl1;
      this.girisTarih.TabIndex = 10;
      this.layoutControl2.Location = new Point(12, 44);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(1106, 20);
      this.layoutControl2.TabIndex = 9;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(1106, 20);
      this.layoutControlGroup1.TextVisible = false;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(872, 68);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(246, 57);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl1;
      this.labelControl1.TabIndex = 8;
      this.labelControl1.Text = "Sonraki Bakım Kilometre Bilgileri";
      this.bakimYeriLook.Location = new Point(662, 68);
      this.bakimYeriLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimYeriLook.Name = "bakimYeriLook";
      this.bakimYeriLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimYeriLook.Properties.Appearance.Options.UseFont = true;
      this.bakimYeriLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimYeriLook.Properties.NullText = "";
      this.bakimYeriLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.bakimYeriLook.Size = new Size(182, 28);
      this.bakimYeriLook.StyleController = (IStyleController) this.layoutControl1;
      this.bakimYeriLook.TabIndex = 7;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.isEmriNoText.Enabled = false;
      this.isEmriNoText.Location = new Point(409, 68);
      this.isEmriNoText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isEmriNoText.Name = "isEmriNoText";
      this.isEmriNoText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isEmriNoText.Properties.Appearance.Options.UseFont = true;
      this.isEmriNoText.Size = new Size(114, 28);
      this.isEmriNoText.StyleController = (IStyleController) this.layoutControl1;
      this.isEmriNoText.TabIndex = 6;
      this.isEmriText.Enabled = false;
      this.isEmriText.Location = new Point(147, 68);
      this.isEmriText.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isEmriText.Name = "isEmriText";
      this.isEmriText.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isEmriText.Properties.Appearance.Options.UseFont = true;
      this.isEmriText.Size = new Size(123, 28);
      this.isEmriText.StyleController = (IStyleController) this.layoutControl1;
      this.isEmriText.TabIndex = 5;
      this.atolyeBolumLook.EditValue = (object) "[EditValu";
      this.atolyeBolumLook.Location = new Point(147, 12);
      this.atolyeBolumLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyeBolumLook.Name = "atolyeBolumLook";
      this.atolyeBolumLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyeBolumLook.Properties.Appearance.Options.UseFont = true;
      this.atolyeBolumLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyeBolumLook.Properties.NullText = "";
      this.atolyeBolumLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.atolyeBolumLook.Size = new Size(416, 28);
      this.atolyeBolumLook.StyleController = (IStyleController) this.layoutControl1;
      this.atolyeBolumLook.TabIndex = 4;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[27]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem2,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10,
        (BaseLayoutItem) this.layoutControlItem11,
        (BaseLayoutItem) this.layoutControlItem12,
        (BaseLayoutItem) this.layoutControlItem13,
        (BaseLayoutItem) this.layoutControlItem14,
        (BaseLayoutItem) this.layoutControlItem15,
        (BaseLayoutItem) this.layoutControlItem16,
        (BaseLayoutItem) this.layoutControlItem17,
        (BaseLayoutItem) this.layoutControlItem20,
        (BaseLayoutItem) this.layoutControlItem21,
        (BaseLayoutItem) this.layoutControlItem22,
        (BaseLayoutItem) this.layoutControlItem23,
        (BaseLayoutItem) this.layoutControlItem19,
        (BaseLayoutItem) this.layoutControlItem24,
        (BaseLayoutItem) this.layoutControlItem18,
        (BaseLayoutItem) this.layoutControlItem25,
        (BaseLayoutItem) this.layoutControlItem26
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1130, 331);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.atolyeBolumLook;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(555, 32);
      this.layoutControlItem1.Text = "Atölye Bölüm";
      this.layoutControlItem1.TextSize = new Size(132, 22);
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new Point(0, 277);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new Size(1110, 34);
      this.emptySpaceItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.isEmriText;
      this.layoutControlItem2.Enabled = false;
      this.layoutControlItem2.Location = new Point(0, 56);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(262, 32);
      this.layoutControlItem2.Text = "İş Emri Kod";
      this.layoutControlItem2.TextSize = new Size(132, 22);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.isEmriNoText;
      this.layoutControlItem3.Enabled = false;
      this.layoutControlItem3.Location = new Point(262, 56);
      this.layoutControlItem3.MinSize = new Size(210, 32);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(253, 32);
      this.layoutControlItem3.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem3.Text = "NO";
      this.layoutControlItem3.TextSize = new Size(132, 22);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.bakimYeriLook;
      this.layoutControlItem4.Location = new Point(515, 56);
      this.layoutControlItem4.MinSize = new Size(186, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(321, 26);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "Bakım Yeri";
      this.layoutControlItem4.TextSize = new Size(132, 22);
      this.layoutControlItem5.Control = (Control) this.labelControl1;
      this.layoutControlItem5.Location = new Point(860, 56);
      this.layoutControlItem5.MinSize = new Size(79, 20);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(250, 61);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.layoutControlItem6.Control = (Control) this.layoutControl2;
      this.layoutControlItem6.Location = new Point(0, 32);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(1110, 24);
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.girisTarih;
      this.layoutControlItem7.CustomizationFormText = "Giriş Tarihi";
      this.layoutControlItem7.Location = new Point(0, 88);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(262, 32);
      this.layoutControlItem7.Text = "Giriş Tarihi";
      this.layoutControlItem7.TextSize = new Size(132, 22);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.girisSaat;
      this.layoutControlItem8.Location = new Point(262, 88);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(253, 32);
      this.layoutControlItem8.Text = "Saat";
      this.layoutControlItem8.TextSize = new Size(132, 22);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.bakimYerAdiText;
      this.layoutControlItem9.Enabled = false;
      this.layoutControlItem9.Location = new Point(515, 82);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(321, 32);
      this.layoutControlItem9.Text = "Bakım Yer Adı";
      this.layoutControlItem9.TextSize = new Size(132, 22);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.genelBakimText;
      this.layoutControlItem10.Enabled = false;
      this.layoutControlItem10.Location = new Point(860, 117);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(250, 32);
      this.layoutControlItem10.Text = "Genel Bakım";
      this.layoutControlItem10.TextSize = new Size(132, 22);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.cikisTarihi;
      this.layoutControlItem11.Location = new Point(0, 120);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(262, 32);
      this.layoutControlItem11.Text = "Çıkış Tarihi";
      this.layoutControlItem11.TextSize = new Size(132, 22);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.cikisSaat;
      this.layoutControlItem12.Location = new Point(262, 120);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(253, 32);
      this.layoutControlItem12.Text = "Saat";
      this.layoutControlItem12.TextSize = new Size(132, 22);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.Control = (Control) this.bakimKmSaatText;
      this.layoutControlItem13.Enabled = false;
      this.layoutControlItem13.Location = new Point(515, 114);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(321, 32);
      this.layoutControlItem13.Text = "Bakım Km / Saat";
      this.layoutControlItem13.TextSize = new Size(132, 22);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.motorYagText;
      this.layoutControlItem14.Location = new Point(860, 149);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(250, 32);
      this.layoutControlItem14.Text = "Motor Yağ";
      this.layoutControlItem14.TextSize = new Size(132, 22);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.bildirilenArizaText;
      this.layoutControlItem15.Location = new Point(0, 152);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.Size = new Size(515, 61);
      this.layoutControlItem15.Text = "Bildirilen Arıza";
      this.layoutControlItem15.TextSize = new Size(132, 22);
      this.layoutControlItem16.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem16.Control = (Control) this.arizaNedeniLook;
      this.layoutControlItem16.Enabled = false;
      this.layoutControlItem16.Location = new Point(515, 146);
      this.layoutControlItem16.Name = "layoutControlItem16";
      this.layoutControlItem16.Size = new Size(321, 32);
      this.layoutControlItem16.Text = "Arıza Nedeni";
      this.layoutControlItem16.TextSize = new Size(132, 22);
      this.layoutControlItem17.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem17.Control = (Control) this.sanzimanYagText;
      this.layoutControlItem17.Location = new Point(860, 181);
      this.layoutControlItem17.Name = "layoutControlItem17";
      this.layoutControlItem17.Size = new Size(250, 32);
      this.layoutControlItem17.Text = "Şanzıman Yağ";
      this.layoutControlItem17.TextSize = new Size(132, 22);
      this.layoutControlItem20.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem20.Control = (Control) this.diferansiyelYagText;
      this.layoutControlItem20.Location = new Point(860, 213);
      this.layoutControlItem20.Name = "layoutControlItem20";
      this.layoutControlItem20.Size = new Size(250, 32);
      this.layoutControlItem20.Text = "Diferansiyel Yağ";
      this.layoutControlItem20.TextSize = new Size(132, 22);
      this.layoutControlItem21.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem21.Control = (Control) this.hidrolikYagText;
      this.layoutControlItem21.Location = new Point(860, 245);
      this.layoutControlItem21.Name = "layoutControlItem21";
      this.layoutControlItem21.Size = new Size(250, 32);
      this.layoutControlItem21.Text = "Hidrolik Yağ";
      this.layoutControlItem21.TextSize = new Size(132, 22);
      this.layoutControlItem22.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem22.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem22.Control = (Control) this.atolyeSefiLook;
      this.layoutControlItem22.Location = new Point(515, 178);
      this.layoutControlItem22.Name = "layoutControlItem22";
      this.layoutControlItem22.Size = new Size(321, 32);
      this.layoutControlItem22.Text = "Atolye Şefi";
      this.layoutControlItem22.TextSize = new Size(132, 22);
      this.layoutControlItem23.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem23.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem23.Control = (Control) this.bakimOzetiText;
      this.layoutControlItem23.Enabled = false;
      this.layoutControlItem23.Location = new Point(515, 210);
      this.layoutControlItem23.Name = "layoutControlItem23";
      this.layoutControlItem23.Size = new Size(321, 35);
      this.layoutControlItem23.Text = "Bakım Özeti";
      this.layoutControlItem23.TextSize = new Size(132, 22);
      this.layoutControlItem19.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem19.Control = (Control) this.isEmriDurumLook;
      this.layoutControlItem19.Location = new Point(0, 213);
      this.layoutControlItem19.Name = "layoutControlItem19";
      this.layoutControlItem19.Size = new Size(515, 32);
      this.layoutControlItem19.Text = "İş Emri Durum";
      this.layoutControlItem19.TextSize = new Size(132, 22);
      this.layoutControlItem24.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem24.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem24.Control = (Control) this.bakimTuruLook;
      this.layoutControlItem24.Location = new Point(0, 245);
      this.layoutControlItem24.Name = "layoutControlItem24";
      this.layoutControlItem24.Size = new Size(515, 32);
      this.layoutControlItem24.Text = "Bakım Türü";
      this.layoutControlItem24.TextSize = new Size(132, 22);
      this.layoutControlItem18.Control = (Control) this.layoutControl3;
      this.layoutControlItem18.Location = new Point(836, 56);
      this.layoutControlItem18.Name = "layoutControlItem18";
      this.layoutControlItem18.Size = new Size(24, 189);
      this.layoutControlItem18.TextSize = new Size(0, 0);
      this.layoutControlItem18.TextVisible = false;
      this.layoutControlItem25.Control = (Control) this.layoutControl4;
      this.layoutControlItem25.Location = new Point(555, 0);
      this.layoutControlItem25.Name = "layoutControlItem25";
      this.layoutControlItem25.Size = new Size(555, 32);
      this.layoutControlItem25.TextSize = new Size(0, 0);
      this.layoutControlItem25.TextVisible = false;
      this.bakimDerecesiLook.EditValue = (object) "";
      this.bakimDerecesiLook.Location = new Point(662, 257);
      this.bakimDerecesiLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimDerecesiLook.Name = "bakimDerecesiLook";
      this.bakimDerecesiLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimDerecesiLook.Properties.Appearance.Options.UseFont = true;
      this.bakimDerecesiLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimDerecesiLook.Properties.PopupView = (ColumnView) this.gridView1;
      this.bakimDerecesiLook.Size = new Size(206, 28);
      this.bakimDerecesiLook.StyleController = (IStyleController) this.layoutControl1;
      this.bakimDerecesiLook.TabIndex = 31;
      this.layoutControlItem26.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem26.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem26.Control = (Control) this.bakimDerecesiLook;
      this.layoutControlItem26.Location = new Point(515, 245);
      this.layoutControlItem26.Name = "layoutControlItem26";
      this.layoutControlItem26.Size = new Size(345, 32);
      this.layoutControlItem26.Text = "Bakım Derecesi";
      this.layoutControlItem26.TextSize = new Size(132, 22);
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1130, 800);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (AtolyeTalepEmri);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ekle2";
      this.Load += new EventHandler(this.Ekle2_Load);
      this.ribbonControl1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.panelControl1.EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl4.EndInit();
      this.panelControl4.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView6.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      this.repositoryItemLookUpEdit3.EndInit();
      this.panelControl3.EndInit();
      this.panelControl3.ResumeLayout(false);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.layoutControl4.EndInit();
      this.layoutControlGroup3.EndInit();
      this.layoutControl3.EndInit();
      this.layoutControlGroup2.EndInit();
      this.bakimTuruLook.Properties.EndInit();
      this.searchLookUpEdit6View.EndInit();
      this.isEmriDurumLook.Properties.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.bakimOzetiText.Properties.EndInit();
      this.atolyeSefiLook.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.hidrolikYagText.Properties.EndInit();
      this.diferansiyelYagText.Properties.EndInit();
      this.sanzimanYagText.Properties.EndInit();
      this.arizaNedeniLook.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.bildirilenArizaText.Properties.EndInit();
      this.motorYagText.Properties.EndInit();
      this.bakimKmSaatText.Properties.EndInit();
      this.cikisSaat.Properties.EndInit();
      this.cikisTarihi.Properties.CalendarTimeProperties.EndInit();
      this.cikisTarihi.Properties.EndInit();
      this.genelBakimText.Properties.EndInit();
      this.bakimYerAdiText.Properties.EndInit();
      this.girisSaat.Properties.EndInit();
      this.girisTarih.Properties.CalendarTimeProperties.EndInit();
      this.girisTarih.Properties.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlGroup1.EndInit();
      this.bakimYeriLook.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.isEmriNoText.Properties.EndInit();
      this.isEmriText.Properties.EndInit();
      this.atolyeBolumLook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem2.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.layoutControlItem11.EndInit();
      this.layoutControlItem12.EndInit();
      this.layoutControlItem13.EndInit();
      this.layoutControlItem14.EndInit();
      this.layoutControlItem15.EndInit();
      this.layoutControlItem16.EndInit();
      this.layoutControlItem17.EndInit();
      this.layoutControlItem20.EndInit();
      this.layoutControlItem21.EndInit();
      this.layoutControlItem22.EndInit();
      this.layoutControlItem23.EndInit();
      this.layoutControlItem19.EndInit();
      this.layoutControlItem24.EndInit();
      this.layoutControlItem18.EndInit();
      this.layoutControlItem25.EndInit();
      this.bakimDerecesiLook.Properties.EndInit();
      this.layoutControlItem26.EndInit();
      this.gridView1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class Elemanlar
    {
      public string maladi { get; set; }

      public string aciklama { get; set; }

      public string birim { get; set; }

      public Decimal miktar { get; set; }

      public Decimal fiyat { get; set; }

      public Decimal tutar { get; set; }
    }

    public class ElemanlarDurum
    {
      public string Atolyeadı { get; set; }

      public string Usta { get; set; }

      public string bakimGrubu { get; set; }

      public string Yapilanbakim { get; set; }
    }
  }
}
