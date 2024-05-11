// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.LoginKayitFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.XtraEditors;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class LoginKayitFormu : Form
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId kullan = new KullaniciSonId();
    private YetkiClass yet = new YetkiClass();
    private int personelId;
    private string gorevyeri;
    private string unvani;
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox sifre_txt;
    private Label label6;
    private Button button1;
    private TextBox AdiTxt;
    private Label label4;
    private Panel panel3;
    private Panel panel4;
    private Panel panel2;
    private Button button5;
    private Button button3;
    private Panel panel1;
    private DataGridView dataGridView1;
    private TextBox sifre_tekrar_txt;
    private Label label2;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn Kodu;
    private DataGridViewTextBoxColumn Başlık;
    private DataGridViewCheckBoxColumn Menu;
    private DataGridViewCheckBoxColumn Kayıt;
    private DataGridViewCheckBoxColumn Sil;
    private DataGridViewCheckBoxColumn Düzenle;
    private DataGridViewCheckBoxColumn Okuma;
    private DataGridViewCheckBoxColumn Hepsi;

    public LoginKayitFormu() => this.InitializeComponent();

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      this.dataGridView1.Visible = true;
      IQueryable<\u003C\u003Ef__AnonymousType48<int, string, string, int?, int?, int?>> source = this.db.TBLPERSONEL.Where<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (musteri => musteri.ADISOYADI.Contains(this.AdiTxt.Text))).Select(musteri => new
      {
        ID = musteri.ID,
        ADI = musteri.ADI,
        SOYADI = musteri.SOYADI,
        BELDBIRIMIID = musteri.BELDBIRIMIID,
        UNVANID = musteri.UNVANID,
        BELDMUDURLUKID = musteri.BELDMUDURLUKID
      });
      if (source.Count() <= 0)
        return;
      this.dataGridView1.Visible = true;
      this.dataGridView1.DataSource = (object) source.ToList();
    }

    private void LoginKayitFormu_Load(object sender, EventArgs e)
    {
      this.dataGridView1.Visible = false;
      this.YetkiListele();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.personelId = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value);
      this.AdiTxt.Text = (this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value?.ToString() + " " + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[2].Value?.ToString()).ToString();
      this.dataGridView1.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void YetkiListele()
    {
      IQueryable<TBLMENU> queryable = this.db.TBLMENU.Select<TBLMENU, TBLMENU>((Expression<Func<TBLMENU, TBLMENU>>) (s => s));
      this.dataGridView2.Rows.Clear();
      this.dataGridView2.ColumnCount = 8;
      foreach (TBLMENU tblmenu in (IEnumerable<TBLMENU>) queryable)
        this.dataGridView2.Rows.Add((object) tblmenu.ID, (object) tblmenu.KOMUTADI, (object) false, (object) false, (object) false, (object) false, (object) false, (object) false);
      this.dataGridView2.AllowUserToAddRows = false;
    }

    private void kayit()
    {
      int num1 = 0;
      if (this.db.TBLKULLANICILAR.Where<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (p => p.PERSONELID == (int?) this.personelId)).Any<TBLKULLANICILAR>())
      {
        int num2 = (int) MessageBox.Show("Böyle bir kullanıcı mevcuttur");
      }
      else
      {
        try
        {
          TBLKULLANICILAR entity1 = new TBLKULLANICILAR()
          {
            KULLANICIADI = this.AdiTxt.Text,
            PERSONELID = new int?(this.personelId),
            SIFRE = this.sifre_txt.Text,
            SIFRETEKRAR = this.sifre_tekrar_txt.Text
          };
          entity1.PERSONELID = new int?(YetkiClass.personelid);
          entity1.ID = new int?(this.kullan.KullanicSonId());
          TBLPERSONEL tblpersonel = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (x => x.ID == this.personelId));
          int unvan_id = Convert.ToInt32((object) tblpersonel.UNVANID);
          TBLPERSUNVAN tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<Func<TBLPERSUNVAN, bool>>) (x => x.ID == unvan_id));
          entity1.GOREVYERI = tblpersonel.GOREVYERI;
          entity1.UNVANI = tblpersunvan.UNVAN;
          TBLFORMKULLANICI entity2 = new TBLFORMKULLANICI();
          foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
          {
            if (num1 < 67)
            {
              try
              {
                entity2.KOMUTADI = row.Cells[1].Value.ToString();
                entity2.KULLANICIID = entity1.ID;
                entity2.SALTOKUNUR = !(bool) row.Cells[2].Value ? "Evet" : "Hayır";
                entity2.KAYIT = new bool?((bool) row.Cells[3].Value);
                entity2.SİL = new bool?((bool) row.Cells[4].Value);
                entity2.GUNCELLEME = new bool?((bool) row.Cells[5].Value);
                entity2.LISTELEME = new bool?((bool) row.Cells[6].Value);
                this.db.TBLFORMKULLANICI.Add(entity2);
                this.db.SaveChanges();
              }
              catch (Exception ex)
              {
                int num3 = (int) MessageBox.Show(ex?.ToString() + " offf ya hata");
              }
            }
            ++num1;
          }
          this.db.TBLKULLANICILAR.Add(entity1);
          this.db.SaveChanges();
          int num4 = (int) MessageBox.Show("İşleminiz Başarılı bir şekilde gerçekleşti");
        }
        catch (Exception ex)
        {
          int num5 = (int) XtraMessageBox.Show("Hata Var.." + ex?.ToString());
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      switch (YetkiClass.secim)
      {
        case "Kayıt":
          this.kayit();
          break;
        case "guncelle":
          this.guncelle();
          break;
      }
    }

    private void button5_Click(object sender, EventArgs e) => Application.Exit();

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 7)
        return;
      try
      {
        if ((bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) false;
        else if (!(bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value = (object) true;
        if ((bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[2].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[3].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[4].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[5].Value = (object) true;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[6].Value = (object) true;
        }
        else if (!(bool) this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[7].Value)
        {
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[2].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[3].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[4].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[5].Value = (object) false;
          this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[6].Value = (object) false;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void guncelleload()
    {
      TBLKULLANICILAR tblkullanicilar = this.db.TBLKULLANICILAR.FirstOrDefault<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (x => x.ID == (int?) YetkiClass.secim_id));
      this.AdiTxt.Text = tblkullanicilar.KULLANICIADI;
      this.sifre_txt.Text = tblkullanicilar.SIFRE;
      int sorgu_id = Convert.ToInt32((object) tblkullanicilar.ID);
      this.sifre_tekrar_txt.Text = tblkullanicilar.SIFRETEKRAR;
      IQueryable<TBLFORMKULLANICI> queryable = this.db.TBLFORMKULLANICI.Where<TBLFORMKULLANICI>((Expression<Func<TBLFORMKULLANICI, bool>>) (hd => hd.KULLANICIID == (int?) sorgu_id));
      this.dataGridView2.Rows.Clear();
      this.dataGridView2.ColumnCount = 8;
      foreach (TBLFORMKULLANICI tblformkullanici in (IEnumerable<TBLFORMKULLANICI>) queryable)
      {
        bool flag = false;
        if (tblformkullanici.SALTOKUNUR == "Hayır")
          flag = true;
        this.dataGridView2.Rows.Add((object) tblformkullanici.ID, (object) tblformkullanici.KOMUTADI, (object) flag, (object) tblformkullanici.KAYIT, (object) tblformkullanici.SİL, (object) tblformkullanici.GUNCELLEME, (object) tblformkullanici.LISTELEME, (object) false);
      }
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView1.Visible = false;
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      if (!(YetkiClass.secim == "guncelle"))
        return;
      this.guncelleload();
    }

    private void guncelle()
    {
      TBLKULLANICILAR tblkullanicilar = this.db.TBLKULLANICILAR.FirstOrDefault<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (x => x.ID == (int?) YetkiClass.secim_id));
      tblkullanicilar.KULLANICIADI = this.AdiTxt.Text;
      tblkullanicilar.PERSONELID = new int?(this.personelId);
      tblkullanicilar.SIFRE = this.sifre_txt.Text;
      tblkullanicilar.ADISOYADI = this.AdiTxt.Text;
      tblkullanicilar.SIFRETEKRAR = this.sifre_tekrar_txt.Text;
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
      {
        int den = Convert.ToInt32(row.Cells[0].Value);
        TBLFORMKULLANICI tblformkullanici = this.db.TBLFORMKULLANICI.FirstOrDefault<TBLFORMKULLANICI>((Expression<Func<TBLFORMKULLANICI, bool>>) (x => x.ID == den));
        try
        {
          try
          {
            tblformkullanici.SALTOKUNUR = !(bool) row.Cells[2].Value ? "Evet" : "Hayır";
          }
          catch (Exception ex)
          {
            tblformkullanici.SALTOKUNUR = "Evet";
          }
          try
          {
            tblformkullanici.KAYIT = new bool?((bool) row.Cells[3].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.KAYIT = new bool?(false);
          }
          try
          {
            tblformkullanici.GUNCELLEME = new bool?((bool) row.Cells[5].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.GUNCELLEME = new bool?(false);
          }
          try
          {
            tblformkullanici.SİL = new bool?((bool) row.Cells[4].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.SİL = new bool?(false);
          }
          try
          {
            tblformkullanici.LISTELEME = new bool?((bool) row.Cells[6].Value);
          }
          catch (Exception ex)
          {
            tblformkullanici.LISTELEME = new bool?(false);
          }
          this.db.SaveChanges();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex?.ToString() + " offf ya hata");
        }
      }
      this.db.SaveChanges();
      int num1 = (int) MessageBox.Show("Güncelleme İşleminiz Başarılı bir şekilde gerçekleşti");
      this.guncelleload();
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
      this.label1 = new Label();
      this.sifre_txt = new TextBox();
      this.label6 = new Label();
      this.button1 = new Button();
      this.AdiTxt = new TextBox();
      this.label4 = new Label();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.panel2 = new Panel();
      this.button5 = new Button();
      this.button3 = new Button();
      this.panel1 = new Panel();
      this.dataGridView1 = new DataGridView();
      this.sifre_tekrar_txt = new TextBox();
      this.label2 = new Label();
      this.dataGridView2 = new DataGridView();
      this.Kodu = new DataGridViewTextBoxColumn();
      this.Başlık = new DataGridViewTextBoxColumn();
      this.Menu = new DataGridViewCheckBoxColumn();
      this.Kayıt = new DataGridViewCheckBoxColumn();
      this.Sil = new DataGridViewCheckBoxColumn();
      this.Düzenle = new DataGridViewCheckBoxColumn();
      this.Okuma = new DataGridViewCheckBoxColumn();
      this.Hepsi = new DataGridViewCheckBoxColumn();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.dataGridView2).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(474, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(211, 29);
      this.label1.TabIndex = 8;
      this.label1.Text = "KULLANICI KAYIT";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.sifre_txt.BackColor = Color.Ivory;
      this.sifre_txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.sifre_txt.Location = new Point(125, 141);
      this.sifre_txt.Multiline = true;
      this.sifre_txt.Name = "sifre_txt";
      this.sifre_txt.Size = new Size(322, 27);
      this.sifre_txt.TabIndex = 122;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(75, 144);
      this.label6.Name = "label6";
      this.label6.Size = new Size(47, 21);
      this.label6.TabIndex = 121;
      this.label6.Text = "Şifre";
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(1498, 6);
      this.button1.Name = "button1";
      this.button1.Size = new Size(31, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AdiTxt.BackColor = Color.Ivory;
      this.AdiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AdiTxt.Location = new Point(125, 104);
      this.AdiTxt.Multiline = true;
      this.AdiTxt.Name = "AdiTxt";
      this.AdiTxt.Size = new Size(322, 27);
      this.AdiTxt.TabIndex = 118;
      this.AdiTxt.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(8, 106);
      this.label4.Name = "label4";
      this.label4.Size = new Size(113, 21);
      this.label4.TabIndex = 117;
      this.label4.Text = "Kullanıcı Adı";
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 861);
      this.panel3.TabIndex = 112;
      this.panel4.BackColor = Color.SteelBlue;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(0, 908);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(1531, 6);
      this.panel4.TabIndex = 111;
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1531, 47);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(10, 867);
      this.panel2.TabIndex = 110;
      this.button5.BackColor = Color.SteelBlue;
      this.button5.FlatAppearance.BorderSize = 2;
      this.button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button5.ForeColor = Color.White;
      this.button5.Location = new Point(248, 650);
      this.button5.Name = "button5";
      this.button5.Size = new Size(170, 58);
      this.button5.TabIndex = 108;
      this.button5.Text = "Kapat";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button3.BackColor = Color.SteelBlue;
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(52, 650);
      this.button3.Name = "button3";
      this.button3.Size = new Size(170, 58);
      this.button3.TabIndex = 106;
      this.button3.Text = "Kaydet";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1541, 47);
      this.panel1.TabIndex = 104;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(122, 137);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new Size(744, 393);
      this.dataGridView1.TabIndex = 137;
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.sifre_tekrar_txt.BackColor = Color.Ivory;
      this.sifre_tekrar_txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.sifre_tekrar_txt.Location = new Point(125, 178);
      this.sifre_tekrar_txt.Multiline = true;
      this.sifre_tekrar_txt.Name = "sifre_tekrar_txt";
      this.sifre_tekrar_txt.Size = new Size(322, 27);
      this.sifre_tekrar_txt.TabIndex = 122;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.Location = new Point(15, 183);
      this.label2.Name = "label2";
      this.label2.Size = new Size(107, 21);
      this.label2.TabIndex = 121;
      this.label2.Text = "Şifre Tekrar";
      gridViewCellStyle1.BackColor = Color.Silver;
      this.dataGridView2.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange((DataGridViewColumn) this.Kodu, (DataGridViewColumn) this.Başlık, (DataGridViewColumn) this.Menu, (DataGridViewColumn) this.Kayıt, (DataGridViewColumn) this.Sil, (DataGridViewColumn) this.Düzenle, (DataGridViewColumn) this.Okuma, (DataGridViewColumn) this.Hepsi);
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridView2.DefaultCellStyle = gridViewCellStyle2;
      this.dataGridView2.Dock = DockStyle.Right;
      this.dataGridView2.Location = new Point(453, 47);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.Height = 30;
      this.dataGridView2.Size = new Size(1078, 861);
      this.dataGridView2.TabIndex = 138;
      this.dataGridView2.CellClick += new DataGridViewCellEventHandler(this.dataGridView2_CellClick);
      this.dataGridView2.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
      this.dataGridView2.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
      this.Kodu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      this.Kodu.FillWeight = 214.6786f;
      this.Kodu.HeaderText = "kodu";
      this.Kodu.Name = "Kodu";
      this.Kodu.Width = 40;
      this.Başlık.FillWeight = 173.7409f;
      this.Başlık.HeaderText = "Başlık";
      this.Başlık.Name = "Başlık";
      this.Menu.FalseValue = (object) "0";
      this.Menu.FillWeight = 50.12064f;
      this.Menu.HeaderText = "Menu";
      this.Menu.Name = "Menu";
      this.Kayıt.FalseValue = (object) "0";
      this.Kayıt.FillWeight = 48.42142f;
      this.Kayıt.HeaderText = "Kayıt";
      this.Kayıt.Name = "Kayıt";
      this.Sil.FalseValue = (object) "0";
      this.Sil.FillWeight = 46.00843f;
      this.Sil.HeaderText = "Sil";
      this.Sil.Name = "Sil";
      this.Düzenle.FalseValue = (object) "0";
      this.Düzenle.FillWeight = 42.73159f;
      this.Düzenle.HeaderText = "Düzenle";
      this.Düzenle.Name = "Düzenle";
      this.Okuma.FalseValue = (object) "0";
      this.Okuma.FillWeight = 38.4127f;
      this.Okuma.HeaderText = "Okuma";
      this.Okuma.Name = "Okuma";
      this.Hepsi.FalseValue = (object) "false";
      this.Hepsi.FillWeight = 32.84033f;
      this.Hepsi.HeaderText = "Hepsi";
      this.Hepsi.Name = "Hepsi";
      this.Hepsi.Resizable = DataGridViewTriState.True;
      this.Hepsi.SortMode = DataGridViewColumnSortMode.Automatic;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1541, 914);
      this.Controls.Add((Control) this.dataGridView2);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.sifre_tekrar_txt);
      this.Controls.Add((Control) this.sifre_txt);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.AdiTxt);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (LoginKayitFormu);
      this.Text = nameof (LoginKayitFormu);
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.LoginKayitFormu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.dataGridView2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
