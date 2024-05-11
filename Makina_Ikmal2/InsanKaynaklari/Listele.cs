// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.Listele
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.LoginIslemleri;
using Makina_Ikmal.LoginIslemleri.per_listeTableAdapters;
using Makina_Ikmal.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class Listele : Form
  {
    private bellEntities db = new bellEntities();
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private Button button5;
    private ImageList ımageList1;
    private Panel panel2;
    private Button button2;
    private Button kytBtn;
    private Button button3;
    private Button button4;
    private Panel panel1;
    private Panel panel3;
    private BindingSource tBLPERSONELBindingSource1;
    private per_liste per_liste;
    private BindingSource dataTable1BindingSource;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private GridControl gridControl1;
    private BindingSource dataTable1BindingSource1;
    private GridView gridView1;
    private GridColumn colID;
    private GridColumn colDurum;
    private GridColumn colDurum1;
    private GridColumn colTCKIMLIKNO;
    private GridColumn colADISOYADI;
    private GridColumn colEGITIMDURUM;
    private GridColumn colUNVAN;
    private GridColumn colGOREVYERI;
    private GridColumn colCEPTELEFON;
    private GridColumn colPLAKA;
    private GridColumn colDOGUMTARIHI;
    private GridColumn colISEGIRISTARIHI;
    private GridColumn colSIRANO;
    private GridColumn colKURUMGOREV;

    public Listele() => this.InitializeComponent();

    private void Listele_Load(object sender, EventArgs e)
    {
      this.dataTable1TableAdapter.Fill(this.per_liste.DataTable1);
      this.liste();
    }

    private void liste()
    {
    }

    private void button4_Click(object sender, EventArgs e) => this.Close();

    private void button5_Click(object sender, EventArgs e)
    {
      int num = (int) new ResimliYazdirFormu().ShowDialog();
    }

    private void kytBtn_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi") && YetkiClass.EkleYetki == 1)
      {
        YetkiClass.secim = "kayıt";
        int num = (int) new fEkle().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi") && YetkiClass.GuncelleYetki == 1)
      {
        YetkiClass.secim = "guncelle";
        int num = (int) new fEkle().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi") && YetkiClass.SilYetki == 1)
      {
        YetkiClass.secim = "sil";
        TBLPERSONEL entity = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (x => x.ID == YetkiClass.personelid));
        if (MessageBox.Show(entity.ADISOYADI + " adlı kişi silmek istediğinizden emin misiniz", "Evet", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.db.TBLPERSONEL.Remove(entity);
        this.db.SaveChanges();
        this.liste();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void advancedDataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void advancedDataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi") && YetkiClass.GuncelleYetki == 1)
      {
        YetkiClass.secim = "guncelle";
        int num = (int) new fEkle().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void advancedDataGridView1_SortStringChanged_1(object sender, EventArgs e)
    {
    }

    private void advancedDataGridView1_FilterStringChanged_1(object sender, EventArgs e)
    {
    }

    private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Listele));
      this.button5 = new Button();
      this.ımageList1 = new ImageList(this.components);
      this.panel2 = new Panel();
      this.button2 = new Button();
      this.kytBtn = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.panel1 = new Panel();
      this.panel3 = new Panel();
      this.tBLPERSONELBindingSource1 = new BindingSource(this.components);
      this.per_liste = new per_liste();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.colID = new GridColumn();
      this.colDurum = new GridColumn();
      this.colDurum1 = new GridColumn();
      this.colTCKIMLIKNO = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colEGITIMDURUM = new GridColumn();
      this.colUNVAN = new GridColumn();
      this.colGOREVYERI = new GridColumn();
      this.colCEPTELEFON = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colDOGUMTARIHI = new GridColumn();
      this.colISEGIRISTARIHI = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colKURUMGOREV = new GridColumn();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).BeginInit();
      this.per_liste.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.SuspendLayout();
      this.button5.BackColor = Color.Transparent;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button5.ForeColor = Color.White;
      this.button5.ImageAlign = ContentAlignment.TopCenter;
      this.button5.ImageKey = "Downloads.png";
      this.button5.ImageList = this.ımageList1;
      this.button5.Location = new Point(572, 8);
      this.button5.Name = "button5";
      this.button5.Size = new Size(124, 73);
      this.button5.TabIndex = 190;
      this.button5.Text = "Rapor";
      this.button5.TextAlign = ContentAlignment.BottomCenter;
      this.button5.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.ımageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ımageList1.ImageStream");
      this.ımageList1.TransparentColor = Color.Transparent;
      this.ımageList1.Images.SetKeyName(0, "223.png");
      this.ımageList1.Images.SetKeyName(1, "1283195017_Check.ico");
      this.ımageList1.Images.SetKeyName(2, "Actualiser.png");
      this.ımageList1.Images.SetKeyName(3, "Add.ico");
      this.ımageList1.Images.SetKeyName(4, "Bittorrent Plus.png");
      this.ımageList1.Images.SetKeyName(5, "Downloads.png");
      this.ımageList1.Images.SetKeyName(6, "loading30.gif");
      this.ımageList1.Images.SetKeyName(7, "14 Reboot.png");
      this.ımageList1.Images.SetKeyName(8, "button_plus_green.ico");
      this.ımageList1.Images.SetKeyName(9, "Sil32x32.png");
      this.ımageList1.Images.SetKeyName(10, "Windows Turn Off.png");
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1645, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 836);
      this.panel2.TabIndex = 192;
      this.button2.BackColor = Color.Transparent;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button2.ForeColor = Color.White;
      this.button2.ImageAlign = ContentAlignment.TopCenter;
      this.button2.ImageKey = "Downloads.png";
      this.button2.ImageList = this.ımageList1;
      this.button2.Location = new Point(100, -1);
      this.button2.Name = "button2";
      this.button2.Size = new Size(120, 92);
      this.button2.TabIndex = 188;
      this.button2.Text = "Düzenle";
      this.button2.TextAlign = ContentAlignment.BottomCenter;
      this.button2.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.kytBtn.BackColor = Color.Transparent;
      this.kytBtn.FlatAppearance.BorderSize = 0;
      this.kytBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.kytBtn.FlatStyle = FlatStyle.Flat;
      this.kytBtn.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.kytBtn.ForeColor = Color.White;
      this.kytBtn.ImageAlign = ContentAlignment.TopCenter;
      this.kytBtn.ImageKey = "Bittorrent Plus.png";
      this.kytBtn.ImageList = this.ımageList1;
      this.kytBtn.Location = new Point(11, -1);
      this.kytBtn.Name = "kytBtn";
      this.kytBtn.Size = new Size(105, 95);
      this.kytBtn.TabIndex = 189;
      this.kytBtn.Text = "Yeni Ekle";
      this.kytBtn.TextAlign = ContentAlignment.BottomCenter;
      this.kytBtn.TextImageRelation = TextImageRelation.ImageAboveText;
      this.kytBtn.UseVisualStyleBackColor = false;
      this.kytBtn.Click += new EventHandler(this.kytBtn_Click);
      this.button3.BackColor = Color.Transparent;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button3.ForeColor = Color.White;
      this.button3.ImageAlign = ContentAlignment.TopCenter;
      this.button3.ImageKey = "Sil32x32.png";
      this.button3.ImageList = this.ımageList1;
      this.button3.Location = new Point(189, -1);
      this.button3.Name = "button3";
      this.button3.Size = new Size(115, 92);
      this.button3.TabIndex = 191;
      this.button3.Text = "Sil";
      this.button3.TextAlign = ContentAlignment.BottomCenter;
      this.button3.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button4.BackColor = Color.Transparent;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button4.ForeColor = Color.White;
      this.button4.ImageAlign = ContentAlignment.TopCenter;
      this.button4.ImageIndex = 10;
      this.button4.ImageList = this.ımageList1;
      this.button4.Location = new Point(1550, 0);
      this.button4.Name = "button4";
      this.button4.Size = new Size(88, 76);
      this.button4.TabIndex = 187;
      this.button4.Text = "Kapat";
      this.button4.TextAlign = ContentAlignment.BottomCenter;
      this.button4.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.panel1.BackColor = Color.FromArgb(0, 134, 138);
      this.panel1.Controls.Add((Control) this.button5);
      this.panel1.Controls.Add((Control) this.button3);
      this.panel1.Controls.Add((Control) this.kytBtn);
      this.panel1.Controls.Add((Control) this.button4);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1645, 97);
      this.panel1.TabIndex = 194;
      this.panel3.Controls.Add((Control) this.gridControl1);
      this.panel3.Dock = DockStyle.Fill;
      this.panel3.Location = new Point(0, 97);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(1645, 739);
      this.panel3.TabIndex = 195;
      this.per_liste.DataSetName = "per_liste";
      this.per_liste.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.per_liste;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(1645, 739);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[14]
      {
        this.colID,
        this.colDurum,
        this.colDurum1,
        this.colTCKIMLIKNO,
        this.colADISOYADI,
        this.colEGITIMDURUM,
        this.colUNVAN,
        this.colGOREVYERI,
        this.colCEPTELEFON,
        this.colPLAKA,
        this.colDOGUMTARIHI,
        this.colISEGIRISTARIHI,
        this.colSIRANO,
        this.colKURUMGOREV
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.per_liste;
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Visible = true;
      this.colID.VisibleIndex = 0;
      this.colID.Width = 94;
      this.colDurum.FieldName = "Durum";
      this.colDurum.MinWidth = 25;
      this.colDurum.Name = "colDurum";
      this.colDurum.Visible = true;
      this.colDurum.VisibleIndex = 1;
      this.colDurum.Width = 94;
      this.colDurum1.FieldName = "Durum1";
      this.colDurum1.MinWidth = 25;
      this.colDurum1.Name = "colDurum1";
      this.colDurum1.Visible = true;
      this.colDurum1.VisibleIndex = 2;
      this.colDurum1.Width = 94;
      this.colTCKIMLIKNO.FieldName = "TCKIMLIKNO";
      this.colTCKIMLIKNO.MinWidth = 25;
      this.colTCKIMLIKNO.Name = "colTCKIMLIKNO";
      this.colTCKIMLIKNO.Visible = true;
      this.colTCKIMLIKNO.VisibleIndex = 3;
      this.colTCKIMLIKNO.Width = 94;
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 25;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 4;
      this.colADISOYADI.Width = 94;
      this.colEGITIMDURUM.FieldName = "EGITIMDURUM";
      this.colEGITIMDURUM.MinWidth = 25;
      this.colEGITIMDURUM.Name = "colEGITIMDURUM";
      this.colEGITIMDURUM.Visible = true;
      this.colEGITIMDURUM.VisibleIndex = 5;
      this.colEGITIMDURUM.Width = 94;
      this.colUNVAN.FieldName = "UNVAN";
      this.colUNVAN.MinWidth = 25;
      this.colUNVAN.Name = "colUNVAN";
      this.colUNVAN.Visible = true;
      this.colUNVAN.VisibleIndex = 6;
      this.colUNVAN.Width = 94;
      this.colGOREVYERI.FieldName = "GOREVYERI";
      this.colGOREVYERI.MinWidth = 25;
      this.colGOREVYERI.Name = "colGOREVYERI";
      this.colGOREVYERI.Visible = true;
      this.colGOREVYERI.VisibleIndex = 7;
      this.colGOREVYERI.Width = 94;
      this.colCEPTELEFON.FieldName = "CEPTELEFON";
      this.colCEPTELEFON.MinWidth = 25;
      this.colCEPTELEFON.Name = "colCEPTELEFON";
      this.colCEPTELEFON.Visible = true;
      this.colCEPTELEFON.VisibleIndex = 8;
      this.colCEPTELEFON.Width = 94;
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 25;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 9;
      this.colPLAKA.Width = 94;
      this.colDOGUMTARIHI.FieldName = "DOGUMTARIHI";
      this.colDOGUMTARIHI.MinWidth = 25;
      this.colDOGUMTARIHI.Name = "colDOGUMTARIHI";
      this.colDOGUMTARIHI.Visible = true;
      this.colDOGUMTARIHI.VisibleIndex = 10;
      this.colDOGUMTARIHI.Width = 94;
      this.colISEGIRISTARIHI.FieldName = "ISEGIRISTARIHI";
      this.colISEGIRISTARIHI.MinWidth = 25;
      this.colISEGIRISTARIHI.Name = "colISEGIRISTARIHI";
      this.colISEGIRISTARIHI.Visible = true;
      this.colISEGIRISTARIHI.VisibleIndex = 11;
      this.colISEGIRISTARIHI.Width = 94;
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.MinWidth = 25;
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.Visible = true;
      this.colSIRANO.VisibleIndex = 12;
      this.colSIRANO.Width = 94;
      this.colKURUMGOREV.FieldName = "KURUMGOREV";
      this.colKURUMGOREV.MinWidth = 25;
      this.colKURUMGOREV.Name = "colKURUMGOREV";
      this.colKURUMGOREV.Visible = true;
      this.colKURUMGOREV.VisibleIndex = 13;
      this.colKURUMGOREV.Width = 94;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1651, 836);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel2);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Listele);
      this.Text = nameof (Listele);
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Listele_Load);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).EndInit();
      this.per_liste.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
