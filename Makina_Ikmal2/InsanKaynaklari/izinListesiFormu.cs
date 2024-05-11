// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.izinListesiFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class izinListesiFormu : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private DataGridView dataGridView1;
    private Panel panel1;
    private Label girisLabel;
    private Button button1;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Column1;

    public izinListesiFormu() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    private void izinListesiFormu_Load(object sender, EventArgs e) => this.dataGridView1.DataSource = (object) this.db.TBLPERSONEL.Select(x => new
    {
      ID = x.ID,
      ADISOYADI = x.ADISOYADI
    }).ToList();

    private void panel1_MouseDown(object sender, MouseEventArgs e) => izinListesiFormu.ReleaseCapture();

    private void listeleme(int IDXa)
    {
      int num1 = 0;
      this.dataGridView2.Rows.Clear();
      IQueryable<\u003C\u003Ef__AnonymousType46<int, int?, int?, int?, int?, int?>> queryable = this.db.TBLPERSIZINDURUM.OrderByDescending<TBLPERSIZINDURUM, int>((Expression<Func<TBLPERSIZINDURUM, int>>) (x => x.ID)).Where<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (item => item.PERSONELID == (int?) IDXa)).Select(item => new
      {
        ID = item.ID,
        IZINYILI = item.IZINYILI,
        KULLANILANIZIN = item.KULLANILANIZIN,
        IZINHAKKI = item.IZINHAKKI,
        PERSONELID = item.PERSONELID,
        PERSONELIZINID = item.PERSONELIZINID
      });
      this.dataGridView2.ColumnCount = 5;
      foreach (var data in queryable)
      {
        var item = data;
        try
        {
          this.dataGridView2.Rows.Add((object) this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (x => (int?) x.ID == item.PERSONELID)).ADISOYADI, (object) item.IZINYILI, (object) item.IZINHAKKI, (object) item.KULLANILANIZIN, (object) item.PERSONELIZINID);
        }
        catch (Exception ex)
        {
        }
      }
      int num2 = 0;
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          try
          {
            num2 += Convert.ToInt32(row.Cells[2].Value) - Convert.ToInt32(row.Cells[3].Value);
            ++num1;
          }
          catch (Exception ex)
          {
          }
        }
      }
      if (num1 <= 0)
        return;
      this.dataGridView2.Rows.Add((object) "", (object) "Toplam izin Sayısı:", (object) num2);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) => this.listeleme(Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value));

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
        ;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dataGridView1 = new DataGridView();
      this.panel1 = new Panel();
      this.girisLabel = new Label();
      this.button1 = new Button();
      this.dataGridView2 = new DataGridView();
      this.ID = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.Column1);
      this.dataGridView1.Location = new Point(12, 131);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView1.RowTemplate.Height = 40;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(463, 606);
      this.dataGridView1.TabIndex = 165;
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1163, 47);
      this.panel1.TabIndex = 167;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(476, 9);
      this.girisLabel.Name = "girisLabel";
      this.girisLabel.Size = new Size(205, 29);
      this.girisLabel.TabIndex = 8;
      this.girisLabel.Text = "PERSONEL KAYIT";
      this.girisLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(1103, 5);
      this.button1.Name = "button1";
      this.button1.Size = new Size(48, 39);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new Point(481, 131);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView2.RowTemplate.Height = 40;
      this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView2.Size = new Size(670, 606);
      this.dataGridView2.TabIndex = 165;
      this.ID.DataPropertyName = "ID";
      this.ID.FillWeight = 28.4264f;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.Visible = false;
      this.Column1.DataPropertyName = "ADISOYADI";
      this.Column1.FillWeight = 111.5736f;
      this.Column1.HeaderText = "ADISOYADI";
      this.Column1.Name = "Column1";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1163, 749);
      this.Controls.Add((Control) this.dataGridView2);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (izinListesiFormu);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (izinListesiFormu);
      this.Load += new EventHandler(this.izinListesiFormu_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.ResumeLayout(false);
    }
  }
}
