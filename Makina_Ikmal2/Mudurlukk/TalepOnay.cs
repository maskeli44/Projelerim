// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Mudurlukk.TalepOnay
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.DepoModel;
using Makina_Ikmal.DepoModel.talepFisListesi1TableAdapters;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.Mudurlukk
{
  public class TalepOnay : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private GridControl gridControl1;
    private GridView gridView1;
    private talepFisListesi1 talepFisListesi1;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;

    public TalepOnay() => this.InitializeComponent();

    private void TalepOnay_Load(object sender, EventArgs e) => this.listele();

    public void listele()
    {
      MudurOnay.list.Clear();
      string str1 = "";
      DbSet<TBLTALEPFIS> tbltalepfis1 = this.db.TBLTALEPFIS;
      Expression<System.Func<TBLTALEPFIS, int>> keySelector = (Expression<System.Func<TBLTALEPFIS, int>>) (hd => hd.ID);
      foreach (TBLTALEPFIS tbltalepfis2 in (IEnumerable<TBLTALEPFIS>) tbltalepfis1.OrderBy<TBLTALEPFIS, int>(keySelector))
      {
        int? talepdurumid = tbltalepfis2.TALEPDURUMID;
        int num1 = 1;
        if (talepdurumid.GetValueOrDefault() == num1 & talepdurumid.HasValue)
        {
          str1 = "Olur Bekliyor";
        }
        else
        {
          talepdurumid = tbltalepfis2.TALEPDURUMID;
          int num2 = 2;
          if (talepdurumid.GetValueOrDefault() == num2 & talepdurumid.HasValue)
          {
            str1 = "Onaylandı";
          }
          else
          {
            talepdurumid = tbltalepfis2.TALEPDURUMID;
            int num3 = 3;
            if (talepdurumid.GetValueOrDefault() == num3 & talepdurumid.HasValue)
              str1 = "Olura Göndeildi";
          }
        }
        MudurOnay.list.Add(new Degerler()
        {
          ID = tbltalepfis2.ID,
          BOLUM = "Talep Bölümü",
          TARIH = tbltalepfis2.TARIH.ToString(),
          DURUMU = str1,
          KOD = tbltalepfis2.KOD
        });
      }
      DbSet<TBLTASITGOREV> tbltasitgorev1 = this.db.TBLTASITGOREV;
      Expression<System.Func<TBLTASITGOREV, TBLTASITGOREV>> selector = (Expression<System.Func<TBLTASITGOREV, TBLTASITGOREV>>) (hf => hf);
      foreach (TBLTASITGOREV tbltasitgorev2 in (IEnumerable<TBLTASITGOREV>) tbltasitgorev1.Select<TBLTASITGOREV, TBLTASITGOREV>(selector))
      {
        string str2 = !(tbltasitgorev2.MUDONAYZAMAN == "1") ? (!(tbltasitgorev2.MUDONAYZAMAN == "2") ? "Olur Bekliyor" : "Onaylandı") : "Olur Bekliyor";
        MudurOnay.list.Add(new Degerler()
        {
          ID = tbltasitgorev2.ID,
          BOLUM = "Taşıt Görev",
          TARIH = tbltasitgorev2.CIKISZAMANI.ToString(),
          DURUMU = str2,
          KOD = tbltasitgorev2.KOD
        });
      }
      this.gridControl1.DataSource = (object) MudurOnay.list.ToList<Degerler>();
    }

    public void res() => this.Close();

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      if (this.gridView1.GetFocusedRowCellValue("BOLUM").ToString() == "Talep Bölümü")
      {
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        new TalepDuzenleme().Show();
      }
      else
      {
        if (!(this.gridView1.GetFocusedRowCellValue("BOLUM").ToString() == "Taşıt Görev"))
          return;
        YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
        TasitGorevEmriDuzenle gorevEmriDuzenle = new TasitGorevEmriDuzenle();
        gorevEmriDuzenle.guncelleLoad(YetkiClass.secim_id);
        gorevEmriDuzenle.Show();
      }
    }

    private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      string str = (sender as GridView).GetRowCellValue(e.RowHandle, "DURUMU").ToString();
      if (!(str == "Onaylandı") && !(str == "Olura Göndeildi"))
        return;
      e.Appearance.BackColor = Color.Green;
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
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.talepFisListesi1 = new talepFisListesi1();
      this.gridView1 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.gridColumn4 = new GridColumn();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.gridColumn5 = new GridColumn();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.talepFisListesi1.BeginInit();
      this.gridView1.BeginInit();
      this.SuspendLayout();
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1445, 717);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.talepFisListesi1;
      this.talepFisListesi1.DataSetName = "talepFisListesi1";
      this.talepFisListesi1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 12f);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.gridColumn5,
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3,
        this.gridColumn4
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.RowHeight = 35;
      this.gridView1.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gridColumn4, ColumnSortOrder.Descending)
      });
      this.gridView1.RowCellStyle += new RowCellStyleEventHandler(this.gridView1_RowCellStyle);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.gridColumn1.Caption = "Birim";
      this.gridColumn1.FieldName = "BOLUM";
      this.gridColumn1.MinWidth = 25;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.AllowEdit = false;
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 1;
      this.gridColumn1.Width = 214;
      this.gridColumn2.Caption = "Tarih";
      this.gridColumn2.FieldName = "TARIH";
      this.gridColumn2.MinWidth = 25;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.AllowEdit = false;
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 2;
      this.gridColumn2.Width = 214;
      this.gridColumn3.Caption = "ONAY DURUMU";
      this.gridColumn3.FieldName = "DURUMU";
      this.gridColumn3.MinWidth = 25;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.AllowEdit = false;
      this.gridColumn3.OptionsColumn.ReadOnly = true;
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 3;
      this.gridColumn3.Width = 216;
      this.gridColumn4.Caption = "gridColumn4";
      this.gridColumn4.FieldName = "ID";
      this.gridColumn4.MinWidth = 25;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.OptionsColumn.AllowEdit = false;
      this.gridColumn4.OptionsColumn.ReadOnly = true;
      this.gridColumn4.Width = 94;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.gridColumn5.Caption = "KODU";
      this.gridColumn5.FieldName = "KOD";
      this.gridColumn5.MinWidth = 25;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Visible = true;
      this.gridColumn5.VisibleIndex = 0;
      this.gridColumn5.Width = 153;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1445, 717);
      this.Controls.Add((Control) this.gridControl1);
      this.Name = nameof (TalepOnay);
      this.Text = nameof (TalepOnay);
      this.Load += new EventHandler(this.TalepOnay_Load);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.talepFisListesi1.EndInit();
      this.gridView1.EndInit();
      this.ResumeLayout(false);
    }
  }
}
