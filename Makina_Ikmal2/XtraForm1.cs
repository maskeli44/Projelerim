// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.XtraForm1
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal
{
  public class XtraForm1 : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private GridControl gridControl1;
    private GridView gridView1;
    private XtraOpenFileDialog xtraOpenFileDialog1;
    private SimpleButton simpleButton1;

    public XtraForm1() => this.InitializeComponent();

    private void XtraForm1_Load(object sender, EventArgs e)
    {
    }

    private void leftjoin() => this.gridControl1.DataSource = (object) this.db.TBLDEPOFIS.GroupJoin((IEnumerable<TBLDEPOFISHRKT>) this.db.TBLDEPOFISHRKT, (Expression<Func<TBLDEPOFIS, int?>>) (u => (int?) u.ID), (Expression<Func<TBLDEPOFISHRKT, int?>>) (p => p.DEPOFISID), (u, gj) => new
    {
      u = u,
      gj = gj
    }).SelectMany(data => data.gj.DefaultIfEmpty<TBLDEPOFISHRKT>(), (data, x) => new
    {
      \u003C\u003Eh__TransparentIdentifier0 = data,
      x = x
    }).GroupJoin((IEnumerable<TBLISEMRI>) this.db.TBLISEMRI, data => data.\u003C\u003Eh__TransparentIdentifier0.u.ISEMRIID, (Expression<Func<TBLISEMRI, int?>>) (t => (int?) t.ID), (data, gt) => new
    {
      \u003C\u003Eh__TransparentIdentifier1 = data,
      gt = gt
    }).SelectMany(data => data.gt.DefaultIfEmpty<TBLISEMRI>(), (data, xt) => new
    {
      \u003C\u003Eh__TransparentIdentifier2 = data,
      xt = xt
    }).GroupJoin((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, data => data.xt.ARACID, (Expression<Func<TBLARACLAR, int?>>) (a => (int?) a.ID), (data, ga) => new
    {
      \u003C\u003Eh__TransparentIdentifier3 = data,
      ga = ga
    }).SelectMany(data => data.ga.DefaultIfEmpty<TBLARACLAR>(), (data, xa) => new
    {
      \u003C\u003Eh__TransparentIdentifier4 = data,
      xa = xa
    }).Where(data => data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.u.ISLEMTIPIID == "3").Select(data => new
    {
      UsergroupID = data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.u.KOD,
      ISEMRIID = data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.u.ISEMRIID,
      ID = data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.u.ID,
      KOD = data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.xt.KOD,
      PLAKA = data.xa.PLAKA
    }).Distinct().ToList();

    private void groupbydenem()
    {
      IQueryable<TBLDEPOFISHRKT> source = this.db.TBLDEPOFISHRKT.GroupJoin((IEnumerable<TBLDEPOFIS>) this.db.TBLDEPOFIS, (Expression<Func<TBLDEPOFISHRKT, int?>>) (p => p.DEPOFISID), (Expression<Func<TBLDEPOFIS, int?>>) (depofis => (int?) depofis.ID), (p, gd) => new
      {
        p = p,
        gd = gd
      }).SelectMany(data => data.gd.DefaultIfEmpty<TBLDEPOFIS>(), (data, gx) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        gx = gx
      }).GroupJoin((IEnumerable<TBLMALZEMELER>) this.db.TBLMALZEMELER, data => data.\u003C\u003Eh__TransparentIdentifier0.p.MALZEMEID, (Expression<Func<TBLMALZEMELER, int?>>) (malzeme => (int?) malzeme.ID), (data, gm) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        gm = gm
      }).SelectMany(data => data.gm.DefaultIfEmpty<TBLMALZEMELER>(), (data, mx) => new
      {
        \u003C\u003Eh__TransparentIdentifier2 = data,
        mx = mx
      }).GroupJoin((IEnumerable<TBLMALZGRUP>) this.db.TBLMALZGRUP, data => data.mx.GRUPID, (Expression<Func<TBLMALZGRUP, int?>>) (malgr => (int?) malgr.ID), (data, grt) => new
      {
        \u003C\u003Eh__TransparentIdentifier3 = data,
        grt = grt
      }).SelectMany(data => data.grt.DefaultIfEmpty<TBLMALZGRUP>(), (data, grx) => new
      {
        \u003C\u003Eh__TransparentIdentifier4 = data,
        grx = grx
      }).GroupJoin((IEnumerable<TBLMALZBIRIM>) this.db.TBLMALZBIRIM, data => data.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.mx.BIRIMID, (Expression<Func<TBLMALZBIRIM, int?>>) (bir => (int?) bir.ID), (data, birg) => new
      {
        \u003C\u003Eh__TransparentIdentifier5 = data,
        birg = birg
      }).SelectMany(data => data.birg.DefaultIfEmpty<TBLMALZBIRIM>(), (data, gf) => data.\u003C\u003Eh__TransparentIdentifier5.\u003C\u003Eh__TransparentIdentifier4.\u003C\u003Eh__TransparentIdentifier3.\u003C\u003Eh__TransparentIdentifier2.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.p);
      this.gridControl1.DataSource = (object) null;
      this.gridControl1.DataSource = (object) source.Distinct<TBLDEPOFISHRKT>().GroupBy<TBLDEPOFISHRKT, Decimal?>((Expression<Func<TBLDEPOFISHRKT, Decimal?>>) (x => x.MIKTAR)).ToList<IGrouping<Decimal?, TBLDEPOFISHRKT>>();
    }

    private void simpleButton1_Click(object sender, EventArgs e) => this.groupbydenem();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.xtraOpenFileDialog1 = new XtraOpenFileDialog(this.components);
      this.simpleButton1 = new SimpleButton();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.SuspendLayout();
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(921, 644);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
      this.simpleButton1.Location = new Point(344, 5);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(94, 29);
      this.simpleButton1.TabIndex = 1;
      this.simpleButton1.Text = "simpleButton1";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(921, 644);
      this.Controls.Add((Control) this.simpleButton1);
      this.Controls.Add((Control) this.gridControl1);
      this.Name = nameof (XtraForm1);
      this.Text = nameof (XtraForm1);
      this.Load += new EventHandler(this.XtraForm1_Load);
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.ResumeLayout(false);
    }
  }
}
