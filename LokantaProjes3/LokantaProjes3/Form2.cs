using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokantaProjes3
{
    public partial class Form2 : Form
    {
        Yiyecek yiyecek = new Yiyecek();
        Menu m = new Menu();
     
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("yemek");
            comboBox1.Items.Add("salata");
            comboBox1.Items.Add("içecek");
            comboBox1.Items.Add("tatlı");
            comboBox1.Items.Add("meyve");
            comboBox1.SelectedIndex = 0;

            
        }

        public void yazdir()
        {
            listBox1.Items.Clear();
            double Toplam = 0;
            foreach (Yiyecek yiyecek in m.SiparisYazdir())
            {
                Toplam += yiyecek.Fiyat;
                listBox1.Items.Add(yiyecek.yazdir() + " " + yiyecek.GetType().Name);
            }
            textBox6.Text = "Tutar:" + Toplam.ToString() + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "yemek")
            {
                yiyecek = new yemek(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            }
            if (comboBox1.Text == "salata")
            {
                yiyecek = new Salata(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            }
            if (comboBox1.Text == "içecek")
            {
                yiyecek = new icecek(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            }
            if (comboBox1.Text == "meyve")
            {
                yiyecek = new meyve(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            }
            if (comboBox1.Text == "tatlı")
            {
                yiyecek = new tatlı(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            }
            m.YemekEkle(yiyecek);
            yazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m.YemekSil(listBox1.SelectedIndex);
            yazdir();
        }
    }
 }

