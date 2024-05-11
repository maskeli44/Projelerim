// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.fbaslangic
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Makina_Ikmal.AKemalBaskanlik;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Otomasyon;
using Makina_Ikmal.Properties;
using Makina_Ikmal.Sabitler;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makina_Ikmal
{
  public class fbaslangic : XtraForm
  {
    private bellEntities db = new bellEntities();
    private YetkiClass yetkili = new YetkiClass();
    private IContainer components = (IContainer) null;
    private Button bBaskanlik;
    private Button bMudurluk;
    private Button bInsanKaynaklari;
    private Button button9;
    private Button button10;
    private Button button1;
    private Button button11;
    private Button button2;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button7;
    private LabelControl labelControl1;
    private Button button8;
    private Button button12;

    public fbaslangic() => this.InitializeComponent();

    private void fbaslangic_Load(object sender, EventArgs e)
    {
      if (Settings.Default.TemaSkin != "")
      {
        UserLookAndFeel.Default.SetSkinStyle(Settings.Default.TemaSkin);
      }
      else
      {
        UserLookAndFeel.Default.SetSkinStyle("Pumpkin");
        Settings.Default.Save();
      }
      try
      {
        this.sorumlulariyukle();
      }
      catch
      {
        int num = (int) XtraMessageBox.Show("İnternet yok");
      }
    }

    private Task NetKontrol() => Task.Run((Action) (() =>
    {
      try
      {
        new TcpClient("www.google.com.tr", 80).Close();
      }
      catch (Exception ex)
      {
        int num = (int) XtraMessageBox.Show(ex.Message, "İnternet hatası!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }));

    private void sorumlulariyukle()
    {
      TBLYETKILIMZA tblyetkilimza = this.db.TBLYETKILIMZA.FirstOrDefault<TBLYETKILIMZA>((Expression<Func<TBLYETKILIMZA, bool>>) (x => x.ID == 1));
      sorumlu.belediyebaskani = Convert.ToInt32((object) tblyetkilimza.BELBSKNID);
      sorumlu.genelsekreter = Convert.ToInt32((object) tblyetkilimza.GENELSKRTRID);
      sorumlu.genelsekreteryardimcisi = Convert.ToInt32((object) tblyetkilimza.GENELSKRTRYRDMCID);
      sorumlu.dairebaskani = Convert.ToInt32((object) tblyetkilimza.DAIREBSKNID);
      sorumlu.subemuduru = Convert.ToInt32((object) tblyetkilimza.SUBEMDRID);
      sorumlu.atolyesefi = Convert.ToInt32((object) tblyetkilimza.ATOLYESEFID);
      sorumlu.depoyetkilisi = Convert.ToInt32((object) tblyetkilimza.DEPOYETKILID);
      sorumlu.kabulkomisyonbaskanı = Convert.ToInt32((object) tblyetkilimza.KABULKOMBASKANID);
      sorumlu.kabulkom1 = Convert.ToInt32((object) tblyetkilimza.KABULKOMUYE1ID);
      sorumlu.kabulkom2 = Convert.ToInt32((object) tblyetkilimza.KABULKOMUYE2ID);
      sorumlu.yagsorumlusu = Convert.ToInt32((object) tblyetkilimza.YAGSORUMLUSU);
      sorumlu.teklifsorumlusu = Convert.ToInt32((object) tblyetkilimza.TKLFSORUMLUID);
      sorumlu.piyasa1 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMABSKNID);
      sorumlu.piyasa2 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMAUYE1ID);
      sorumlu.piyasa3 = Convert.ToInt32((object) tblyetkilimza.PYSARSTRMAUYE2ID);
    }

    private void bInsanKaynaklari_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("PERSONEL"))
      {
        int num1 = (int) new Makina_Ikmal.insankaynak.Basinsan().ShowDialog();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("ARAÇ BÖLÜMÜ"))
      {
        new Makina_Ikmal.AracBolumu.AracBolumu().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int num = (int) new Makina_Ikmal.Hakkimizda.Hakkimizda().ShowDialog();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("SATIN ALMA"))
      {
        new Makina_Ikmal.SatinAlma.GirisSayfasi().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("ATÖLYE İŞLEM"))
      {
        int num1 = (int) new Makina_Ikmal.Atolye.BasDepo().ShowDialog();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button9_Click(object sender, EventArgs e) => Application.Exit();

    private void button6_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("AKARYAKIT"))
      {
        new Makina_Ikmal.Akaryakit.GirisSayfasi().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("TAŞIT GÖREV"))
      {
        new Makina_Ikmal.Tasit.Basinsan().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button7_Click(object sender, EventArgs e) => new YetkiliImzaAyarlamasi().Show();

    private void bBaskanlik_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("BAŞKANLIK"))
      {
        new Baskanlik().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void bMudurluk_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("BAŞKANLIK"))
      {
        new Makina_Ikmal.Mudurlukk.Basinsan().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("OTOMASYON BİRİMİ"))
      {
        new OtomasyonGiris().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("MALZEME") || this.yetkili.MenuYetkilendirme("DEPO FİŞLERİ"))
      {
        new Makina_Ikmal.Aambar.BasDepo().Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button7_Click_1(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("ATÖLYE İŞLEM"))
      {
        int num1 = (int) new Makina_Ikmal.YagBolum.Basinsan().ShowDialog();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
      }
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (this.yetkili.MenuYetkilendirme("ATÖLYE İŞLEM"))
        return;
      int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmamaktadır.");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fbaslangic));
      this.bBaskanlik = new Button();
      this.bMudurluk = new Button();
      this.labelControl1 = new LabelControl();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.button8 = new Button();
      this.button7 = new Button();
      this.button3 = new Button();
      this.button2 = new Button();
      this.button12 = new Button();
      this.button11 = new Button();
      this.button1 = new Button();
      this.button10 = new Button();
      this.button9 = new Button();
      this.bInsanKaynaklari = new Button();
      this.SuspendLayout();
      this.bBaskanlik.BackColor = Color.SeaShell;
      this.bBaskanlik.FlatAppearance.BorderColor = Color.SeaShell;
      this.bBaskanlik.FlatStyle = FlatStyle.Flat;
      this.bBaskanlik.Font = new Font("Microsoft Sans Serif", 30f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bBaskanlik.Location = new Point(39, 109);
      this.bBaskanlik.Margin = new Padding(4);
      this.bBaskanlik.Name = "bBaskanlik";
      this.bBaskanlik.Size = new Size(439, 89);
      this.bBaskanlik.TabIndex = 10;
      this.bBaskanlik.Text = "BAŞKANLIK";
      this.bBaskanlik.UseVisualStyleBackColor = false;
      this.bBaskanlik.Click += new EventHandler(this.bBaskanlik_Click);
      this.bMudurluk.BackColor = Color.SeaShell;
      this.bMudurluk.FlatAppearance.BorderColor = Color.SeaShell;
      this.bMudurluk.FlatStyle = FlatStyle.Flat;
      this.bMudurluk.Font = new Font("Microsoft Sans Serif", 30f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bMudurluk.Location = new Point(523, 109);
      this.bMudurluk.Margin = new Padding(4);
      this.bMudurluk.Name = "bMudurluk";
      this.bMudurluk.Size = new Size(439, 89);
      this.bMudurluk.TabIndex = 11;
      this.bMudurluk.Text = "MÜDÜRLÜK";
      this.bMudurluk.UseVisualStyleBackColor = false;
      this.bMudurluk.Click += new EventHandler(this.bMudurluk_Click);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.ForeColor = Color.White;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.AutoSizeMode = LabelAutoSizeMode.Horizontal;
      this.labelControl1.Location = new Point(121, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(1001, 69);
      this.labelControl1.TabIndex = 36;
      this.labelControl1.Text = "MAKİNE İKMAL YÖNETİM SİSTEMİ";
      this.button4.BackColor = Color.FromArgb(11, 34, 57);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Georgia", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.WhiteSmoke;
      this.button4.Image = (Image) Resources.car_insurance;
      this.button4.Location = new Point(761, 417);
      this.button4.Margin = new Padding(4);
      this.button4.Name = "button4";
      this.button4.Size = new Size(200, 153);
      this.button4.TabIndex = 35;
      this.button4.Text = "Taşıt Görevlendirme";
      this.button4.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.BackColor = Color.FromArgb(11, 34, 57);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button5.ForeColor = Color.WhiteSmoke;
      this.button5.Image = (Image) Resources.map64;
      this.button5.Location = new Point(523, 417);
      this.button5.Margin = new Padding(4);
      this.button5.Name = "button5";
      this.button5.Size = new Size(200, 153);
      this.button5.TabIndex = 34;
      this.button5.Text = "Otomasyon";
      this.button5.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.FromArgb(11, 34, 57);
      this.button6.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button6.ForeColor = Color.WhiteSmoke;
      this.button6.Image = (Image) Resources.petrol_station;
      this.button6.Location = new Point(277, 417);
      this.button6.Margin = new Padding(4);
      this.button6.Name = "button6";
      this.button6.Size = new Size(200, 153);
      this.button6.TabIndex = 33;
      this.button6.Text = "Akaryakıt";
      this.button6.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button8.BackColor = Color.FromArgb(11, 34, 57);
      this.button8.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button8.ForeColor = Color.WhiteSmoke;
      this.button8.Image = (Image) Resources.warehouse;
      this.button8.Location = new Point(523, 564);
      this.button8.Margin = new Padding(4);
      this.button8.Name = "button8";
      this.button8.Size = new Size(200, 153);
      this.button8.TabIndex = 32;
      this.button8.Text = "AYARLAR";
      this.button8.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button7_Click);
      this.button7.BackColor = Color.FromArgb(11, 34, 57);
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button7.ForeColor = Color.WhiteSmoke;
      this.button7.Image = (Image) Resources.warehouse;
      this.button7.Location = new Point(277, 564);
      this.button7.Margin = new Padding(4);
      this.button7.Name = "button7";
      this.button7.Size = new Size(200, 153);
      this.button7.TabIndex = 32;
      this.button7.Text = "Yağ Bölümü";
      this.button7.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click_1);
      this.button3.BackColor = Color.FromArgb(11, 34, 57);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.WhiteSmoke;
      this.button3.Image = (Image) Resources.warehouse;
      this.button3.Location = new Point(39, 564);
      this.button3.Margin = new Padding(4);
      this.button3.Name = "button3";
      this.button3.Size = new Size(200, 153);
      this.button3.TabIndex = 32;
      this.button3.Text = "Hakkımızda";
      this.button3.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button2.BackColor = Color.FromArgb(11, 34, 57);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Georgia", 10.5f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.WhiteSmoke;
      this.button2.Image = (Image) Resources.warehouse;
      this.button2.Location = new Point(39, 417);
      this.button2.Margin = new Padding(4);
      this.button2.Name = "button2";
      this.button2.Size = new Size(200, 153);
      this.button2.TabIndex = 32;
      this.button2.Text = "Ambar";
      this.button2.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button12.BackColor = Color.FromArgb(11, 34, 57);
      this.button12.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button12.FlatStyle = FlatStyle.Flat;
      this.button12.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button12.ForeColor = Color.WhiteSmoke;
      this.button12.Image = (Image) Resources.certification;
      this.button12.Location = new Point(1017, 242);
      this.button12.Margin = new Padding(4);
      this.button12.Name = "button12";
      this.button12.Size = new Size(200, 153);
      this.button12.TabIndex = 31;
      this.button12.Text = "Hakediş";
      this.button12.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.button11.BackColor = Color.FromArgb(11, 34, 57);
      this.button11.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button11.FlatStyle = FlatStyle.Flat;
      this.button11.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button11.ForeColor = Color.WhiteSmoke;
      this.button11.Image = (Image) Resources.certification;
      this.button11.Location = new Point(761, 242);
      this.button11.Margin = new Padding(4);
      this.button11.Name = "button11";
      this.button11.Size = new Size(200, 153);
      this.button11.TabIndex = 31;
      this.button11.Text = "Araç Sicil";
      this.button11.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button1.BackColor = Color.FromArgb(11, 34, 57);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button1.ForeColor = Color.WhiteSmoke;
      this.button1.Image = (Image) Resources.mechanic;
      this.button1.Location = new Point(523, 242);
      this.button1.Margin = new Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new Size(200, 153);
      this.button1.TabIndex = 30;
      this.button1.Text = "Atölye";
      this.button1.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button10.BackColor = Color.FromArgb(11, 34, 57);
      this.button10.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.button10.FlatStyle = FlatStyle.Flat;
      this.button10.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button10.ForeColor = Color.WhiteSmoke;
      this.button10.Image = (Image) Resources.buy;
      this.button10.Location = new Point(277, 242);
      this.button10.Margin = new Padding(4);
      this.button10.Name = "button10";
      this.button10.Size = new Size(200, 153);
      this.button10.TabIndex = 29;
      this.button10.Text = "Satın Alma";
      this.button10.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.button9.BackColor = Color.Crimson;
      this.button9.FlatAppearance.BorderColor = Color.Crimson;
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button9.ForeColor = Color.WhiteSmoke;
      this.button9.Image = (Image) Resources.exit4854;
      this.button9.ImageAlign = ContentAlignment.TopLeft;
      this.button9.Location = new Point(806, 617);
      this.button9.Margin = new Padding(4);
      this.button9.Name = "button9";
      this.button9.Size = new Size(155, 62);
      this.button9.TabIndex = 27;
      this.button9.Text = "ÇIKIŞ";
      this.button9.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.bInsanKaynaklari.BackColor = Color.FromArgb(11, 34, 57);
      this.bInsanKaynaklari.FlatAppearance.BorderColor = Color.FromArgb(11, 34, 57);
      this.bInsanKaynaklari.FlatStyle = FlatStyle.Flat;
      this.bInsanKaynaklari.Font = new Font("Georgia", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bInsanKaynaklari.ForeColor = Color.WhiteSmoke;
      this.bInsanKaynaklari.Image = (Image) Resources.ık64;
      this.bInsanKaynaklari.Location = new Point(39, 242);
      this.bInsanKaynaklari.Margin = new Padding(4);
      this.bInsanKaynaklari.Name = "bInsanKaynaklari";
      this.bInsanKaynaklari.Size = new Size(200, 153);
      this.bInsanKaynaklari.TabIndex = 14;
      this.bInsanKaynaklari.Text = "İnsan Kaynakları";
      this.bInsanKaynaklari.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bInsanKaynaklari.UseVisualStyleBackColor = false;
      this.bInsanKaynaklari.Click += new EventHandler(this.bInsanKaynaklari_Click);
      this.Appearance.BackColor = Color.FromArgb(11, 34, 57);
      this.Appearance.ForeColor = SystemColors.ControlText;
      this.Appearance.Options.UseBackColor = true;
      this.Appearance.Options.UseFont = true;
      this.Appearance.Options.UseForeColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1315, 692);
      this.Controls.Add((Control) this.labelControl1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.button11);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.bInsanKaynaklari);
      this.Controls.Add((Control) this.bMudurluk);
      this.Controls.Add((Control) this.bBaskanlik);
      this.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.IconOptions.Icon = (Icon) componentResourceManager.GetObject("fbaslangic.IconOptions.Icon");
      this.Margin = new Padding(4);
      this.Name = nameof (fbaslangic);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Makine İkmal Yönetim Sistemi";
      this.Load += new EventHandler(this.fbaslangic_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
