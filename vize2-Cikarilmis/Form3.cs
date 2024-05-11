// Decompiled with JetBrains decompiler
// Type: vize2.Form3
// Assembly: vize2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B51AE39-F2E9-466B-AE8E-E46B77637AE0
// Assembly location: C:\Users\alika\AppData\Local\Apps\2.0\Z0554ZKO.T39\MRGGENCW.A9Q\vize..tion_da83c66a6ba25ef2_0001.0000_efe3df4567b02f2a\vize2.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace vize2
{
  public partial class Form3 : Form
  {
    
    private string cumle;


        public Form3() {
            InitializeComponent();
        } 

    private void verilerigörüntüle()
    {
      DataBaseKoprusu.baglanti.Open();
      DataBaseKoprusu.komut2.Connection = DataBaseKoprusu.baglanti;
      DataBaseKoprusu.komut2.CommandText = "Select * From AMBAR";
      OleDbDataReader oleDbDataReader = DataBaseKoprusu.komut2.ExecuteReader();
      while (oleDbDataReader.Read())
        listView1.Items.Add(new ListViewItem()
        {
          Text = oleDbDataReader["id"].ToString(),
          SubItems = {
            oleDbDataReader["kapasite"].ToString(),
            oleDbDataReader["adres"].ToString()
          }
        });
      DataBaseKoprusu.baglanti.Close();
    }

    private void verilerigörüntüle2()
    {
      DataBaseKoprusu.baglanti.Open();
      OleDbCommand oleDbCommand = new OleDbCommand();
      oleDbCommand.Connection = DataBaseKoprusu.baglanti;
      oleDbCommand.CommandText = "Select * From STOK";
      OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
      while (oleDbDataReader.Read())
        listView2.Items.Add(new ListViewItem()
        {
          Text = oleDbDataReader["id"].ToString(),
          SubItems = {
            oleDbDataReader["URUN_ad"].ToString(),
            oleDbDataReader["miktar"].ToString(),
            oleDbDataReader["değeri"].ToString(),
            oleDbDataReader["saklamasüresi"].ToString(),
            oleDbDataReader["gönderenfirma"].ToString(),
            oleDbDataReader["alıcıfirma"].ToString()
          }
        });
      DataBaseKoprusu.baglanti.Close();
    }

    private void Form3_Load(object sender, EventArgs e)
    {
      label6.Text = Form1.isim.ToString();
      label7.Text = Form1.soyisim.ToString();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(textBox2.Text);
      DataBaseKoprusu.baglanti.Open();
      if (int32 <= 1000)
      {
        this.cumle = "insert into GirenCIKAN (URUN_ad,topmiktar,topdeger,gonderen,alici,tarih,islemtipi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + (object) 1 + "')";
        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox10.Text != "" && textBox5.Text != "" && textBox9.Text != "")
        {
          DataBaseKoprusu.komut2.Connection = DataBaseKoprusu.baglanti;
          OleDbCommand oleDbCommand = new OleDbCommand(this.cumle, DataBaseKoprusu.baglanti);
          DataBaseKoprusu.komut2.CommandText = "insert into STOK (URUN_ad,miktar,değeri,saklamasüresi,gönderenfirma,alıcıfirma) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox10.Text + "','" + textBox5.Text + "','" + textBox9.Text + "')";
          oleDbCommand.ExecuteNonQuery();
          DataBaseKoprusu.komut2.ExecuteNonQuery();
          int num = (int) MessageBox.Show("Bilgiler Başarı İle Kaydedildi");
          textBox1.Clear();
          textBox2.Clear();
          textBox3.Clear();
          textBox10.Clear();
          textBox5.Clear();
          textBox9.Clear();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Boş Alan olamaz!");
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Depolar 50 Tondan Fazla Yük Alamaz");
      }
      DataBaseKoprusu.baglanti.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DataBaseKoprusu.baglanti.Open();
      DataBaseKoprusu.komut2.Connection = DataBaseKoprusu.baglanti;
      if (textBox8.Text != "")
      {
        OleDbCommand oleDbCommand = new OleDbCommand();
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(URUN_ad) values(select URUN_ad from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(topmiktar) values(select miktar from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(toplamdeger) values(select değeri from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(gonderen) values(select gönderenfirma from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(alici) values(select alıcıfirma from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(tarih) values(select saklamasüresi from STOK)";
        DataBaseKoprusu.komut2.CommandText = "insert into GirisCIKIS(islemtipi) values('" + (object) 2 + "')";
        DataBaseKoprusu.komut2.CommandText = "Delete From STOK Where URUN_ad = '" + textBox8.Text + "' ";
        DataBaseKoprusu.komut2.ExecuteNonQuery();
        int num = (int) MessageBox.Show("Bilgiler Başarı İle Kaydedildi");
      }
      else
      {
        int num1 = (int) MessageBox.Show("Ürün Adı Girmeniz Gerekmekte");
      }
      DataBaseKoprusu.baglanti.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.verilerigörüntüle();
      button3.Visible = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      listView2.Items.Clear();
      this.verilerigörüntüle2();
    }

    

    
  }
}
