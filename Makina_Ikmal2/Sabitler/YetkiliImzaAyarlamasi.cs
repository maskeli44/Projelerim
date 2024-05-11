// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.YetkiliImzaAyarlamasi
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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Makina_Ikmal.bellDataSet6TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Sabitler
{
  public class YetkiliImzaAyarlamasi : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private BarButtonItem barButtonItem12;
    private BarButtonItem barButtonItem13;
    private BarEditItem barEditItem1;
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
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup4;
    private RibbonPageGroup ribbonPageGroup1;
    private LayoutControl layoutControl1;
    private SearchLookUpEdit kabulKomBsknLook;
    private GridView searchLookUpEdit14View;
    private SearchLookUpEdit kabulKomUye2Look;
    private GridView searchLookUpEdit13View;
    private SearchLookUpEdit kabulKomUye1Look;
    private GridView searchLookUpEdit12View;
    private SearchLookUpEdit PysArstrmBsknLook;
    private GridView searchLookUpEdit11View;
    private SearchLookUpEdit PysArstrmUye2Look;
    private GridView searchLookUpEdit10View;
    private SearchLookUpEdit PysArstrmUye1Look;
    private GridView searchLookUpEdit9View;
    private SearchLookUpEdit teklifSrmlLook;
    private GridView searchLookUpEdit8View;
    private SearchLookUpEdit depoYtklLook;
    private GridView searchLookUpEdit7View;
    private SearchLookUpEdit AtolyeSefLook;
    private GridView searchLookUpEdit6View;
    private SearchLookUpEdit subeMdrLook;
    private GridView searchLookUpEdit5View;
    private SearchLookUpEdit daireBsknLook;
    private GridView searchLookUpEdit4View;
    private SearchLookUpEdit genelskrtryrdLook;
    private GridView searchLookUpEdit3View;
    private SearchLookUpEdit genelskrtrLook;
    private GridView searchLookUpEdit2View;
    private SearchLookUpEdit belbaskanlook;
    private GridView searchLookUpEdit1View;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
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
    private bellDataSet6 bellDataSet6;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn AdSoyad;
    private GridColumn gridColumn12;
    private GridColumn gridColumn11;
    private GridColumn gridColumn10;
    private GridColumn gridColumn9;
    private GridColumn gridColumn8;
    private GridColumn gridColumn7;
    private GridColumn gridColumn6;
    private GridColumn gridColumn5;
    private GridColumn gridColumn4;
    private GridColumn gridColumn3;
    private GridColumn gridColumn2;
    private GridColumn gridColumn1;
    private GridColumn G;
    private SearchLookUpEdit yagsorumlusuLook;
    private GridView searchLookUpEdit14View1;
    private GridColumn gridColumn121;
    private LayoutControlItem layoutControlItem15;

    public YetkiliImzaAyarlamasi() => this.InitializeComponent();

    private void YetkiliImzaAyarlamasi_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet6.TBLPERSONEL);
      TBLYETKILIMZA tblyetkilimza = this.db.TBLYETKILIMZA.FirstOrDefault<TBLYETKILIMZA>((Expression<System.Func<TBLYETKILIMZA, bool>>) (x => x.ID == 1));
      this.AtolyeSefLook.EditValue = (object) tblyetkilimza.ATOLYESEFID;
      this.depoYtklLook.EditValue = (object) tblyetkilimza.DEPOYETKILID;
      this.belbaskanlook.EditValue = (object) tblyetkilimza.BELBSKNID;
      this.genelskrtrLook.EditValue = (object) tblyetkilimza.GENELSKRTRID;
      this.genelskrtryrdLook.EditValue = (object) tblyetkilimza.GENELSKRTRYRDMCID;
      this.subeMdrLook.EditValue = (object) tblyetkilimza.SUBEMDRID;
      this.daireBsknLook.EditValue = (object) tblyetkilimza.DAIREBSKNID;
      this.teklifSrmlLook.EditValue = (object) tblyetkilimza.TKLFSORUMLUID;
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      TBLYETKILIMZA tblyetkilimza = this.db.TBLYETKILIMZA.FirstOrDefault<TBLYETKILIMZA>((Expression<System.Func<TBLYETKILIMZA, bool>>) (x => x.ID == 1));
      try
      {
        if (this.belbaskanlook.Text != "")
          tblyetkilimza.BELBSKNID = new int?(Convert.ToInt32(this.belbaskanlook.EditValue));
        if (this.genelskrtrLook.Text != "")
          tblyetkilimza.GENELSKRTRID = new int?(Convert.ToInt32(this.genelskrtrLook.EditValue));
        if (this.genelskrtryrdLook.Text != "")
          tblyetkilimza.GENELSKRTRYRDMCID = new int?(Convert.ToInt32(this.genelskrtryrdLook.EditValue));
        if (this.daireBsknLook.Text != "")
          tblyetkilimza.DAIREBSKNID = new int?(Convert.ToInt32(this.daireBsknLook.EditValue));
        if (this.subeMdrLook.Text != "")
          tblyetkilimza.SUBEMDRID = new int?(Convert.ToInt32(this.subeMdrLook.EditValue));
        if (this.AtolyeSefLook.Text != "")
          tblyetkilimza.ATOLYESEFID = new int?(Convert.ToInt32(this.AtolyeSefLook.EditValue));
        if (this.depoYtklLook.Text != "")
          tblyetkilimza.DEPOYETKILID = new int?(Convert.ToInt32(this.depoYtklLook.EditValue));
        if (this.teklifSrmlLook.Text != "")
          tblyetkilimza.TKLFSORUMLUID = new int?(Convert.ToInt32(this.teklifSrmlLook.EditValue));
        if (this.PysArstrmUye1Look.Text != "")
          tblyetkilimza.PYSARSTRMAUYE1ID = new int?(Convert.ToInt32(this.PysArstrmUye1Look.EditValue));
        if (this.PysArstrmUye2Look.Text != "")
          tblyetkilimza.PYSARSTRMAUYE2ID = new int?(Convert.ToInt32(this.PysArstrmUye2Look.EditValue));
        if (this.PysArstrmBsknLook.Text != "")
          tblyetkilimza.PYSARSTRMABSKNID = new int?(Convert.ToInt32(this.PysArstrmBsknLook.EditValue));
        if (this.kabulKomUye1Look.Text != "")
          tblyetkilimza.KABULKOMUYE1ID = new int?(Convert.ToInt32(this.kabulKomUye1Look.EditValue));
        if (this.kabulKomUye2Look.Text != "")
          tblyetkilimza.KABULKOMUYE2ID = new int?(Convert.ToInt32(this.kabulKomUye2Look.EditValue));
        if (this.kabulKomBsknLook.Text != "")
          tblyetkilimza.KABULKOMBASKANID = new int?(Convert.ToInt32(this.kabulKomBsknLook.EditValue));
        if (this.yagsorumlusuLook.Text != "")
          tblyetkilimza.YAGSORUMLUSU = new int?(Convert.ToInt32(this.yagsorumlusuLook.EditValue));
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde alındı.");
        this.sorumlulariyukle();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.ToString());
      }
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void sorumlulariyukle()
    {
      TBLYETKILIMZA tblyetkilimza = this.db.TBLYETKILIMZA.FirstOrDefault<TBLYETKILIMZA>((Expression<System.Func<TBLYETKILIMZA, bool>>) (x => x.ID == 1));
      sorumlu.belediyebaskani = Convert.ToInt32((object) tblyetkilimza.BELBSKNID);
      sorumlu.genelsekreter = Convert.ToInt32((object) tblyetkilimza.GENELSKRTRID);
      sorumlu.genelsekreteryardimcisi = Convert.ToInt32((object) tblyetkilimza.GENELSKRTRID);
      sorumlu.dairebaskani = Convert.ToInt32((object) tblyetkilimza.GENELSKRTRYRDMCID);
      sorumlu.subemuduru = Convert.ToInt32((object) tblyetkilimza.SUBEMDRID);
      sorumlu.atolyesefi = Convert.ToInt32((object) tblyetkilimza.ATOLYESEFID);
      sorumlu.depoyetkilisi = Convert.ToInt32((object) tblyetkilimza.DEPOYETKILID);
      sorumlu.kabulkomisyonbaskanı = Convert.ToInt32((object) tblyetkilimza.KABULKOMBASKANID);
      sorumlu.kabulkom1 = Convert.ToInt32((object) tblyetkilimza.KABULKOMUYE1ID);
      sorumlu.kabulkom2 = Convert.ToInt32((object) tblyetkilimza.KABULKOMUYE2ID);
      sorumlu.yagsorumlusu = Convert.ToInt32((object) tblyetkilimza.ATOLYESEFID);
      sorumlu.teklifsorumlusu = Convert.ToInt32((object) tblyetkilimza.TKLFSORUMLUID);
      sorumlu.piyasa1 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMABSKNID);
      sorumlu.piyasa2 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMAUYE1ID);
      sorumlu.piyasa3 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMAUYE2ID);
      sorumlu.yagsorumlusu = Convert.ToInt32((object) tblyetkilimza.YAGSORUMLUSU);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (YetkiliImzaAyarlamasi));
      this.ribbonControl1 = new RibbonControl();
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
      this.barEditItem1 = new BarEditItem();
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
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.kabulKomBsknLook = new SearchLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.bellDataSet6 = new bellDataSet6();
      this.searchLookUpEdit14View = new GridView();
      this.gridColumn12 = new GridColumn();
      this.kabulKomUye2Look = new SearchLookUpEdit();
      this.searchLookUpEdit13View = new GridView();
      this.gridColumn11 = new GridColumn();
      this.kabulKomUye1Look = new SearchLookUpEdit();
      this.searchLookUpEdit12View = new GridView();
      this.gridColumn10 = new GridColumn();
      this.PysArstrmBsknLook = new SearchLookUpEdit();
      this.searchLookUpEdit11View = new GridView();
      this.gridColumn9 = new GridColumn();
      this.PysArstrmUye2Look = new SearchLookUpEdit();
      this.searchLookUpEdit10View = new GridView();
      this.gridColumn8 = new GridColumn();
      this.PysArstrmUye1Look = new SearchLookUpEdit();
      this.searchLookUpEdit9View = new GridView();
      this.gridColumn7 = new GridColumn();
      this.teklifSrmlLook = new SearchLookUpEdit();
      this.searchLookUpEdit8View = new GridView();
      this.gridColumn6 = new GridColumn();
      this.depoYtklLook = new SearchLookUpEdit();
      this.searchLookUpEdit7View = new GridView();
      this.gridColumn5 = new GridColumn();
      this.AtolyeSefLook = new SearchLookUpEdit();
      this.searchLookUpEdit6View = new GridView();
      this.gridColumn4 = new GridColumn();
      this.subeMdrLook = new SearchLookUpEdit();
      this.searchLookUpEdit5View = new GridView();
      this.gridColumn3 = new GridColumn();
      this.daireBsknLook = new SearchLookUpEdit();
      this.searchLookUpEdit4View = new GridView();
      this.gridColumn2 = new GridColumn();
      this.genelskrtryrdLook = new SearchLookUpEdit();
      this.searchLookUpEdit3View = new GridView();
      this.gridColumn1 = new GridColumn();
      this.genelskrtrLook = new SearchLookUpEdit();
      this.searchLookUpEdit2View = new GridView();
      this.G = new GridColumn();
      this.belbaskanlook = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.AdSoyad = new GridColumn();
      this.yagsorumlusuLook = new SearchLookUpEdit();
      this.searchLookUpEdit14View1 = new GridView();
      this.gridColumn121 = new GridColumn();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
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
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.kabulKomBsknLook.Properties.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.bellDataSet6.BeginInit();
      this.searchLookUpEdit14View.BeginInit();
      this.kabulKomUye2Look.Properties.BeginInit();
      this.searchLookUpEdit13View.BeginInit();
      this.kabulKomUye1Look.Properties.BeginInit();
      this.searchLookUpEdit12View.BeginInit();
      this.PysArstrmBsknLook.Properties.BeginInit();
      this.searchLookUpEdit11View.BeginInit();
      this.PysArstrmUye2Look.Properties.BeginInit();
      this.searchLookUpEdit10View.BeginInit();
      this.PysArstrmUye1Look.Properties.BeginInit();
      this.searchLookUpEdit9View.BeginInit();
      this.teklifSrmlLook.Properties.BeginInit();
      this.searchLookUpEdit8View.BeginInit();
      this.depoYtklLook.Properties.BeginInit();
      this.searchLookUpEdit7View.BeginInit();
      this.AtolyeSefLook.Properties.BeginInit();
      this.searchLookUpEdit6View.BeginInit();
      this.subeMdrLook.Properties.BeginInit();
      this.searchLookUpEdit5View.BeginInit();
      this.daireBsknLook.Properties.BeginInit();
      this.searchLookUpEdit4View.BeginInit();
      this.genelskrtryrdLook.Properties.BeginInit();
      this.searchLookUpEdit3View.BeginInit();
      this.genelskrtrLook.Properties.BeginInit();
      this.searchLookUpEdit2View.BeginInit();
      this.belbaskanlook.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.yagsorumlusuLook.Properties.BeginInit();
      this.searchLookUpEdit14View1.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
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
        (BarItem) this.barEditItem1,
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
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 30;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 288;
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
      this.ribbonControl1.Size = new Size(934, 118);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
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
      this.barButtonItem10.Caption = "Birinci Yazdırma";
      this.barButtonItem10.Id = 10;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem11.Caption = "İkinci Yazdırma";
      this.barButtonItem11.Id = 11;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem12.Caption = "Üçüncü Yazdırma";
      this.barButtonItem12.Id = 12;
      this.barButtonItem12.Name = "barButtonItem12";
      this.barButtonItem13.Caption = "Filtrele";
      this.barButtonItem13.Id = 13;
      this.barButtonItem13.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.Image");
      this.barButtonItem13.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem13.ImageOptions.LargeImage");
      this.barButtonItem13.LargeWidth = 100;
      this.barButtonItem13.Name = "barButtonItem13";
      this.barEditItem1.AccessibleDescription = "Kayıt Bul...";
      this.barEditItem1.Edit = (RepositoryItem) null;
      this.barEditItem1.EditHeight = 30;
      this.barEditItem1.EditWidth = 120;
      this.barEditItem1.Id = 14;
      this.barEditItem1.Name = "barEditItem1";
      this.barEditItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barCheckItem1.Caption = "Giriş Yaptı";
      this.barCheckItem1.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem1.Id = 15;
      this.barCheckItem1.Name = "barCheckItem1";
      this.barCheckItem2.Caption = "Parça Bekleniyor";
      this.barCheckItem2.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem2.Id = 16;
      this.barCheckItem2.Name = "barCheckItem2";
      this.barCheckItem3.Caption = "Bakım Yapılıyor";
      this.barCheckItem3.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem3.Id = 17;
      this.barCheckItem3.Name = "barCheckItem3";
      this.barCheckItem4.Caption = "Teslim Edildi";
      this.barCheckItem4.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem4.Id = 18;
      this.barCheckItem4.Name = "barCheckItem4";
      this.barCheckItem5.Caption = "Dış Servis";
      this.barCheckItem5.CheckBoxVisibility = CheckBoxVisibility.BeforeText;
      this.barCheckItem5.Id = 19;
      this.barCheckItem5.Name = "barCheckItem5";
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
      this.barButtonItem17.Caption = "Excel";
      this.barButtonItem17.Id = 24;
      this.barButtonItem17.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.Image");
      this.barButtonItem17.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem17.ImageOptions.LargeImage");
      this.barButtonItem17.LargeWidth = 100;
      this.barButtonItem17.Name = "barButtonItem17";
      this.barButtonItem17.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem18.Caption = "Biten İş Emrini Yazdır";
      this.barButtonItem18.Id = 25;
      this.barButtonItem18.Name = "barButtonItem18";
      this.barButtonItem19.Caption = "Günlük Faaliyet Raporu ";
      this.barButtonItem19.Id = 26;
      this.barButtonItem19.Name = "barButtonItem19";
      this.barButtonItem20.Caption = "barButtonItem20";
      this.barButtonItem20.Id = 27;
      this.barButtonItem20.Name = "barButtonItem20";
      this.barButtonItem1.Caption = "Karne Yazdır";
      this.barButtonItem1.Id = 28;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem2.Caption = "Kaydet";
      this.barButtonItem2.Id = 29;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup4,
        this.ribbonPageGroup1
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.layoutControl1.Controls.Add((Control) this.kabulKomBsknLook);
      this.layoutControl1.Controls.Add((Control) this.kabulKomUye2Look);
      this.layoutControl1.Controls.Add((Control) this.kabulKomUye1Look);
      this.layoutControl1.Controls.Add((Control) this.PysArstrmBsknLook);
      this.layoutControl1.Controls.Add((Control) this.PysArstrmUye2Look);
      this.layoutControl1.Controls.Add((Control) this.PysArstrmUye1Look);
      this.layoutControl1.Controls.Add((Control) this.teklifSrmlLook);
      this.layoutControl1.Controls.Add((Control) this.depoYtklLook);
      this.layoutControl1.Controls.Add((Control) this.AtolyeSefLook);
      this.layoutControl1.Controls.Add((Control) this.subeMdrLook);
      this.layoutControl1.Controls.Add((Control) this.daireBsknLook);
      this.layoutControl1.Controls.Add((Control) this.genelskrtryrdLook);
      this.layoutControl1.Controls.Add((Control) this.genelskrtrLook);
      this.layoutControl1.Controls.Add((Control) this.belbaskanlook);
      this.layoutControl1.Controls.Add((Control) this.yagsorumlusuLook);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 118);
      this.layoutControl1.Margin = new Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(934, 634);
      this.layoutControl1.TabIndex = 2;
      this.layoutControl1.Text = "layoutControl1";
      this.kabulKomBsknLook.EditValue = (object) "";
      this.kabulKomBsknLook.Location = new Point(222, 454);
      this.kabulKomBsknLook.Margin = new Padding(3, 4, 3, 4);
      this.kabulKomBsknLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kabulKomBsknLook.Name = "kabulKomBsknLook";
      this.kabulKomBsknLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kabulKomBsknLook.Properties.Appearance.Options.UseFont = true;
      this.kabulKomBsknLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kabulKomBsknLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.kabulKomBsknLook.Properties.DisplayMember = "ADISOYADI";
      this.kabulKomBsknLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit14View;
      this.kabulKomBsknLook.Properties.ValueMember = "ID";
      this.kabulKomBsknLook.Size = new Size(700, 30);
      this.kabulKomBsknLook.StyleController = (IStyleController) this.layoutControl1;
      this.kabulKomBsknLook.TabIndex = 17;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet6;
      this.bellDataSet6.DataSetName = "bellDataSet6";
      this.bellDataSet6.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.searchLookUpEdit14View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn12
      });
      this.searchLookUpEdit14View.DetailHeight = 431;
      this.searchLookUpEdit14View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit14View.Name = "searchLookUpEdit14View";
      this.searchLookUpEdit14View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit14View.OptionsView.ShowGroupPanel = false;
      this.gridColumn12.Caption = "Ad Soyad";
      this.gridColumn12.FieldName = "ADISOYADI";
      this.gridColumn12.MinWidth = 23;
      this.gridColumn12.Name = "gridColumn12";
      this.gridColumn12.Visible = true;
      this.gridColumn12.VisibleIndex = 0;
      this.gridColumn12.Width = 87;
      this.kabulKomUye2Look.EditValue = (object) "";
      this.kabulKomUye2Look.Location = new Point(222, 420);
      this.kabulKomUye2Look.Margin = new Padding(3, 4, 3, 4);
      this.kabulKomUye2Look.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kabulKomUye2Look.Name = "kabulKomUye2Look";
      this.kabulKomUye2Look.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kabulKomUye2Look.Properties.Appearance.Options.UseFont = true;
      this.kabulKomUye2Look.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kabulKomUye2Look.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.kabulKomUye2Look.Properties.DisplayMember = "ADISOYADI";
      this.kabulKomUye2Look.Properties.PopupView = (ColumnView) this.searchLookUpEdit13View;
      this.kabulKomUye2Look.Properties.ValueMember = "ID";
      this.kabulKomUye2Look.Size = new Size(700, 30);
      this.kabulKomUye2Look.StyleController = (IStyleController) this.layoutControl1;
      this.kabulKomUye2Look.TabIndex = 16;
      this.searchLookUpEdit13View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn11
      });
      this.searchLookUpEdit13View.DetailHeight = 431;
      this.searchLookUpEdit13View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit13View.Name = "searchLookUpEdit13View";
      this.searchLookUpEdit13View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit13View.OptionsView.ShowGroupPanel = false;
      this.gridColumn11.Caption = "Ad Soyad";
      this.gridColumn11.FieldName = "ADISOYADI";
      this.gridColumn11.MinWidth = 23;
      this.gridColumn11.Name = "gridColumn11";
      this.gridColumn11.Visible = true;
      this.gridColumn11.VisibleIndex = 0;
      this.gridColumn11.Width = 87;
      this.kabulKomUye1Look.EditValue = (object) "";
      this.kabulKomUye1Look.Location = new Point(222, 386);
      this.kabulKomUye1Look.Margin = new Padding(3, 4, 3, 4);
      this.kabulKomUye1Look.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.kabulKomUye1Look.Name = "kabulKomUye1Look";
      this.kabulKomUye1Look.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kabulKomUye1Look.Properties.Appearance.Options.UseFont = true;
      this.kabulKomUye1Look.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kabulKomUye1Look.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.kabulKomUye1Look.Properties.DisplayMember = "ADISOYADI";
      this.kabulKomUye1Look.Properties.PopupView = (ColumnView) this.searchLookUpEdit12View;
      this.kabulKomUye1Look.Properties.ValueMember = "ID";
      this.kabulKomUye1Look.Size = new Size(700, 30);
      this.kabulKomUye1Look.StyleController = (IStyleController) this.layoutControl1;
      this.kabulKomUye1Look.TabIndex = 15;
      this.searchLookUpEdit12View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn10
      });
      this.searchLookUpEdit12View.DetailHeight = 431;
      this.searchLookUpEdit12View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit12View.Name = "searchLookUpEdit12View";
      this.searchLookUpEdit12View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit12View.OptionsView.ShowGroupPanel = false;
      this.gridColumn10.Caption = "Ad Soyad";
      this.gridColumn10.FieldName = "ADISOYADI";
      this.gridColumn10.MinWidth = 23;
      this.gridColumn10.Name = "gridColumn10";
      this.gridColumn10.Visible = true;
      this.gridColumn10.VisibleIndex = 0;
      this.gridColumn10.Width = 87;
      this.PysArstrmBsknLook.EditValue = (object) "";
      this.PysArstrmBsknLook.Location = new Point(222, 352);
      this.PysArstrmBsknLook.Margin = new Padding(3, 4, 3, 4);
      this.PysArstrmBsknLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.PysArstrmBsknLook.Name = "PysArstrmBsknLook";
      this.PysArstrmBsknLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.PysArstrmBsknLook.Properties.Appearance.Options.UseFont = true;
      this.PysArstrmBsknLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.PysArstrmBsknLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.PysArstrmBsknLook.Properties.DisplayMember = "ADISOYADI";
      this.PysArstrmBsknLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit11View;
      this.PysArstrmBsknLook.Properties.ValueMember = "ID";
      this.PysArstrmBsknLook.Size = new Size(700, 30);
      this.PysArstrmBsknLook.StyleController = (IStyleController) this.layoutControl1;
      this.PysArstrmBsknLook.TabIndex = 14;
      this.searchLookUpEdit11View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn9
      });
      this.searchLookUpEdit11View.DetailHeight = 431;
      this.searchLookUpEdit11View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit11View.Name = "searchLookUpEdit11View";
      this.searchLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit11View.OptionsView.ShowGroupPanel = false;
      this.gridColumn9.Caption = "Ad Soyad";
      this.gridColumn9.FieldName = "ADISOYADI";
      this.gridColumn9.MinWidth = 23;
      this.gridColumn9.Name = "gridColumn9";
      this.gridColumn9.Visible = true;
      this.gridColumn9.VisibleIndex = 0;
      this.gridColumn9.Width = 87;
      this.PysArstrmUye2Look.EditValue = (object) "";
      this.PysArstrmUye2Look.Location = new Point(222, 318);
      this.PysArstrmUye2Look.Margin = new Padding(3, 4, 3, 4);
      this.PysArstrmUye2Look.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.PysArstrmUye2Look.Name = "PysArstrmUye2Look";
      this.PysArstrmUye2Look.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.PysArstrmUye2Look.Properties.Appearance.Options.UseFont = true;
      this.PysArstrmUye2Look.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.PysArstrmUye2Look.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.PysArstrmUye2Look.Properties.DisplayMember = "ADISOYADI";
      this.PysArstrmUye2Look.Properties.PopupView = (ColumnView) this.searchLookUpEdit10View;
      this.PysArstrmUye2Look.Properties.ValueMember = "ID";
      this.PysArstrmUye2Look.Size = new Size(700, 30);
      this.PysArstrmUye2Look.StyleController = (IStyleController) this.layoutControl1;
      this.PysArstrmUye2Look.TabIndex = 13;
      this.searchLookUpEdit10View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn8
      });
      this.searchLookUpEdit10View.DetailHeight = 431;
      this.searchLookUpEdit10View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit10View.Name = "searchLookUpEdit10View";
      this.searchLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit10View.OptionsView.ShowGroupPanel = false;
      this.gridColumn8.Caption = "Ad Soyad";
      this.gridColumn8.FieldName = "ADISOYADI";
      this.gridColumn8.MinWidth = 23;
      this.gridColumn8.Name = "gridColumn8";
      this.gridColumn8.Visible = true;
      this.gridColumn8.VisibleIndex = 0;
      this.gridColumn8.Width = 87;
      this.PysArstrmUye1Look.EditValue = (object) "";
      this.PysArstrmUye1Look.Location = new Point(222, 284);
      this.PysArstrmUye1Look.Margin = new Padding(3, 4, 3, 4);
      this.PysArstrmUye1Look.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.PysArstrmUye1Look.Name = "PysArstrmUye1Look";
      this.PysArstrmUye1Look.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.PysArstrmUye1Look.Properties.Appearance.Options.UseFont = true;
      this.PysArstrmUye1Look.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.PysArstrmUye1Look.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.PysArstrmUye1Look.Properties.DisplayMember = "ADISOYADI";
      this.PysArstrmUye1Look.Properties.PopupView = (ColumnView) this.searchLookUpEdit9View;
      this.PysArstrmUye1Look.Properties.ValueMember = "ID";
      this.PysArstrmUye1Look.Size = new Size(700, 30);
      this.PysArstrmUye1Look.StyleController = (IStyleController) this.layoutControl1;
      this.PysArstrmUye1Look.TabIndex = 12;
      this.searchLookUpEdit9View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn7
      });
      this.searchLookUpEdit9View.DetailHeight = 431;
      this.searchLookUpEdit9View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit9View.Name = "searchLookUpEdit9View";
      this.searchLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit9View.OptionsView.ShowGroupPanel = false;
      this.gridColumn7.Caption = "Ad Soyad";
      this.gridColumn7.FieldName = "ADISOYADI";
      this.gridColumn7.MinWidth = 23;
      this.gridColumn7.Name = "gridColumn7";
      this.gridColumn7.Visible = true;
      this.gridColumn7.VisibleIndex = 0;
      this.gridColumn7.Width = 87;
      this.teklifSrmlLook.EditValue = (object) "";
      this.teklifSrmlLook.Location = new Point(222, 250);
      this.teklifSrmlLook.Margin = new Padding(3, 4, 3, 4);
      this.teklifSrmlLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.teklifSrmlLook.Name = "teklifSrmlLook";
      this.teklifSrmlLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.teklifSrmlLook.Properties.Appearance.Options.UseFont = true;
      this.teklifSrmlLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.teklifSrmlLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.teklifSrmlLook.Properties.DisplayMember = "ADISOYADI";
      this.teklifSrmlLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit8View;
      this.teklifSrmlLook.Properties.ValueMember = "ID";
      this.teklifSrmlLook.Size = new Size(700, 30);
      this.teklifSrmlLook.StyleController = (IStyleController) this.layoutControl1;
      this.teklifSrmlLook.TabIndex = 11;
      this.searchLookUpEdit8View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn6
      });
      this.searchLookUpEdit8View.DetailHeight = 431;
      this.searchLookUpEdit8View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit8View.Name = "searchLookUpEdit8View";
      this.searchLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit8View.OptionsView.ShowGroupPanel = false;
      this.gridColumn6.Caption = "Ad Soyad";
      this.gridColumn6.FieldName = "ADISOYADI";
      this.gridColumn6.MinWidth = 23;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.gridColumn6.Width = 87;
      this.depoYtklLook.EditValue = (object) "";
      this.depoYtklLook.Location = new Point(222, 216);
      this.depoYtklLook.Margin = new Padding(3, 4, 3, 4);
      this.depoYtklLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.depoYtklLook.Name = "depoYtklLook";
      this.depoYtklLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.depoYtklLook.Properties.Appearance.Options.UseFont = true;
      this.depoYtklLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.depoYtklLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.depoYtklLook.Properties.DisplayMember = "ADISOYADI";
      this.depoYtklLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit7View;
      this.depoYtklLook.Properties.ValueMember = "ID";
      this.depoYtklLook.Size = new Size(700, 30);
      this.depoYtklLook.StyleController = (IStyleController) this.layoutControl1;
      this.depoYtklLook.TabIndex = 10;
      this.searchLookUpEdit7View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn5
      });
      this.searchLookUpEdit7View.DetailHeight = 431;
      this.searchLookUpEdit7View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit7View.Name = "searchLookUpEdit7View";
      this.searchLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit7View.OptionsView.ShowGroupPanel = false;
      this.gridColumn5.Caption = "Ad Soyad";
      this.gridColumn5.FieldName = "ADISOYADI";
      this.gridColumn5.MinWidth = 23;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.gridColumn5.Width = 87;
      this.AtolyeSefLook.EditValue = (object) "";
      this.AtolyeSefLook.Location = new Point(222, 182);
      this.AtolyeSefLook.Margin = new Padding(3, 4, 3, 4);
      this.AtolyeSefLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.AtolyeSefLook.Name = "AtolyeSefLook";
      this.AtolyeSefLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.AtolyeSefLook.Properties.Appearance.Options.UseFont = true;
      this.AtolyeSefLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.AtolyeSefLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.AtolyeSefLook.Properties.DisplayMember = "ADISOYADI";
      this.AtolyeSefLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit6View;
      this.AtolyeSefLook.Properties.ValueMember = "ID";
      this.AtolyeSefLook.Size = new Size(700, 30);
      this.AtolyeSefLook.StyleController = (IStyleController) this.layoutControl1;
      this.AtolyeSefLook.TabIndex = 9;
      this.searchLookUpEdit6View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn4
      });
      this.searchLookUpEdit6View.DetailHeight = 431;
      this.searchLookUpEdit6View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit6View.Name = "searchLookUpEdit6View";
      this.searchLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit6View.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "Ad Soyad";
      this.gridColumn4.FieldName = "ADISOYADI";
      this.gridColumn4.MinWidth = 23;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 0;
      this.gridColumn4.Width = 87;
      this.subeMdrLook.EditValue = (object) "";
      this.subeMdrLook.Location = new Point(222, 148);
      this.subeMdrLook.Margin = new Padding(3, 4, 3, 4);
      this.subeMdrLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.subeMdrLook.Name = "subeMdrLook";
      this.subeMdrLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.subeMdrLook.Properties.Appearance.Options.UseFont = true;
      this.subeMdrLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.subeMdrLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.subeMdrLook.Properties.DisplayMember = "ADISOYADI";
      this.subeMdrLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit5View;
      this.subeMdrLook.Properties.ValueMember = "ID";
      this.subeMdrLook.Size = new Size(700, 30);
      this.subeMdrLook.StyleController = (IStyleController) this.layoutControl1;
      this.subeMdrLook.TabIndex = 8;
      this.searchLookUpEdit5View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn3
      });
      this.searchLookUpEdit5View.DetailHeight = 431;
      this.searchLookUpEdit5View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit5View.Name = "searchLookUpEdit5View";
      this.searchLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit5View.OptionsView.ShowGroupPanel = false;
      this.gridColumn3.Caption = "Ad Soyad";
      this.gridColumn3.FieldName = "ADISOYADI";
      this.gridColumn3.MinWidth = 23;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 87;
      this.daireBsknLook.EditValue = (object) "";
      this.daireBsknLook.Location = new Point(222, 114);
      this.daireBsknLook.Margin = new Padding(3, 4, 3, 4);
      this.daireBsknLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.daireBsknLook.Name = "daireBsknLook";
      this.daireBsknLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.daireBsknLook.Properties.Appearance.Options.UseFont = true;
      this.daireBsknLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.daireBsknLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.daireBsknLook.Properties.DisplayMember = "ADISOYADI";
      this.daireBsknLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit4View;
      this.daireBsknLook.Properties.ValueMember = "ID";
      this.daireBsknLook.Size = new Size(700, 30);
      this.daireBsknLook.StyleController = (IStyleController) this.layoutControl1;
      this.daireBsknLook.TabIndex = 7;
      this.searchLookUpEdit4View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.searchLookUpEdit4View.DetailHeight = 431;
      this.searchLookUpEdit4View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
      this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.Caption = "Ad Soyad";
      this.gridColumn2.FieldName = "ADISOYADI";
      this.gridColumn2.MinWidth = 23;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.gridColumn2.Width = 87;
      this.genelskrtryrdLook.EditValue = (object) "";
      this.genelskrtryrdLook.Location = new Point(222, 80);
      this.genelskrtryrdLook.Margin = new Padding(3, 4, 3, 4);
      this.genelskrtryrdLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelskrtryrdLook.Name = "genelskrtryrdLook";
      this.genelskrtryrdLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelskrtryrdLook.Properties.Appearance.Options.UseFont = true;
      this.genelskrtryrdLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.genelskrtryrdLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.genelskrtryrdLook.Properties.DisplayMember = "ADISOYADI";
      this.genelskrtryrdLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit3View;
      this.genelskrtryrdLook.Properties.ValueMember = "ID";
      this.genelskrtryrdLook.Size = new Size(700, 30);
      this.genelskrtryrdLook.StyleController = (IStyleController) this.layoutControl1;
      this.genelskrtryrdLook.TabIndex = 6;
      this.searchLookUpEdit3View.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.searchLookUpEdit3View.DetailHeight = 431;
      this.searchLookUpEdit3View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
      this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Ad Soyad";
      this.gridColumn1.FieldName = "ADISOYADI";
      this.gridColumn1.MinWidth = 23;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 87;
      this.genelskrtrLook.EditValue = (object) "";
      this.genelskrtrLook.Location = new Point(222, 46);
      this.genelskrtrLook.Margin = new Padding(3, 4, 3, 4);
      this.genelskrtrLook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.genelskrtrLook.Name = "genelskrtrLook";
      this.genelskrtrLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.genelskrtrLook.Properties.Appearance.Options.UseFont = true;
      this.genelskrtrLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.genelskrtrLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.genelskrtrLook.Properties.DisplayMember = "ADISOYADI";
      this.genelskrtrLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit2View;
      this.genelskrtrLook.Properties.ValueMember = "ID";
      this.genelskrtrLook.Size = new Size(700, 30);
      this.genelskrtrLook.StyleController = (IStyleController) this.layoutControl1;
      this.genelskrtrLook.TabIndex = 5;
      this.searchLookUpEdit2View.Columns.AddRange(new GridColumn[1]
      {
        this.G
      });
      this.searchLookUpEdit2View.DetailHeight = 431;
      this.searchLookUpEdit2View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
      this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
      this.G.Caption = "Ad Soyad";
      this.G.FieldName = "ADISOYADI";
      this.G.MinWidth = 23;
      this.G.Name = "G";
      this.G.Visible = true;
      this.G.VisibleIndex = 0;
      this.G.Width = 87;
      this.belbaskanlook.EditValue = (object) "";
      this.belbaskanlook.Location = new Point(222, 12);
      this.belbaskanlook.Margin = new Padding(3, 4, 3, 4);
      this.belbaskanlook.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.belbaskanlook.Name = "belbaskanlook";
      this.belbaskanlook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.belbaskanlook.Properties.Appearance.Options.UseFont = true;
      this.belbaskanlook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.belbaskanlook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.belbaskanlook.Properties.DisplayMember = "ADISOYADI";
      this.belbaskanlook.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.belbaskanlook.Properties.ValueMember = "ID";
      this.belbaskanlook.Size = new Size(700, 30);
      this.belbaskanlook.StyleController = (IStyleController) this.layoutControl1;
      this.belbaskanlook.TabIndex = 4;
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[1]
      {
        this.AdSoyad
      });
      this.searchLookUpEdit1View.DetailHeight = 431;
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.AdSoyad.Caption = "Ad Soyad";
      this.AdSoyad.FieldName = "ADISOYADI";
      this.AdSoyad.MinWidth = 23;
      this.AdSoyad.Name = "AdSoyad";
      this.AdSoyad.Visible = true;
      this.AdSoyad.VisibleIndex = 0;
      this.AdSoyad.Width = 87;
      this.yagsorumlusuLook.EditValue = (object) "";
      this.yagsorumlusuLook.Location = new Point(222, 488);
      this.yagsorumlusuLook.Margin = new Padding(3, 4, 3, 4);
      this.yagsorumlusuLook.Name = "yagsorumlusuLook";
      this.yagsorumlusuLook.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.yagsorumlusuLook.Properties.Appearance.Options.UseFont = true;
      this.yagsorumlusuLook.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.yagsorumlusuLook.Properties.DataSource = (object) this.tBLPERSONELBindingSource;
      this.yagsorumlusuLook.Properties.DisplayMember = "ADISOYADI";
      this.yagsorumlusuLook.Properties.PopupView = (ColumnView) this.searchLookUpEdit14View1;
      this.yagsorumlusuLook.Properties.ValueMember = "ID";
      this.yagsorumlusuLook.Size = new Size(700, 30);
      this.yagsorumlusuLook.StyleController = (IStyleController) this.layoutControl1;
      this.yagsorumlusuLook.TabIndex = 17;
      this.searchLookUpEdit14View1.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn121
      });
      this.searchLookUpEdit14View1.DetailHeight = 431;
      this.searchLookUpEdit14View1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit14View1.Name = "searchLookUpEdit14View1";
      this.searchLookUpEdit14View1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit14View1.OptionsView.ShowGroupPanel = false;
      this.gridColumn121.Caption = "Ad Soyad";
      this.gridColumn121.FieldName = "ADISOYADI";
      this.gridColumn121.MinWidth = 23;
      this.gridColumn121.Name = "gridColumn121";
      this.gridColumn121.Visible = true;
      this.gridColumn121.VisibleIndex = 0;
      this.gridColumn121.Width = 87;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[16]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
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
        (BaseLayoutItem) this.layoutControlItem15
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(934, 634);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.belbaskanlook;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(914, 34);
      this.layoutControlItem1.Text = "Belediye Başkanı";
      this.layoutControlItem1.TextSize = new Size(207, 24);
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 510);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(914, 104);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.genelskrtrLook;
      this.layoutControlItem2.Location = new Point(0, 34);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(914, 34);
      this.layoutControlItem2.Text = "Genel Sekreter";
      this.layoutControlItem2.TextSize = new Size(207, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.genelskrtryrdLook;
      this.layoutControlItem3.Location = new Point(0, 68);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(914, 34);
      this.layoutControlItem3.Text = "Genel Sekreter Yrd.";
      this.layoutControlItem3.TextSize = new Size(207, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.daireBsknLook;
      this.layoutControlItem4.Location = new Point(0, 102);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(914, 34);
      this.layoutControlItem4.Text = "Daire Başkanı";
      this.layoutControlItem4.TextSize = new Size(207, 24);
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.subeMdrLook;
      this.layoutControlItem5.Location = new Point(0, 136);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(914, 34);
      this.layoutControlItem5.Text = "Şube Müdürü";
      this.layoutControlItem5.TextSize = new Size(207, 24);
      this.layoutControlItem6.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem6.Control = (Control) this.AtolyeSefLook;
      this.layoutControlItem6.Location = new Point(0, 170);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(914, 34);
      this.layoutControlItem6.Text = "Atölye Şefi";
      this.layoutControlItem6.TextSize = new Size(207, 24);
      this.layoutControlItem7.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem7.Control = (Control) this.depoYtklLook;
      this.layoutControlItem7.Location = new Point(0, 204);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(914, 34);
      this.layoutControlItem7.Text = "Depo Yetkilisi";
      this.layoutControlItem7.TextSize = new Size(207, 24);
      this.layoutControlItem8.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem8.Control = (Control) this.teklifSrmlLook;
      this.layoutControlItem8.Location = new Point(0, 238);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new Size(914, 34);
      this.layoutControlItem8.Text = "Teklif Sorumlusu";
      this.layoutControlItem8.TextSize = new Size(207, 24);
      this.layoutControlItem9.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem9.Control = (Control) this.PysArstrmUye1Look;
      this.layoutControlItem9.Location = new Point(0, 272);
      this.layoutControlItem9.Name = "layoutControlItem9";
      this.layoutControlItem9.Size = new Size(914, 34);
      this.layoutControlItem9.Text = "Piyasa Araştırma Üye 1";
      this.layoutControlItem9.TextSize = new Size(207, 24);
      this.layoutControlItem10.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem10.Control = (Control) this.PysArstrmUye2Look;
      this.layoutControlItem10.Location = new Point(0, 306);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new Size(914, 34);
      this.layoutControlItem10.Text = "Piyasa Araştırma Üye 2";
      this.layoutControlItem10.TextSize = new Size(207, 24);
      this.layoutControlItem11.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem11.Control = (Control) this.PysArstrmBsknLook;
      this.layoutControlItem11.Location = new Point(0, 340);
      this.layoutControlItem11.Name = "layoutControlItem11";
      this.layoutControlItem11.Size = new Size(914, 34);
      this.layoutControlItem11.Text = "Piyasa Araştırma Başkanı";
      this.layoutControlItem11.TextSize = new Size(207, 24);
      this.layoutControlItem12.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem12.Control = (Control) this.kabulKomUye1Look;
      this.layoutControlItem12.Location = new Point(0, 374);
      this.layoutControlItem12.Name = "layoutControlItem12";
      this.layoutControlItem12.Size = new Size(914, 34);
      this.layoutControlItem12.Text = "Kabul Kom. Üye 1";
      this.layoutControlItem12.TextSize = new Size(207, 24);
      this.layoutControlItem13.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem13.Control = (Control) this.kabulKomUye2Look;
      this.layoutControlItem13.Location = new Point(0, 408);
      this.layoutControlItem13.Name = "layoutControlItem13";
      this.layoutControlItem13.Size = new Size(914, 34);
      this.layoutControlItem13.Text = "Kabul Kom. Üye 2";
      this.layoutControlItem13.TextSize = new Size(207, 24);
      this.layoutControlItem14.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem14.Control = (Control) this.kabulKomBsknLook;
      this.layoutControlItem14.Location = new Point(0, 442);
      this.layoutControlItem14.Name = "layoutControlItem14";
      this.layoutControlItem14.Size = new Size(914, 34);
      this.layoutControlItem14.Text = "Kabul Kom. Başkanı";
      this.layoutControlItem14.TextSize = new Size(207, 24);
      this.layoutControlItem15.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem15.Control = (Control) this.yagsorumlusuLook;
      this.layoutControlItem15.ControlAlignment = ContentAlignment.TopLeft;
      this.layoutControlItem15.CustomizationFormText = "Yağ Birim Sorumlusu";
      this.layoutControlItem15.Location = new Point(0, 476);
      this.layoutControlItem15.Name = "layoutControlItem15";
      this.layoutControlItem15.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem15.OptionsPrint.AppearanceItemControl.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
      this.layoutControlItem15.OptionsPrint.AppearanceItemText.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem15.OptionsPrint.AppearanceItemText.Options.UseFont = true;
      this.layoutControlItem15.Size = new Size(914, 34);
      this.layoutControlItem15.Text = "Yağ Birim Sorumlusu";
      this.layoutControlItem15.TextSize = new Size(207, 24);
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(934, 752);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (YetkiliImzaAyarlamasi);
      this.Text = "Yetkili imza Ayarlamasi";
      this.Load += new EventHandler(this.YetkiliImzaAyarlamasi_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.kabulKomBsknLook.Properties.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.bellDataSet6.EndInit();
      this.searchLookUpEdit14View.EndInit();
      this.kabulKomUye2Look.Properties.EndInit();
      this.searchLookUpEdit13View.EndInit();
      this.kabulKomUye1Look.Properties.EndInit();
      this.searchLookUpEdit12View.EndInit();
      this.PysArstrmBsknLook.Properties.EndInit();
      this.searchLookUpEdit11View.EndInit();
      this.PysArstrmUye2Look.Properties.EndInit();
      this.searchLookUpEdit10View.EndInit();
      this.PysArstrmUye1Look.Properties.EndInit();
      this.searchLookUpEdit9View.EndInit();
      this.teklifSrmlLook.Properties.EndInit();
      this.searchLookUpEdit8View.EndInit();
      this.depoYtklLook.Properties.EndInit();
      this.searchLookUpEdit7View.EndInit();
      this.AtolyeSefLook.Properties.EndInit();
      this.searchLookUpEdit6View.EndInit();
      this.subeMdrLook.Properties.EndInit();
      this.searchLookUpEdit5View.EndInit();
      this.daireBsknLook.Properties.EndInit();
      this.searchLookUpEdit4View.EndInit();
      this.genelskrtryrdLook.Properties.EndInit();
      this.searchLookUpEdit3View.EndInit();
      this.genelskrtrLook.Properties.EndInit();
      this.searchLookUpEdit2View.EndInit();
      this.belbaskanlook.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.yagsorumlusuLook.Properties.EndInit();
      this.searchLookUpEdit14View1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
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
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
