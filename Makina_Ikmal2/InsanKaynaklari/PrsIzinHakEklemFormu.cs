// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.PrsIzinHakEklemFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class PrsIzinHakEklemFormu : Form
  {
    private KullaniciSonId SER = new KullaniciSonId();
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private ComboBox AdiCombo;
    private ComboBox İzinYiliCombo;
    private Label label3;
    private TextBox AraTxt;
    private Label label2;
    private Label label4;
    private DataGridView dataGridView1;
    private Button button4;
    private Label label1;
    private TextBox izinSayisiTxt;
    private Panel panel1;
    private Label girisLabel;
    private Button button1;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn ADISOYADI;

    public PrsIzinHakEklemFormu() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void AraTxt_TextChanged(object sender, EventArgs e)
    {
      IQueryable<\u003C\u003Ef__AnonymousType45<int, string>> source = this.db.TBLPERSONEL.Where<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (musteri => musteri.ADISOYADI.Contains(this.AraTxt.Text))).Select(musteri => new
      {
        ID = musteri.ID,
        ADISOYADI = musteri.ADISOYADI
      });
      if (source.Count() <= 0)
        return;
      this.dataGridView1.Visible = true;
      this.dataGridView1.DataSource = (object) source.ToList();
    }

    private void PrsIzinHakEklemFormu_Load(object sender, EventArgs e)
    {
      this.dataGridView1.Visible = false;
      this.AdiCombo.ValueMember = "ID";
      this.AdiCombo.DisplayMember = "ADISOYADI";
      this.AdiCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      YetkiClass.personelid = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value);
      this.AdiCombo.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
      this.dataGridView1.Visible = false;
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      YetkiClass.personelid = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value);
      this.AdiCombo.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
      this.dataGridView1.Visible = false;
    }

    private void AraTxt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      this.dataGridView1.Focus();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.db.TBLPERSIZINDURUM.Add(new TBLPERSIZINDURUM()
      {
        PERSONELID = new int?(YetkiClass.personelid),
        IZINHAKKI = new int?(Convert.ToInt32(this.izinSayisiTxt.Text)),
        IZINYILI = new int?(Convert.ToInt32(this.İzinYiliCombo.Text)),
        KULLANILANIZIN = new int?(0),
        ID = this.SER.personelizindurumuSonId()
      });
      this.db.SaveChanges();
      int num = (int) MessageBox.Show("Başarlı bir şekilde eklendi.");
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      PrsIzinHakEklemFormu.ReleaseCapture();
      PrsIzinHakEklemFormu.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void AdiCombo_SelectedIndexChanged(object sender, EventArgs e) => YetkiClass.personelid = Convert.ToInt32(this.AdiCombo.SelectedValue);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.AdiCombo = new ComboBox();
      this.İzinYiliCombo = new ComboBox();
      this.label3 = new Label();
      this.AraTxt = new TextBox();
      this.label2 = new Label();
      this.label4 = new Label();
      this.dataGridView1 = new DataGridView();
      this.button4 = new Button();
      this.label1 = new Label();
      this.izinSayisiTxt = new TextBox();
      this.panel1 = new Panel();
      this.girisLabel = new Label();
      this.button1 = new Button();
      this.ID = new DataGridViewTextBoxColumn();
      this.ADISOYADI = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.AdiCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.AdiCombo.FormattingEnabled = true;
      this.AdiCombo.Items.AddRange(new object[6]
      {
        (object) "Memur",
        (object) "İşçi",
        (object) "Sözleşmeli",
        (object) "Daimi İşçi",
        (object) "Diğer",
        (object) "İşkur"
      });
      this.AdiCombo.Location = new Point(265, 119);
      this.AdiCombo.Name = "AdiCombo";
      this.AdiCombo.Size = new Size(246, 32);
      this.AdiCombo.TabIndex = 153;
      this.AdiCombo.SelectedIndexChanged += new EventHandler(this.AdiCombo_SelectedIndexChanged);
      this.İzinYiliCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.İzinYiliCombo.FormattingEnabled = true;
      this.İzinYiliCombo.Items.AddRange(new object[4]
      {
        (object) "2021",
        (object) "2022",
        (object) "2023",
        (object) "2024"
      });
      this.İzinYiliCombo.Location = new Point(265, 154);
      this.İzinYiliCombo.Name = "İzinYiliCombo";
      this.İzinYiliCombo.Size = new Size(246, 32);
      this.İzinYiliCombo.TabIndex = 149;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.Location = new Point(161, 122);
      this.label3.Name = "label3";
      this.label3.Size = new Size(98, 21);
      this.label3.TabIndex = 144;
      this.label3.Text = "Adı Soyadı";
      this.AraTxt.BackColor = Color.Ivory;
      this.AraTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AraTxt.ImeMode = ImeMode.NoControl;
      this.AraTxt.Location = new Point(265, 89);
      this.AraTxt.Multiline = true;
      this.AraTxt.Name = "AraTxt";
      this.AraTxt.Size = new Size(246, 27);
      this.AraTxt.TabIndex = 143;
      this.AraTxt.TextChanged += new EventHandler(this.AraTxt_TextChanged);
      this.AraTxt.KeyDown += new KeyEventHandler(this.AraTxt_KeyDown);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.Location = new Point(220, 92);
      this.label2.Name = "label2";
      this.label2.Size = new Size(39, 21);
      this.label2.TabIndex = 142;
      this.label2.Text = "Ara";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(176, 157);
      this.label4.Name = "label4";
      this.label4.Size = new Size(83, 21);
      this.label4.TabIndex = 145;
      this.label4.Text = "İzin Türü";
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.ADISOYADI);
      this.dataGridView1.Location = new Point(265, 119);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView1.RowTemplate.Height = 40;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(429, 408);
      this.dataGridView1.TabIndex = 154;
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
      this.button4.BackColor = Color.SteelBlue;
      this.button4.FlatAppearance.BorderSize = 2;
      this.button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.White;
      this.button4.Location = new Point(387, 244);
      this.button4.Name = "button4";
      this.button4.Size = new Size(124, 39);
      this.button4.TabIndex = 155;
      this.button4.Text = "Kaydet";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label1.Location = new Point(168, 195);
      this.label1.Name = "label1";
      this.label1.Size = new Size(91, 21);
      this.label1.TabIndex = 142;
      this.label1.Text = "İzin Sayısı";
      this.izinSayisiTxt.BackColor = Color.Ivory;
      this.izinSayisiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.izinSayisiTxt.ImeMode = ImeMode.NoControl;
      this.izinSayisiTxt.Location = new Point(266, 192);
      this.izinSayisiTxt.Multiline = true;
      this.izinSayisiTxt.Name = "izinSayisiTxt";
      this.izinSayisiTxt.Size = new Size(246, 27);
      this.izinSayisiTxt.TabIndex = 143;
      this.izinSayisiTxt.KeyDown += new KeyEventHandler(this.AraTxt_KeyDown);
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(702, 47);
      this.panel1.TabIndex = 156;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(220, 12);
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
      this.button1.Location = new Point(649, 5);
      this.button1.Name = "button1";
      this.button1.Size = new Size(41, 39);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.ID.DataPropertyName = "ID";
      this.ID.FillWeight = 50.76142f;
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ADISOYADI.DataPropertyName = "ADISOYADI";
      this.ADISOYADI.FillWeight = 149.2386f;
      this.ADISOYADI.HeaderText = "ADISOYADI";
      this.ADISOYADI.Name = "ADISOYADI";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(702, 584);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.AdiCombo);
      this.Controls.Add((Control) this.İzinYiliCombo);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.izinSayisiTxt);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.AraTxt);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label4);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (PrsIzinHakEklemFormu);
      this.Text = nameof (PrsIzinHakEklemFormu);
      this.Load += new EventHandler(this.PrsIzinHakEklemFormu_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
