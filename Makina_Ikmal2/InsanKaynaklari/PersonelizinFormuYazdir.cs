// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.PersonelizinFormuYazdir
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using Makina_Ikmal.Model.izinListesiTableAdapters;
using Makina_Ikmal.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class PersonelizinFormuYazdir : Form
  {
    public int yazdir_id;
    private IContainer components = (IContainer) null;
    private PrintDocument printDocument1;
    private PrintPreviewDialog printPreviewDialog1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private ReportViewer reportViewer1;
    private BindingSource dataTable1BindingSource;
    private izinListesi izinListesi;
    private DataTable1TableAdapter dataTable1TableAdapter;

    public PersonelizinFormuYazdir() => this.InitializeComponent();

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      Font font1 = new Font("Calibri", 15f);
      Font font2 = new Font("Calibri", 12f);
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      Pen pen = new Pen(Color.Black);
      e.Graphics.DrawImage(this.pictureBox1.Image, 30, 20, 80, 80);
      e.Graphics.DrawImage(this.pictureBox2.Image, 650, 30, 100, 80);
      e.Graphics.DrawLine(pen, 120, 180, 750, 180);
      e.Graphics.DrawLine(pen, 120, 240, 750, 240);
      e.Graphics.DrawString("T.C.", font1, (Brush) solidBrush, 350f, 40f);
      e.Graphics.DrawString("ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI", font1, (Brush) solidBrush, 200f, 60f);
      e.Graphics.DrawString("Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü", font2, (Brush) solidBrush, 150f, 100f);
      e.Graphics.DrawString("Personel İzin Formu", font2, (Brush) solidBrush, 250f, 120f);
    }

    private void PersonelizinFormu_Load(object sender, EventArgs e) => this.reportViewer1.RefreshReport();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PersonelizinFormuYazdir));
      ReportDataSource reportDataSource = new ReportDataSource();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.izinListesi = new izinListesi();
      this.printDocument1 = new PrintDocument();
      this.printPreviewDialog1 = new PrintPreviewDialog();
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.reportViewer1 = new ReportViewer();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.izinListesi.BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.izinListesi;
      this.izinListesi.DataSetName = "izinListesi";
      this.izinListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
      this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
      this.printPreviewDialog1.ClientSize = new Size(400, 300);
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = (Icon) componentResourceManager.GetObject("printPreviewDialog1.Icon");
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.Text = "Baskı önizleme";
      this.printPreviewDialog1.Visible = false;
      this.pictureBox2.Image = (Image) Resources.isobelgesi;
      this.pictureBox2.Location = new Point(783, 64);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(175, 86);
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      this.pictureBox1.Location = new Point(65, 44);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(132, 126);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.reportViewer1.Dock = DockStyle.Fill;
      reportDataSource.Name = "DataSet1";
      reportDataSource.Value = (object) this.dataTable1BindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Makina_Ikmal.InsanKaynaklari.Report2.rdlc";
      this.reportViewer1.Location = new Point(0, 0);
      this.reportViewer1.Margin = new Padding(0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = (string) null;
      this.reportViewer1.Size = new Size(1056, 738);
      this.reportViewer1.TabIndex = 1;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1056, 738);
      this.Controls.Add((Control) this.reportViewer1);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Name = "PersonelizinFormu";
      this.Text = "PersonelizinFormu";
      this.Load += new EventHandler(this.PersonelizinFormu_Load);
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.izinListesi.EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
