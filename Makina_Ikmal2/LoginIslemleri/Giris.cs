// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.Giris
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class Giris : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox sifreTxt;
    private Label label6;
    private Button button1;
    private TextBox adiTxt;
    private Label label4;
    private Panel panel3;
    private Panel panel4;
    private Button button3;
    private Panel panel1;

    public Giris() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      Giris.ReleaseCapture();
      Giris.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void label1_MouseDown(object sender, MouseEventArgs e)
    {
      Giris.ReleaseCapture();
      Giris.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button3_Click(object sender, EventArgs e)
    {
      this.adiTxt.Text = "Tarık OKAY";
      this.sifreTxt.Text = "1234";
      IQueryable<TBLKULLANICILAR> source = this.db.TBLKULLANICILAR.Where<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (p => p.KULLANICIADI == this.adiTxt.Text && p.SIFRE == this.sifreTxt.Text));
      if (source.Any<TBLKULLANICILAR>())
      {
        foreach (TBLKULLANICILAR tblkullanicilar in (IEnumerable<TBLKULLANICILAR>) source)
        {
          int id = Convert.ToInt32((object) tblkullanicilar.ID);
          this.db.TBLFORMKULLANICI.FirstOrDefault<TBLFORMKULLANICI>((Expression<Func<TBLFORMKULLANICI, bool>>) (x => x.ID == id));
          YetkiClass.kullanici_id = Convert.ToInt32((object) tblkullanicilar.ID);
          YetkiClass.kullanici_ad = tblkullanicilar.ADISOYADI;
          new fbaslangic().Show();
          this.Hide();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Kullanıcı adınızı veya şifreniz hatalı");
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
      this.label1 = new Label();
      this.sifreTxt = new TextBox();
      this.label6 = new Label();
      this.button1 = new Button();
      this.adiTxt = new TextBox();
      this.label4 = new Label();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.button3 = new Button();
      this.panel1 = new Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(86, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(205, 29);
      this.label1.TabIndex = 8;
      this.label1.Text = "PERSONEL KAYIT";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.sifreTxt.BackColor = Color.Ivory;
      this.sifreTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.sifreTxt.Location = new Point(132, 130);
      this.sifreTxt.Multiline = true;
      this.sifreTxt.Name = "sifreTxt";
      this.sifreTxt.Size = new Size(226, 27);
      this.sifreTxt.TabIndex = 122;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(80, 132);
      this.label6.Name = "label6";
      this.label6.Size = new Size(47, 21);
      this.label6.TabIndex = 121;
      this.label6.Text = "Şifre";
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(350, 9);
      this.button1.Name = "button1";
      this.button1.Size = new Size(31, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.adiTxt.BackColor = Color.Ivory;
      this.adiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.adiTxt.Location = new Point(132, 97);
      this.adiTxt.Multiline = true;
      this.adiTxt.Name = "adiTxt";
      this.adiTxt.Size = new Size(226, 27);
      this.adiTxt.TabIndex = 118;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(13, 100);
      this.label4.Name = "label4";
      this.label4.Size = new Size(113, 21);
      this.label4.TabIndex = 117;
      this.label4.Text = "Kullanıcı Adı";
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 210);
      this.panel3.TabIndex = 112;
      this.panel4.BackColor = Color.SteelBlue;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(0, 257);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(389, 6);
      this.panel4.TabIndex = 111;
      this.button3.BackColor = Color.SteelBlue;
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(227, 195);
      this.button3.Name = "button3";
      this.button3.Size = new Size(131, 40);
      this.button3.TabIndex = 106;
      this.button3.Text = "Giriş";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(389, 47);
      this.panel1.TabIndex = 104;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(389, 263);
      this.Controls.Add((Control) this.sifreTxt);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.adiTxt);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Giris);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Giris);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
