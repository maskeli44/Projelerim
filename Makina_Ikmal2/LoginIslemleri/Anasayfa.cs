// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.LoginIslemleri.Anasayfa
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.insankaynak;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.LoginIslemleri
{
  public class Anasayfa : XtraForm
  {
    private YetkiClass yet = new YetkiClass();
    private IContainer components = (IContainer) null;
    private AccordionControl accordionControl1;
    private DocumentManager documentManager1;
    private TabbedView tabbedView1;
    private BarDockControl barDockControlLeft;
    private BarManager barManager1;
    private Bar bar1;
    private SkinDropDownButtonItem skinDropDownButtonItem1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlRight;
    private DefaultLookAndFeel defaultLookAndFeel1;
    private SkinBarSubItem skinBarSubItem1;
    private AccordionControlSeparator accordionControlSeparator1;
    private Bar bar3;
    private AccordionControlSeparator accordionControlSeparator3;
    private AccordionControlElement accordionControlElement1;
    private LabelControl girenkullanici_label;
    private TextEdit textEdit1;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet7 bellDataSet7;
    private BindingSource tBLKULLANICILARBindingSource;
    private TBLKULLANICILARTableAdapter tBLKULLANICILARTableAdapter;
    private GridColumn colID;
    private GridColumn colSIRANO;
    private GridColumn colTURU;
    private GridColumn colKULLANICIADI;
    private GridColumn colUNVANI;
    private GridColumn colGOREVYERI;
    private GridColumn gridColumn1;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private AccordionControlElement accordionControlElement2;

    public Anasayfa() => this.InitializeComponent();

    private void accordionControlElement2_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel Listesi"))
      {
        ilksayfa ilksayfa = new ilksayfa();
        ilksayfa.MdiParent = (Form) this;
        ilksayfa.Show();
      }
      else
      {
        int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
      }
    }

    private void accordionControlElement3_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("Personel İzin Listesi"))
        return;
      int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
    }

    private void BasDepo_Load(object sender, EventArgs e)
    {
      try
      {
        this.defaultLookAndFeel1.LookAndFeel.SkinName = Settings.Default.TemaSkin;
      }
      catch
      {
      }
      this.Yenile();
    }

    public void Yenile()
    {
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet7.TBLPERSONEL);
      this.tBLKULLANICILARTableAdapter.Fill(this.bellDataSet7.TBLKULLANICILAR);
      this.textEdit1.Text = "Sayın " + YetkiClass.kullanici_ad;
      if (!this.yet.MenuYetkilendirme("Personel Listesi"))
        return;
      ilksayfa ilksayfa = new ilksayfa();
      ilksayfa.MdiParent = (Form) this;
      ilksayfa.Show();
    }

    private void accordionControlElement4_Click(object sender, EventArgs e)
    {
      if (this.yet.MenuYetkilendirme("İzin Durum Listesi"))
        return;
      int num = (int) MessageBox.Show("Buraya giriş yetkiniz bulunmaktadır.");
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("PERSONELID"));
      YetkiClass.secim = "guncelle";
      int num = (int) new Guncelle().ShowDialog();
    }

    private void accordionControlElement2_Click_1(object sender, EventArgs e)
    {
      int num = (int) new KayitEkle().ShowDialog();
    }

    private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.TemaSkin = this.defaultLookAndFeel1.LookAndFeel.SkinName;
      Settings.Default.Save();
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
      this.accordionControl1 = new AccordionControl();
      this.accordionControlSeparator3 = new AccordionControlSeparator();
      this.accordionControlElement1 = new AccordionControlElement();
      this.accordionControlSeparator1 = new AccordionControlSeparator();
      this.accordionControlElement2 = new AccordionControlElement();
      this.documentManager1 = new DocumentManager(this.components);
      this.barManager1 = new BarManager(this.components);
      this.bar1 = new Bar();
      this.skinBarSubItem1 = new SkinBarSubItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.skinDropDownButtonItem1 = new SkinDropDownButtonItem();
      this.tabbedView1 = new TabbedView(this.components);
      this.defaultLookAndFeel1 = new DefaultLookAndFeel(this.components);
      this.bar3 = new Bar();
      this.girenkullanici_label = new LabelControl();
      this.textEdit1 = new TextEdit();
      this.gridControl1 = new GridControl();
      this.tBLKULLANICILARBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colSIRANO = new GridColumn();
      this.colTURU = new GridColumn();
      this.colKULLANICIADI = new GridColumn();
      this.colUNVANI = new GridColumn();
      this.colGOREVYERI = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.tBLKULLANICILARTableAdapter = new TBLKULLANICILARTableAdapter();
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.accordionControl1.BeginInit();
      ((ISupportInitialize) this.documentManager1).BeginInit();
      this.barManager1.BeginInit();
      ((ISupportInitialize) this.tabbedView1).BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLKULLANICILARBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.SuspendLayout();
      this.accordionControl1.Dock = DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new AccordionControlElement[4]
      {
        (AccordionControlElement) this.accordionControlSeparator3,
        this.accordionControlElement1,
        (AccordionControlElement) this.accordionControlSeparator1,
        this.accordionControlElement2
      });
      this.accordionControl1.Location = new Point(0, 22);
      this.accordionControl1.Margin = new Padding(3, 2, 3, 2);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = ScrollBarMode.Fluent;
      this.accordionControl1.Size = new Size(206, 514);
      this.accordionControl1.TabIndex = 5;
      this.accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
      this.accordionControlSeparator3.Name = "accordionControlSeparator3";
      this.accordionControlElement1.ImageOptions.Image = (Image) Resources.ık64;
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = ElementStyle.Item;
      this.accordionControlElement1.Text = "  MAKİNE İKMAL ŞUBE MÜDÜRLÜĞÜ";
      this.accordionControlSeparator1.Name = "accordionControlSeparator1";
      this.accordionControlElement2.ImageOptions.Image = (Image) Resources.employee_32x322;
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Style = ElementStyle.Item;
      this.accordionControlElement2.Text = "Kullanıcı Kayıt";
      this.accordionControlElement2.Click += new EventHandler(this.accordionControlElement2_Click_1);
      this.documentManager1.MdiParent = (Form) this;
      this.documentManager1.MenuManager = (IDXMenuManager) this.barManager1;
      this.documentManager1.View = (DevExpress.XtraBars.Docking2010.Views.BaseView) this.tabbedView1;
      this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[1]
      {
        (DevExpress.XtraBars.Docking2010.Views.BaseView) this.tabbedView1
      });
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar1 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[2]
      {
        (BarItem) this.skinDropDownButtonItem1,
        (BarItem) this.skinBarSubItem1
      });
      this.barManager1.MaxItemId = 2;
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[1]
      {
        new LinkPersistInfo((BarItem) this.skinBarSubItem1)
      });
      this.bar1.Text = "Tools";
      this.skinBarSubItem1.Caption = "Temalar";
      this.skinBarSubItem1.Id = 1;
      this.skinBarSubItem1.Name = "skinBarSubItem1";
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlTop.Size = new Size(1033, 22);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 536);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlBottom.Size = new Size(1033, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 22);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlLeft.Size = new Size(0, 514);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1033, 22);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(3, 2, 3, 2);
      this.barDockControlRight.Size = new Size(0, 514);
      this.skinDropDownButtonItem1.Id = 0;
      this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
      this.skinDropDownButtonItem1.PaintStyle = BarItemPaintStyle.CaptionInMenu;
      this.defaultLookAndFeel1.EnableBonusSkins = true;
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Dark Gray";
      this.bar3.BarName = "Status bar";
      this.bar3.CanDockStyle = BarCanDockStyle.Bottom;
      this.bar3.DockCol = 0;
      this.bar3.DockRow = 0;
      this.bar3.DockStyle = BarDockStyle.Bottom;
      this.bar3.OptionsBar.AllowQuickCustomization = false;
      this.bar3.OptionsBar.DrawDragBorder = false;
      this.bar3.OptionsBar.UseWholeRow = true;
      this.bar3.Text = "Status bar";
      this.girenkullanici_label.Appearance.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.girenkullanici_label.Appearance.ForeColor = Color.Blue;
      this.girenkullanici_label.Appearance.Options.UseFont = true;
      this.girenkullanici_label.Appearance.Options.UseForeColor = true;
      this.girenkullanici_label.Location = new Point(370, 5);
      this.girenkullanici_label.Margin = new Padding(3, 2, 3, 2);
      this.girenkullanici_label.Name = "girenkullanici_label";
      this.girenkullanici_label.Size = new Size(0, 17);
      this.girenkullanici_label.TabIndex = 10;
      this.textEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textEdit1.Enabled = false;
      this.textEdit1.Location = new Point(780, 1);
      this.textEdit1.Margin = new Padding(3, 2, 3, 2);
      this.textEdit1.MenuManager = (IDXMenuManager) this.barManager1;
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 10.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
      this.textEdit1.Size = new Size(243, 22);
      this.textEdit1.TabIndex = 11;
      this.gridControl1.DataSource = (object) this.tBLKULLANICILARBindingSource;
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(206, 22);
      this.gridControl1.MainView = (DevExpress.XtraGrid.Views.Base.BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(827, 514);
      this.gridControl1.TabIndex = 16;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1]
      {
        (DevExpress.XtraGrid.Views.Base.BaseView) this.gridView1
      });
      this.tBLKULLANICILARBindingSource.DataMember = "TBLKULLANICILAR";
      this.tBLKULLANICILARBindingSource.DataSource = (object) this.bellDataSet7;
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Appearance.Row.BackColor = SystemColors.ActiveCaption;
      this.gridView1.Appearance.Row.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[7]
      {
        this.colID,
        this.colSIRANO,
        this.colTURU,
        this.colKULLANICIADI,
        this.colUNVANI,
        this.colGOREVYERI,
        this.gridColumn1
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.gridView1.RowHeight = 24;
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 21;
      this.colID.Name = "colID";
      this.colID.OptionsColumn.AllowEdit = false;
      this.colID.OptionsColumn.ReadOnly = true;
      this.colID.Width = 81;
      this.colSIRANO.Caption = "Sıra No";
      this.colSIRANO.FieldName = "SIRANO";
      this.colSIRANO.MinWidth = 21;
      this.colSIRANO.Name = "colSIRANO";
      this.colSIRANO.OptionsColumn.AllowEdit = false;
      this.colSIRANO.OptionsColumn.ReadOnly = true;
      this.colSIRANO.Width = 81;
      this.colTURU.Caption = "Türü";
      this.colTURU.FieldName = "TURU";
      this.colTURU.MinWidth = 21;
      this.colTURU.Name = "colTURU";
      this.colTURU.OptionsColumn.AllowEdit = false;
      this.colTURU.OptionsColumn.ReadOnly = true;
      this.colTURU.Width = 81;
      this.colKULLANICIADI.Caption = "Kullanıcı Adı";
      this.colKULLANICIADI.FieldName = "KULLANICIADI";
      this.colKULLANICIADI.MinWidth = 21;
      this.colKULLANICIADI.Name = "colKULLANICIADI";
      this.colKULLANICIADI.OptionsColumn.AllowEdit = false;
      this.colKULLANICIADI.OptionsColumn.ReadOnly = true;
      this.colKULLANICIADI.Visible = true;
      this.colKULLANICIADI.VisibleIndex = 0;
      this.colKULLANICIADI.Width = 81;
      this.colUNVANI.Caption = "Ünvanı";
      this.colUNVANI.FieldName = "UNVANI";
      this.colUNVANI.MinWidth = 21;
      this.colUNVANI.Name = "colUNVANI";
      this.colUNVANI.OptionsColumn.AllowEdit = false;
      this.colUNVANI.OptionsColumn.ReadOnly = true;
      this.colUNVANI.Visible = true;
      this.colUNVANI.VisibleIndex = 1;
      this.colUNVANI.Width = 81;
      this.colGOREVYERI.Caption = "Görev Yeri";
      this.colGOREVYERI.FieldName = "GOREVYERI";
      this.colGOREVYERI.MinWidth = 21;
      this.colGOREVYERI.Name = "colGOREVYERI";
      this.colGOREVYERI.OptionsColumn.AllowEdit = false;
      this.colGOREVYERI.OptionsColumn.ReadOnly = true;
      this.colGOREVYERI.Visible = true;
      this.colGOREVYERI.VisibleIndex = 2;
      this.colGOREVYERI.Width = 81;
      this.gridColumn1.Caption = "Adı Soyadı";
      this.gridColumn1.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.gridColumn1.FieldName = "PERSONELID";
      this.gridColumn1.MinWidth = 21;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 3;
      this.gridColumn1.Width = 81;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADISOYADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet7;
      this.tBLKULLANICILARTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1033, 536);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.textEdit1);
      this.Controls.Add((Control) this.girenkullanici_label);
      this.Controls.Add((Control) this.accordionControl1);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.IsMdiContainer = true;
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (Anasayfa);
      this.Text = "Kullanıcı Yetkilendirme";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosed += new FormClosedEventHandler(this.Anasayfa_FormClosed);
      this.Load += new EventHandler(this.BasDepo_Load);
      this.accordionControl1.EndInit();
      ((ISupportInitialize) this.documentManager1).EndInit();
      this.barManager1.EndInit();
      ((ISupportInitialize) this.tabbedView1).EndInit();
      this.textEdit1.Properties.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLKULLANICILARBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
