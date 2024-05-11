// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Hakkimizda.Hakkimizda
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Hakkimizda
{
  public class Hakkimizda : XtraForm
  {
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private BarEditItem barEditItem1;
    private BarEditItem barEditItem2;
    private BarEditItem barEditItem4;
    private BarCheckItem barCheckItem1;
    private BarCheckItem barCheckItem2;
    private BarCheckItem barCheckItem3;
    private BarCheckItem barCheckItem4;
    private BarCheckItem barCheckItem5;
    private BarCheckItem barCheckItem6;
    private BarEditItem barEditItem5;
    private BarCheckItem barCheckItem7;
    private BarCheckItem barCheckItem9;
    private BarCheckItem barCheckItem10;
    private BarCheckItem barCheckItem11;
    private BarCheckItem barCheckItem12;
    private BarCheckItem barCheckItem13;
    private BarCheckItem barCheckItem8;
    private BarButtonItem barButtonItem9;
    private BarButtonItem barButtonItem10;
    private BarButtonItem barButtonItem11;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private ImageSlider ımageSlider1;
    private LabelControl labelControl1;
    private LabelControl labelControl2;
    private LabelControl labelControl3;

    public Hakkimizda() => this.InitializeComponent();

    private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void memoEdit1_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void labelControl1_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Makina_Ikmal.Hakkimizda.Hakkimizda));
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
      this.barCheckItem7 = new BarCheckItem();
      this.barCheckItem9 = new BarCheckItem();
      this.barCheckItem10 = new BarCheckItem();
      this.barCheckItem11 = new BarCheckItem();
      this.barCheckItem12 = new BarCheckItem();
      this.barCheckItem13 = new BarCheckItem();
      this.barCheckItem8 = new BarCheckItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barButtonItem10 = new BarButtonItem();
      this.barButtonItem11 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ımageSlider1 = new ImageSlider();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.ribbonControl1.BeginInit();
      ((ISupportInitialize) this.ımageSlider1).BeginInit();
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
        (BarItem) this.barButtonItem9,
        (BarItem) this.barButtonItem10,
        (BarItem) this.barButtonItem11
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 62;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
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
      this.ribbonControl1.Size = new Size(1004, 96);
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
      this.barEditItem5.Edit = (RepositoryItem) null;
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
      this.barButtonItem9.Id = 59;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem10.Id = 60;
      this.barButtonItem10.Name = "barButtonItem10";
      this.barButtonItem11.Caption = "Kapat";
      this.barButtonItem11.Id = 61;
      this.barButtonItem11.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.Image");
      this.barButtonItem11.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem11.ImageOptions.LargeImage");
      this.barButtonItem11.LargeWidth = 100;
      this.barButtonItem11.Name = "barButtonItem11";
      this.barButtonItem11.ItemClick += new ItemClickEventHandler(this.barButtonItem11_ItemClick);
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[1]
      {
        this.ribbonPageGroup1
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem11);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ımageSlider1.CurrentImageIndex = 0;
      this.ımageSlider1.Dock = DockStyle.Fill;
      this.ımageSlider1.Images.Add((Image) componentResourceManager.GetObject("ımageSlider1.Images"));
      this.ımageSlider1.Location = new Point(0, 96);
      this.ımageSlider1.Name = "ımageSlider1";
      this.ımageSlider1.Size = new Size(1004, 518);
      this.ımageSlider1.TabIndex = 4;
      this.ımageSlider1.Text = "ımageSlider1";
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.ForeColor = Color.Black;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.LineColor = Color.White;
      this.labelControl1.Location = new Point(373, 108);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(235, 24);
      this.labelControl1.TabIndex = 5;
      this.labelControl1.Text = "Sorumlu: Mustafa BAYAR";
      this.labelControl1.Click += new EventHandler(this.labelControl1_Click);
      this.labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.ForeColor = Color.Black;
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Appearance.Options.UseForeColor = true;
      this.labelControl2.LineColor = Color.White;
      this.labelControl2.Location = new Point(158, 149);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(201, 24);
      this.labelControl2.TabIndex = 7;
      this.labelControl2.Text = "İrtibat: 0535 082 88 02";
      this.labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl3.Appearance.ForeColor = Color.Black;
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Appearance.Options.UseForeColor = true;
      this.labelControl3.LineColor = Color.White;
      this.labelControl3.Location = new Point(628, 149);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(281, 24);
      this.labelControl3.TabIndex = 8;
      this.labelControl3.Text = "Mail: bayeryazilim@gmail.com";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1004, 614);
      this.Controls.Add((Control) this.labelControl3);
      this.Controls.Add((Control) this.labelControl2);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.ımageSlider1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (Hakkimizda);
      this.Text = nameof (Hakkimizda);
      this.ribbonControl1.EndInit();
      ((ISupportInitialize) this.ımageSlider1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
