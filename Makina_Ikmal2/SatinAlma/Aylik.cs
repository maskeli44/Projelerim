// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.SatinAlma.Aylik
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Makina_Ikmal.SatinAlma
{
  public class Aylik : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private Chart chart1;
    private LayoutControlItem layoutControlItem1;
    private BarManager barManager1;
    private Bar bar1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarButtonItem barButtonItem1;

    public Aylik() => this.InitializeComponent();

    private void Aylik_Load(object sender, EventArgs e) => this.Yenile();

    private void Yenile()
    {
      IQueryable<IGrouping<int, TBLTEKLIF>> source = this.db.TBLTEKLIF.Where<TBLTEKLIF>((Expression<Func<TBLTEKLIF, bool>>) (hd => hd.FATURATARIHI.Value.Year == DateTime.Now.Year)).GroupBy<TBLTEKLIF, int>((Expression<Func<TBLTEKLIF, int>>) (hd => hd.FATURATARIHI.Value.Month));
      Expression<Func<IGrouping<int, TBLTEKLIF>, \u003C\u003Ef__AnonymousType57<Decimal, DateTime?>>> selector = sorguGroup => new
      {
        FATURATUTAR = sorguGroup.Sum<TBLTEKLIF>((Func<TBLTEKLIF, Decimal?>) (x => x.FATURATUTAR)).Value,
        FATURATARIHI2 = sorguGroup.FirstOrDefault<TBLTEKLIF>().FATURATARIHI
      };
      foreach (var data in source.Select(selector))
      {
        int num;
        if (data.FATURATARIHI2.HasValue)
        {
          Decimal faturatutar = data.FATURATUTAR;
          num = 1;
        }
        else
          num = 0;
        if (num != 0)
        {
          DataPointCollection points = this.chart1.Series["Teklifler"].Points;
          DateTime dateTime = data.FATURATARIHI2.Value;
          string xValue = dateTime.ToString("MMMM");
          object[] objArray = new object[1]
          {
            (object) data.FATURATUTAR
          };
          points.AddXY((object) xValue, objArray);
          Series series = this.chart1.Series["Teklifler"];
          dateTime = data.FATURATARIHI2.Value;
          string str = dateTime.ToString("MMMM") + " " + data.FATURATUTAR.ToString("C2");
          series.LegendText = str;
          this.chart1.Series["Teklifler"].LabelFormat = "C2";
          this.chart1.Series["Teklifler"].IsValueShownAsLabel = true;
        }
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
      ChartArea chartArea = new ChartArea();
      Legend legend = new Legend();
      Series series = new Series();
      Title title = new Title();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Aylik));
      this.layoutControl1 = new LayoutControl();
      this.chart1 = new Chart();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem1 = new LayoutControlItem();
      this.barManager1 = new BarManager(this.components);
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.bar1 = new Bar();
      this.barButtonItem1 = new BarButtonItem();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.chart1.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem1.BeginInit();
      this.barManager1.BeginInit();
      this.SuspendLayout();
      this.layoutControl1.Controls.Add((Control) this.chart1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 24);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(1061, 635);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      this.chart1.BorderlineDashStyle = ChartDashStyle.Dash;
      chartArea.Area3DStyle.Enable3D = true;
      chartArea.Area3DStyle.WallWidth = 0;
      chartArea.Name = "ChartArea1";
      chartArea.ShadowColor = Color.White;
      this.chart1.ChartAreas.Add(chartArea);
      legend.Name = "Legend1";
      this.chart1.Legends.Add(legend);
      this.chart1.Location = new Point(12, 12);
      this.chart1.Name = "chart1";
      series.ChartArea = "ChartArea1";
      series.Legend = "Legend1";
      series.Name = "Teklifler";
      series.YValuesPerPoint = 3;
      this.chart1.Series.Add(series);
      this.chart1.Size = new Size(1037, 611);
      this.chart1.TabIndex = 4;
      this.chart1.Text = "Aylık Grafik";
      title.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      title.Name = "sffs";
      title.Text = "MAKİNA İKMAL ŞUBE MÜDÜRLÜĞÜ AYLIK HARCAMA GRAFİĞİ";
      this.chart1.Titles.Add(title);
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem1
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(1061, 635);
      this.Root.TextVisible = false;
      this.layoutControlItem1.Control = (Control) this.chart1;
      this.layoutControlItem1.Location = new Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new Size(1041, 615);
      this.layoutControlItem1.TextLocation = Locations.Top;
      this.layoutControlItem1.TextSize = new Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar1 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[1]
      {
        (BarItem) this.barButtonItem1
      });
      this.barManager1.MaxItemId = 2;
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new Size(1061, 24);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 659);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new Size(1061, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 24);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new Size(0, 635);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1061, 24);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new Size(0, 635);
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockStyle = BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[1]
      {
        new LinkPersistInfo((BarItem) this.barButtonItem1)
      });
      this.bar1.Text = "Tools";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.Name = "barButtonItem1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1061, 659);
      this.Controls.Add((Control) this.layoutControl1);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (Aylik);
      this.Text = nameof (Aylik);
      this.Load += new EventHandler(this.Aylik_Load);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.chart1.EndInit();
      this.Root.EndInit();
      this.layoutControlItem1.EndInit();
      this.barManager1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
