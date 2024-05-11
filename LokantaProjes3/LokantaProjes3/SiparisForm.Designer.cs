namespace LokantaProjes3
{
    partial class SiparisForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretimMaliyeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamSatisAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamKar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kalanYamek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.yemekAdi,
            this.uretimMaliyeti,
            this.fiyati,
            this.toplamSatisAdeti,
            this.toplamKar,
            this.kalanYamek});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // yemekAdi
            // 
            this.yemekAdi.HeaderText = "Yemek Adı";
            this.yemekAdi.Name = "yemekAdi";
            // 
            // uretimMaliyeti
            // 
            this.uretimMaliyeti.HeaderText = "Üretim Maliyeti";
            this.uretimMaliyeti.Name = "uretimMaliyeti";
            // 
            // fiyati
            // 
            this.fiyati.HeaderText = "Fiyatı";
            this.fiyati.Name = "fiyati";
            // 
            // toplamSatisAdeti
            // 
            this.toplamSatisAdeti.HeaderText = "Toplam Satış Adeti";
            this.toplamSatisAdeti.Name = "toplamSatisAdeti";
            // 
            // toplamKar
            // 
            this.toplamKar.HeaderText = "Toplam Kar";
            this.toplamKar.Name = "toplamKar";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(530, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // kalanYamek
            // 
            this.kalanYamek.HeaderText = "Kalan Yemek Miktarı";
            this.kalanYamek.Name = "kalanYamek";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretimMaliyeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamSatisAdeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamKar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanYamek;
    }
}