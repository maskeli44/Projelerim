// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.YagBolum.Ustalar2
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet5TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Properties;
using Makina_Ikmal.Sabitler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Makina_Ikmal.YagBolum
{
  public class Ustalar2 : XtraForm
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private SimpleButton simpleButton1;
    private SearchLookUpEdit searchLookUpEdit3;
    private GridView gridView3;
    private GridColumn gridColumn2;
    private SearchLookUpEdit searchLookUpEdit2;
    private GridView gridView2;
    private SearchLookUpEdit searchLookUpEdit1;
    private GridView searchLookUpEdit1View;
    private GridColumn ID;
    private GridColumn BOLUMADI;
    private bellDataSet5 bellDataSet5;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private GridColumn gridColumn1;
    private MemoEdit textEdit1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private SimpleButton simpleButton2;

    public Ustalar2() => this.InitializeComponent();

    private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
      int deger = Convert.ToInt32(this.searchLookUpEdit1.EditValue);
      this.searchLookUpEdit2.Properties.ValueMember = "ID";
      this.searchLookUpEdit2.Properties.DisplayMember = "USTAADISOYADI";
      this.searchLookUpEdit2.Properties.DataSource = (object) this.db.TBLATOLYEUSTALAR.Where<TBLATOLYEUSTALAR>((Expression<System.Func<TBLATOLYEUSTALAR, bool>>) (x => x.ATOLYEID == (int?) deger)).Select(x => new
      {
        ID = x.ID,
        USTAADISOYADI = x.USTAADISOYADI
      }).ToList();
    }

    private void Ustalar2_Load(object sender, EventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet5.TBLBAKIMGRUBU);
      this.searchLookUpEdit1.Properties.ValueMember = "ID";
      this.searchLookUpEdit1.Properties.DisplayMember = "BOLUMADI";
      this.searchLookUpEdit1.Properties.DataSource = (object) this.db.TBLATOLYEBOLUM.ToList<TBLATOLYEBOLUM>();
      this.searchLookUpEdit1.Properties.PopupFormSize = new Size(120, 300);
      this.searchLookUpEdit2.Properties.ValueMember = "ID";
      this.searchLookUpEdit2.Properties.DisplayMember = "USTAADISOYADI";
      this.searchLookUpEdit2.Properties.DataSource = (object) this.db.TBLATOLYEUSTALAR.ToList<TBLATOLYEUSTALAR>();
      this.searchLookUpEdit2.Properties.PopupFormSize = new Size(120, 300);
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      DegerAktarma degerAktarma = new DegerAktarma();
      DegerAktarma.list.Add(new Makina_Ikmal.Classlar.ElemanlarDurum()
      {
        ID = 0,
        ATOLYEID = this.searchLookUpEdit1.EditValue.ToString(),
        BAKIMYAPUSTAID = this.searchLookUpEdit2.EditValue.ToString(),
        BAKIMGRUBUID = this.searchLookUpEdit3.EditValue.ToString(),
        YAPILANBAKIM = this.textEdit1.Text
      });
      YagEmri yagEmri = new YagEmri();
      ((YagEmri) Application.OpenForms["YagEmri"])?.tetikle();
    }

    private void searchLookUpEdit3_EditValueChanged(object sender, EventArgs e)
    {
      try
      {
        int id = Convert.ToInt32(this.searchLookUpEdit3.EditValue);
        this.textEdit1.Text = this.db.TBLBAKIMTANIM.FirstOrDefault<TBLBAKIMTANIM>((Expression<System.Func<TBLBAKIMTANIM, bool>>) (x => x.BAKIMGRUBUID == (int?) id)).YAPILANBAKIM;
      }
      catch (Exception ex)
      {
      }
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      int num = (int) new AtolyeUstaEkle().ShowDialog();
      try
      {
        int deger = Convert.ToInt32(this.searchLookUpEdit1.EditValue);
        this.searchLookUpEdit2.Properties.ValueMember = "ID";
        this.searchLookUpEdit2.Properties.DisplayMember = "USTAADISOYADI";
        this.searchLookUpEdit2.Properties.DataSource = (object) this.db.TBLATOLYEUSTALAR.Where<TBLATOLYEUSTALAR>((Expression<System.Func<TBLATOLYEUSTALAR, bool>>) (x => x.ATOLYEID == (int?) deger)).Select(x => new
        {
          ID = x.ID,
          USTAADISOYADI = x.USTAADISOYADI
        }).ToList();
      }
      catch (Exception ex)
      {
      }
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
      this.simpleButton1 = new SimpleButton();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.bellDataSet5 = new bellDataSet5();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.simpleButton2 = new SimpleButton();
      this.searchLookUpEdit3 = new SearchLookUpEdit();
      this.gridView3 = new GridView();
      this.gridColumn2 = new GridColumn();
      this.searchLookUpEdit2 = new SearchLookUpEdit();
      this.gridView2 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.searchLookUpEdit1 = new SearchLookUpEdit();
      this.searchLookUpEdit1View = new GridView();
      this.ID = new GridColumn();
      this.BOLUMADI = new GridColumn();
      this.textEdit1 = new MemoEdit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.bellDataSet5.BeginInit();
      this.searchLookUpEdit3.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.searchLookUpEdit2.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.searchLookUpEdit1.Properties.BeginInit();
      this.searchLookUpEdit1View.BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.simpleButton1.Location = new Point(413, 19);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(94, 99);
      this.simpleButton1.TabIndex = 13;
      this.simpleButton1.Text = "Ekle";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.tBLBAKIMGRUBUBindingSource.DataSource = (object) this.bellDataSet5;
      this.bellDataSet5.DataSetName = "bellDataSet5";
      this.bellDataSet5.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label1.Location = new Point(16, 22);
      this.label1.Name = "label1";
      this.label1.Size = new Size(86, 20);
      this.label1.TabIndex = 15;
      this.label1.Text = "Bölüm Adı";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.Location = new Point(29, 58);
      this.label2.Name = "label2";
      this.label2.Size = new Size(73, 20);
      this.label2.TabIndex = 15;
      this.label2.Text = "Usta Adı";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.Location = new Point(7, 93);
      this.label3.Name = "label3";
      this.label3.Size = new Size(95, 20);
      this.label3.TabIndex = 15;
      this.label3.Text = "Bakım Türü";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.Location = new Point(21, 139);
      this.label4.Name = "label4";
      this.label4.Size = new Size(81, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "Yapılan İş";
      this.simpleButton2.ImageOptions.Image = (Image) Resources.add_16x1610;
      this.simpleButton2.Location = new Point(368, 54);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(26, 29);
      this.simpleButton2.TabIndex = 16;
      this.simpleButton2.Click += new EventHandler(this.simpleButton2_Click);
      this.searchLookUpEdit3.EditValue = (object) "";
      this.searchLookUpEdit3.Location = new Point(106, 89);
      this.searchLookUpEdit3.Name = "searchLookUpEdit3";
      this.searchLookUpEdit3.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit3.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit3.Properties.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.searchLookUpEdit3.Properties.DisplayMember = "GRUPADI";
      this.searchLookUpEdit3.Properties.NullText = "";
      this.searchLookUpEdit3.Properties.PopupView = (ColumnView) this.gridView3;
      this.searchLookUpEdit3.Properties.ValueMember = "ID";
      this.searchLookUpEdit3.Size = new Size(289, 30);
      this.searchLookUpEdit3.TabIndex = 10;
      this.searchLookUpEdit3.EditValueChanged += new EventHandler(this.searchLookUpEdit3_EditValueChanged);
      this.gridView3.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn2
      });
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gridColumn2.FieldName = "GRUPADI";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 0;
      this.searchLookUpEdit2.EditValue = (object) "";
      this.searchLookUpEdit2.Location = new Point(106, 53);
      this.searchLookUpEdit2.Name = "searchLookUpEdit2";
      this.searchLookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit2.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit2.Properties.NullText = "";
      this.searchLookUpEdit2.Properties.PopupView = (ColumnView) this.gridView2;
      this.searchLookUpEdit2.Size = new Size(256, 30);
      this.searchLookUpEdit2.TabIndex = 11;
      this.gridView2.Columns.AddRange(new GridColumn[1]
      {
        this.gridColumn1
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "Usta Adı Soyadı";
      this.gridColumn1.FieldName = "USTAADISOYADI";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.searchLookUpEdit1.EditValue = (object) "";
      this.searchLookUpEdit1.Location = new Point(106, 17);
      this.searchLookUpEdit1.Name = "searchLookUpEdit1";
      this.searchLookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.searchLookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.searchLookUpEdit1.Properties.DisplayMember = "ID";
      this.searchLookUpEdit1.Properties.NullText = "";
      this.searchLookUpEdit1.Properties.PopupView = (ColumnView) this.searchLookUpEdit1View;
      this.searchLookUpEdit1.Properties.ValueMember = "BOLUMADI";
      this.searchLookUpEdit1.Size = new Size(289, 30);
      this.searchLookUpEdit1.TabIndex = 12;
      this.searchLookUpEdit1.EditValueChanged += new EventHandler(this.searchLookUpEdit1_EditValueChanged);
      this.searchLookUpEdit1View.Columns.AddRange(new GridColumn[2]
      {
        this.ID,
        this.BOLUMADI
      });
      this.searchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 100;
      this.searchLookUpEdit1View.OptionsFind.SearchInPreview = true;
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.ID.Caption = "gridColumn1";
      this.ID.FieldName = "ID";
      this.ID.Name = "ID";
      this.BOLUMADI.Caption = "gridColumn1";
      this.BOLUMADI.FieldName = "BOLUMADI";
      this.BOLUMADI.Name = "BOLUMADI";
      this.BOLUMADI.Visible = true;
      this.BOLUMADI.VisibleIndex = 0;
      this.textEdit1.Location = new Point(106, 136);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.ScrollBars = ScrollBars.None;
      this.textEdit1.Size = new Size(401, 65);
      this.textEdit1.TabIndex = 14;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(516, 212);
      this.Controls.Add((Control) this.simpleButton2);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.simpleButton1);
      this.Controls.Add((Control) this.searchLookUpEdit3);
      this.Controls.Add((Control) this.searchLookUpEdit2);
      this.Controls.Add((Control) this.searchLookUpEdit1);
      this.Controls.Add((Control) this.textEdit1);
      this.Name = nameof (Ustalar2);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = nameof (Ustalar2);
      this.Load += new EventHandler(this.Ustalar2_Load);
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.bellDataSet5.EndInit();
      this.searchLookUpEdit3.Properties.EndInit();
      this.gridView3.EndInit();
      this.searchLookUpEdit2.Properties.EndInit();
      this.gridView2.EndInit();
      this.searchLookUpEdit1.Properties.EndInit();
      this.searchLookUpEdit1View.EndInit();
      this.textEdit1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
