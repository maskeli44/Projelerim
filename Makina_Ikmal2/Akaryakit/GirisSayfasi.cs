// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Akaryakit.GirisSayfasi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Makina_Ikmal.Akaryakit.Hakedis;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Akaryakit
{
  public class GirisSayfasi : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private AccordionControl accordionControl1;
    private DocumentManager documentManager1;
    private TabbedView tabbedView1;
    private BarDockControl barDockControlLeft;
    private BarManager barManager1;
    private Bar bar1;
    private SkinDropDownButtonItem skinDropDownButtonItem1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlRight;
    private DefaultLookAndFeel defaultLookAndFeel1;
    private SkinBarSubItem skinBarSubItem1;
    private AccordionControlSeparator accordionControlSeparator1;
    private Bar bar3;
    private AccordionControlSeparator accordionControlSeparator3;
    private AccordionControlElement accordionControlElement1;
    private LabelControl girenkullanici_label;
    private TextEdit textEdit1;
    private AccordionControlElement accordionControlElement6;
    private AccordionControlElement accordionControlElement4;

    public GirisSayfasi() => this.InitializeComponent();

    private void BasDepo_Load(object sender, EventArgs e)
    {
      this.defaultLookAndFeel1.LookAndFeel.SkinName = Settings.Default.TemaSkin;
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
      this.yet.yetkiislemleri("AKARYAKIT");
      if (YetkiClass.ListelemeYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        AracYakitKonrol aracYakitKonrol = new AracYakitKonrol();
        aracYakitKonrol.MdiParent = (Form) this;
        aracYakitKonrol.Text = "Araç Yakıt Kontrol";
        aracYakitKonrol.Show();
      }
      else
      {
        int num = (int) XtraMessageBox.Show("Burada yetkiniz yok");
      }
    }

    private void accordionControlElement6_Click(object sender, EventArgs e)
    {
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
      if (this.yet.MenuYetkilendirme("AKARYAKIT"))
      {
        AracYakitKonrol openForm = (AracYakitKonrol) Application.OpenForms["AracYakitKonrol"];
        if (openForm != null)
        {
          openForm.Focus();
          openForm.Yenile();
        }
        else
        {
          AracYakitKonrol aracYakitKonrol = new AracYakitKonrol();
          aracYakitKonrol.MdiParent = (Form) this;
          aracYakitKonrol.Show();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement4_Click(object sender, EventArgs e)
    {
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
      if (this.yet.MenuYetkilendirme("AKARYAKIT"))
      {
        HakedisListe openForm = (HakedisListe) Application.OpenForms["HakedisListe"];
        if (openForm != null)
        {
          openForm.Focus();
          openForm.Yenile();
        }
        else
        {
          HakedisListe hakedisListe = new HakedisListe();
          hakedisListe.MdiParent = (Form) this;
          hakedisListe.Show();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void GirisSayfasi_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.TemaSkin = this.defaultLookAndFeel1.LookAndFeel.SkinName;
      Settings.Default.Save();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GirisSayfasi));
      this.accordionControl1 = new AccordionControl();
      this.accordionControlSeparator3 = new AccordionControlSeparator();
      this.accordionControlElement1 = new AccordionControlElement();
      this.accordionControlSeparator1 = new AccordionControlSeparator();
      this.accordionControlElement6 = new AccordionControlElement();
      this.accordionControlElement4 = new AccordionControlElement();
      this.documentManager1 = new DocumentManager(this.components);
      this.barManager1 = new BarManager(this.components);
      this.bar1 = new Bar();
      this.skinBarSubItem1 = new SkinBarSubItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.skinDropDownButtonItem1 = new SkinDropDownButtonItem();
      this.tabbedView1 = new TabbedView(this.components);
      this.defaultLookAndFeel1 = new DefaultLookAndFeel(this.components);
      this.bar3 = new Bar();
      this.girenkullanici_label = new LabelControl();
      this.textEdit1 = new TextEdit();
      this.accordionControl1.BeginInit();
      ((ISupportInitialize) this.documentManager1).BeginInit();
      this.barManager1.BeginInit();
      ((ISupportInitialize) this.tabbedView1).BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.accordionControl1.Dock = DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new AccordionControlElement[5]
      {
        (AccordionControlElement) this.accordionControlSeparator3,
        this.accordionControlElement1,
        (AccordionControlElement) this.accordionControlSeparator1,
        this.accordionControlElement6,
        this.accordionControlElement4
      });
      this.accordionControl1.Location = new Point(0, 22);
      this.accordionControl1.Margin = new Padding(3, 2, 3, 2);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = ScrollBarMode.Fluent;
      this.accordionControl1.Size = new Size(216, 466);
      this.accordionControl1.TabIndex = 5;
      this.accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
      this.accordionControlSeparator3.Name = "accordionControlSeparator3";
      this.accordionControlElement1.ImageOptions.Image = (Image) Resources.ık64;
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = ElementStyle.Item;
      this.accordionControlElement1.Text = "  MAKİNE İKMAL ŞUBE MÜDÜRLÜĞÜ";
      this.accordionControlSeparator1.Name = "accordionControlSeparator1";
      this.accordionControlElement6.Appearance.Normal.Options.UseTextOptions = true;
      this.accordionControlElement6.Appearance.Normal.TextOptions.VAlignment = VertAlignment.Center;
      this.accordionControlElement6.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement6.ImageOptions.Image");
      this.accordionControlElement6.Name = "accordionControlElement6";
      this.accordionControlElement6.Style = ElementStyle.Item;
      this.accordionControlElement6.Text = "Araç Yakıt Kontrol";
      this.accordionControlElement6.Click += new EventHandler(this.accordionControlElement6_Click);
      this.accordionControlElement4.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement4.ImageOptions.Image");
      this.accordionControlElement4.Name = "accordionControlElement4";
      this.accordionControlElement4.Style = ElementStyle.Item;
      this.accordionControlElement4.Text = "Hak Ediş";
      this.accordionControlElement4.Click += new EventHandler(this.accordionControlElement4_Click);
      this.documentManager1.MdiParent = (Form) this;
      this.documentManager1.MenuManager = (IDXMenuManager) this.barManager1;
      this.documentManager1.View = (BaseView) this.tabbedView1;
      this.documentManager1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.tabbedView1
      });
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar1 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[2]
      {
        (BarItem) this.skinDropDownButtonItem1,
        (BarItem) this.skinBarSubItem1
      });
      this.barManager1.MaxItemId = 2;
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[1]
      {
        new LinkPersistInfo((BarItem) this.skinBarSubItem1)
      });
      this.bar1.Text = "Tools";
      this.skinBarSubItem1.Caption = "Temalar";
      this.skinBarSubItem1.Id = 1;
      this.skinBarSubItem1.Name = "skinBarSubItem1";
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlTop.Size = new Size(889, 22);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlBottom.Size = new Size(889, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 22);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlLeft.Size = new Size(0, 466);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(889, 22);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlRight.Size = new Size(0, 466);
      this.skinDropDownButtonItem1.Id = 0;
      this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
      this.skinDropDownButtonItem1.PaintStyle = BarItemPaintStyle.CaptionInMenu;
      this.defaultLookAndFeel1.EnableBonusSkins = true;
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Dark Gray";
      this.bar3.BarName = "Status bar";
      this.bar3.CanDockStyle = BarCanDockStyle.Bottom;
      this.bar3.DockCol = 0;
      this.bar3.DockRow = 0;
      this.bar3.DockStyle = BarDockStyle.Bottom;
      this.bar3.OptionsBar.AllowQuickCustomization = false;
      this.bar3.OptionsBar.DrawDragBorder = false;
      this.bar3.OptionsBar.UseWholeRow = true;
      this.bar3.Text = "Status bar";
      this.girenkullanici_label.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girenkullanici_label.Appearance.ForeColor = Color.Blue;
      this.girenkullanici_label.Appearance.Options.UseFont = true;
      this.girenkullanici_label.Appearance.Options.UseForeColor = true;
      this.girenkullanici_label.Location = new Point(370, 5);
      this.girenkullanici_label.Margin = new Padding(3, 2, 3, 2);
      this.girenkullanici_label.Name = "girenkullanici_label";
      this.girenkullanici_label.Size = new Size(0, 17);
      this.girenkullanici_label.TabIndex = 10;
      this.textEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textEdit1.Enabled = false;
      this.textEdit1.Location = new Point(636, 1);
      this.textEdit1.Margin = new Padding(3, 2, 3, 2);
      this.textEdit1.MenuManager = (IDXMenuManager) this.barManager1;
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
      this.textEdit1.Size = new Size(243, 22);
      this.textEdit1.TabIndex = 11;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(889, 488);
      this.Controls.Add((Control) this.textEdit1);
      this.Controls.Add((Control) this.girenkullanici_label);
      this.Controls.Add((Control) this.accordionControl1);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.IsMdiContainer = true;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (GirisSayfasi);
      this.WindowState = FormWindowState.Maximized;
      this.FormClosed += new FormClosedEventHandler(this.GirisSayfasi_FormClosed);
      this.Load += new EventHandler(this.BasDepo_Load);
      this.accordionControl1.EndInit();
      ((ISupportInitialize) this.documentManager1).EndInit();
      this.barManager1.EndInit();
      ((ISupportInitialize) this.tabbedView1).EndInit();
      this.textEdit1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
