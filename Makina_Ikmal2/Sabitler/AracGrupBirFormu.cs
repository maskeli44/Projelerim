// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Sabitler.AracGrupBirFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.Sabitler
{
  public class AracGrupBirFormu : Form
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId sonid = new KullaniciSonId();
    private int id = 0;
    private IContainer components = (IContainer) null;
    private TextBox adiTxt;
    private Panel panel3;
    private Panel panel4;
    private Panel panel2;
    private Button kytBtn;
    private Label girisLabel;
    private Button button1;
    private Label label6;
    private Panel panel1;
    private Button silBtn;
    private Button kapatBtn;
    private DataGridView dataGridView1;
    private Button button2;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;

    public AracGrupBirFormu() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      AracGrupBirFormu.ReleaseCapture();
      AracGrupBirFormu.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void girisLabel_MouseDown(object sender, MouseEventArgs e)
    {
      AracGrupBirFormu.ReleaseCapture();
      AracGrupBirFormu.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void AracGrupBirFormu_Load(object sender, EventArgs e) => this.listeleFon();

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.adiTxt.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
      this.id = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void kytBtn_Click(object sender, EventArgs e)
    {
      try
      {
        this.db.TBLARACGRUBU.Add(new TBLARACGRUBU()
        {
          ID = this.sonid.aracgrup1SonId(),
          GRUPADI = this.adiTxt.Text
        });
        this.db.SaveChanges();
        int num = (int) MessageBox.Show("Kayıt başarlı bir şekilde gerçekleşti.");
        this.listeleFon();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Kayıt sırasında hata meydana geldi.");
      }
    }

    private void listeleFon()
    {
      this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 13f, FontStyle.Bold);
      this.dataGridView1.DataSource = (object) this.db.TBLARACGRUBU.OrderBy<TBLARACGRUBU, string>((Expression<Func<TBLARACGRUBU, string>>) (x => x.GRUPADI)).Select(item => new
      {
        ID = item.ID,
        GRUPADI = item.GRUPADI
      }).ToList();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.adiTxt = new TextBox();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.panel2 = new Panel();
      this.girisLabel = new Label();
      this.button1 = new Button();
      this.label6 = new Label();
      this.panel1 = new Panel();
      this.dataGridView1 = new DataGridView();
      this.kapatBtn = new Button();
      this.silBtn = new Button();
      this.button2 = new Button();
      this.kytBtn = new Button();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.adiTxt.BackColor = Color.Ivory;
      this.adiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.adiTxt.Location = new Point(117, 115);
      this.adiTxt.Multiline = true;
      this.adiTxt.Name = "adiTxt";
      this.adiTxt.Size = new Size(238, 39);
      this.adiTxt.TabIndex = 168;
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 539);
      this.panel3.TabIndex = 165;
      this.panel4.BackColor = Color.SteelBlue;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(0, 586);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(592, 6);
      this.panel4.TabIndex = 164;
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(592, 47);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 545);
      this.panel2.TabIndex = 163;
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(217, 9);
      this.girisLabel.Name = "girisLabel";
      this.girisLabel.Size = new Size(154, 29);
      this.girisLabel.TabIndex = 8;
      this.girisLabel.Text = "GRUP KAYIT";
      this.girisLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.girisLabel.MouseDown += new MouseEventHandler(this.girisLabel_MouseDown);
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(544, 9);
      this.button1.Name = "button1";
      this.button1.Size = new Size(42, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Lucida Sans Unicode", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(15, 121);
      this.label6.Name = "label6";
      this.label6.Size = new Size(96, 23);
      this.label6.TabIndex = 166;
      this.label6.Text = "Grup Adı";
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(598, 47);
      this.panel1.TabIndex = 159;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      gridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
      gridViewCellStyle1.ForeColor = Color.Black;
      this.dataGridView1.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = gridViewCellStyle2;
      this.dataGridView1.Dock = DockStyle.Bottom;
      this.dataGridView1.Location = new Point(6, 169);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 30;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(586, 417);
      this.dataGridView1.TabIndex = 169;
      this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.kapatBtn.BackColor = Color.Transparent;
      this.kapatBtn.FlatAppearance.BorderSize = 0;
      this.kapatBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.kapatBtn.FlatStyle = FlatStyle.Flat;
      this.kapatBtn.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kapatBtn.ForeColor = Color.White;
      this.kapatBtn.Image = (Image) Resources.Program_Exit32x32;
      this.kapatBtn.Location = new Point(529, 53);
      this.kapatBtn.Name = "kapatBtn";
      this.kapatBtn.Size = new Size(57, 42);
      this.kapatBtn.TabIndex = 160;
      this.kapatBtn.UseVisualStyleBackColor = false;
      this.silBtn.BackColor = Color.Transparent;
      this.silBtn.FlatAppearance.BorderSize = 0;
      this.silBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.silBtn.FlatStyle = FlatStyle.Flat;
      this.silBtn.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.silBtn.ForeColor = Color.White;
      this.silBtn.Image = (Image) Resources.Sil32x32;
      this.silBtn.Location = new Point(456, 53);
      this.silBtn.Name = "silBtn";
      this.silBtn.Size = new Size(57, 42);
      this.silBtn.TabIndex = 160;
      this.silBtn.UseVisualStyleBackColor = false;
      this.button2.BackColor = Color.Transparent;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.White;
      this.button2.Image = (Image) Resources.update;
      this.button2.Location = new Point(398, 53);
      this.button2.Name = "button2";
      this.button2.Size = new Size(57, 42);
      this.button2.TabIndex = 160;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.kytBtn_Click);
      this.kytBtn.BackColor = Color.Transparent;
      this.kytBtn.FlatAppearance.BorderSize = 0;
      this.kytBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.kytBtn.FlatStyle = FlatStyle.Flat;
      this.kytBtn.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kytBtn.ForeColor = Color.White;
      this.kytBtn.Image = (Image) Resources.Kaydet24x24;
      this.kytBtn.Location = new Point(335, 53);
      this.kytBtn.Name = "kytBtn";
      this.kytBtn.Size = new Size(57, 42);
      this.kytBtn.TabIndex = 160;
      this.kytBtn.UseVisualStyleBackColor = false;
      this.kytBtn.Click += new EventHandler(this.kytBtn_Click);
      this.Column1.DataPropertyName = "ID";
      this.Column1.HeaderText = "S.NO";
      this.Column1.Name = "Column1";
      this.Column1.Visible = false;
      this.Column2.DataPropertyName = "GRUPADI";
      this.Column2.HeaderText = "Grup Adı";
      this.Column2.Name = "Column2";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(598, 592);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.adiTxt);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.kapatBtn);
      this.Controls.Add((Control) this.silBtn);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.kytBtn);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (AracGrupBirFormu);
      this.Text = nameof (AracGrupBirFormu);
      this.Load += new EventHandler(this.AracGrupBirFormu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
