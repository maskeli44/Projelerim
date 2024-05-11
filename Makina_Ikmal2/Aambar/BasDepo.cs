﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Aambar.BasDepo
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
using Makina_Ikmal.Depo;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Aambar
{
  public class BasDepo : XtraForm
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
    private SkinBarSubItem skinBarSubItem1;
    private AccordionControlSeparator accordionControlSeparator1;
    private Bar bar3;
    private AccordionControlSeparator accordionControlSeparator3;
    private AccordionControlElement accordionControlElement1;
    private LabelControl girenkullanici_label;
    private TextEdit textEdit1;
    private AccordionControlElement accordionControlElement6;
    private AccordionControlElement accordionControlElement7;
    private AccordionControlElement accordionControlElement8;
    private AccordionControlElement accordionControlElement4;
    private AccordionControlElement accordionControlElement5;
    private AccordionControlElement accordionControlElement9;
    private AccordionControlElement accordionControlElement10;
    private AccordionControlElement accordionControlElement11;
    private AccordionControlElement accordionControlElement12;
    private AccordionControlElement accordionControlElement13;
    private AccordionControlElement accordionControlElement14;
    private AccordionControlElement accordionControlElement15;
    private AccordionControlElement accordionControlElement16;

    public BasDepo() => this.InitializeComponent();

    private void accordionControlElement2_Click(object sender, EventArgs e)
    {
    }

    private void accordionControlElement3_Click(object sender, EventArgs e)
    {
      malzemeEkstresi malzemeEkstresi = new malzemeEkstresi();
      malzemeEkstresi.MdiParent = (Form) this;
      malzemeEkstresi.Show();
    }

    private void BasDepo_Load(object sender, EventArgs e)
    {
      this.defaultLookAndFeel1.LookAndFeel.SkinName = Settings.Default.TemaSkin;
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
    }

    private void accordionControlElement6_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "Ambar";
      malzemeListesi malzemeListesi = new malzemeListesi();
      malzemeListesi.Text = "Ambar";
      malzemeListesi.MdiParent = (Form) this;
      malzemeListesi.Show();
    }

    private void accordionControlElement7_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "Filtre";
      malzemeListesi malzemeListesi = new malzemeListesi();
      malzemeListesi.Text = "Filtre";
      malzemeListesi.MdiParent = (Form) this;
      malzemeListesi.Show();
    }

    private void accordionControlElement8_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "Yağ";
      malzemeListesi malzemeListesi = new malzemeListesi();
      malzemeListesi.Text = "Yağ";
      malzemeListesi.MdiParent = (Form) this;
      malzemeListesi.Show();
    }

    private void accordionControlElement10_Click(object sender, EventArgs e)
    {
    }

    private void accordionControlElement4_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "malzemeHareketleri";
      malzemeHareketleri malzemeHareketleri = new malzemeHareketleri();
      malzemeHareketleri.MdiParent = (Form) this;
      malzemeHareketleri.Show();
    }

    private void accordionControlElement5_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "depoTanim";
      new depoTanim().Show();
    }

    private void accordionControlElement9_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "markaTanim";
      new markaTanim().Show();
    }

    private void accordionControlElement10_Click_1(object sender, EventArgs e)
    {
      YetkiClass.secim = "kdvTanim";
      new kdvTanim().Show();
    }

    private void accordionControlElement11_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Hizmet Tanımları"))
      {
        hizmetTanimlari hizmetTanimlari = new hizmetTanimlari();
        hizmetTanimlari.MdiParent = (Form) this;
        hizmetTanimlari.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement14_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Giriş Fiş Listesi"))
      {
        Makina_Ikmal.Depo.GirisFisListesi girisFisListesi = new Makina_Ikmal.Depo.GirisFisListesi();
        girisFisListesi.MdiParent = (Form) this;
        girisFisListesi.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement15_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Çıkış Fiş Listesi"))
      {
        Makina_Ikmal.Depo.CikisFisListesi cikisFisListesi = new Makina_Ikmal.Depo.CikisFisListesi();
        cikisFisListesi.MdiParent = (Form) this;
        cikisFisListesi.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement16_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Sayım Fiş Listesi"))
      {
        Makina_Ikmal.Depo.SayimFisListesi sayimFisListesi = new Makina_Ikmal.Depo.SayimFisListesi();
        sayimFisListesi.MdiParent = (Form) this;
        sayimFisListesi.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement13_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Talep Fiş Listesi"))
      {
        talepFisListesi talepFisListesi = new talepFisListesi();
        talepFisListesi.MdiParent = (Form) this;
        talepFisListesi.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement12_Click(object sender, EventArgs e)
    {
    }

    private void BasDepo_FormClosed(object sender, FormClosedEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BasDepo));
      this.accordionControl1 = new AccordionControl();
      this.accordionControlSeparator3 = new AccordionControlSeparator();
      this.accordionControlElement1 = new AccordionControlElement();
      this.accordionControlSeparator1 = new AccordionControlSeparator();
      this.accordionControlElement2 = new AccordionControlElement();
      this.accordionControlElement6 = new AccordionControlElement();
      this.accordionControlElement7 = new AccordionControlElement();
      this.accordionControlElement8 = new AccordionControlElement();
      this.accordionControlElement3 = new AccordionControlElement();
      this.accordionControlElement4 = new AccordionControlElement();
      this.accordionControlElement5 = new AccordionControlElement();
      this.accordionControlElement9 = new AccordionControlElement();
      this.accordionControlElement10 = new AccordionControlElement();
      this.accordionControlElement11 = new AccordionControlElement();
      this.accordionControlElement12 = new AccordionControlElement();
      this.accordionControlElement13 = new AccordionControlElement();
      this.accordionControlElement14 = new AccordionControlElement();
      this.accordionControlElement15 = new AccordionControlElement();
      this.accordionControlElement16 = new AccordionControlElement();
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
      this.accordionControl1.Elements.AddRange(new AccordionControlElement[11]
      {
        (AccordionControlElement) this.accordionControlSeparator3,
        this.accordionControlElement1,
        (AccordionControlElement) this.accordionControlSeparator1,
        this.accordionControlElement2,
        this.accordionControlElement3,
        this.accordionControlElement4,
        this.accordionControlElement5,
        this.accordionControlElement9,
        this.accordionControlElement10,
        this.accordionControlElement11,
        this.accordionControlElement12
      });
      this.accordionControl1.Location = new Point(0, 22);
      this.accordionControl1.Margin = new Padding(3, 2, 3, 2);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = ScrollBarMode.Fluent;
      this.accordionControl1.Size = new Size(256, 466);
      this.accordionControl1.TabIndex = 5;
      this.accordionControl1.Text = "Hizmet Tanımları";
      this.accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
      this.accordionControlSeparator3.Name = "accordionControlSeparator3";
      this.accordionControlElement1.ImageOptions.Image = (Image) Resources.ık64;
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = ElementStyle.Item;
      this.accordionControlElement1.Text = "  MAKİNE İKMAL ŞUBE MÜDÜRLÜĞÜ";
      this.accordionControlSeparator1.Name = "accordionControlSeparator1";
      this.accordionControlElement2.Elements.AddRange(new AccordionControlElement[3]
      {
        this.accordionControlElement6,
        this.accordionControlElement7,
        this.accordionControlElement8
      });
      this.accordionControlElement2.Expanded = true;
      this.accordionControlElement2.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement2.ImageOptions.Image");
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Text = "MALZEME LİSTESİ";
      this.accordionControlElement2.Click += new EventHandler(this.accordionControlElement2_Click);
      this.accordionControlElement6.Name = "accordionControlElement6";
      this.accordionControlElement6.Style = ElementStyle.Item;
      this.accordionControlElement6.Text = "Ambar";
      this.accordionControlElement6.Click += new EventHandler(this.accordionControlElement6_Click);
      this.accordionControlElement7.Name = "accordionControlElement7";
      this.accordionControlElement7.Style = ElementStyle.Item;
      this.accordionControlElement7.Text = "Filtre";
      this.accordionControlElement7.Click += new EventHandler(this.accordionControlElement7_Click);
      this.accordionControlElement8.Name = "accordionControlElement8";
      this.accordionControlElement8.Style = ElementStyle.Item;
      this.accordionControlElement8.Text = "Yağ";
      this.accordionControlElement8.Click += new EventHandler(this.accordionControlElement8_Click);
      this.accordionControlElement3.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement3.ImageOptions.Image");
      this.accordionControlElement3.Name = "accordionControlElement3";
      this.accordionControlElement3.Style = ElementStyle.Item;
      this.accordionControlElement3.Text = "Malzeme Ekstresi";
      this.accordionControlElement3.Click += new EventHandler(this.accordionControlElement3_Click);
      this.accordionControlElement4.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement4.ImageOptions.Image");
      this.accordionControlElement4.Name = "accordionControlElement4";
      this.accordionControlElement4.Style = ElementStyle.Item;
      this.accordionControlElement4.Text = "Malzeme Hareketleri";
      this.accordionControlElement4.Click += new EventHandler(this.accordionControlElement4_Click);
      this.accordionControlElement5.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement5.ImageOptions.Image");
      this.accordionControlElement5.Name = "accordionControlElement5";
      this.accordionControlElement5.Style = ElementStyle.Item;
      this.accordionControlElement5.Text = "Depo Tanım";
      this.accordionControlElement5.Click += new EventHandler(this.accordionControlElement5_Click);
      this.accordionControlElement9.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement9.ImageOptions.Image");
      this.accordionControlElement9.Name = "accordionControlElement9";
      this.accordionControlElement9.Style = ElementStyle.Item;
      this.accordionControlElement9.Text = "Marka Tanım";
      this.accordionControlElement9.Click += new EventHandler(this.accordionControlElement9_Click);
      this.accordionControlElement10.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement10.ImageOptions.Image");
      this.accordionControlElement10.Name = "accordionControlElement10";
      this.accordionControlElement10.Style = ElementStyle.Item;
      this.accordionControlElement10.Text = "Kdv Tanım";
      this.accordionControlElement10.Click += new EventHandler(this.accordionControlElement10_Click_1);
      this.accordionControlElement11.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement11.ImageOptions.Image");
      this.accordionControlElement11.Name = "accordionControlElement11";
      this.accordionControlElement11.Style = ElementStyle.Item;
      this.accordionControlElement11.Text = "Hizmet Tanımları";
      this.accordionControlElement11.Click += new EventHandler(this.accordionControlElement11_Click);
      this.accordionControlElement12.Elements.AddRange(new AccordionControlElement[4]
      {
        this.accordionControlElement13,
        this.accordionControlElement14,
        this.accordionControlElement15,
        this.accordionControlElement16
      });
      this.accordionControlElement12.Expanded = true;
      this.accordionControlElement12.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement12.ImageOptions.Image");
      this.accordionControlElement12.Name = "accordionControlElement12";
      this.accordionControlElement12.Text = "DEPO FİŞLERİ";
      this.accordionControlElement12.Click += new EventHandler(this.accordionControlElement12_Click);
      this.accordionControlElement13.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement13.ImageOptions.Image");
      this.accordionControlElement13.Name = "accordionControlElement13";
      this.accordionControlElement13.Style = ElementStyle.Item;
      this.accordionControlElement13.Text = "Talep Fişi Listesi";
      this.accordionControlElement13.Click += new EventHandler(this.accordionControlElement13_Click);
      this.accordionControlElement14.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement14.ImageOptions.Image");
      this.accordionControlElement14.Name = "accordionControlElement14";
      this.accordionControlElement14.Style = ElementStyle.Item;
      this.accordionControlElement14.Text = "Giriş Fişi Listesi";
      this.accordionControlElement14.Click += new EventHandler(this.accordionControlElement14_Click);
      this.accordionControlElement15.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement15.ImageOptions.Image");
      this.accordionControlElement15.Name = "accordionControlElement15";
      this.accordionControlElement15.Style = ElementStyle.Item;
      this.accordionControlElement15.Text = "Çıkış Fişi Listesi";
      this.accordionControlElement15.Click += new EventHandler(this.accordionControlElement15_Click);
      this.accordionControlElement16.ImageOptions.Image = (Image) componentResourceManager.GetObject("accordionControlElement16.ImageOptions.Image");
      this.accordionControlElement16.Name = "accordionControlElement16";
      this.accordionControlElement16.Style = ElementStyle.Item;
      this.accordionControlElement16.Text = "Sayım Fişi Listesi";
      this.accordionControlElement16.Click += new EventHandler(this.accordionControlElement16_Click);
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
      this.Name = nameof (BasDepo);
      this.WindowState = FormWindowState.Maximized;
      this.FormClosed += new FormClosedEventHandler(this.BasDepo_FormClosed);
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
