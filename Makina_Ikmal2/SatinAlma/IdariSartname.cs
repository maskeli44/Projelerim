// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.IdariSartname
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Makina_Ikmal.SatinAlma
{
  public class IdariSartname : XtraForm
  {
    private bellEntities db = new bellEntities();
    private int control = 0;
    public int teklifID = 0;
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem KaydetButton;
    private BarButtonItem SilButton;
    private BarButtonItem YazdirButton;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem YeniDosyaButton;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup5;
    private RibbonPageGroup ribbonPageGroup3;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private BarButtonItem teklifeYukleButon;
    private BarButtonItem barButtonItem3;
    private LayoutControl layoutControl1;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridControl gridControl1;
    private GridView gridView1;
    private TextEdit isinAdiTxt;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private GridColumn colID;
    private GridColumn colISINADI;
    private Makina_Ikmal.Model.TalepToplaTableAdapters.TBLTALEPTEKNIKSARTTableAdapter tBLTALEPTEKNIKSARTTableAdapter1;
    private SimpleButton simpleButton3;
    private SimpleButton guncelleKaydet;
    private SimpleButton yeniKaydet;
    private ComboBoxEdit durumCombo;
    private TextEdit aciklamaTxt;
    private TextEdit siraNoTxt;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem5;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem6;
    private LayoutControlItem layoutControlItem8;
    private LayoutControlItem layoutControlItem9;
    private bellDataSet5 bellDataSet5;
    private GridColumn colSIRANO;
    private GridColumn colACIKLAMA;
    private GridColumn colDURUM;
    private SimpleButton simpleButton1;
    private LayoutControlItem layoutControlItem10;
    private GridColumn idariSartID;
    private BindingSource tBLIDARISARTNAMEBindingSource;
    private TBLIDARISARTNAMETableAdapter tBLIDARISARTNAMETableAdapter;
    private BindingSource tBLIDARISARTHRKTBindingSource;
    private BindingSource idariSartCekBindingSource;
    private idariSartCek idariSartCek;
    private Makina_Ikmal.Model.idariSartCekTableAdapters.TBLIDARISARTHRKTTableAdapter tBLIDARISARTHRKTTableAdapter;
    private GridColumn colID2;

    public IdariSartname() => this.InitializeComponent();

    private void TeknikSartname_Load(object sender, EventArgs e) => this.tBLIDARISARTNAMETableAdapter.Fill(this.bellDataSet5.TBLIDARISARTNAME);

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void YazdirButton_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
    }

    private void gridView1_Click(object sender, EventArgs e)
    {
      this.tBLIDARISARTHRKTTableAdapter.Fill(this.idariSartCek.TBLIDARISARTHRKT, Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID")));
      this.isinAdiTxt.Text = this.gridView1.GetFocusedRowCellValue(this.colISINADI).ToString();
      if (this.gridView2.DataRowCount != 0)
      {
        this.aciklamaTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colACIKLAMA).ToString();
        this.siraNoTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colSIRANO).ToString();
        this.durumCombo.Text = this.gridView2.GetFocusedRowCellValue(this.colDURUM).ToString();
      }
      else
        this.siraNoTxt.Text = "1";
    }

    private void gridView2_Click(object sender, EventArgs e)
    {
      this.siraNoTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colSIRANO).ToString();
      this.aciklamaTxt.Text = this.gridView2.GetFocusedRowCellValue(this.colACIKLAMA).ToString();
      this.durumCombo.Text = this.gridView2.GetFocusedRowCellValue(this.colDURUM).ToString();
    }

    private void Listele()
    {
      this.tBLIDARISARTNAMETableAdapter.Fill(this.bellDataSet5.TBLIDARISARTNAME);
      this.tBLIDARISARTHRKTTableAdapter.Fill(this.idariSartCek.TBLIDARISARTHRKT, Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID")));
    }

    private void YeniDosyaButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.isinAdiTxt.Text != "")
      {
        try
        {
          this.db.TBLIDARISARTNAME.Add(new TBLIDARISARTNAME()
          {
            IDARISARTADI = this.isinAdiTxt.Text
          });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    private void KaydetButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (this.isinAdiTxt.Text != "" && guncelID != 0)
      {
        try
        {
          this.db.TBLIDARISARTNAME.FirstOrDefault<TBLIDARISARTNAME>((Expression<System.Func<TBLIDARISARTNAME, bool>>) (x => x.ID == guncelID)).IDARISARTADI = this.isinAdiTxt.Text;
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Güncelleme başarı ile tamamlanmıştır.");
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    private void yeniKaydet_Click(object sender, EventArgs e)
    {
      this.siraNoTxt.Text = Convert.ToString(Convert.ToInt32(this.gridView2.DataRowCount) + 1);
      this.aciklamaTxt.Text = "";
      this.control = 1;
    }

    private bool BoslukKontrol() => this.isinAdiTxt.Text != "" && this.siraNoTxt.Text != "" && this.aciklamaTxt.Text != "";

    private void guncelleKaydet_Click(object sender, EventArgs e)
    {
      if (this.BoslukKontrol() && this.control == 1)
      {
        try
        {
          this.db.TBLIDARISARTHRKT.Add(new TBLIDARISARTHRKT()
          {
            SIRANO = this.siraNoTxt.Text,
            IDARISARTID = new int?(Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID))),
            ACIKLAMA = this.aciklamaTxt.Text,
            DURUM = this.durumCombo.SelectedItem.ToString()
          });
          this.db.SaveChanges();
          int num = (int) XtraMessageBox.Show("Kayıt başarı ile tamamlanmıştır.");
          this.Listele();
          this.control = 0;
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var Veya Yeni Kaydet Butonuna Basınız");
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      int idariID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue("IDARISARTID"));
      string sirano = Convert.ToString(this.gridView2.GetFocusedRowCellValue("SIRANO"));
      if (this.BoslukKontrol() && idariID != 0 && this.control == 0)
      {
        try
        {
          TBLIDARISARTHRKT tblidarisarthrkt = this.db.TBLIDARISARTHRKT.FirstOrDefault<TBLIDARISARTHRKT>((Expression<System.Func<TBLIDARISARTHRKT, bool>>) (x => x.IDARISARTID == (int?) idariID && x.SIRANO == sirano));
          tblidarisarthrkt.IDARISARTID = new int?(Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.idariSartID)));
          tblidarisarthrkt.SIRANO = this.siraNoTxt.Text;
          tblidarisarthrkt.ACIKLAMA = this.aciklamaTxt.Text;
          tblidarisarthrkt.DURUM = this.durumCombo.SelectedItem.ToString();
          this.db.SaveChanges();
          this.Listele();
          int num = (int) XtraMessageBox.Show("Güncelleme başarı ile tamamlanmıştır.");
        }
        catch (Exception ex)
        {
          int num = (int) XtraMessageBox.Show(ex.ToString());
        }
      }
      else
      {
        int num1 = (int) XtraMessageBox.Show("Boş Alanlar Var");
      }
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView2.GetFocusedRowCellValue(this.colID));
      if (guncelID == 0)
        return;
      try
      {
        this.db.TBLIDARISARTHRKT.Remove(this.db.TBLIDARISARTHRKT.FirstOrDefault<TBLIDARISARTHRKT>((Expression<System.Func<TBLIDARISARTHRKT, bool>>) (x => x.ID == guncelID)));
        this.db.SaveChanges();
        this.Listele();
      }
      catch
      {
      }
    }

    private void SilButton_ItemClick(object sender, ItemClickEventArgs e)
    {
      int guncelID = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue(this.colID));
      if (guncelID == 0)
        return;
      try
      {
        IQueryable<TBLIDARISARTHRKT> source = this.db.TBLIDARISARTHRKT.Where<TBLIDARISARTHRKT>((Expression<System.Func<TBLIDARISARTHRKT, bool>>) (hd => hd.IDARISARTID == (int?) guncelID));
        if (source.Count<TBLIDARISARTHRKT>() > 0)
        {
          foreach (TBLIDARISARTHRKT tblidarisarthrkt in (IEnumerable<TBLIDARISARTHRKT>) source)
            this.db.TBLIDARISARTHRKT.Remove(this.db.TBLIDARISARTHRKT.Find(new object[1]
            {
              (object) tblidarisarthrkt.ID
            }));
        }
        this.db.TBLIDARISARTNAME.Remove(this.db.TBLIDARISARTNAME.FirstOrDefault<TBLIDARISARTNAME>((Expression<System.Func<TBLIDARISARTNAME, bool>>) (x => x.ID == guncelID)));
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
        Console.WriteLine(ex.ToString());
      }
      this.tBLIDARISARTNAMETableAdapter.Fill(this.bellDataSet5.TBLIDARISARTNAME);
    }

    public void Gizle(int hide)
    {
      if (hide != 1)
        return;
      this.teklifeYukleButon.Enabled = false;
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.Listele();

    private void talebYukleButon_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        ParameterExpression parameterExpression;
        // ISSUE: method reference
        int num = this.db.TBLTEKLIFIDARISART.Where<TBLTEKLIFIDARISART>(Expression.Lambda<System.Func<TBLTEKLIFIDARISART, bool>>((Expression) Expression.Equal(x.TEKLIFID, (Expression) Expression.Call(this.teklifID, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.ToString)), Array.Empty<Expression>())), parameterExpression)).Count<TBLTEKLIFIDARISART>();
        for (int rowHandle = 0; rowHandle < this.gridView2.DataRowCount; ++rowHandle)
        {
          this.db.TBLTEKLIFIDARISART.Add(new TBLTEKLIFIDARISART()
          {
            SIRANO = Convert.ToString(num + rowHandle + 1),
            TEKLIFID = this.teklifID.ToString(),
            ACIKLAMA = this.gridView2.GetRowCellValue(rowHandle, this.colACIKLAMA).ToString()
          });
          this.db.SaveChanges();
        }
        ((TeklifFisi) Application.OpenForms["TeklifFisi"])?.SartnameGelen();
        this.Close();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IdariSartname));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.KaydetButton = new BarButtonItem();
      this.SilButton = new BarButtonItem();
      this.YazdirButton = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.YeniDosyaButton = new BarButtonItem();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.tBLIDARISARTNAMEBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colISINADI = new GridColumn();
      this.teklifeYukleButon = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.simpleButton1 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.guncelleKaydet = new SimpleButton();
      this.yeniKaydet = new SimpleButton();
      this.durumCombo = new ComboBoxEdit();
      this.aciklamaTxt = new TextEdit();
      this.siraNoTxt = new TextEdit();
      this.gridControl2 = new GridControl();
      this.tBLIDARISARTHRKTBindingSource = new BindingSource(this.components);
      this.idariSartCekBindingSource = new BindingSource(this.components);
      this.idariSartCek = new idariSartCek();
      this.gridView2 = new GridView();
      this.colID2 = new GridColumn();
      this.idariSartID = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colACIKLAMA = new GridColumn();
      this.colDURUM = new GridColumn();
      this.isinAdiTxt = new TextEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlItem7 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem8 = new LayoutControlItem();
      this.layoutControlItem9 = new LayoutControlItem();
      this.layoutControlItem10 = new LayoutControlItem();
      this.tBLIDARISARTNAMETableAdapter = new TBLIDARISARTNAMETableAdapter();
      this.tBLIDARISARTHRKTTableAdapter = new Makina_Ikmal.Model.idariSartCekTableAdapters.TBLIDARISARTHRKTTableAdapter();
      this.ribbonControl1.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLIDARISARTNAMEBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.gridView1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.durumCombo.Properties.BeginInit();
      this.aciklamaTxt.Properties.BeginInit();
      this.siraNoTxt.Properties.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.tBLIDARISARTHRKTBindingSource).BeginInit();
      ((ISupportInitialize) this.idariSartCekBindingSource).BeginInit();
      this.idariSartCek.BeginInit();
      this.gridView2.BeginInit();
      this.isinAdiTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem8.BeginInit();
      this.layoutControlItem9.BeginInit();
      this.layoutControlItem10.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[12]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.KaydetButton,
        (BarItem) this.SilButton,
        (BarItem) this.YazdirButton,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.YeniDosyaButton,
        (BarItem) this.barEditItem1,
        (BarItem) this.teklifeYukleButon,
        (BarItem) this.barButtonItem3
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ribbonControl1.MaxItemId = 14;
      this.ribbonControl1.Name = "ribbonControl1";
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
      this.ribbonControl1.Size = new Size(1312, 122);
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
      this.KaydetButton.Caption = "Kaydet";
      this.KaydetButton.Id = 2;
      this.KaydetButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.Image");
      this.KaydetButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("KaydetButton.ImageOptions.LargeImage");
      this.KaydetButton.LargeWidth = 100;
      this.KaydetButton.Name = "KaydetButton";
      this.KaydetButton.ItemClick += new ItemClickEventHandler(this.KaydetButton_ItemClick);
      this.SilButton.Caption = "Sil";
      this.SilButton.Id = 3;
      this.SilButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.Image");
      this.SilButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("SilButton.ImageOptions.LargeImage");
      this.SilButton.LargeWidth = 100;
      this.SilButton.Name = "SilButton";
      this.SilButton.RibbonStyle = RibbonItemStyles.Large;
      this.SilButton.ItemClick += new ItemClickEventHandler(this.SilButton_ItemClick);
      this.YazdirButton.Caption = "Yazdır";
      this.YazdirButton.Id = 4;
      this.YazdirButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.Image");
      this.YazdirButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YazdirButton.ImageOptions.LargeImage");
      this.YazdirButton.LargeWidth = 100;
      this.YazdirButton.Name = "YazdirButton";
      this.YazdirButton.RibbonStyle = RibbonItemStyles.Large;
      this.YazdirButton.ItemClick += new ItemClickEventHandler(this.YazdirButton_ItemClick);
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
      this.YeniDosyaButton.Caption = "Yeni";
      this.YeniDosyaButton.Id = 8;
      this.YeniDosyaButton.ImageOptions.Image = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.Image");
      this.YeniDosyaButton.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("YeniDosyaButton.ImageOptions.LargeImage");
      this.YeniDosyaButton.LargeWidth = 100;
      this.YeniDosyaButton.Name = "YeniDosyaButton";
      this.YeniDosyaButton.RibbonStyle = RibbonItemStyles.Large;
      this.YeniDosyaButton.ItemClick += new ItemClickEventHandler(this.YeniDosyaButton_ItemClick);
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 11;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.DataSource = (object) this.tBLIDARISARTNAMEBindingSource;
      this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.gridControl1.Location = new Point(12, 46);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1288, 369);
      this.gridControl1.TabIndex = 5;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
      this.tBLIDARISARTNAMEBindingSource.DataMember = "TBLIDARISARTNAME";
      this.tBLIDARISARTNAMEBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.EvenRow.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.gridView1.Appearance.EvenRow.BackColor2 = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.gridView1.Appearance.EvenRow.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.EvenRow.Options.UseFont = true;
      this.gridView1.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView1.Appearance.Row.BackColor = Color.Aqua;
      this.gridView1.Appearance.Row.BackColor2 = Color.White;
      this.gridView1.Appearance.RowSeparator.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.gridView1.Appearance.RowSeparator.BackColor2 = Color.Blue;
      this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
      this.gridView1.Columns.AddRange(new GridColumn[2]
      {
        this.colID,
        this.colISINADI
      });
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.Click += new EventHandler(this.gridView1_Click);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 23;
      this.colID.Name = "colID";
      this.colID.Width = 87;
      this.colISINADI.Caption = "İdari Şartnamenin Adı";
      this.colISINADI.FieldName = "IDARISARTADI";
      this.colISINADI.MinWidth = 23;
      this.colISINADI.Name = "colISINADI";
      this.colISINADI.OptionsColumn.AllowEdit = false;
      this.colISINADI.OptionsColumn.ReadOnly = true;
      this.colISINADI.Visible = true;
      this.colISINADI.VisibleIndex = 0;
      this.colISINADI.Width = 87;
      this.teklifeYukleButon.Caption = "Teklife Yükle";
      this.teklifeYukleButon.Id = 12;
      this.teklifeYukleButon.ImageOptions.Image = (Image) componentResourceManager.GetObject("teklifeYukleButon.ImageOptions.Image");
      this.teklifeYukleButon.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("teklifeYukleButon.ImageOptions.LargeImage");
      this.teklifeYukleButon.LargeWidth = 100;
      this.teklifeYukleButon.Name = "teklifeYukleButon";
      this.teklifeYukleButon.ItemClick += new ItemClickEventHandler(this.talebYukleButon_ItemClick);
      this.barButtonItem3.Caption = "Yenile";
      this.barButtonItem3.Id = 13;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[5]
      {
        this.ribbonPageGroup2,
        this.ribbonPageGroup1,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5,
        this.ribbonPageGroup3
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.YeniDosyaButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.KaydetButton);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.SilButton);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.teklifeYukleButon);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.YazdirButton, true);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.simpleButton3);
      this.layoutControl1.Controls.Add((Control) this.guncelleKaydet);
      this.layoutControl1.Controls.Add((Control) this.yeniKaydet);
      this.layoutControl1.Controls.Add((Control) this.durumCombo);
      this.layoutControl1.Controls.Add((Control) this.aciklamaTxt);
      this.layoutControl1.Controls.Add((Control) this.siraNoTxt);
      this.layoutControl1.Controls.Add((Control) this.gridControl2);
      this.layoutControl1.Controls.Add((Control) this.gridControl1);
      this.layoutControl1.Controls.Add((Control) this.isinAdiTxt);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 122);
      this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1270, 267, 650, 400));
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1312, 940);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton1.Location = new Point(1166, 419);
      this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(64, 45);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 14;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.simpleButton3.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton3.ImageOptions.Image");
      this.simpleButton3.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton3.Location = new Point(1234, 419);
      this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.PaintStyle = PaintStyles.Light;
      this.simpleButton3.Size = new Size(66, 45);
      this.simpleButton3.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton3.TabIndex = 13;
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.guncelleKaydet.ImageOptions.Image = (Image) componentResourceManager.GetObject("guncelleKaydet.ImageOptions.Image");
      this.guncelleKaydet.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.guncelleKaydet.Location = new Point(1098, 419);
      this.guncelleKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.guncelleKaydet.Name = "guncelleKaydet";
      this.guncelleKaydet.PaintStyle = PaintStyles.Light;
      this.guncelleKaydet.Size = new Size(64, 45);
      this.guncelleKaydet.StyleController = (IStyleController) this.layoutControl1;
      this.guncelleKaydet.TabIndex = 12;
      this.guncelleKaydet.ToolTip = "Kaydet";
      this.guncelleKaydet.Click += new EventHandler(this.guncelleKaydet_Click);
      this.yeniKaydet.ImageOptions.Image = (Image) componentResourceManager.GetObject("yeniKaydet.ImageOptions.Image");
      this.yeniKaydet.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.yeniKaydet.Location = new Point(1033, 419);
      this.yeniKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.yeniKaydet.Name = "yeniKaydet";
      this.yeniKaydet.PaintStyle = PaintStyles.Light;
      this.yeniKaydet.Size = new Size(61, 45);
      this.yeniKaydet.StyleController = (IStyleController) this.layoutControl1;
      this.yeniKaydet.TabIndex = 11;
      this.yeniKaydet.Click += new EventHandler(this.yeniKaydet_Click);
      this.durumCombo.Location = new Point(870, 427);
      this.durumCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.durumCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.durumCombo.Name = "durumCombo";
      this.durumCombo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.durumCombo.Properties.Appearance.Options.UseFont = true;
      this.durumCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.durumCombo.Properties.Items.AddRange(new object[2]
      {
        (object) "Aktif",
        (object) "Pasif"
      });
      this.durumCombo.Size = new Size(159, 30);
      this.durumCombo.StyleController = (IStyleController) this.layoutControl1;
      this.durumCombo.TabIndex = 10;
      this.aciklamaTxt.Location = new Point(286, 427);
      this.aciklamaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.aciklamaTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.aciklamaTxt.Name = "aciklamaTxt";
      this.aciklamaTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.aciklamaTxt.Properties.Appearance.Options.UseFont = true;
      this.aciklamaTxt.Size = new Size(580, 30);
      this.aciklamaTxt.StyleController = (IStyleController) this.layoutControl1;
      this.aciklamaTxt.TabIndex = 8;
      this.siraNoTxt.Location = new Point(79, 427);
      this.siraNoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.siraNoTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.siraNoTxt.Name = "siraNoTxt";
      this.siraNoTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.siraNoTxt.Properties.Appearance.Options.UseFont = true;
      this.siraNoTxt.Properties.Mask.EditMask = "n0";
      this.siraNoTxt.Properties.Mask.MaskType = MaskType.Numeric;
      this.siraNoTxt.Size = new Size(122, 30);
      this.siraNoTxt.StyleController = (IStyleController) this.layoutControl1;
      this.siraNoTxt.TabIndex = 7;
      this.gridControl2.DataSource = (object) this.tBLIDARISARTHRKTBindingSource;
      this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridControl2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(12, 468);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1288, 460);
      this.gridControl2.TabIndex = 6;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.tBLIDARISARTHRKTBindingSource.DataMember = "TBLIDARISARTHRKT";
      this.tBLIDARISARTHRKTBindingSource.DataSource = (object) this.idariSartCekBindingSource;
      this.idariSartCekBindingSource.DataSource = (object) this.idariSartCek;
      this.idariSartCekBindingSource.Position = 0;
      this.idariSartCek.DataSetName = "idariSartCek";
      this.idariSartCek.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 11.25f);
      this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[5]
      {
        this.colID2,
        this.idariSartID,
        this.colSIRANO,
        this.colACIKLAMA,
        this.colDURUM
      });
      this.gridView2.DetailHeight = 431;
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridView2.Click += new EventHandler(this.gridView2_Click);
      this.colID2.Caption = "gridColumn1";
      this.colID2.FieldName = "ID";
      this.colID2.MinWidth = 23;
      this.colID2.Name = "colID2";
      this.colID2.Width = 87;
      this.idariSartID.FieldName = "IDARISARTID";
      this.idariSartID.MinWidth = 23;
      this.idariSartID.Name = "idariSartID";
      this.idariSartID.Width = 87;
      this.colSIRANO.Caption = "Sıra No";
      this.colSIRANO.DisplayFormat.FormatType = FormatType.Numeric;
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.MinWidth = 23;
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.OptionsColumn.AllowEdit = false;
      this.colSIRANO.OptionsColumn.ReadOnly = true;
      this.colSIRANO.Visible = true;
      this.colSIRANO.VisibleIndex = 0;
      this.colSIRANO.Width = 101;
      this.colACIKLAMA.Caption = "Açıklama";
      this.colACIKLAMA.FieldName = "ACIKLAMA";
      this.colACIKLAMA.MinWidth = 23;
      this.colACIKLAMA.Name = "colACIKLAMA";
      this.colACIKLAMA.OptionsColumn.AllowEdit = false;
      this.colACIKLAMA.OptionsColumn.ReadOnly = true;
      this.colACIKLAMA.Visible = true;
      this.colACIKLAMA.VisibleIndex = 1;
      this.colACIKLAMA.Width = 474;
      this.colDURUM.Caption = "Durum";
      this.colDURUM.FieldName = "DURUM";
      this.colDURUM.MinWidth = 23;
      this.colDURUM.Name = "colDURUM";
      this.colDURUM.OptionsColumn.AllowEdit = false;
      this.colDURUM.OptionsColumn.ReadOnly = true;
      this.colDURUM.Visible = true;
      this.colDURUM.VisibleIndex = 2;
      this.colDURUM.Width = 147;
      this.isinAdiTxt.Location = new Point(194, 12);
      this.isinAdiTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.isinAdiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.isinAdiTxt.Name = "isinAdiTxt";
      this.isinAdiTxt.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.isinAdiTxt.Properties.Appearance.Options.UseFont = true;
      this.isinAdiTxt.Size = new Size(1106, 30);
      this.isinAdiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.isinAdiTxt.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[10]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem8,
        (BaseLayoutItem) this.layoutControlItem9,
        (BaseLayoutItem) this.layoutControlItem10
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1312, 940);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.isinAdiTxt;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1292, 34);
      this.layoutControlItem1.Text = "İdari Şartnamenin Adı";
      this.layoutControlItem1.TextSize = new Size(179, 24);
      this.layoutControlItem2.Control = (Control) this.gridControl1;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(1292, 373);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.gridControl2;
      this.layoutControlItem3.Location = new Point(0, 456);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(1292, 464);
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.siraNoTxt;
      this.layoutControlItem4.Location = new Point(0, 407);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
      this.layoutControlItem4.Size = new Size(193, 49);
      this.layoutControlItem4.Text = "Sira No";
      this.layoutControlItem4.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem4.TextSize = new Size(62, 24);
      this.layoutControlItem4.TextToControlDistance = 5;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.aciklamaTxt;
      this.layoutControlItem5.Location = new Point(193, 407);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
      this.layoutControlItem5.Size = new Size(665, 49);
      this.layoutControlItem5.Text = "Açıklama";
      this.layoutControlItem5.TextAlignMode = TextAlignModeItem.AutoSize;
      this.layoutControlItem5.TextSize = new Size(76, 24);
      this.layoutControlItem5.TextToControlDistance = 5;
      this.layoutControlItem7.Control = (Control) this.durumCombo;
      this.layoutControlItem7.Location = new Point(858, 407);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
      this.layoutControlItem7.Size = new Size(163, 49);
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.layoutControlItem6.Control = (Control) this.yeniKaydet;
      this.layoutControlItem6.Location = new Point(1021, 407);
      this.layoutControlItem6.MaxSize = new Size(65, 49);
      this.layoutControlItem6.MinSize = new Size(65, 49);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(65, 49);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem8.Control = (Control) this.guncelleKaydet;
      this.layoutControlItem8.Location = new Point(1086, 407);
      this.layoutControlItem8.MaxSize = new Size(68, 49);
      this.layoutControlItem8.MinSize = new Size(68, 49);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(68, 49);
      this.layoutControlItem8.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem8.TextSize = new Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      this.layoutControlItem9.Control = (Control) this.simpleButton3;
      this.layoutControlItem9.Location = new Point(1222, 407);
      this.layoutControlItem9.MaxSize = new Size(70, 49);
      this.layoutControlItem9.MinSize = new Size(70, 49);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(70, 49);
      this.layoutControlItem9.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem9.TextSize = new Size(0, 0);
      this.layoutControlItem9.TextVisible = false;
      this.layoutControlItem10.Control = (Control) this.simpleButton1;
      this.layoutControlItem10.Location = new Point(1154, 407);
      this.layoutControlItem10.MaxSize = new Size(68, 49);
      this.layoutControlItem10.MinSize = new Size(68, 49);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(68, 49);
      this.layoutControlItem10.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem10.TextSize = new Size(0, 0);
      this.layoutControlItem10.TextVisible = false;
      this.tBLIDARISARTNAMETableAdapter.ClearBeforeFill = true;
      this.tBLIDARISARTHRKTTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1312, 1062);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = nameof (IdariSartname);
      this.Text = "İdari Şartname";
      this.Load += new EventHandler(this.TeknikSartname_Load);
      this.ribbonControl1.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLIDARISARTNAMEBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.gridView1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.durumCombo.Properties.EndInit();
      this.aciklamaTxt.Properties.EndInit();
      this.siraNoTxt.Properties.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.tBLIDARISARTHRKTBindingSource).EndInit();
      ((ISupportInitialize) this.idariSartCekBindingSource).EndInit();
      this.idariSartCek.EndInit();
      this.gridView2.EndInit();
      this.isinAdiTxt.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlItem7.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem8.EndInit();
      this.layoutControlItem9.EndInit();
      this.layoutControlItem10.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
