// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.LoginListeFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using ADGV;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.InsankaynaklariTableAdapters;
using Makina_Ikmal.Model.LoginListeTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class LoginListeFormu : Form
  {
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private Insankaynaklari insankaynaklari;
    private BindingSource tBLPERSONELBindingSource;
    private BindingSource insankaynaklariBindingSource;
    private BindingSource tBLPERSONELBindingSource1;
    private Panel panel3;
    private AdvancedDataGridView advancedDataGridView1;
    private Panel panel1;
    private Button button5;
    private ImageList ımageList1;
    private Button button3;
    private Button kytBtn;
    private Button button4;
    private Button button2;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private Panel panel2;
    private LoginListe loginListe;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn kULLANICIADIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gOREVYERIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn uNVANIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn aDISOYADIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;

    public LoginListeFormu() => this.InitializeComponent();

    private void LoginListeFormu_Load(object sender, EventArgs e) => this.dataTable1TableAdapter.Fill(this.loginListe.DataTable1);

    private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void advancedDataGridView1_Click(object sender, EventArgs e)
    {
    }

    private void advancedDataGridView1_DoubleClick(object sender, EventArgs e)
    {
      int int16 = (int) Convert.ToInt16(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = int16;
      int num = (int) new LoginKayitFormu().ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int int16 = (int) Convert.ToInt16(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = int16;
      int num = (int) new LoginKayitFormu().ShowDialog();
    }

    private void kytBtn_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "Kayıt";
      int num = (int) new LoginKayitFormu().ShowDialog();
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
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoginListeFormu));
      this.insankaynaklari = new Insankaynaklari();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.insankaynaklariBindingSource = new BindingSource(this.components);
      this.tBLPERSONELBindingSource1 = new BindingSource(this.components);
      this.panel3 = new Panel();
      this.advancedDataGridView1 = new AdvancedDataGridView();
      this.panel1 = new Panel();
      this.ımageList1 = new ImageList(this.components);
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.panel2 = new Panel();
      this.button5 = new Button();
      this.button3 = new Button();
      this.kytBtn = new Button();
      this.button4 = new Button();
      this.button2 = new Button();
      this.loginListe = new LoginListe();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.ıDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.kULLANICIADIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gOREVYERIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.uNVANIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.aDISOYADIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.expr1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.insankaynaklari.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      ((ISupportInitialize) this.insankaynaklariBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).BeginInit();
      this.panel3.SuspendLayout();
      ((ISupportInitialize) this.advancedDataGridView1).BeginInit();
      this.panel1.SuspendLayout();
      this.loginListe.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.SuspendLayout();
      this.insankaynaklari.DataSetName = "Insankaynaklari";
      this.insankaynaklari.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.insankaynaklariBindingSource;
      this.insankaynaklariBindingSource.DataSource = (object) this.insankaynaklari;
      this.insankaynaklariBindingSource.Position = 0;
      this.panel3.Controls.Add((Control) this.advancedDataGridView1);
      this.panel3.Dock = DockStyle.Fill;
      this.panel3.Location = new Point(0, 97);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(1195, 628);
      this.panel3.TabIndex = 198;
      gridViewCellStyle1.BackColor = Color.Silver;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.advancedDataGridView1.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.advancedDataGridView1.AutoGenerateColumns = false;
      this.advancedDataGridView1.AutoGenerateContextFilters = true;
      this.advancedDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      this.advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.advancedDataGridView1.Columns.AddRange((DataGridViewColumn) this.ıDDataGridViewTextBoxColumn, (DataGridViewColumn) this.kULLANICIADIDataGridViewTextBoxColumn, (DataGridViewColumn) this.gOREVYERIDataGridViewTextBoxColumn, (DataGridViewColumn) this.uNVANIDataGridViewTextBoxColumn, (DataGridViewColumn) this.aDISOYADIDataGridViewTextBoxColumn, (DataGridViewColumn) this.expr1DataGridViewTextBoxColumn);
      this.advancedDataGridView1.DataSource = (object) this.dataTable1BindingSource;
      this.advancedDataGridView1.DateWithTime = false;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.advancedDataGridView1.DefaultCellStyle = gridViewCellStyle3;
      this.advancedDataGridView1.Dock = DockStyle.Fill;
      this.advancedDataGridView1.Location = new Point(0, 0);
      this.advancedDataGridView1.Name = "advancedDataGridView1";
      this.advancedDataGridView1.ReadOnly = true;
      this.advancedDataGridView1.RowHeadersVisible = false;
      this.advancedDataGridView1.RowTemplate.Height = 80;
      this.advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.advancedDataGridView1.Size = new Size(1195, 628);
      this.advancedDataGridView1.TabIndex = 194;
      this.advancedDataGridView1.TimeFilter = false;
      this.advancedDataGridView1.CellClick += new DataGridViewCellEventHandler(this.advancedDataGridView1_CellClick);
      this.advancedDataGridView1.Click += new EventHandler(this.advancedDataGridView1_Click);
      this.advancedDataGridView1.DoubleClick += new EventHandler(this.advancedDataGridView1_DoubleClick);
      this.panel1.BackColor = Color.FromArgb(0, 134, 138);
      this.panel1.Controls.Add((Control) this.button5);
      this.panel1.Controls.Add((Control) this.button3);
      this.panel1.Controls.Add((Control) this.kytBtn);
      this.panel1.Controls.Add((Control) this.button4);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1195, 97);
      this.panel1.TabIndex = 197;
      this.ımageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ımageList1.ImageStream");
      this.ımageList1.TransparentColor = Color.Transparent;
      this.ımageList1.Images.SetKeyName(0, "223.png");
      this.ımageList1.Images.SetKeyName(1, "1283195017_Check.ico");
      this.ımageList1.Images.SetKeyName(2, "Actualiser.png");
      this.ımageList1.Images.SetKeyName(3, "Add.ico");
      this.ımageList1.Images.SetKeyName(4, "Bittorrent Plus.png");
      this.ımageList1.Images.SetKeyName(5, "Downloads.png");
      this.ımageList1.Images.SetKeyName(6, "loading30.gif");
      this.ımageList1.Images.SetKeyName(7, "14 Reboot.png");
      this.ımageList1.Images.SetKeyName(8, "button_plus_green.ico");
      this.ımageList1.Images.SetKeyName(9, "Sil32x32.png");
      this.ımageList1.Images.SetKeyName(10, "Windows Turn Off.png");
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1195, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 725);
      this.panel2.TabIndex = 196;
      this.button5.BackColor = Color.Transparent;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button5.ForeColor = Color.White;
      this.button5.ImageAlign = ContentAlignment.TopCenter;
      this.button5.ImageKey = "Downloads.png";
      this.button5.ImageList = this.ımageList1;
      this.button5.Location = new Point(572, 8);
      this.button5.Name = "button5";
      this.button5.Size = new Size(124, 73);
      this.button5.TabIndex = 190;
      this.button5.Text = "Rapor";
      this.button5.TextAlign = ContentAlignment.BottomCenter;
      this.button5.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button5.UseVisualStyleBackColor = false;
      this.button3.BackColor = Color.Transparent;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.ImageAlign = ContentAlignment.TopCenter;
      this.button3.ImageKey = "Sil32x32.png";
      this.button3.ImageList = this.ımageList1;
      this.button3.Location = new Point(189, -1);
      this.button3.Name = "button3";
      this.button3.Size = new Size(115, 92);
      this.button3.TabIndex = 191;
      this.button3.Text = "Sil";
      this.button3.TextAlign = ContentAlignment.BottomCenter;
      this.button3.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button3.UseVisualStyleBackColor = false;
      this.kytBtn.BackColor = Color.Transparent;
      this.kytBtn.FlatAppearance.BorderSize = 0;
      this.kytBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.kytBtn.FlatStyle = FlatStyle.Flat;
      this.kytBtn.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kytBtn.ForeColor = Color.White;
      this.kytBtn.ImageAlign = ContentAlignment.TopCenter;
      this.kytBtn.ImageKey = "Bittorrent Plus.png";
      this.kytBtn.ImageList = this.ımageList1;
      this.kytBtn.Location = new Point(11, -1);
      this.kytBtn.Name = "kytBtn";
      this.kytBtn.Size = new Size(105, 95);
      this.kytBtn.TabIndex = 189;
      this.kytBtn.Text = "Yeni Ekle";
      this.kytBtn.TextAlign = ContentAlignment.BottomCenter;
      this.kytBtn.TextImageRelation = TextImageRelation.ImageAboveText;
      this.kytBtn.UseVisualStyleBackColor = false;
      this.kytBtn.Click += new EventHandler(this.kytBtn_Click);
      this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button4.BackColor = Color.Transparent;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.White;
      this.button4.ImageAlign = ContentAlignment.TopCenter;
      this.button4.ImageIndex = 10;
      this.button4.ImageList = this.ımageList1;
      this.button4.Location = new Point(1100, 0);
      this.button4.Name = "button4";
      this.button4.Size = new Size(88, 76);
      this.button4.TabIndex = 187;
      this.button4.Text = "Kapat";
      this.button4.TextAlign = ContentAlignment.BottomCenter;
      this.button4.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button4.UseVisualStyleBackColor = false;
      this.button2.BackColor = Color.Transparent;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.White;
      this.button2.ImageAlign = ContentAlignment.TopCenter;
      this.button2.ImageKey = "Downloads.png";
      this.button2.ImageList = this.ımageList1;
      this.button2.Location = new Point(100, -1);
      this.button2.Name = "button2";
      this.button2.Size = new Size(120, 92);
      this.button2.TabIndex = 188;
      this.button2.Text = "Düzenle";
      this.button2.TextAlign = ContentAlignment.BottomCenter;
      this.button2.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.loginListe.DataSetName = "LoginListe";
      this.loginListe.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.loginListe;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
      this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.ıDDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
      this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıDDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.kULLANICIADIDataGridViewTextBoxColumn.DataPropertyName = "KULLANICIADI";
      this.kULLANICIADIDataGridViewTextBoxColumn.HeaderText = "KULLANICIADI";
      this.kULLANICIADIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.kULLANICIADIDataGridViewTextBoxColumn.Name = "kULLANICIADIDataGridViewTextBoxColumn";
      this.kULLANICIADIDataGridViewTextBoxColumn.ReadOnly = true;
      this.kULLANICIADIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.gOREVYERIDataGridViewTextBoxColumn.DataPropertyName = "GOREVYERI";
      this.gOREVYERIDataGridViewTextBoxColumn.HeaderText = "GOREVYERI";
      this.gOREVYERIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.gOREVYERIDataGridViewTextBoxColumn.Name = "gOREVYERIDataGridViewTextBoxColumn";
      this.gOREVYERIDataGridViewTextBoxColumn.ReadOnly = true;
      this.gOREVYERIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.uNVANIDataGridViewTextBoxColumn.DataPropertyName = "UNVANI";
      this.uNVANIDataGridViewTextBoxColumn.HeaderText = "UNVANI";
      this.uNVANIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.uNVANIDataGridViewTextBoxColumn.Name = "uNVANIDataGridViewTextBoxColumn";
      this.uNVANIDataGridViewTextBoxColumn.ReadOnly = true;
      this.uNVANIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.aDISOYADIDataGridViewTextBoxColumn.DataPropertyName = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.HeaderText = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.aDISOYADIDataGridViewTextBoxColumn.Name = "aDISOYADIDataGridViewTextBoxColumn";
      this.aDISOYADIDataGridViewTextBoxColumn.ReadOnly = true;
      this.aDISOYADIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
      this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
      this.expr1DataGridViewTextBoxColumn.MinimumWidth = 22;
      this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
      this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
      this.expr1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1201, 725);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel2);
      this.Name = nameof (LoginListeFormu);
      this.Text = nameof (LoginListeFormu);
      this.Load += new EventHandler(this.LoginListeFormu_Load);
      this.insankaynaklari.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      ((ISupportInitialize) this.insankaynaklariBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).EndInit();
      this.panel3.ResumeLayout(false);
      ((ISupportInitialize) this.advancedDataGridView1).EndInit();
      this.panel1.ResumeLayout(false);
      this.loginListe.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.ResumeLayout(false);
    }
  }
}
