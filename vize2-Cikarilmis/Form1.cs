// Decompiled with JetBrains decompiler
// Type: vize2.Form1
// Assembly: vize2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B51AE39-F2E9-466B-AE8E-E46B77637AE0
// Assembly location: C:\Users\alika\AppData\Local\Apps\2.0\Z0554ZKO.T39\MRGGENCW.A9Q\vize..tion_da83c66a6ba25ef2_0001.0000_efe3df4567b02f2a\vize2.exe

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace vize2
{
  public partial class Form1 : Form
  {
    
    public string nick;
    public string pass;
    public static string isim;
    public static string soyisim;
    
   

    public Form1()
    {
        InitializeComponent();
    }
       

    private void button1_Click(object sender, EventArgs e)
    {
            try
            {
                
                
                this.getir();
                
                DataBaseKoprusu.baglanti.Open();
                OleDbCommand oleDbCommand = new OleDbCommand("Select * From KULLANICIPANELI where nick='" + this.textBox1.Text + "' and sifre='" + this.textBox2.Text + "'", DataBaseKoprusu.baglanti);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                string str = "select tip from KULLANICIPANELI where '" + this.textBox1.Text + "' and sifre='" + this.textBox2.Text + "'";
                
                if (oleDbDataReader.Read())
                {
                    oleDbCommand.CommandText = str;
                    if (str == "YÖNETİCİ")
                    {
                        new Form4().Show();
                    }
                    else
                    {
                        new Form3().Show();
                        this.Hide();
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show("Bilgiler Yanlış");
                }
                DataBaseKoprusu.baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
      
    }
        
    private void getir()
    {
        try
        {
          DataBaseKoprusu.baglanti.Open();
          OleDbDataReader oleDbDataReader = new OleDbCommand("Select ad , soyad From KULLANICIPANELI Where nick='" + this.textBox1.Text + "' and sifre='" + this.textBox2.Text + "'", DataBaseKoprusu.baglanti).ExecuteReader();
          if (oleDbDataReader.Read())
          {
                    Form1.isim = oleDbDataReader[0].ToString();
                    Form1.soyisim = oleDbDataReader[1].ToString();
          }
          DataBaseKoprusu.baglanti.Close();
        }
        catch (Exception e)
        {
                MessageBox.Show(e.ToString());
        }
      
    }

    private void button2_Click(object sender, EventArgs e)
    {
      new Form2().Show();
      this.Hide();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
