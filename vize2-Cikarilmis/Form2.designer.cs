using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System;
namespace vize2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = (IContainer)null;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.textBox3 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.label7 = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.label8 = new Label();
            this.comboBox1 = new ComboBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.SuspendLayout();
            this.button1.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.button1.Location = new Point(190, 377);
            this.button1.Name = "button1";
            this.button1.Size = new Size(155, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "KAYIT YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox3.Location = new Point(189, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(156, 28);
            this.textBox3.TabIndex = 23;
            this.textBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox2.Location = new Point(188, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(156, 28);
            this.textBox2.TabIndex = 22;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox1.Location = new Point(189, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(156, 28);
            this.textBox1.TabIndex = 21;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label7.Location = new Point(111, 233);
            this.label7.Name = "label7";
            this.label7.Size = new Size(74, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "ÞÝFRE :";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label6.Location = new Point(37, 200);
            this.label6.Name = "label6";
            this.label6.Size = new Size(148, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "KULLANICI ADI :";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label5.Location = new Point(104, 167);
            this.label5.Name = "label5";
            this.label5.Size = new Size(80, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "SOYAD:";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label4.Location = new Point(128, 266);
            this.label4.Name = "label4";
            this.label4.Size = new Size(55, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "TEL :";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label3.Location = new Point(137, 133);
            this.label3.Name = "label3";
            this.label3.Size = new Size(46, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "AD :";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label2.Location = new Point(128, 28);
            this.label2.Name = "label2";
            this.label2.Size = new Size(148, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "KAYDOL";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(105, 88);
            this.label1.Name = "label1";
            this.label1.Size = new Size(187, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝRÝN";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label8.Location = new Point(27, 303);
            this.label8.Name = "label8";
            this.label8.Size = new Size(156, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "YETKÝ SEVÝYESÝ:";
            this.comboBox1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[2]
            {
        (object) "DEPO SORUMLUSU",
        (object) "KONTROL ELEMANI"
            });
            this.comboBox1.Location = new Point(188, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(156, 26);
            this.comboBox1.TabIndex = 28;
            this.textBox4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox4.Location = new Point(189, 233);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(156, 28);
            this.textBox4.TabIndex = 24;
            this.textBox4.UseSystemPasswordChar = true;
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
            this.textBox5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox5.Location = new Point(188, 266);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(156, 28);
            this.textBox5.TabIndex = 29;
            this.textBox5.UseSystemPasswordChar = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DodgerBlue;
            this.ClientSize = new Size(386, 436);
            this.Controls.Add((Control)this.textBox5);
            this.Controls.Add((Control)this.comboBox1);
            this.Controls.Add((Control)this.label8);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.textBox4);
            this.Controls.Add((Control)this.textBox3);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label7);
            this.Controls.Add((Control)this.label6);
            this.Controls.Add((Control)this.label5);
            this.Controls.Add((Control)this.label4);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            //this.Name = nameof(Form2);
            //this.Text = nameof(Form2);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}