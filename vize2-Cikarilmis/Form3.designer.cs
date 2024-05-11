using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System;
namespace vize2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = (IContainer)null;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBox5;
        private Label label18;
        private Label label17;
        private TextBox textBox3;
        private Label label16;
        private TextBox textBox2;
        private Label label15;
        private TextBox textBox1;
        private Label label4;
        private GroupBox groupBox4;
        private Button button2;
        private TextBox textBox8;
        private Label label23;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private Button button3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button button4;
        private TextBox textBox9;
        private Label label5;
        private TextBox textBox10;
        private Label label6;
        private Label label7;
        private GroupBox groupBox5;
        private ListView listView3;

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
            ListViewGroup listViewGroup = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            this.groupBox1 = new GroupBox();
            this.button3 = new Button();
            this.listView1 = new ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.groupBox2 = new GroupBox();
            this.listView2 = new ListView();
            this.columnHeader4 = new ColumnHeader();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader6 = new ColumnHeader();
            this.columnHeader7 = new ColumnHeader();
            this.columnHeader8 = new ColumnHeader();
            this.columnHeader9 = new ColumnHeader();
            this.columnHeader10 = new ColumnHeader();
            this.button4 = new Button();
            this.groupBox3 = new GroupBox();
            this.textBox10 = new TextBox();
            this.textBox9 = new TextBox();
            this.label5 = new Label();
            this.button1 = new Button();
            this.textBox5 = new TextBox();
            this.label18 = new Label();
            this.label17 = new Label();
            this.textBox3 = new TextBox();
            this.label16 = new Label();
            this.textBox2 = new TextBox();
            this.label15 = new Label();
            this.textBox1 = new TextBox();
            this.label4 = new Label();
            this.groupBox4 = new GroupBox();
            this.button2 = new Button();
            this.textBox8 = new TextBox();
            this.label23 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.groupBox5 = new GroupBox();
            this.listView3 = new ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            this.groupBox1.Controls.Add((Control)this.button3);
            this.groupBox1.Controls.Add((Control)this.listView1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.groupBox1.Location = new Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(484, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPOLAR";
            this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
            this.button3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.button3.Location = new Point(375, 105);
            this.button3.Name = "button3";
            this.button3.Size = new Size(94, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "GÖSTER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.listView1.Columns.AddRange(new ColumnHeader[3]
            {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3
            });
            this.listView1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            listViewGroup.Header = "ListViewGroup";
            listViewGroup.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new ListViewGroup[1]
            {
        listViewGroup
            });
            this.listView1.Location = new Point(16, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(353, 134);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.columnHeader1.Text = "Depo No";
            this.columnHeader1.Width = 80;
            this.columnHeader2.Text = "Kapasite(ton)";
            this.columnHeader2.Width = 110;
            this.columnHeader3.Text = "adres";
            this.columnHeader3.Width = 156;
            this.groupBox2.Controls.Add((Control)this.listView2);
            this.groupBox2.Controls.Add((Control)this.button4);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.groupBox2.Location = new Point(542, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(624, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STOK";
            this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
            this.listView2.Columns.AddRange(new ColumnHeader[7]
            {
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader10
            });
            this.listView2.Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.listView2.Location = new Point(6, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new Size(503, 199);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = View.Details;
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 23;
            this.columnHeader5.Text = "Ürün Adý";
            this.columnHeader6.Text = "Miktarý";
            this.columnHeader7.Text = "Deðeri";
            this.columnHeader8.Text = "Saklama Süresi";
            this.columnHeader8.Width = 126;
            this.columnHeader9.Text = "Gönderici";
            this.columnHeader10.Text = "Alýcý";
            this.columnHeader10.Width = 72;
            this.button4.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.button4.Location = new Point(515, 124);
            this.button4.Name = "button4";
            this.button4.Size = new Size(103, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "GÖSTER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.groupBox3.Controls.Add((Control)this.textBox10);
            this.groupBox3.Controls.Add((Control)this.textBox9);
            this.groupBox3.Controls.Add((Control)this.label5);
            this.groupBox3.Controls.Add((Control)this.button1);
            this.groupBox3.Controls.Add((Control)this.textBox5);
            this.groupBox3.Controls.Add((Control)this.label18);
            this.groupBox3.Controls.Add((Control)this.label17);
            this.groupBox3.Controls.Add((Control)this.textBox3);
            this.groupBox3.Controls.Add((Control)this.label16);
            this.groupBox3.Controls.Add((Control)this.textBox2);
            this.groupBox3.Controls.Add((Control)this.label15);
            this.groupBox3.Controls.Add((Control)this.textBox1);
            this.groupBox3.Controls.Add((Control)this.label4);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.groupBox3.Location = new Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(484, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN GÝRÝÞÝ";
            this.textBox10.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox10.Location = new Point(169, 134);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(100, 25);
            this.textBox10.TabIndex = 18;
            this.textBox9.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox9.Location = new Point(169, 194);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Size(100, 25);
            this.textBox9.TabIndex = 17;
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label5.Location = new Point(166, 175);
            this.label5.Name = "label5";
            this.label5.Size = new Size(83, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ALICI FÝRMA";
            this.button1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.button1.Location = new Point(339, 103);
            this.button1.Name = "button1";
            this.button1.Size = new Size(111, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox5.Location = new Point(29, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(100, 25);
            this.textBox5.TabIndex = 13;
            this.label18.AutoSize = true;
            this.label18.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label18.Location = new Point(26, 175);
            this.label18.Name = "label18";
            this.label18.Size = new Size(130, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "GÖNDEREN FÝRMA";
            this.label17.AutoSize = true;
            this.label17.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label17.Location = new Point(166, 114);
            this.label17.Name = "label17";
            this.label17.Size = new Size(125, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "TARÝH(gg/aa/yyyy)";
            this.textBox3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox3.Location = new Point(29, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(100, 25);
            this.textBox3.TabIndex = 9;
            this.label16.AutoSize = true;
            this.label16.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label16.Location = new Point(26, 114);
            this.label16.Name = "label16";
            this.label16.Size = new Size(101, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "GÝREN DEÐER";
            this.textBox2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox2.Location = new Point(169, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 25);
            this.textBox2.TabIndex = 7;
            this.label15.AutoSize = true;
            this.label15.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label15.Location = new Point(166, 55);
            this.label15.Name = "label15";
            this.label15.Size = new Size(103, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "GÝREN MÝKTAR";
            this.textBox1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox1.Location = new Point(29, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 25);
            this.textBox1.TabIndex = 5;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label4.Location = new Point(26, 55);
            this.label4.Name = "label4";
            this.label4.Size = new Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ÜRÜN ADI";
            this.groupBox4.Controls.Add((Control)this.button2);
            this.groupBox4.Controls.Add((Control)this.textBox8);
            this.groupBox4.Controls.Add((Control)this.label23);
            this.groupBox4.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.groupBox4.Location = new Point(542, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(418, 231);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN ÇIKIÞI";
            this.button2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.button2.Location = new Point(224, 86);
            this.button2.Name = "button2";
            this.button2.Size = new Size(111, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "ONAYLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.textBox8.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.textBox8.Location = new Point(69, 93);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(100, 25);
            this.textBox8.TabIndex = 5;
            this.label23.AutoSize = true;
            this.label23.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label23.Location = new Point(66, 73);
            this.label23.Name = "label23";
            this.label23.Size = new Size(73, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "ÜRÜN ADI";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label6.Location = new Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new Size(57, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "isim";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)162);
            this.label7.Location = new Point(10, 47);
            this.label7.Name = "label7";
            this.label7.Size = new Size(94, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "soyisim";
            this.groupBox5.Controls.Add((Control)this.label6);
            this.groupBox5.Controls.Add((Control)this.label7);
            this.groupBox5.Location = new Point(966, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(200, 89);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kullanýcý";
            this.listView3.Location = new Point(1005, 132);
            this.listView3.Name = "listView3";
            this.listView3.Size = new Size(121, 97);
            this.listView3.TabIndex = 8;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = View.Details;
            this.listView3.Visible = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DodgerBlue;
            this.ClientSize = new Size(1181, 620);
            this.Controls.Add((Control)this.listView3);
            this.Controls.Add((Control)this.groupBox5);
            this.Controls.Add((Control)this.groupBox4);
            this.Controls.Add((Control)this.groupBox3);
            this.Controls.Add((Control)this.groupBox2);
            this.Controls.Add((Control)this.groupBox1);
            //this.Name = nameof(Form3);
            //this.Text = nameof(Form3);
            this.Load += new EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}