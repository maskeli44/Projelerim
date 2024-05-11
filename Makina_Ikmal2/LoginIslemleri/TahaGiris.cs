// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.TahaGiris
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class TahaGiris : XtraForm
  {
    private string connetionString;
    private string connetionString1;
    private string connetionString2;
    private string connetionString3;
    private string connetionString4;
    private string connetionString5;
    private string connetionString6;
    private bellEntities db = new bellEntities();
    public static bool kontr;
    private IContainer components = (IContainer) null;
    private LayoutControl layoutControl1;
    private LayoutControlGroup Root;
    private Panel panel1;
    private Label label10;
    private CheckBox checkBox1;
    private Button button2;
    private Button button1;
    private Label label9;
    private Label label6;
    private Label label5;
    private Label label2;
    private Label label1;
    private LayoutControlItem layoutControlItem2;
    private Label label11;
    private TextEdit sifre;
    private TextEdit kullaniciadi;
    private PictureEdit pictureEdit2;
    private PictureEdit pictureEdit1;
    private LabelControl labelControl2;
    private LabelControl labelControl1;
    private System.Windows.Forms.ComboBox comboBox2;
    private CheckBox chkben;

    public TahaGiris()
    {
      this.InitializeComponent();
      this.Init_Data();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        IQueryable<TBLKULLANICILAR> source = this.db.TBLKULLANICILAR.Where<TBLKULLANICILAR>((Expression<Func<TBLKULLANICILAR, bool>>) (p => p.KULLANICIADI == this.kullaniciadi.Text && p.SIFRE == this.sifre.Text));
        if (source.Any<TBLKULLANICILAR>())
        {
          foreach (TBLKULLANICILAR tblkullanicilar in (IEnumerable<TBLKULLANICILAR>) source)
          {
            int id = Convert.ToInt32((object) tblkullanicilar.ID);
            this.db.TBLFORMKULLANICI.FirstOrDefault<TBLFORMKULLANICI>((Expression<Func<TBLFORMKULLANICI, bool>>) (x => x.ID == id));
            YetkiClass.kullanici_id = Convert.ToInt32((object) tblkullanicilar.PERSONELID);
            YetkiClass.kullanici_ad = tblkullanicilar.ADISOYADI;
            this.Save_Data();
            new fbaslangic().Show();
            this.Hide();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Kullanıcı adınızı veya şifreniz hatalı");
        }
      }
      catch
      {
        int num = (int) XtraMessageBox.Show("İnternet yok");
      }
    }

    private void Init_Data()
    {
      if (!(Settings.Default.KulanıcıAdı != string.Empty))
        return;
      if (Settings.Default.BeniHatırla)
      {
        this.kullaniciadi.Text = Settings.Default.KulanıcıAdı;
        this.sifre.Text = Settings.Default.Sifre;
        this.chkben.Checked = true;
      }
      else
        this.kullaniciadi.Text = Settings.Default.KulanıcıAdı;
    }

    private void Save_Data()
    {
      if (this.chkben.Checked)
      {
        Settings.Default.KulanıcıAdı = this.kullaniciadi.Text;
        Settings.Default.Sifre = this.sifre.Text;
        Settings.Default.BeniHatırla = true;
        Settings.Default.Save();
      }
      else
      {
        Settings.Default.KulanıcıAdı = "";
        Settings.Default.Sifre = "";
        Settings.Default.BeniHatırla = false;
        Settings.Default.Save();
      }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => Application.Exit();

    private void TahaGiris_Load(object sender, EventArgs e)
    {
      try
      {
        this.sorumlulariyukle();
        this.kullaniciadi.Focus();
      }
      catch
      {
        int num = (int) XtraMessageBox.Show("İNTERNET YOK");
      }
    }

    private void SqlTanimla()
    {
    }

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
      try
      {
        this.label5.Text = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (x => x.ID == sorumlu.dairebaskani)).ADISOYADI;
      }
      catch (Exception ex)
      {
      }
      try
      {
        this.label6.Text = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (x => x.ID == sorumlu.subemuduru)).ADISOYADI;
      }
      catch (Exception ex)
      {
      }
    }

    private void kullaniciadi_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      this.sifre.Focus();
    }

    private void sifre_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      this.button1.Focus();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      string databesname = "";
      if (this.comboBox2.SelectedIndex == 0)
        databesname = "bell2019-2020";
      else if (this.comboBox2.SelectedIndex == 1)
        databesname = "ikmal_2021";
      else if (this.comboBox2.SelectedIndex == 2)
        databesname = "bell";
      this.connetionString = string.Format("Data Source=.;Initial Catalog=" + databesname + ";Integrated Security=True");
      this.connetionString2 = string.Format("Data Source=.;Initial Catalog=" + databesname + ";Integrated Security=True");
      this.connetionString3 = string.Format("Data Source=.;Initial Catalog=" + databesname + ";Integrated Security=True ");
      this.connetionString4 = string.Format("XpoProvider=MSSqlServer;data source=.;integrated security=SSPI;initial catalog=" + databesname + " ");
      this.connetionString5 = string.Format("XpoProvider=MSSqlServer;data source=.;integrated security=SSPI;initial catalog=" + databesname + " ");
      this.connetionString6 = string.Format("Data Source=.;Initial Catalog=" + databesname + ";Integrated Security=True ");
      try
      {
        appconfig appconfig = new appconfig();
        appconfig.SaveConnectionString("Makina_Ikmal.Properties.Settings.belediyeConnectionString", this.connetionString);
        appconfig.SaveConnectionString("Makina_Ikmal.Properties.Settings.bellConnectionString", this.connetionString2);
        appconfig.SaveConnectionString("Makina_Ikmal.Properties.Settings.bellConnectionString1", this.connetionString3);
        appconfig.SaveConnectionString("bellConnectionString", this.connetionString4);
        appconfig.SaveConnectionString("bellConnectionString1", this.connetionString5);
        appconfig.SaveConnectionString("Makina_Ikmal.Properties.Settings.makina_ikmalConnectionString", this.connetionString6);
        TahaGiris.kontr = true;
        ConfigurationManager.RefreshSection("appSettings");
        TahaGiris.test(databesname);
        Application.Restart();
      }
      catch (Exception ex)
      {
      }
    }

    private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private static void test(string databesname)
    {
      string str1 = "System.Data.SqlClient";
      string str2 = ".";
      string str3 = databesname;
      string str4 = new SqlConnectionStringBuilder()
      {
        DataSource = str2,
        InitialCatalog = str3,
        IntegratedSecurity = true,
        MultipleActiveResultSets = true
      }.ToString();
      EntityConnectionStringBuilder connectionStringBuilder = new EntityConnectionStringBuilder();
      connectionStringBuilder.Provider = str1;
      connectionStringBuilder.ProviderConnectionString = str4;
      connectionStringBuilder.Metadata = "res://*/Model.beldiye.csdl|res://*/Model.beldiye.ssdl|res://*/Model.beldiye.msl";
      System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      configuration.ConnectionStrings.ConnectionStrings["bellEntities"].ConnectionString = connectionStringBuilder.ToString();
      configuration.ConnectionStrings.ConnectionStrings["bellEntities"].ProviderName = "System.Data.EntityClient";
      configuration.Save(ConfigurationSaveMode.Modified);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.layoutControl1 = new LayoutControl();
      this.panel1 = new Panel();
      this.chkben = new CheckBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.labelControl2 = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.sifre = new TextEdit();
      this.kullaniciadi = new TextEdit();
      this.pictureEdit2 = new PictureEdit();
      this.pictureEdit1 = new PictureEdit();
      this.label11 = new Label();
      this.label10 = new Label();
      this.checkBox1 = new CheckBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.label9 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.Root = new LayoutControlGroup();
      this.layoutControlItem2 = new LayoutControlItem();
      this.layoutControl1.BeginInit();
      this.layoutControl1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.sifre.Properties.BeginInit();
      this.kullaniciadi.Properties.BeginInit();
      this.pictureEdit2.Properties.BeginInit();
      this.pictureEdit1.Properties.BeginInit();
      this.Root.BeginInit();
      this.layoutControlItem2.BeginInit();
      this.SuspendLayout();
      this.layoutControl1.Controls.Add((Control) this.panel1);
      this.layoutControl1.Dock = DockStyle.Fill;
      this.layoutControl1.Location = new Point(0, 0);
      this.layoutControl1.Margin = new Padding(3, 2, 3, 2);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new Size(670, 383);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      this.panel1.BackColor = Color.MediumAquamarine;
      this.panel1.Controls.Add((Control) this.chkben);
      this.panel1.Controls.Add((Control) this.comboBox2);
      this.panel1.Controls.Add((Control) this.labelControl2);
      this.panel1.Controls.Add((Control) this.labelControl1);
      this.panel1.Controls.Add((Control) this.sifre);
      this.panel1.Controls.Add((Control) this.kullaniciadi);
      this.panel1.Controls.Add((Control) this.pictureEdit2);
      this.panel1.Controls.Add((Control) this.pictureEdit1);
      this.panel1.Controls.Add((Control) this.label11);
      this.panel1.Controls.Add((Control) this.label10);
      this.panel1.Controls.Add((Control) this.checkBox1);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.panel1.Location = new Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(646, 359);
      this.panel1.TabIndex = 5;
      this.chkben.AutoSize = true;
      this.chkben.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chkben.Location = new Point(487, 327);
      this.chkben.Margin = new Padding(3, 2, 3, 2);
      this.chkben.Name = "chkben";
      this.chkben.Size = new Size(102, 22);
      this.chkben.TabIndex = 21;
      this.chkben.Text = "Beni Hatırla";
      this.chkben.UseVisualStyleBackColor = true;
      this.comboBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[3]
      {
        (object) "2019-2020",
        (object) "2021",
        (object) "2022"
      });
      this.comboBox2.Location = new Point(24, 245);
      this.comboBox2.Margin = new Padding(3, 2, 3, 2);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(124, 28);
      this.comboBox2.TabIndex = 20;
      this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
      this.labelControl2.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(230, 282);
      this.labelControl2.Margin = new Padding(3, 2, 3, 2);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(32, 19);
      this.labelControl2.TabIndex = 19;
      this.labelControl2.Text = "Şifre";
      this.labelControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(170, 245);
      this.labelControl1.Margin = new Padding(3, 2, 3, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(87, 19);
      this.labelControl1.TabIndex = 19;
      this.labelControl1.Text = "Kullanıcı Adı";
      this.sifre.Location = new Point(267, 280);
      this.sifre.Margin = new Padding(3, 2, 3, 2);
      this.sifre.Name = "sifre";
      this.sifre.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.sifre.Properties.Appearance.Options.UseFont = true;
      this.sifre.Properties.PasswordChar = '*';
      this.sifre.Size = new Size(206, 26);
      this.sifre.TabIndex = 18;
      this.sifre.KeyDown += new KeyEventHandler(this.sifre_KeyDown);
      this.kullaniciadi.Location = new Point(267, 243);
      this.kullaniciadi.Margin = new Padding(3, 2, 3, 2);
      this.kullaniciadi.Name = "kullaniciadi";
      this.kullaniciadi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kullaniciadi.Properties.Appearance.Options.UseFont = true;
      this.kullaniciadi.Size = new Size(206, 26);
      this.kullaniciadi.TabIndex = 17;
      this.kullaniciadi.KeyDown += new KeyEventHandler(this.kullaniciadi_KeyDown);
      this.pictureEdit2.EditValue = (object) Resources.logo;
      this.pictureEdit2.Location = new Point(2, 58);
      this.pictureEdit2.Margin = new Padding(3, 2, 3, 2);
      this.pictureEdit2.Name = "pictureEdit2";
      this.pictureEdit2.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit2.Properties.SizeMode = PictureSizeMode.Zoom;
      this.pictureEdit2.Size = new Size(157, 174);
      this.pictureEdit2.TabIndex = 16;
      this.pictureEdit1.EditValue = (object) Resources.logo;
      this.pictureEdit1.Location = new Point(487, 58);
      this.pictureEdit1.Margin = new Padding(3, 2, 3, 2);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom;
      this.pictureEdit1.Size = new Size(157, 174);
      this.pictureEdit1.TabIndex = 16;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Arial", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label11.Location = new Point(517, 734);
      this.label11.Name = "label11";
      this.label11.Size = new Size(148, 16);
      this.label11.TabIndex = 15;
      this.label11.Text = "BAYER YAZILIM -2022";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label10.Location = new Point(510, 874);
      this.label10.Name = "label10";
      this.label10.Size = new Size(125, 15);
      this.label10.TabIndex = 14;
      this.label10.Text = "BAYER YAZILIM -2022";
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.checkBox1.Location = new Point(25, 580);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(110, 24);
      this.checkBox1.TabIndex = 12;
      this.checkBox1.Text = "Beni Hatırla";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.button2.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.SaddleBrown;
      this.button2.Location = new Point(373, 321);
      this.button2.Name = "button2";
      this.button2.Size = new Size(100, 36);
      this.button2.TabIndex = 11;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button1.ForeColor = Color.SaddleBrown;
      this.button1.Location = new Point(267, 321);
      this.button1.Name = "button1";
      this.button1.Size = new Size(99, 36);
      this.button1.TabIndex = 10;
      this.button1.Text = "Giriş";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 162);
      this.label9.Location = new Point(464, 917);
      this.label9.Name = "label9";
      this.label9.Size = new Size(155, 17);
      this.label9.TabIndex = 9;
      this.label9.Text = "BAYER YAZILIM 2022";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(263, 164);
      this.label6.Name = "label6";
      this.label6.Size = new Size(0, 20);
      this.label6.TabIndex = 4;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label5.Location = new Point(211, 131);
      this.label5.Name = "label5";
      this.label5.Size = new Size(0, 24);
      this.label5.TabIndex = 2;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Calibri", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label2.ForeColor = Color.DarkRed;
      this.label2.Location = new Point(175, 58);
      this.label2.Name = "label2";
      this.label2.Size = new Size(271, 72);
      this.label2.TabIndex = 1;
      this.label2.Text = "MAKİNE İKMAL ŞUBE\r\n       MÜDÜRLÜĞÜ";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Calibri", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label1.Location = new Point(18, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(546, 42);
      this.label1.TabIndex = 0;
      this.label1.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYESİ";
      this.Root.EnableIndentsWithoutBorders = DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new BaseLayoutItem[1]
      {
        (BaseLayoutItem) this.layoutControlItem2
      });
      this.Root.Name = "Root";
      this.Root.Size = new Size(670, 383);
      this.Root.TextVisible = false;
      this.layoutControlItem2.Control = (Control) this.panel1;
      this.layoutControlItem2.Location = new Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new Size(650, 363);
      this.layoutControlItem2.TextSize = new Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(670, 383);
      this.Controls.Add((Control) this.layoutControl1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (TahaGiris);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Kullanıcı Giriş";
      this.Load += new EventHandler(this.TahaGiris_Load);
      this.layoutControl1.EndInit();
      this.layoutControl1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.sifre.Properties.EndInit();
      this.kullaniciadi.Properties.EndInit();
      this.pictureEdit2.Properties.EndInit();
      this.pictureEdit1.Properties.EndInit();
      this.Root.EndInit();
      this.layoutControlItem2.EndInit();
      this.ResumeLayout(false);
    }
  }
}
