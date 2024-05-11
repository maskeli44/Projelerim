// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.DenemeListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class DenemeListesi : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn RESIM2;

    public DenemeListesi() => this.InitializeComponent();

    private void DenemeListesi_Load(object sender, EventArgs e) => this.dataGridView1.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dataGridView1 = new DataGridView();
      this.RESIM2 = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.RESIM2);
      this.dataGridView1.Dock = DockStyle.Fill;
      this.dataGridView1.Location = new Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new Size(1073, 698);
      this.dataGridView1.TabIndex = 0;
      this.RESIM2.DataPropertyName = "RESIM2";
      this.RESIM2.HeaderText = "RESIM2";
      this.RESIM2.Name = "RESIM2";
      this.RESIM2.Resizable = DataGridViewTriState.True;
      this.RESIM2.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1073, 698);
      this.Controls.Add((Control) this.dataGridView1);
      this.Name = nameof (DenemeListesi);
      this.Text = nameof (DenemeListesi);
      this.Load += new EventHandler(this.DenemeListesi_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
