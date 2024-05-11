// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.PersonelIzinFormu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class PersonelIzinFormu : Form
  {
    private KullaniciSonId kul = new KullaniciSonId();
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private ComboBox SubeMuduruCombo;
    private Label label13;
    private Button button1;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private TextBox İzinYillariTxt;
    private Label label6;
    private Label label3;
    private TextBox AraTxt;
    private Label label2;
    private Panel panel3;
    private Panel panel4;
    private Panel panel2;
    private Label girisLabel;
    private Label label4;
    private Button button4;
    private Button button3;
    private Panel panel1;
    private ComboBox İzinTuruCombo;
    private Label label1;
    private ComboBox daireBskCombo;
    private Label label5;
    private ComboBox insKayDBSKCombo;
    private Label label14;
    private ComboBox genelSkrYardCombo;
    private Label label15;
    private DateTimePicker BaslangicTarihiDate;
    private DateTimePicker BitisTarihiDatetime;
    private DateTimePicker OnayTarihidateTimePicker;
    private DateTimePicker GoreveBasladateTimePicker;
    private ComboBox AdiCombo;
    private TextBox GunSayisiTxt;
    private TextBox izindekiAdresiTxt;
    private ComboBox izinDurumCombo;
    private Label label16;
    private TextBox mudurYrnBakanTxt;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn IDX;
    private DataGridViewTextBoxColumn ADISOYADI;
    private DateTimePicker bas_saatdate;
    private Label label17;
    private Button button2;
    private Button button6;

    public PersonelIzinFormu() => this.InitializeComponent();

    [DllImport("user32.DLL")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL")]
    private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void button4_Click(object sender, EventArgs e)
    {
      int num = (int) new PrsIzinHakEklemFormu().ShowDialog();
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      PersonelIzinFormu.ReleaseCapture();
      PersonelIzinFormu.SendMessage(this.Handle, 274, 61458, 0);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int num1 = (int) MessageBox.Show("kayıt:" + YetkiClass.EkleYetki.ToString() + " menu yetki " + YetkiClass.menuyetki + " secim:" + YetkiClass.secim);
      if (YetkiClass.EkleYetki == 1 && YetkiClass.menuyetki == "Hayır" && YetkiClass.secim == "kayıt")
        this.kayitfonk();
      else if (YetkiClass.secim == "guncelle" && YetkiClass.GuncelleYetki == 1 && YetkiClass.menuyetki == "Hayır")
      {
        this.guncelle();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Burada giriş yetkiniz bulunmaktadır.");
      }
    }

    private void kayitfonk()
    {
      try
      {
        TBLPERSONELIZIN entity = new TBLPERSONELIZIN();
        entity.PERSID = new int?(Convert.ToInt32(this.AdiCombo.SelectedValue));
        YetkiClass.personelid = Convert.ToInt32(this.AdiCombo.SelectedValue);
        entity.IZINTURU = this.İzinTuruCombo.Text;
        entity.IZINYILLARI = this.İzinYillariTxt.Text;
        entity.BASLANGICTARIHI = new DateTime?(this.BaslangicTarihiDate.Value);
        entity.BITISTARIHI = new DateTime?(this.BitisTarihiDatetime.Value);
        entity.IZINGUNSAY = this.GunSayisiTxt.Text;
        entity.IZINDEBULADRES = this.izindekiAdresiTxt.Text;
        entity.ONAYTARIH = new DateTime?(this.OnayTarihidateTimePicker.Value);
        entity.GOREVEBASTARIH = new DateTime?(this.GoreveBasladateTimePicker.Value);
        entity.IZINDURUM = this.izinDurumCombo.Text;
        entity.BASLANGICSAATI = new DateTime?(Convert.ToDateTime(this.bas_saatdate.Text));
        try
        {
          entity.SBMUDURID = new int?(Convert.ToInt32(this.SubeMuduruCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.DAIREBSKID = new int?(Convert.ToInt32(this.daireBskCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.GENELSEKYRDID = new int?(Convert.ToInt32(this.genelSkrYardCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          entity.INSANDAIREBSKID = new int?(Convert.ToInt32(this.insKayDBSKCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        entity.MUDURYERINE = new int?(Convert.ToInt32(this.mudurYrnBakanTxt.Text));
        string[] source1 = this.İzinYillariTxt.Text.Split(',');
        int per_id = Convert.ToInt32(YetkiClass.personelid);
        int num1 = 0;
        int num2 = 0;
        int num3 = int.Parse(this.GunSayisiTxt.Text);
        int degeryil = 0;
        string str1 = "";
        foreach (string str2 in source1)
        {
          degeryil = Convert.ToInt32(str2);
          IQueryable<TBLPERSIZINDURUM> source2 = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) per_id));
          Expression<Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.IZINYILI == (int?) degeryil);
          foreach (TBLPERSIZINDURUM tblpersizindurum in (IEnumerable<TBLPERSIZINDURUM>) source2.Where<TBLPERSIZINDURUM>(predicate))
          {
            if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) > 0)
            {
              try
              {
                num1 += Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN);
              }
              catch (Exception ex)
              {
              }
              try
              {
                num2 += Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN);
              }
              catch (Exception ex)
              {
              }
            }
            else
            {
              int num4 = (int) MessageBox.Show(degeryil.ToString() + " bu yıla ait izin hakkı yoktur");
              break;
            }
          }
          str1 = this.kul.sayitoyazi(Convert.ToInt32(this.GunSayisiTxt.Text));
          if (((IEnumerable<string>) source1).Count<string>() > 1)
            str1 = this.İzinYillariTxt.Text + " Yıllarından " + this.GunSayisiTxt.Text + str1;
          else if (((IEnumerable<string>) source1).Count<string>() == 1)
            str1 = this.İzinYillariTxt.Text + " Yılından " + this.GunSayisiTxt.Text + str1;
        }
        entity.IZINSURESI = str1;
        if (num1 >= num3)
        {
          foreach (string str3 in source1)
          {
            try
            {
              int deger = Convert.ToInt32(str3);
              TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (ys => ys.PERSONELID == (int?) per_id && ys.IZINYILI == (int?) deger));
              if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) > num3)
                tblpersizindurum.KULLANILANIZIN = new int?(Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) + num3);
              else if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) == num1)
              {
                tblpersizindurum.KULLANILANIZIN = new int?(num3);
              }
              else
              {
                tblpersizindurum.KULLANILANIZIN = tblpersizindurum.IZINHAKKI;
                num3 -= Convert.ToInt32((object) tblpersizindurum.IZINHAKKI);
              }
              tblpersizindurum.PERSONELID = new int?(YetkiClass.personelid);
            }
            catch (Exception ex)
            {
            }
            this.db.SaveChanges();
          }
          this.db.TBLPERSONELIZIN.Add(entity);
          this.db.SaveChanges();
          int num5 = (int) MessageBox.Show("Başarlı bir sikilde kaydedildi.");
        }
        else
        {
          int num6 = (int) MessageBox.Show("İzin gün sayısı toplam izin sayısını geçemez.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

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

    private void PersonelIzinFormu_Load(object sender, EventArgs e)
    {
      this.dataGridView1.Visible = false;
      this.AdiCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.AdiCombo.ValueMember = "ID";
      this.AdiCombo.DisplayMember = "ADISOYADI";
      this.SubeMuduruCombo.ValueMember = "ID";
      this.SubeMuduruCombo.DisplayMember = "ADISOYADI";
      this.SubeMuduruCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.insKayDBSKCombo.ValueMember = "ID";
      this.insKayDBSKCombo.DisplayMember = "ADISOYADI";
      this.insKayDBSKCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.daireBskCombo.ValueMember = "ID";
      this.daireBskCombo.DisplayMember = "ADISOYADI";
      this.daireBskCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.genelSkrYardCombo.ValueMember = "ID";
      this.genelSkrYardCombo.DisplayMember = "ADISOYADI";
      this.genelSkrYardCombo.DataSource = (object) this.db.TBLPERSONEL.ToList<TBLPERSONEL>();
      this.silfonk();
      this.yet.MenuYetkilendirme("Personel İzin Listesi");
      switch (YetkiClass.secim)
      {
        case "kayit":
          this.silfonk();
          break;
        case "guncelle":
          this.guncelleload();
          break;
      }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      YetkiClass.personelid = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value);
      this.AdiCombo.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
      this.AdiCombo.ValueMember = "IDX";
      this.AdiCombo.DisplayMember = "ADISOYADI";
      this.dataGridView1.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void silfonk()
    {
      this.AdiCombo.Text = "";
      this.SubeMuduruCombo.Text = "";
      this.insKayDBSKCombo.Text = "";
      this.daireBskCombo.Text = "";
      this.genelSkrYardCombo.Text = "";
    }

    private void guncelleload()
    {
      DbSet<TBLPERSONELIZIN> tblpersonelizin1 = this.db.TBLPERSONELIZIN;
      Expression<Func<TBLPERSONELIZIN, bool>> predicate = (Expression<Func<TBLPERSONELIZIN, bool>>) (hd => hd.ID == YetkiClass.secim_id);
      foreach (TBLPERSONELIZIN tblpersonelizin2 in (IEnumerable<TBLPERSONELIZIN>) tblpersonelizin1.Where<TBLPERSONELIZIN>(predicate))
      {
        this.AdiCombo.SelectedValue = (object) tblpersonelizin2.PERSID;
        this.İzinTuruCombo.Text = tblpersonelizin2.IZINTURU;
        this.İzinYillariTxt.Text = tblpersonelizin2.IZINYILLARI;
        this.GunSayisiTxt.Text = tblpersonelizin2.IZINGUNSAY.ToString();
        this.BaslangicTarihiDate.Value = Convert.ToDateTime((object) tblpersonelizin2.BASLANGICTARIHI);
        this.BitisTarihiDatetime.Value = Convert.ToDateTime((object) tblpersonelizin2.BITISTARIHI);
        this.izindekiAdresiTxt.Text = tblpersonelizin2.IZINDEBULADRES;
        this.OnayTarihidateTimePicker.Value = Convert.ToDateTime((object) tblpersonelizin2.ONAYTARIH);
        this.izinDurumCombo.Text = tblpersonelizin2.IZINDURUM;
        this.SubeMuduruCombo.SelectedValue = (object) Convert.ToInt32((object) tblpersonelizin2.SBMUDURID);
        this.daireBskCombo.SelectedValue = (object) Convert.ToInt32((object) tblpersonelizin2.DAIREBSKID);
        this.insKayDBSKCombo.SelectedValue = (object) Convert.ToInt32((object) tblpersonelizin2.INSANDAIREBSKID);
        this.genelSkrYardCombo.SelectedValue = (object) Convert.ToInt32((object) tblpersonelizin2.GENELSEKYRDID);
        this.mudurYrnBakanTxt.Text = Convert.ToInt32((object) tblpersonelizin2.MUDURYERINE).ToString();
      }
      this.girisLabel.Text = "Güncelleme Formu";
      this.button3.Text = "Güncelle";
      this.İzinYillariTxt.Enabled = false;
    }

    private void guncelle()
    {
      try
      {
        this.gunsilfonk();
        TBLPERSONELIZIN tblpersonelizin = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
        tblpersonelizin.PERSID = new int?(Convert.ToInt32(this.AdiCombo.SelectedValue));
        YetkiClass.personelid = Convert.ToInt32(this.AdiCombo.SelectedValue);
        tblpersonelizin.IZINTURU = this.İzinTuruCombo.Text;
        tblpersonelizin.IZINYILLARI = this.İzinYillariTxt.Text;
        tblpersonelizin.BASLANGICTARIHI = new DateTime?(this.BaslangicTarihiDate.Value);
        tblpersonelizin.BITISTARIHI = new DateTime?(this.BitisTarihiDatetime.Value);
        tblpersonelizin.IZINGUNSAY = this.GunSayisiTxt.Text;
        tblpersonelizin.IZINDEBULADRES = this.izindekiAdresiTxt.Text;
        tblpersonelizin.ONAYTARIH = new DateTime?(this.OnayTarihidateTimePicker.Value);
        tblpersonelizin.GOREVEBASTARIH = new DateTime?(this.GoreveBasladateTimePicker.Value);
        tblpersonelizin.IZINDURUM = this.izinDurumCombo.Text;
        tblpersonelizin.BASLANGICSAATI = new DateTime?(Convert.ToDateTime(this.bas_saatdate.Text));
        try
        {
          tblpersonelizin.SBMUDURID = new int?(Convert.ToInt32(this.SubeMuduruCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          tblpersonelizin.DAIREBSKID = new int?(Convert.ToInt32(this.daireBskCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          tblpersonelizin.GENELSEKYRDID = new int?(Convert.ToInt32(this.genelSkrYardCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        try
        {
          tblpersonelizin.INSANDAIREBSKID = new int?(Convert.ToInt32(this.insKayDBSKCombo.SelectedValue));
        }
        catch (Exception ex)
        {
        }
        tblpersonelizin.MUDURYERINE = new int?(Convert.ToInt32(this.mudurYrnBakanTxt.Text));
        string[] source1 = this.İzinYillariTxt.Text.Split(',');
        int per_id = Convert.ToInt32(YetkiClass.personelid);
        int num1 = 0;
        int num2 = 0;
        int num3 = int.Parse(this.GunSayisiTxt.Text);
        int degeryil = 0;
        string str1 = "";
        foreach (string str2 in source1)
        {
          degeryil = Convert.ToInt32(str2);
          IQueryable<TBLPERSIZINDURUM> source2 = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) per_id));
          Expression<Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.IZINYILI == (int?) degeryil);
          foreach (TBLPERSIZINDURUM tblpersizindurum in (IEnumerable<TBLPERSIZINDURUM>) source2.Where<TBLPERSIZINDURUM>(predicate))
          {
            if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) > 0)
            {
              try
              {
                num1 += Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN);
              }
              catch (Exception ex)
              {
              }
              try
              {
                num2 += Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN);
              }
              catch (Exception ex)
              {
              }
            }
            else
            {
              int num4 = (int) MessageBox.Show(degeryil.ToString() + " bu yıla ait izin hakkı yoktur");
              break;
            }
          }
          str1 = this.kul.sayitoyazi(Convert.ToInt32(this.GunSayisiTxt.Text));
          if (((IEnumerable<string>) source1).Count<string>() > 1)
            str1 = this.İzinYillariTxt.Text + " Yıllarından " + this.GunSayisiTxt.Text + str1;
          else if (((IEnumerable<string>) source1).Count<string>() == 1)
            str1 = this.İzinYillariTxt.Text + " Yılından " + this.GunSayisiTxt.Text + str1;
        }
        tblpersonelizin.IZINSURESI = str1;
        if (num1 >= num3)
        {
          foreach (string str3 in source1)
          {
            try
            {
              int deger = Convert.ToInt32(str3);
              TBLPERSIZINDURUM tblpersizindurum = this.db.TBLPERSIZINDURUM.FirstOrDefault<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (ys => ys.PERSONELID == (int?) per_id && ys.IZINYILI == (int?) deger));
              if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) > num3)
                tblpersizindurum.KULLANILANIZIN = new int?(Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) + num3);
              else if (Convert.ToInt32((object) tblpersizindurum.IZINHAKKI) - Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN) == num1)
              {
                tblpersizindurum.KULLANILANIZIN = new int?(num3);
              }
              else
              {
                tblpersizindurum.KULLANILANIZIN = tblpersizindurum.IZINHAKKI;
                num3 -= Convert.ToInt32((object) tblpersizindurum.IZINHAKKI);
              }
            }
            catch (Exception ex)
            {
            }
            this.db.SaveChanges();
          }
          this.db.SaveChanges();
          int num5 = (int) MessageBox.Show("Başarlı bir sikilde kaydedildi.");
        }
        else
        {
          int num6 = (int) MessageBox.Show("İzin gün sayısı toplam izin sayısını geçemez.");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void sil()
    {
      TBLPERSONELIZIN entity = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
      string[] strArray = this.İzinYillariTxt.Text.Split(',');
      int per_id = Convert.ToInt32((object) entity.PERSID);
      int int32_1 = Convert.ToInt32(entity.IZINGUNSAY);
      foreach (string str in strArray)
      {
        int degeryil = Convert.ToInt32(str);
        IQueryable<TBLPERSIZINDURUM> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) per_id));
        Expression<Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.IZINYILI == (int?) degeryil);
        foreach (TBLPERSIZINDURUM tblpersizindurum1 in (IEnumerable<TBLPERSIZINDURUM>) source.Where<TBLPERSIZINDURUM>(predicate))
        {
          try
          {
            int int32_2 = Convert.ToInt32((object) tblpersizindurum1.IZINHAKKI);
            int int32_3 = Convert.ToInt32((object) tblpersizindurum1.KULLANILANIZIN);
            if (int32_2 == int32_3 && int32_3 < int32_1)
            {
              int32_1 -= int32_2;
              tblpersizindurum1.KULLANILANIZIN = new int?(0);
              int? nullable1 = tblpersizindurum1.KULLANILANIZIN;
              int num = 0;
              if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
              {
                TBLPERSIZINDURUM tblpersizindurum2 = tblpersizindurum1;
                nullable1 = new int?();
                int? nullable2 = nullable1;
                tblpersizindurum2.PERSONELIZINID = nullable2;
              }
            }
            else
            {
              tblpersizindurum1.KULLANILANIZIN = new int?(int32_3 - int32_1);
              int32_1 -= int32_3;
              int? nullable3 = tblpersizindurum1.KULLANILANIZIN;
              int num = 0;
              if (nullable3.GetValueOrDefault() == num & nullable3.HasValue)
              {
                TBLPERSIZINDURUM tblpersizindurum3 = tblpersizindurum1;
                nullable3 = new int?();
                int? nullable4 = nullable3;
                tblpersizindurum3.PERSONELIZINID = nullable4;
              }
            }
          }
          catch (DbEntityValidationException ex)
          {
            Exception innerException = (Exception) ex;
            foreach (DbEntityValidationResult entityValidationError in ex.EntityValidationErrors)
            {
              foreach (DbValidationError validationError in (IEnumerable<DbValidationError>) entityValidationError.ValidationErrors)
                innerException = (Exception) new InvalidOperationException(string.Format("{0}:{1}", (object) entityValidationError.Entry.Entity.ToString(), (object) validationError.ErrorMessage), innerException);
            }
            throw innerException;
          }
        }
      }
      this.db.TBLPERSONELIZIN.Remove(entity);
      this.db.SaveChanges();
      int num1 = (int) MessageBox.Show("İşlem gerekçleşti");
    }

    private void gunsilfonk()
    {
      TBLPERSONELIZIN tblpersonelizin = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
      string[] strArray = this.İzinYillariTxt.Text.Split(',');
      int per_id = Convert.ToInt32((object) tblpersonelizin.PERSID);
      int int32_1 = Convert.ToInt32(tblpersonelizin.IZINGUNSAY);
      foreach (string str in strArray)
      {
        int degeryil = Convert.ToInt32(str);
        IQueryable<TBLPERSIZINDURUM> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) per_id));
        Expression<Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<Func<TBLPERSIZINDURUM, bool>>) (hd => hd.IZINYILI == (int?) degeryil);
        foreach (TBLPERSIZINDURUM tblpersizindurum in (IEnumerable<TBLPERSIZINDURUM>) source.Where<TBLPERSIZINDURUM>(predicate))
        {
          try
          {
            int int32_2 = Convert.ToInt32((object) tblpersizindurum.IZINHAKKI);
            int int32_3 = Convert.ToInt32((object) tblpersizindurum.KULLANILANIZIN);
            if (int32_2 == int32_3 && int32_3 < int32_1)
            {
              int32_1 -= int32_2;
              tblpersizindurum.KULLANILANIZIN = new int?(0);
            }
            else
            {
              tblpersizindurum.KULLANILANIZIN = new int?(int32_3 - int32_1);
              int32_1 -= int32_3;
            }
          }
          catch (DbEntityValidationException ex)
          {
            Exception innerException = (Exception) ex;
            foreach (DbEntityValidationResult entityValidationError in ex.EntityValidationErrors)
            {
              foreach (DbValidationError validationError in (IEnumerable<DbValidationError>) entityValidationError.ValidationErrors)
                innerException = (Exception) new InvalidOperationException(string.Format("{0}:{1}", (object) entityValidationError.Entry.Entity.ToString(), (object) validationError.ErrorMessage), innerException);
            }
            throw innerException;
          }
        }
      }
      this.db.SaveChanges();
    }

    private void yazdirfonk()
    {
      int num = (int) new PersonelizinFormuYazdir()
      {
        yazdir_id = YetkiClass.secim_id
      }.ShowDialog();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.SilYetki == 1)
      {
        this.sil();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button6_Click(object sender, EventArgs e) => this.yazdirfonk();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SubeMuduruCombo = new ComboBox();
      this.label13 = new Label();
      this.button1 = new Button();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.İzinYillariTxt = new TextBox();
      this.label6 = new Label();
      this.label3 = new Label();
      this.AraTxt = new TextBox();
      this.label2 = new Label();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.panel2 = new Panel();
      this.girisLabel = new Label();
      this.label4 = new Label();
      this.button4 = new Button();
      this.button3 = new Button();
      this.panel1 = new Panel();
      this.İzinTuruCombo = new ComboBox();
      this.label1 = new Label();
      this.daireBskCombo = new ComboBox();
      this.label5 = new Label();
      this.insKayDBSKCombo = new ComboBox();
      this.label14 = new Label();
      this.genelSkrYardCombo = new ComboBox();
      this.label15 = new Label();
      this.BaslangicTarihiDate = new DateTimePicker();
      this.BitisTarihiDatetime = new DateTimePicker();
      this.OnayTarihidateTimePicker = new DateTimePicker();
      this.GoreveBasladateTimePicker = new DateTimePicker();
      this.AdiCombo = new ComboBox();
      this.GunSayisiTxt = new TextBox();
      this.izindekiAdresiTxt = new TextBox();
      this.izinDurumCombo = new ComboBox();
      this.label16 = new Label();
      this.mudurYrnBakanTxt = new TextBox();
      this.dataGridView1 = new DataGridView();
      this.IDX = new DataGridViewTextBoxColumn();
      this.ADISOYADI = new DataGridViewTextBoxColumn();
      this.bas_saatdate = new DateTimePicker();
      this.label17 = new Label();
      this.button2 = new Button();
      this.button6 = new Button();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.SubeMuduruCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.SubeMuduruCombo.FormattingEnabled = true;
      this.SubeMuduruCombo.Location = new Point(357, 559);
      this.SubeMuduruCombo.Name = "SubeMuduruCombo";
      this.SubeMuduruCombo.Size = new Size(379, 32);
      this.SubeMuduruCombo.TabIndex = 137;
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label13.Location = new Point(228, 562);
      this.label13.Name = "label13";
      this.label13.Size = new Size(118, 21);
      this.label13.TabIndex = 136;
      this.label13.Text = "Şube Müdürü";
      this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(1121, 6);
      this.button1.Name = "button1";
      this.button1.Size = new Size(82, 32);
      this.button1.TabIndex = 4;
      this.button1.Text = "X";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label12.Location = new Point(241, 529);
      this.label12.Name = "label12";
      this.label12.Size = new Size(105, 21);
      this.label12.TabIndex = 134;
      this.label12.Text = "Onay Tarihi";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label11.Location = new Point(212, 437);
      this.label11.Name = "label11";
      this.label11.Size = new Size(134, 21);
      this.label11.TabIndex = 132;
      this.label11.Text = "İzindeki Adresi";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label10.Location = new Point(191, 404);
      this.label10.Name = "label10";
      this.label10.Size = new Size(155, 21);
      this.label10.TabIndex = 130;
      this.label10.Text = "Göreve Baş. Tarih";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label9.Location = new Point(218, 371);
      this.label9.Name = "label9";
      this.label9.Size = new Size(128, 21);
      this.label9.TabIndex = 128;
      this.label9.Text = "İzin Gün Sayısı";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label8.Location = new Point(249, 338);
      this.label8.Name = "label8";
      this.label8.Size = new Size(97, 21);
      this.label8.TabIndex = 126;
      this.label8.Text = "Bitiş Tarihi";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label7.Location = new Point(205, 305);
      this.label7.Name = "label7";
      this.label7.Size = new Size(141, 21);
      this.label7.TabIndex = 124;
      this.label7.Text = "Başlangıç Tarihi";
      this.İzinYillariTxt.BackColor = Color.Ivory;
      this.İzinYillariTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.İzinYillariTxt.Location = new Point(357, 268);
      this.İzinYillariTxt.Multiline = true;
      this.İzinYillariTxt.Name = "İzinYillariTxt";
      this.İzinYillariTxt.Size = new Size(379, 31);
      this.İzinYillariTxt.TabIndex = 123;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label6.Location = new Point(253, 272);
      this.label6.Name = "label6";
      this.label6.Size = new Size(93, 21);
      this.label6.TabIndex = 122;
      this.label6.Text = "İzin Yıllari";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.Location = new Point(248, 204);
      this.label3.Name = "label3";
      this.label3.Size = new Size(98, 21);
      this.label3.TabIndex = 116;
      this.label3.Text = "Adı Soyadı";
      this.AraTxt.BackColor = Color.Ivory;
      this.AraTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.AraTxt.ImeMode = ImeMode.NoControl;
      this.AraTxt.Location = new Point(357, 169);
      this.AraTxt.Multiline = true;
      this.AraTxt.Name = "AraTxt";
      this.AraTxt.Size = new Size(151, 27);
      this.AraTxt.TabIndex = 115;
      this.AraTxt.TextChanged += new EventHandler(this.AraTxt_TextChanged);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.Location = new Point(307, 173);
      this.label2.Name = "label2";
      this.label2.Size = new Size(39, 21);
      this.label2.TabIndex = 114;
      this.label2.Text = "Ara";
      this.panel3.BackColor = Color.SteelBlue;
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(0, 47);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(6, 721);
      this.panel3.TabIndex = 113;
      this.panel4.BackColor = Color.SteelBlue;
      this.panel4.Dock = DockStyle.Bottom;
      this.panel4.Location = new Point(0, 768);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(1209, 6);
      this.panel4.TabIndex = 112;
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1209, 47);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 727);
      this.panel2.TabIndex = 111;
      this.girisLabel.AutoSize = true;
      this.girisLabel.Font = new Font("Century Gothic", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.girisLabel.ForeColor = Color.White;
      this.girisLabel.Location = new Point(474, 9);
      this.girisLabel.Name = "girisLabel";
      this.girisLabel.Size = new Size(132, 29);
      this.girisLabel.TabIndex = 8;
      this.girisLabel.Text = "İZİN KAYIT";
      this.girisLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(263, 239);
      this.label4.Name = "label4";
      this.label4.Size = new Size(83, 21);
      this.label4.TabIndex = 118;
      this.label4.Text = "İzin Türü";
      this.button4.BackColor = Color.SteelBlue;
      this.button4.FlatAppearance.BorderSize = 2;
      this.button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.White;
      this.button4.Location = new Point(209, 53);
      this.button4.Name = "button4";
      this.button4.Size = new Size(145, 39);
      this.button4.TabIndex = 108;
      this.button4.Text = "Yeni Ekle";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.BackColor = Color.SteelBlue;
      this.button3.FlatAppearance.BorderSize = 2;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(40, 53);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 39);
      this.button3.TabIndex = 107;
      this.button3.Text = "Kaydet";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.panel1.BackColor = Color.SteelBlue;
      this.panel1.Controls.Add((Control) this.girisLabel);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1215, 47);
      this.panel1.TabIndex = 105;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.İzinTuruCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.İzinTuruCombo.FormattingEnabled = true;
      this.İzinTuruCombo.Items.AddRange(new object[3]
      {
        (object) "Yıllık",
        (object) "Mazeret",
        (object) "Doğum izni"
      });
      this.İzinTuruCombo.Location = new Point(357, 234);
      this.İzinTuruCombo.Name = "İzinTuruCombo";
      this.İzinTuruCombo.Size = new Size(152, 32);
      this.İzinTuruCombo.TabIndex = 125;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label1.Location = new Point(223, 597);
      this.label1.Name = "label1";
      this.label1.Size = new Size(123, 21);
      this.label1.TabIndex = 132;
      this.label1.Text = "Daire Başkanı";
      this.daireBskCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.daireBskCombo.FormattingEnabled = true;
      this.daireBskCombo.Location = new Point(357, 594);
      this.daireBskCombo.Name = "daireBskCombo";
      this.daireBskCombo.Size = new Size(379, 32);
      this.daireBskCombo.TabIndex = 133;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label5.Location = new Point(207, 630);
      this.label5.Name = "label5";
      this.label5.Size = new Size(139, 21);
      this.label5.TabIndex = 134;
      this.label5.Text = "İnsan Kay D.Bşk";
      this.insKayDBSKCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.insKayDBSKCombo.FormattingEnabled = true;
      this.insKayDBSKCombo.Location = new Point(357, 627);
      this.insKayDBSKCombo.Name = "insKayDBSKCombo";
      this.insKayDBSKCombo.Size = new Size(379, 32);
      this.insKayDBSKCombo.TabIndex = 135;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label14.Location = new Point(171, 663);
      this.label14.Name = "label14";
      this.label14.Size = new Size(175, 21);
      this.label14.TabIndex = 136;
      this.label14.Text = "Genel Sekreter Yard";
      this.genelSkrYardCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.genelSkrYardCombo.FormattingEnabled = true;
      this.genelSkrYardCombo.Location = new Point(357, 660);
      this.genelSkrYardCombo.Name = "genelSkrYardCombo";
      this.genelSkrYardCombo.Size = new Size(379, 32);
      this.genelSkrYardCombo.TabIndex = 137;
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label15.Location = new Point(162, 700);
      this.label15.Name = "label15";
      this.label15.Size = new Size(181, 21);
      this.label15.TabIndex = 136;
      this.label15.Text = "Müdür  Yerine Bakan";
      this.BaslangicTarihiDate.CalendarFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.BaslangicTarihiDate.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.BaslangicTarihiDate.Format = DateTimePickerFormat.Short;
      this.BaslangicTarihiDate.Location = new Point(357, 302);
      this.BaslangicTarihiDate.Name = "BaslangicTarihiDate";
      this.BaslangicTarihiDate.Size = new Size(152, 26);
      this.BaslangicTarihiDate.TabIndex = 138;
      this.BaslangicTarihiDate.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.BitisTarihiDatetime.CalendarFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.BitisTarihiDatetime.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.BitisTarihiDatetime.Format = DateTimePickerFormat.Short;
      this.BitisTarihiDatetime.Location = new Point(357, 335);
      this.BitisTarihiDatetime.Name = "BitisTarihiDatetime";
      this.BitisTarihiDatetime.Size = new Size(152, 26);
      this.BitisTarihiDatetime.TabIndex = 138;
      this.BitisTarihiDatetime.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.OnayTarihidateTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.OnayTarihidateTimePicker.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.OnayTarihidateTimePicker.Format = DateTimePickerFormat.Short;
      this.OnayTarihidateTimePicker.Location = new Point(357, 529);
      this.OnayTarihidateTimePicker.Name = "OnayTarihidateTimePicker";
      this.OnayTarihidateTimePicker.Size = new Size(152, 26);
      this.OnayTarihidateTimePicker.TabIndex = 139;
      this.OnayTarihidateTimePicker.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.GoreveBasladateTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.GoreveBasladateTimePicker.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.GoreveBasladateTimePicker.Format = DateTimePickerFormat.Short;
      this.GoreveBasladateTimePicker.Location = new Point(357, 402);
      this.GoreveBasladateTimePicker.Name = "GoreveBasladateTimePicker";
      this.GoreveBasladateTimePicker.Size = new Size(152, 26);
      this.GoreveBasladateTimePicker.TabIndex = 140;
      this.GoreveBasladateTimePicker.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
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
      this.AdiCombo.Location = new Point(357, 199);
      this.AdiCombo.Name = "AdiCombo";
      this.AdiCombo.Size = new Size(379, 32);
      this.AdiCombo.TabIndex = 141;
      this.GunSayisiTxt.BackColor = Color.Ivory;
      this.GunSayisiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.GunSayisiTxt.Location = new Point(357, 367);
      this.GunSayisiTxt.Multiline = true;
      this.GunSayisiTxt.Name = "GunSayisiTxt";
      this.GunSayisiTxt.Size = new Size(152, 31);
      this.GunSayisiTxt.TabIndex = 142;
      this.izindekiAdresiTxt.BackColor = Color.Ivory;
      this.izindekiAdresiTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.izindekiAdresiTxt.Location = new Point(358, 436);
      this.izindekiAdresiTxt.Multiline = true;
      this.izindekiAdresiTxt.Name = "izindekiAdresiTxt";
      this.izindekiAdresiTxt.Size = new Size(379, 88);
      this.izindekiAdresiTxt.TabIndex = 143;
      this.izinDurumCombo.Font = new Font("Microsoft Sans Serif", 11.7f, FontStyle.Bold);
      this.izinDurumCombo.FormattingEnabled = true;
      this.izinDurumCombo.Items.AddRange(new object[2]
      {
        (object) "İzinde",
        (object) "Geldi"
      });
      this.izinDurumCombo.Location = new Point(623, 525);
      this.izinDurumCombo.Name = "izinDurumCombo";
      this.izinDurumCombo.Size = new Size(113, 32);
      this.izinDurumCombo.TabIndex = 137;
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label16.Location = new Point(515, 531);
      this.label16.Name = "label16";
      this.label16.Size = new Size(101, 21);
      this.label16.TabIndex = 134;
      this.label16.Text = "İzin Durum";
      this.mudurYrnBakanTxt.BackColor = Color.Ivory;
      this.mudurYrnBakanTxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.mudurYrnBakanTxt.Location = new Point(357, 694);
      this.mudurYrnBakanTxt.Multiline = true;
      this.mudurYrnBakanTxt.Name = "mudurYrnBakanTxt";
      this.mudurYrnBakanTxt.Size = new Size(379, 31);
      this.mudurYrnBakanTxt.TabIndex = 123;
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.IDX, (DataGridViewColumn) this.ADISOYADI);
      this.dataGridView1.Location = new Point(739, 199);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView1.RowTemplate.Height = 40;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(429, 408);
      this.dataGridView1.TabIndex = 155;
      this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      this.IDX.DataPropertyName = "IDX";
      this.IDX.FillWeight = 50.76142f;
      this.IDX.HeaderText = "IDX";
      this.IDX.Name = "IDX";
      this.ADISOYADI.DataPropertyName = "ADISOYADI";
      this.ADISOYADI.FillWeight = 149.2386f;
      this.ADISOYADI.HeaderText = "ADISOYADI";
      this.ADISOYADI.Name = "ADISOYADI";
      this.bas_saatdate.CalendarFont = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bas_saatdate.Font = new Font("Microsoft Sans Serif", 9.6f, FontStyle.Bold);
      this.bas_saatdate.Format = DateTimePickerFormat.Time;
      this.bas_saatdate.Location = new Point(585, 305);
      this.bas_saatdate.Name = "bas_saatdate";
      this.bas_saatdate.ShowUpDown = true;
      this.bas_saatdate.Size = new Size(152, 26);
      this.bas_saatdate.TabIndex = 138;
      this.bas_saatdate.Value = new DateTime(2021, 10, 27, 17, 50, 16, 0);
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Lucida Sans Unicode", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label17.Location = new Point(530, 307);
      this.label17.Name = "label17";
      this.label17.Size = new Size(45, 21);
      this.label17.TabIndex = 126;
      this.label17.Text = "Saat";
      this.button2.BackColor = Color.SteelBlue;
      this.button2.FlatAppearance.BorderSize = 2;
      this.button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.White;
      this.button2.Location = new Point(378, 53);
      this.button2.Name = "button2";
      this.button2.Size = new Size(145, 39);
      this.button2.TabIndex = 109;
      this.button2.Text = "Sil";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.SteelBlue;
      this.button6.FlatAppearance.BorderSize = 2;
      this.button6.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button6.ForeColor = Color.White;
      this.button6.Location = new Point(547, 53);
      this.button6.Name = "button6";
      this.button6.Size = new Size(145, 39);
      this.button6.TabIndex = 109;
      this.button6.Text = "Yazdır";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1215, 774);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.izindekiAdresiTxt);
      this.Controls.Add((Control) this.GunSayisiTxt);
      this.Controls.Add((Control) this.AdiCombo);
      this.Controls.Add((Control) this.GoreveBasladateTimePicker);
      this.Controls.Add((Control) this.OnayTarihidateTimePicker);
      this.Controls.Add((Control) this.BitisTarihiDatetime);
      this.Controls.Add((Control) this.bas_saatdate);
      this.Controls.Add((Control) this.BaslangicTarihiDate);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.genelSkrYardCombo);
      this.Controls.Add((Control) this.label14);
      this.Controls.Add((Control) this.izinDurumCombo);
      this.Controls.Add((Control) this.SubeMuduruCombo);
      this.Controls.Add((Control) this.insKayDBSKCombo);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.daireBskCombo);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.İzinTuruCombo);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.mudurYrnBakanTxt);
      this.Controls.Add((Control) this.İzinYillariTxt);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.AraTxt);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (PersonelIzinFormu);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (PersonelIzinFormu);
      this.Load += new EventHandler(this.PersonelIzinFormu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
