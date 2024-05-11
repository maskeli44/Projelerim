// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.Mudurizinformu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using Makina_Ikmal.Model.izinListesiTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class Mudurizinformu : Form
  {
    private IContainer components = (IContainer) null;
    private ReportViewer reportViewer1;
    private BindingSource dataTable1BindingSource;
    private izinListesi izinListesi;
    private DataTable1TableAdapter dataTable1TableAdapter;

    public Mudurizinformu() => this.InitializeComponent();

    private void Mudurizinformu_Load(object sender, EventArgs e) => this.reportViewer1.RefreshReport();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ReportDataSource reportDataSource = new ReportDataSource();
      this.reportViewer1 = new ReportViewer();
      this.izinListesi = new izinListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.izinListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.SuspendLayout();
      this.reportViewer1.Dock = DockStyle.Fill;
      reportDataSource.Name = "DataSet1";
      reportDataSource.Value = (object) this.dataTable1BindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Makina_Ikmal.InsanKaynaklari.mudur.rdlc";
      this.reportViewer1.Location = new Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = (string) null;
      this.reportViewer1.Size = new Size(1069, 788);
      this.reportViewer1.TabIndex = 0;
      this.izinListesi.DataSetName = "izinListesi";
      this.izinListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.izinListesi;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1069, 788);
      this.Controls.Add((Control) this.reportViewer1);
      this.Name = nameof (Mudurizinformu);
      this.Text = nameof (Mudurizinformu);
      this.Load += new EventHandler(this.Mudurizinformu_Load);
      this.izinListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
    }
  }
}
