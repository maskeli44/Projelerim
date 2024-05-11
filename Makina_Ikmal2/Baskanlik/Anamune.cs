// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Baskanlik.Anamune
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.insankaynak;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Baskanlik
{
  public class Anamune : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private AccordionControl accordionControl1;
    private AccordionControlElement accordionControlElement2;
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
    private AccordionControlElement accordionControlElement3;
    private AccordionControlElement accordionControlElement4;
    private SkinBarSubItem skinBarSubItem1;
    private AccordionControlSeparator accordionControlSeparator1;
    private Bar bar3;
    private AccordionControlSeparator accordionControlSeparator3;
    private AccordionControlElement accordionControlElement1;
    private LabelControl girenkullanici_label;
    private TextEdit textEdit1;
    private AccordionControlElement accordionControlElement5;
    private AccordionControlElement accordionControlElement6;

    public Anamune() => this.InitializeComponent();

    private void accordionControlElement2_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi"))
      {
        AracMasraf aracMasraf = new AracMasraf();
        aracMasraf.MdiParent = (Form) this;
        aracMasraf.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement3_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi"))
        return;
      int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
    }

    private void BasDepo_Load(object sender, EventArgs e)
    {
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
      if (!this.yet.MenuYetkilendirme("Personel Listesi"))
        return;
      ilksayfa ilksayfa = new ilksayfa();
      ilksayfa.MdiParent = (Form) this;
      ilksayfa.Show();
    }

    private void accordionControlElement4_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("İzin Durum Listesi"))
        return;
      int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
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
      this.accordionControl1 = new AccordionControl();
      this.accordionControlSeparator3 = new AccordionControlSeparator();
      this.accordionControlElement1 = new AccordionControlElement();
      this.accordionControlSeparator1 = new AccordionControlSeparator();
      this.accordionControlElement2 = new AccordionControlElement();
      this.accordionControlElement3 = new AccordionControlElement();
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
      this.accordionControlElement5 = new AccordionControlElement();
      this.accordionControlElement6 = new AccordionControlElement();
      this.accordionControl1.BeginInit();
      ((ISupportInitialize) this.documentManager1).BeginInit();
      this.barManager1.BeginInit();
      ((ISupportInitialize) this.tabbedView1).BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.accordionControl1.Dock = DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new AccordionControlElement[8]
      {
        (AccordionControlElement) this.accordionControlSeparator3,
        this.accordionControlElement1,
        (AccordionControlElement) this.accordionControlSeparator1,
        this.accordionControlElement2,
        this.accordionControlElement3,
        this.accordionControlElement4,
        this.accordionControlElement5,
        this.accordionControlElement6
      });
      this.accordionControl1.Location = new Point(0, 27);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = ScrollBarMode.Fluent;
      this.accordionControl1.Size = new Size(240, 573);
      this.accordionControl1.TabIndex = 5;
      this.accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
      this.accordionControlSeparator3.Name = "accordionControlSeparator3";
      this.accordionControlElement1.ImageOptions.Image = (Image) Resources.ık64;
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = ElementStyle.Item;
      this.accordionControlElement1.Text = "  MAKİNE İKMAL ŞUBE MÜDÜRLÜĞÜ";
      this.accordionControlSeparator1.Name = "accordionControlSeparator1";
      this.accordionControlElement2.ImageOptions.Image = (Image) Resources.adress_book__2_;
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Style = ElementStyle.Item;
      this.accordionControlElement2.Text = "Arac Masraf Listesi";
      this.accordionControlElement2.Click += new EventHandler(this.accordionControlElement2_Click);
      this.accordionControlElement3.ImageOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.accordionControlElement3.Name = "accordionControlElement3";
      this.accordionControlElement3.Style = ElementStyle.Item;
      this.accordionControlElement3.Text = "Araç Karnesi";
      this.accordionControlElement3.Click += new EventHandler(this.accordionControlElement3_Click);
      this.accordionControlElement4.ImageOptions.Image = (Image) Resources.traveler_with_a_suitcase;
      this.accordionControlElement4.Name = "accordionControlElement4";
      this.accordionControlElement4.Style = ElementStyle.Item;
      this.accordionControlElement4.Text = "İş Emri Tv Ekran";
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
      this.barDockControlTop.Size = new Size(1037, 27);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 600);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new Size(1037, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 27);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new Size(0, 573);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1037, 27);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new Size(0, 573);
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
      this.girenkullanici_label.Location = new Point(432, 6);
      this.girenkullanici_label.Name = "girenkullanici_label";
      this.girenkullanici_label.Size = new Size(0, 21);
      this.girenkullanici_label.TabIndex = 10;
      this.textEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textEdit1.Enabled = false;
      this.textEdit1.Location = new Point(742, 1);
      this.textEdit1.MenuManager = (IDXMenuManager) this.barManager1;
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
      this.textEdit1.Size = new Size(283, 26);
      this.textEdit1.TabIndex = 11;
      this.accordionControlElement5.Name = "accordionControlElement5";
      this.accordionControlElement5.Style = ElementStyle.Item;
      this.accordionControlElement5.Text = "İş Emri Analiz Listesi";
      this.accordionControlElement6.Name = "accordionControlElement6";
      this.accordionControlElement6.Style = ElementStyle.Item;
      this.accordionControlElement6.Text = "Malzeme Analiz Liste ";
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1037, 600);
      this.Controls.Add((Control) this.textEdit1);
      this.Controls.Add((Control) this.girenkullanici_label);
      this.Controls.Add((Control) this.accordionControl1);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.IsMdiContainer = true;
      this.Name = nameof (Anamune);
      this.Text = "İNSAN kAYNAKLARI";
      this.WindowState = FormWindowState.Maximized;
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
