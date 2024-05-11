// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.ToplantiRapor
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.DataAccess.Sql;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.insankaynak
{
  public class ToplantiRapor : XtraReport
  {
    private IContainer components = (IContainer) null;
    private SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption1;
    private XRControlStyle DetailData1;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle PageInfo;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private DetailBand Detail;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRTable xrTable3;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableRow xrTableRow41;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRTableRow xrTableRow42;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableRow xrTableRow43;
    private XRTableCell xrTableCell108;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableRow xrTableRow44;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private XRTableRow xrTableRow45;
    private XRTableCell xrTableCell118;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell122;
    private XRTableRow xrTableRow46;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTableCell xrTableCell127;
    private XRTableRow xrTableRow47;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell130;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableRow xrTableRow48;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRTableCell xrTableCell135;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableRow xrTableRow49;
    private XRTableCell xrTableCell138;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;
    private XRTableCell xrTableCell141;
    private XRTableCell xrTableCell142;
    private XRTableRow xrTableRow50;
    private XRTableCell xrTableCell162;
    private XRTableCell xrTableCell144;
    private XRTableCell xrTableCell145;
    private XRTableCell xrTableCell146;
    private XRTableCell xrTableCell147;
    private XRTableRow xrTableRow51;
    private XRTableCell xrTableCell163;
    private XRTableRow xrTableRow52;
    private XRTableCell xrTableCell164;
    private XRTableRow xrTableRow53;
    private XRTableCell xrTableCell165;
    private XRTableCell xrTableCell168;
    private XRTableCell xrTableCell150;
    private XRTable xrTable2;
    private XRTableRow xrTableRow36;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell78;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell65;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell58;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCell59;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell2;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell70;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell76;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell33;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell64;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell63;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell5;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private Parameter id;

    public ToplantiRapor() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      SelectQuery selectQuery = new SelectQuery();
      Column column1 = new Column();
      ColumnExpression columnExpression1 = new ColumnExpression();
      Table table1 = new Table();
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
      Table table2 = new Table();
      Column column10 = new Column();
      ColumnExpression columnExpression10 = new ColumnExpression();
      Table table3 = new Table();
      Column column11 = new Column();
      ColumnExpression columnExpression11 = new ColumnExpression();
      Table table4 = new Table();
      Column column12 = new Column();
      ColumnExpression columnExpression12 = new ColumnExpression();
      Table table5 = new Table();
      Column column13 = new Column();
      ColumnExpression columnExpression13 = new ColumnExpression();
      Table table6 = new Table();
      Column column14 = new Column();
      ColumnExpression columnExpression14 = new ColumnExpression();
      Table table7 = new Table();
      Column column15 = new Column();
      ColumnExpression columnExpression15 = new ColumnExpression();
      Table table8 = new Table();
      Column column16 = new Column();
      ColumnExpression columnExpression16 = new ColumnExpression();
      Table table9 = new Table();
      Column column17 = new Column();
      ColumnExpression columnExpression17 = new ColumnExpression();
      Table table10 = new Table();
      Column column18 = new Column();
      ColumnExpression columnExpression18 = new ColumnExpression();
      Table table11 = new Table();
      Column column19 = new Column();
      ColumnExpression columnExpression19 = new ColumnExpression();
      Table table12 = new Table();
      Column column20 = new Column();
      ColumnExpression columnExpression20 = new ColumnExpression();
      Table table13 = new Table();
      Column column21 = new Column();
      ColumnExpression columnExpression21 = new ColumnExpression();
      Join join1 = new Join();
      RelationColumnInfo relationColumnInfo1 = new RelationColumnInfo();
      Join join2 = new Join();
      RelationColumnInfo relationColumnInfo2 = new RelationColumnInfo();
      Join join3 = new Join();
      RelationColumnInfo relationColumnInfo3 = new RelationColumnInfo();
      Join join4 = new Join();
      RelationColumnInfo relationColumnInfo4 = new RelationColumnInfo();
      Join join5 = new Join();
      RelationColumnInfo relationColumnInfo5 = new RelationColumnInfo();
      Join join6 = new Join();
      RelationColumnInfo relationColumnInfo6 = new RelationColumnInfo();
      Join join7 = new Join();
      RelationColumnInfo relationColumnInfo7 = new RelationColumnInfo();
      Join join8 = new Join();
      RelationColumnInfo relationColumnInfo8 = new RelationColumnInfo();
      Join join9 = new Join();
      RelationColumnInfo relationColumnInfo9 = new RelationColumnInfo();
      Join join10 = new Join();
      RelationColumnInfo relationColumnInfo10 = new RelationColumnInfo();
      Join join11 = new Join();
      RelationColumnInfo relationColumnInfo11 = new RelationColumnInfo();
      Join join12 = new Join();
      RelationColumnInfo relationColumnInfo12 = new RelationColumnInfo();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ToplantiRapor));
      this.sqlDataSource1 = new SqlDataSource(this.components);
      this.Title = new XRControlStyle();
      this.DetailCaption1 = new XRControlStyle();
      this.DetailData1 = new XRControlStyle();
      this.DetailData3_Odd = new XRControlStyle();
      this.PageInfo = new XRControlStyle();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      this.ReportHeader = new ReportHeaderBand();
      this.Detail = new DetailBand();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel1 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel4 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrTableRow2 = new XRTableRow();
      this.xrTableCell4 = new XRTableCell();
      this.xrTableRow3 = new XRTableRow();
      this.xrTableCell7 = new XRTableCell();
      this.xrTableRow4 = new XRTableRow();
      this.xrTableCell10 = new XRTableCell();
      this.xrTableCell11 = new XRTableCell();
      this.xrTableCell12 = new XRTableCell();
      this.xrTableRow5 = new XRTableRow();
      this.xrTableCell13 = new XRTableCell();
      this.xrTableCell14 = new XRTableCell();
      this.xrTableCell15 = new XRTableCell();
      this.xrTableRow6 = new XRTableRow();
      this.xrTableCell16 = new XRTableCell();
      this.xrTableCell17 = new XRTableCell();
      this.xrTableCell18 = new XRTableCell();
      this.xrTableRow7 = new XRTableRow();
      this.xrTableCell19 = new XRTableCell();
      this.xrTableCell20 = new XRTableCell();
      this.xrTableCell21 = new XRTableCell();
      this.xrTableRow8 = new XRTableRow();
      this.xrTableCell22 = new XRTableCell();
      this.xrTableCell23 = new XRTableCell();
      this.xrTableCell24 = new XRTableCell();
      this.xrTableRow9 = new XRTableRow();
      this.xrTableCell25 = new XRTableCell();
      this.xrTableCell26 = new XRTableCell();
      this.xrTableCell27 = new XRTableCell();
      this.xrTableRow10 = new XRTableRow();
      this.xrTableCell2 = new XRTableCell();
      this.xrTableRow11 = new XRTableRow();
      this.xrTableCell6 = new XRTableCell();
      this.xrTableCell8 = new XRTableCell();
      this.xrTableCell9 = new XRTableCell();
      this.xrTableRow12 = new XRTableRow();
      this.xrTableCell28 = new XRTableCell();
      this.xrTableCell29 = new XRTableCell();
      this.xrTableCell30 = new XRTableCell();
      this.xrTableRow13 = new XRTableRow();
      this.xrTableCell31 = new XRTableCell();
      this.xrTableCell32 = new XRTableCell();
      this.xrTableRow14 = new XRTableRow();
      this.xrTableCell34 = new XRTableCell();
      this.xrTableCell35 = new XRTableCell();
      this.xrTableCell36 = new XRTableCell();
      this.xrTableRow15 = new XRTableRow();
      this.xrTableCell37 = new XRTableCell();
      this.xrTableCell38 = new XRTableCell();
      this.xrTableCell39 = new XRTableCell();
      this.xrTableRow16 = new XRTableRow();
      this.xrTableCell40 = new XRTableCell();
      this.xrTableCell41 = new XRTableCell();
      this.xrTableCell42 = new XRTableCell();
      this.xrTableRow17 = new XRTableRow();
      this.xrTableCell43 = new XRTableCell();
      this.xrTableCell44 = new XRTableCell();
      this.xrTableCell45 = new XRTableCell();
      this.xrTableRow18 = new XRTableRow();
      this.xrTableCell46 = new XRTableCell();
      this.xrTableCell47 = new XRTableCell();
      this.xrTableCell48 = new XRTableCell();
      this.xrTableRow19 = new XRTableRow();
      this.xrTableCell49 = new XRTableCell();
      this.xrTableCell50 = new XRTableCell();
      this.xrTableCell51 = new XRTableCell();
      this.xrTableRow20 = new XRTableRow();
      this.xrTableCell52 = new XRTableCell();
      this.xrTableCell53 = new XRTableCell();
      this.xrTableCell54 = new XRTableCell();
      this.xrTableRow21 = new XRTableRow();
      this.xrTableCell55 = new XRTableCell();
      this.xrTableCell56 = new XRTableCell();
      this.xrTableCell57 = new XRTableCell();
      this.xrTableRow22 = new XRTableRow();
      this.xrTableCell33 = new XRTableCell();
      this.xrTableRow23 = new XRTableRow();
      this.xrTableCell60 = new XRTableCell();
      this.xrTableCell61 = new XRTableCell();
      this.xrTableRow24 = new XRTableRow();
      this.xrTableCell3 = new XRTableCell();
      this.xrTableRow25 = new XRTableRow();
      this.xrTableCell64 = new XRTableCell();
      this.xrTableRow26 = new XRTableRow();
      this.xrTableCell67 = new XRTableCell();
      this.xrTableCell68 = new XRTableCell();
      this.xrTableCell69 = new XRTableCell();
      this.xrTableRow27 = new XRTableRow();
      this.xrTableCell62 = new XRTableCell();
      this.xrTableCell70 = new XRTableCell();
      this.xrTableRow28 = new XRTableRow();
      this.xrTableCell71 = new XRTableCell();
      this.xrTableCell72 = new XRTableCell();
      this.xrTableRow29 = new XRTableRow();
      this.xrTableCell73 = new XRTableCell();
      this.xrTableCell74 = new XRTableCell();
      this.xrTableRow30 = new XRTableRow();
      this.xrTableCell75 = new XRTableCell();
      this.xrTableCell76 = new XRTableCell();
      this.xrTableRow31 = new XRTableRow();
      this.xrTableCell5 = new XRTableCell();
      this.xrTableRow32 = new XRTableRow();
      this.xrTableCell63 = new XRTableCell();
      this.xrTableRow33 = new XRTableRow();
      this.xrTableCell58 = new XRTableCell();
      this.xrTableRow34 = new XRTableRow();
      this.xrTableCell59 = new XRTableCell();
      this.xrTableRow35 = new XRTableRow();
      this.xrTableCell65 = new XRTableCell();
      this.xrLabel6 = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrTable2 = new XRTable();
      this.xrTableRow36 = new XRTableRow();
      this.xrTableCell66 = new XRTableCell();
      this.xrTableCell77 = new XRTableCell();
      this.xrTableCell78 = new XRTableCell();
      this.xrTableCell79 = new XRTableCell();
      this.xrTableRow37 = new XRTableRow();
      this.xrTableCell80 = new XRTableCell();
      this.xrTableCell81 = new XRTableCell();
      this.xrTableCell82 = new XRTableCell();
      this.xrTableCell83 = new XRTableCell();
      this.xrTableRow38 = new XRTableRow();
      this.xrTableCell84 = new XRTableCell();
      this.xrTableCell85 = new XRTableCell();
      this.xrTableCell86 = new XRTableCell();
      this.xrTableCell87 = new XRTableCell();
      this.xrTable3 = new XRTable();
      this.xrTableRow39 = new XRTableRow();
      this.xrTableCell88 = new XRTableCell();
      this.xrTableCell89 = new XRTableCell();
      this.xrTableCell90 = new XRTableCell();
      this.xrTableCell91 = new XRTableCell();
      this.xrTableCell92 = new XRTableCell();
      this.xrTableRow40 = new XRTableRow();
      this.xrTableCell93 = new XRTableCell();
      this.xrTableCell94 = new XRTableCell();
      this.xrTableCell95 = new XRTableCell();
      this.xrTableCell96 = new XRTableCell();
      this.xrTableCell97 = new XRTableCell();
      this.xrTableRow41 = new XRTableRow();
      this.xrTableCell98 = new XRTableCell();
      this.xrTableCell99 = new XRTableCell();
      this.xrTableCell100 = new XRTableCell();
      this.xrTableCell101 = new XRTableCell();
      this.xrTableCell102 = new XRTableCell();
      this.xrTableRow42 = new XRTableRow();
      this.xrTableCell103 = new XRTableCell();
      this.xrTableCell104 = new XRTableCell();
      this.xrTableCell105 = new XRTableCell();
      this.xrTableCell106 = new XRTableCell();
      this.xrTableCell107 = new XRTableCell();
      this.xrTableRow43 = new XRTableRow();
      this.xrTableCell108 = new XRTableCell();
      this.xrTableCell109 = new XRTableCell();
      this.xrTableCell110 = new XRTableCell();
      this.xrTableCell111 = new XRTableCell();
      this.xrTableCell112 = new XRTableCell();
      this.xrTableRow44 = new XRTableRow();
      this.xrTableCell113 = new XRTableCell();
      this.xrTableCell114 = new XRTableCell();
      this.xrTableCell115 = new XRTableCell();
      this.xrTableCell116 = new XRTableCell();
      this.xrTableCell117 = new XRTableCell();
      this.xrTableRow45 = new XRTableRow();
      this.xrTableCell118 = new XRTableCell();
      this.xrTableCell119 = new XRTableCell();
      this.xrTableCell120 = new XRTableCell();
      this.xrTableCell121 = new XRTableCell();
      this.xrTableCell122 = new XRTableCell();
      this.xrTableRow46 = new XRTableRow();
      this.xrTableCell123 = new XRTableCell();
      this.xrTableCell124 = new XRTableCell();
      this.xrTableCell125 = new XRTableCell();
      this.xrTableCell126 = new XRTableCell();
      this.xrTableCell127 = new XRTableCell();
      this.xrTableRow47 = new XRTableRow();
      this.xrTableCell128 = new XRTableCell();
      this.xrTableCell129 = new XRTableCell();
      this.xrTableCell130 = new XRTableCell();
      this.xrTableCell131 = new XRTableCell();
      this.xrTableCell132 = new XRTableCell();
      this.xrTableRow48 = new XRTableRow();
      this.xrTableCell133 = new XRTableCell();
      this.xrTableCell134 = new XRTableCell();
      this.xrTableCell135 = new XRTableCell();
      this.xrTableCell136 = new XRTableCell();
      this.xrTableCell137 = new XRTableCell();
      this.xrTableRow49 = new XRTableRow();
      this.xrTableCell138 = new XRTableCell();
      this.xrTableCell139 = new XRTableCell();
      this.xrTableCell140 = new XRTableCell();
      this.xrTableCell141 = new XRTableCell();
      this.xrTableCell142 = new XRTableCell();
      this.xrTableRow50 = new XRTableRow();
      this.xrTableCell144 = new XRTableCell();
      this.xrTableCell145 = new XRTableCell();
      this.xrTableCell146 = new XRTableCell();
      this.xrTableCell147 = new XRTableCell();
      this.xrTableRow51 = new XRTableRow();
      this.xrTableRow52 = new XRTableRow();
      this.xrTableRow53 = new XRTableRow();
      this.xrTableCell150 = new XRTableCell();
      this.xrTableCell162 = new XRTableCell();
      this.xrTableCell163 = new XRTableCell();
      this.xrTableCell164 = new XRTableCell();
      this.xrTableCell165 = new XRTableCell();
      this.xrTableCell168 = new XRTableCell();
      this.id = new Parameter();
      this.xrTable1.BeginInit();
      this.xrTable2.BeginInit();
      this.xrTable3.BeginInit();
      this.BeginInit();
      this.sqlDataSource1.ConnectionName = "bellConnectionString";
      this.sqlDataSource1.Name = "sqlDataSource1";
      columnExpression1.ColumnName = "TOPLANTITARIHI";
      table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"485\" />";
      table1.Name = "TBLPERTOPLANTI";
      columnExpression1.Table = table1;
      column1.Expression = (ExpressionBase) columnExpression1;
      columnExpression2.ColumnName = "DAIREBASK_KODU";
      columnExpression2.Table = table1;
      column2.Expression = (ExpressionBase) columnExpression2;
      columnExpression3.ColumnName = "TOPLANTIKONUSU";
      columnExpression3.Table = table1;
      column3.Expression = (ExpressionBase) columnExpression3;
      columnExpression4.ColumnName = "RAPORNO";
      columnExpression4.Table = table1;
      column4.Expression = (ExpressionBase) columnExpression4;
      columnExpression5.ColumnName = "TOPLANTISURESI";
      columnExpression5.Table = table1;
      column5.Expression = (ExpressionBase) columnExpression5;
      columnExpression6.ColumnName = "SONRAKITOPLANTITARIHI";
      columnExpression6.Table = table1;
      column6.Expression = (ExpressionBase) columnExpression6;
      columnExpression7.ColumnName = "GUNDEMMADDELERI";
      columnExpression7.Table = table1;
      column7.Expression = (ExpressionBase) columnExpression7;
      columnExpression8.ColumnName = "KARARACIKLAMASI";
      columnExpression8.Table = table1;
      column8.Expression = (ExpressionBase) columnExpression8;
      columnExpression9.ColumnName = "ADISOYADI";
      table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table2.Name = "TBLPERSONEL";
      columnExpression9.Table = table2;
      column9.Expression = (ExpressionBase) columnExpression9;
      column10.Alias = "yazisleri";
      columnExpression10.ColumnName = "ADISOYADI";
      table3.Alias = "TBLPERSONEL_1";
      table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table3.Name = "TBLPERSONEL";
      columnExpression10.Table = table3;
      column10.Expression = (ExpressionBase) columnExpression10;
      column11.Alias = "atolyesef";
      columnExpression11.ColumnName = "ADISOYADI";
      table4.Alias = "TBLPERSONEL_2";
      table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table4.Name = "TBLPERSONEL";
      columnExpression11.Table = table4;
      column11.Expression = (ExpressionBase) columnExpression11;
      column12.Alias = "ambarsm";
      columnExpression12.ColumnName = "ADISOYADI";
      table5.Alias = "TBLPERSONEL_3";
      table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table5.Name = "TBLPERSONEL";
      columnExpression12.Table = table5;
      column12.Expression = (ExpressionBase) columnExpression12;
      column13.Alias = "ismakinasi";
      columnExpression13.ColumnName = "ADISOYADI";
      table6.Alias = "TBLPERSONEL_4";
      table6.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table6.Name = "TBLPERSONEL";
      columnExpression13.Table = table6;
      column13.Expression = (ExpressionBase) columnExpression13;
      column14.Alias = "ikmalsorumlusu";
      columnExpression14.ColumnName = "ADISOYADI";
      table7.Alias = "TBLPERSONEL_5";
      table7.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table7.Name = "TBLPERSONEL";
      columnExpression14.Table = table7;
      column14.Expression = (ExpressionBase) columnExpression14;
      column15.Alias = "akaryakitsorumlusu";
      columnExpression15.ColumnName = "ADISOYADI";
      table8.Alias = "TBLPERSONEL_6";
      table8.MetaSerializable = "<Meta X=\"1115\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table8.Name = "TBLPERSONEL";
      columnExpression15.Table = table8;
      column15.Expression = (ExpressionBase) columnExpression15;
      column16.Alias = "kaynakustabasi";
      columnExpression16.ColumnName = "ADISOYADI";
      table9.Alias = "TBLPERSONEL_7";
      table9.MetaSerializable = "<Meta X=\"1270\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table9.Name = "TBLPERSONEL";
      columnExpression16.Table = table9;
      column16.Expression = (ExpressionBase) columnExpression16;
      column17.Alias = "elektriksorumlusu";
      columnExpression17.ColumnName = "ADISOYADI";
      table10.Alias = "TBLPERSONEL_8";
      table10.MetaSerializable = "<Meta X=\"1425\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table10.Name = "TBLPERSONEL";
      columnExpression17.Table = table10;
      column17.Expression = (ExpressionBase) columnExpression17;
      column18.Alias = "kamyonsorumlusu";
      columnExpression18.ColumnName = "ADISOYADI";
      table11.Alias = "TBLPERSONEL_9";
      table11.MetaSerializable = "<Meta X=\"1580\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table11.Name = "TBLPERSONEL";
      columnExpression18.Table = table11;
      column18.Expression = (ExpressionBase) columnExpression18;
      column19.Alias = "lastiksorumlusu";
      columnExpression19.ColumnName = "ADISOYADI";
      table12.Alias = "TBLPERSONEL_10";
      table12.MetaSerializable = "<Meta X=\"1735\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table12.Name = "TBLPERSONEL";
      columnExpression19.Table = table12;
      column19.Expression = (ExpressionBase) columnExpression19;
      column20.Alias = "ambarayniyatsorumlusu";
      columnExpression20.ColumnName = "ADISOYADI";
      table13.Alias = "TBLPERSONEL_11";
      table13.MetaSerializable = "<Meta X=\"1890\" Y=\"30\" Width=\"125\" Height=\"925\" />";
      table13.Name = "TBLPERSONEL";
      columnExpression20.Table = table13;
      column20.Expression = (ExpressionBase) columnExpression20;
      columnExpression21.ColumnName = "ID";
      columnExpression21.Table = table1;
      column21.Expression = (ExpressionBase) columnExpression21;
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
      selectQuery.Columns.Add((ColumnBase) column19);
      selectQuery.Columns.Add((ColumnBase) column20);
      selectQuery.Columns.Add((ColumnBase) column21);
      selectQuery.Name = "TBLPERTOPLANTI_1";
      relationColumnInfo1.NestedKeyColumn = "ID";
      relationColumnInfo1.ParentKeyColumn = "TOPLANTIYONETICISI";
      join1.KeyColumns.Add(relationColumnInfo1);
      join1.Nested = table2;
      join1.Parent = table1;
      relationColumnInfo2.NestedKeyColumn = "ID";
      relationColumnInfo2.ParentKeyColumn = "YAZIISLERISRMLS";
      join2.KeyColumns.Add(relationColumnInfo2);
      join2.Nested = table3;
      join2.Parent = table1;
      relationColumnInfo3.NestedKeyColumn = "ID";
      relationColumnInfo3.ParentKeyColumn = "ATOLYESRMLS";
      join3.KeyColumns.Add(relationColumnInfo3);
      join3.Nested = table4;
      join3.Parent = table1;
      relationColumnInfo4.NestedKeyColumn = "ID";
      relationColumnInfo4.ParentKeyColumn = "AMBARSRMLS";
      join4.KeyColumns.Add(relationColumnInfo4);
      join4.Nested = table5;
      join4.Parent = table1;
      relationColumnInfo5.NestedKeyColumn = "ID";
      relationColumnInfo5.ParentKeyColumn = "ISMAKINASISRMLS";
      join5.KeyColumns.Add(relationColumnInfo5);
      join5.Nested = table6;
      join5.Parent = table1;
      relationColumnInfo6.NestedKeyColumn = "ID";
      relationColumnInfo6.ParentKeyColumn = "IKMALBIRIMSRMLS";
      join6.KeyColumns.Add(relationColumnInfo6);
      join6.Nested = table7;
      join6.Parent = table1;
      relationColumnInfo7.NestedKeyColumn = "ID";
      relationColumnInfo7.ParentKeyColumn = "AKARYKTSRMLS";
      join7.KeyColumns.Add(relationColumnInfo7);
      join7.Nested = table8;
      join7.Parent = table1;
      relationColumnInfo8.NestedKeyColumn = "ID";
      relationColumnInfo8.ParentKeyColumn = "KAYNAKISTANYONSEF";
      join8.KeyColumns.Add(relationColumnInfo8);
      join8.Nested = table9;
      join8.Parent = table1;
      relationColumnInfo9.NestedKeyColumn = "ID";
      relationColumnInfo9.ParentKeyColumn = "ELEKTRIKSRMLS";
      join9.KeyColumns.Add(relationColumnInfo9);
      join9.Nested = table10;
      join9.Parent = table1;
      relationColumnInfo10.NestedKeyColumn = "ID";
      relationColumnInfo10.ParentKeyColumn = "KAMYONTAMIRUSTABAS";
      join10.KeyColumns.Add(relationColumnInfo10);
      join10.Nested = table11;
      join10.Parent = table1;
      relationColumnInfo11.NestedKeyColumn = "ID";
      relationColumnInfo11.ParentKeyColumn = "OTOLASTIKUSTABASI";
      join11.KeyColumns.Add(relationColumnInfo11);
      join11.Nested = table12;
      join11.Parent = table1;
      relationColumnInfo12.NestedKeyColumn = "ID";
      relationColumnInfo12.ParentKeyColumn = "AMBARAYNIYATSRMLS";
      join12.KeyColumns.Add(relationColumnInfo12);
      join12.Nested = table13;
      join12.Parent = table1;
      selectQuery.Relations.Add(join1);
      selectQuery.Relations.Add(join2);
      selectQuery.Relations.Add(join3);
      selectQuery.Relations.Add(join4);
      selectQuery.Relations.Add(join5);
      selectQuery.Relations.Add(join6);
      selectQuery.Relations.Add(join7);
      selectQuery.Relations.Add(join8);
      selectQuery.Relations.Add(join9);
      selectQuery.Relations.Add(join10);
      selectQuery.Relations.Add(join11);
      selectQuery.Relations.Add(join12);
      selectQuery.Tables.Add(table1);
      selectQuery.Tables.Add(table2);
      selectQuery.Tables.Add(table3);
      selectQuery.Tables.Add(table4);
      selectQuery.Tables.Add(table5);
      selectQuery.Tables.Add(table6);
      selectQuery.Tables.Add(table7);
      selectQuery.Tables.Add(table8);
      selectQuery.Tables.Add(table9);
      selectQuery.Tables.Add(table10);
      selectQuery.Tables.Add(table11);
      selectQuery.Tables.Add(table12);
      selectQuery.Tables.Add(table13);
      this.sqlDataSource1.Queries.AddRange(new SqlQuery[1]
      {
        (SqlQuery) selectQuery
      });
      this.sqlDataSource1.ResultSchemaSerializable = componentResourceManager.GetString("sqlDataSource1.ResultSchemaSerializable");
      this.Title.BackColor = Color.Transparent;
      this.Title.BorderColor = Color.Black;
      this.Title.Borders = BorderSide.None;
      this.Title.BorderWidth = 1f;
      this.Title.Font = new Font("Arial", 14.25f);
      this.Title.ForeColor = Color.FromArgb(75, 75, 75);
      this.Title.Name = "Title";
      this.DetailCaption1.BackColor = Color.FromArgb(75, 75, 75);
      this.DetailCaption1.BorderColor = Color.White;
      this.DetailCaption1.Borders = BorderSide.Left;
      this.DetailCaption1.BorderWidth = 2f;
      this.DetailCaption1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.DetailCaption1.ForeColor = Color.White;
      this.DetailCaption1.Name = "DetailCaption1";
      this.DetailCaption1.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailCaption1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailData1.BorderColor = Color.Transparent;
      this.DetailData1.Borders = BorderSide.Left;
      this.DetailData1.BorderWidth = 2f;
      this.DetailData1.Font = new Font("Arial", 8.25f);
      this.DetailData1.ForeColor = Color.Black;
      this.DetailData1.Name = "DetailData1";
      this.DetailData1.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData1.TextAlignment = TextAlignment.MiddleLeft;
      this.DetailData3_Odd.BackColor = Color.FromArgb(231, 231, 231);
      this.DetailData3_Odd.BorderColor = Color.Transparent;
      this.DetailData3_Odd.Borders = BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1f;
      this.DetailData3_Odd.Font = new Font("Arial", 8.25f);
      this.DetailData3_Odd.ForeColor = Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new PaddingInfo(6, 6, 0, 0, 100f);
      this.DetailData3_Odd.TextAlignment = TextAlignment.MiddleLeft;
      this.PageInfo.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      this.PageInfo.ForeColor = Color.FromArgb(75, 75, 75);
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.TopMargin.HeightF = 81.66666f;
      this.TopMargin.Name = "TopMargin";
      this.BottomMargin.HeightF = 39.16667f;
      this.BottomMargin.Name = "BottomMargin";
      this.ReportHeader.Controls.AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel3
      });
      this.ReportHeader.HeightF = 130f;
      this.ReportHeader.Name = "ReportHeader";
      this.Detail.Controls.AddRange(new XRControl[8]
      {
        (XRControl) this.xrTable3,
        (XRControl) this.xrTable2,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 1936.667f;
      this.Detail.Name = "Detail";
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(592.8334f, 14.16666f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(154.1666f, 100f);
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 100f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.xrLabel1.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel1.LocationFloat = new PointFloat(136.6667f, 0.0f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(422.5f, 23f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "T.C.";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel2.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel2.LocationFloat = new PointFloat(111.6666f, 23f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(467.4999f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "ŞANLIURFA BÜYÜKŞEHİR BELEDİYE BAŞKANLIĞI";
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel3.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel3.LocationFloat = new PointFloat(111.6666f, 46f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(467.4999f, 22.99999f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "Destek Hizmetleri Dairesi Başkanlığı";
      this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel4.Font = new Font("Arial", 10f, FontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(111.6666f, 66.83334f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel4.SizeF = new SizeF(467.4999f, 22.99999f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Makine İkmal Şube Müdürlüğü";
      this.xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel5.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(111.6666f, 97.00001f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(467.4999f, 22.99999f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "Toplantı Tutanak Formu";
      this.xrLabel5.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTable1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[35]
      {
        this.xrTableRow1,
        this.xrTableRow35,
        this.xrTableRow33,
        this.xrTableRow34,
        this.xrTableRow2,
        this.xrTableRow3,
        this.xrTableRow4,
        this.xrTableRow5,
        this.xrTableRow6,
        this.xrTableRow7,
        this.xrTableRow8,
        this.xrTableRow9,
        this.xrTableRow11,
        this.xrTableRow12,
        this.xrTableRow21,
        this.xrTableRow20,
        this.xrTableRow19,
        this.xrTableRow18,
        this.xrTableRow17,
        this.xrTableRow16,
        this.xrTableRow15,
        this.xrTableRow14,
        this.xrTableRow13,
        this.xrTableRow10,
        this.xrTableRow23,
        this.xrTableRow27,
        this.xrTableRow28,
        this.xrTableRow29,
        this.xrTableRow30,
        this.xrTableRow22,
        this.xrTableRow24,
        this.xrTableRow25,
        this.xrTableRow32,
        this.xrTableRow31,
        this.xrTableRow26
      });
      this.xrTable1.SizeF = new SizeF(746.9999f, 875f);
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Borders = BorderSide.All;
      this.xrTableCell1.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.RowSpan = 2;
      this.xrTableCell1.StylePriority.UseBorders = false;
      this.xrTableCell1.StylePriority.UseFont = false;
      this.xrTableCell1.StylePriority.UseTextAlignment = false;
      this.xrTableCell1.Text = "GÜNDEM MADDELERİ";
      this.xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell1.Weight = 3.0;
      this.xrTableRow2.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell4
      });
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1.0;
      this.xrTableCell4.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GUNDEMMADDELERI]")
      });
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Weight = 3.0;
      this.xrTableRow3.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell7
      });
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1.0;
      this.xrTableCell7.Borders = BorderSide.All;
      this.xrTableCell7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.StylePriority.UseFont = false;
      this.xrTableCell7.StylePriority.UseTextAlignment = false;
      this.xrTableCell7.Text = "ALINAN KARARLAR";
      this.xrTableCell7.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell7.Weight = 3.0;
      this.xrTableRow4.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell10,
        this.xrTableCell11,
        this.xrTableCell12
      });
      this.xrTableRow4.Name = "xrTableRow4";
      this.xrTableRow4.Weight = 1.0;
      this.xrTableCell10.Borders = BorderSide.All;
      this.xrTableCell10.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.StylePriority.UseFont = false;
      this.xrTableCell10.StylePriority.UseTextAlignment = false;
      this.xrTableCell10.Text = "KARARIN AÇIKLAMASI";
      this.xrTableCell10.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell10.Weight = 1.0;
      this.xrTableCell11.Borders = BorderSide.All;
      this.xrTableCell11.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseBorders = false;
      this.xrTableCell11.StylePriority.UseFont = false;
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      this.xrTableCell11.Text = "SORUMLU";
      this.xrTableCell11.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell11.Weight = 1.0;
      this.xrTableCell12.Borders = BorderSide.All;
      this.xrTableCell12.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell12.Multiline = true;
      this.xrTableCell12.Name = "xrTableCell12";
      this.xrTableCell12.StylePriority.UseBorders = false;
      this.xrTableCell12.StylePriority.UseFont = false;
      this.xrTableCell12.StylePriority.UseTextAlignment = false;
      this.xrTableCell12.Text = "SÜRE";
      this.xrTableCell12.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell12.Weight = 1.0;
      this.xrTableRow5.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell13,
        this.xrTableCell14,
        this.xrTableCell15
      });
      this.xrTableRow5.Name = "xrTableRow5";
      this.xrTableRow5.Weight = 1.0;
      this.xrTableCell13.Borders = BorderSide.All;
      this.xrTableCell13.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[KARARACIKLAMASI]")
      });
      this.xrTableCell13.Multiline = true;
      this.xrTableCell13.Name = "xrTableCell13";
      this.xrTableCell13.RowSpan = 15;
      this.xrTableCell13.StylePriority.UseBorders = false;
      this.xrTableCell13.StylePriority.UseTextAlignment = false;
      this.xrTableCell13.Text = ",";
      this.xrTableCell13.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell13.Weight = 1.4953146117440639;
      this.xrTableCell14.Borders = BorderSide.Top;
      this.xrTableCell14.Multiline = true;
      this.xrTableCell14.Name = "xrTableCell14";
      this.xrTableCell14.StylePriority.UseBorders = false;
      this.xrTableCell14.Weight = 0.98661326103676272;
      this.xrTableCell15.Borders = BorderSide.All;
      this.xrTableCell15.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell15.Multiline = true;
      this.xrTableCell15.Name = "xrTableCell15";
      this.xrTableCell15.RowSpan = 15;
      this.xrTableCell15.StylePriority.UseBorders = false;
      this.xrTableCell15.StylePriority.UseFont = false;
      this.xrTableCell15.StylePriority.UseTextAlignment = false;
      this.xrTableCell15.Text = "[TOPLANTISURESI]  DK";
      this.xrTableCell15.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell15.Weight = 0.5180721272191734;
      this.xrTableRow6.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell16,
        this.xrTableCell17,
        this.xrTableCell18
      });
      this.xrTableRow6.Name = "xrTableRow6";
      this.xrTableRow6.Weight = 1.0;
      this.xrTableCell16.Multiline = true;
      this.xrTableCell16.Name = "xrTableCell16";
      this.xrTableCell16.Text = "xrTableCell16";
      this.xrTableCell16.Weight = 1.4953146117440639;
      this.xrTableCell17.Multiline = true;
      this.xrTableCell17.Name = "xrTableCell17";
      this.xrTableCell17.Weight = 0.98661326103676272;
      this.xrTableCell18.Multiline = true;
      this.xrTableCell18.Name = "xrTableCell18";
      this.xrTableCell18.Text = "xrTableCell18";
      this.xrTableCell18.Weight = 0.5180721272191734;
      this.xrTableRow7.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell19,
        this.xrTableCell20,
        this.xrTableCell21
      });
      this.xrTableRow7.Name = "xrTableRow7";
      this.xrTableRow7.Weight = 1.0;
      this.xrTableCell19.Multiline = true;
      this.xrTableCell19.Name = "xrTableCell19";
      this.xrTableCell19.Text = "xrTableCell19";
      this.xrTableCell19.Weight = 1.4953146117440639;
      this.xrTableCell20.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[yazisleri]")
      });
      this.xrTableCell20.Multiline = true;
      this.xrTableCell20.Name = "xrTableCell20";
      this.xrTableCell20.Weight = 0.98661326103676272;
      this.xrTableCell21.Multiline = true;
      this.xrTableCell21.Name = "xrTableCell21";
      this.xrTableCell21.Text = "xrTableCell21";
      this.xrTableCell21.Weight = 0.5180721272191734;
      this.xrTableRow8.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell22,
        this.xrTableCell23,
        this.xrTableCell24
      });
      this.xrTableRow8.Name = "xrTableRow8";
      this.xrTableRow8.Weight = 1.0;
      this.xrTableCell22.Multiline = true;
      this.xrTableCell22.Name = "xrTableCell22";
      this.xrTableCell22.Text = "xrTableCell22";
      this.xrTableCell22.Weight = 1.4953146117440639;
      this.xrTableCell23.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ikmalsorumlusu]")
      });
      this.xrTableCell23.Multiline = true;
      this.xrTableCell23.Name = "xrTableCell23";
      this.xrTableCell23.Weight = 0.98661326103676272;
      this.xrTableCell24.Multiline = true;
      this.xrTableCell24.Name = "xrTableCell24";
      this.xrTableCell24.Text = "xrTableCell24";
      this.xrTableCell24.Weight = 0.5180721272191734;
      this.xrTableRow9.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell25,
        this.xrTableCell26,
        this.xrTableCell27
      });
      this.xrTableRow9.Name = "xrTableRow9";
      this.xrTableRow9.Weight = 1.0;
      this.xrTableCell25.Multiline = true;
      this.xrTableCell25.Name = "xrTableCell25";
      this.xrTableCell25.Text = "xrTableCell25";
      this.xrTableCell25.Weight = 1.4953146117440639;
      this.xrTableCell26.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[atolyesef]")
      });
      this.xrTableCell26.Multiline = true;
      this.xrTableCell26.Name = "xrTableCell26";
      this.xrTableCell26.Weight = 0.98661326103676272;
      this.xrTableCell27.Multiline = true;
      this.xrTableCell27.Name = "xrTableCell27";
      this.xrTableCell27.Text = "xrTableCell27";
      this.xrTableCell27.Weight = 0.5180721272191734;
      this.xrTableRow10.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell2
      });
      this.xrTableRow10.Name = "xrTableRow10";
      this.xrTableRow10.Weight = 1.0;
      this.xrTableCell2.Borders = BorderSide.All;
      this.xrTableCell2.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.StylePriority.UseBorders = false;
      this.xrTableCell2.StylePriority.UseFont = false;
      this.xrTableCell2.StylePriority.UseTextAlignment = false;
      this.xrTableCell2.Text = "ONAYLAR";
      this.xrTableCell2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell2.Weight = 3.0;
      this.xrTableRow11.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell6,
        this.xrTableCell8,
        this.xrTableCell9
      });
      this.xrTableRow11.Name = "xrTableRow11";
      this.xrTableRow11.Weight = 1.0;
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.Text = "xrTableCell6";
      this.xrTableCell6.Weight = 1.4953146117440639;
      this.xrTableCell8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ambarsm]")
      });
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Weight = 0.98661326103676272;
      this.xrTableCell9.Multiline = true;
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.Text = "xrTableCell9";
      this.xrTableCell9.Weight = 0.5180721272191734;
      this.xrTableRow12.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell28,
        this.xrTableCell29,
        this.xrTableCell30
      });
      this.xrTableRow12.Name = "xrTableRow12";
      this.xrTableRow12.Weight = 1.0;
      this.xrTableCell28.Multiline = true;
      this.xrTableCell28.Name = "xrTableCell28";
      this.xrTableCell28.Text = "xrTableCell28";
      this.xrTableCell28.Weight = 1.4953146117440639;
      this.xrTableCell29.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ismakinasi]")
      });
      this.xrTableCell29.Multiline = true;
      this.xrTableCell29.Name = "xrTableCell29";
      this.xrTableCell29.Weight = 0.98661326103676272;
      this.xrTableCell30.Multiline = true;
      this.xrTableCell30.Name = "xrTableCell30";
      this.xrTableCell30.Text = "xrTableCell30";
      this.xrTableCell30.Weight = 0.5180721272191734;
      this.xrTableRow13.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell31,
        this.xrTableCell32
      });
      this.xrTableRow13.Name = "xrTableRow13";
      this.xrTableRow13.Weight = 1.0;
      this.xrTableCell31.Borders = BorderSide.All;
      this.xrTableCell31.Multiline = true;
      this.xrTableCell31.Name = "xrTableCell31";
      this.xrTableCell31.StylePriority.UseBorders = false;
      this.xrTableCell31.Text = "Bir Sonraki Toplantı Tarihi : [SONRAKITOPLANTITARIHI!d.MM.yyyy]";
      this.xrTableCell31.Weight = 1.4953145504637815;
      this.xrTableCell32.Borders = BorderSide.All;
      this.xrTableCell32.Multiline = true;
      this.xrTableCell32.Name = "xrTableCell32";
      this.xrTableCell32.StylePriority.UseBorders = false;
      this.xrTableCell32.Weight = 1.5046854495362185;
      this.xrTableRow14.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell34,
        this.xrTableCell35,
        this.xrTableCell36
      });
      this.xrTableRow14.Name = "xrTableRow14";
      this.xrTableRow14.Weight = 1.0;
      this.xrTableCell34.Multiline = true;
      this.xrTableCell34.Name = "xrTableCell34";
      this.xrTableCell34.Text = "xrTableCell34";
      this.xrTableCell34.Weight = 1.4953146117440639;
      this.xrTableCell35.Borders = BorderSide.Bottom;
      this.xrTableCell35.Multiline = true;
      this.xrTableCell35.Name = "xrTableCell35";
      this.xrTableCell35.StylePriority.UseBorders = false;
      this.xrTableCell35.Weight = 0.98661326103676272;
      this.xrTableCell36.Multiline = true;
      this.xrTableCell36.Name = "xrTableCell36";
      this.xrTableCell36.Text = "xrTableCell36";
      this.xrTableCell36.Weight = 0.5180721272191734;
      this.xrTableRow15.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell37,
        this.xrTableCell38,
        this.xrTableCell39
      });
      this.xrTableRow15.Name = "xrTableRow15";
      this.xrTableRow15.Weight = 1.0;
      this.xrTableCell37.Multiline = true;
      this.xrTableCell37.Name = "xrTableCell37";
      this.xrTableCell37.Text = "xrTableCell37";
      this.xrTableCell37.Weight = 1.4953146117440639;
      this.xrTableCell38.Multiline = true;
      this.xrTableCell38.Name = "xrTableCell38";
      this.xrTableCell38.Weight = 0.98661326103676272;
      this.xrTableCell39.Multiline = true;
      this.xrTableCell39.Name = "xrTableCell39";
      this.xrTableCell39.Text = "xrTableCell39";
      this.xrTableCell39.Weight = 0.5180721272191734;
      this.xrTableRow16.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell40,
        this.xrTableCell41,
        this.xrTableCell42
      });
      this.xrTableRow16.Name = "xrTableRow16";
      this.xrTableRow16.Weight = 1.0;
      this.xrTableCell40.Multiline = true;
      this.xrTableCell40.Name = "xrTableCell40";
      this.xrTableCell40.Text = "xrTableCell40";
      this.xrTableCell40.Weight = 1.4953146117440639;
      this.xrTableCell41.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ambarayniyatsorumlusu]")
      });
      this.xrTableCell41.Multiline = true;
      this.xrTableCell41.Name = "xrTableCell41";
      this.xrTableCell41.Weight = 0.98661326103676272;
      this.xrTableCell42.Multiline = true;
      this.xrTableCell42.Name = "xrTableCell42";
      this.xrTableCell42.Text = "xrTableCell42";
      this.xrTableCell42.Weight = 0.5180721272191734;
      this.xrTableRow17.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell43,
        this.xrTableCell44,
        this.xrTableCell45
      });
      this.xrTableRow17.Name = "xrTableRow17";
      this.xrTableRow17.Weight = 1.0;
      this.xrTableCell43.Multiline = true;
      this.xrTableCell43.Name = "xrTableCell43";
      this.xrTableCell43.Text = "xrTableCell43";
      this.xrTableCell43.Weight = 1.4953146117440639;
      this.xrTableCell44.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[lastiksorumlusu]")
      });
      this.xrTableCell44.Multiline = true;
      this.xrTableCell44.Name = "xrTableCell44";
      this.xrTableCell44.Weight = 0.98661326103676272;
      this.xrTableCell45.Multiline = true;
      this.xrTableCell45.Name = "xrTableCell45";
      this.xrTableCell45.Text = "xrTableCell45";
      this.xrTableCell45.Weight = 0.5180721272191734;
      this.xrTableRow18.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell46,
        this.xrTableCell47,
        this.xrTableCell48
      });
      this.xrTableRow18.Name = "xrTableRow18";
      this.xrTableRow18.Weight = 1.0;
      this.xrTableCell46.Multiline = true;
      this.xrTableCell46.Name = "xrTableCell46";
      this.xrTableCell46.Text = "xrTableCell46";
      this.xrTableCell46.Weight = 1.4953146117440639;
      this.xrTableCell47.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[kamyonsorumlusu]")
      });
      this.xrTableCell47.Multiline = true;
      this.xrTableCell47.Name = "xrTableCell47";
      this.xrTableCell47.Weight = 0.98661326103676272;
      this.xrTableCell48.Multiline = true;
      this.xrTableCell48.Name = "xrTableCell48";
      this.xrTableCell48.Text = "xrTableCell48";
      this.xrTableCell48.Weight = 0.5180721272191734;
      this.xrTableRow19.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell49,
        this.xrTableCell50,
        this.xrTableCell51
      });
      this.xrTableRow19.Name = "xrTableRow19";
      this.xrTableRow19.Weight = 1.0;
      this.xrTableCell49.Multiline = true;
      this.xrTableCell49.Name = "xrTableCell49";
      this.xrTableCell49.Text = "xrTableCell49";
      this.xrTableCell49.Weight = 1.4953146117440639;
      this.xrTableCell50.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[elektriksorumlusu]")
      });
      this.xrTableCell50.Multiline = true;
      this.xrTableCell50.Name = "xrTableCell50";
      this.xrTableCell50.Weight = 0.98661326103676272;
      this.xrTableCell51.Multiline = true;
      this.xrTableCell51.Name = "xrTableCell51";
      this.xrTableCell51.Text = "xrTableCell51";
      this.xrTableCell51.Weight = 0.5180721272191734;
      this.xrTableRow20.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell52,
        this.xrTableCell53,
        this.xrTableCell54
      });
      this.xrTableRow20.Name = "xrTableRow20";
      this.xrTableRow20.Weight = 1.0;
      this.xrTableCell52.Multiline = true;
      this.xrTableCell52.Name = "xrTableCell52";
      this.xrTableCell52.Text = "xrTableCell52";
      this.xrTableCell52.Weight = 1.4953146117440639;
      this.xrTableCell53.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[kaynakustabasi]")
      });
      this.xrTableCell53.Multiline = true;
      this.xrTableCell53.Name = "xrTableCell53";
      this.xrTableCell53.Weight = 0.98661326103676272;
      this.xrTableCell54.Multiline = true;
      this.xrTableCell54.Name = "xrTableCell54";
      this.xrTableCell54.Text = "xrTableCell54";
      this.xrTableCell54.Weight = 0.5180721272191734;
      this.xrTableRow21.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell55,
        this.xrTableCell56,
        this.xrTableCell57
      });
      this.xrTableRow21.Name = "xrTableRow21";
      this.xrTableRow21.Weight = 1.0;
      this.xrTableCell55.Multiline = true;
      this.xrTableCell55.Name = "xrTableCell55";
      this.xrTableCell55.Text = "xrTableCell55";
      this.xrTableCell55.Weight = 1.4953146117440639;
      this.xrTableCell56.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[akaryakitsorumlusu]")
      });
      this.xrTableCell56.Multiline = true;
      this.xrTableCell56.Name = "xrTableCell56";
      this.xrTableCell56.Weight = 0.98661326103676272;
      this.xrTableCell57.Multiline = true;
      this.xrTableCell57.Name = "xrTableCell57";
      this.xrTableCell57.Text = "xrTableCell57";
      this.xrTableCell57.Weight = 0.5180721272191734;
      this.xrTableRow22.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell33
      });
      this.xrTableRow22.Name = "xrTableRow22";
      this.xrTableRow22.Weight = 1.0;
      this.xrTableCell33.Multiline = true;
      this.xrTableCell33.Name = "xrTableCell33";
      this.xrTableCell33.Weight = 3.0;
      this.xrTableRow23.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell60,
        this.xrTableCell61
      });
      this.xrTableRow23.Name = "xrTableRow23";
      this.xrTableRow23.Weight = 1.0;
      this.xrTableCell60.Borders = BorderSide.All;
      this.xrTableCell60.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell60.Multiline = true;
      this.xrTableCell60.Name = "xrTableCell60";
      this.xrTableCell60.StylePriority.UseBorders = false;
      this.xrTableCell60.StylePriority.UseFont = false;
      this.xrTableCell60.StylePriority.UseTextAlignment = false;
      this.xrTableCell60.Text = "RAPORTÖR";
      this.xrTableCell60.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell60.Weight = 1.4953144279032167;
      this.xrTableCell61.Borders = BorderSide.All;
      this.xrTableCell61.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell61.Multiline = true;
      this.xrTableCell61.Name = "xrTableCell61";
      this.xrTableCell61.StylePriority.UseBorders = false;
      this.xrTableCell61.StylePriority.UseFont = false;
      this.xrTableCell61.StylePriority.UseTextAlignment = false;
      this.xrTableCell61.Text = "TOPLANTI YÖNETİCİSİ";
      this.xrTableCell61.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell61.Weight = 1.5046855720967833;
      this.xrTableRow24.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell3
      });
      this.xrTableRow24.Name = "xrTableRow24";
      this.xrTableRow24.Weight = 1.0;
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Text = "Eki : Toplantıya katılan Personel Listesi";
      this.xrTableCell3.Weight = 3.0;
      this.xrTableRow25.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell64
      });
      this.xrTableRow25.Name = "xrTableRow25";
      this.xrTableRow25.Weight = 1.0;
      this.xrTableCell64.Multiline = true;
      this.xrTableCell64.Name = "xrTableCell64";
      this.xrTableCell64.Weight = 3.0;
      this.xrTableRow26.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell67,
        this.xrTableCell68,
        this.xrTableCell69
      });
      this.xrTableRow26.Name = "xrTableRow26";
      this.xrTableRow26.Weight = 1.0;
      this.xrTableCell67.Multiline = true;
      this.xrTableCell67.Name = "xrTableCell67";
      this.xrTableCell67.Text = "Form No FR-028";
      this.xrTableCell67.Weight = 1.0;
      this.xrTableCell68.Multiline = true;
      this.xrTableCell68.Name = "xrTableCell68";
      this.xrTableCell68.Text = "Revizyon No :5";
      this.xrTableCell68.Weight = 1.0;
      this.xrTableCell69.Multiline = true;
      this.xrTableCell69.Name = "xrTableCell69";
      this.xrTableCell69.Text = "Yayın Tarihi : 23.06.2014";
      this.xrTableCell69.Weight = 1.0;
      this.xrTableRow27.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell62,
        this.xrTableCell70
      });
      this.xrTableRow27.Name = "xrTableRow27";
      this.xrTableRow27.Weight = 1.0;
      this.xrTableCell62.Borders = BorderSide.All;
      this.xrTableCell62.Multiline = true;
      this.xrTableCell62.Name = "xrTableCell62";
      this.xrTableCell62.RowSpan = 4;
      this.xrTableCell62.StylePriority.UseBorders = false;
      this.xrTableCell62.Weight = 1.4953144279032167;
      this.xrTableCell70.Borders = BorderSide.All;
      this.xrTableCell70.Multiline = true;
      this.xrTableCell70.Name = "xrTableCell70";
      this.xrTableCell70.RowSpan = 4;
      this.xrTableCell70.StylePriority.UseBorders = false;
      this.xrTableCell70.Weight = 1.5046855720967833;
      this.xrTableRow28.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell71,
        this.xrTableCell72
      });
      this.xrTableRow28.Name = "xrTableRow28";
      this.xrTableRow28.Weight = 1.0;
      this.xrTableCell71.Multiline = true;
      this.xrTableCell71.Name = "xrTableCell71";
      this.xrTableCell71.Text = "xrTableCell71";
      this.xrTableCell71.Weight = 1.4953144279032167;
      this.xrTableCell72.Multiline = true;
      this.xrTableCell72.Name = "xrTableCell72";
      this.xrTableCell72.Text = "xrTableCell72";
      this.xrTableCell72.Weight = 1.5046855720967833;
      this.xrTableRow29.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell73,
        this.xrTableCell74
      });
      this.xrTableRow29.Name = "xrTableRow29";
      this.xrTableRow29.Weight = 1.0;
      this.xrTableCell73.Multiline = true;
      this.xrTableCell73.Name = "xrTableCell73";
      this.xrTableCell73.Text = "xrTableCell73";
      this.xrTableCell73.Weight = 1.4953144279032167;
      this.xrTableCell74.Multiline = true;
      this.xrTableCell74.Name = "xrTableCell74";
      this.xrTableCell74.Text = "xrTableCell74";
      this.xrTableCell74.Weight = 1.5046855720967833;
      this.xrTableRow30.Cells.AddRange(new XRTableCell[2]
      {
        this.xrTableCell75,
        this.xrTableCell76
      });
      this.xrTableRow30.Name = "xrTableRow30";
      this.xrTableRow30.Weight = 1.0;
      this.xrTableCell75.Multiline = true;
      this.xrTableCell75.Name = "xrTableCell75";
      this.xrTableCell75.Text = "xrTableCell75";
      this.xrTableCell75.Weight = 1.4953144279032167;
      this.xrTableCell76.Multiline = true;
      this.xrTableCell76.Name = "xrTableCell76";
      this.xrTableCell76.Text = "xrTableCell76";
      this.xrTableCell76.Weight = 1.5046855720967833;
      this.xrTableRow31.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell5
      });
      this.xrTableRow31.Name = "xrTableRow31";
      this.xrTableRow31.Weight = 1.0;
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Weight = 3.0;
      this.xrTableRow32.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell63
      });
      this.xrTableRow32.Name = "xrTableRow32";
      this.xrTableRow32.Weight = 1.0;
      this.xrTableCell63.Multiline = true;
      this.xrTableCell63.Name = "xrTableCell63";
      this.xrTableCell63.Weight = 3.0;
      this.xrTableRow33.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell58
      });
      this.xrTableRow33.Name = "xrTableRow33";
      this.xrTableRow33.Weight = 1.0;
      this.xrTableCell58.Borders = BorderSide.All;
      this.xrTableCell58.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[GUNDEMMADDELERI]")
      });
      this.xrTableCell58.Multiline = true;
      this.xrTableCell58.Name = "xrTableCell58";
      this.xrTableCell58.RowSpan = 3;
      this.xrTableCell58.StylePriority.UseBorders = false;
      this.xrTableCell58.StylePriority.UseTextAlignment = false;
      this.xrTableCell58.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell58.Weight = 3.0;
      this.xrTableRow34.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell59
      });
      this.xrTableRow34.Name = "xrTableRow34";
      this.xrTableRow34.Weight = 1.0;
      this.xrTableCell59.Multiline = true;
      this.xrTableCell59.Name = "xrTableCell59";
      this.xrTableCell59.Text = "xrTableCell59";
      this.xrTableCell59.Weight = 3.0;
      this.xrTableRow35.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell65
      });
      this.xrTableRow35.Name = "xrTableRow35";
      this.xrTableRow35.Weight = 1.0;
      this.xrTableCell65.Multiline = true;
      this.xrTableCell65.Name = "xrTableCell65";
      this.xrTableCell65.Text = "xrTableCell65";
      this.xrTableCell65.Weight = 3.0;
      this.xrLabel6.LocationFloat = new PointFloat(10f, 692f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel6.SizeF = new SizeF(352.3333f, 23f);
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "Yazı İşleri Sorumlusu";
      this.xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel7.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel7.LocationFloat = new PointFloat(382.3334f, 667f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel7.SizeF = new SizeF(354.6667f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel8.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[yazisleri]")
      });
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(10f, 667f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(352.3333f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel9.LocationFloat = new PointFloat(382.3333f, 692f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(354.6667f, 23f);
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "Makine İkmal Şube Müdürü";
      this.xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel10.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(10f, 960.9999f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel10.SizeF = new SizeF(736.9999f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "TOPLANTIYA KATILAN PERSONEL LİSTESİ";
      this.xrLabel10.TextAlignment = TextAlignment.TopCenter;
      this.xrTable2.Borders = BorderSide.All;
      this.xrTable2.LocationFloat = new PointFloat(0.0f, 1015f);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable2.Rows.AddRange(new XRTableRow[3]
      {
        this.xrTableRow36,
        this.xrTableRow37,
        this.xrTableRow38
      });
      this.xrTable2.SizeF = new SizeF(746.9999f, 75f);
      this.xrTable2.StylePriority.UseBorders = false;
      this.xrTable2.StylePriority.UseTextAlignment = false;
      this.xrTable2.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableRow36.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell66,
        this.xrTableCell77,
        this.xrTableCell79,
        this.xrTableCell78
      });
      this.xrTableRow36.Name = "xrTableRow36";
      this.xrTableRow36.Weight = 1.0;
      this.xrTableCell66.Multiline = true;
      this.xrTableCell66.Name = "xrTableCell66";
      this.xrTableCell66.Text = "Toplantı Tarihi";
      this.xrTableCell66.Weight = 1.0;
      this.xrTableCell77.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLANTITARIHI]")
      });
      this.xrTableCell77.Multiline = true;
      this.xrTableCell77.Name = "xrTableCell77";
      this.xrTableCell77.TextFormatString = "{0:d.MM.yyyy}";
      this.xrTableCell77.Weight = 1.0;
      this.xrTableCell78.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[DAIREBASK_KODU]")
      });
      this.xrTableCell78.Multiline = true;
      this.xrTableCell78.Name = "xrTableCell78";
      this.xrTableCell78.Weight = 1.0;
      this.xrTableCell79.Multiline = true;
      this.xrTableCell79.Name = "xrTableCell79";
      this.xrTableCell79.Text = "Daire Bşk./Şb.Md Kodu";
      this.xrTableCell79.Weight = 1.0;
      this.xrTableRow37.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell80,
        this.xrTableCell81,
        this.xrTableCell82,
        this.xrTableCell83
      });
      this.xrTableRow37.Name = "xrTableRow37";
      this.xrTableRow37.Weight = 1.0;
      this.xrTableCell80.Multiline = true;
      this.xrTableCell80.Name = "xrTableCell80";
      this.xrTableCell80.Text = "Toplantı Yöneticisi";
      this.xrTableCell80.Weight = 1.0;
      this.xrTableCell81.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ADISOYADI]")
      });
      this.xrTableCell81.Multiline = true;
      this.xrTableCell81.Name = "xrTableCell81";
      this.xrTableCell81.Weight = 1.0;
      this.xrTableCell82.Multiline = true;
      this.xrTableCell82.Name = "xrTableCell82";
      this.xrTableCell82.Text = "Rapor No";
      this.xrTableCell82.Weight = 1.0;
      this.xrTableCell83.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[RAPORNO]")
      });
      this.xrTableCell83.Multiline = true;
      this.xrTableCell83.Name = "xrTableCell83";
      this.xrTableCell83.Weight = 1.0;
      this.xrTableRow38.Cells.AddRange(new XRTableCell[4]
      {
        this.xrTableCell84,
        this.xrTableCell85,
        this.xrTableCell86,
        this.xrTableCell87
      });
      this.xrTableRow38.Name = "xrTableRow38";
      this.xrTableRow38.Weight = 1.0;
      this.xrTableCell84.Multiline = true;
      this.xrTableCell84.Name = "xrTableCell84";
      this.xrTableCell84.Text = "Toplantı Konusu";
      this.xrTableCell84.Weight = 1.0;
      this.xrTableCell85.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLANTIKONUSU]")
      });
      this.xrTableCell85.Multiline = true;
      this.xrTableCell85.Name = "xrTableCell85";
      this.xrTableCell85.Weight = 1.0;
      this.xrTableCell86.Multiline = true;
      this.xrTableCell86.Name = "xrTableCell86";
      this.xrTableCell86.Text = "Süre";
      this.xrTableCell86.Weight = 1.0;
      this.xrTableCell87.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[TOPLANTISURESI]")
      });
      this.xrTableCell87.Multiline = true;
      this.xrTableCell87.Name = "xrTableCell87";
      this.xrTableCell87.Weight = 1.0;
      this.xrTable3.Borders = BorderSide.All;
      this.xrTable3.LocationFloat = new PointFloat(0.0f, 1111.667f);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable3.Rows.AddRange(new XRTableRow[15]
      {
        this.xrTableRow39,
        this.xrTableRow40,
        this.xrTableRow41,
        this.xrTableRow42,
        this.xrTableRow43,
        this.xrTableRow44,
        this.xrTableRow45,
        this.xrTableRow46,
        this.xrTableRow47,
        this.xrTableRow48,
        this.xrTableRow49,
        this.xrTableRow50,
        this.xrTableRow51,
        this.xrTableRow52,
        this.xrTableRow53
      });
      this.xrTable3.SizeF = new SizeF(747f, 825f);
      this.xrTable3.StylePriority.UseBorders = false;
      this.xrTableRow39.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell88,
        this.xrTableCell89,
        this.xrTableCell90,
        this.xrTableCell91,
        this.xrTableCell92
      });
      this.xrTableRow39.Name = "xrTableRow39";
      this.xrTableRow39.Weight = 1.0;
      this.xrTableCell88.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell88.Multiline = true;
      this.xrTableCell88.Name = "xrTableCell88";
      this.xrTableCell88.StylePriority.UseFont = false;
      this.xrTableCell88.StylePriority.UseTextAlignment = false;
      this.xrTableCell88.Text = "Sıra No";
      this.xrTableCell88.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell88.Weight = 0.33280442314331093;
      this.xrTableCell89.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell89.Multiline = true;
      this.xrTableCell89.Name = "xrTableCell89";
      this.xrTableCell89.StylePriority.UseFont = false;
      this.xrTableCell89.StylePriority.UseTextAlignment = false;
      this.xrTableCell89.Text = "Katılımcılar";
      this.xrTableCell89.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell89.Weight = 1.966615366972539;
      this.xrTableCell90.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell90.Multiline = true;
      this.xrTableCell90.Name = "xrTableCell90";
      this.xrTableCell90.StylePriority.UseFont = false;
      this.xrTableCell90.StylePriority.UseTextAlignment = false;
      this.xrTableCell90.Text = "Görevi";
      this.xrTableCell90.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell90.Weight = 1.0;
      this.xrTableCell91.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell91.Multiline = true;
      this.xrTableCell91.Name = "xrTableCell91";
      this.xrTableCell91.StylePriority.UseFont = false;
      this.xrTableCell91.StylePriority.UseTextAlignment = false;
      this.xrTableCell91.Text = "İmza";
      this.xrTableCell91.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell91.Weight = 1.0;
      this.xrTableCell92.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell92.Multiline = true;
      this.xrTableCell92.Name = "xrTableCell92";
      this.xrTableCell92.StylePriority.UseFont = false;
      this.xrTableCell92.StylePriority.UseTextAlignment = false;
      this.xrTableCell92.Text = "Katılmama Nedeni";
      this.xrTableCell92.TextAlignment = TextAlignment.TopCenter;
      this.xrTableCell92.Weight = 1.0;
      this.xrTableRow40.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell93,
        this.xrTableCell94,
        this.xrTableCell95,
        this.xrTableCell96,
        this.xrTableCell97
      });
      this.xrTableRow40.Name = "xrTableRow40";
      this.xrTableRow40.Weight = 1.0;
      this.xrTableCell93.Font = new Font("Arial", 9.75f);
      this.xrTableCell93.Multiline = true;
      this.xrTableCell93.Name = "xrTableCell93";
      this.xrTableCell93.StylePriority.UseFont = false;
      this.xrTableCell93.StylePriority.UseTextAlignment = false;
      this.xrTableCell93.Text = "1.";
      this.xrTableCell93.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell93.Weight = 0.33280442314331093;
      this.xrTableCell94.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[yazisleri]")
      });
      this.xrTableCell94.Font = new Font("Arial", 9.75f);
      this.xrTableCell94.Multiline = true;
      this.xrTableCell94.Name = "xrTableCell94";
      this.xrTableCell94.StylePriority.UseFont = false;
      this.xrTableCell94.StylePriority.UseTextAlignment = false;
      this.xrTableCell94.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell94.Weight = 1.966615366972539;
      this.xrTableCell95.Font = new Font("Arial", 9.75f);
      this.xrTableCell95.Multiline = true;
      this.xrTableCell95.Name = "xrTableCell95";
      this.xrTableCell95.StylePriority.UseFont = false;
      this.xrTableCell95.StylePriority.UseTextAlignment = false;
      this.xrTableCell95.Text = "Yazı İşleri Sorumlusu";
      this.xrTableCell95.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell95.Weight = 1.0;
      this.xrTableCell96.Font = new Font("Arial", 9.75f);
      this.xrTableCell96.Multiline = true;
      this.xrTableCell96.Name = "xrTableCell96";
      this.xrTableCell96.StylePriority.UseFont = false;
      this.xrTableCell96.StylePriority.UseTextAlignment = false;
      this.xrTableCell96.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell96.Weight = 1.0;
      this.xrTableCell97.Font = new Font("Arial", 9.75f);
      this.xrTableCell97.Multiline = true;
      this.xrTableCell97.Name = "xrTableCell97";
      this.xrTableCell97.StylePriority.UseFont = false;
      this.xrTableCell97.StylePriority.UseTextAlignment = false;
      this.xrTableCell97.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell97.Weight = 1.0;
      this.xrTableRow41.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell98,
        this.xrTableCell99,
        this.xrTableCell100,
        this.xrTableCell101,
        this.xrTableCell102
      });
      this.xrTableRow41.Name = "xrTableRow41";
      this.xrTableRow41.Weight = 1.0;
      this.xrTableCell98.Font = new Font("Arial", 9.75f);
      this.xrTableCell98.Multiline = true;
      this.xrTableCell98.Name = "xrTableCell98";
      this.xrTableCell98.StylePriority.UseFont = false;
      this.xrTableCell98.StylePriority.UseTextAlignment = false;
      this.xrTableCell98.Text = "2.";
      this.xrTableCell98.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell98.Weight = 0.33280442314331093;
      this.xrTableCell99.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[atolyesef]")
      });
      this.xrTableCell99.Font = new Font("Arial", 9.75f);
      this.xrTableCell99.Multiline = true;
      this.xrTableCell99.Name = "xrTableCell99";
      this.xrTableCell99.StylePriority.UseFont = false;
      this.xrTableCell99.StylePriority.UseTextAlignment = false;
      this.xrTableCell99.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell99.Weight = 1.966615366972539;
      this.xrTableCell100.Font = new Font("Arial", 9.75f);
      this.xrTableCell100.Multiline = true;
      this.xrTableCell100.Name = "xrTableCell100";
      this.xrTableCell100.StylePriority.UseFont = false;
      this.xrTableCell100.StylePriority.UseTextAlignment = false;
      this.xrTableCell100.Text = "Atölye Bakım ve Onarım Birim Sorumlusu";
      this.xrTableCell100.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell100.Weight = 1.0;
      this.xrTableCell101.Font = new Font("Arial", 9.75f);
      this.xrTableCell101.Multiline = true;
      this.xrTableCell101.Name = "xrTableCell101";
      this.xrTableCell101.StylePriority.UseFont = false;
      this.xrTableCell101.StylePriority.UseTextAlignment = false;
      this.xrTableCell101.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell101.Weight = 1.0;
      this.xrTableCell102.Font = new Font("Arial", 9.75f);
      this.xrTableCell102.Multiline = true;
      this.xrTableCell102.Name = "xrTableCell102";
      this.xrTableCell102.StylePriority.UseFont = false;
      this.xrTableCell102.StylePriority.UseTextAlignment = false;
      this.xrTableCell102.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell102.Weight = 1.0;
      this.xrTableRow42.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell103,
        this.xrTableCell104,
        this.xrTableCell105,
        this.xrTableCell106,
        this.xrTableCell107
      });
      this.xrTableRow42.Name = "xrTableRow42";
      this.xrTableRow42.Weight = 1.0;
      this.xrTableCell103.Font = new Font("Arial", 9.75f);
      this.xrTableCell103.Multiline = true;
      this.xrTableCell103.Name = "xrTableCell103";
      this.xrTableCell103.StylePriority.UseFont = false;
      this.xrTableCell103.StylePriority.UseTextAlignment = false;
      this.xrTableCell103.Text = "3.";
      this.xrTableCell103.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell103.Weight = 0.33280442314331093;
      this.xrTableCell104.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ambarsm]")
      });
      this.xrTableCell104.Font = new Font("Arial", 9.75f);
      this.xrTableCell104.Multiline = true;
      this.xrTableCell104.Name = "xrTableCell104";
      this.xrTableCell104.StylePriority.UseFont = false;
      this.xrTableCell104.StylePriority.UseTextAlignment = false;
      this.xrTableCell104.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell104.Weight = 1.966615366972539;
      this.xrTableCell105.Font = new Font("Arial", 9.75f);
      this.xrTableCell105.Multiline = true;
      this.xrTableCell105.Name = "xrTableCell105";
      this.xrTableCell105.StylePriority.UseFont = false;
      this.xrTableCell105.StylePriority.UseTextAlignment = false;
      this.xrTableCell105.Text = "Ambar Sorumlusu";
      this.xrTableCell105.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell105.Weight = 1.0;
      this.xrTableCell106.Font = new Font("Arial", 9.75f);
      this.xrTableCell106.Multiline = true;
      this.xrTableCell106.Name = "xrTableCell106";
      this.xrTableCell106.StylePriority.UseFont = false;
      this.xrTableCell106.StylePriority.UseTextAlignment = false;
      this.xrTableCell106.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell106.Weight = 1.0;
      this.xrTableCell107.Font = new Font("Arial", 9.75f);
      this.xrTableCell107.Multiline = true;
      this.xrTableCell107.Name = "xrTableCell107";
      this.xrTableCell107.StylePriority.UseFont = false;
      this.xrTableCell107.StylePriority.UseTextAlignment = false;
      this.xrTableCell107.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell107.Weight = 1.0;
      this.xrTableRow43.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell108,
        this.xrTableCell109,
        this.xrTableCell110,
        this.xrTableCell111,
        this.xrTableCell112
      });
      this.xrTableRow43.Name = "xrTableRow43";
      this.xrTableRow43.Weight = 1.0;
      this.xrTableCell108.Font = new Font("Arial", 9.75f);
      this.xrTableCell108.Multiline = true;
      this.xrTableCell108.Name = "xrTableCell108";
      this.xrTableCell108.StylePriority.UseFont = false;
      this.xrTableCell108.StylePriority.UseTextAlignment = false;
      this.xrTableCell108.Text = "4.";
      this.xrTableCell108.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell108.Weight = 0.33280442314331093;
      this.xrTableCell109.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ismakinasi]")
      });
      this.xrTableCell109.Font = new Font("Arial", 9.75f);
      this.xrTableCell109.Multiline = true;
      this.xrTableCell109.Name = "xrTableCell109";
      this.xrTableCell109.StylePriority.UseFont = false;
      this.xrTableCell109.StylePriority.UseTextAlignment = false;
      this.xrTableCell109.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell109.Weight = 1.966615366972539;
      this.xrTableCell110.Font = new Font("Arial", 9.75f);
      this.xrTableCell110.Multiline = true;
      this.xrTableCell110.Name = "xrTableCell110";
      this.xrTableCell110.StylePriority.UseFont = false;
      this.xrTableCell110.StylePriority.UseTextAlignment = false;
      this.xrTableCell110.Text = "İş Makinesi Ustabaşı";
      this.xrTableCell110.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell110.Weight = 1.0;
      this.xrTableCell111.Font = new Font("Arial", 9.75f);
      this.xrTableCell111.Multiline = true;
      this.xrTableCell111.Name = "xrTableCell111";
      this.xrTableCell111.StylePriority.UseFont = false;
      this.xrTableCell111.StylePriority.UseTextAlignment = false;
      this.xrTableCell111.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell111.Weight = 1.0;
      this.xrTableCell112.Font = new Font("Arial", 9.75f);
      this.xrTableCell112.Multiline = true;
      this.xrTableCell112.Name = "xrTableCell112";
      this.xrTableCell112.StylePriority.UseFont = false;
      this.xrTableCell112.StylePriority.UseTextAlignment = false;
      this.xrTableCell112.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell112.Weight = 1.0;
      this.xrTableRow44.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell113,
        this.xrTableCell114,
        this.xrTableCell115,
        this.xrTableCell116,
        this.xrTableCell117
      });
      this.xrTableRow44.Name = "xrTableRow44";
      this.xrTableRow44.Weight = 1.0;
      this.xrTableCell113.Font = new Font("Arial", 9.75f);
      this.xrTableCell113.Multiline = true;
      this.xrTableCell113.Name = "xrTableCell113";
      this.xrTableCell113.StylePriority.UseFont = false;
      this.xrTableCell113.StylePriority.UseTextAlignment = false;
      this.xrTableCell113.Text = "5.";
      this.xrTableCell113.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell113.Weight = 0.33280442314331093;
      this.xrTableCell114.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ikmalsorumlusu]")
      });
      this.xrTableCell114.Font = new Font("Arial", 9.75f);
      this.xrTableCell114.Multiline = true;
      this.xrTableCell114.Name = "xrTableCell114";
      this.xrTableCell114.StylePriority.UseFont = false;
      this.xrTableCell114.StylePriority.UseTextAlignment = false;
      this.xrTableCell114.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell114.Weight = 1.966615366972539;
      this.xrTableCell115.Font = new Font("Arial", 9.75f);
      this.xrTableCell115.Multiline = true;
      this.xrTableCell115.Name = "xrTableCell115";
      this.xrTableCell115.StylePriority.UseFont = false;
      this.xrTableCell115.StylePriority.UseTextAlignment = false;
      this.xrTableCell115.Text = "İkmal Birim Sorumlusu";
      this.xrTableCell115.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell115.Weight = 1.0;
      this.xrTableCell116.Font = new Font("Arial", 9.75f);
      this.xrTableCell116.Multiline = true;
      this.xrTableCell116.Name = "xrTableCell116";
      this.xrTableCell116.StylePriority.UseFont = false;
      this.xrTableCell116.StylePriority.UseTextAlignment = false;
      this.xrTableCell116.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell116.Weight = 1.0;
      this.xrTableCell117.Font = new Font("Arial", 9.75f);
      this.xrTableCell117.Multiline = true;
      this.xrTableCell117.Name = "xrTableCell117";
      this.xrTableCell117.StylePriority.UseFont = false;
      this.xrTableCell117.StylePriority.UseTextAlignment = false;
      this.xrTableCell117.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell117.Weight = 1.0;
      this.xrTableRow45.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell118,
        this.xrTableCell119,
        this.xrTableCell120,
        this.xrTableCell121,
        this.xrTableCell122
      });
      this.xrTableRow45.Name = "xrTableRow45";
      this.xrTableRow45.Weight = 1.0;
      this.xrTableCell118.Font = new Font("Arial", 9.75f);
      this.xrTableCell118.Multiline = true;
      this.xrTableCell118.Name = "xrTableCell118";
      this.xrTableCell118.StylePriority.UseFont = false;
      this.xrTableCell118.StylePriority.UseTextAlignment = false;
      this.xrTableCell118.Text = "6.";
      this.xrTableCell118.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell118.Weight = 0.33280442314331093;
      this.xrTableCell119.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[akaryakitsorumlusu]")
      });
      this.xrTableCell119.Font = new Font("Arial", 9.75f);
      this.xrTableCell119.Multiline = true;
      this.xrTableCell119.Name = "xrTableCell119";
      this.xrTableCell119.StylePriority.UseFont = false;
      this.xrTableCell119.StylePriority.UseTextAlignment = false;
      this.xrTableCell119.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell119.Weight = 1.966615366972539;
      this.xrTableCell120.Font = new Font("Arial", 9.75f);
      this.xrTableCell120.Multiline = true;
      this.xrTableCell120.Name = "xrTableCell120";
      this.xrTableCell120.StylePriority.UseFont = false;
      this.xrTableCell120.StylePriority.UseTextAlignment = false;
      this.xrTableCell120.Text = "Akaryakıt İstasyon Şefi";
      this.xrTableCell120.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell120.Weight = 1.0;
      this.xrTableCell121.Font = new Font("Arial", 9.75f);
      this.xrTableCell121.Multiline = true;
      this.xrTableCell121.Name = "xrTableCell121";
      this.xrTableCell121.StylePriority.UseFont = false;
      this.xrTableCell121.StylePriority.UseTextAlignment = false;
      this.xrTableCell121.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell121.Weight = 1.0;
      this.xrTableCell122.Font = new Font("Arial", 9.75f);
      this.xrTableCell122.Multiline = true;
      this.xrTableCell122.Name = "xrTableCell122";
      this.xrTableCell122.StylePriority.UseFont = false;
      this.xrTableCell122.StylePriority.UseTextAlignment = false;
      this.xrTableCell122.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell122.Weight = 1.0;
      this.xrTableRow46.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell123,
        this.xrTableCell124,
        this.xrTableCell125,
        this.xrTableCell126,
        this.xrTableCell127
      });
      this.xrTableRow46.Name = "xrTableRow46";
      this.xrTableRow46.Weight = 1.0;
      this.xrTableCell123.Font = new Font("Arial", 9.75f);
      this.xrTableCell123.Multiline = true;
      this.xrTableCell123.Name = "xrTableCell123";
      this.xrTableCell123.StylePriority.UseFont = false;
      this.xrTableCell123.StylePriority.UseTextAlignment = false;
      this.xrTableCell123.Text = "7.";
      this.xrTableCell123.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell123.Weight = 0.33280442314331093;
      this.xrTableCell124.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[kaynakustabasi]")
      });
      this.xrTableCell124.Font = new Font("Arial", 9.75f);
      this.xrTableCell124.Multiline = true;
      this.xrTableCell124.Name = "xrTableCell124";
      this.xrTableCell124.StylePriority.UseFont = false;
      this.xrTableCell124.StylePriority.UseTextAlignment = false;
      this.xrTableCell124.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell124.Weight = 1.966615366972539;
      this.xrTableCell125.Font = new Font("Arial", 9.75f);
      this.xrTableCell125.Multiline = true;
      this.xrTableCell125.Name = "xrTableCell125";
      this.xrTableCell125.StylePriority.UseFont = false;
      this.xrTableCell125.StylePriority.UseTextAlignment = false;
      this.xrTableCell125.Text = "Kaynak Atölye Sorumlusu";
      this.xrTableCell125.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell125.Weight = 1.0;
      this.xrTableCell126.Font = new Font("Arial", 9.75f);
      this.xrTableCell126.Multiline = true;
      this.xrTableCell126.Name = "xrTableCell126";
      this.xrTableCell126.StylePriority.UseFont = false;
      this.xrTableCell126.StylePriority.UseTextAlignment = false;
      this.xrTableCell126.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell126.Weight = 1.0;
      this.xrTableCell127.Font = new Font("Arial", 9.75f);
      this.xrTableCell127.Multiline = true;
      this.xrTableCell127.Name = "xrTableCell127";
      this.xrTableCell127.StylePriority.UseFont = false;
      this.xrTableCell127.StylePriority.UseTextAlignment = false;
      this.xrTableCell127.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell127.Weight = 1.0;
      this.xrTableRow47.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell128,
        this.xrTableCell129,
        this.xrTableCell130,
        this.xrTableCell131,
        this.xrTableCell132
      });
      this.xrTableRow47.Name = "xrTableRow47";
      this.xrTableRow47.Weight = 1.0;
      this.xrTableCell128.Font = new Font("Arial", 9.75f);
      this.xrTableCell128.Multiline = true;
      this.xrTableCell128.Name = "xrTableCell128";
      this.xrTableCell128.StylePriority.UseFont = false;
      this.xrTableCell128.StylePriority.UseTextAlignment = false;
      this.xrTableCell128.Text = "8.";
      this.xrTableCell128.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell128.Weight = 0.33280442314331093;
      this.xrTableCell129.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[elektriksorumlusu]")
      });
      this.xrTableCell129.Font = new Font("Arial", 9.75f);
      this.xrTableCell129.Multiline = true;
      this.xrTableCell129.Name = "xrTableCell129";
      this.xrTableCell129.StylePriority.UseFont = false;
      this.xrTableCell129.StylePriority.UseTextAlignment = false;
      this.xrTableCell129.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell129.Weight = 1.966615366972539;
      this.xrTableCell130.Font = new Font("Arial", 9.75f);
      this.xrTableCell130.Multiline = true;
      this.xrTableCell130.Name = "xrTableCell130";
      this.xrTableCell130.StylePriority.UseFont = false;
      this.xrTableCell130.StylePriority.UseTextAlignment = false;
      this.xrTableCell130.Text = "Oto Elektrik Ustabaşı";
      this.xrTableCell130.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell130.Weight = 1.0;
      this.xrTableCell131.Font = new Font("Arial", 9.75f);
      this.xrTableCell131.Multiline = true;
      this.xrTableCell131.Name = "xrTableCell131";
      this.xrTableCell131.StylePriority.UseFont = false;
      this.xrTableCell131.StylePriority.UseTextAlignment = false;
      this.xrTableCell131.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell131.Weight = 1.0;
      this.xrTableCell132.Font = new Font("Arial", 9.75f);
      this.xrTableCell132.Multiline = true;
      this.xrTableCell132.Name = "xrTableCell132";
      this.xrTableCell132.StylePriority.UseFont = false;
      this.xrTableCell132.StylePriority.UseTextAlignment = false;
      this.xrTableCell132.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell132.Weight = 1.0;
      this.xrTableRow48.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell133,
        this.xrTableCell134,
        this.xrTableCell135,
        this.xrTableCell136,
        this.xrTableCell137
      });
      this.xrTableRow48.Name = "xrTableRow48";
      this.xrTableRow48.Weight = 1.0;
      this.xrTableCell133.Font = new Font("Arial", 9.75f);
      this.xrTableCell133.Multiline = true;
      this.xrTableCell133.Name = "xrTableCell133";
      this.xrTableCell133.StylePriority.UseFont = false;
      this.xrTableCell133.StylePriority.UseTextAlignment = false;
      this.xrTableCell133.Text = "9.";
      this.xrTableCell133.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell133.Weight = 0.33280442314331093;
      this.xrTableCell134.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[kamyonsorumlusu]")
      });
      this.xrTableCell134.Font = new Font("Arial", 9.75f);
      this.xrTableCell134.Multiline = true;
      this.xrTableCell134.Name = "xrTableCell134";
      this.xrTableCell134.StylePriority.UseFont = false;
      this.xrTableCell134.StylePriority.UseTextAlignment = false;
      this.xrTableCell134.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell134.Weight = 1.966615366972539;
      this.xrTableCell135.Font = new Font("Arial", 9.75f);
      this.xrTableCell135.Multiline = true;
      this.xrTableCell135.Name = "xrTableCell135";
      this.xrTableCell135.StylePriority.UseFont = false;
      this.xrTableCell135.StylePriority.UseTextAlignment = false;
      this.xrTableCell135.Text = "Kamyon Tamir Ustabaşı";
      this.xrTableCell135.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell135.Weight = 1.0;
      this.xrTableCell136.Font = new Font("Arial", 9.75f);
      this.xrTableCell136.Multiline = true;
      this.xrTableCell136.Name = "xrTableCell136";
      this.xrTableCell136.StylePriority.UseFont = false;
      this.xrTableCell136.StylePriority.UseTextAlignment = false;
      this.xrTableCell136.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell136.Weight = 1.0;
      this.xrTableCell137.Font = new Font("Arial", 9.75f);
      this.xrTableCell137.Multiline = true;
      this.xrTableCell137.Name = "xrTableCell137";
      this.xrTableCell137.StylePriority.UseFont = false;
      this.xrTableCell137.StylePriority.UseTextAlignment = false;
      this.xrTableCell137.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell137.Weight = 1.0;
      this.xrTableRow49.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell138,
        this.xrTableCell139,
        this.xrTableCell140,
        this.xrTableCell141,
        this.xrTableCell142
      });
      this.xrTableRow49.Name = "xrTableRow49";
      this.xrTableRow49.Weight = 1.0;
      this.xrTableCell138.Font = new Font("Arial", 9.75f);
      this.xrTableCell138.Multiline = true;
      this.xrTableCell138.Name = "xrTableCell138";
      this.xrTableCell138.StylePriority.UseFont = false;
      this.xrTableCell138.StylePriority.UseTextAlignment = false;
      this.xrTableCell138.Text = "10.";
      this.xrTableCell138.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell138.Weight = 0.33280442314331093;
      this.xrTableCell139.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[lastiksorumlusu]")
      });
      this.xrTableCell139.Font = new Font("Arial", 9.75f);
      this.xrTableCell139.Multiline = true;
      this.xrTableCell139.Name = "xrTableCell139";
      this.xrTableCell139.StylePriority.UseFont = false;
      this.xrTableCell139.StylePriority.UseTextAlignment = false;
      this.xrTableCell139.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell139.Weight = 1.966615366972539;
      this.xrTableCell140.Font = new Font("Arial", 9.75f);
      this.xrTableCell140.Multiline = true;
      this.xrTableCell140.Name = "xrTableCell140";
      this.xrTableCell140.StylePriority.UseFont = false;
      this.xrTableCell140.StylePriority.UseTextAlignment = false;
      this.xrTableCell140.Text = "Oto Lastik Ustabaşı";
      this.xrTableCell140.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell140.Weight = 1.0;
      this.xrTableCell141.Font = new Font("Arial", 9.75f);
      this.xrTableCell141.Multiline = true;
      this.xrTableCell141.Name = "xrTableCell141";
      this.xrTableCell141.StylePriority.UseFont = false;
      this.xrTableCell141.StylePriority.UseTextAlignment = false;
      this.xrTableCell141.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell141.Weight = 1.0;
      this.xrTableCell142.Font = new Font("Arial", 9.75f);
      this.xrTableCell142.Multiline = true;
      this.xrTableCell142.Name = "xrTableCell142";
      this.xrTableCell142.StylePriority.UseFont = false;
      this.xrTableCell142.StylePriority.UseTextAlignment = false;
      this.xrTableCell142.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell142.Weight = 1.0;
      this.xrTableRow50.Cells.AddRange(new XRTableCell[5]
      {
        this.xrTableCell162,
        this.xrTableCell144,
        this.xrTableCell145,
        this.xrTableCell146,
        this.xrTableCell147
      });
      this.xrTableRow50.Name = "xrTableRow50";
      this.xrTableRow50.Weight = 1.0;
      this.xrTableCell144.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "[ambarayniyatsorumlusu]")
      });
      this.xrTableCell144.Font = new Font("Arial", 9.75f);
      this.xrTableCell144.Multiline = true;
      this.xrTableCell144.Name = "xrTableCell144";
      this.xrTableCell144.StylePriority.UseFont = false;
      this.xrTableCell144.StylePriority.UseTextAlignment = false;
      this.xrTableCell144.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell144.Weight = 1.966615366972539;
      this.xrTableCell145.Font = new Font("Arial", 9.75f);
      this.xrTableCell145.Multiline = true;
      this.xrTableCell145.Name = "xrTableCell145";
      this.xrTableCell145.StylePriority.UseFont = false;
      this.xrTableCell145.StylePriority.UseTextAlignment = false;
      this.xrTableCell145.Text = "Ambar Ayniyat Sorumlusu";
      this.xrTableCell145.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell145.Weight = 1.0;
      this.xrTableCell146.Font = new Font("Arial", 9.75f);
      this.xrTableCell146.Multiline = true;
      this.xrTableCell146.Name = "xrTableCell146";
      this.xrTableCell146.StylePriority.UseFont = false;
      this.xrTableCell146.StylePriority.UseTextAlignment = false;
      this.xrTableCell146.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell146.Weight = 1.0;
      this.xrTableCell147.Font = new Font("Arial", 9.75f);
      this.xrTableCell147.Multiline = true;
      this.xrTableCell147.Name = "xrTableCell147";
      this.xrTableCell147.StylePriority.UseFont = false;
      this.xrTableCell147.StylePriority.UseTextAlignment = false;
      this.xrTableCell147.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell147.Weight = 1.0;
      this.xrTableRow51.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell163
      });
      this.xrTableRow51.Name = "xrTableRow51";
      this.xrTableRow51.Weight = 1.0;
      this.xrTableRow52.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell164
      });
      this.xrTableRow52.Name = "xrTableRow52";
      this.xrTableRow52.Weight = 1.0;
      this.xrTableRow53.Cells.AddRange(new XRTableCell[3]
      {
        this.xrTableCell165,
        this.xrTableCell168,
        this.xrTableCell150
      });
      this.xrTableRow53.Name = "xrTableRow53";
      this.xrTableRow53.Weight = 1.0;
      this.xrTableCell150.Borders = BorderSide.None;
      this.xrTableCell150.Font = new Font("Arial", 9.75f);
      this.xrTableCell150.Multiline = true;
      this.xrTableCell150.Name = "xrTableCell150";
      this.xrTableCell150.StylePriority.UseBorders = false;
      this.xrTableCell150.StylePriority.UseFont = false;
      this.xrTableCell150.StylePriority.UseTextAlignment = false;
      this.xrTableCell150.Text = "Tarihi :23.06.2014";
      this.xrTableCell150.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell150.Weight = 5.0;
      this.xrTableCell162.Font = new Font("Arial", 9.75f);
      this.xrTableCell162.Multiline = true;
      this.xrTableCell162.Name = "xrTableCell162";
      this.xrTableCell162.StylePriority.UseFont = false;
      this.xrTableCell162.StylePriority.UseTextAlignment = false;
      this.xrTableCell162.Text = "11.";
      this.xrTableCell162.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell162.Weight = 0.33280442314331093;
      this.xrTableCell163.Borders = BorderSide.None;
      this.xrTableCell163.Font = new Font("Arial", 9.75f);
      this.xrTableCell163.Multiline = true;
      this.xrTableCell163.Name = "xrTableCell163";
      this.xrTableCell163.StylePriority.UseBorders = false;
      this.xrTableCell163.StylePriority.UseFont = false;
      this.xrTableCell163.StylePriority.UseTextAlignment = false;
      this.xrTableCell163.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell163.Weight = 15.0;
      this.xrTableCell164.Borders = BorderSide.None;
      this.xrTableCell164.Font = new Font("Arial", 9.75f);
      this.xrTableCell164.Multiline = true;
      this.xrTableCell164.Name = "xrTableCell164";
      this.xrTableCell164.StylePriority.UseBorders = false;
      this.xrTableCell164.StylePriority.UseFont = false;
      this.xrTableCell164.StylePriority.UseTextAlignment = false;
      this.xrTableCell164.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell164.Weight = 15.0;
      this.xrTableCell165.Borders = BorderSide.None;
      this.xrTableCell165.Font = new Font("Arial", 9.75f);
      this.xrTableCell165.Multiline = true;
      this.xrTableCell165.Name = "xrTableCell165";
      this.xrTableCell165.StylePriority.UseBorders = false;
      this.xrTableCell165.StylePriority.UseFont = false;
      this.xrTableCell165.StylePriority.UseTextAlignment = false;
      this.xrTableCell165.Text = "Form No: FR-028";
      this.xrTableCell165.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell165.Weight = 5.0;
      this.xrTableCell168.Borders = BorderSide.None;
      this.xrTableCell168.Font = new Font("Arial", 9.75f);
      this.xrTableCell168.Multiline = true;
      this.xrTableCell168.Name = "xrTableCell168";
      this.xrTableCell168.StylePriority.UseBorders = false;
      this.xrTableCell168.StylePriority.UseFont = false;
      this.xrTableCell168.StylePriority.UseTextAlignment = false;
      this.xrTableCell168.Text = "Revizyon No: 5 Yayın";
      this.xrTableCell168.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell168.Weight = 5.0;
      this.id.Description = "id";
      this.id.Name = "id";
      this.id.Type = typeof (int);
      this.id.ValueInfo = "0";
      this.Bands.AddRange(new Band[4]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.ReportHeader,
        (Band) this.Detail
      });
      this.ComponentStorage.AddRange(new IComponent[1]
      {
        (IComponent) this.sqlDataSource1
      });
      this.DataMember = "TBLPERTOPLANTI_1";
      this.DataSource = (object) this.sqlDataSource1;
      this.FilterString = "[ID] = ?id";
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(40, 40, 82, 39);
      this.PageHeight = 1169;
      this.PageWidth = 827;
      this.PaperKind = PaperKind.A4;
      this.Parameters.AddRange(new Parameter[1]{ this.id });
      this.StyleSheet.AddRange(new XRControlStyle[5]
      {
        this.Title,
        this.DetailCaption1,
        this.DetailData1,
        this.DetailData3_Odd,
        this.PageInfo
      });
      this.Version = "20.1";
      this.xrTable1.EndInit();
      this.xrTable2.EndInit();
      this.xrTable3.EndInit();
      this.EndInit();
    }
  }
}
