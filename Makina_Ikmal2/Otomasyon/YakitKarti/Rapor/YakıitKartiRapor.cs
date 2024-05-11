// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.YakitKarti.Rapor.YakıitKartiRapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Otomasyon.YakitKarti.Rapor
{
  public class YakıitKartiRapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell8;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell10;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell6;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell28;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell19;
    private SqlDataSource sqlDataSource1;
    private GroupHeaderBand GroupHeader1;
    private ImageCollection ımageCollection1;
    private ImageCollection ımageCollection2;
    private XRPictureBox xrPictureBox1;
    private Parameter id;

    public YakıitKartiRapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (YakıitKartiRapor));
      SelectQuery selectQuery = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table = new Table();
      Column column2 = new Column();
      ColumnExpression columnExpression2 = new ColumnExpression();
      Column column3 = new Column();
      ColumnExpression columnExpression3 = new ColumnExpression();
      Column column4 = new Column();
      ColumnExpression columnExpression4 = new ColumnExpression();
      Column column5 = new Column();
      ColumnExpression columnExpression5 = new ColumnExpression();
      Column column6 = new Column();
      ColumnExpression columnExpression6 = new ColumnExpression();
      Column column7 = new Column();
      ColumnExpression columnExpression7 = new ColumnExpression();
      Column column8 = new Column();
      ColumnExpression columnExpression8 = new ColumnExpression();
      Column column9 = new Column();
      ColumnExpression columnExpression9 = new ColumnExpression();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      this.TopMargin = new TopMarginBand();
      this.xrLabel1 = new XRLabel();
      this.BottomMargin = new BottomMarginBand();
      this.Detail = new DetailBand();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.GroupHeader1 = new GroupHeaderBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.ımageCollection1 = new ImageCollection(this.components);
      this.ımageCollection2 = new ImageCollection(this.components);
      this.id = new Parameter();
      this.xrTable1.BeginInit();
      this.ımageCollection1.BeginInit();
      this.ımageCollection2.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLabel1
      });
      this.TopMargin.Name = "TopMargin";
      this.xrLabel1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrLabel1.LocationFloat = new PointFloat(0.0f, 70.75002f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(650f, 29.25f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "YAKIT KARTI TESLİM TUTANAĞI";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.BottomMargin.HeightF = 146.3264f;
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.HeightF = 130.4859f;
      this.Detail.Name = "Detail";
      this.xrTable1.LocationFloat = new PointFloat(10.00001f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[10]
      {
        this.xrTableRow1,
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow8,
        this.xrTableRow5,
        this.xrTableRow7,
        this.xrTableRow6,
        this.xrTableRow9,
        this.xrTableRow10
      });
      this.xrTable1.SizeF = new SizeF(650f, 538.7154f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.Silver;
      this.xrTableCell1.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "Sürücü / Operatör Yakıt Kartı Bilgileri";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 12.0;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell2,
        this.xrTableCell7,
        this.xrTableCell12
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell2.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Kart No";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell2.Weight = 1.2003204345703125;
      this.xrTableCell7.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KARTNO]")
      });
      this.xrTableCell7.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell7.Weight = 1.5160257192758413;
      this.xrTableCell12.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.RowSpan = 4;
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.Weight = 475.0 / 208.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell3,
        this.xrTableCell8,
        this.xrTableCell13
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell3.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell3.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "T.C. Kimlik No";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell3.Weight = 1.2003204345703125;
      this.xrTableCell8.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TCNO]")
      });
      this.xrTableCell8.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell8.Weight = 1.5160257192758413;
      this.xrTableCell13.Borders = BorderSide.Right;
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.Weight = 475.0 / 208.0;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell4,
        this.xrTableCell9,
        this.xrTableCell14
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell4.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell4.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "Adı Soyadı";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell4.Weight = 1.2003204345703125;
      this.xrTableCell9.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell9.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SOFORADISOYADI]")
      });
      this.xrTableCell9.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell9.Weight = 1.5160257192758413;
      this.xrTableCell14.Borders = BorderSide.Right;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.Weight = 475.0 / 208.0;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell17,
        this.xrTableCell18,
        this.xrTableCell19
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell17.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell17.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Sürücü Belgesi";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell17.Weight = 1.2003204345703125;
      this.xrTableCell18.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell18.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[SURUCUBELGE]")
      });
      this.xrTableCell18.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell18.Weight = 1.5160257192758413;
      this.xrTableCell19.Borders = BorderSide.Right;
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBorders = false;
      this.xrTableCell19.Weight = 475.0 / 208.0;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell5,
        this.xrTableCell10
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell5.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell5.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Çalıştığı Birim";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell5.Weight = 1.2003204345703125;
      this.xrTableCell10.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell10.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[CALISTIGIBIRIM]")
      });
      this.xrTableCell10.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell10.Weight = 3.7996795654296873;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell11,
        this.xrTableCell16
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell11.Borders = BorderSide.Left | BorderSide.Top;
      this.xrTableCell11.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "Evrak Tarih ve Sayı";
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleRight;
      this.xrTableCell11.Weight = 1.2003204345703125;
      this.xrTableCell16.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell16.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ACIKLAMA]")
      });
      this.xrTableCell16.Font = new Font("Arial", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell16.Weight = 3.7996795654296878;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell6
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell6.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell6.Font = new Font("Arial", 11f);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.Text = componentResourceManager.GetString("xrTableCell6.Text");
      this.xrTableCell6.Weight = 12.0;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell15,
        this.xrTableCell35,
        this.xrTableCell28
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell15.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell15.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.Text = "Teslim Eden";
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 4.8346158541165867;
      this.xrTableCell35.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell35.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.StylePriority.UseBorders = false;
      this.xrTableCell35.StylePriority.UseFont = false;
      this.xrTableCell35.StylePriority.UseTextAlignment = false;
      this.xrTableCell35.Text = "Tarih";
      this.xrTableCell35.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell35.Weight = 2.6461533766526446;
      this.xrTableCell28.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
      this.xrTableCell28.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseBorders = false;
      this.xrTableCell28.StylePriority.UseFont = false;
      this.xrTableCell28.StylePriority.UseTextAlignment = false;
      this.xrTableCell28.Text = "Teslim Alan";
      this.xrTableCell28.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell28.Weight = 235.0 / 52.0;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell21,
        this.xrTableCell22,
        this.xrTableCell23
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell21.Borders = BorderSide.All;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TESLIMEDEN]+'\n'+[TESLIMEDENUNVAN]")
      });
      this.xrTableCell21.Font = new Font("Arial", 11f);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.StylePriority.UseTextAlignment = false;
      this.xrTableCell21.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell21.Weight = 4.8346158541165867;
      this.xrTableCell22.Borders = BorderSide.All;
      this.xrTableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TARIH]")
      });
      this.xrTableCell22.Font = new Font("Arial", 11f);
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.StylePriority.UseFont = false;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell22.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell22.Weight = 2.6461533766526446;
      this.xrTableCell23.Borders = BorderSide.All;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TESLIMALAN]+'\n'+[TESLIMALANUNVAN]+'\n\n\n\n\n'")
      });
      this.xrTableCell23.Font = new Font("Arial", 11f);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.StylePriority.UseTextAlignment = false;
      this.xrTableCell23.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell23.Weight = 235.0 / 52.0;
      this.sqlDataSource1.ConnectionName = "bellConnectionString1";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "ID";
      table.Name = "TBLYAKITKARTI";
      columnExpression1.Table = table;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "KARTNO";
      columnExpression2.Table = table;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "TCNO";
      columnExpression3.Table = table;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "SOFORADISOYADI";
      columnExpression4.Table = table;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "CALISTIGIBIRIM";
      columnExpression5.Table = table;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "CALISTIGIMUDURLUK";
      columnExpression6.Table = table;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "KIMLIKONYUZU";
      columnExpression7.Table = table;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "YUKLEYICIFIRMMA";
      columnExpression8.Table = table;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "TELEFON";
      columnExpression9.Table = table;
      column9.Expression = (ExpressionBase) columnExpression9;
      columnExpression10.ColumnName = "TESLIMALAN";
      columnExpression10.Table = table;
      column10.Expression = (ExpressionBase) columnExpression10;
      columnExpression11.ColumnName = "TESLIMALANUNVAN";
      columnExpression11.Table = table;
      column11.Expression = (ExpressionBase) columnExpression11;
      columnExpression12.ColumnName = "ADRES";
      columnExpression12.Table = table;
      column12.Expression = (ExpressionBase) columnExpression12;
      columnExpression13.ColumnName = "ACIKLAMA";
      columnExpression13.Table = table;
      column13.Expression = (ExpressionBase) columnExpression13;
      columnExpression14.ColumnName = "TESLIMEDEN";
      columnExpression14.Table = table;
      column14.Expression = (ExpressionBase) columnExpression14;
      columnExpression15.ColumnName = "TESLIMEDENUNVAN";
      columnExpression15.Table = table;
      column15.Expression = (ExpressionBase) columnExpression15;
      columnExpression16.ColumnName = "SICILNO";
      columnExpression16.Table = table;
      column16.Expression = (ExpressionBase) columnExpression16;
      columnExpression17.ColumnName = "SURUCUBELGE";
      columnExpression17.Table = table;
      column17.Expression = (ExpressionBase) columnExpression17;
      columnExpression18.ColumnName = "TARIH";
      columnExpression18.Table = table;
      column18.Expression = (ExpressionBase) columnExpression18;
      selectQuery.Columns.Add((ColumnBase) column1);
      selectQuery.Columns.Add((ColumnBase) column2);
      selectQuery.Columns.Add((ColumnBase) column3);
      selectQuery.Columns.Add((ColumnBase) column4);
      selectQuery.Columns.Add((ColumnBase) column5);
      selectQuery.Columns.Add((ColumnBase) column6);
      selectQuery.Columns.Add((ColumnBase) column7);
      selectQuery.Columns.Add((ColumnBase) column8);
      selectQuery.Columns.Add((ColumnBase) column9);
      selectQuery.Columns.Add((ColumnBase) column10);
      selectQuery.Columns.Add((ColumnBase) column11);
      selectQuery.Columns.Add((ColumnBase) column12);
      selectQuery.Columns.Add((ColumnBase) column13);
      selectQuery.Columns.Add((ColumnBase) column14);
      selectQuery.Columns.Add((ColumnBase) column15);
      selectQuery.Columns.Add((ColumnBase) column16);
      selectQuery.Columns.Add((ColumnBase) column17);
      selectQuery.Columns.Add((ColumnBase) column18);
      selectQuery.Name = "TBLYAKITKARTI";
      selectQuery.Tables.Add(table);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.GroupHeader1.Controls.AddRange(new XRControl[2]
      {
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrTable1
      });
      this.GroupHeader1.HeightF = 596.007f;
      this.GroupHeader1.Name = "GroupHeader1";
      this.xrPictureBox1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "ImageSource", "[KIMLIKONYUZU]")
      });
      this.xrPictureBox1.LocationFloat = new PointFloat(373.1249f, 63.87154f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(276.8751f, 195.4861f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.ımageCollection1.ImageStream = (ImageCollectionStreamer) componentResourceManager.GetObject("ımageCollection1.ImageStream");
      this.ımageCollection2.ImageStream = (ImageCollectionStreamer) componentResourceManager.GetObject("ımageCollection2.ImageStream");
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.GroupHeader1
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLYAKITKARTI";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(100, 82, 100, 146);
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.ımageCollection1.EndInit();
      this.ımageCollection2.EndInit();
      this.EndInit();
    }
  }
}
