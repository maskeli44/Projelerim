// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Tasit.Filtrele
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Tasit
{
  public class Filtrele : XtraForm
  {
    public DateTime ilkTarih = DateTime.Today;
    public DateTime sonTarih = DateTime.Today;
    private IContainer components = (IContainer) null;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private DateEdit dateEdit2;
    private DateEdit dateEdit1;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem4;
    private LayoutControl layoutControl2;
    private LayoutControlGroup layoutControlGroup1;
    private LayoutControlItem layoutControlItem5;

    public Filtrele() => this.InitializeComponent();

    private void simpleButton2_Click(object sender, EventArgs e) => this.Close();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      this.ilkTarih = this.dateEdit1.DateTime;
      this.sonTarih = this.dateEdit2.DateTime;
      this.Close();
    }

    private void Filtrele_Load(object sender, EventArgs e)
    {
      this.dateEdit1.DateTime = this.ilkTarih;
      this.dateEdit2.DateTime = this.sonTarih;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Filtrele));
      this.layoutControl1 = new LayoutControl();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.dateEdit2 = new DateEdit();
      this.dateEdit1 = new DateEdit();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControl2 = new LayoutControl();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControlGroup1 = new LayoutControlGroup();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.dateEdit2.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit2.Properties.BeginInit();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControl2.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.layoutControlGroup1.BeginInit();
      this.SuspendLayout();
      this.layoutControl1.Controls.Add((Control) this.layoutControl2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton2);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.dateEdit2);
      this.layoutControl1.Controls.Add((Control) this.dateEdit1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(401, 322);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      this.simpleButton2.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton2.Appearance.Options.UseFont = true;
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.Location = new Point(202, 217);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(187, 93);
      this.simpleButton2.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton2.TabIndex = 7;
      this.simpleButton2.Text = "Filtreleme İptal";
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.simpleButton1.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton1.ImageOptions.Image");
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.simpleButton1.Location = new Point(12, 217);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(186, 93);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 6;
      this.simpleButton1.Text = nameof (Filtrele);
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.dateEdit2.EditValue = (object) null;
      this.dateEdit2.Location = new Point(12, 120);
      this.dateEdit2.Name = "dateEdit2";
      this.dateEdit2.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateEdit2.Properties.Appearance.Options.UseFont = true;
      this.dateEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Size = new Size(377, 24);
      this.dateEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit2.TabIndex = 5;
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(12, 92);
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateEdit1.Properties.Appearance.Options.UseFont = true;
      this.dateEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Size = new Size(377, 24);
      this.dateEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.dateEdit1.TabIndex = 4;
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[6]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem5
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(401, 322);
      this.Root.TextVisible = false;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.dateEdit1;
      this.layoutControlItem1.Location = new Point(0, 80);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(381, 28);
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 136);
      this.emptySpaceItem1.MinSize = new Size(104, 24);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(381, 69);
      this.emptySpaceItem1.SizeConstraintsType = SizeConstraintsType.Custom;
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.dateEdit2;
      this.layoutControlItem2.Location = new Point(0, 108);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(381, 28);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.layoutControlItem3.Control = (Control) this.simpleButton1;
      this.layoutControlItem3.Location = new Point(0, 205);
      this.layoutControlItem3.MinSize = new Size(78, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(190, 97);
      this.layoutControlItem3.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      this.layoutControlItem4.Control = (Control) this.simpleButton2;
      this.layoutControlItem4.Location = new Point(190, 205);
      this.layoutControlItem4.MinSize = new Size(78, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(191, 97);
      this.layoutControlItem4.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControl2.Location = new Point(12, 12);
      this.layoutControl2.Name = "layoutControl2";
      this.layoutControl2.Root = this.layoutControlGroup1;
      this.layoutControl2.Size = new Size(377, 76);
      this.layoutControl2.TabIndex = 8;
      this.layoutControl2.Text = "layoutControl2";
      this.layoutControlItem5.Control = (Control) this.layoutControl2;
      this.layoutControlItem5.Location = new Point(0, 0);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new Size(381, 80);
      this.layoutControlItem5.TextSize = new Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new Size(377, 76);
      this.layoutControlGroup1.TextVisible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(401, 322);
      this.Controls.Add((Control) this.layoutControl1);
      this.Name = nameof (Filtrele);
      this.Text = nameof (Filtrele);
      this.Load += new EventHandler(this.Filtrele_Load);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.dateEdit2.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit2.Properties.EndInit();
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControl2.EndInit();
      this.layoutControlItem5.EndInit();
      this.layoutControlGroup1.EndInit();
      this.ResumeLayout(false);
    }
  }
}
