using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System;
namespace vize2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;

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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.label2 = new Label();
            this.label3 = new Label();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 25f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label1.ForeColor = Color.GreenYellow;
            this.label1.Location = new Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new Size(639, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMBAR YÖNETÝCÝ GÝRÝÞ PANELÝ";
            this.textBox1.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox1.Location = new Point(366, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(193, 33);
            this.textBox1.TabIndex = 1;
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label2.Location = new Point(122, 225);
            this.label2.Name = "label2";
            this.label2.Size = new Size(198, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ADI:";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label3.Location = new Point(122, 282);
            this.label3.Name = "label3";
            this.label3.Size = new Size(95, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "ÞÝFRE:";
            this.textBox2.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox2.Location = new Point(366, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(193, 33);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            this.button1.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.button1.Location = new Point(337, 335);
            this.button1.Name = "button1";
            this.button1.Size = new Size(125, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "GÝRÝÞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Font = new Font("Microsoft Sans Serif", 14.5f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.button2.Location = new Point(337, 385);
            this.button2.Name = "button2";
            this.button2.Size = new Size(125, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "KAYDOL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DodgerBlue;
            this.ClientSize = new Size(800, 494);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label1);
            //this.Name = nameof(Form1);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}