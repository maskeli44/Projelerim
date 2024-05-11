// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.izListeformu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using ADGV;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.izinListesiTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class izListeformu : Form
  {
    private IContainer components = (IContainer) null;
    private AdvancedDataGridView advancedDataGridView1;
    private BindingSource izinListesiBindingSource;
    private izinListesi izinListesi;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private DataGridViewTextBoxColumn ıZINTURUDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINYILLARIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINSURESIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bASLANGICTARIHIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bITISTARIHIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINGUNSAYDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gOREVEBASTARIHDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn aDISOYADIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn uNVANDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn kURUMGOREVDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gOREVUNVANIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn uNVANIDDataGridViewTextBoxColumn;
    private BindingSource dataTable1BindingSource1;
    private BindingSource dataTable1BindingSource2;
    private BindingSource dataTable1BindingSource3;

    public izListeformu() => this.InitializeComponent();

    private void izListeformu_Load(object sender, EventArgs e)
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
      this.components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.advancedDataGridView1 = new AdvancedDataGridView();
      this.ıZINTURUDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINYILLARIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINSURESIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bASLANGICTARIHIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bITISTARIHIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINGUNSAYDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gOREVEBASTARIHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.aDISOYADIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.uNVANDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.kURUMGOREVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.dataTable1BindingSource2 = new BindingSource(this.components);
      this.izinListesi = new izinListesi();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.izinListesiBindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.dataTable1BindingSource3 = new BindingSource(this.components);
      ((ISupportInitialize) this.advancedDataGridView1).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).BeginInit();
      this.izinListesi.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      ((ISupportInitialize) this.izinListesiBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource3).BeginInit();
      this.SuspendLayout();
      this.advancedDataGridView1.AllowUserToAddRows = false;
      this.advancedDataGridView1.AutoGenerateColumns = false;
      this.advancedDataGridView1.AutoGenerateContextFilters = true;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.Red;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.advancedDataGridView1.Columns.AddRange((DataGridViewColumn) this.ıZINTURUDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINYILLARIDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINSURESIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bASLANGICTARIHIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bITISTARIHIDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINGUNSAYDataGridViewTextBoxColumn, (DataGridViewColumn) this.gOREVEBASTARIHDataGridViewTextBoxColumn, (DataGridViewColumn) this.aDISOYADIDataGridViewTextBoxColumn, (DataGridViewColumn) this.uNVANDataGridViewTextBoxColumn, (DataGridViewColumn) this.kURUMGOREVDataGridViewTextBoxColumn);
      this.advancedDataGridView1.DataSource = (object) this.dataTable1BindingSource3;
      this.advancedDataGridView1.DateWithTime = false;
      this.advancedDataGridView1.Dock = DockStyle.Fill;
      this.advancedDataGridView1.Location = new Point(0, 0);
      this.advancedDataGridView1.Name = "advancedDataGridView1";
      this.advancedDataGridView1.ReadOnly = true;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.advancedDataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle2;
      this.advancedDataGridView1.RowHeadersVisible = false;
      this.advancedDataGridView1.RowHeadersWidth = 60;
      this.advancedDataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.advancedDataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
      this.advancedDataGridView1.RowTemplate.Height = 60;
      this.advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.advancedDataGridView1.Size = new Size(1116, 568);
      this.advancedDataGridView1.TabIndex = 1;
      this.advancedDataGridView1.TimeFilter = false;
      this.ıZINTURUDataGridViewTextBoxColumn.DataPropertyName = "IZINTURU";
      this.ıZINTURUDataGridViewTextBoxColumn.HeaderText = "IZINTURU";
      this.ıZINTURUDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINTURUDataGridViewTextBoxColumn.Name = "ıZINTURUDataGridViewTextBoxColumn";
      this.ıZINTURUDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINTURUDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINYILLARIDataGridViewTextBoxColumn.DataPropertyName = "IZINYILLARI";
      this.ıZINYILLARIDataGridViewTextBoxColumn.HeaderText = "IZINYILLARI";
      this.ıZINYILLARIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINYILLARIDataGridViewTextBoxColumn.Name = "ıZINYILLARIDataGridViewTextBoxColumn";
      this.ıZINYILLARIDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINYILLARIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINSURESIDataGridViewTextBoxColumn.DataPropertyName = "IZINSURESI";
      this.ıZINSURESIDataGridViewTextBoxColumn.HeaderText = "IZINSURESI";
      this.ıZINSURESIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINSURESIDataGridViewTextBoxColumn.Name = "ıZINSURESIDataGridViewTextBoxColumn";
      this.ıZINSURESIDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINSURESIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.DataPropertyName = "BASLANGICTARIHI";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.HeaderText = "BASLANGICTARIHI";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.Name = "bASLANGICTARIHIDataGridViewTextBoxColumn";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bITISTARIHIDataGridViewTextBoxColumn.DataPropertyName = "BITISTARIHI";
      this.bITISTARIHIDataGridViewTextBoxColumn.HeaderText = "BITISTARIHI";
      this.bITISTARIHIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bITISTARIHIDataGridViewTextBoxColumn.Name = "bITISTARIHIDataGridViewTextBoxColumn";
      this.bITISTARIHIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bITISTARIHIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.DataPropertyName = "IZINGUNSAY";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.HeaderText = "IZINGUNSAY";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.Name = "ıZINGUNSAYDataGridViewTextBoxColumn";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.DataPropertyName = "GOREVEBASTARIH";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.HeaderText = "GOREVEBASTARIH";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.Name = "gOREVEBASTARIHDataGridViewTextBoxColumn";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.ReadOnly = true;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.aDISOYADIDataGridViewTextBoxColumn.DataPropertyName = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.HeaderText = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.aDISOYADIDataGridViewTextBoxColumn.Name = "aDISOYADIDataGridViewTextBoxColumn";
      this.aDISOYADIDataGridViewTextBoxColumn.ReadOnly = true;
      this.aDISOYADIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.uNVANDataGridViewTextBoxColumn.DataPropertyName = "UNVAN";
      this.uNVANDataGridViewTextBoxColumn.HeaderText = "UNVAN";
      this.uNVANDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.uNVANDataGridViewTextBoxColumn.Name = "uNVANDataGridViewTextBoxColumn";
      this.uNVANDataGridViewTextBoxColumn.ReadOnly = true;
      this.uNVANDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.kURUMGOREVDataGridViewTextBoxColumn.DataPropertyName = "KURUMGOREV";
      this.kURUMGOREVDataGridViewTextBoxColumn.HeaderText = "KURUMGOREV";
      this.kURUMGOREVDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.kURUMGOREVDataGridViewTextBoxColumn.Name = "kURUMGOREVDataGridViewTextBoxColumn";
      this.kURUMGOREVDataGridViewTextBoxColumn.ReadOnly = true;
      this.kURUMGOREVDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.dataTable1BindingSource2.DataMember = "DataTable1";
      this.dataTable1BindingSource2.DataSource = (object) this.izinListesi;
      this.izinListesi.DataSetName = "izinListesi";
      this.izinListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.izinListesiBindingSource;
      this.izinListesiBindingSource.DataSource = (object) this.izinListesi;
      this.izinListesiBindingSource.Position = 0;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.izinListesiBindingSource;
      this.dataTable1BindingSource3.DataMember = "DataTable1";
      this.dataTable1BindingSource3.DataSource = (object) this.izinListesi;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1116, 568);
      this.Controls.Add((Control) this.advancedDataGridView1);
      this.Name = nameof (izListeformu);
      this.Text = nameof (izListeformu);
      this.Load += new EventHandler(this.izListeformu_Load);
      ((ISupportInitialize) this.advancedDataGridView1).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource2).EndInit();
      this.izinListesi.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      ((ISupportInitialize) this.izinListesiBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource3).EndInit();
      this.ResumeLayout(false);
    }
  }
}
