// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Akaryakit.CikisZamaniReport
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Akaryakit
{
  public class CikisZamaniReport : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private PageHeaderBand PageHeader;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell22;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell26;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell28;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell19;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell21;
    private Parameter kod;
    private Parameter plaka;
    private Parameter ebysTarih;
    private Parameter ebysSayi;
    private Parameter giris;
    private Parameter cikis;
    private Parameter birimAd;
    private Parameter mudurluk;
    private Parameter sofor;
    private Parameter istasyon;
    private Parameter birimPers;
    private Parameter otomasyon;
    private XRTableCell xrTableCell14;

    public CikisZamaniReport() => this.InitializeComponent();

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
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell27 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.PageHeader = new PageHeaderBand();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.kod = new Parameter();
      this.plaka = new Parameter();
      this.ebysTarih = new Parameter();
      this.ebysSayi = new Parameter();
      this.giris = new Parameter();
      this.cikis = new Parameter();
      this.birimAd = new Parameter();
      this.mudurluk = new Parameter();
      this.sofor = new Parameter();
      this.istasyon = new Parameter();
      this.birimPers = new Parameter();
      this.otomasyon = new Parameter();
      this.xrTableCell14 = new XRTableCell();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.TopMargin.HeightF = 40f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.Name = "BottomMargin";
      this.Detail.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 281.25f;
      this.Detail.Name = "Detail";
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[9]
      {
        this.xrTableRow1,
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow5,
        this.xrTableRow6,
        this.xrTableRow7,
        this.xrTableRow9,
        this.xrTableRow8
      });
      this.xrTable1.SizeF = new SizeF(721.3541f, 281.25f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.BackColor = Color.LightSteelBlue;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.StylePriority.UseBackColor = false;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "ARAÇ - ÇIKIŞ ZAMANI - YAKIT KONTROL KARTI";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 2.0;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell2,
        this.xrTableCell13,
        this.xrTableCell5,
        this.xrTableCell22
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell2.BackColor = Color.Transparent;
      this.xrTableCell2.Borders = BorderSide.Left;
      this.xrTableCell2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBackColor = false;
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "Kod :";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 0.5;
      this.xrTableCell13.BackColor = Color.Transparent;
      this.xrTableCell13.Borders = BorderSide.None;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?kod")
      });
      this.xrTableCell13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.StylePriority.UseBackColor = false;
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.StylePriority.UseFont = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 0.5;
      this.xrTableCell5.BackColor = Color.Transparent;
      this.xrTableCell5.Borders = BorderSide.None;
      this.xrTableCell5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.StylePriority.UseBackColor = false;
      this.xrTableCell5.StylePriority.UseBorders = false;
      this.xrTableCell5.StylePriority.UseFont = false;
      this.xrTableCell5.StylePriority.UseTextAlignment = false;
      this.xrTableCell5.Text = "Giriş Zamanı";
      this.xrTableCell5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell5.Weight = 0.5;
      this.xrTableCell22.BackColor = Color.Transparent;
      this.xrTableCell22.Borders = BorderSide.Right;
      this.xrTableCell22.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?giris")
      });
      this.xrTableCell22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.StylePriority.UseBackColor = false;
      this.xrTableCell22.StylePriority.UseBorders = false;
      this.xrTableCell22.StylePriority.UseFont = false;
      this.xrTableCell22.StylePriority.UseTextAlignment = false;
      this.xrTableCell22.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell22.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell22.Weight = 0.5;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell3,
        this.xrTableCell23,
        this.xrTableCell6,
        this.xrTableCell24
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell3.BackColor = Color.Transparent;
      this.xrTableCell3.Borders = BorderSide.Left;
      this.xrTableCell3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.StylePriority.UseBackColor = false;
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UseFont = false;
      this.xrTableCell3.StylePriority.UseTextAlignment = false;
      this.xrTableCell3.Text = "Plaka :";
      this.xrTableCell3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell3.Weight = 0.5;
      this.xrTableCell23.BackColor = Color.Transparent;
      this.xrTableCell23.Borders = BorderSide.None;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?plaka")
      });
      this.xrTableCell23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.StylePriority.UseBackColor = false;
      this.xrTableCell23.StylePriority.UseBorders = false;
      this.xrTableCell23.StylePriority.UseFont = false;
      this.xrTableCell23.StylePriority.UseTextAlignment = false;
      this.xrTableCell23.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell23.Weight = 0.5;
      this.xrTableCell6.BackColor = Color.Transparent;
      this.xrTableCell6.Borders = BorderSide.None;
      this.xrTableCell6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBackColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.StylePriority.UseTextAlignment = false;
      this.xrTableCell6.Text = "Çıkış Zamanı";
      this.xrTableCell6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell6.Weight = 0.5;
      this.xrTableCell24.BackColor = Color.Transparent;
      this.xrTableCell24.Borders = BorderSide.Right;
      this.xrTableCell24.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?cikis")
      });
      this.xrTableCell24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.StylePriority.UseBackColor = false;
      this.xrTableCell24.StylePriority.UseBorders = false;
      this.xrTableCell24.StylePriority.UseFont = false;
      this.xrTableCell24.StylePriority.UseTextAlignment = false;
      this.xrTableCell24.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell24.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell24.Weight = 0.5;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell4,
        this.xrTableCell25,
        this.xrTableCell7,
        this.xrTableCell26
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell4.BackColor = Color.Transparent;
      this.xrTableCell4.Borders = BorderSide.Left;
      this.xrTableCell4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.StylePriority.UseBackColor = false;
      this.xrTableCell4.StylePriority.UseBorders = false;
      this.xrTableCell4.StylePriority.UseFont = false;
      this.xrTableCell4.StylePriority.UseTextAlignment = false;
      this.xrTableCell4.Text = "EBYS Tarih :";
      this.xrTableCell4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell4.Weight = 0.5;
      this.xrTableCell25.BackColor = Color.Transparent;
      this.xrTableCell25.Borders = BorderSide.None;
      this.xrTableCell25.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?ebysTarih")
      });
      this.xrTableCell25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.StylePriority.UseBackColor = false;
      this.xrTableCell25.StylePriority.UseBorders = false;
      this.xrTableCell25.StylePriority.UseFont = false;
      this.xrTableCell25.StylePriority.UseTextAlignment = false;
      this.xrTableCell25.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell25.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell25.Weight = 0.5;
      this.xrTableCell7.BackColor = Color.Transparent;
      this.xrTableCell7.Borders = BorderSide.None;
      this.xrTableCell7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBackColor = false;
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "Birim Adı";
      this.xrTableCell7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell7.Weight = 0.5;
      this.xrTableCell26.BackColor = Color.Transparent;
      this.xrTableCell26.Borders = BorderSide.Right;
      this.xrTableCell26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?birimAd")
      });
      this.xrTableCell26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.StylePriority.UseBackColor = false;
      this.xrTableCell26.StylePriority.UseBorders = false;
      this.xrTableCell26.StylePriority.UseFont = false;
      this.xrTableCell26.StylePriority.UseTextAlignment = false;
      this.xrTableCell26.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell26.Weight = 0.5;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell8,
        this.xrTableCell27,
        this.xrTableCell9,
        this.xrTableCell28
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell8.BackColor = Color.Transparent;
      this.xrTableCell8.Borders = BorderSide.Left;
      this.xrTableCell8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBackColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.StylePriority.UseFont = false;
      this.xrTableCell8.StylePriority.UseTextAlignment = false;
      this.xrTableCell8.Text = "EBYS Sayi";
      this.xrTableCell8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell8.Weight = 0.5;
      this.xrTableCell27.BackColor = Color.Transparent;
      this.xrTableCell27.Borders = BorderSide.None;
      this.xrTableCell27.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?ebysSayi")
      });
      this.xrTableCell27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.StylePriority.UseBackColor = false;
      this.xrTableCell27.StylePriority.UseBorders = false;
      this.xrTableCell27.StylePriority.UseFont = false;
      this.xrTableCell27.StylePriority.UseTextAlignment = false;
      this.xrTableCell27.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell27.Weight = 0.5;
      this.xrTableCell9.BackColor = Color.Transparent;
      this.xrTableCell9.Borders = BorderSide.None;
      this.xrTableCell9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBackColor = false;
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.StylePriority.UseFont = false;
      this.xrTableCell9.StylePriority.UseTextAlignment = false;
      this.xrTableCell9.Text = "Müdürlük Adı";
      this.xrTableCell9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell9.Weight = 0.5;
      this.xrTableCell28.BackColor = Color.Transparent;
      this.xrTableCell28.Borders = BorderSide.Right;
      this.xrTableCell28.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?birimPers")
      });
      this.xrTableCell28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.StylePriority.UseBackColor = false;
      this.xrTableCell28.StylePriority.UseBorders = false;
      this.xrTableCell28.StylePriority.UseFont = false;
      this.xrTableCell28.StylePriority.UseTextAlignment = false;
      this.xrTableCell28.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell28.Weight = 0.5;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell10,
        this.xrTableCell11
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell10.BackColor = Color.Transparent;
      this.xrTableCell10.Borders = BorderSide.Left;
      this.xrTableCell10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBackColor = false;
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell10.Weight = 1.0;
      this.xrTableCell11.BackColor = Color.Transparent;
      this.xrTableCell11.Borders = BorderSide.Right;
      this.xrTableCell11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBackColor = false;
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell11.Weight = 1.0;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell12
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell12.BackColor = Color.Transparent;
      this.xrTableCell12.Borders = BorderSide.Left | BorderSide.Right;
      this.xrTableCell12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBackColor = false;
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "Yukarıda Plakası verilen araç/ iş makinesinin deposu dolu olduğu görülmüştür.";
      this.xrTableCell12.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell12.Weight = 2.0;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell16,
        this.xrTableCell18,
        this.xrTableCell17,
        this.xrTableCell19
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell16.BackColor = Color.Transparent;
      this.xrTableCell16.Borders = BorderSide.Left;
      this.xrTableCell16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.StylePriority.UseBackColor = false;
      this.xrTableCell16.StylePriority.UseBorders = false;
      this.xrTableCell16.StylePriority.UseFont = false;
      this.xrTableCell16.StylePriority.UseTextAlignment = false;
      this.xrTableCell16.Text = "Şöför & Oparatör";
      this.xrTableCell16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell16.Weight = 0.5;
      this.xrTableCell18.BackColor = Color.Transparent;
      this.xrTableCell18.Borders = BorderSide.None;
      this.xrTableCell18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.StylePriority.UseBackColor = false;
      this.xrTableCell18.StylePriority.UseBorders = false;
      this.xrTableCell18.StylePriority.UseFont = false;
      this.xrTableCell18.StylePriority.UseTextAlignment = false;
      this.xrTableCell18.Text = "İstasyon Görevlisi";
      this.xrTableCell18.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell18.Weight = 0.5;
      this.xrTableCell17.BackColor = Color.Transparent;
      this.xrTableCell17.Borders = BorderSide.None;
      this.xrTableCell17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.StylePriority.UseBackColor = false;
      this.xrTableCell17.StylePriority.UseBorders = false;
      this.xrTableCell17.StylePriority.UseFont = false;
      this.xrTableCell17.StylePriority.UseTextAlignment = false;
      this.xrTableCell17.Text = "Birim Personel";
      this.xrTableCell17.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell17.Weight = 0.5;
      this.xrTableCell19.BackColor = Color.Transparent;
      this.xrTableCell19.Borders = BorderSide.Right;
      this.xrTableCell19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.StylePriority.UseBackColor = false;
      this.xrTableCell19.StylePriority.UseBorders = false;
      this.xrTableCell19.StylePriority.UseFont = false;
      this.xrTableCell19.StylePriority.UseTextAlignment = false;
      this.xrTableCell19.Text = "Otomasyon Görevlisi";
      this.xrTableCell19.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell19.Weight = 0.5;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell14,
        this.xrTableCell20,
        this.xrTableCell15,
        this.xrTableCell21
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell20.BackColor = Color.Transparent;
      this.xrTableCell20.Borders = BorderSide.Bottom;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?istasyon")
      });
      this.xrTableCell20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.StylePriority.UseBackColor = false;
      this.xrTableCell20.StylePriority.UseBorders = false;
      this.xrTableCell20.StylePriority.UseFont = false;
      this.xrTableCell20.StylePriority.UseTextAlignment = false;
      this.xrTableCell20.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell20.Weight = 0.5;
      this.xrTableCell15.BackColor = Color.Transparent;
      this.xrTableCell15.Borders = BorderSide.Bottom;
      this.xrTableCell15.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?birimPers")
      });
      this.xrTableCell15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.StylePriority.UseBackColor = false;
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 0.5;
      this.xrTableCell21.BackColor = Color.Transparent;
      this.xrTableCell21.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell21.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?otomasyon")
      });
      this.xrTableCell21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.StylePriority.UseBackColor = false;
      this.xrTableCell21.StylePriority.UseBorders = false;
      this.xrTableCell21.StylePriority.UseFont = false;
      this.xrTableCell21.StylePriority.UseTextAlignment = false;
      this.xrTableCell21.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell21.Weight = 0.5;
      this.PageHeader.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2
      });
      this.PageHeader.Name = "PageHeader";
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel3.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(99.99999f, 38.20837f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(444.7916f, 23f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel3.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel2.Font = new Font("Arial", 13f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(311.7187f, 10.00005f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(48.95834f, 28.20832f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "T.C. ";
      this.xrLabel2.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel4.Font = new Font("Arial", 10f);
      this.xrLabel4.LocationFloat = new PointFloat(104.1666f, 61.20837f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(440.625f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Destek Hizmetleri Dairesi Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(553.479f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(167.8751f, 100f);
      this.xrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
      this.kod.AllowNull = true;
      this.kod.Description = "kod";
      this.kod.Name = "kod";
      this.plaka.Description = "plaka";
      this.plaka.Name = "plaka";
      this.ebysTarih.AllowNull = true;
      this.ebysTarih.Description = "ebysTarih";
      this.ebysTarih.Name = "ebysTarih";
      this.ebysTarih.Type = typeof (DateTime);
      this.ebysTarih.ValueInfo = "2021-12-20";
      this.ebysSayi.AllowNull = true;
      this.ebysSayi.Description = "ebysSayi";
      this.ebysSayi.Name = "ebysSayi";
      this.giris.AllowNull = true;
      this.giris.Description = "giris";
      this.giris.Name = "giris";
      this.giris.Type = typeof (DateTime);
      this.giris.ValueInfo = "2021-12-20";
      this.cikis.AllowNull = true;
      this.cikis.Description = "cikis";
      this.cikis.Name = "cikis";
      this.cikis.Type = typeof (DateTime);
      this.cikis.ValueInfo = "2021-12-20";
      this.birimAd.AllowNull = true;
      this.birimAd.Description = "birimAd";
      this.birimAd.Name = "birimAd";
      this.mudurluk.AllowNull = true;
      this.mudurluk.Description = "mudurluk";
      this.mudurluk.Name = "mudurluk";
      this.sofor.AllowNull = true;
      this.sofor.Description = "sofor";
      this.sofor.Name = "sofor";
      this.istasyon.AllowNull = true;
      this.istasyon.Description = "istasyon";
      this.istasyon.Name = "istasyon";
      this.birimPers.AllowNull = true;
      this.birimPers.Description = "birimPers";
      this.birimPers.Name = "birimPers";
      this.otomasyon.AllowNull = true;
      this.otomasyon.Description = "otomasyon";
      this.otomasyon.Name = "otomasyon";
      this.xrTableCell14.BackColor = Color.Transparent;
      this.xrTableCell14.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell14.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?sofor")
      });
      this.xrTableCell14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBackColor = false;
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.StylePriority.UseFont = false;
      this.xrTableCell14.StylePriority.UseTextAlignment = false;
      this.xrTableCell14.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell14.Weight = 0.5;
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail,
        (Band) this.PageHeader
      });
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(48, 47, 40, 100);
      this.Parameters.AddRange(new Parameter[12]
      {
        this.kod,
        this.plaka,
        this.ebysTarih,
        this.ebysSayi,
        this.giris,
        this.cikis,
        this.birimAd,
        this.mudurluk,
        this.sofor,
        this.istasyon,
        this.birimPers,
        this.otomasyon
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}
