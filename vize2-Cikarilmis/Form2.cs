// Decompiled with JetBrains decompiler
// Type: vize2.Form2
// Assembly: vize2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B51AE39-F2E9-466B-AE8E-E46B77637AE0
// Assembly location: C:\Users\alika\AppData\Local\Apps\2.0\Z0554ZKO.T39\MRGGENCW.A9Q\vize..tion_da83c66a6ba25ef2_0001.0000_efe3df4567b02f2a\vize2.exe

using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace vize2
{
  public partial class Form2 : Form
  {

        public Form2() {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
    {
      
      DataBaseKoprusu.baglanti.Open();
      DataBaseKoprusu.komut.Connection = DataBaseKoprusu.baglanti;
      
      if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
      {
        new OleDbCommand("insert into KULLANICIPANELI (ad,soyad,nick,sifre,tel,tip) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", DataBaseKoprusu.baglanti).ExecuteNonQuery();
        int num = (int) MessageBox.Show("Bilgileriniz Başarı İle Kaydedildi");
        new Form1().Show();
        this.Hide();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Bilgi girilmedi");
      }
      DataBaseKoprusu.baglanti.Close();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
    }

  

    
  }
}
