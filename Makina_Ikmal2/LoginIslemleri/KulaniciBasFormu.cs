// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.KulaniciBasFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class KulaniciBasFormu : Form
  {
    private IContainer components = (IContainer) null;
    private PrintPreviewDialog printPreviewDialog1;
    private PrintDocument printDocument1;
    public Panel pOrta;
    private Button bKucult;
    private Button bAlt;
    private Button bBuyut;
    private Button bCikis;
    private PictureBox btnKaydirma;
    private Label label2;
    private Label label1;
    private Panel panel3;
    private PictureBox pLogo;
    private Button button1;
    private Button bPersonellistesi;
    private Panel panel4;
    private Panel panel2;
    private Panel pMenu;
    private Button bPersonelizin;

    public KulaniciBasFormu() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void btnKaydirma_Click(object sender, EventArgs e)
    {
    }

    private void bCikis_Click(object sender, EventArgs e) => this.Close();

    private void bBuyut_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
      this.bKucult.Visible = true;
      this.bBuyut.Visible = false;
    }

    private void bKucult_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      this.bKucult.Visible = false;
      this.bBuyut.Visible = true;
    }

    private void panel3_MouseDown(object sender, MouseEventArgs e)
    {
      KulaniciBasFormu.ReleaseCapture();
      KulaniciBasFormu.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void btnKaydirma_Click_1(object sender, EventArgs e)
    {
      if (this.pMenu.Width == 65)
        this.pMenu.Width = 235;
      else
        this.pMenu.Width = 65;
    }

    private void bAlt_Click_1(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    public void forumac(Form frm)
    {
      this.pOrta.Controls.Clear();
      frm.MdiParent = (Form) this;
      frm.FormBorderStyle = FormBorderStyle.None;
      frm.WindowState = FormWindowState.Maximized;
      this.pOrta.Controls.Add((Control) frm);
      frm.Show();
    }

    private void bPersonellistesi_Click(object sender, EventArgs e) => this.forumac((Form) new LoginListeFormu());

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KulaniciBasFormu));
      this.printPreviewDialog1 = new PrintPreviewDialog();
      this.printDocument1 = new PrintDocument();
      this.pOrta = new Panel();
      this.bKucult = new Button();
      this.bAlt = new Button();
      this.bBuyut = new Button();
      this.bCikis = new Button();
      this.btnKaydirma = new PictureBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.panel3 = new Panel();
      this.pLogo = new PictureBox();
      this.button1 = new Button();
      this.bPersonellistesi = new Button();
      this.panel4 = new Panel();
      this.panel2 = new Panel();
      this.pMenu = new Panel();
      this.bPersonelizin = new Button();
      ((ISupportInitialize) this.btnKaydirma).BeginInit();
      this.panel3.SuspendLayout();
      ((ISupportInitialize) this.pLogo).BeginInit();
      this.panel4.SuspendLayout();
      this.panel2.SuspendLayout();
      this.pMenu.SuspendLayout();
      this.SuspendLayout();
      this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
      this.printPreviewDialog1.ClientSize = new Size(400, 300);
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = (Icon) componentResourceManager.GetObject("printPreviewDialog1.Icon");
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.Text = "Baskı önizleme";
      this.printPreviewDialog1.Visible = false;
      this.pOrta.Dock = DockStyle.Fill;
      this.pOrta.Location = new Point(311, 109);
      this.pOrta.Margin = new Padding(0);
      this.pOrta.Name = "pOrta";
      this.pOrta.Size = new Size(768, 664);
      this.pOrta.TabIndex = 7;
      this.bKucult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bKucult.Cursor = Cursors.Hand;
      this.bKucult.FlatAppearance.BorderSize = 0;
      this.bKucult.FlatStyle = FlatStyle.Flat;
      this.bKucult.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bKucult.ForeColor = SystemColors.Control;
      this.bKucult.Image = (Image) Resources.minimize__2_;
      this.bKucult.Location = new Point(704, 4);
      this.bKucult.Name = "bKucult";
      this.bKucult.Size = new Size(30, 30);
      this.bKucult.TabIndex = 4;
      this.bKucult.UseVisualStyleBackColor = true;
      this.bKucult.Visible = false;
      this.bKucult.Click += new EventHandler(this.bKucult_Click);
      this.bAlt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bAlt.Cursor = Cursors.Hand;
      this.bAlt.FlatAppearance.BorderSize = 0;
      this.bAlt.FlatStyle = FlatStyle.Flat;
      this.bAlt.Font = new Font("Microsoft Sans Serif", 1.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.bAlt.ForeColor = SystemColors.Control;
      this.bAlt.Location = new Point(676, 6);
      this.bAlt.Name = "bAlt";
      this.bAlt.Size = new Size(30, 30);
      this.bAlt.TabIndex = 3;
      this.bAlt.Text = "_____";
      this.bAlt.UseVisualStyleBackColor = true;
      this.bAlt.Click += new EventHandler(this.bAlt_Click_1);
      this.bBuyut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bBuyut.Cursor = Cursors.Hand;
      this.bBuyut.FlatAppearance.BorderSize = 0;
      this.bBuyut.FlatStyle = FlatStyle.Flat;
      this.bBuyut.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bBuyut.ForeColor = SystemColors.Control;
      this.bBuyut.Image = (Image) Resources.full_screen__2_;
      this.bBuyut.Location = new Point(704, 3);
      this.bBuyut.Name = "bBuyut";
      this.bBuyut.Size = new Size(30, 30);
      this.bBuyut.TabIndex = 2;
      this.bBuyut.UseVisualStyleBackColor = true;
      this.bBuyut.Click += new EventHandler(this.bBuyut_Click);
      this.bCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bCikis.Cursor = Cursors.Hand;
      this.bCikis.FlatAppearance.BorderSize = 0;
      this.bCikis.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
      this.bCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.bCikis.FlatStyle = FlatStyle.Flat;
      this.bCikis.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bCikis.ForeColor = SystemColors.Control;
      this.bCikis.Location = new Point(735, 3);
      this.bCikis.Name = "bCikis";
      this.bCikis.Size = new Size(30, 30);
      this.bCikis.TabIndex = 1;
      this.bCikis.Text = "X";
      this.bCikis.UseVisualStyleBackColor = true;
      this.bCikis.Click += new EventHandler(this.bCikis_Click);
      this.btnKaydirma.Cursor = Cursors.Hand;
      this.btnKaydirma.Image = (Image) Resources.menu;
      this.btnKaydirma.Location = new Point(4, 9);
      this.btnKaydirma.Name = "btnKaydirma";
      this.btnKaydirma.Size = new Size(38, 38);
      this.btnKaydirma.SizeMode = PictureBoxSizeMode.Zoom;
      this.btnKaydirma.TabIndex = 0;
      this.btnKaydirma.TabStop = false;
      this.btnKaydirma.Click += new EventHandler(this.btnKaydirma_Click_1);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Book Antiqua", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label2.ForeColor = Color.Aquamarine;
      this.label2.Location = new Point(101, 79);
      this.label2.Name = "label2";
      this.label2.Size = new Size(175, 19);
      this.label2.TabIndex = 2;
      this.label2.Text = "İNSAN KAYNAKLARI";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label1.ForeColor = Color.Ivory;
      this.label1.Location = new Point(81, 11);
      this.label1.Name = "label1";
      this.label1.Size = new Size(197, 48);
      this.label1.TabIndex = 1;
      this.label1.Text = "MAKİNE İKMAL\r\nŞUBE MÜDÜRLÜĞÜ";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.panel3.BackColor = Color.FromArgb(0, 89, 92);
      this.panel3.Controls.Add((Control) this.bKucult);
      this.panel3.Controls.Add((Control) this.bAlt);
      this.panel3.Controls.Add((Control) this.bBuyut);
      this.panel3.Controls.Add((Control) this.bCikis);
      this.panel3.Controls.Add((Control) this.btnKaydirma);
      this.panel3.Dock = DockStyle.Top;
      this.panel3.Location = new Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(768, 53);
      this.panel3.TabIndex = 1;
      this.panel3.MouseDown += new MouseEventHandler(this.panel3_MouseDown);
      this.pLogo.Image = (Image) Resources.ık64;
      this.pLogo.Location = new Point(3, 2);
      this.pLogo.Name = "pLogo";
      this.pLogo.Size = new Size(86, 123);
      this.pLogo.SizeMode = PictureBoxSizeMode.Zoom;
      this.pLogo.TabIndex = 0;
      this.pLogo.TabStop = false;
      this.button1.Dock = DockStyle.Top;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Location = new Point(0, 132);
      this.button1.Name = "button1";
      this.button1.Size = new Size(311, 10);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.bPersonellistesi.FlatAppearance.BorderSize = 0;
      this.bPersonellistesi.FlatAppearance.MouseOverBackColor = Color.DimGray;
      this.bPersonellistesi.FlatStyle = FlatStyle.Flat;
      this.bPersonellistesi.Font = new Font("Constantia", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bPersonellistesi.ForeColor = Color.LightCyan;
      this.bPersonellistesi.Image = (Image) Resources.adress_book__2_;
      this.bPersonellistesi.Location = new Point(-8, 148);
      this.bPersonellistesi.Name = "bPersonellistesi";
      this.bPersonellistesi.Size = new Size(316, 45);
      this.bPersonellistesi.TabIndex = 1;
      this.bPersonellistesi.Text = "   Kullanıcı Listesi";
      this.bPersonellistesi.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bPersonellistesi.UseVisualStyleBackColor = true;
      this.bPersonellistesi.Click += new EventHandler(this.bPersonellistesi_Click);
      this.panel4.BorderStyle = BorderStyle.FixedSingle;
      this.panel4.Controls.Add((Control) this.label2);
      this.panel4.Controls.Add((Control) this.label1);
      this.panel4.Controls.Add((Control) this.pLogo);
      this.panel4.Dock = DockStyle.Top;
      this.panel4.Location = new Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(311, 132);
      this.panel4.TabIndex = 0;
      this.panel2.BackColor = Color.FromArgb(0, 134, 138);
      this.panel2.Controls.Add((Control) this.panel3);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(311, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(768, 109);
      this.panel2.TabIndex = 6;
      this.pMenu.BackColor = Color.FromArgb(50, 50, 78);
      this.pMenu.Controls.Add((Control) this.bPersonelizin);
      this.pMenu.Controls.Add((Control) this.button1);
      this.pMenu.Controls.Add((Control) this.bPersonellistesi);
      this.pMenu.Controls.Add((Control) this.panel4);
      this.pMenu.Dock = DockStyle.Left;
      this.pMenu.Location = new Point(0, 0);
      this.pMenu.Name = "pMenu";
      this.pMenu.Size = new Size(311, 773);
      this.pMenu.TabIndex = 5;
      this.bPersonelizin.FlatAppearance.BorderSize = 0;
      this.bPersonelizin.FlatAppearance.MouseOverBackColor = Color.DimGray;
      this.bPersonelizin.FlatStyle = FlatStyle.Flat;
      this.bPersonelizin.Font = new Font("Constantia", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bPersonelizin.ForeColor = Color.LightCyan;
      this.bPersonelizin.Image = (Image) Resources.traveler_with_a_suitcase;
      this.bPersonelizin.Location = new Point(-15, 199);
      this.bPersonelizin.Name = "bPersonelizin";
      this.bPersonelizin.Size = new Size(323, 45);
      this.bPersonelizin.TabIndex = 4;
      this.bPersonelizin.Text = "    Personel İzin";
      this.bPersonelizin.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bPersonelizin.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1079, 773);
      this.Controls.Add((Control) this.pOrta);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.pMenu);
      this.FormBorderStyle = FormBorderStyle.None;
      this.IsMdiContainer = true;
      this.Name = nameof (KulaniciBasFormu);
      this.Text = nameof (KulaniciBasFormu);
      ((ISupportInitialize) this.btnKaydirma).EndInit();
      this.panel3.ResumeLayout(false);
      ((ISupportInitialize) this.pLogo).EndInit();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.pMenu.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
