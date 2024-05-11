// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.BeldBirimForum
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class BeldBirimForum : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private Label label8;
    private Label girisLabel;
    private Button button1;
    private Panel panel3;
    private Panel panel1;
    private TextBox AdiTxt;
    private Panel panel2;
    private Panel panel4;
    private Button button3;
    private DataGridView dataGridView1;

    public BeldBirimForum() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void BeldBirimForum_Load(object sender, EventArgs e) => this.listele();

    private void listele() => this.dataGridView1.DataSource = (object) this.db.TBLBELDBIRIMLER.Select(sor => new
    {
      ID = sor.ID,
      BELDBIRIMADI = sor.BELDBIRIMADI
    }).ToList();

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      BeldBirimForum.ReleaseCapture();
      BeldBirimForum.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void girisLabel_MouseDown(object sender, MouseEventArgs e)
    {
      BeldBirimForum.ReleaseCapture();
      BeldBirimForum.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button3_Click(object sender, EventArgs e)
    {
      this.db.TBLBELDBIRIMLER.Add(new TBLBELDBIRIMLER()
      {
        BELDBIRIMADI = this.AdiTxt.Text,
        SAVEUSER = YetkiClass.kullanici_ad,
        SAVEDATE = new DateTime?(DateTime.Now)
      });
      this.db.SaveChanges();
      int num = (int) MessageBox.Show("Kayıt başarılı bir şekilde alındı.");
      this.listele();
      this.AdiTxt.Text = "";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label8 = new Label();
      this.girisLabel = new Label();
      this.button1 = new Button();
      this.panel3 = new Panel();
      this.panel1 = new Panel();
      this.AdiTxt = new TextBox();
      this.panel2 = new Panel();
      this.panel4 = new Panel();
      this.button3 = new Button();
      this.dataGridView1 = new DataGridView();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label8.Location = new Point(9, 24);
      this.label8.Name = "label8";
      this.label8.Size = new Size(128, 21);
      this.label8.TabIndex = 125;
      this.label8.Text = "Beldiye Birim :";
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(257, 9);
      this.girisLabel.Name = "girisLabel";
      this.girisLabel.Size = new Size(205, 29);
      this.girisLabel.TabIndex = 8;
      this.girisLabel.Text = "PERSONEL KAYIT";
      this.girisLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.girisLabel.MouseDown += new MouseEventHandler(this.girisLabel_MouseDown);
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(741, 6);
      this.button1.Name = "button1";
      this.button1.Size = new Size(31, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 527);
      this.panel3.TabIndex = 112;
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(779, 47);
      this.panel1.TabIndex = 104;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.AdiTxt.BackColor = Color.Ivory;
      this.AdiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AdiTxt.Location = new Point(137, 24);
      this.AdiTxt.Multiline = true;
      this.AdiTxt.Name = "AdiTxt";
      this.AdiTxt.Size = new Size(322, 27);
      this.AdiTxt.TabIndex = 126;
      this.panel2.Controls.Add((Control) this.button3);
      this.panel2.Controls.Add((Control) this.AdiTxt);
      this.panel2.Controls.Add((Control) this.label8);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(6, 47);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(773, 75);
      this.panel2.TabIndex = (int) sbyte.MaxValue;
      this.panel4.Controls.Add((Control) this.dataGridView1);
      this.panel4.Dock = DockStyle.Fill;
      this.panel4.Location = new Point(6, 122);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(773, 452);
      this.panel4.TabIndex = 128;
      this.button3.BackColor = Color.SteelBlue;
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(530, 6);
      this.button3.Name = "button3";
      this.button3.Size = new Size(170, 58);
      this.button3.TabIndex = (int) sbyte.MaxValue;
      this.button3.Text = "Kaydet";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = Color.Gainsboro;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = DockStyle.Fill;
      this.dataGridView1.Location = new Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new Size(773, 452);
      this.dataGridView1.TabIndex = 0;
      this.AccessibleRole = AccessibleRole.Indicator;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(779, 574);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (BeldBirimForum);
      this.Text = nameof (BeldBirimForum);
      this.Load += new EventHandler(this.BeldBirimForum_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel4.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
