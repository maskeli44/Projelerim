// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.fEkle
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
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal
{
  public class fEkle : Form
  {
    private bellEntities db = new bellEntities();
    private KullaniciSonId ser = new KullaniciSonId();
    private YetkiClass yet = new YetkiClass();
    private Resimleme rs = new Resimleme();
    private string resimyolu;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label girisLabel;
    private Button button1;
    private Button button4;
    private Button button3;
    private Button button2;
    private PictureBox ResimPic;
    private Panel panel2;
    private Panel panel4;
    private Panel panel3;
    private Label label2;
    private TextBox kodTxt;
    private TextBox TcTxt;
    private Label label3;
    private TextBox AdiTxt;
    private Label label4;
    private TextBox SicilTxt;
    private Label label5;
    private TextBox SoyadTxt;
    private Label label6;
    private Label label7;
    private ComboBox egitimDurumCombo;
    private ComboBox UnvanCombo;
    private Label label8;
    private ComboBox IstidamCombo;
    private Label label9;
    private TextBox GorevYeriTxt;
    private Label label10;
    private ComboBox GorevUnvanCombo;
    private Label label11;
    private ComboBox BirimAdiCombo;
    private Label label12;
    private ComboBox MudurlukCombo;
    private Label label13;
    private Label label15;
    private ComboBox YetkiIzmaCombo;
    private Label label16;
    private TextBox CocukSayisiTxt;
    private Label label17;
    private ComboBox KanGrubuCombo;
    private Label label18;
    private Label label19;
    private Label label20;
    private Label label21;
    private Label label23;
    private TextBox Telefon2Txt;
    private Label label24;
    private TextBox Telefon1Txt;
    private Label label25;
    private ComboBox KayitDurumuCombo;
    private Label label14;
    private DateTimePicker GirisTarihiDate;
    private ComboBox EhliyetBilgisiCombo;
    private DateTimePicker EhliyetTarihiDate;
    private DateTimePicker DogumTarihiDate;
    private TextBox ParafTxt;
    private Button button6;
    private TextBox ikametAdresiTxt;
    private Label label22;
    private Button button5;
    private TextBox SiraNoTxt;
    private Label label26;
    private Label zimmetlabel;
    private Label zimmetdegerlabel;
    private Button button7;

    public fEkle() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      fEkle.ReleaseCapture();
      fEkle.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void fEkle_Load(object sender, EventArgs e)
    {
      this.yet.yetkiislemleri("PERSONEL");
      this.kodTxt.Text = this.ser.PersonelP();
      this.UnvanCombo.DataSource = (object) this.db.TBLPERSUNVAN.ToList<TBLPERSUNVAN>();
      this.UnvanCombo.ValueMember = "ID";
      this.UnvanCombo.DisplayMember = "UNVAN";
      this.egitimDurumCombo.DataSource = (object) this.db.TBLPERSEGITIMDRM.ToList<TBLPERSEGITIMDRM>();
      this.egitimDurumCombo.ValueMember = "ID";
      this.egitimDurumCombo.DisplayMember = "EGITIMDURUM";
      this.BirimAdiCombo.DataSource = (object) this.db.TBLBELDBIRIMLER.ToList<TBLBELDBIRIMLER>();
      this.BirimAdiCombo.ValueMember = "ID";
      this.BirimAdiCombo.DisplayMember = "BELDBIRIMADI";
      this.GorevUnvanCombo.DataSource = (object) this.db.TBLPERSKURUMGOREV.ToList<TBLPERSKURUMGOREV>();
      this.GorevUnvanCombo.ValueMember = "ID";
      this.GorevUnvanCombo.DisplayMember = "KURUMGOREV";
      this.MudurlukCombo.DataSource = (object) this.db.TBLBELDMUDURLUK.ToList<TBLBELDMUDURLUK>();
      this.MudurlukCombo.ValueMember = "ID";
      this.MudurlukCombo.DisplayMember = "BELDMUDURLUK";
      this.EhliyetBilgisiCombo.DataSource = (object) this.db.TBLPERSEHLIYET.ToList<TBLPERSEHLIYET>();
      this.EhliyetBilgisiCombo.ValueMember = "ID";
      this.EhliyetBilgisiCombo.DisplayMember = "EHLIYET";
      switch (YetkiClass.secim)
      {
        case "kayit":
          this.kayitload();
          this.silmeislemi();
          break;
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button3_Click(object sender, EventArgs e)
    {
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
      {
        this.kayit();
        this.silmeislemi();
      }
      else
      {
        if (!(YetkiClass.secim == "guncelle") || YetkiClass.GuncelleYetki != 1 || !(YetkiClass.menuyetki == "Hayır"))
          return;
        this.guncelle();
      }
    }

    private void YetkiIzmaCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.YetkiIzmaCombo.Text == "Var")
        this.ParafTxt.Enabled = false;
      else
        this.ParafTxt.Enabled = true;
    }

    private void kayit()
    {
      TBLPERSONEL entity = new TBLPERSONEL();
      try
      {
        entity.ADI = this.AdiTxt.Text;
        entity.SOYADI = this.SoyadTxt.Text;
        entity.ADISOYADI = this.AdiTxt.Text + " " + this.SoyadTxt.Text;
        entity.TCKIMLIKNO = this.TcTxt.Text;
        entity.SICILNO = this.SicilTxt.Text;
        entity.KOD = this.kodTxt.Text;
        entity.ID = this.ser.personelSonId();
        entity.UNVANID = new int?(Convert.ToInt32(this.UnvanCombo.SelectedValue));
        entity.GOREVUNVANID = new int?(Convert.ToInt32(this.GorevUnvanCombo.SelectedValue));
        entity.EGITIMID = new int?(Convert.ToInt32(this.egitimDurumCombo.SelectedValue));
        entity.EHLIYETID = new int?(Convert.ToInt32(this.EhliyetBilgisiCombo.SelectedValue));
        entity.EHLVERTARIH = this.EhliyetTarihiDate.Value.ToString();
        entity.BELDBIRIMIID = new int?(Convert.ToInt32(this.BirimAdiCombo.SelectedValue));
        entity.BELDMUDURLUKID = new int?(Convert.ToInt32(this.MudurlukCombo.SelectedValue));
        entity.GOREVYERI = this.GorevYeriTxt.Text;
        entity.KANGRUPID = new int?(this.KanGrubuCombo.SelectedIndex);
        if (this.YetkiIzmaCombo.Text == "Var")
        {
          this.ParafTxt.Enabled = false;
        }
        else
        {
          this.ParafTxt.Enabled = true;
          entity.PARAFTANIM = this.ParafTxt.Text;
        }
        entity.YETKILIIMZAID = new int?(Convert.ToInt32(this.YetkiIzmaCombo.SelectedIndex));
        entity.IKMADRES = this.ikametAdresiTxt.Text;
        entity.CEPTELEFON = this.Telefon1Txt.Text;
        entity.CEPTELEFON2 = this.Telefon2Txt.Text;
        entity.COCUKTOPLAM = new int?(Convert.ToInt32(this.CocukSayisiTxt.Text));
        entity.SIRANO = this.SiraNoTxt.Text;
        entity.ISEGIRISTARIHI = new DateTime?(Convert.ToDateTime(this.GirisTarihiDate.Value));
        entity.DOGUMTARIHI = new DateTime?(Convert.ToDateTime(this.DogumTarihiDate.Value));
        entity.SAVEUSER = YetkiClass.kullanici_ad;
        entity.SAVEDATE = new DateTime?(DateTime.Now);
        int num = this.KayitDurumuCombo.Text == "Aktif" ? 1 : 2;
        entity.PERSDURUMID = new int?(num);
        this.db.TBLPERSONEL.Add(entity);
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " Hata var");
      }
    }

    private void button6_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
      int num = (int) openFileDialog.ShowDialog();
      this.resimyolu = openFileDialog.FileName;
      this.ResimPic.ImageLocation = this.resimyolu;
    }

    public static byte[] converterDemo(Image x) => (byte[]) new ImageConverter().ConvertTo((object) x, typeof (byte[]));

    private void kayitload()
    {
      this.zimmetlabel.Visible = false;
      this.zimmetdegerlabel.Visible = false;
      this.ParafTxt.Enabled = false;
    }

    private void guncelleload()
    {
      try
      {
        this.girisLabel.Text = "Güncelleme Formu";
        this.button3.Text = "Güncelle";
        int id = YetkiClass.personelid;
        DbSet<TBLPERSONEL> tblpersonel1 = this.db.TBLPERSONEL;
        Expression<Func<TBLPERSONEL, bool>> predicate = (Expression<Func<TBLPERSONEL, bool>>) (hd => hd.ID == id);
        foreach (TBLPERSONEL tblpersonel2 in (IEnumerable<TBLPERSONEL>) tblpersonel1.Where<TBLPERSONEL>(predicate))
        {
          this.AdiTxt.Text = tblpersonel2.ADI;
          this.SoyadTxt.Text = tblpersonel2.SOYADI;
          this.TcTxt.Text = tblpersonel2.TCKIMLIKNO;
          this.SicilTxt.Text = tblpersonel2.SICILNO;
          this.kodTxt.Text = tblpersonel2.KOD;
          try
          {
            int unvanid = int.Parse(tblpersonel2.UNVANID.ToString());
            TBLPERSUNVAN tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<Func<TBLPERSUNVAN, bool>>) (x => x.ID == unvanid));
            if (unvanid != 0)
              tblpersunvan = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<Func<TBLPERSUNVAN, bool>>) (x => x.ID == unvanid));
            this.UnvanCombo.Text = tblpersunvan.UNVAN;
          }
          catch (Exception ex)
          {
            this.UnvanCombo.Text = "";
          }
          try
          {
            int birimid = Convert.ToInt32((object) tblpersonel2.BELDBIRIMIID);
            TBLPERSKURUMGOREV tblperskurumgorev = this.db.TBLPERSKURUMGOREV.FirstOrDefault<TBLPERSKURUMGOREV>((Expression<Func<TBLPERSKURUMGOREV, bool>>) (x => x.ID == birimid));
            int? beldbirimiid = tblpersonel2.BELDBIRIMIID;
            int num = 0;
            if (!(beldbirimiid.GetValueOrDefault() == num & beldbirimiid.HasValue) || tblpersonel2.BELDBIRIMIID.HasValue)
              tblperskurumgorev = this.db.TBLPERSKURUMGOREV.FirstOrDefault<TBLPERSKURUMGOREV>((Expression<Func<TBLPERSKURUMGOREV, bool>>) (x => x.ID == birimid));
            this.GorevUnvanCombo.Text = tblperskurumgorev.KURUMGOREV;
          }
          catch (Exception ex)
          {
            this.GorevUnvanCombo.Text = "";
          }
          try
          {
            int egitim_id = Convert.ToInt32((object) tblpersonel2.EGITIMID);
            this.db.TBLPERSEGITIMDRM.FirstOrDefault<TBLPERSEGITIMDRM>((Expression<Func<TBLPERSEGITIMDRM, bool>>) (x => x.ID == egitim_id));
            int? egitimid = tblpersonel2.EGITIMID;
            int num = 0;
            if (!(egitimid.GetValueOrDefault() == num & egitimid.HasValue) && tblpersonel2.EGITIMID.HasValue)
              this.egitimDurumCombo.Text = this.db.TBLPERSEGITIMDRM.FirstOrDefault<TBLPERSEGITIMDRM>((Expression<Func<TBLPERSEGITIMDRM, bool>>) (x => x.ID == egitim_id)).EGITIMDURUM;
          }
          catch (Exception ex)
          {
            this.egitimDurumCombo.Text = "";
          }
          try
          {
            TBLBELDBIRIMLER tblbeldbirimler = this.db.TBLBELDBIRIMLER.Find(new object[1]
            {
              (object) Convert.ToInt32((object) tblpersonel2.GOREVUNVANID)
            });
            this.GorevUnvanCombo.Text = tblbeldbirimler.BELDBIRIMADI == null ? "" : tblbeldbirimler.BELDBIRIMADI;
          }
          catch (Exception ex)
          {
            this.GorevUnvanCombo.Text = "";
          }
          try
          {
            this.IstidamCombo.SelectedIndex = Convert.ToInt32((object) tblpersonel2.PERSISTIHDAMIID);
          }
          catch (Exception ex)
          {
          }
          try
          {
            ComboBox ehliyetBilgisiCombo = this.EhliyetBilgisiCombo;
            int? ehliyetid = tblpersonel2.EHLIYETID;
            string str = ehliyetid.ToString();
            ehliyetBilgisiCombo.Text = str;
            int ehliyet_id = Convert.ToInt32((object) tblpersonel2.EGITIMID);
            this.db.TBLPERSEHLIYET.FirstOrDefault<TBLPERSEHLIYET>((Expression<Func<TBLPERSEHLIYET, bool>>) (x => x.ID == ehliyet_id));
            ehliyetid = tblpersonel2.EHLIYETID;
            int num = 0;
            if (!(ehliyetid.GetValueOrDefault() == num & ehliyetid.HasValue))
              this.EhliyetBilgisiCombo.Text = this.db.TBLPERSEHLIYET.FirstOrDefault<TBLPERSEHLIYET>((Expression<Func<TBLPERSEHLIYET, bool>>) (x => x.ID == ehliyet_id)).EHLIYET;
          }
          catch (Exception ex)
          {
            this.EhliyetBilgisiCombo.Text = "";
          }
          this.GorevYeriTxt.Text = tblpersonel2.GOREVYERI;
          try
          {
            this.KanGrubuCombo.SelectedIndex = Convert.ToInt32((object) tblpersonel2.KANGRUPID);
          }
          catch (Exception ex)
          {
          }
          this.YetkiIzmaCombo.SelectedIndex = Convert.ToInt32((object) tblpersonel2.YETKILIIMZAID);
          this.ikametAdresiTxt.Text = tblpersonel2.IKMADRES;
          this.Telefon1Txt.Text = tblpersonel2.CEPTELEFON;
          this.Telefon2Txt.Text = tblpersonel2.CEPTELEFON2;
          this.CocukSayisiTxt.Text = tblpersonel2.COCUKTOPLAM.ToString();
          this.SiraNoTxt.Text = tblpersonel2.SIRANO;
          try
          {
            int arac_id = Convert.ToInt32((object) tblpersonel2.ARACID);
            this.zimmetdegerlabel.Text = this.db.TBLARACLAR.FirstOrDefault<TBLARACLAR>((Expression<Func<TBLARACLAR, bool>>) (x => x.ID == arac_id)).PLAKA;
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.EhliyetTarihiDate.Value = Convert.ToDateTime(tblpersonel2.EHLVERTARIH);
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.GirisTarihiDate.Value = Convert.ToDateTime((object) tblpersonel2.ISEGIRISTARIHI);
          }
          catch (Exception ex)
          {
          }
          try
          {
            this.DogumTarihiDate.Value = Convert.ToDateTime((object) tblpersonel2.DOGUMTARIHI);
          }
          catch (Exception ex)
          {
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex?.ToString() + " Hata var");
      }
    }

    private void guncelle()
    {
      try
      {
        TBLPERSONEL tblpersonel = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (x => x.ID == YetkiClass.personelid));
        tblpersonel.ADI = this.AdiTxt.Text;
        tblpersonel.SOYADI = this.SoyadTxt.Text;
        tblpersonel.ADISOYADI = this.AdiTxt.Text + " " + this.SoyadTxt.Text;
        tblpersonel.TCKIMLIKNO = this.TcTxt.Text;
        tblpersonel.SICILNO = this.SicilTxt.Text;
        tblpersonel.KOD = this.kodTxt.Text;
        tblpersonel.UNVANID = new int?(Convert.ToInt32(this.UnvanCombo.SelectedValue));
        tblpersonel.GOREVUNVANID = new int?(Convert.ToInt32(this.GorevUnvanCombo.SelectedValue));
        tblpersonel.EGITIMID = new int?(Convert.ToInt32(this.egitimDurumCombo.SelectedValue));
        tblpersonel.PERSISTIHDAMIID = new int?(Convert.ToInt32(this.IstidamCombo.SelectedIndex));
        tblpersonel.EHLIYETID = new int?(Convert.ToInt32(this.EhliyetBilgisiCombo.SelectedValue));
        tblpersonel.BELDBIRIMIID = new int?(Convert.ToInt32(this.BirimAdiCombo.SelectedValue));
        tblpersonel.BELDMUDURLUKID = new int?(Convert.ToInt32(this.MudurlukCombo.SelectedValue));
        tblpersonel.GOREVYERI = this.GorevYeriTxt.Text;
        tblpersonel.KANGRUPID = new int?(this.KanGrubuCombo.SelectedIndex);
        int num1 = this.YetkiIzmaCombo.Text == "Var" ? 0 : 1;
        tblpersonel.YETKILIIMZAID = new int?(num1);
        tblpersonel.IKMADRES = this.ikametAdresiTxt.Text;
        tblpersonel.ARACID = new int?(1);
        tblpersonel.CEPTELEFON = this.Telefon1Txt.Text;
        tblpersonel.CEPTELEFON2 = this.Telefon2Txt.Text;
        tblpersonel.COCUKTOPLAM = new int?(Convert.ToInt32(this.CocukSayisiTxt.Text));
        tblpersonel.SIRANO = this.SiraNoTxt.Text;
        tblpersonel.EDITDATE = new DateTime?(DateTime.Now);
        tblpersonel.EDITUSER = YetkiClass.kullanici_ad;
        int num2 = this.KayitDurumuCombo.Text == "Aktif" ? 1 : 2;
        tblpersonel.PERSDURUMID = new int?(num2);
        tblpersonel.EDITUSER = YetkiClass.kullanici_ad;
        this.db.SaveChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (!(YetkiClass.secim == "kayit"))
        return;
      this.silmeislemi();
    }

    private void button2_Click(object sender, EventArgs e) => this.ResimPic.Image = (Image) null;

    private void button5_Click(object sender, EventArgs e) => this.Close();

    private void button7_Click(object sender, EventArgs e)
    {
      int num = (int) new BeldBirimForum().ShowDialog();
    }

    private void silmeislemi()
    {
      this.yet.yetkiislemleri("PERSONEL");
      this.kodTxt.Text = this.ser.PersonelP();
      this.UnvanCombo.DataSource = (object) this.db.TBLPERSUNVAN.ToList<TBLPERSUNVAN>();
      this.UnvanCombo.ValueMember = "ID";
      this.UnvanCombo.DisplayMember = "UNVAN";
      this.egitimDurumCombo.DataSource = (object) this.db.TBLPERSEGITIMDRM.ToList<TBLPERSEGITIMDRM>();
      this.egitimDurumCombo.ValueMember = "ID";
      this.egitimDurumCombo.DisplayMember = "EGITIMDURUM";
      this.BirimAdiCombo.DataSource = (object) this.db.TBLBELDBIRIMLER.ToList<TBLBELDBIRIMLER>();
      this.BirimAdiCombo.ValueMember = "ID";
      this.BirimAdiCombo.DisplayMember = "BELDBIRIMADI";
      this.GorevUnvanCombo.DataSource = (object) this.db.TBLPERSKURUMGOREV.ToList<TBLPERSKURUMGOREV>();
      this.GorevUnvanCombo.ValueMember = "ID";
      this.GorevUnvanCombo.DisplayMember = "KURUMGOREV";
      this.MudurlukCombo.DataSource = (object) this.db.TBLBELDMUDURLUK.ToList<TBLBELDMUDURLUK>();
      this.MudurlukCombo.ValueMember = "ID";
      this.MudurlukCombo.DisplayMember = "BELDMUDURLUK";
      this.EhliyetBilgisiCombo.DataSource = (object) this.db.TBLPERSEHLIYET.ToList<TBLPERSEHLIYET>();
      this.EhliyetBilgisiCombo.ValueMember = "ID";
      this.EhliyetBilgisiCombo.DisplayMember = "EHLIYET";
      switch (YetkiClass.secim)
      {
        case "kayit":
          this.kayitload();
          break;
        case "guncelle":
          this.guncelleload();
          break;
      }
      this.AdiTxt.Text = "";
      this.SoyadTxt.Text = "";
      this.UnvanCombo.Text = "";
      this.egitimDurumCombo.Text = "";
      this.BirimAdiCombo.Text = "";
      this.GorevUnvanCombo.Text = "";
      this.MudurlukCombo.Text = "";
      this.EhliyetBilgisiCombo.Text = "";
      this.EhliyetTarihiDate.Text = "";
      this.TcTxt.Text = "";
      this.SicilTxt.Text = "";
      this.GorevYeriTxt.Text = "";
      this.ikametAdresiTxt.Text = "";
      this.Telefon1Txt.Text = "";
      this.Telefon2Txt.Text = "";
      this.GirisTarihiDate.Value = DateTime.Now;
      this.EhliyetTarihiDate.Value = DateTime.Now;
      this.DogumTarihiDate.Value = DateTime.Now;
      this.CocukSayisiTxt.Text = "";
      this.ParafTxt.Text = "";
      this.SiraNoTxt.Text = "";
      this.ResimPic.Image = (Image) null;
    }

    private void TcTxt_TextChanged(object sender, EventArgs e)
    {
      if (this.db.TBLPERSONEL.Where<TBLPERSONEL>((Expression<Func<TBLPERSONEL, bool>>) (musteri => musteri.TCKIMLIKNO == this.TcTxt.Text)).Select(musteri => new
      {
        ID = musteri.ID,
        ADISOYADI = musteri.ADISOYADI
      }).Count() <= 0 || !(YetkiClass.secim == "kayıt"))
        return;
      int num = (int) MessageBox.Show("Bu TC Numarası kayıtlıdır");
    }

    private void AdiTxt_TextChanged(object sender, EventArgs e)
    {
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
      this.girisLabel = new Label();
      this.button1 = new Button();
      this.button4 = new Button();
      this.button3 = new Button();
      this.button2 = new Button();
      this.panel2 = new Panel();
      this.panel4 = new Panel();
      this.panel3 = new Panel();
      this.label2 = new Label();
      this.kodTxt = new TextBox();
      this.TcTxt = new TextBox();
      this.label3 = new Label();
      this.AdiTxt = new TextBox();
      this.label4 = new Label();
      this.SicilTxt = new TextBox();
      this.label5 = new Label();
      this.SoyadTxt = new TextBox();
      this.label6 = new Label();
      this.label7 = new Label();
      this.egitimDurumCombo = new ComboBox();
      this.UnvanCombo = new ComboBox();
      this.label8 = new Label();
      this.IstidamCombo = new ComboBox();
      this.label9 = new Label();
      this.GorevYeriTxt = new TextBox();
      this.label10 = new Label();
      this.GorevUnvanCombo = new ComboBox();
      this.label11 = new Label();
      this.BirimAdiCombo = new ComboBox();
      this.label12 = new Label();
      this.MudurlukCombo = new ComboBox();
      this.label13 = new Label();
      this.label15 = new Label();
      this.YetkiIzmaCombo = new ComboBox();
      this.label16 = new Label();
      this.CocukSayisiTxt = new TextBox();
      this.label17 = new Label();
      this.KanGrubuCombo = new ComboBox();
      this.label18 = new Label();
      this.label19 = new Label();
      this.label20 = new Label();
      this.label21 = new Label();
      this.label23 = new Label();
      this.Telefon2Txt = new TextBox();
      this.label24 = new Label();
      this.Telefon1Txt = new TextBox();
      this.label25 = new Label();
      this.KayitDurumuCombo = new ComboBox();
      this.label14 = new Label();
      this.GirisTarihiDate = new DateTimePicker();
      this.EhliyetBilgisiCombo = new ComboBox();
      this.EhliyetTarihiDate = new DateTimePicker();
      this.DogumTarihiDate = new DateTimePicker();
      this.ParafTxt = new TextBox();
      this.button6 = new Button();
      this.ikametAdresiTxt = new TextBox();
      this.label22 = new Label();
      this.button5 = new Button();
      this.SiraNoTxt = new TextBox();
      this.label26 = new Label();
      this.zimmetlabel = new Label();
      this.zimmetdegerlabel = new Label();
      this.ResimPic = new PictureBox();
      this.button7 = new Button();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.ResimPic).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1210, 47);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(474, 9);
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
      this.button1.Location = new Point(1172, 6);
      this.button1.Name = "button1";
      this.button1.Size = new Size(31, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button4.BackColor = Color.SteelBlue;
      this.button4.FlatAppearance.BorderSize = 2;
      this.button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.White;
      this.button4.Location = new Point(485, 598);
      this.button4.Name = "button4";
      this.button4.Size = new Size(170, 58);
      this.button4.TabIndex = 37;
      this.button4.Text = "Temizle";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.BackColor = Color.SteelBlue;
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(309, 598);
      this.button3.Name = "button3";
      this.button3.Size = new Size(170, 58);
      this.button3.TabIndex = 36;
      this.button3.Text = "Kaydet";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button2.BackColor = Color.SteelBlue;
      this.button2.FlatAppearance.BorderSize = 2;
      this.button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.ForeColor = Color.White;
      this.button2.Location = new Point(1068, 280);
      this.button2.Name = "button2";
      this.button2.Size = new Size(114, 34);
      this.button2.TabIndex = 35;
      this.button2.Text = "Resim Sil";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1204, 47);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 629);
      this.panel2.TabIndex = 40;
      this.panel4.BackColor = Color.SteelBlue;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(0, 670);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(1204, 6);
      this.panel4.TabIndex = 41;
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 623);
      this.panel3.TabIndex = 42;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.Location = new Point(177, 81);
      this.label2.Name = "label2";
      this.label2.Size = new Size(43, 21);
      this.label2.TabIndex = 43;
      this.label2.Text = "Kod";
      this.kodTxt.BackColor = Color.Ivory;
      this.kodTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.kodTxt.ImeMode = ImeMode.NoControl;
      this.kodTxt.Location = new Point(227, 81);
      this.kodTxt.Multiline = true;
      this.kodTxt.Name = "kodTxt";
      this.kodTxt.Size = new Size(133, 27);
      this.kodTxt.TabIndex = 44;
      this.TcTxt.BackColor = Color.Ivory;
      this.TcTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TcTxt.Location = new Point(227, 115);
      this.TcTxt.Multiline = true;
      this.TcTxt.Name = "TcTxt";
      this.TcTxt.Size = new Size(133, 27);
      this.TcTxt.TabIndex = 46;
      this.TcTxt.TextChanged += new EventHandler(this.TcTxt_TextChanged);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.Location = new Point(97, 114);
      this.label3.Name = "label3";
      this.label3.Size = new Size(124, 21);
      this.label3.TabIndex = 45;
      this.label3.Text = "T.C.Kimlik No";
      this.AdiTxt.BackColor = Color.Ivory;
      this.AdiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AdiTxt.Location = new Point(227, 148);
      this.AdiTxt.Multiline = true;
      this.AdiTxt.Name = "AdiTxt";
      this.AdiTxt.Size = new Size(322, 27);
      this.AdiTxt.TabIndex = 48;
      this.AdiTxt.TextChanged += new EventHandler(this.AdiTxt_TextChanged);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(182, 148);
      this.label4.Name = "label4";
      this.label4.Size = new Size(38, 21);
      this.label4.TabIndex = 47;
      this.label4.Text = "Adı";
      this.SicilTxt.BackColor = Color.Ivory;
      this.SicilTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SicilTxt.ImeMode = ImeMode.NoControl;
      this.SicilTxt.Location = new Point(443, 115);
      this.SicilTxt.Multiline = true;
      this.SicilTxt.Name = "SicilTxt";
      this.SicilTxt.Size = new Size(106, 27);
      this.SicilTxt.TabIndex = 50;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label5.Location = new Point(367, 117);
      this.label5.Name = "label5";
      this.label5.Size = new Size(72, 21);
      this.label5.TabIndex = 49;
      this.label5.Text = "Sicil No";
      this.SoyadTxt.BackColor = Color.Ivory;
      this.SoyadTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SoyadTxt.Location = new Point(227, 181);
      this.SoyadTxt.Multiline = true;
      this.SoyadTxt.Name = "SoyadTxt";
      this.SoyadTxt.Size = new Size(322, 27);
      this.SoyadTxt.TabIndex = 52;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(155, 181);
      this.label6.Name = "label6";
      this.label6.Size = new Size(65, 21);
      this.label6.TabIndex = 51;
      this.label6.Text = "Soyadı";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label7.Location = new Point(88, 214);
      this.label7.Name = "label7";
      this.label7.Size = new Size(133, 21);
      this.label7.TabIndex = 53;
      this.label7.Text = "Eğitim Durumu";
      this.egitimDurumCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.egitimDurumCombo.FormattingEnabled = true;
      this.egitimDurumCombo.Location = new Point(227, 214);
      this.egitimDurumCombo.Name = "egitimDurumCombo";
      this.egitimDurumCombo.Size = new Size(322, 32);
      this.egitimDurumCombo.TabIndex = 55;
      this.UnvanCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.UnvanCombo.FormattingEnabled = true;
      this.UnvanCombo.Location = new Point(227, 247);
      this.UnvanCombo.Name = "UnvanCombo";
      this.UnvanCombo.Size = new Size(322, 32);
      this.UnvanCombo.TabIndex = 57;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label8.Location = new Point(160, 247);
      this.label8.Name = "label8";
      this.label8.Size = new Size(61, 21);
      this.label8.TabIndex = 56;
      this.label8.Text = "Unvan";
      this.IstidamCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.IstidamCombo.FormattingEnabled = true;
      this.IstidamCombo.Items.AddRange(new object[6]
      {
        (object) "Memur",
        (object) "İşçi",
        (object) "Sözleşmeli",
        (object) "Daimi İşçi",
        (object) "Diğer",
        (object) "İşkur"
      });
      this.IstidamCombo.Location = new Point(227, 280);
      this.IstidamCombo.Name = "IstidamCombo";
      this.IstidamCombo.Size = new Size(322, 32);
      this.IstidamCombo.TabIndex = 59;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label9.Location = new Point(134, 280);
      this.label9.Name = "label9";
      this.label9.Size = new Size(86, 21);
      this.label9.TabIndex = 58;
      this.label9.Text = "İstihdamı";
      this.GorevYeriTxt.BackColor = Color.Ivory;
      this.GorevYeriTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GorevYeriTxt.Location = new Point(227, 313);
      this.GorevYeriTxt.Multiline = true;
      this.GorevYeriTxt.Name = "GorevYeriTxt";
      this.GorevYeriTxt.Size = new Size(322, 27);
      this.GorevYeriTxt.TabIndex = 61;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label10.Location = new Point(123, 313);
      this.label10.Name = "label10";
      this.label10.Size = new Size(97, 21);
      this.label10.TabIndex = 60;
      this.label10.Text = "Görev Yeri";
      this.GorevUnvanCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.GorevUnvanCombo.FormattingEnabled = true;
      this.GorevUnvanCombo.Location = new Point(227, 346);
      this.GorevUnvanCombo.Name = "GorevUnvanCombo";
      this.GorevUnvanCombo.Size = new Size(322, 32);
      this.GorevUnvanCombo.TabIndex = 63;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label11.Location = new Point(101, 346);
      this.label11.Name = "label11";
      this.label11.Size = new Size(120, 21);
      this.label11.TabIndex = 62;
      this.label11.Text = "Görev Unvanı";
      this.BirimAdiCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.BirimAdiCombo.FormattingEnabled = true;
      this.BirimAdiCombo.Location = new Point(227, 379);
      this.BirimAdiCombo.Name = "BirimAdiCombo";
      this.BirimAdiCombo.Size = new Size(322, 32);
      this.BirimAdiCombo.TabIndex = 65;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label12.Location = new Point(135, 379);
      this.label12.Name = "label12";
      this.label12.Size = new Size(86, 21);
      this.label12.TabIndex = 64;
      this.label12.Text = "Birim Adı";
      this.MudurlukCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.MudurlukCombo.FormattingEnabled = true;
      this.MudurlukCombo.Location = new Point(227, 412);
      this.MudurlukCombo.Name = "MudurlukCombo";
      this.MudurlukCombo.Size = new Size(322, 32);
      this.MudurlukCombo.TabIndex = 67;
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label13.Location = new Point(122, 412);
      this.label13.Name = "label13";
      this.label13.Size = new Size(99, 21);
      this.label13.TabIndex = 66;
      this.label13.Text = "Müdürlüğü";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label15.Location = new Point(620, 379);
      this.label15.Name = "label15";
      this.label15.Size = new Size(114, 21);
      this.label15.TabIndex = 88;
      this.label15.Text = "Paraf Tanımı";
      this.YetkiIzmaCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.YetkiIzmaCombo.FormattingEnabled = true;
      this.YetkiIzmaCombo.Items.AddRange(new object[2]
      {
        (object) "Var",
        (object) "Yok"
      });
      this.YetkiIzmaCombo.Location = new Point(745, 343);
      this.YetkiIzmaCombo.Name = "YetkiIzmaCombo";
      this.YetkiIzmaCombo.Size = new Size(152, 32);
      this.YetkiIzmaCombo.TabIndex = 87;
      this.YetkiIzmaCombo.SelectedIndexChanged += new EventHandler(this.YetkiIzmaCombo_SelectedIndexChanged);
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label16.Location = new Point(623, 346);
      this.label16.Name = "label16";
      this.label16.Size = new Size(111, 21);
      this.label16.TabIndex = 86;
      this.label16.Text = "İmza Yetkisi";
      this.CocukSayisiTxt.BackColor = Color.Ivory;
      this.CocukSayisiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CocukSayisiTxt.Location = new Point(745, 310);
      this.CocukSayisiTxt.Multiline = true;
      this.CocukSayisiTxt.Name = "CocukSayisiTxt";
      this.CocukSayisiTxt.Size = new Size(152, 27);
      this.CocukSayisiTxt.TabIndex = 85;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label17.Location = new Point(621, 313);
      this.label17.Name = "label17";
      this.label17.Size = new Size(113, 21);
      this.label17.TabIndex = 84;
      this.label17.Text = "Çocuk Sayısı";
      this.KanGrubuCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.KanGrubuCombo.FormattingEnabled = true;
      this.KanGrubuCombo.Items.AddRange(new object[8]
      {
        (object) "A Rh+",
        (object) "B Rh+",
        (object) "O Rh+",
        (object) "AB Rh+",
        (object) "A Rh-",
        (object) "B Rh-",
        (object) "O Rh-",
        (object) "AB Rh-"
      });
      this.KanGrubuCombo.Location = new Point(745, 277);
      this.KanGrubuCombo.Name = "KanGrubuCombo";
      this.KanGrubuCombo.Size = new Size(152, 32);
      this.KanGrubuCombo.TabIndex = 83;
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label18.Location = new Point(638, 280);
      this.label18.Name = "label18";
      this.label18.Size = new Size(96, 21);
      this.label18.TabIndex = 82;
      this.label18.Text = "Kan Grubu";
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label19.Location = new Point(610, 246);
      this.label19.Name = "label19";
      this.label19.Size = new Size(124, 21);
      this.label19.TabIndex = 80;
      this.label19.Text = "Doğum Tarihi";
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label20.Location = new Point(617, 213);
      this.label20.Name = "label20";
      this.label20.Size = new Size(117, 21);
      this.label20.TabIndex = 78;
      this.label20.Text = "Ehliyet Tarihi";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label21.Location = new Point(615, 181);
      this.label21.Name = "label21";
      this.label21.Size = new Size(118, 21);
      this.label21.TabIndex = 76;
      this.label21.Text = "Ehliyet Bilgisi";
      this.label23.AutoSize = true;
      this.label23.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label23.Location = new Point(605, 148);
      this.label23.Name = "label23";
      this.label23.Size = new Size(128, 21);
      this.label23.TabIndex = 72;
      this.label23.Text = "İşe Giriş Tarihi";
      this.Telefon2Txt.BackColor = Color.Ivory;
      this.Telefon2Txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Telefon2Txt.Location = new Point(745, 112);
      this.Telefon2Txt.Multiline = true;
      this.Telefon2Txt.Name = "Telefon2Txt";
      this.Telefon2Txt.Size = new Size(152, 27);
      this.Telefon2Txt.TabIndex = 71;
      this.label24.AutoSize = true;
      this.label24.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label24.Location = new Point(634, 114);
      this.label24.Name = "label24";
      this.label24.Size = new Size(100, 21);
      this.label24.TabIndex = 70;
      this.label24.Text = "İrtibat No2";
      this.Telefon1Txt.BackColor = Color.Ivory;
      this.Telefon1Txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Telefon1Txt.ImeMode = ImeMode.NoControl;
      this.Telefon1Txt.Location = new Point(745, 78);
      this.Telefon1Txt.Multiline = true;
      this.Telefon1Txt.Name = "Telefon1Txt";
      this.Telefon1Txt.Size = new Size(152, 27);
      this.Telefon1Txt.TabIndex = 69;
      this.label25.AutoSize = true;
      this.label25.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label25.Location = new Point(634, 81);
      this.label25.Name = "label25";
      this.label25.Size = new Size(100, 21);
      this.label25.TabIndex = 68;
      this.label25.Text = "İrtibat No1";
      this.KayitDurumuCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.KayitDurumuCombo.FormattingEnabled = true;
      this.KayitDurumuCombo.Items.AddRange(new object[2]
      {
        (object) "Aktif",
        (object) "Pasif"
      });
      this.KayitDurumuCombo.Location = new Point(745, 409);
      this.KayitDurumuCombo.Name = "KayitDurumuCombo";
      this.KayitDurumuCombo.Size = new Size(152, 32);
      this.KayitDurumuCombo.TabIndex = 91;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label14.Location = new Point(613, 412);
      this.label14.Name = "label14";
      this.label14.Size = new Size(122, 21);
      this.label14.TabIndex = 90;
      this.label14.Text = "Kayıt Durumu";
      this.GirisTarihiDate.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.GirisTarihiDate.Format = DateTimePickerFormat.Short;
      this.GirisTarihiDate.Location = new Point(745, 145);
      this.GirisTarihiDate.Name = "GirisTarihiDate";
      this.GirisTarihiDate.Size = new Size(152, 26);
      this.GirisTarihiDate.TabIndex = 92;
      this.GirisTarihiDate.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.EhliyetBilgisiCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.EhliyetBilgisiCombo.FormattingEnabled = true;
      this.EhliyetBilgisiCombo.Location = new Point(745, 178);
      this.EhliyetBilgisiCombo.Name = "EhliyetBilgisiCombo";
      this.EhliyetBilgisiCombo.Size = new Size(152, 32);
      this.EhliyetBilgisiCombo.TabIndex = 93;
      this.EhliyetTarihiDate.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.EhliyetTarihiDate.Format = DateTimePickerFormat.Short;
      this.EhliyetTarihiDate.Location = new Point(745, 211);
      this.EhliyetTarihiDate.Name = "EhliyetTarihiDate";
      this.EhliyetTarihiDate.Size = new Size(152, 26);
      this.EhliyetTarihiDate.TabIndex = 94;
      this.EhliyetTarihiDate.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.DogumTarihiDate.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.DogumTarihiDate.Format = DateTimePickerFormat.Short;
      this.DogumTarihiDate.Location = new Point(745, 244);
      this.DogumTarihiDate.Name = "DogumTarihiDate";
      this.DogumTarihiDate.Size = new Size(152, 26);
      this.DogumTarihiDate.TabIndex = 95;
      this.DogumTarihiDate.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.ParafTxt.BackColor = Color.Ivory;
      this.ParafTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ParafTxt.Location = new Point(745, 376);
      this.ParafTxt.Multiline = true;
      this.ParafTxt.Name = "ParafTxt";
      this.ParafTxt.Size = new Size(152, 27);
      this.ParafTxt.TabIndex = 96;
      this.button6.BackColor = Color.SteelBlue;
      this.button6.FlatAppearance.BorderSize = 2;
      this.button6.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.ForeColor = Color.White;
      this.button6.Location = new Point(945, 280);
      this.button6.Name = "button6";
      this.button6.Size = new Size(114, 34);
      this.button6.TabIndex = 97;
      this.button6.Text = "Resim Ekle";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.ikametAdresiTxt.BackColor = Color.Ivory;
      this.ikametAdresiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ikametAdresiTxt.Location = new Point(227, 442);
      this.ikametAdresiTxt.Multiline = true;
      this.ikametAdresiTxt.Name = "ikametAdresiTxt";
      this.ikametAdresiTxt.Size = new Size(670, 71);
      this.ikametAdresiTxt.TabIndex = 99;
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label22.Location = new Point(96, 464);
      this.label22.Name = "label22";
      this.label22.Size = new Size(125, 21);
      this.label22.TabIndex = 98;
      this.label22.Text = "İkamet Adresi";
      this.button5.BackColor = Color.SteelBlue;
      this.button5.FlatAppearance.BorderSize = 2;
      this.button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button5.ForeColor = Color.White;
      this.button5.Location = new Point(666, 598);
      this.button5.Name = "button5";
      this.button5.Size = new Size(170, 58);
      this.button5.TabIndex = 38;
      this.button5.Text = "Kapat";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.SiraNoTxt.BackColor = Color.Ivory;
      this.SiraNoTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SiraNoTxt.ImeMode = ImeMode.NoControl;
      this.SiraNoTxt.Location = new Point(1050, 340);
      this.SiraNoTxt.Multiline = true;
      this.SiraNoTxt.Name = "SiraNoTxt";
      this.SiraNoTxt.Size = new Size(124, 27);
      this.SiraNoTxt.TabIndex = 101;
      this.label26.AutoSize = true;
      this.label26.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label26.Location = new Point(967, 343);
      this.label26.Name = "label26";
      this.label26.Size = new Size(70, 21);
      this.label26.TabIndex = 100;
      this.label26.Text = "Sıra No";
      this.zimmetlabel.AutoSize = true;
      this.zimmetlabel.Font = new Font("Lucida Sans Unicode", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.zimmetlabel.Location = new Point(475, 533);
      this.zimmetlabel.Name = "zimmetlabel";
      this.zimmetlabel.Size = new Size(163, 23);
      this.zimmetlabel.TabIndex = 102;
      this.zimmetlabel.Text = "Zimmetli Aracı :";
      this.zimmetdegerlabel.AutoSize = true;
      this.zimmetdegerlabel.Font = new Font("Lucida Sans Unicode", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.zimmetdegerlabel.ForeColor = Color.Red;
      this.zimmetdegerlabel.Location = new Point(644, 533);
      this.zimmetdegerlabel.Name = "zimmetdegerlabel";
      this.zimmetdegerlabel.Size = new Size(40, 23);
      this.zimmetdegerlabel.TabIndex = 103;
      this.zimmetdegerlabel.Text = "___";
      this.ResimPic.Image = (Image) Resources.buy64;
      this.ResimPic.Location = new Point(971, 88);
      this.ResimPic.Name = "ResimPic";
      this.ResimPic.Size = new Size(182, 186);
      this.ResimPic.SizeMode = PictureBoxSizeMode.StretchImage;
      this.ResimPic.TabIndex = 39;
      this.ResimPic.TabStop = false;
      this.button7.Location = new Point(555, 385);
      this.button7.Name = "button7";
      this.button7.Size = new Size(35, 23);
      this.button7.TabIndex = 104;
      this.button7.Text = "button7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ControlLight;
      this.ClientSize = new Size(1210, 676);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.zimmetdegerlabel);
      this.Controls.Add((Control) this.zimmetlabel);
      this.Controls.Add((Control) this.SiraNoTxt);
      this.Controls.Add((Control) this.label26);
      this.Controls.Add((Control) this.ikametAdresiTxt);
      this.Controls.Add((Control) this.label22);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.ParafTxt);
      this.Controls.Add((Control) this.DogumTarihiDate);
      this.Controls.Add((Control) this.EhliyetTarihiDate);
      this.Controls.Add((Control) this.EhliyetBilgisiCombo);
      this.Controls.Add((Control) this.GirisTarihiDate);
      this.Controls.Add((Control) this.KayitDurumuCombo);
      this.Controls.Add((Control) this.label14);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.YetkiIzmaCombo);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.CocukSayisiTxt);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.KanGrubuCombo);
      this.Controls.Add((Control) this.label18);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.label20);
      this.Controls.Add((Control) this.label21);
      this.Controls.Add((Control) this.label23);
      this.Controls.Add((Control) this.Telefon2Txt);
      this.Controls.Add((Control) this.label24);
      this.Controls.Add((Control) this.Telefon1Txt);
      this.Controls.Add((Control) this.label25);
      this.Controls.Add((Control) this.MudurlukCombo);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.BirimAdiCombo);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.GorevUnvanCombo);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.GorevYeriTxt);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.IstidamCombo);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.UnvanCombo);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.egitimDurumCombo);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.SoyadTxt);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.SicilTxt);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.AdiTxt);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.TcTxt);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.kodTxt);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.ResimPic);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (fEkle);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (fEkle);
      this.Load += new EventHandler(this.fEkle_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.ResimPic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
