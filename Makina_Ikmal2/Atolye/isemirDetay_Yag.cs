// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.isemirDetay_Yag
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Makina_Ikmal.bellDataSet7TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.isemirmalzemeTableAdapters;
using Makina_Ikmal.Model.ModelYag;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Makina_Ikmal.Atolye
{
  public class isemirDetay_Yag : XtraForm
  {
    private IContainer components = (IContainer) null;
    private GridControl gridControl1;
    private GridView gridView1;
    private BindingSource dataTable2BindingSource;
    private isemirmalzeme isemirmalzeme;
    private DataTable2TableAdapter dataTable2TableAdapter;
    private BindingSource dataTable1BindingSource;
    private isemribakimyapanustalar isemribakimyapanustalar;
    private Makina_Ikmal.Model.isemribakimyapanustalarTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private RepositoryItemLookUpEdit bakimlar;
    private RepositoryItemLookUpEdit ustalar;
    private BindingSource tBLATOLYEUSTALARBindingSource;
    private TBLATOLYEUSTALARTableAdapter tBLATOLYEUSTALARTableAdapter;
    private BindingSource tBLBAKIMGRUBUBindingSource;
    private TBLBAKIMGRUBUTableAdapter tBLBAKIMGRUBUTableAdapter;
    private GridColumn colBOLUMADI;
    private GridColumn colUSTAADISOYADI;
    private GridColumn colGRUPADI;
    private GridColumn colYAPILANBAKIM;
    private GridColumn colISEMRIID;
    private GridColumn colATOLYEID;
    private GridColumn colBAKIMYAPUSTAID;
    private GridColumn colBAKIMGRUBUID;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridColumn gridColumn1;
    private GridColumn KOD;
    private GridColumn colMIKTAR;
    private GridColumn colFIYAT;
    private GridColumn colTUTAR;
    private GridColumn TARIH;
    private GridColumn colMALZEMEADI;
    private GridColumn colBIRIMADI;
    private BindingSource dataTable1BindingSource1;
    private YagDepoHrkt yagDepoHrkt;
    private Makina_Ikmal.Model.ModelYag.YagDepoHrktTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    private TBLMALZBIRIMTableAdapter tBLMALZBIRIMTableAdapter;
    private BindingSource tBLMALZBIRIMBindingSource;
    private TBLMALZEMELERTableAdapter tBLMALZEMELERTableAdapter;
    private BindingSource tBLMALZEMELERBindingSource;
    private bellDataSet7 bellDataSet7;

    public isemirDetay_Yag() => this.InitializeComponent();

    private void isemirDetay_Load(object sender, EventArgs e)
    {
      this.tBLBAKIMGRUBUTableAdapter.Fill(this.bellDataSet7.TBLBAKIMGRUBU);
      this.tBLATOLYEUSTALARTableAdapter.Fill(this.bellDataSet7.TBLATOLYEUSTALAR);
      this.dataTable1TableAdapter1.Fill(this.yagDepoHrkt.DataTable1, new int?(YetkiClass.secim_id));
      this.dataTable1TableAdapter.Fill(this.isemribakimyapanustalar.DataTable1, new int?(YetkiClass.secim_id));
    }

    private void gridView2_CustomColumnDisplayText(
      object sender,
      CustomColumnDisplayTextEventArgs e)
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
      this.gridControl1 = new GridControl();
      this.dataTable1BindingSource = new BindingSource(this.components);
      this.isemribakimyapanustalar = new isemribakimyapanustalar();
      this.gridView1 = new GridView();
      this.colBOLUMADI = new GridColumn();
      this.colUSTAADISOYADI = new GridColumn();
      this.colGRUPADI = new GridColumn();
      this.colYAPILANBAKIM = new GridColumn();
      this.colISEMRIID = new GridColumn();
      this.colATOLYEID = new GridColumn();
      this.colBAKIMYAPUSTAID = new GridColumn();
      this.colBAKIMGRUBUID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.bakimlar = new RepositoryItemLookUpEdit();
      this.tBLBAKIMGRUBUBindingSource = new BindingSource(this.components);
      this.ustalar = new RepositoryItemLookUpEdit();
      this.tBLATOLYEUSTALARBindingSource = new BindingSource(this.components);
      this.dataTable2BindingSource = new BindingSource(this.components);
      this.isemirmalzeme = new isemirmalzeme();
      this.dataTable2TableAdapter = new DataTable2TableAdapter();
      this.dataTable1TableAdapter = new Makina_Ikmal.Model.isemribakimyapanustalarTableAdapters.DataTable1TableAdapter();
      this.tBLATOLYEUSTALARTableAdapter = new TBLATOLYEUSTALARTableAdapter();
      this.tBLBAKIMGRUBUTableAdapter = new TBLBAKIMGRUBUTableAdapter();
      this.gridControl2 = new GridControl();
      this.dataTable1BindingSource1 = new BindingSource(this.components);
      this.yagDepoHrkt = new YagDepoHrkt();
      this.gridView2 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.KOD = new GridColumn();
      this.colMIKTAR = new GridColumn();
      this.colFIYAT = new GridColumn();
      this.colTUTAR = new GridColumn();
      this.TARIH = new GridColumn();
      this.colMALZEMEADI = new GridColumn();
      this.colBIRIMADI = new GridColumn();
      this.dataTable1TableAdapter1 = new Makina_Ikmal.Model.ModelYag.YagDepoHrktTableAdapters.DataTable1TableAdapter();
      this.tBLMALZBIRIMTableAdapter = new TBLMALZBIRIMTableAdapter();
      this.tBLMALZBIRIMBindingSource = new BindingSource(this.components);
      this.tBLMALZEMELERTableAdapter = new TBLMALZEMELERTableAdapter();
      this.tBLMALZEMELERBindingSource = new BindingSource(this.components);
      this.bellDataSet7 = new bellDataSet7();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource).BeginInit();
      this.isemribakimyapanustalar.BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      this.bakimlar.BeginInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).BeginInit();
      this.ustalar.BeginInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).BeginInit();
      ((ISupportInitialize) this.dataTable2BindingSource).BeginInit();
      this.isemirmalzeme.BeginInit();
      this.gridControl2.BeginInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).BeginInit();
      this.yagDepoHrkt.BeginInit();
      this.gridView2.BeginInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).BeginInit();
      this.bellDataSet7.BeginInit();
      this.SuspendLayout();
      this.gridControl1.DataSource = (object) this.dataTable1BindingSource;
      this.gridControl1.Dock = DockStyle.Top;
      this.gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Location = new Point(0, 0);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Margin = new Padding(3, 2, 3, 2);
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1,
        (RepositoryItem) this.bakimlar,
        (RepositoryItem) this.ustalar
      });
      this.gridControl1.Size = new Size(1196, 191);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.dataTable1BindingSource.DataMember = "DataTable1";
      this.dataTable1BindingSource.DataSource = (object) this.isemribakimyapanustalar;
      this.isemribakimyapanustalar.DataSetName = "isemribakimyapanustalar";
      this.isemribakimyapanustalar.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView1.Columns.AddRange(new GridColumn[8]
      {
        this.colBOLUMADI,
        this.colUSTAADISOYADI,
        this.colGRUPADI,
        this.colYAPILANBAKIM,
        this.colISEMRIID,
        this.colATOLYEID,
        this.colBAKIMYAPUSTAID,
        this.colBAKIMGRUBUID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colBOLUMADI.Caption = "Bölüm";
      this.colBOLUMADI.FieldName = "BOLUMADI";
      this.colBOLUMADI.MinWidth = 25;
      this.colBOLUMADI.Name = "colBOLUMADI";
      this.colBOLUMADI.Visible = true;
      this.colBOLUMADI.VisibleIndex = 0;
      this.colBOLUMADI.Width = 94;
      this.colUSTAADISOYADI.Caption = "Usta Adı Soyadı";
      this.colUSTAADISOYADI.FieldName = "USTAADISOYADI";
      this.colUSTAADISOYADI.MinWidth = 25;
      this.colUSTAADISOYADI.Name = "colUSTAADISOYADI";
      this.colUSTAADISOYADI.Visible = true;
      this.colUSTAADISOYADI.VisibleIndex = 1;
      this.colUSTAADISOYADI.Width = 94;
      this.colGRUPADI.Caption = "Grup Adı";
      this.colGRUPADI.FieldName = "GRUPADI";
      this.colGRUPADI.MinWidth = 25;
      this.colGRUPADI.Name = "colGRUPADI";
      this.colGRUPADI.Visible = true;
      this.colGRUPADI.VisibleIndex = 2;
      this.colGRUPADI.Width = 94;
      this.colYAPILANBAKIM.Caption = "Yapılan Bakım";
      this.colYAPILANBAKIM.FieldName = "YAPILANBAKIM";
      this.colYAPILANBAKIM.MinWidth = 25;
      this.colYAPILANBAKIM.Name = "colYAPILANBAKIM";
      this.colYAPILANBAKIM.Visible = true;
      this.colYAPILANBAKIM.VisibleIndex = 3;
      this.colYAPILANBAKIM.Width = 94;
      this.colISEMRIID.FieldName = "ISEMRIID";
      this.colISEMRIID.MinWidth = 25;
      this.colISEMRIID.Name = "colISEMRIID";
      this.colISEMRIID.Width = 94;
      this.colATOLYEID.FieldName = "ATOLYEID";
      this.colATOLYEID.MinWidth = 25;
      this.colATOLYEID.Name = "colATOLYEID";
      this.colATOLYEID.Width = 94;
      this.colBAKIMYAPUSTAID.FieldName = "BAKIMYAPUSTAID";
      this.colBAKIMYAPUSTAID.MinWidth = 25;
      this.colBAKIMYAPUSTAID.Name = "colBAKIMYAPUSTAID";
      this.colBAKIMYAPUSTAID.Width = 94;
      this.colBAKIMGRUBUID.FieldName = "BAKIMGRUBUID";
      this.colBAKIMGRUBUID.MinWidth = 25;
      this.colBAKIMGRUBUID.Name = "colBAKIMGRUBUID";
      this.colBAKIMGRUBUID.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.bakimlar.AutoHeight = false;
      this.bakimlar.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.bakimlar.DataSource = (object) this.tBLBAKIMGRUBUBindingSource;
      this.bakimlar.DisplayMember = "GRUPADI";
      this.bakimlar.Name = "bakimlar";
      this.bakimlar.ValueMember = "ID";
      this.tBLBAKIMGRUBUBindingSource.DataMember = "TBLBAKIMGRUBU";
      this.ustalar.AutoHeight = false;
      this.ustalar.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ustalar.DataSource = (object) this.tBLATOLYEUSTALARBindingSource;
      this.ustalar.DisplayMember = "USTAADISOYADI";
      this.ustalar.Name = "ustalar";
      this.ustalar.ValueMember = "ID";
      this.tBLATOLYEUSTALARBindingSource.DataMember = "TBLATOLYEUSTALAR";
      this.dataTable2BindingSource.DataMember = "DataTable2";
      this.dataTable2BindingSource.DataSource = (object) this.isemirmalzeme;
      this.isemirmalzeme.DataSetName = "isemirmalzeme";
      this.isemirmalzeme.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataTable2TableAdapter.ClearBeforeFill = true;
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.tBLATOLYEUSTALARTableAdapter.ClearBeforeFill = true;
      this.tBLBAKIMGRUBUTableAdapter.ClearBeforeFill = true;
      this.gridControl2.DataSource = (object) this.dataTable1BindingSource1;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Location = new Point(0, 191);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.Margin = new Padding(3, 2, 3, 2);
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(1196, 413);
      this.gridControl2.TabIndex = 2;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.dataTable1BindingSource1.DataMember = "DataTable1";
      this.dataTable1BindingSource1.DataSource = (object) this.yagDepoHrkt;
      this.yagDepoHrkt.DataSetName = "YagDepoHrkt";
      this.yagDepoHrkt.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.gridView2.Columns.AddRange(new GridColumn[8]
      {
        this.gridColumn1,
        this.KOD,
        this.colMIKTAR,
        this.colFIYAT,
        this.colTUTAR,
        this.TARIH,
        this.colMALZEMEADI,
        this.colBIRIMADI
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsView.ShowFooter = true;
      this.gridColumn1.Caption = "S.No";
      this.gridColumn1.MinWidth = 24;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 31;
      this.KOD.Caption = "Kod";
      this.KOD.CustomizationCaption = "Kod";
      this.KOD.FieldName = "KOD";
      this.KOD.MinWidth = 24;
      this.KOD.Name = "KOD";
      this.KOD.Visible = true;
      this.KOD.VisibleIndex = 1;
      this.KOD.Width = 72;
      this.colMIKTAR.Caption = "Miktar";
      this.colMIKTAR.FieldName = "MIKTAR";
      this.colMIKTAR.MinWidth = 23;
      this.colMIKTAR.Name = "colMIKTAR";
      this.colMIKTAR.Visible = true;
      this.colMIKTAR.VisibleIndex = 5;
      this.colMIKTAR.Width = 44;
      this.colFIYAT.Caption = "Fiyat";
      this.colFIYAT.FieldName = "FIYAT";
      this.colFIYAT.MinWidth = 23;
      this.colFIYAT.Name = "colFIYAT";
      this.colFIYAT.Visible = true;
      this.colFIYAT.VisibleIndex = 6;
      this.colFIYAT.Width = 56;
      this.colTUTAR.Caption = "Tutar";
      this.colTUTAR.FieldName = "TUTAR";
      this.colTUTAR.MinWidth = 23;
      this.colTUTAR.Name = "colTUTAR";
      this.colTUTAR.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TUTAR", "Toplam={0:0.##}")
      });
      this.colTUTAR.Visible = true;
      this.colTUTAR.VisibleIndex = 7;
      this.colTUTAR.Width = 86;
      this.TARIH.Caption = "Tarih";
      this.TARIH.FieldName = "TARIH";
      this.TARIH.MinWidth = 24;
      this.TARIH.Name = "TARIH";
      this.TARIH.Visible = true;
      this.TARIH.VisibleIndex = 2;
      this.TARIH.Width = 82;
      this.colMALZEMEADI.Caption = "Malzema Adı veya Hizmet Adı";
      this.colMALZEMEADI.FieldName = "MALZEMEADI";
      this.colMALZEMEADI.MinWidth = 23;
      this.colMALZEMEADI.Name = "colMALZEMEADI";
      this.colMALZEMEADI.Visible = true;
      this.colMALZEMEADI.VisibleIndex = 3;
      this.colMALZEMEADI.Width = 264;
      this.colBIRIMADI.Caption = "Birim";
      this.colBIRIMADI.FieldName = "BIRIMADI";
      this.colBIRIMADI.MinWidth = 23;
      this.colBIRIMADI.Name = "colBIRIMADI";
      this.colBIRIMADI.Visible = true;
      this.colBIRIMADI.VisibleIndex = 4;
      this.colBIRIMADI.Width = 54;
      this.dataTable1TableAdapter1.ClearBeforeFill = true;
      this.tBLMALZBIRIMTableAdapter.ClearBeforeFill = true;
      this.tBLMALZBIRIMBindingSource.DataMember = "TBLMALZBIRIM";
      this.tBLMALZEMELERTableAdapter.ClearBeforeFill = true;
      this.tBLMALZEMELERBindingSource.DataMember = "TBLMALZEMELER";
      this.bellDataSet7.DataSetName = "bellDataSet7";
      this.bellDataSet7.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1196, 604);
      this.Controls.Add((Control) this.gridControl2);
      this.Controls.Add((Control) this.gridControl1);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (isemirDetay_Yag);
      this.Text = "İş Emir Detay";
      this.Load += new EventHandler(this.isemirDetay_Load);
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource).EndInit();
      this.isemribakimyapanustalar.EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      this.bakimlar.EndInit();
      ((ISupportInitialize) this.tBLBAKIMGRUBUBindingSource).EndInit();
      this.ustalar.EndInit();
      ((ISupportInitialize) this.tBLATOLYEUSTALARBindingSource).EndInit();
      ((ISupportInitialize) this.dataTable2BindingSource).EndInit();
      this.isemirmalzeme.EndInit();
      this.gridControl2.EndInit();
      ((ISupportInitialize) this.dataTable1BindingSource1).EndInit();
      this.yagDepoHrkt.EndInit();
      this.gridView2.EndInit();
      ((ISupportInitialize) this.tBLMALZBIRIMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLMALZEMELERBindingSource).EndInit();
      this.bellDataSet7.EndInit();
      this.ResumeLayout(false);
    }
  }
}
