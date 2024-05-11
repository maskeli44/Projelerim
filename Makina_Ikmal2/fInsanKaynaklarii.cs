// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.fInsanKaynaklarii
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.InsanKaynaklari;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal
{
  public class fInsanKaynaklarii : Form
  {
    private bellEntities db = new bellEntities();
    private Resimleme res = new Resimleme();
    private KullaniciSonId ser = new KullaniciSonId();
    private YetkiClass yet = new YetkiClass();
    private int say = 0;
    private int carp = 1;
    private int sonuc = 1;
    private IContainer components = (IContainer) null;
    private Panel pMenu;
    private Button bPersonellistesi;
    private Panel panel4;
    private Label label2;
    private Label label1;
    private PictureBox pLogo;
    private PictureBox btnKaydirma;
    private Panel panel2;
    private Panel panel3;
    private Button bCikis;
    private Button bBuyut;
    private Button bAlt;
    private Button bKucult;
    private Button button1;
    private Button bPersonelizin;
    private Button bIzinDurumListesi;
    private Button button2;
    public Panel pOrta;
    private PrintDocument printDocument1;
    private PrintPreviewDialog printPreviewDialog1;

    public fInsanKaynaklarii() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void btnKaydirma_Click(object sender, EventArgs e)
    {
      if (this.pMenu.Width == 65)
        this.pMenu.Width = 235;
      else
        this.pMenu.Width = 65;
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

    private void bAlt_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void panel3_MouseDown(object sender, MouseEventArgs e)
    {
      fInsanKaynaklarii.ReleaseCapture();
      fInsanKaynaklarii.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void pMenu_Paint(object sender, PaintEventArgs e)
    {
    }

    private void fInsanKaynaklarii_Load(object sender, EventArgs e)
    {
    }

    public void forumac(Form frm)
    {
      this.pOrta.Controls.Clear();
      frm.MdiParent = (Form) this;
      frm.FormBorderStyle = FormBorderStyle.None;
      frm.WindowState = FormWindowState.Maximized;
      this.pOrta.Controls.Add((Control) frm);
      frm.Show();
    }

    private void bPersonellistesi_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi"))
      {
        this.forumac((Form) new Listele());
        this.panel2.Size = new Size(989, 50);
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi") && YetkiClass.EkleYetki == 1)
      {
        YetkiClass.secim = "kayit";
        int num = (int) new fEkle().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      int num = (int) new fEkle().ShowDialog();
    }

    private void bPersonelizin_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.EkleYetki == 1)
      {
        izinListesiFormu izinListesiFormu = new izinListesiFormu();
        YetkiClass.secim = "kayıt";
        int num = (int) izinListesiFormu.ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void bIzinDurumListesi_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi"))
      {
        this.forumac((Form) new izindeOlanListesi());
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.ser.personelSonId().ToString());
    }

    private void button4_Click(object sender, EventArgs e) => this.printPreviewDialog1.Show();

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      IQueryable<TBLPERSONEL> queryable = this.db.TBLPERSONEL.Select<TBLPERSONEL, TBLPERSONEL>((Expression<Func<TBLPERSONEL, TBLPERSONEL>>) (hd => hd));
      e.Graphics.DrawString("OKAY ÇIRÇIR PRES FABRİKASI", new Font("arial", 15f), (Brush) new SolidBrush(Color.Black), 180f, 40f);
      e.Graphics.DrawString("S.No", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 20f, 80f);
      e.Graphics.DrawString("Resim", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 80f, 80f);
      e.Graphics.DrawString("Adı Soyadı", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 180f, 80f);
      e.Graphics.DrawString("Eğitim Durumu", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 350f, 80f);
      e.Graphics.DrawString("Unvanı ", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 480f, 80f);
      e.Graphics.DrawString("İstihdam ", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 550f, 80f);
      e.Graphics.DrawString("Görev Yeri ", new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 650f, 80f);
      int y = 100;
      foreach (TBLPERSONEL tblpersonel in (IEnumerable<TBLPERSONEL>) queryable)
      {
        e.Graphics.DrawString(tblpersonel.ID.ToString(), new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 20f, (float) y);
        e.HasMorePages = true;
        e.Graphics.DrawString(tblpersonel.ADISOYADI, new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 180f, (float) y);
        this.sonuc = this.carp * 11;
        try
        {
          ++this.say;
          int egitimid = Convert.ToInt32((object) tblpersonel.EGITIMID);
          TBLPERSEGITIMDRM tblpersegitimdrm = this.db.TBLPERSEGITIMDRM.FirstOrDefault<TBLPERSEGITIMDRM>((Expression<Func<TBLPERSEGITIMDRM, bool>>) (x => x.ID == egitimid));
          e.Graphics.DrawString(tblpersegitimdrm.EGITIMDURUM, new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 350f, (float) y);
          int unvanid = Convert.ToInt32((object) tblpersonel.UNVANID);
          TBLPERSUNVAN tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<Func<TBLPERSUNVAN, bool>>) (x => x.ID == unvanid));
          e.Graphics.DrawString(tblpersunvan.UNVAN, new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 480f, (float) y);
          Convert.ToInt32((object) tblpersonel.PERSISTIHDAMIID);
          TBLBELDBIRIMLER tblbeldbirimler = this.db.TBLBELDBIRIMLER.FirstOrDefault<TBLBELDBIRIMLER>((Expression<Func<TBLBELDBIRIMLER, bool>>) (x => x.ID == egitimid));
          e.Graphics.DrawString(tblbeldbirimler.BELDBIRIMADI, new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 550f, (float) y);
        }
        catch (Exception ex)
        {
        }
        e.Graphics.DrawString(tblpersonel.GOREVYERI, new Font("arial", 9f), (Brush) new SolidBrush(Color.Black), 650f, (float) y);
        if (this.say > this.sonuc)
        {
          e.HasMorePages = true;
          ++this.carp;
        }
        else
          e.HasMorePages = false;
        y += 80;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fInsanKaynaklarii));
      this.pMenu = new Panel();
      this.bPersonelizin = new Button();
      this.bIzinDurumListesi = new Button();
      this.button1 = new Button();
      this.button2 = new Button();
      this.bPersonellistesi = new Button();
      this.panel4 = new Panel();
      this.label2 = new Label();
      this.label1 = new Label();
      this.pLogo = new PictureBox();
      this.panel2 = new Panel();
      this.panel3 = new Panel();
      this.bKucult = new Button();
      this.bAlt = new Button();
      this.bBuyut = new Button();
      this.bCikis = new Button();
      this.btnKaydirma = new PictureBox();
      this.pOrta = new Panel();
      this.printDocument1 = new PrintDocument();
      this.printPreviewDialog1 = new PrintPreviewDialog();
      this.pMenu.SuspendLayout();
      this.panel4.SuspendLayout();
      ((ISupportInitialize) this.pLogo).BeginInit();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((ISupportInitialize) this.btnKaydirma).BeginInit();
      this.SuspendLayout();
      this.pMenu.BackColor = Color.FromArgb(50, 50, 78);
      this.pMenu.Controls.Add((Control) this.bPersonelizin);
      this.pMenu.Controls.Add((Control) this.bIzinDurumListesi);
      this.pMenu.Controls.Add((Control) this.button1);
      this.pMenu.Controls.Add((Control) this.button2);
      this.pMenu.Controls.Add((Control) this.bPersonellistesi);
      this.pMenu.Controls.Add((Control) this.panel4);
      this.pMenu.Dock = DockStyle.Left;
      this.pMenu.Location = new Point(0, 0);
      this.pMenu.Name = "pMenu";
      this.pMenu.Size = new Size(311, 680);
      this.pMenu.TabIndex = 1;
      this.pMenu.Paint += new PaintEventHandler(this.pMenu_Paint);
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
      this.bPersonelizin.Click += new EventHandler(this.bPersonelizin_Click);
      this.bIzinDurumListesi.FlatAppearance.BorderSize = 0;
      this.bIzinDurumListesi.FlatAppearance.MouseOverBackColor = Color.DimGray;
      this.bIzinDurumListesi.FlatStyle = FlatStyle.Flat;
      this.bIzinDurumListesi.Font = new Font("Constantia", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bIzinDurumListesi.ForeColor = Color.LightCyan;
      this.bIzinDurumListesi.Image = (Image) Resources.list;
      this.bIzinDurumListesi.Location = new Point(0, 250);
      this.bIzinDurumListesi.Name = "bIzinDurumListesi";
      this.bIzinDurumListesi.Size = new Size(311, 45);
      this.bIzinDurumListesi.TabIndex = 3;
      this.bIzinDurumListesi.Text = "Personel   İzin Listesi";
      this.bIzinDurumListesi.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bIzinDurumListesi.UseVisualStyleBackColor = true;
      this.bIzinDurumListesi.Click += new EventHandler(this.bIzinDurumListesi_Click);
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
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseOverBackColor = Color.DimGray;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Constantia", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.LightCyan;
      this.button2.Image = (Image) Resources.adress_book__2_;
      this.button2.Location = new Point(-15, 315);
      this.button2.Name = "button2";
      this.button2.Size = new Size(316, 45);
      this.button2.TabIndex = 1;
      this.button2.Text = "    Personel Ekle";
      this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
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
      this.bPersonellistesi.Text = "    Personel Listesi";
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
      this.label1.Click += new EventHandler(this.label1_Click);
      this.pLogo.Image = (Image) Resources.ık64;
      this.pLogo.Location = new Point(3, 2);
      this.pLogo.Name = "pLogo";
      this.pLogo.Size = new Size(86, 123);
      this.pLogo.SizeMode = PictureBoxSizeMode.Zoom;
      this.pLogo.TabIndex = 0;
      this.pLogo.TabStop = false;
      this.panel2.BackColor = Color.FromArgb(0, 134, 138);
      this.panel2.Controls.Add((Control) this.panel3);
      this.panel2.Dock = DockStyle.Top;
      this.panel2.Location = new Point(311, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(989, 109);
      this.panel2.TabIndex = 2;
      this.panel3.BackColor = Color.FromArgb(0, 89, 92);
      this.panel3.Controls.Add((Control) this.bKucult);
      this.panel3.Controls.Add((Control) this.bAlt);
      this.panel3.Controls.Add((Control) this.bBuyut);
      this.panel3.Controls.Add((Control) this.bCikis);
      this.panel3.Controls.Add((Control) this.btnKaydirma);
      this.panel3.Dock = DockStyle.Top;
      this.panel3.Location = new Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(989, 53);
      this.panel3.TabIndex = 1;
      this.panel3.MouseDown += new MouseEventHandler(this.panel3_MouseDown);
      this.bKucult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bKucult.Cursor = Cursors.Hand;
      this.bKucult.FlatAppearance.BorderSize = 0;
      this.bKucult.FlatStyle = FlatStyle.Flat;
      this.bKucult.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bKucult.ForeColor = SystemColors.Control;
      this.bKucult.Image = (Image) Resources.minimize__2_;
      this.bKucult.Location = new Point(925, 4);
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
      this.bAlt.Location = new Point(897, 6);
      this.bAlt.Name = "bAlt";
      this.bAlt.Size = new Size(30, 30);
      this.bAlt.TabIndex = 3;
      this.bAlt.Text = "_____";
      this.bAlt.UseVisualStyleBackColor = true;
      this.bAlt.Click += new EventHandler(this.bAlt_Click);
      this.bBuyut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bBuyut.Cursor = Cursors.Hand;
      this.bBuyut.FlatAppearance.BorderSize = 0;
      this.bBuyut.FlatStyle = FlatStyle.Flat;
      this.bBuyut.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bBuyut.ForeColor = SystemColors.Control;
      this.bBuyut.Image = (Image) Resources.full_screen__2_;
      this.bBuyut.Location = new Point(925, 3);
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
      this.bCikis.Location = new Point(956, 3);
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
      this.btnKaydirma.Click += new EventHandler(this.btnKaydirma_Click);
      this.pOrta.Dock = DockStyle.Fill;
      this.pOrta.Location = new Point(311, 109);
      this.pOrta.Margin = new Padding(0);
      this.pOrta.Name = "pOrta";
      this.pOrta.Size = new Size(989, 571);
      this.pOrta.TabIndex = 4;
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
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1300, 680);
      this.Controls.Add((Control) this.pOrta);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.pMenu);
      this.FormBorderStyle = FormBorderStyle.None;
      this.IsMdiContainer = true;
      this.Name = nameof (fInsanKaynaklarii);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (fInsanKaynaklarii);
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fInsanKaynaklarii_Load);
      this.pMenu.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      ((ISupportInitialize) this.pLogo).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((ISupportInitialize) this.btnKaydirma).EndInit();
      this.ResumeLayout(false);
    }
  }
}
