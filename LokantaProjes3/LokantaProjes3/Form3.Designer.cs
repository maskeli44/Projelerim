namespace LokantaProjes3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonYemekEkle = new System.Windows.Forms.Button();
            this.buttonYemekSil = new System.Windows.Forms.Button();
            this.buttonRaporAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYeniYemek = new System.Windows.Forms.TextBox();
            this.textBoxMalzemeler = new System.Windows.Forms.TextBox();
            this.listBoxYemekler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonYemekEkle
            // 
            this.buttonYemekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemekEkle.Location = new System.Drawing.Point(104, 155);
            this.buttonYemekEkle.Name = "buttonYemekEkle";
            this.buttonYemekEkle.Size = new System.Drawing.Size(136, 47);
            this.buttonYemekEkle.TabIndex = 0;
            this.buttonYemekEkle.Text = "Ekle";
            this.buttonYemekEkle.UseVisualStyleBackColor = true;
            this.buttonYemekEkle.Click += new System.EventHandler(this.buttonYemekEkle_Click_1);
            // 
            // buttonYemekSil
            // 
            this.buttonYemekSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemekSil.Location = new System.Drawing.Point(104, 235);
            this.buttonYemekSil.Name = "buttonYemekSil";
            this.buttonYemekSil.Size = new System.Drawing.Size(136, 47);
            this.buttonYemekSil.TabIndex = 1;
            this.buttonYemekSil.Text = "Sil";
            this.buttonYemekSil.UseVisualStyleBackColor = true;
            this.buttonYemekSil.Click += new System.EventHandler(this.buttonYemekSil_Click_1);
            // 
            // buttonRaporAl
            // 
            this.buttonRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRaporAl.Location = new System.Drawing.Point(104, 324);
            this.buttonRaporAl.Name = "buttonRaporAl";
            this.buttonRaporAl.Size = new System.Drawing.Size(136, 45);
            this.buttonRaporAl.TabIndex = 2;
            this.buttonRaporAl.Text = "Rapor";
            this.buttonRaporAl.UseVisualStyleBackColor = true;
            this.buttonRaporAl.Click += new System.EventHandler(this.buttonRaporAl_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yemek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Malzemeler:";
            // 
            // textBoxYeniYemek
            // 
            this.textBoxYeniYemek.Location = new System.Drawing.Point(170, 23);
            this.textBoxYeniYemek.Name = "textBoxYeniYemek";
            this.textBoxYeniYemek.Size = new System.Drawing.Size(196, 26);
            this.textBoxYeniYemek.TabIndex = 5;
            // 
            // textBoxMalzemeler
            // 
            this.textBoxMalzemeler.Location = new System.Drawing.Point(170, 73);
            this.textBoxMalzemeler.Name = "textBoxMalzemeler";
            this.textBoxMalzemeler.Size = new System.Drawing.Size(196, 26);
            this.textBoxMalzemeler.TabIndex = 6;
            // 
            // listBoxYemekler
            // 
            this.listBoxYemekler.FormattingEnabled = true;
            this.listBoxYemekler.ItemHeight = 20;
            this.listBoxYemekler.Location = new System.Drawing.Point(398, 13);
            this.listBoxYemekler.Name = "listBoxYemekler";
            this.listBoxYemekler.Size = new System.Drawing.Size(372, 344);
            this.listBoxYemekler.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxYemekler);
            this.Controls.Add(this.textBoxMalzemeler);
            this.Controls.Add(this.textBoxYeniYemek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaporAl);
            this.Controls.Add(this.buttonYemekSil);
            this.Controls.Add(this.buttonYemekEkle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYemekEkle;
        private System.Windows.Forms.Button buttonYemekSil;
        private System.Windows.Forms.Button buttonRaporAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYeniYemek;
        private System.Windows.Forms.TextBox textBoxMalzemeler;
        internal System.Windows.Forms.ListBox listBoxYemekler;
    }
}