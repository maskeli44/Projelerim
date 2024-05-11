// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.BakimEkle
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
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Log;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using Makina_Ikmal.Sabitler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class BakimEkle : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private LayoutControl layoutControl1;
    private SimpleButton simpleButton1;
    private LookUpEdit bakimgrubuCombo;
    private LookUpEdit atolyeCombo;
    private LayoutControlGroup Root;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem1;
    private LayoutControlItem layoutControlItem4;
    private LabelControl labelControl1;
    private MemoEdit bakimTanimiTxt;
    private LayoutControlItem layoutControlItem5;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLATOLYEBOLUMBindingSource;
    private TBLATOLYEBOLUMTableAdapter tBLATOLYEBOLUMTableAdapter;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private BarButtonItem barButtonItem2;

    public BakimEkle() => this.InitializeComponent();

    private void BakimEkle_Load(object sender, EventArgs e)
    {
      this.atolyeCombo.Properties.DataSource = (object) this.db.TBLATOLYEBOLUM.ToList<TBLATOLYEBOLUM>();
      this.bakimgrubuCombo.Properties.DataSource = (object) this.db.TBLBAKIMGRUBU.ToList<TBLBAKIMGRUBU>();
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelleload();
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        this.db.TBLBAKIMTANIM.Add(new TBLBAKIMTANIM()
        {
          ATOLYEID = new int?(Convert.ToInt32(this.atolyeCombo.EditValue)),
          BAKIMGRUBUID = new int?(Convert.ToInt32(this.bakimgrubuCombo.EditValue)),
          YAPILANBAKIM = this.bakimTanimiTxt.Text
        });
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt İşleminiz başarlı bir şekilde gerçekleşti");
        LogEkle.Logs("Ekleme Yapti");
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show("Kayıt yapılırken bir hata oluştu lütfen daha sonra tekrar deneyin");
      }
    }

    private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        TBLBAKIMTANIM tblbakimtanim = this.db.TBLBAKIMTANIM.FirstOrDefault<TBLBAKIMTANIM>((Expression<System.Func<TBLBAKIMTANIM, bool>>) (x => x.ID == YetkiClass.secim_id));
        tblbakimtanim.ATOLYEID = new int?(Convert.ToInt32(this.atolyeCombo.EditValue));
        tblbakimtanim.BAKIMGRUBUID = new int?(Convert.ToInt32(this.bakimgrubuCombo.EditValue));
        tblbakimtanim.YAPILANBAKIM = this.bakimTanimiTxt.Text;
        this.db.SaveChanges();
        int num = (int) XtraMessageBox.Show("Kayıt İşleminiz başarlı bir şekilde gerçekleşti");
        LogEkle.Logs("Duzenleme Yapti");
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show("Kayıt yapılırken bir hata oluştu lütfen daha sonra tekrar deneyin");
      }
    }

    private void guncelleload()
    {
      try
      {
        TBLBAKIMTANIM tblbakimtanim = this.db.TBLBAKIMTANIM.FirstOrDefault<TBLBAKIMTANIM>((Expression<System.Func<TBLBAKIMTANIM, bool>>) (x => x.ID == YetkiClass.secim_id));
        this.atolyeCombo.EditValue = (object) tblbakimtanim.ATOLYEID;
        this.bakimgrubuCombo.EditValue = (object) tblbakimtanim.BAKIMGRUBUID;
        this.bakimTanimiTxt.Text = tblbakimtanim.YAPILANBAKIM;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      new AtolyeBakimGrubu().Show();
      this.atolyeCombo.Properties.DataSource = (object) this.db.TBLATOLYEBOLUM.ToList<TBLATOLYEBOLUM>();
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
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.layoutControl1 = new LayoutControl();
      this.labelControl1 = new LabelControl();
      this.simpleButton1 = new SimpleButton();
      this.bakimgrubuCombo = new LookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.atolyeCombo = new LookUpEdit();
      this.tBLATOLYEBOLUMBindingSource = new BindingSource(this.components);
      this.bakimTanimiTxt = new MemoEdit();
      this.Root = new LayoutControlGroup();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.tBLATOLYEBOLUMTableAdapter = new TBLATOLYEBOLUMTableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.ribbonControl1.BeginInit();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.bakimgrubuCombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.atolyeCombo.Properties.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).BeginInit();
      this.bakimTanimiTxt.Properties.BeginInit();
      this.Root.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[4]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 3;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.Size = new Size(682, 178);
      this.barButtonItem1.Caption = "Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) Resources.saveto_16x161;
      this.barButtonItem1.ImageOptions.LargeImage = (Image) Resources.saveto_32x321;
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Düzenle";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) Resources.edittask_16x16;
      this.barButtonItem2.ImageOptions.LargeImage = (Image) Resources.edittask_32x32;
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[1]
      {
        this.ribbonPageGroup1
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.layoutControl1.Controls.Add((Control) this.labelControl1);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.bakimgrubuCombo);
      this.layoutControl1.Controls.Add((Control) this.atolyeCombo);
      this.layoutControl1.Controls.Add((Control) this.bakimTanimiTxt);
      this.layoutControl1.Location = new Point(9, 184);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(672, 369);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      this.labelControl1.Location = new Point(621, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(39, 30);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl1;
      this.labelControl1.TabIndex = 8;
      this.simpleButton1.ImageOptions.Image = (Image) Resources.add_16x1610;
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(621, 46);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(39, 30);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 7;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.bakimgrubuCombo.Location = new Point(137, 46);
      this.bakimgrubuCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimgrubuCombo.Name = "bakimgrubuCombo";
      this.bakimgrubuCombo.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimgrubuCombo.Properties.Appearance.Options.UseFont = true;
      this.bakimgrubuCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimgrubuCombo.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("GRUPADI", "Grup Adı")
      });
      this.bakimgrubuCombo.Properties.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.bakimgrubuCombo.Properties.DisplayMember = "GRUPADI";
      this.bakimgrubuCombo.Properties.NullText = "";
      this.bakimgrubuCombo.Properties.ValueMember = "ID";
      this.bakimgrubuCombo.Size = new Size(480, 30);
      this.bakimgrubuCombo.StyleController = (IStyleController) this.layoutControl1;
      this.bakimgrubuCombo.TabIndex = 6;
      this.bakimgrubuCombo.EditValueChanged += new EventHandler(this.lookUpEdit2_EditValueChanged);
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.atolyeCombo.Location = new Point(137, 12);
      this.atolyeCombo.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.atolyeCombo.Name = "atolyeCombo";
      this.atolyeCombo.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.atolyeCombo.Properties.Appearance.Options.UseFont = true;
      this.atolyeCombo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.atolyeCombo.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("BOLUMADI", "Bölüm Adı")
      });
      this.atolyeCombo.Properties.DataSource = (object) this.tBLATOLYEBOLUMBindingSource;
      this.atolyeCombo.Properties.DisplayMember = "BOLUMADI";
      this.atolyeCombo.Properties.NullText = "";
      this.atolyeCombo.Properties.ValueMember = "ID";
      this.atolyeCombo.Size = new Size(480, 30);
      this.atolyeCombo.StyleController = (IStyleController) this.layoutControl1;
      this.atolyeCombo.TabIndex = 5;
      this.tBLATOLYEBOLUMBindingSource.DataMember = "TBLATOLYEBOLUM";
      this.tBLATOLYEBOLUMBindingSource.DataSource = (object) this.bellDataSet5;
      this.bakimTanimiTxt.Location = new Point(137, 80);
      this.bakimTanimiTxt.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.bakimTanimiTxt.Name = "bakimTanimiTxt";
      this.bakimTanimiTxt.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bakimTanimiTxt.Properties.Appearance.Options.UseFont = true;
      this.bakimTanimiTxt.Size = new Size(523, 64);
      this.bakimTanimiTxt.StyleController = (IStyleController) this.layoutControl1;
      this.bakimTanimiTxt.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[6]
      {
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(672, 369);
      this.Root.TextVisible = false;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 136);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(652, 213);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.atolyeCombo;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(609, 34);
      this.layoutControlItem2.Text = "Atölye Bölüm";
      this.layoutControlItem2.TextSize = new Size(122, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.bakimgrubuCombo;
      this.layoutControlItem3.Location = new Point(0, 34);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(609, 34);
      this.layoutControlItem3.Text = "Bakım Grubu";
      this.layoutControlItem3.TextSize = new Size(122, 24);
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.bakimTanimiTxt;
      this.layoutControlItem1.Location = new Point(0, 68);
      this.layoutControlItem1.MinSize = new Size(191, 30);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(652, 68);
      this.layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem1.Text = "Bakım Tanımı";
      this.layoutControlItem1.TextSize = new Size(122, 24);
      this.layoutControlItem4.Control = (Control) this.simpleButton1;
      this.layoutControlItem4.Location = new Point(609, 34);
      this.layoutControlItem4.MinSize = new Size(26, 31);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(43, 34);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem5.Control = (Control) this.labelControl1;
      this.layoutControlItem5.Location = new Point(609, 0);
      this.layoutControlItem5.MinSize = new Size(4, 20);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(43, 34);
      this.layoutControlItem5.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.tBLATOLYEBOLUMTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(682, 357);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (BakimEkle);
      this.Text = nameof (BakimEkle);
      this.Load += new EventHandler(this.BakimEkle_Load);
      this.ribbonControl1.EndInit();
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.bakimgrubuCombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.atolyeCombo.Properties.EndInit();
      ((ISupportInitialize) this.tBLATOLYEBOLUMBindingSource).EndInit();
      this.bakimTanimiTxt.Properties.EndInit();
      this.Root.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem5.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
