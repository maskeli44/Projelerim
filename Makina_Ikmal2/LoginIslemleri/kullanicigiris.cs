﻿// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.kullanicigiris
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
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
  public class kullanicigiris : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private Panel panel1;
    private Label label1;
    private Label label9;
    private TextBox textBox2;
    private Label label8;
    private TextBox adiTxt;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private CheckBox checkBox1;
    private Button button2;
    private Button button1;
    private CheckBox checkBox2;
    private Label label10;

    public kullanicigiris() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => Application.Exit();

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      kullanicigiris.ReleaseCapture();
      kullanicigiris.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox2.Checked)
        this.textBox2.PasswordChar = char.MinValue;
      else
        this.textBox2.PasswordChar = '*';
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.adiTxt.Text = "Tarık OKAY";
      this.textBox2.Text = "1234";
      IQueryable<TBLKULLANICILAR> source = this.db.TBLKULLANICILAR.Where<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (p => p.KULLANICIADI == this.adiTxt.Text && p.SIFRE == this.textBox2.Text));
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
      this.panel1 = new Panel();
      this.checkBox2 = new CheckBox();
      this.checkBox1 = new CheckBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.label9 = new Label();
      this.textBox2 = new TextBox();
      this.label8 = new Label();
      this.adiTxt = new TextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.pictureBox1 = new PictureBox();
      this.label10 = new Label();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.MediumAquamarine;
      this.panel1.Controls.Add((Control) this.label10);
      this.panel1.Controls.Add((Control) this.checkBox2);
      this.panel1.Controls.Add((Control) this.checkBox1);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.textBox2);
      this.panel1.Controls.Add((Control) this.label8);
      this.panel1.Controls.Add((Control) this.adiTxt);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.panel1.Location = new Point(886, 0);
      this.panel1.Margin = new Padding(4, 4, 4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(889, 1102);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkBox2.Location = new Point(607, 645);
      this.checkBox2.Margin = new Padding(4, 4, 4, 4);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(139, 24);
      this.checkBox2.TabIndex = 13;
      this.checkBox2.Text = "Şifreyi  Göster";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkBox1.Location = new Point(29, 714);
      this.checkBox1.Margin = new Padding(4, 4, 4, 4);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(133, 29);
      this.checkBox1.TabIndex = 12;
      this.checkBox1.Text = "Beni Hatırla";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.button2.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.Location = new Point(476, 704);
      this.button2.Margin = new Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new Size(128, 44);
      this.button2.TabIndex = 11;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button1.Location = new Point(325, 704);
      this.button1.Margin = new Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new Size(128, 44);
      this.button1.TabIndex = 10;
      this.button1.Text = "Giriş";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 162);
      this.label9.Location = new Point(541, 1129);
      this.label9.Margin = new Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new Size(206, 23);
      this.label9.TabIndex = 9;
      this.label9.Text = "BAYER YAZILIM 2022";
      this.textBox2.Location = new Point(25, 631);
      this.textBox2.Margin = new Padding(4, 4, 4, 4);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(577, 49);
      this.textBox2.TabIndex = 8;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label8.ForeColor = Color.Red;
      this.label8.Location = new Point(29, 593);
      this.label8.Margin = new Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new Size(69, 29);
      this.label8.TabIndex = 7;
      this.label8.Text = "Şifre:";
      this.adiTxt.Location = new Point(25, 511);
      this.adiTxt.Margin = new Padding(4, 4, 4, 4);
      this.adiTxt.Name = "adiTxt";
      this.adiTxt.Size = new Size(577, 49);
      this.adiTxt.TabIndex = 6;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label7.ForeColor = Color.Red;
      this.label7.Location = new Point(29, 473);
      this.label7.Margin = new Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(151, 29);
      this.label7.TabIndex = 5;
      this.label7.Text = "Kullanıcı Adı:";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(200, 378);
      this.label6.Margin = new Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(155, 26);
      this.label6.TabIndex = 4;
      this.label6.Text = "Eşref ÖKTEN";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label5.Location = new Point(215, 337);
      this.label5.Margin = new Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(262, 29);
      this.label5.TabIndex = 2;
      this.label5.Text = "Mehmet Hicri ÇUBUK";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(24, 374);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(163, 29);
      this.label4.TabIndex = 3;
      this.label4.Text = "Şube Müdürü:";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.Location = new Point(21, 336);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(191, 31);
      this.label3.TabIndex = 2;
      this.label3.Text = "Daire Başkanı:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Calibri", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label2.ForeColor = Color.DarkRed;
      this.label2.Location = new Point(245, 113);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(342, 90);
      this.label2.TabIndex = 1;
      this.label2.Text = "MAKİNE İKMAL ŞUBE\r\n       MÜDÜRLÜĞÜ";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Calibri", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label1.Location = new Point(62, 52);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(689, 54);
      this.label1.TabIndex = 0;
      this.label1.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.pictureBox1.Dock = DockStyle.Left;
      this.pictureBox1.Image = (Image) Resources.icon;
      this.pictureBox1.Location = new Point(0, 0);
      this.pictureBox1.Margin = new Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(886, 1102);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label10.Location = new Point(595, 1076);
      this.label10.Name = "label10";
      this.label10.Size = new Size(151, 17);
      this.label10.TabIndex = 14;
      this.label10.Text = "BAYER YAZILIM -2022";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1775, 1102);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(4, 4, 4, 4);
      this.Name = nameof (kullanicigiris);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (kullanicigiris);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
