// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.YagBolum.isbitenEmirTarih
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.YagBolum
{
  public class isbitenEmirTarih : XtraForm
  {
    private IContainer components = (IContainer) null;
    private LayoutControl layoutControl1;
    private SimpleButton simpleButton1;
    private TextEdit textEdit1;
    private TextEdit textEdit2;
    private DateEdit buyukTarih;
    private DateEdit kucukTarih;
    private LayoutControlGroup Root;
    private LayoutControlItem layoutControlItem1;
    private EmptySpaceItem emptySpaceItem1;
    private LayoutControlItem layoutControlItem4;
    private LayoutControlItem layoutControlItem3;
    private LayoutControlItem layoutControlItem2;
    private LayoutControlItem layoutControlItem6;
    private LookUpEdit lookUpEdit1;
    private LabelControl labelControl1;
    private LayoutControlItem layoutControlItem7;
    private LayoutControlItem layoutControlItem5;

    public isbitenEmirTarih() => this.InitializeComponent();

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      GunlukTarihRaporu gunlukTarihRaporu = new GunlukTarihRaporu();
      gunlukTarihRaporu.Parameters["kucuk"].Value = (object) Convert.ToDateTime(this.kucukTarih.EditValue);
      gunlukTarihRaporu.Parameters["kucuk"].Visible = false;
      gunlukTarihRaporu.Parameters["buyuk"].Value = (object) Convert.ToDateTime(this.buyukTarih.EditValue);
      gunlukTarihRaporu.Parameters["buyuk"].Visible = false;
      new ReportPrintTool((IReport) gunlukTarihRaporu).ShowPreviewDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.layoutControl1 = new LayoutControl();
      this.Root = new LayoutControlGroup();
      this.emptySpaceItem1 = new EmptySpaceItem();
      this.labelControl1 = new LabelControl();
      this.layoutControlItem7 = new LayoutControlItem();
      this.lookUpEdit1 = new LookUpEdit();
      this.simpleButton1 = new SimpleButton();
      this.textEdit1 = new TextEdit();
      this.textEdit2 = new TextEdit();
      this.buyukTarih = new DateEdit();
      this.kucukTarih = new DateEdit();
      this.layoutControlItem1 = new LayoutControlItem();
      this.layoutControlItem4 = new LayoutControlItem();
      this.layoutControlItem3 = new LayoutControlItem();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControlItem6 = new LayoutControlItem();
      this.layoutControlItem5 = new LayoutControlItem();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.Root.BeginInit();
      this.emptySpaceItem1.BeginInit();
      this.layoutControlItem7.BeginInit();
      this.lookUpEdit1.Properties.BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.textEdit2.Properties.BeginInit();
      this.buyukTarih.Properties.CalendarTimeProperties.BeginInit();
      this.buyukTarih.Properties.BeginInit();
      this.kucukTarih.Properties.CalendarTimeProperties.BeginInit();
      this.kucukTarih.Properties.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.layoutControlItem4.BeginInit();
      this.layoutControlItem3.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.layoutControlItem6.BeginInit();
      this.layoutControlItem5.BeginInit();
      this.SuspendLayout();
      this.layoutControl1.Controls.Add((Control) this.lookUpEdit1);
      this.layoutControl1.Controls.Add((Control) this.labelControl1);
      this.layoutControl1.Controls.Add((Control) this.simpleButton1);
      this.layoutControl1.Controls.Add((Control) this.textEdit1);
      this.layoutControl1.Controls.Add((Control) this.textEdit2);
      this.layoutControl1.Controls.Add((Control) this.buyukTarih);
      this.layoutControl1.Controls.Add((Control) this.kucukTarih);
      this.layoutControl1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.Location = new Point(15, 7);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = Color.LightGray;
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = HorzAlignment.Center;
      this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = VertAlignment.Center;
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(808, 318);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[8]
      {
        (BaseLayoutItem) this.layoutControlItem1,
        (BaseLayoutItem) this.emptySpaceItem1,
        (BaseLayoutItem) this.layoutControlItem4,
        (BaseLayoutItem) this.layoutControlItem3,
        (BaseLayoutItem) this.layoutControlItem2,
        (BaseLayoutItem) this.layoutControlItem6,
        (BaseLayoutItem) this.layoutControlItem7,
        (BaseLayoutItem) this.layoutControlItem5
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(808, 318);
      this.Root.TextVisible = false;
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new Point(0, 136);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new Size(248, 162);
      this.emptySpaceItem1.TextSize = new Size(0, 0);
      this.labelControl1.Location = new Point(510, 148);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(286, 158);
      this.labelControl1.StyleController = (IStyleController) this.layoutControl1;
      this.labelControl1.TabIndex = 11;
      this.layoutControlItem7.Control = (Control) this.labelControl1;
      this.layoutControlItem7.Location = new Point(498, 136);
      this.layoutControlItem7.MinSize = new Size(79, 20);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new Size(290, 162);
      this.layoutControlItem7.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem7.TextSize = new Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      this.lookUpEdit1.Location = new Point(195, 114);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit1.Properties.NullText = "";
      this.lookUpEdit1.Size = new Size(601, 30);
      this.lookUpEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.lookUpEdit1.TabIndex = 12;
      this.simpleButton1.ImageOptions.Image = (Image) Resources.defaultprinternetwork_32x32;
      this.simpleButton1.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
      this.simpleButton1.Location = new Point(260, 148);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.PaintStyle = PaintStyles.Light;
      this.simpleButton1.Size = new Size(246, 158);
      this.simpleButton1.StyleController = (IStyleController) this.layoutControl1;
      this.simpleButton1.TabIndex = 10;
      this.simpleButton1.Text = "Yazdır";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.textEdit1.Location = new Point(195, 80);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Size = new Size(601, 30);
      this.textEdit1.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit1.TabIndex = 8;
      this.textEdit2.Location = new Point(195, 46);
      this.textEdit2.Name = "textEdit2";
      this.textEdit2.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.textEdit2.Properties.Appearance.Options.UseFont = true;
      this.textEdit2.Size = new Size(601, 30);
      this.textEdit2.StyleController = (IStyleController) this.layoutControl1;
      this.textEdit2.TabIndex = 7;
      this.buyukTarih.EditValue = (object) null;
      this.buyukTarih.Location = new Point(589, 12);
      this.buyukTarih.Name = "buyukTarih";
      this.buyukTarih.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.buyukTarih.Properties.Appearance.Options.UseFont = true;
      this.buyukTarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.buyukTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.buyukTarih.Size = new Size(207, 30);
      this.buyukTarih.StyleController = (IStyleController) this.layoutControl1;
      this.buyukTarih.TabIndex = 5;
      this.kucukTarih.EditValue = (object) null;
      this.kucukTarih.Location = new Point(195, 12);
      this.kucukTarih.Name = "kucukTarih";
      this.kucukTarih.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kucukTarih.Properties.Appearance.Options.UseFont = true;
      this.kucukTarih.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kucukTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.kucukTarih.Size = new Size(207, 30);
      this.kucukTarih.StyleController = (IStyleController) this.layoutControl1;
      this.kucukTarih.TabIndex = 4;
      this.layoutControlItem1.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem1.Control = (Control) this.kucukTarih;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(394, 34);
      this.layoutControlItem1.Text = "Başlangıç Tarihi";
      this.layoutControlItem1.TextSize = new Size(171, 24);
      this.layoutControlItem4.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem4.Control = (Control) this.textEdit2;
      this.layoutControlItem4.Location = new Point(0, 34);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new Size(788, 34);
      this.layoutControlItem4.Text = "Yağ İçin Not";
      this.layoutControlItem4.TextSize = new Size(171, 24);
      this.layoutControlItem3.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem3.Control = (Control) this.textEdit1;
      this.layoutControlItem3.Location = new Point(0, 68);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new Size(788, 34);
      this.layoutControlItem3.Text = "Araç Sayısı İçin Not";
      this.layoutControlItem3.TextSize = new Size(171, 24);
      this.layoutControlItem2.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem2.Control = (Control) this.buyukTarih;
      this.layoutControlItem2.Location = new Point(394, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(394, 34);
      this.layoutControlItem2.Text = "Bitiş Tarihi";
      this.layoutControlItem2.TextSize = new Size(171, 24);
      this.layoutControlItem6.Control = (Control) this.simpleButton1;
      this.layoutControlItem6.Location = new Point(248, 136);
      this.layoutControlItem6.MinSize = new Size(81, 40);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new Size(250, 162);
      this.layoutControlItem6.SizeConstraintsType = SizeConstraintsType.Custom;
      this.layoutControlItem6.TextSize = new Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem5.AppearanceItemCaption.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
      this.layoutControlItem5.Control = (Control) this.lookUpEdit1;
      this.layoutControlItem5.Location = new Point(0, 102);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsPrint.AppearanceItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.layoutControlItem5.OptionsPrint.AppearanceItem.Options.UseFont = true;
      this.layoutControlItem5.Size = new Size(788, 34);
      this.layoutControlItem5.Text = "Müdür Adı Soyadı";
      this.layoutControlItem5.TextSize = new Size(171, 24);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(835, 360);
      this.Controls.Add((Control) this.layoutControl1);
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (isbitenEmirTarih);
      this.Text = nameof (isbitenEmirTarih);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.Root.EndInit();
      this.emptySpaceItem1.EndInit();
      this.layoutControlItem7.EndInit();
      this.lookUpEdit1.Properties.EndInit();
      this.textEdit1.Properties.EndInit();
      this.textEdit2.Properties.EndInit();
      this.buyukTarih.Properties.CalendarTimeProperties.EndInit();
      this.buyukTarih.Properties.EndInit();
      this.kucukTarih.Properties.CalendarTimeProperties.EndInit();
      this.kucukTarih.Properties.EndInit();
      this.layoutControlItem1.EndInit();
      this.layoutControlItem4.EndInit();
      this.layoutControlItem3.EndInit();
      this.layoutControlItem2.EndInit();
      this.layoutControlItem6.EndInit();
      this.layoutControlItem5.EndInit();
      this.ResumeLayout(false);
    }
  }
}
