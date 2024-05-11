// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.iz_oz
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;
using Makina_Ikmal.Model;
using Makina_Ikmal.Model.izin_ozetleriTableAdapters;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.insankaynak
{
  public class iz_oz : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRPivotGrid xrPivotGrid1;
    private DataTable1TableAdapter dataTable1TableAdapter;
    private izin_ozetleri izin_ozetleri2;
    private XRPivotGridField fieldTCKIMLIKNO1;
    private XRPivotGridField fieldADISOYADI1;
    private XRPivotGridField fieldADI1;
    private XRPivotGridField fieldIZINYILI1;
    private XRPivotGridField fieldSumIZINHAKKI1;
    private XRPivotGridField fieldSumKULLANILANIZIN1;
    private XRPivotGridField fieldPERSDURUMID1;
    private XRPivotGridField fieldkalan1;
    private GroupHeaderBand GroupHeader1;
    private izin_ozetleri izin_ozetleri1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;

    public iz_oz() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrPivotGrid1 = new XRPivotGrid();
      this.dataTable1TableAdapter = new DataTable1TableAdapter();
      this.izin_ozetleri2 = new izin_ozetleri();
      this.fieldTCKIMLIKNO1 = new XRPivotGridField();
      this.fieldADISOYADI1 = new XRPivotGridField();
      this.fieldADI1 = new XRPivotGridField();
      this.fieldIZINYILI1 = new XRPivotGridField();
      this.fieldSumIZINHAKKI1 = new XRPivotGridField();
      this.fieldSumKULLANILANIZIN1 = new XRPivotGridField();
      this.fieldPERSDURUMID1 = new XRPivotGridField();
      this.fieldkalan1 = new XRPivotGridField();
      this.GroupHeader1 = new GroupHeaderBand();
      this.izin_ozetleri1 = new izin_ozetleri();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.izin_ozetleri2.BeginInit();
      this.izin_ozetleri1.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 114.1667f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.BackColor = Color.WhiteSmoke;
      this.BottomMargin.HeightF = 1.666667f;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.StylePriority.UseBackColor = false;
      this.Detail.HeightF = 5f;
      this.Detail.Name = "Detail";
      this.xrPivotGrid1.Appearance.Cell.BackColor = Color.Gainsboro;
      this.xrPivotGrid1.Appearance.Cell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldHeader.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValue.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new Font("Tahoma", 9f, FontStyle.Bold);
      this.xrPivotGrid1.Appearance.Lines.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.Appearance.TotalCell.Font = new Font("Tahoma", 7.8f);
      this.xrPivotGrid1.DataAdapter = (object) this.dataTable1TableAdapter;
      this.xrPivotGrid1.DataMember = "DataTable1";
      this.xrPivotGrid1.DataSource = (object) this.izin_ozetleri2;
      this.xrPivotGrid1.Fields.AddRange(new XRPivotGridField[8]
      {
        this.fieldTCKIMLIKNO1,
        this.fieldADISOYADI1,
        this.fieldADI1,
        this.fieldIZINYILI1,
        this.fieldSumIZINHAKKI1,
        this.fieldSumKULLANILANIZIN1,
        this.fieldPERSDURUMID1,
        this.fieldkalan1
      });
      this.xrPivotGrid1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPivotGrid1.Name = "xrPivotGrid1";
      this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
      this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DefaultBoolean.False;
      this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
      this.xrPivotGrid1.SizeF = new SizeF(815.9999f, 58.33333f);
      this.dataTable1TableAdapter.ClearBeforeFill = true;
      this.izin_ozetleri2.DataSetName = "izin_ozetleri";
      this.izin_ozetleri2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.fieldTCKIMLIKNO1.AreaIndex = 0;
      this.fieldTCKIMLIKNO1.Caption = "TCKIMLIKNO";
      this.fieldTCKIMLIKNO1.FieldName = "TCKIMLIKNO";
      this.fieldTCKIMLIKNO1.Name = "fieldTCKIMLIKNO1";
      this.fieldADISOYADI1.Area = PivotArea.RowArea;
      this.fieldADISOYADI1.AreaIndex = 0;
      this.fieldADISOYADI1.Caption = "ADISOYADI";
      this.fieldADISOYADI1.FieldName = "ADISOYADI";
      this.fieldADISOYADI1.Name = "fieldADISOYADI1";
      this.fieldADISOYADI1.Width = 188;
      this.fieldADI1.Area = PivotArea.RowArea;
      this.fieldADI1.AreaIndex = 1;
      this.fieldADI1.Caption = "ADI";
      this.fieldADI1.FieldName = "ADI";
      this.fieldADI1.GrandTotalText = "Toplam";
      this.fieldADI1.Name = "fieldADI1";
      this.fieldADI1.Width = 87;
      this.fieldIZINYILI1.Area = PivotArea.ColumnArea;
      this.fieldIZINYILI1.AreaIndex = 0;
      this.fieldIZINYILI1.Caption = "YIL";
      this.fieldIZINYILI1.FieldName = "IZINYILI";
      this.fieldIZINYILI1.Name = "fieldIZINYILI1";
      this.fieldIZINYILI1.Width = 38;
      this.fieldSumIZINHAKKI1.AreaIndex = 1;
      this.fieldSumIZINHAKKI1.Caption = "Sum_IZINHAKKI";
      this.fieldSumIZINHAKKI1.FieldName = "Sum_IZINHAKKI";
      this.fieldSumIZINHAKKI1.Name = "fieldSumIZINHAKKI1";
      this.fieldSumKULLANILANIZIN1.AreaIndex = 2;
      this.fieldSumKULLANILANIZIN1.Caption = "Sum_KULLANILANIZIN";
      this.fieldSumKULLANILANIZIN1.FieldName = "Sum_KULLANILANIZIN";
      this.fieldSumKULLANILANIZIN1.Name = "fieldSumKULLANILANIZIN1";
      this.fieldPERSDURUMID1.AreaIndex = 3;
      this.fieldPERSDURUMID1.Caption = "PERSDURUMID";
      this.fieldPERSDURUMID1.FieldName = "PERSDURUMID";
      this.fieldPERSDURUMID1.Name = "fieldPERSDURUMID1";
      this.fieldkalan1.Area = PivotArea.DataArea;
      this.fieldkalan1.AreaIndex = 0;
      this.fieldkalan1.Caption = "ÖZET";
      this.fieldkalan1.FieldName = "kalan";
      this.fieldkalan1.Name = "fieldkalan1";
      this.GroupHeader1.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrPivotGrid1
      });
      this.GroupHeader1.HeightF = 61.66667f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.izin_ozetleri1.DataSetName = "izin_ozetleri";
      this.izin_ozetleri1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(661.8334f, 14.16666f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(154.1666f, 100f);
      this.xrLabel1.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(136.6667f, 14.16666f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel1.SizeF = new SizeF(481.6666f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "T.C.";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel2.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(111.6666f, 41.00001f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel2.SizeF = new SizeF(526.6666f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "ŞANLIURFA BÜYÜKŞEHİR BAŞKANLIĞI";
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel3.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(111.6666f, 81.16666f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel3.SizeF = new SizeF(526.6666f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "PERSONEL İZİN DURUMLARI";
      this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1
      });
      this.ComponentStorage.AddRange(new IComponent[2]
      {
        (IComponent) this.izin_ozetleri1,
        (IComponent) this.izin_ozetleri2
      });
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(20, 14, 114, 2);
      this.Version = "20.1";
      this.izin_ozetleri2.EndInit();
      this.izin_ozetleri1.EndInit();
      this.EndInit();
    }
  }
}
