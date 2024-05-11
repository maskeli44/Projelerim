// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.InsanKaynaklari.izindeOlanListesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using ADGV;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.izinListesiTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.InsanKaynaklari
{
  public class izindeOlanListesi : Form
  {
    private YetkiClass yet = new YetkiClass();
    private bellEntities db = new bellEntities();
    private int secim_id;
    private IContainer components = (IContainer) null;
    private Button button5;
    private ImageList ımageList1;
    private Button kytBtn;
    private Button button4;
    private Button button2;
    private AdvancedDataGridView advancedDataGridView1;
    private Panel panel3;
    private Panel panel1;
    private Button button3;
    private Panel panel2;
    private Button button1;
    private izinListesi izinListesi;
    private BindingSource dataTable2BindingSource;
    private DataTable2TableAdapter dataTable2TableAdapter;
    private DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
    private DataGridViewImageColumn tBLPERSONELRESIM2DataGridViewImageColumn;
    private DataGridViewTextBoxColumn aDISOYADIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINTURUDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINYILLARIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINSURESIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bASLANGICTARIHIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bASLANGICSAATIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bITISTARIHIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bITISSAATIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINGUNSAYDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gOREVEBASTARIHDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINDEBULADRESDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn oNAYTARIHDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ıZINDURUMDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn gOREVYERIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn uNVANDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn kURUMGOREVDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn bELDBIRIMADIDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;

    public izindeOlanListesi() => this.InitializeComponent();

    private void izindeOlanListesi_Load(object sender, EventArgs e)
    {
      this.dataTable2TableAdapter.Fill(this.izinListesi.DataTable2);
      this.dataTable2TableAdapter.Fill(this.izinListesi.DataTable2);
      this.listele();
      this.secim_id = Convert.ToInt32(this.advancedDataGridView1.Rows[0].Cells[0].Value);
    }

    private void listele() => this.dataTable2TableAdapter.Fill(this.izinListesi.DataTable2);

    private void kytBtn_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.EkleYetki == 1)
      {
        int num1 = (int) new PersonelIzinFormu().ShowDialog();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) new PersonelizinFormuYazdir()
      {
        yazdir_id = this.secim_id
      }.ShowDialog();
    }

    private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) => this.secim_id = Convert.ToInt32(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.GuncelleYetki == 1)
      {
        int int32 = Convert.ToInt32(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = int32;
        int num = (int) new PersonelIzinFormu().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void advancedDataGridView1_DoubleClick(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.GuncelleYetki == 1)
      {
        int int16 = (int) Convert.ToInt16(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);
        YetkiClass.secim = "guncelle";
        YetkiClass.secim_id = int16;
        int num = (int) new PersonelIzinFormu().ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi") && YetkiClass.SilYetki == 1)
      {
        this.silfonk();
        this.listele();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void silfonk()
    {
      TBLPERSONELIZIN entity = this.db.TBLPERSONELIZIN.FirstOrDefault<TBLPERSONELIZIN>((Expression<System.Func<TBLPERSONELIZIN, bool>>) (x => x.ID == YetkiClass.secim_id));
      new TextBox().Text = entity.IZINYILLARI.ToString();
      string[] strArray = entity.IZINYILLARI.Split(',');
      int per_id = Convert.ToInt32((object) entity.PERSID);
      int int32_1 = Convert.ToInt32(entity.IZINGUNSAY);
      foreach (string str in strArray)
      {
        int degeryil = Convert.ToInt32(str);
        IQueryable<TBLPERSIZINDURUM> source = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) per_id));
        Expression<System.Func<TBLPERSIZINDURUM, bool>> predicate = (Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.IZINYILI == (int?) degeryil);
        foreach (TBLPERSIZINDURUM tblpersizindurum1 in (IEnumerable<TBLPERSIZINDURUM>) source.Where<TBLPERSIZINDURUM>(predicate))
        {
          try
          {
            int int32_2 = Convert.ToInt32((object) tblpersizindurum1.IZINHAKKI);
            int int32_3 = Convert.ToInt32((object) tblpersizindurum1.KULLANILANIZIN);
            if (int32_2 == int32_3 && int32_3 < int32_1)
            {
              int32_1 -= int32_2;
              tblpersizindurum1.KULLANILANIZIN = new int?(0);
              int? nullable1 = tblpersizindurum1.KULLANILANIZIN;
              int num = 0;
              if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
              {
                TBLPERSIZINDURUM tblpersizindurum2 = tblpersizindurum1;
                nullable1 = new int?();
                int? nullable2 = nullable1;
                tblpersizindurum2.PERSONELIZINID = nullable2;
              }
            }
            else
            {
              tblpersizindurum1.KULLANILANIZIN = new int?(int32_3 - int32_1);
              int32_1 -= int32_3;
              int? nullable3 = tblpersizindurum1.KULLANILANIZIN;
              int num = 0;
              if (nullable3.GetValueOrDefault() == num & nullable3.HasValue)
              {
                TBLPERSIZINDURUM tblpersizindurum3 = tblpersizindurum1;
                nullable3 = new int?();
                int? nullable4 = nullable3;
                tblpersizindurum3.PERSONELIZINID = nullable4;
              }
            }
          }
          catch (DbEntityValidationException ex)
          {
            Exception innerException = (Exception) ex;
            foreach (DbEntityValidationResult entityValidationError in ex.EntityValidationErrors)
            {
              foreach (DbValidationError validationError in (IEnumerable<DbValidationError>) entityValidationError.ValidationErrors)
                innerException = (Exception) new InvalidOperationException(string.Format("{0}:{1}", (object) entityValidationError.Entry.Entity.ToString(), (object) validationError.ErrorMessage), innerException);
            }
            throw innerException;
          }
        }
      }
      this.db.TBLPERSONELIZIN.Remove(entity);
      this.db.SaveChanges();
      int num1 = (int) MessageBox.Show("İşlem gerekçleşti");
    }

    private void advancedDataGridView1_Click(object sender, EventArgs e)
    {
      this.secim_id = Convert.ToInt32(this.advancedDataGridView1.Rows[this.advancedDataGridView1.CurrentRow.Index].Cells[0].Value);
      YetkiClass.secim_id = this.secim_id;
    }

    private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e) => this.dataTable2BindingSource.Sort = this.advancedDataGridView1.SortString;

    private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e) => this.dataTable2BindingSource.Filter = this.advancedDataGridView1.FilterString;

    private void button4_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (izindeOlanListesi));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.ımageList1 = new ImageList(this.components);
      this.advancedDataGridView1 = new AdvancedDataGridView();
      this.dataTable2BindingSource = new BindingSource(this.components);
      this.izinListesi = new izinListesi();
      this.panel3 = new Panel();
      this.panel1 = new Panel();
      this.button1 = new Button();
      this.button5 = new Button();
      this.button3 = new Button();
      this.kytBtn = new Button();
      this.button4 = new Button();
      this.button2 = new Button();
      this.panel2 = new Panel();
      this.dataTable2TableAdapter = new DataTable2TableAdapter();
      this.ıDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.tBLPERSONELRESIM2DataGridViewImageColumn = new DataGridViewImageColumn();
      this.aDISOYADIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINTURUDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINYILLARIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINSURESIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bASLANGICTARIHIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bASLANGICSAATIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bITISTARIHIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bITISSAATIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINGUNSAYDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gOREVEBASTARIHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINDEBULADRESDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.oNAYTARIHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.ıZINDURUMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.gOREVYERIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.uNVANDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.kURUMGOREVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.bELDBIRIMADIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.expr1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.expr2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      this.expr3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.advancedDataGridView1).BeginInit();
      ((ISupportInitialize) this.dataTable2BindingSource).BeginInit();
      this.izinListesi.BeginInit();
      this.panel3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
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
      gridViewCellStyle1.BackColor = Color.Silver;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.advancedDataGridView1.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.advancedDataGridView1.AutoGenerateColumns = false;
      this.advancedDataGridView1.AutoGenerateContextFilters = true;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      this.advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.advancedDataGridView1.Columns.AddRange((DataGridViewColumn) this.ıDDataGridViewTextBoxColumn, (DataGridViewColumn) this.tBLPERSONELRESIM2DataGridViewImageColumn, (DataGridViewColumn) this.aDISOYADIDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINTURUDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINYILLARIDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINSURESIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bASLANGICTARIHIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bASLANGICSAATIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bITISTARIHIDataGridViewTextBoxColumn, (DataGridViewColumn) this.bITISSAATIDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINGUNSAYDataGridViewTextBoxColumn, (DataGridViewColumn) this.gOREVEBASTARIHDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINDEBULADRESDataGridViewTextBoxColumn, (DataGridViewColumn) this.oNAYTARIHDataGridViewTextBoxColumn, (DataGridViewColumn) this.ıZINDURUMDataGridViewTextBoxColumn, (DataGridViewColumn) this.gOREVYERIDataGridViewTextBoxColumn, (DataGridViewColumn) this.uNVANDataGridViewTextBoxColumn, (DataGridViewColumn) this.kURUMGOREVDataGridViewTextBoxColumn, (DataGridViewColumn) this.bELDBIRIMADIDataGridViewTextBoxColumn, (DataGridViewColumn) this.expr1DataGridViewTextBoxColumn, (DataGridViewColumn) this.expr2DataGridViewTextBoxColumn, (DataGridViewColumn) this.expr3DataGridViewTextBoxColumn);
      this.advancedDataGridView1.DataSource = (object) this.dataTable2BindingSource;
      this.advancedDataGridView1.DateWithTime = false;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.advancedDataGridView1.DefaultCellStyle = gridViewCellStyle3;
      this.advancedDataGridView1.Dock = DockStyle.Fill;
      this.advancedDataGridView1.Location = new Point(0, 0);
      this.advancedDataGridView1.Name = "advancedDataGridView1";
      this.advancedDataGridView1.ReadOnly = true;
      this.advancedDataGridView1.RowHeadersVisible = false;
      this.advancedDataGridView1.RowTemplate.Height = 80;
      this.advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.advancedDataGridView1.Size = new Size(1142, 664);
      this.advancedDataGridView1.TabIndex = 194;
      this.advancedDataGridView1.TimeFilter = false;
      this.advancedDataGridView1.SortStringChanged += new EventHandler(this.advancedDataGridView1_SortStringChanged);
      this.advancedDataGridView1.FilterStringChanged += new EventHandler(this.advancedDataGridView1_FilterStringChanged);
      this.advancedDataGridView1.CellClick += new DataGridViewCellEventHandler(this.advancedDataGridView1_CellClick);
      this.advancedDataGridView1.Click += new EventHandler(this.advancedDataGridView1_Click);
      this.advancedDataGridView1.DoubleClick += new EventHandler(this.advancedDataGridView1_DoubleClick);
      this.dataTable2BindingSource.DataMember = "DataTable2";
      this.dataTable2BindingSource.DataSource = (object) this.izinListesi;
      this.izinListesi.DataSetName = "izinListesi";
      this.izinListesi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.panel3.Controls.Add((Control) this.advancedDataGridView1);
      this.panel3.Dock = DockStyle.Fill;
      this.panel3.Location = new Point(0, 75);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(1142, 664);
      this.panel3.TabIndex = 198;
      this.panel1.BackColor = Color.FromArgb(0, 134, 138);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.button5);
      this.panel1.Controls.Add((Control) this.button3);
      this.panel1.Controls.Add((Control) this.kytBtn);
      this.panel1.Controls.Add((Control) this.button4);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1142, 75);
      this.panel1.TabIndex = 197;
      this.button1.BackColor = Color.Transparent;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button1.ForeColor = Color.White;
      this.button1.ImageAlign = ContentAlignment.TopCenter;
      this.button1.ImageKey = "Actualiser.png";
      this.button1.ImageList = this.ımageList1;
      this.button1.Location = new Point(684, 8);
      this.button1.Name = "button1";
      this.button1.Size = new Size(124, 73);
      this.button1.TabIndex = 190;
      this.button1.Text = "Rapor";
      this.button1.TextAlign = ContentAlignment.BottomCenter;
      this.button1.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
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
      this.button4.Location = new Point(1047, 0);
      this.button4.Name = "button4";
      this.button4.Size = new Size(88, 76);
      this.button4.TabIndex = 187;
      this.button4.Text = "Kapat";
      this.button4.TextAlign = ContentAlignment.BottomCenter;
      this.button4.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
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
      this.panel2.BackColor = Color.SteelBlue;
      this.panel2.Dock = DockStyle.Right;
      this.panel2.Location = new Point(1142, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(6, 739);
      this.panel2.TabIndex = 196;
      this.dataTable2TableAdapter.ClearBeforeFill = true;
      this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
      this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.ıDDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
      this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıDDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıDDataGridViewTextBoxColumn.Visible = false;
      this.tBLPERSONELRESIM2DataGridViewImageColumn.DataPropertyName = "TBLPERSONEL_RESIM2";
      this.tBLPERSONELRESIM2DataGridViewImageColumn.HeaderText = "TBLPERSONEL_RESIM2";
      this.tBLPERSONELRESIM2DataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
      this.tBLPERSONELRESIM2DataGridViewImageColumn.MinimumWidth = 22;
      this.tBLPERSONELRESIM2DataGridViewImageColumn.Name = "tBLPERSONELRESIM2DataGridViewImageColumn";
      this.tBLPERSONELRESIM2DataGridViewImageColumn.ReadOnly = true;
      this.tBLPERSONELRESIM2DataGridViewImageColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.aDISOYADIDataGridViewTextBoxColumn.DataPropertyName = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.HeaderText = "ADISOYADI";
      this.aDISOYADIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.aDISOYADIDataGridViewTextBoxColumn.Name = "aDISOYADIDataGridViewTextBoxColumn";
      this.aDISOYADIDataGridViewTextBoxColumn.ReadOnly = true;
      this.aDISOYADIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINTURUDataGridViewTextBoxColumn.DataPropertyName = "IZINTURU";
      this.ıZINTURUDataGridViewTextBoxColumn.HeaderText = "IZINTURU";
      this.ıZINTURUDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINTURUDataGridViewTextBoxColumn.Name = "ıZINTURUDataGridViewTextBoxColumn";
      this.ıZINTURUDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINTURUDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINYILLARIDataGridViewTextBoxColumn.DataPropertyName = "IZINYILLARI";
      this.ıZINYILLARIDataGridViewTextBoxColumn.HeaderText = "IZINYILLARI";
      this.ıZINYILLARIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINYILLARIDataGridViewTextBoxColumn.Name = "ıZINYILLARIDataGridViewTextBoxColumn";
      this.ıZINYILLARIDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINYILLARIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINSURESIDataGridViewTextBoxColumn.DataPropertyName = "IZINSURESI";
      this.ıZINSURESIDataGridViewTextBoxColumn.HeaderText = "IZINSURESI";
      this.ıZINSURESIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINSURESIDataGridViewTextBoxColumn.Name = "ıZINSURESIDataGridViewTextBoxColumn";
      this.ıZINSURESIDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINSURESIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.DataPropertyName = "BASLANGICTARIHI";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.HeaderText = "BASLANGICTARIHI";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.Name = "bASLANGICTARIHIDataGridViewTextBoxColumn";
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bASLANGICTARIHIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bASLANGICSAATIDataGridViewTextBoxColumn.DataPropertyName = "BASLANGICSAATI";
      this.bASLANGICSAATIDataGridViewTextBoxColumn.HeaderText = "BASLANGICSAATI";
      this.bASLANGICSAATIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bASLANGICSAATIDataGridViewTextBoxColumn.Name = "bASLANGICSAATIDataGridViewTextBoxColumn";
      this.bASLANGICSAATIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bASLANGICSAATIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bITISTARIHIDataGridViewTextBoxColumn.DataPropertyName = "BITISTARIHI";
      this.bITISTARIHIDataGridViewTextBoxColumn.HeaderText = "BITISTARIHI";
      this.bITISTARIHIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bITISTARIHIDataGridViewTextBoxColumn.Name = "bITISTARIHIDataGridViewTextBoxColumn";
      this.bITISTARIHIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bITISTARIHIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bITISSAATIDataGridViewTextBoxColumn.DataPropertyName = "BITISSAATI";
      this.bITISSAATIDataGridViewTextBoxColumn.HeaderText = "BITISSAATI";
      this.bITISSAATIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bITISSAATIDataGridViewTextBoxColumn.Name = "bITISSAATIDataGridViewTextBoxColumn";
      this.bITISSAATIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bITISSAATIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.DataPropertyName = "IZINGUNSAY";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.HeaderText = "IZINGUNSAY";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.Name = "ıZINGUNSAYDataGridViewTextBoxColumn";
      this.ıZINGUNSAYDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINGUNSAYDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.DataPropertyName = "GOREVEBASTARIH";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.HeaderText = "GOREVEBASTARIH";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.Name = "gOREVEBASTARIHDataGridViewTextBoxColumn";
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.ReadOnly = true;
      this.gOREVEBASTARIHDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.DataPropertyName = "IZINDEBULADRES";
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.HeaderText = "IZINDEBULADRES";
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.Name = "ıZINDEBULADRESDataGridViewTextBoxColumn";
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINDEBULADRESDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.oNAYTARIHDataGridViewTextBoxColumn.DataPropertyName = "ONAYTARIH";
      this.oNAYTARIHDataGridViewTextBoxColumn.HeaderText = "ONAYTARIH";
      this.oNAYTARIHDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.oNAYTARIHDataGridViewTextBoxColumn.Name = "oNAYTARIHDataGridViewTextBoxColumn";
      this.oNAYTARIHDataGridViewTextBoxColumn.ReadOnly = true;
      this.oNAYTARIHDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.ıZINDURUMDataGridViewTextBoxColumn.DataPropertyName = "IZINDURUM";
      this.ıZINDURUMDataGridViewTextBoxColumn.HeaderText = "IZINDURUM";
      this.ıZINDURUMDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.ıZINDURUMDataGridViewTextBoxColumn.Name = "ıZINDURUMDataGridViewTextBoxColumn";
      this.ıZINDURUMDataGridViewTextBoxColumn.ReadOnly = true;
      this.ıZINDURUMDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.gOREVYERIDataGridViewTextBoxColumn.DataPropertyName = "GOREVYERI";
      this.gOREVYERIDataGridViewTextBoxColumn.HeaderText = "GOREVYERI";
      this.gOREVYERIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.gOREVYERIDataGridViewTextBoxColumn.Name = "gOREVYERIDataGridViewTextBoxColumn";
      this.gOREVYERIDataGridViewTextBoxColumn.ReadOnly = true;
      this.gOREVYERIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.uNVANDataGridViewTextBoxColumn.DataPropertyName = "UNVAN";
      this.uNVANDataGridViewTextBoxColumn.HeaderText = "UNVAN";
      this.uNVANDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.uNVANDataGridViewTextBoxColumn.Name = "uNVANDataGridViewTextBoxColumn";
      this.uNVANDataGridViewTextBoxColumn.ReadOnly = true;
      this.uNVANDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.kURUMGOREVDataGridViewTextBoxColumn.DataPropertyName = "KURUMGOREV";
      this.kURUMGOREVDataGridViewTextBoxColumn.HeaderText = "KURUMGOREV";
      this.kURUMGOREVDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.kURUMGOREVDataGridViewTextBoxColumn.Name = "kURUMGOREVDataGridViewTextBoxColumn";
      this.kURUMGOREVDataGridViewTextBoxColumn.ReadOnly = true;
      this.kURUMGOREVDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.bELDBIRIMADIDataGridViewTextBoxColumn.DataPropertyName = "BELDBIRIMADI";
      this.bELDBIRIMADIDataGridViewTextBoxColumn.HeaderText = "BELDBIRIMADI";
      this.bELDBIRIMADIDataGridViewTextBoxColumn.MinimumWidth = 22;
      this.bELDBIRIMADIDataGridViewTextBoxColumn.Name = "bELDBIRIMADIDataGridViewTextBoxColumn";
      this.bELDBIRIMADIDataGridViewTextBoxColumn.ReadOnly = true;
      this.bELDBIRIMADIDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
      this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
      this.expr1DataGridViewTextBoxColumn.MinimumWidth = 22;
      this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
      this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
      this.expr1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
      this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
      this.expr2DataGridViewTextBoxColumn.MinimumWidth = 22;
      this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
      this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
      this.expr2DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
      this.expr3DataGridViewTextBoxColumn.HeaderText = "Expr3";
      this.expr3DataGridViewTextBoxColumn.MinimumWidth = 22;
      this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
      this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
      this.expr3DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1148, 739);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel2);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (izindeOlanListesi);
      this.Text = nameof (izindeOlanListesi);
      this.Load += new EventHandler(this.izindeOlanListesi_Load);
      ((ISupportInitialize) this.advancedDataGridView1).EndInit();
      ((ISupportInitialize) this.dataTable2BindingSource).EndInit();
      this.izinListesi.EndInit();
      this.panel3.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
