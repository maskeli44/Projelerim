// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Atolye.isemriRaporYag
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace Makina_Ikmal.Atolye
{
  public class isemriRaporYag : XtraReport
  {
    private IContainer components = (IContainer) null;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel11;
    private XRPictureBox xrPictureBox2;
    private XRPictureBox xrPictureBox1;
    private Parameter plaka;
    private Parameter aracBilgisi;
    private Parameter isEmirkod;
    private Parameter bariza;
    private Parameter bakimyeri;
    private Parameter km;
    private Parameter ctarih;
    private Parameter gsaat;
    private Parameter csaat;
    private Parameter sofor;
    private Parameter atolyesef;
    private Parameter gtarih;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRTable xrTable117;
    private XRTableRow xrTableRow117;
    private XRTableCell xrTableCell117;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRTable xrTable228;
    private XRTableRow xrTableRow228;
    private XRTableCell xrTableCell228;
    private XRTable xrTable227;
    private XRTableRow xrTableRow227;
    private XRTableCell xrTableCell227;
    private XRTable xrTable226;
    private XRTableRow xrTableRow226;
    private XRTableCell xrTableCell226;
    private XRTable xrTable225;
    private XRTableRow xrTableRow225;
    private XRTableCell xrTableCell225;
    private XRTable xrTable224;
    private XRTableRow xrTableRow224;
    private XRTableCell xrTableCell224;
    private XRTable xrTable223;
    private XRTableRow xrTableRow223;
    private XRTableCell xrTableCell223;
    private XRTable xrTable222;
    private XRTableRow xrTableRow222;
    private XRTableCell xrTableCell222;
    private XRTable xrTable221;
    private XRTableRow xrTableRow221;
    private XRTableCell xrTableCell221;
    private XRTable xrTable220;
    private XRTableRow xrTableRow220;
    private XRTableCell xrTableCell220;
    private XRTable xrTable219;
    private XRTableRow xrTableRow219;
    private XRTableCell xrTableCell219;
    private XRTable xrTable218;
    private XRTableRow xrTableRow218;
    private XRTableCell xrTableCell218;
    private XRTable xrTable217;
    private XRTableRow xrTableRow217;
    private XRTableCell xrTableCell217;
    private XRTable xrTable216;
    private XRTableRow xrTableRow216;
    private XRTableCell xrTableCell216;
    private XRTable xrTable215;
    private XRTableRow xrTableRow215;
    private XRTableCell xrTableCell215;
    private XRTable xrTable214;
    private XRTableRow xrTableRow214;
    private XRTableCell xrTableCell214;
    private XRTable xrTable213;
    private XRTableRow xrTableRow213;
    private XRTableCell xrTableCell213;
    private XRTable xrTable212;
    private XRTableRow xrTableRow212;
    private XRTableCell xrTableCell212;
    private XRTable xrTable211;
    private XRTableRow xrTableRow211;
    private XRTableCell xrTableCell211;
    private XRTable xrTable210;
    private XRTableRow xrTableRow210;
    private XRTableCell xrTableCell210;
    private XRTable xrTable209;
    private XRTableRow xrTableRow209;
    private XRTableCell xrTableCell209;
    private XRTable xrTable208;
    private XRTableRow xrTableRow208;
    private XRTableCell xrTableCell208;
    private XRTable xrTable207;
    private XRTableRow xrTableRow207;
    private XRTableCell xrTableCell207;
    private XRTable xrTable206;
    private XRTableRow xrTableRow206;
    private XRTableCell xrTableCell206;
    private XRTable xrTable205;
    private XRTableRow xrTableRow205;
    private XRTableCell xrTableCell205;
    private XRTable xrTable204;
    private XRTableRow xrTableRow204;
    private XRTableCell xrTableCell204;
    private XRTable xrTable203;
    private XRTableRow xrTableRow203;
    private XRTableCell xrTableCell203;
    private XRTable xrTable202;
    private XRTableRow xrTableRow202;
    private XRTableCell xrTableCell202;
    private XRTable xrTable201;
    private XRTableRow xrTableRow201;
    private XRTableCell xrTableCell201;
    private XRTable xrTable200;
    private XRTableRow xrTableRow200;
    private XRTableCell xrTableCell200;
    private XRTable xrTable199;
    private XRTableRow xrTableRow199;
    private XRTableCell xrTableCell199;
    private XRTable xrTable198;
    private XRTableRow xrTableRow198;
    private XRTableCell xrTableCell198;
    private XRTable xrTable197;
    private XRTableRow xrTableRow197;
    private XRTableCell xrTableCell197;
    private XRTable xrTable196;
    private XRTableRow xrTableRow196;
    private XRTableCell xrTableCell196;
    private XRTable xrTable195;
    private XRTableRow xrTableRow195;
    private XRTableCell xrTableCell195;
    private XRTable xrTable194;
    private XRTableRow xrTableRow194;
    private XRTableCell xrTableCell194;
    private XRTable xrTable193;
    private XRTableRow xrTableRow193;
    private XRTableCell xrTableCell193;
    private XRTable xrTable192;
    private XRTableRow xrTableRow192;
    private XRTableCell xrTableCell192;
    private XRTable xrTable191;
    private XRTableRow xrTableRow191;
    private XRTableCell xrTableCell191;
    private XRTable xrTable190;
    private XRTableRow xrTableRow190;
    private XRTableCell xrTableCell190;
    private XRTable xrTable189;
    private XRTableRow xrTableRow189;
    private XRTableCell xrTableCell189;
    private XRTable xrTable188;
    private XRTableRow xrTableRow188;
    private XRTableCell xrTableCell188;
    private XRTable xrTable187;
    private XRTableRow xrTableRow187;
    private XRTableCell xrTableCell187;
    private XRTable xrTable186;
    private XRTableRow xrTableRow186;
    private XRTableCell xrTableCell186;
    private XRTable xrTable185;
    private XRTableRow xrTableRow185;
    private XRTableCell xrTableCell185;
    private XRTable xrTable184;
    private XRTableRow xrTableRow184;
    private XRTableCell xrTableCell184;
    private XRTable xrTable183;
    private XRTableRow xrTableRow183;
    private XRTableCell xrTableCell183;
    private XRTable xrTable182;
    private XRTableRow xrTableRow182;
    private XRTableCell xrTableCell182;
    private XRTable xrTable181;
    private XRTableRow xrTableRow181;
    private XRTableCell xrTableCell181;
    private XRTable xrTable180;
    private XRTableRow xrTableRow180;
    private XRTableCell xrTableCell180;
    private XRTable xrTable179;
    private XRTableRow xrTableRow179;
    private XRTableCell xrTableCell179;
    private XRTable xrTable178;
    private XRTableRow xrTableRow178;
    private XRTableCell xrTableCell178;
    private XRTable xrTable177;
    private XRTableRow xrTableRow177;
    private XRTableCell xrTableCell177;
    private XRTable xrTable176;
    private XRTableRow xrTableRow176;
    private XRTableCell xrTableCell176;
    private XRTable xrTable175;
    private XRTableRow xrTableRow175;
    private XRTableCell xrTableCell175;
    private XRTable xrTable174;
    private XRTableRow xrTableRow174;
    private XRTableCell xrTableCell174;
    private XRTable xrTable173;
    private XRTableRow xrTableRow173;
    private XRTableCell xrTableCell173;
    private XRTable xrTable172;
    private XRTableRow xrTableRow172;
    private XRTableCell xrTableCell172;
    private XRTable xrTable171;
    private XRTableRow xrTableRow171;
    private XRTableCell xrTableCell171;
    private XRTable xrTable170;
    private XRTableRow xrTableRow170;
    private XRTableCell xrTableCell170;
    private XRTable xrTable169;
    private XRTableRow xrTableRow169;
    private XRTableCell xrTableCell169;
    private XRTable xrTable168;
    private XRTableRow xrTableRow168;
    private XRTableCell xrTableCell168;
    private XRTable xrTable167;
    private XRTableRow xrTableRow167;
    private XRTableCell xrTableCell167;
    private XRTable xrTable166;
    private XRTableRow xrTableRow166;
    private XRTableCell xrTableCell166;
    private XRTable xrTable165;
    private XRTableRow xrTableRow165;
    private XRTableCell xrTableCell165;
    private XRTable xrTable164;
    private XRTableRow xrTableRow164;
    private XRTableCell xrTableCell164;
    private XRTable xrTable163;
    private XRTableRow xrTableRow163;
    private XRTableCell xrTableCell163;
    private XRTable xrTable162;
    private XRTableRow xrTableRow162;
    private XRTableCell xrTableCell162;
    private XRTable xrTable161;
    private XRTableRow xrTableRow161;
    private XRTableCell xrTableCell161;
    private XRTable xrTable160;
    private XRTableRow xrTableRow160;
    private XRTableCell xrTableCell160;
    private XRTable xrTable159;
    private XRTableRow xrTableRow159;
    private XRTableCell xrTableCell159;
    private XRTable xrTable158;
    private XRTableRow xrTableRow158;
    private XRTableCell xrTableCell158;
    private XRTable xrTable157;
    private XRTableRow xrTableRow157;
    private XRTableCell xrTableCell157;
    private XRTable xrTable156;
    private XRTableRow xrTableRow156;
    private XRTableCell xrTableCell156;
    private XRTable xrTable155;
    private XRTableRow xrTableRow155;
    private XRTableCell xrTableCell155;
    private XRTable xrTable154;
    private XRTableRow xrTableRow154;
    private XRTableCell xrTableCell154;
    private XRTable xrTable153;
    private XRTableRow xrTableRow153;
    private XRTableCell xrTableCell153;
    private XRTable xrTable152;
    private XRTableRow xrTableRow152;
    private XRTableCell xrTableCell152;
    private XRTable xrTable151;
    private XRTableRow xrTableRow151;
    private XRTableCell xrTableCell151;
    private XRTable xrTable150;
    private XRTableRow xrTableRow150;
    private XRTableCell xrTableCell150;
    private XRTable xrTable149;
    private XRTableRow xrTableRow149;
    private XRTableCell xrTableCell149;
    private XRTable xrTable148;
    private XRTableRow xrTableRow148;
    private XRTableCell xrTableCell148;
    private XRTable xrTable147;
    private XRTableRow xrTableRow147;
    private XRTableCell xrTableCell147;
    private XRTable xrTable146;
    private XRTableRow xrTableRow146;
    private XRTableCell xrTableCell146;
    private XRTable xrTable145;
    private XRTableRow xrTableRow145;
    private XRTableCell xrTableCell145;
    private XRTable xrTable144;
    private XRTableRow xrTableRow144;
    private XRTableCell xrTableCell144;
    private XRTable xrTable143;
    private XRTableRow xrTableRow143;
    private XRTableCell xrTableCell143;
    private XRTable xrTable142;
    private XRTableRow xrTableRow142;
    private XRTableCell xrTableCell142;
    private XRTable xrTable141;
    private XRTableRow xrTableRow141;
    private XRTableCell xrTableCell141;
    private XRTable xrTable140;
    private XRTableRow xrTableRow140;
    private XRTableCell xrTableCell140;
    private XRTable xrTable139;
    private XRTableRow xrTableRow139;
    private XRTableCell xrTableCell139;
    private XRTable xrTable138;
    private XRTableRow xrTableRow138;
    private XRTableCell xrTableCell138;
    private XRTable xrTable137;
    private XRTableRow xrTableRow137;
    private XRTableCell xrTableCell137;
    private XRTable xrTable136;
    private XRTableRow xrTableRow136;
    private XRTableCell xrTableCell136;
    private XRTable xrTable135;
    private XRTableRow xrTableRow135;
    private XRTableCell xrTableCell135;
    private XRTable xrTable134;
    private XRTableRow xrTableRow134;
    private XRTableCell xrTableCell134;
    private XRTable xrTable133;
    private XRTableRow xrTableRow133;
    private XRTableCell xrTableCell133;
    private XRTable xrTable132;
    private XRTableRow xrTableRow132;
    private XRTableCell xrTableCell132;
    private XRTable xrTable131;
    private XRTableRow xrTableRow131;
    private XRTableCell xrTableCell131;
    private XRTable xrTable130;
    private XRTableRow xrTableRow130;
    private XRTableCell xrTableCell130;
    private XRTable xrTable129;
    private XRTableRow xrTableRow129;
    private XRTableCell xrTableCell129;
    private XRTable xrTable128;
    private XRTableRow xrTableRow128;
    private XRTableCell xrTableCell128;
    private XRTable xrTable127;
    private XRTableRow xrTableRow127;
    private XRTableCell xrTableCell127;
    private XRTable xrTable126;
    private XRTableRow xrTableRow126;
    private XRTableCell xrTableCell126;
    private XRTable xrTable125;
    private XRTableRow xrTableRow125;
    private XRTableCell xrTableCell125;
    private XRTable xrTable124;
    private XRTableRow xrTableRow124;
    private XRTableCell xrTableCell124;
    private XRTable xrTable123;
    private XRTableRow xrTableRow123;
    private XRTableCell xrTableCell123;
    private XRTable xrTable122;
    private XRTableRow xrTableRow122;
    private XRTableCell xrTableCell122;
    private XRTable xrTable121;
    private XRTableRow xrTableRow121;
    private XRTableCell xrTableCell121;
    private XRTable xrTable120;
    private XRTableRow xrTableRow120;
    private XRTableCell xrTableCell120;
    private XRTable xrTable119;
    private XRTableRow xrTableRow119;
    private XRTableCell xrTableCell119;
    private XRTable xrTable118;
    private XRTableRow xrTableRow118;
    private XRTableCell xrTableCell118;
    private XRLabel xrLabel8;
    private XRTable xrTable116;
    private XRTableRow xrTableRow116;
    private XRTableCell xrTableCell116;
    private XRTable xrTable115;
    private XRTableRow xrTableRow115;
    private XRTableCell xrTableCell115;

    public isemriRaporYag() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.TopMargin = new TopMarginBand();
      this.xrLabel14 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrPictureBox2 = new XRPictureBox();
      this.xrPictureBox1 = new XRPictureBox();
      this.BottomMargin = new BottomMarginBand();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.xrTable117 = new XRTable();
      this.xrTableRow117 = new XRTableRow();
      this.xrTableCell117 = new XRTableCell();
      this.xrLabel7 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrTable228 = new XRTable();
      this.xrTableRow228 = new XRTableRow();
      this.xrTableCell228 = new XRTableCell();
      this.xrTable227 = new XRTable();
      this.xrTableRow227 = new XRTableRow();
      this.xrTableCell227 = new XRTableCell();
      this.xrTable226 = new XRTable();
      this.xrTableRow226 = new XRTableRow();
      this.xrTableCell226 = new XRTableCell();
      this.xrTable225 = new XRTable();
      this.xrTableRow225 = new XRTableRow();
      this.xrTableCell225 = new XRTableCell();
      this.xrTable224 = new XRTable();
      this.xrTableRow224 = new XRTableRow();
      this.xrTableCell224 = new XRTableCell();
      this.xrTable223 = new XRTable();
      this.xrTableRow223 = new XRTableRow();
      this.xrTableCell223 = new XRTableCell();
      this.xrTable222 = new XRTable();
      this.xrTableRow222 = new XRTableRow();
      this.xrTableCell222 = new XRTableCell();
      this.xrTable221 = new XRTable();
      this.xrTableRow221 = new XRTableRow();
      this.xrTableCell221 = new XRTableCell();
      this.xrTable220 = new XRTable();
      this.xrTableRow220 = new XRTableRow();
      this.xrTableCell220 = new XRTableCell();
      this.xrTable219 = new XRTable();
      this.xrTableRow219 = new XRTableRow();
      this.xrTableCell219 = new XRTableCell();
      this.xrTable218 = new XRTable();
      this.xrTableRow218 = new XRTableRow();
      this.xrTableCell218 = new XRTableCell();
      this.xrTable217 = new XRTable();
      this.xrTableRow217 = new XRTableRow();
      this.xrTableCell217 = new XRTableCell();
      this.xrTable216 = new XRTable();
      this.xrTableRow216 = new XRTableRow();
      this.xrTableCell216 = new XRTableCell();
      this.xrTable215 = new XRTable();
      this.xrTableRow215 = new XRTableRow();
      this.xrTableCell215 = new XRTableCell();
      this.xrTable214 = new XRTable();
      this.xrTableRow214 = new XRTableRow();
      this.xrTableCell214 = new XRTableCell();
      this.xrTable213 = new XRTable();
      this.xrTableRow213 = new XRTableRow();
      this.xrTableCell213 = new XRTableCell();
      this.xrTable212 = new XRTable();
      this.xrTableRow212 = new XRTableRow();
      this.xrTableCell212 = new XRTableCell();
      this.xrTable211 = new XRTable();
      this.xrTableRow211 = new XRTableRow();
      this.xrTableCell211 = new XRTableCell();
      this.xrTable210 = new XRTable();
      this.xrTableRow210 = new XRTableRow();
      this.xrTableCell210 = new XRTableCell();
      this.xrTable209 = new XRTable();
      this.xrTableRow209 = new XRTableRow();
      this.xrTableCell209 = new XRTableCell();
      this.xrTable208 = new XRTable();
      this.xrTableRow208 = new XRTableRow();
      this.xrTableCell208 = new XRTableCell();
      this.xrTable207 = new XRTable();
      this.xrTableRow207 = new XRTableRow();
      this.xrTableCell207 = new XRTableCell();
      this.xrTable206 = new XRTable();
      this.xrTableRow206 = new XRTableRow();
      this.xrTableCell206 = new XRTableCell();
      this.xrTable205 = new XRTable();
      this.xrTableRow205 = new XRTableRow();
      this.xrTableCell205 = new XRTableCell();
      this.xrTable204 = new XRTable();
      this.xrTableRow204 = new XRTableRow();
      this.xrTableCell204 = new XRTableCell();
      this.xrTable203 = new XRTable();
      this.xrTableRow203 = new XRTableRow();
      this.xrTableCell203 = new XRTableCell();
      this.xrTable202 = new XRTable();
      this.xrTableRow202 = new XRTableRow();
      this.xrTableCell202 = new XRTableCell();
      this.xrTable201 = new XRTable();
      this.xrTableRow201 = new XRTableRow();
      this.xrTableCell201 = new XRTableCell();
      this.xrTable200 = new XRTable();
      this.xrTableRow200 = new XRTableRow();
      this.xrTableCell200 = new XRTableCell();
      this.xrTable199 = new XRTable();
      this.xrTableRow199 = new XRTableRow();
      this.xrTableCell199 = new XRTableCell();
      this.xrTable198 = new XRTable();
      this.xrTableRow198 = new XRTableRow();
      this.xrTableCell198 = new XRTableCell();
      this.xrTable197 = new XRTable();
      this.xrTableRow197 = new XRTableRow();
      this.xrTableCell197 = new XRTableCell();
      this.xrTable196 = new XRTable();
      this.xrTableRow196 = new XRTableRow();
      this.xrTableCell196 = new XRTableCell();
      this.xrTable195 = new XRTable();
      this.xrTableRow195 = new XRTableRow();
      this.xrTableCell195 = new XRTableCell();
      this.xrTable194 = new XRTable();
      this.xrTableRow194 = new XRTableRow();
      this.xrTableCell194 = new XRTableCell();
      this.xrTable193 = new XRTable();
      this.xrTableRow193 = new XRTableRow();
      this.xrTableCell193 = new XRTableCell();
      this.xrTable192 = new XRTable();
      this.xrTableRow192 = new XRTableRow();
      this.xrTableCell192 = new XRTableCell();
      this.xrTable191 = new XRTable();
      this.xrTableRow191 = new XRTableRow();
      this.xrTableCell191 = new XRTableCell();
      this.xrTable190 = new XRTable();
      this.xrTableRow190 = new XRTableRow();
      this.xrTableCell190 = new XRTableCell();
      this.xrTable189 = new XRTable();
      this.xrTableRow189 = new XRTableRow();
      this.xrTableCell189 = new XRTableCell();
      this.xrTable188 = new XRTable();
      this.xrTableRow188 = new XRTableRow();
      this.xrTableCell188 = new XRTableCell();
      this.xrTable187 = new XRTable();
      this.xrTableRow187 = new XRTableRow();
      this.xrTableCell187 = new XRTableCell();
      this.xrTable186 = new XRTable();
      this.xrTableRow186 = new XRTableRow();
      this.xrTableCell186 = new XRTableCell();
      this.xrTable185 = new XRTable();
      this.xrTableRow185 = new XRTableRow();
      this.xrTableCell185 = new XRTableCell();
      this.xrTable184 = new XRTable();
      this.xrTableRow184 = new XRTableRow();
      this.xrTableCell184 = new XRTableCell();
      this.xrTable183 = new XRTable();
      this.xrTableRow183 = new XRTableRow();
      this.xrTableCell183 = new XRTableCell();
      this.xrTable182 = new XRTable();
      this.xrTableRow182 = new XRTableRow();
      this.xrTableCell182 = new XRTableCell();
      this.xrTable181 = new XRTable();
      this.xrTableRow181 = new XRTableRow();
      this.xrTableCell181 = new XRTableCell();
      this.xrTable180 = new XRTable();
      this.xrTableRow180 = new XRTableRow();
      this.xrTableCell180 = new XRTableCell();
      this.xrTable179 = new XRTable();
      this.xrTableRow179 = new XRTableRow();
      this.xrTableCell179 = new XRTableCell();
      this.xrTable178 = new XRTable();
      this.xrTableRow178 = new XRTableRow();
      this.xrTableCell178 = new XRTableCell();
      this.xrTable177 = new XRTable();
      this.xrTableRow177 = new XRTableRow();
      this.xrTableCell177 = new XRTableCell();
      this.xrTable176 = new XRTable();
      this.xrTableRow176 = new XRTableRow();
      this.xrTableCell176 = new XRTableCell();
      this.xrTable175 = new XRTable();
      this.xrTableRow175 = new XRTableRow();
      this.xrTableCell175 = new XRTableCell();
      this.xrTable174 = new XRTable();
      this.xrTableRow174 = new XRTableRow();
      this.xrTableCell174 = new XRTableCell();
      this.xrTable173 = new XRTable();
      this.xrTableRow173 = new XRTableRow();
      this.xrTableCell173 = new XRTableCell();
      this.xrTable172 = new XRTable();
      this.xrTableRow172 = new XRTableRow();
      this.xrTableCell172 = new XRTableCell();
      this.xrTable171 = new XRTable();
      this.xrTableRow171 = new XRTableRow();
      this.xrTableCell171 = new XRTableCell();
      this.xrTable170 = new XRTable();
      this.xrTableRow170 = new XRTableRow();
      this.xrTableCell170 = new XRTableCell();
      this.xrTable169 = new XRTable();
      this.xrTableRow169 = new XRTableRow();
      this.xrTableCell169 = new XRTableCell();
      this.xrTable168 = new XRTable();
      this.xrTableRow168 = new XRTableRow();
      this.xrTableCell168 = new XRTableCell();
      this.xrTable167 = new XRTable();
      this.xrTableRow167 = new XRTableRow();
      this.xrTableCell167 = new XRTableCell();
      this.xrTable166 = new XRTable();
      this.xrTableRow166 = new XRTableRow();
      this.xrTableCell166 = new XRTableCell();
      this.xrTable165 = new XRTable();
      this.xrTableRow165 = new XRTableRow();
      this.xrTableCell165 = new XRTableCell();
      this.xrTable164 = new XRTable();
      this.xrTableRow164 = new XRTableRow();
      this.xrTableCell164 = new XRTableCell();
      this.xrTable163 = new XRTable();
      this.xrTableRow163 = new XRTableRow();
      this.xrTableCell163 = new XRTableCell();
      this.xrTable162 = new XRTable();
      this.xrTableRow162 = new XRTableRow();
      this.xrTableCell162 = new XRTableCell();
      this.xrTable161 = new XRTable();
      this.xrTableRow161 = new XRTableRow();
      this.xrTableCell161 = new XRTableCell();
      this.xrTable160 = new XRTable();
      this.xrTableRow160 = new XRTableRow();
      this.xrTableCell160 = new XRTableCell();
      this.xrTable159 = new XRTable();
      this.xrTableRow159 = new XRTableRow();
      this.xrTableCell159 = new XRTableCell();
      this.xrTable158 = new XRTable();
      this.xrTableRow158 = new XRTableRow();
      this.xrTableCell158 = new XRTableCell();
      this.xrTable157 = new XRTable();
      this.xrTableRow157 = new XRTableRow();
      this.xrTableCell157 = new XRTableCell();
      this.xrTable156 = new XRTable();
      this.xrTableRow156 = new XRTableRow();
      this.xrTableCell156 = new XRTableCell();
      this.xrTable155 = new XRTable();
      this.xrTableRow155 = new XRTableRow();
      this.xrTableCell155 = new XRTableCell();
      this.xrTable154 = new XRTable();
      this.xrTableRow154 = new XRTableRow();
      this.xrTableCell154 = new XRTableCell();
      this.xrTable153 = new XRTable();
      this.xrTableRow153 = new XRTableRow();
      this.xrTableCell153 = new XRTableCell();
      this.xrTable152 = new XRTable();
      this.xrTableRow152 = new XRTableRow();
      this.xrTableCell152 = new XRTableCell();
      this.xrTable151 = new XRTable();
      this.xrTableRow151 = new XRTableRow();
      this.xrTableCell151 = new XRTableCell();
      this.xrTable150 = new XRTable();
      this.xrTableRow150 = new XRTableRow();
      this.xrTableCell150 = new XRTableCell();
      this.xrTable149 = new XRTable();
      this.xrTableRow149 = new XRTableRow();
      this.xrTableCell149 = new XRTableCell();
      this.xrTable148 = new XRTable();
      this.xrTableRow148 = new XRTableRow();
      this.xrTableCell148 = new XRTableCell();
      this.xrTable147 = new XRTable();
      this.xrTableRow147 = new XRTableRow();
      this.xrTableCell147 = new XRTableCell();
      this.xrTable146 = new XRTable();
      this.xrTableRow146 = new XRTableRow();
      this.xrTableCell146 = new XRTableCell();
      this.xrTable145 = new XRTable();
      this.xrTableRow145 = new XRTableRow();
      this.xrTableCell145 = new XRTableCell();
      this.xrTable144 = new XRTable();
      this.xrTableRow144 = new XRTableRow();
      this.xrTableCell144 = new XRTableCell();
      this.xrTable143 = new XRTable();
      this.xrTableRow143 = new XRTableRow();
      this.xrTableCell143 = new XRTableCell();
      this.xrTable142 = new XRTable();
      this.xrTableRow142 = new XRTableRow();
      this.xrTableCell142 = new XRTableCell();
      this.xrTable141 = new XRTable();
      this.xrTableRow141 = new XRTableRow();
      this.xrTableCell141 = new XRTableCell();
      this.xrTable140 = new XRTable();
      this.xrTableRow140 = new XRTableRow();
      this.xrTableCell140 = new XRTableCell();
      this.xrTable139 = new XRTable();
      this.xrTableRow139 = new XRTableRow();
      this.xrTableCell139 = new XRTableCell();
      this.xrTable138 = new XRTable();
      this.xrTableRow138 = new XRTableRow();
      this.xrTableCell138 = new XRTableCell();
      this.xrTable137 = new XRTable();
      this.xrTableRow137 = new XRTableRow();
      this.xrTableCell137 = new XRTableCell();
      this.xrTable136 = new XRTable();
      this.xrTableRow136 = new XRTableRow();
      this.xrTableCell136 = new XRTableCell();
      this.xrTable135 = new XRTable();
      this.xrTableRow135 = new XRTableRow();
      this.xrTableCell135 = new XRTableCell();
      this.xrTable134 = new XRTable();
      this.xrTableRow134 = new XRTableRow();
      this.xrTableCell134 = new XRTableCell();
      this.xrTable133 = new XRTable();
      this.xrTableRow133 = new XRTableRow();
      this.xrTableCell133 = new XRTableCell();
      this.xrTable132 = new XRTable();
      this.xrTableRow132 = new XRTableRow();
      this.xrTableCell132 = new XRTableCell();
      this.xrTable131 = new XRTable();
      this.xrTableRow131 = new XRTableRow();
      this.xrTableCell131 = new XRTableCell();
      this.xrTable130 = new XRTable();
      this.xrTableRow130 = new XRTableRow();
      this.xrTableCell130 = new XRTableCell();
      this.xrTable129 = new XRTable();
      this.xrTableRow129 = new XRTableRow();
      this.xrTableCell129 = new XRTableCell();
      this.xrTable128 = new XRTable();
      this.xrTableRow128 = new XRTableRow();
      this.xrTableCell128 = new XRTableCell();
      this.xrTable127 = new XRTable();
      this.xrTableRow127 = new XRTableRow();
      this.xrTableCell127 = new XRTableCell();
      this.xrTable126 = new XRTable();
      this.xrTableRow126 = new XRTableRow();
      this.xrTableCell126 = new XRTableCell();
      this.xrTable125 = new XRTable();
      this.xrTableRow125 = new XRTableRow();
      this.xrTableCell125 = new XRTableCell();
      this.xrTable124 = new XRTable();
      this.xrTableRow124 = new XRTableRow();
      this.xrTableCell124 = new XRTableCell();
      this.xrTable123 = new XRTable();
      this.xrTableRow123 = new XRTableRow();
      this.xrTableCell123 = new XRTableCell();
      this.xrTable122 = new XRTable();
      this.xrTableRow122 = new XRTableRow();
      this.xrTableCell122 = new XRTableCell();
      this.xrTable121 = new XRTable();
      this.xrTableRow121 = new XRTableRow();
      this.xrTableCell121 = new XRTableCell();
      this.xrTable120 = new XRTable();
      this.xrTableRow120 = new XRTableRow();
      this.xrTableCell120 = new XRTableCell();
      this.xrTable119 = new XRTable();
      this.xrTableRow119 = new XRTableRow();
      this.xrTableCell119 = new XRTableCell();
      this.xrTable118 = new XRTable();
      this.xrTableRow118 = new XRTableRow();
      this.xrTableCell118 = new XRTableCell();
      this.xrLabel8 = new XRLabel();
      this.xrTable116 = new XRTable();
      this.xrTableRow116 = new XRTableRow();
      this.xrTableCell116 = new XRTableCell();
      this.xrTable115 = new XRTable();
      this.xrTableRow115 = new XRTableRow();
      this.xrTableCell115 = new XRTableCell();
      this.Detail = new DetailBand();
      this.plaka = new Parameter();
      this.aracBilgisi = new Parameter();
      this.isEmirkod = new Parameter();
      this.bariza = new Parameter();
      this.bakimyeri = new Parameter();
      this.km = new Parameter();
      this.ctarih = new Parameter();
      this.gsaat = new Parameter();
      this.csaat = new Parameter();
      this.sofor = new Parameter();
      this.atolyesef = new Parameter();
      this.gtarih = new Parameter();
      this.xrTable117.BeginInit();
      this.xrTable228.BeginInit();
      this.xrTable227.BeginInit();
      this.xrTable226.BeginInit();
      this.xrTable225.BeginInit();
      this.xrTable224.BeginInit();
      this.xrTable223.BeginInit();
      this.xrTable222.BeginInit();
      this.xrTable221.BeginInit();
      this.xrTable220.BeginInit();
      this.xrTable219.BeginInit();
      this.xrTable218.BeginInit();
      this.xrTable217.BeginInit();
      this.xrTable216.BeginInit();
      this.xrTable215.BeginInit();
      this.xrTable214.BeginInit();
      this.xrTable213.BeginInit();
      this.xrTable212.BeginInit();
      this.xrTable211.BeginInit();
      this.xrTable210.BeginInit();
      this.xrTable209.BeginInit();
      this.xrTable208.BeginInit();
      this.xrTable207.BeginInit();
      this.xrTable206.BeginInit();
      this.xrTable205.BeginInit();
      this.xrTable204.BeginInit();
      this.xrTable203.BeginInit();
      this.xrTable202.BeginInit();
      this.xrTable201.BeginInit();
      this.xrTable200.BeginInit();
      this.xrTable199.BeginInit();
      this.xrTable198.BeginInit();
      this.xrTable197.BeginInit();
      this.xrTable196.BeginInit();
      this.xrTable195.BeginInit();
      this.xrTable194.BeginInit();
      this.xrTable193.BeginInit();
      this.xrTable192.BeginInit();
      this.xrTable191.BeginInit();
      this.xrTable190.BeginInit();
      this.xrTable189.BeginInit();
      this.xrTable188.BeginInit();
      this.xrTable187.BeginInit();
      this.xrTable186.BeginInit();
      this.xrTable185.BeginInit();
      this.xrTable184.BeginInit();
      this.xrTable183.BeginInit();
      this.xrTable182.BeginInit();
      this.xrTable181.BeginInit();
      this.xrTable180.BeginInit();
      this.xrTable179.BeginInit();
      this.xrTable178.BeginInit();
      this.xrTable177.BeginInit();
      this.xrTable176.BeginInit();
      this.xrTable175.BeginInit();
      this.xrTable174.BeginInit();
      this.xrTable173.BeginInit();
      this.xrTable172.BeginInit();
      this.xrTable171.BeginInit();
      this.xrTable170.BeginInit();
      this.xrTable169.BeginInit();
      this.xrTable168.BeginInit();
      this.xrTable167.BeginInit();
      this.xrTable166.BeginInit();
      this.xrTable165.BeginInit();
      this.xrTable164.BeginInit();
      this.xrTable163.BeginInit();
      this.xrTable162.BeginInit();
      this.xrTable161.BeginInit();
      this.xrTable160.BeginInit();
      this.xrTable159.BeginInit();
      this.xrTable158.BeginInit();
      this.xrTable157.BeginInit();
      this.xrTable156.BeginInit();
      this.xrTable155.BeginInit();
      this.xrTable154.BeginInit();
      this.xrTable153.BeginInit();
      this.xrTable152.BeginInit();
      this.xrTable151.BeginInit();
      this.xrTable150.BeginInit();
      this.xrTable149.BeginInit();
      this.xrTable148.BeginInit();
      this.xrTable147.BeginInit();
      this.xrTable146.BeginInit();
      this.xrTable145.BeginInit();
      this.xrTable144.BeginInit();
      this.xrTable143.BeginInit();
      this.xrTable142.BeginInit();
      this.xrTable141.BeginInit();
      this.xrTable140.BeginInit();
      this.xrTable139.BeginInit();
      this.xrTable138.BeginInit();
      this.xrTable137.BeginInit();
      this.xrTable136.BeginInit();
      this.xrTable135.BeginInit();
      this.xrTable134.BeginInit();
      this.xrTable133.BeginInit();
      this.xrTable132.BeginInit();
      this.xrTable131.BeginInit();
      this.xrTable130.BeginInit();
      this.xrTable129.BeginInit();
      this.xrTable128.BeginInit();
      this.xrTable127.BeginInit();
      this.xrTable126.BeginInit();
      this.xrTable125.BeginInit();
      this.xrTable124.BeginInit();
      this.xrTable123.BeginInit();
      this.xrTable122.BeginInit();
      this.xrTable121.BeginInit();
      this.xrTable120.BeginInit();
      this.xrTable119.BeginInit();
      this.xrTable118.BeginInit();
      this.xrTable116.BeginInit();
      this.xrTable115.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.xrPictureBox1
      });
      this.TopMargin.HeightF = 96.20832f;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.SnapLinePadding = new PaddingInfo(0, 0, 0, 0, 100f);
      this.xrLabel14.Font = new Font("Arial", 8f);
      this.xrLabel14.LocationFloat = new PointFloat(100f, 56.50004f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(518.2097f, 17.99998f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Destek Hizmetleri Daire Başkanlığı Makine İkmal Şube Müdürlüğü";
      this.xrLabel14.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel13.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel13.LocationFloat = new PointFloat(100f, 36.66668f);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(518.2098f, 17.99998f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "ŞANLIURFA BÜYÜKŞEHİR BAŞKANLIĞI";
      this.xrLabel13.TextAlignment = TextAlignment.TopCenter;
      this.xrLabel11.Font = new Font("Arial", 11f, FontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(100f, 18.6667f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(518.2097f, 17.99998f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "T.C. ";
      this.xrLabel11.TextAlignment = TextAlignment.TopCenter;
      this.xrPictureBox2.ImageSource = new ImageSource((Image) Resources.isobelgesi, true);
      this.xrPictureBox2.LocationFloat = new PointFloat(618.2097f, 0.0f);
      this.xrPictureBox2.Name = "xrPictureBox2";
      this.xrPictureBox2.SizeF = new SizeF(145.8459f, 90f);
      this.xrPictureBox1.ImageSource = new ImageSource((Image) Resources.logo, true);
      this.xrPictureBox1.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new SizeF(100f, 90f);
      this.xrPictureBox1.Sizing = ImageSizeMode.StretchImage;
      this.BottomMargin.Controls.AddRange(new XRControl[120]
      {
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrTable117,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrTable228,
        (XRControl) this.xrTable227,
        (XRControl) this.xrTable226,
        (XRControl) this.xrTable225,
        (XRControl) this.xrTable224,
        (XRControl) this.xrTable223,
        (XRControl) this.xrTable222,
        (XRControl) this.xrTable221,
        (XRControl) this.xrTable220,
        (XRControl) this.xrTable219,
        (XRControl) this.xrTable218,
        (XRControl) this.xrTable217,
        (XRControl) this.xrTable216,
        (XRControl) this.xrTable215,
        (XRControl) this.xrTable214,
        (XRControl) this.xrTable213,
        (XRControl) this.xrTable212,
        (XRControl) this.xrTable211,
        (XRControl) this.xrTable210,
        (XRControl) this.xrTable209,
        (XRControl) this.xrTable208,
        (XRControl) this.xrTable207,
        (XRControl) this.xrTable206,
        (XRControl) this.xrTable205,
        (XRControl) this.xrTable204,
        (XRControl) this.xrTable203,
        (XRControl) this.xrTable202,
        (XRControl) this.xrTable201,
        (XRControl) this.xrTable200,
        (XRControl) this.xrTable199,
        (XRControl) this.xrTable198,
        (XRControl) this.xrTable197,
        (XRControl) this.xrTable196,
        (XRControl) this.xrTable195,
        (XRControl) this.xrTable194,
        (XRControl) this.xrTable193,
        (XRControl) this.xrTable192,
        (XRControl) this.xrTable191,
        (XRControl) this.xrTable190,
        (XRControl) this.xrTable189,
        (XRControl) this.xrTable188,
        (XRControl) this.xrTable187,
        (XRControl) this.xrTable186,
        (XRControl) this.xrTable185,
        (XRControl) this.xrTable184,
        (XRControl) this.xrTable183,
        (XRControl) this.xrTable182,
        (XRControl) this.xrTable181,
        (XRControl) this.xrTable180,
        (XRControl) this.xrTable179,
        (XRControl) this.xrTable178,
        (XRControl) this.xrTable177,
        (XRControl) this.xrTable176,
        (XRControl) this.xrTable175,
        (XRControl) this.xrTable174,
        (XRControl) this.xrTable173,
        (XRControl) this.xrTable172,
        (XRControl) this.xrTable171,
        (XRControl) this.xrTable170,
        (XRControl) this.xrTable169,
        (XRControl) this.xrTable168,
        (XRControl) this.xrTable167,
        (XRControl) this.xrTable166,
        (XRControl) this.xrTable165,
        (XRControl) this.xrTable164,
        (XRControl) this.xrTable163,
        (XRControl) this.xrTable162,
        (XRControl) this.xrTable161,
        (XRControl) this.xrTable160,
        (XRControl) this.xrTable159,
        (XRControl) this.xrTable158,
        (XRControl) this.xrTable157,
        (XRControl) this.xrTable156,
        (XRControl) this.xrTable155,
        (XRControl) this.xrTable154,
        (XRControl) this.xrTable153,
        (XRControl) this.xrTable152,
        (XRControl) this.xrTable151,
        (XRControl) this.xrTable150,
        (XRControl) this.xrTable149,
        (XRControl) this.xrTable148,
        (XRControl) this.xrTable147,
        (XRControl) this.xrTable146,
        (XRControl) this.xrTable145,
        (XRControl) this.xrTable144,
        (XRControl) this.xrTable143,
        (XRControl) this.xrTable142,
        (XRControl) this.xrTable141,
        (XRControl) this.xrTable140,
        (XRControl) this.xrTable139,
        (XRControl) this.xrTable138,
        (XRControl) this.xrTable137,
        (XRControl) this.xrTable136,
        (XRControl) this.xrTable135,
        (XRControl) this.xrTable134,
        (XRControl) this.xrTable133,
        (XRControl) this.xrTable132,
        (XRControl) this.xrTable131,
        (XRControl) this.xrTable130,
        (XRControl) this.xrTable129,
        (XRControl) this.xrTable128,
        (XRControl) this.xrTable127,
        (XRControl) this.xrTable126,
        (XRControl) this.xrTable125,
        (XRControl) this.xrTable124,
        (XRControl) this.xrTable123,
        (XRControl) this.xrTable122,
        (XRControl) this.xrTable121,
        (XRControl) this.xrTable120,
        (XRControl) this.xrTable119,
        (XRControl) this.xrTable118,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrTable116,
        (XRControl) this.xrTable115
      });
      this.BottomMargin.HeightF = 663.4584f;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.SnapLinePadding = new PaddingInfo(0, 0, 0, 0, 100f);
      this.xrLabel3.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?bariza")
      });
      this.xrLabel3.LocationFloat = new PointFloat(289.9167f, 626.4167f);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(100f, 23f);
      this.xrLabel3.Text = "xrLabel3";
      this.xrLabel2.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?atolyesef")
      });
      this.xrLabel2.LocationFloat = new PointFloat(551.8333f, 626.4167f);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(100f, 23f);
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel1.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?sofor")
      });
      this.xrLabel1.LocationFloat = new PointFloat(66.66671f, 626.4167f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(100f, 23f);
      this.xrLabel1.Text = "xrLabel1";
      this.xrTable117.LocationFloat = new PointFloat(100f, 40f);
      this.xrTable117.Name = "xrTable117";
      this.xrTable117.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable117.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow117
      });
      this.xrTable117.SizeF = new SizeF(148.0556f, 25f);
      this.xrTableRow117.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell117
      });
      this.xrTableRow117.Name = "xrTableRow117";
      this.xrTableRow117.Weight = 1.0;
      this.xrTableCell117.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell117.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?plaka")
      });
      this.xrTableCell117.Multiline = true;
      this.xrTableCell117.Name = "xrTableCell117";
      this.xrTableCell117.StylePriority.UseBorders = false;
      this.xrTableCell117.Weight = 1.0;
      this.xrLabel7.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel7.LocationFloat = new PointFloat(273.4999f, 580.4584f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(128.1667f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.Text = "Ustanın Adı Soyadı";
      this.xrLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel6.LocationFloat = new PointFloat(41.66667f, 580.4584f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(136.6667f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "Şoförün Adı Soyadı";
      this.xrTable228.LocationFloat = new PointFloat(591.6671f, 540.0001f);
      this.xrTable228.Name = "xrTable228";
      this.xrTable228.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable228.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow228
      });
      this.xrTable228.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow228.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell228
      });
      this.xrTableRow228.Name = "xrTableRow228";
      this.xrTableRow228.Weight = 1.0;
      this.xrTableCell228.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell228.Multiline = true;
      this.xrTableCell228.Name = "xrTableCell228";
      this.xrTableCell228.StylePriority.UseBorders = false;
      this.xrTableCell228.Weight = 1.0;
      this.xrTable227.LocationFloat = new PointFloat(591.6671f, 515.0001f);
      this.xrTable227.Name = "xrTable227";
      this.xrTable227.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable227.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow227
      });
      this.xrTable227.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow227.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell227
      });
      this.xrTableRow227.Name = "xrTableRow227";
      this.xrTableRow227.Weight = 1.0;
      this.xrTableCell227.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell227.Multiline = true;
      this.xrTableCell227.Name = "xrTableCell227";
      this.xrTableCell227.StylePriority.UseBorders = false;
      this.xrTableCell227.Weight = 1.0;
      this.xrTable226.LocationFloat = new PointFloat(591.6671f, 490.0001f);
      this.xrTable226.Name = "xrTable226";
      this.xrTable226.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable226.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow226
      });
      this.xrTable226.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow226.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell226
      });
      this.xrTableRow226.Name = "xrTableRow226";
      this.xrTableRow226.Weight = 1.0;
      this.xrTableCell226.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell226.Multiline = true;
      this.xrTableCell226.Name = "xrTableCell226";
      this.xrTableCell226.StylePriority.UseBorders = false;
      this.xrTableCell226.Weight = 1.0;
      this.xrTable225.LocationFloat = new PointFloat(591.6671f, 465.0001f);
      this.xrTable225.Name = "xrTable225";
      this.xrTable225.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable225.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow225
      });
      this.xrTable225.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow225.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell225
      });
      this.xrTableRow225.Name = "xrTableRow225";
      this.xrTableRow225.Weight = 1.0;
      this.xrTableCell225.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell225.Multiline = true;
      this.xrTableCell225.Name = "xrTableCell225";
      this.xrTableCell225.StylePriority.UseBorders = false;
      this.xrTableCell225.Weight = 1.0;
      this.xrTable224.LocationFloat = new PointFloat(591.6671f, 440.0001f);
      this.xrTable224.Name = "xrTable224";
      this.xrTable224.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable224.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow224
      });
      this.xrTable224.SizeF = new SizeF(172.6663f, 25f);
      this.xrTableRow224.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell224
      });
      this.xrTableRow224.Name = "xrTableRow224";
      this.xrTableRow224.Weight = 1.0;
      this.xrTableCell224.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell224.Multiline = true;
      this.xrTableCell224.Name = "xrTableCell224";
      this.xrTableCell224.StylePriority.UseBorders = false;
      this.xrTableCell224.Weight = 1.0;
      this.xrTable223.LocationFloat = new PointFloat(591.6671f, 415.0001f);
      this.xrTable223.Name = "xrTable223";
      this.xrTable223.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable223.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow223
      });
      this.xrTable223.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow223.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell223
      });
      this.xrTableRow223.Name = "xrTableRow223";
      this.xrTableRow223.Weight = 1.0;
      this.xrTableCell223.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell223.Multiline = true;
      this.xrTableCell223.Name = "xrTableCell223";
      this.xrTableCell223.StylePriority.UseBorders = false;
      this.xrTableCell223.Weight = 1.0;
      this.xrTable222.LocationFloat = new PointFloat(591.6671f, 390.0001f);
      this.xrTable222.Name = "xrTable222";
      this.xrTable222.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable222.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow222
      });
      this.xrTable222.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow222.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell222
      });
      this.xrTableRow222.Name = "xrTableRow222";
      this.xrTableRow222.Weight = 1.0;
      this.xrTableCell222.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell222.Multiline = true;
      this.xrTableCell222.Name = "xrTableCell222";
      this.xrTableCell222.StylePriority.UseBorders = false;
      this.xrTableCell222.Weight = 1.0;
      this.xrTable221.LocationFloat = new PointFloat(591.6671f, 365.0001f);
      this.xrTable221.Name = "xrTable221";
      this.xrTable221.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable221.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow221
      });
      this.xrTable221.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow221.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell221
      });
      this.xrTableRow221.Name = "xrTableRow221";
      this.xrTableRow221.Weight = 1.0;
      this.xrTableCell221.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell221.Multiline = true;
      this.xrTableCell221.Name = "xrTableCell221";
      this.xrTableCell221.StylePriority.UseBorders = false;
      this.xrTableCell221.Weight = 1.0;
      this.xrTable220.LocationFloat = new PointFloat(591.6671f, 340.0001f);
      this.xrTable220.Name = "xrTable220";
      this.xrTable220.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable220.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow220
      });
      this.xrTable220.SizeF = new SizeF(172.3885f, 25f);
      this.xrTableRow220.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell220
      });
      this.xrTableRow220.Name = "xrTableRow220";
      this.xrTableRow220.Weight = 1.0;
      this.xrTableCell220.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell220.Multiline = true;
      this.xrTableCell220.Name = "xrTableCell220";
      this.xrTableCell220.StylePriority.UseBorders = false;
      this.xrTableCell220.Weight = 1.0;
      this.xrTable219.LocationFloat = new PointFloat(591.6669f, 315.0001f);
      this.xrTable219.Name = "xrTable219";
      this.xrTable219.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable219.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow219
      });
      this.xrTable219.SizeF = new SizeF(172.3886f, 25f);
      this.xrTableRow219.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell219
      });
      this.xrTableRow219.Name = "xrTableRow219";
      this.xrTableRow219.Weight = 1.0;
      this.xrTableCell219.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell219.Multiline = true;
      this.xrTableCell219.Name = "xrTableCell219";
      this.xrTableCell219.StylePriority.UseBorders = false;
      this.xrTableCell219.Weight = 1.0;
      this.xrTable218.LocationFloat = new PointFloat(591.6669f, 290.0001f);
      this.xrTable218.Name = "xrTable218";
      this.xrTable218.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable218.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow218
      });
      this.xrTable218.SizeF = new SizeF(172.3886f, 25f);
      this.xrTableRow218.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell218
      });
      this.xrTableRow218.Name = "xrTableRow218";
      this.xrTableRow218.Weight = 1.0;
      this.xrTableCell218.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell218.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell218.Multiline = true;
      this.xrTableCell218.Name = "xrTableCell218";
      this.xrTableCell218.StylePriority.UseBorders = false;
      this.xrTableCell218.StylePriority.UseFont = false;
      this.xrTableCell218.StylePriority.UseTextAlignment = false;
      this.xrTableCell218.Text = "Araç KM";
      this.xrTableCell218.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell218.Weight = 1.0;
      this.xrTable217.LocationFloat = new PointFloat(496.6667f, 290f);
      this.xrTable217.Name = "xrTable217";
      this.xrTable217.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable217.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow217
      });
      this.xrTable217.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow217.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell217
      });
      this.xrTableRow217.Name = "xrTableRow217";
      this.xrTableRow217.Weight = 1.0;
      this.xrTableCell217.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell217.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell217.Multiline = true;
      this.xrTableCell217.Name = "xrTableCell217";
      this.xrTableCell217.StylePriority.UseBorders = false;
      this.xrTableCell217.StylePriority.UseFont = false;
      this.xrTableCell217.StylePriority.UseTextAlignment = false;
      this.xrTableCell217.Text = "Araç KM";
      this.xrTableCell217.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell217.Weight = 1.0;
      this.xrTable216.LocationFloat = new PointFloat(496.6667f, 315f);
      this.xrTable216.Name = "xrTable216";
      this.xrTable216.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable216.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow216
      });
      this.xrTable216.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow216.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell216
      });
      this.xrTableRow216.Name = "xrTableRow216";
      this.xrTableRow216.Weight = 1.0;
      this.xrTableCell216.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell216.Multiline = true;
      this.xrTableCell216.Name = "xrTableCell216";
      this.xrTableCell216.StylePriority.UseBorders = false;
      this.xrTableCell216.Weight = 1.0;
      this.xrTable215.LocationFloat = new PointFloat(496.6668f, 340f);
      this.xrTable215.Name = "xrTable215";
      this.xrTable215.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable215.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow215
      });
      this.xrTable215.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow215.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell215
      });
      this.xrTableRow215.Name = "xrTableRow215";
      this.xrTableRow215.Weight = 1.0;
      this.xrTableCell215.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell215.Multiline = true;
      this.xrTableCell215.Name = "xrTableCell215";
      this.xrTableCell215.StylePriority.UseBorders = false;
      this.xrTableCell215.Weight = 1.0;
      this.xrTable214.LocationFloat = new PointFloat(496.6668f, 365f);
      this.xrTable214.Name = "xrTable214";
      this.xrTable214.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable214.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow214
      });
      this.xrTable214.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow214.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell214
      });
      this.xrTableRow214.Name = "xrTableRow214";
      this.xrTableRow214.Weight = 1.0;
      this.xrTableCell214.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell214.Multiline = true;
      this.xrTableCell214.Name = "xrTableCell214";
      this.xrTableCell214.StylePriority.UseBorders = false;
      this.xrTableCell214.Weight = 1.0;
      this.xrTable213.LocationFloat = new PointFloat(496.6668f, 390f);
      this.xrTable213.Name = "xrTable213";
      this.xrTable213.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable213.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow213
      });
      this.xrTable213.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow213.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell213
      });
      this.xrTableRow213.Name = "xrTableRow213";
      this.xrTableRow213.Weight = 1.0;
      this.xrTableCell213.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell213.Multiline = true;
      this.xrTableCell213.Name = "xrTableCell213";
      this.xrTableCell213.StylePriority.UseBorders = false;
      this.xrTableCell213.Weight = 1.0;
      this.xrTable212.LocationFloat = new PointFloat(496.6668f, 415f);
      this.xrTable212.Name = "xrTable212";
      this.xrTable212.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable212.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow212
      });
      this.xrTable212.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow212.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell212
      });
      this.xrTableRow212.Name = "xrTableRow212";
      this.xrTableRow212.Weight = 1.0;
      this.xrTableCell212.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell212.Multiline = true;
      this.xrTableCell212.Name = "xrTableCell212";
      this.xrTableCell212.StylePriority.UseBorders = false;
      this.xrTableCell212.Weight = 1.0;
      this.xrTable211.LocationFloat = new PointFloat(496.6668f, 440f);
      this.xrTable211.Name = "xrTable211";
      this.xrTable211.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable211.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow211
      });
      this.xrTable211.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow211.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell211
      });
      this.xrTableRow211.Name = "xrTableRow211";
      this.xrTableRow211.Weight = 1.0;
      this.xrTableCell211.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell211.Multiline = true;
      this.xrTableCell211.Name = "xrTableCell211";
      this.xrTableCell211.StylePriority.UseBorders = false;
      this.xrTableCell211.Weight = 1.0;
      this.xrTable210.LocationFloat = new PointFloat(496.6668f, 465f);
      this.xrTable210.Name = "xrTable210";
      this.xrTable210.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable210.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow210
      });
      this.xrTable210.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow210.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell210
      });
      this.xrTableRow210.Name = "xrTableRow210";
      this.xrTableRow210.Weight = 1.0;
      this.xrTableCell210.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell210.Multiline = true;
      this.xrTableCell210.Name = "xrTableCell210";
      this.xrTableCell210.StylePriority.UseBorders = false;
      this.xrTableCell210.Weight = 1.0;
      this.xrTable209.LocationFloat = new PointFloat(496.6668f, 490f);
      this.xrTable209.Name = "xrTable209";
      this.xrTable209.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable209.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow209
      });
      this.xrTable209.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow209.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell209
      });
      this.xrTableRow209.Name = "xrTableRow209";
      this.xrTableRow209.Weight = 1.0;
      this.xrTableCell209.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell209.Multiline = true;
      this.xrTableCell209.Name = "xrTableCell209";
      this.xrTableCell209.StylePriority.UseBorders = false;
      this.xrTableCell209.Weight = 1.0;
      this.xrTable208.LocationFloat = new PointFloat(496.6668f, 515f);
      this.xrTable208.Name = "xrTable208";
      this.xrTable208.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable208.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow208
      });
      this.xrTable208.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow208.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell208
      });
      this.xrTableRow208.Name = "xrTableRow208";
      this.xrTableRow208.Weight = 1.0;
      this.xrTableCell208.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell208.Multiline = true;
      this.xrTableCell208.Name = "xrTableCell208";
      this.xrTableCell208.StylePriority.UseBorders = false;
      this.xrTableCell208.Weight = 1.0;
      this.xrTable207.LocationFloat = new PointFloat(496.6668f, 540f);
      this.xrTable207.Name = "xrTable207";
      this.xrTable207.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable207.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow207
      });
      this.xrTable207.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow207.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell207
      });
      this.xrTableRow207.Name = "xrTableRow207";
      this.xrTableRow207.Weight = 1.0;
      this.xrTableCell207.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell207.Multiline = true;
      this.xrTableCell207.Name = "xrTableCell207";
      this.xrTableCell207.StylePriority.UseBorders = false;
      this.xrTableCell207.Weight = 1.0;
      this.xrTable206.LocationFloat = new PointFloat(401.6668f, 540.0001f);
      this.xrTable206.Name = "xrTable206";
      this.xrTable206.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable206.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow206
      });
      this.xrTable206.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow206.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell206
      });
      this.xrTableRow206.Name = "xrTableRow206";
      this.xrTableRow206.Weight = 1.0;
      this.xrTableCell206.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell206.Multiline = true;
      this.xrTableCell206.Name = "xrTableCell206";
      this.xrTableCell206.StylePriority.UseBorders = false;
      this.xrTableCell206.Weight = 1.0;
      this.xrTable205.LocationFloat = new PointFloat(401.6667f, 515.0001f);
      this.xrTable205.Name = "xrTable205";
      this.xrTable205.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable205.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow205
      });
      this.xrTable205.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow205.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell205
      });
      this.xrTableRow205.Name = "xrTableRow205";
      this.xrTableRow205.Weight = 1.0;
      this.xrTableCell205.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell205.Multiline = true;
      this.xrTableCell205.Name = "xrTableCell205";
      this.xrTableCell205.StylePriority.UseBorders = false;
      this.xrTableCell205.Weight = 1.0;
      this.xrTable204.LocationFloat = new PointFloat(401.6667f, 490.0001f);
      this.xrTable204.Name = "xrTable204";
      this.xrTable204.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable204.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow204
      });
      this.xrTable204.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow204.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell204
      });
      this.xrTableRow204.Name = "xrTableRow204";
      this.xrTableRow204.Weight = 1.0;
      this.xrTableCell204.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell204.Multiline = true;
      this.xrTableCell204.Name = "xrTableCell204";
      this.xrTableCell204.StylePriority.UseBorders = false;
      this.xrTableCell204.Weight = 1.0;
      this.xrTable203.LocationFloat = new PointFloat(401.6667f, 465.0001f);
      this.xrTable203.Name = "xrTable203";
      this.xrTable203.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable203.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow203
      });
      this.xrTable203.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow203.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell203
      });
      this.xrTableRow203.Name = "xrTableRow203";
      this.xrTableRow203.Weight = 1.0;
      this.xrTableCell203.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell203.Multiline = true;
      this.xrTableCell203.Name = "xrTableCell203";
      this.xrTableCell203.StylePriority.UseBorders = false;
      this.xrTableCell203.Weight = 1.0;
      this.xrTable202.LocationFloat = new PointFloat(401.6667f, 440.0001f);
      this.xrTable202.Name = "xrTable202";
      this.xrTable202.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable202.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow202
      });
      this.xrTable202.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow202.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell202
      });
      this.xrTableRow202.Name = "xrTableRow202";
      this.xrTableRow202.Weight = 1.0;
      this.xrTableCell202.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell202.Multiline = true;
      this.xrTableCell202.Name = "xrTableCell202";
      this.xrTableCell202.StylePriority.UseBorders = false;
      this.xrTableCell202.Weight = 1.0;
      this.xrTable201.LocationFloat = new PointFloat(401.6667f, 415.0001f);
      this.xrTable201.Name = "xrTable201";
      this.xrTable201.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable201.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow201
      });
      this.xrTable201.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow201.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell201
      });
      this.xrTableRow201.Name = "xrTableRow201";
      this.xrTableRow201.Weight = 1.0;
      this.xrTableCell201.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell201.Multiline = true;
      this.xrTableCell201.Name = "xrTableCell201";
      this.xrTableCell201.StylePriority.UseBorders = false;
      this.xrTableCell201.Weight = 1.0;
      this.xrTable200.LocationFloat = new PointFloat(401.6667f, 390.0001f);
      this.xrTable200.Name = "xrTable200";
      this.xrTable200.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable200.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow200
      });
      this.xrTable200.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow200.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell200
      });
      this.xrTableRow200.Name = "xrTableRow200";
      this.xrTableRow200.Weight = 1.0;
      this.xrTableCell200.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell200.Multiline = true;
      this.xrTableCell200.Name = "xrTableCell200";
      this.xrTableCell200.StylePriority.UseBorders = false;
      this.xrTableCell200.Weight = 1.0;
      this.xrTable199.LocationFloat = new PointFloat(401.6667f, 365.0001f);
      this.xrTable199.Name = "xrTable199";
      this.xrTable199.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable199.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow199
      });
      this.xrTable199.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow199.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell199
      });
      this.xrTableRow199.Name = "xrTableRow199";
      this.xrTableRow199.Weight = 1.0;
      this.xrTableCell199.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell199.Multiline = true;
      this.xrTableCell199.Name = "xrTableCell199";
      this.xrTableCell199.StylePriority.UseBorders = false;
      this.xrTableCell199.Weight = 1.0;
      this.xrTable198.LocationFloat = new PointFloat(401.6667f, 340.0001f);
      this.xrTable198.Name = "xrTable198";
      this.xrTable198.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable198.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow198
      });
      this.xrTable198.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow198.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell198
      });
      this.xrTableRow198.Name = "xrTableRow198";
      this.xrTableRow198.Weight = 1.0;
      this.xrTableCell198.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell198.Multiline = true;
      this.xrTableCell198.Name = "xrTableCell198";
      this.xrTableCell198.StylePriority.UseBorders = false;
      this.xrTableCell198.Weight = 1.0;
      this.xrTable197.LocationFloat = new PointFloat(401.6666f, 315.0001f);
      this.xrTable197.Name = "xrTable197";
      this.xrTable197.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable197.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow197
      });
      this.xrTable197.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow197.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell197
      });
      this.xrTableRow197.Name = "xrTableRow197";
      this.xrTableRow197.Weight = 1.0;
      this.xrTableCell197.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell197.Multiline = true;
      this.xrTableCell197.Name = "xrTableCell197";
      this.xrTableCell197.StylePriority.UseBorders = false;
      this.xrTableCell197.Weight = 1.0;
      this.xrTable196.LocationFloat = new PointFloat(401.6666f, 290.0001f);
      this.xrTable196.Name = "xrTable196";
      this.xrTable196.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable196.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow196
      });
      this.xrTable196.SizeF = new SizeF(95.00018f, 25f);
      this.xrTableRow196.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell196
      });
      this.xrTableRow196.Name = "xrTableRow196";
      this.xrTableRow196.Weight = 1.0;
      this.xrTableCell196.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell196.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell196.Multiline = true;
      this.xrTableCell196.Name = "xrTableCell196";
      this.xrTableCell196.StylePriority.UseBorders = false;
      this.xrTableCell196.StylePriority.UseFont = false;
      this.xrTableCell196.StylePriority.UseTextAlignment = false;
      this.xrTableCell196.Text = "Miktar";
      this.xrTableCell196.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell196.Weight = 1.0;
      this.xrTable195.LocationFloat = new PointFloat(200.8333f, 540.0001f);
      this.xrTable195.Name = "xrTable195";
      this.xrTable195.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable195.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow195
      });
      this.xrTable195.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow195.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell195
      });
      this.xrTableRow195.Name = "xrTableRow195";
      this.xrTableRow195.Weight = 1.0;
      this.xrTableCell195.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell195.Multiline = true;
      this.xrTableCell195.Name = "xrTableCell195";
      this.xrTableCell195.StylePriority.UseBorders = false;
      this.xrTableCell195.Weight = 1.0;
      this.xrTable194.LocationFloat = new PointFloat(200.8333f, 515.0001f);
      this.xrTable194.Name = "xrTable194";
      this.xrTable194.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable194.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow194
      });
      this.xrTable194.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow194.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell194
      });
      this.xrTableRow194.Name = "xrTableRow194";
      this.xrTableRow194.Weight = 1.0;
      this.xrTableCell194.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell194.Multiline = true;
      this.xrTableCell194.Name = "xrTableCell194";
      this.xrTableCell194.StylePriority.UseBorders = false;
      this.xrTableCell194.Weight = 1.0;
      this.xrTable193.LocationFloat = new PointFloat(200.8333f, 490.0001f);
      this.xrTable193.Name = "xrTable193";
      this.xrTable193.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable193.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow193
      });
      this.xrTable193.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow193.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell193
      });
      this.xrTableRow193.Name = "xrTableRow193";
      this.xrTableRow193.Weight = 1.0;
      this.xrTableCell193.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell193.Multiline = true;
      this.xrTableCell193.Name = "xrTableCell193";
      this.xrTableCell193.StylePriority.UseBorders = false;
      this.xrTableCell193.Weight = 1.0;
      this.xrTable192.LocationFloat = new PointFloat(200.8333f, 465.0001f);
      this.xrTable192.Name = "xrTable192";
      this.xrTable192.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable192.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow192
      });
      this.xrTable192.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow192.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell192
      });
      this.xrTableRow192.Name = "xrTableRow192";
      this.xrTableRow192.Weight = 1.0;
      this.xrTableCell192.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell192.Multiline = true;
      this.xrTableCell192.Name = "xrTableCell192";
      this.xrTableCell192.StylePriority.UseBorders = false;
      this.xrTableCell192.Weight = 1.0;
      this.xrTable191.LocationFloat = new PointFloat(200.8333f, 440.0001f);
      this.xrTable191.Name = "xrTable191";
      this.xrTable191.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable191.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow191
      });
      this.xrTable191.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow191.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell191
      });
      this.xrTableRow191.Name = "xrTableRow191";
      this.xrTableRow191.Weight = 1.0;
      this.xrTableCell191.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell191.Multiline = true;
      this.xrTableCell191.Name = "xrTableCell191";
      this.xrTableCell191.StylePriority.UseBorders = false;
      this.xrTableCell191.Weight = 1.0;
      this.xrTable190.LocationFloat = new PointFloat(200.8333f, 415.0001f);
      this.xrTable190.Name = "xrTable190";
      this.xrTable190.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable190.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow190
      });
      this.xrTable190.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow190.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell190
      });
      this.xrTableRow190.Name = "xrTableRow190";
      this.xrTableRow190.Weight = 1.0;
      this.xrTableCell190.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell190.Multiline = true;
      this.xrTableCell190.Name = "xrTableCell190";
      this.xrTableCell190.StylePriority.UseBorders = false;
      this.xrTableCell190.Weight = 1.0;
      this.xrTable189.LocationFloat = new PointFloat(200.8333f, 390.0001f);
      this.xrTable189.Name = "xrTable189";
      this.xrTable189.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable189.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow189
      });
      this.xrTable189.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow189.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell189
      });
      this.xrTableRow189.Name = "xrTableRow189";
      this.xrTableRow189.Weight = 1.0;
      this.xrTableCell189.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell189.Multiline = true;
      this.xrTableCell189.Name = "xrTableCell189";
      this.xrTableCell189.StylePriority.UseBorders = false;
      this.xrTableCell189.Weight = 1.0;
      this.xrTable188.LocationFloat = new PointFloat(200.8333f, 365.0001f);
      this.xrTable188.Name = "xrTable188";
      this.xrTable188.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable188.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow188
      });
      this.xrTable188.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow188.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell188
      });
      this.xrTableRow188.Name = "xrTableRow188";
      this.xrTableRow188.Weight = 1.0;
      this.xrTableCell188.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell188.Multiline = true;
      this.xrTableCell188.Name = "xrTableCell188";
      this.xrTableCell188.StylePriority.UseBorders = false;
      this.xrTableCell188.Weight = 1.0;
      this.xrTable187.LocationFloat = new PointFloat(200.8333f, 340.0001f);
      this.xrTable187.Name = "xrTable187";
      this.xrTable187.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable187.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow187
      });
      this.xrTable187.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow187.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell187
      });
      this.xrTableRow187.Name = "xrTableRow187";
      this.xrTableRow187.Weight = 1.0;
      this.xrTableCell187.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell187.Multiline = true;
      this.xrTableCell187.Name = "xrTableCell187";
      this.xrTableCell187.StylePriority.UseBorders = false;
      this.xrTableCell187.Weight = 1.0;
      this.xrTable186.LocationFloat = new PointFloat(200.8333f, 315.0001f);
      this.xrTable186.Name = "xrTable186";
      this.xrTable186.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable186.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow186
      });
      this.xrTable186.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow186.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell186
      });
      this.xrTableRow186.Name = "xrTableRow186";
      this.xrTableRow186.Weight = 1.0;
      this.xrTableCell186.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell186.Multiline = true;
      this.xrTableCell186.Name = "xrTableCell186";
      this.xrTableCell186.StylePriority.UseBorders = false;
      this.xrTableCell186.Weight = 1.0;
      this.xrTable185.LocationFloat = new PointFloat(200.8333f, 290.0001f);
      this.xrTable185.Name = "xrTable185";
      this.xrTable185.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable185.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow185
      });
      this.xrTable185.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow185.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell185
      });
      this.xrTableRow185.Name = "xrTableRow185";
      this.xrTableRow185.Weight = 1.0;
      this.xrTableCell185.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell185.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell185.Multiline = true;
      this.xrTableCell185.Name = "xrTableCell185";
      this.xrTableCell185.StylePriority.UseBorders = false;
      this.xrTableCell185.StylePriority.UseFont = false;
      this.xrTableCell185.StylePriority.UseTextAlignment = false;
      this.xrTableCell185.Text = "Seri No";
      this.xrTableCell185.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell185.Weight = 1.0;
      this.xrTable184.LocationFloat = new PointFloat(0.0f, 540.0001f);
      this.xrTable184.Name = "xrTable184";
      this.xrTable184.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable184.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow184
      });
      this.xrTable184.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow184.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell184
      });
      this.xrTableRow184.Name = "xrTableRow184";
      this.xrTableRow184.Weight = 1.0;
      this.xrTableCell184.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell184.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell184.Multiline = true;
      this.xrTableCell184.Name = "xrTableCell184";
      this.xrTableCell184.StylePriority.UseBorders = false;
      this.xrTableCell184.StylePriority.UseFont = false;
      this.xrTableCell184.Text = "Hava Kurutucu";
      this.xrTableCell184.Weight = 1.0;
      this.xrTable183.LocationFloat = new PointFloat(0.0f, 515.0001f);
      this.xrTable183.Name = "xrTable183";
      this.xrTable183.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable183.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow183
      });
      this.xrTable183.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow183.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell183
      });
      this.xrTableRow183.Name = "xrTableRow183";
      this.xrTableRow183.Weight = 1.0;
      this.xrTableCell183.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell183.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell183.Multiline = true;
      this.xrTableCell183.Name = "xrTableCell183";
      this.xrTableCell183.StylePriority.UseBorders = false;
      this.xrTableCell183.StylePriority.UseFont = false;
      this.xrTableCell183.Text = "Pilot Filtresi";
      this.xrTableCell183.Weight = 1.0;
      this.xrTable182.LocationFloat = new PointFloat(0.0f, 490.0001f);
      this.xrTable182.Name = "xrTable182";
      this.xrTable182.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable182.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow182
      });
      this.xrTable182.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow182.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell182
      });
      this.xrTableRow182.Name = "xrTableRow182";
      this.xrTableRow182.Weight = 1.0;
      this.xrTableCell182.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell182.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell182.Multiline = true;
      this.xrTableCell182.Name = "xrTableCell182";
      this.xrTableCell182.StylePriority.UseBorders = false;
      this.xrTableCell182.StylePriority.UseFont = false;
      this.xrTableCell182.Text = "Tank Filtresi";
      this.xrTableCell182.Weight = 1.0;
      this.xrTable181.LocationFloat = new PointFloat(0.0f, 465.0001f);
      this.xrTable181.Name = "xrTable181";
      this.xrTable181.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable181.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow181
      });
      this.xrTable181.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow181.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell181
      });
      this.xrTableRow181.Name = "xrTableRow181";
      this.xrTableRow181.Weight = 1.0;
      this.xrTableCell181.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell181.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell181.Multiline = true;
      this.xrTableCell181.Name = "xrTableCell181";
      this.xrTableCell181.StylePriority.UseBorders = false;
      this.xrTableCell181.StylePriority.UseFont = false;
      this.xrTableCell181.Text = "Hidrolik Filtresi";
      this.xrTableCell181.Weight = 1.0;
      this.xrTable180.LocationFloat = new PointFloat(0.0f, 440.0001f);
      this.xrTable180.Name = "xrTable180";
      this.xrTable180.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable180.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow180
      });
      this.xrTable180.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow180.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell180
      });
      this.xrTableRow180.Name = "xrTableRow180";
      this.xrTableRow180.Weight = 1.0;
      this.xrTableCell180.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell180.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell180.Multiline = true;
      this.xrTableCell180.Name = "xrTableCell180";
      this.xrTableCell180.StylePriority.UseBorders = false;
      this.xrTableCell180.StylePriority.UseFont = false;
      this.xrTableCell180.Text = "Şanzıman Filtresi";
      this.xrTableCell180.Weight = 1.0;
      this.xrTable179.LocationFloat = new PointFloat(0.0f, 415.0001f);
      this.xrTable179.Name = "xrTable179";
      this.xrTable179.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable179.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow179
      });
      this.xrTable179.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow179.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell179
      });
      this.xrTableRow179.Name = "xrTableRow179";
      this.xrTableRow179.Weight = 1.0;
      this.xrTableCell179.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell179.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell179.Multiline = true;
      this.xrTableCell179.Name = "xrTableCell179";
      this.xrTableCell179.StylePriority.UseBorders = false;
      this.xrTableCell179.StylePriority.UseFont = false;
      this.xrTableCell179.Text = "Su Ayırıcı";
      this.xrTableCell179.Weight = 1.0;
      this.xrTable178.LocationFloat = new PointFloat(0.0f, 390.0001f);
      this.xrTable178.Name = "xrTable178";
      this.xrTable178.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable178.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow178
      });
      this.xrTable178.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow178.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell178
      });
      this.xrTableRow178.Name = "xrTableRow178";
      this.xrTableRow178.Weight = 1.0;
      this.xrTableCell178.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell178.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell178.Multiline = true;
      this.xrTableCell178.Name = "xrTableCell178";
      this.xrTableCell178.StylePriority.UseBorders = false;
      this.xrTableCell178.StylePriority.UseFont = false;
      this.xrTableCell178.Text = "Şase Filtresi";
      this.xrTableCell178.Weight = 1.0;
      this.xrTable177.LocationFloat = new PointFloat(0.0f, 365.0001f);
      this.xrTable177.Name = "xrTable177";
      this.xrTable177.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable177.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow177
      });
      this.xrTable177.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow177.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell177
      });
      this.xrTableRow177.Name = "xrTableRow177";
      this.xrTableRow177.Weight = 1.0;
      this.xrTableCell177.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell177.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell177.Multiline = true;
      this.xrTableCell177.Name = "xrTableCell177";
      this.xrTableCell177.StylePriority.UseBorders = false;
      this.xrTableCell177.StylePriority.UseFont = false;
      this.xrTableCell177.Text = "Mazot Filtresi";
      this.xrTableCell177.Weight = 1.0;
      this.xrTable176.LocationFloat = new PointFloat(0.0f, 340.0001f);
      this.xrTable176.Name = "xrTable176";
      this.xrTable176.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable176.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow176
      });
      this.xrTable176.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow176.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell176
      });
      this.xrTableRow176.Name = "xrTableRow176";
      this.xrTableRow176.Weight = 1.0;
      this.xrTableCell176.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell176.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell176.Multiline = true;
      this.xrTableCell176.Name = "xrTableCell176";
      this.xrTableCell176.StylePriority.UseBorders = false;
      this.xrTableCell176.StylePriority.UseFont = false;
      this.xrTableCell176.Text = "Yağ Filtresi";
      this.xrTableCell176.Weight = 1.0;
      this.xrTable175.LocationFloat = new PointFloat(0.0f, 315.0001f);
      this.xrTable175.Name = "xrTable175";
      this.xrTable175.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable175.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow175
      });
      this.xrTable175.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow175.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell175
      });
      this.xrTableRow175.Name = "xrTableRow175";
      this.xrTableRow175.Weight = 1.0;
      this.xrTableCell175.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell175.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell175.Multiline = true;
      this.xrTableCell175.Name = "xrTableCell175";
      this.xrTableCell175.StylePriority.UseBorders = false;
      this.xrTableCell175.StylePriority.UseFont = false;
      this.xrTableCell175.Text = "Hava Filtresi";
      this.xrTableCell175.Weight = 1.0;
      this.xrTable174.LocationFloat = new PointFloat(0.0f, 290.0001f);
      this.xrTable174.Name = "xrTable174";
      this.xrTable174.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable174.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow174
      });
      this.xrTable174.SizeF = new SizeF(200.8333f, 25f);
      this.xrTableRow174.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell174
      });
      this.xrTableRow174.Name = "xrTableRow174";
      this.xrTableRow174.Weight = 1.0;
      this.xrTableCell174.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell174.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell174.Multiline = true;
      this.xrTableCell174.Name = "xrTableCell174";
      this.xrTableCell174.StylePriority.UseBorders = false;
      this.xrTableCell174.StylePriority.UseFont = false;
      this.xrTableCell174.StylePriority.UseTextAlignment = false;
      this.xrTableCell174.Text = "Yağın Cinsi";
      this.xrTableCell174.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell174.Weight = 1.0;
      this.xrTable173.LocationFloat = new PointFloat(682.6666f, 265.0001f);
      this.xrTable173.Name = "xrTable173";
      this.xrTable173.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable173.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow173
      });
      this.xrTable173.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable173.StylePriority.UseTextAlignment = false;
      this.xrTable173.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow173.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell173
      });
      this.xrTableRow173.Name = "xrTableRow173";
      this.xrTableRow173.Weight = 1.0;
      this.xrTableCell173.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell173.Font = new Font("Arial", 9.75f);
      this.xrTableCell173.Multiline = true;
      this.xrTableCell173.Name = "xrTableCell173";
      this.xrTableCell173.StylePriority.UseBorders = false;
      this.xrTableCell173.StylePriority.UseFont = false;
      this.xrTableCell173.StylePriority.UseTextAlignment = false;
      this.xrTableCell173.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell173.Weight = 1.0;
      this.xrTable172.LocationFloat = new PointFloat(682.6666f, 240f);
      this.xrTable172.Name = "xrTable172";
      this.xrTable172.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable172.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow172
      });
      this.xrTable172.SizeF = new SizeF(81.66672f, 25.00002f);
      this.xrTable172.StylePriority.UseTextAlignment = false;
      this.xrTable172.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow172.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell172
      });
      this.xrTableRow172.Name = "xrTableRow172";
      this.xrTableRow172.Weight = 1.0;
      this.xrTableCell172.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell172.Font = new Font("Arial", 9.75f);
      this.xrTableCell172.Multiline = true;
      this.xrTableCell172.Name = "xrTableCell172";
      this.xrTableCell172.StylePriority.UseBorders = false;
      this.xrTableCell172.StylePriority.UseFont = false;
      this.xrTableCell172.StylePriority.UseTextAlignment = false;
      this.xrTableCell172.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell172.Weight = 1.0;
      this.xrTable171.LocationFloat = new PointFloat(682.6666f, 215f);
      this.xrTable171.Name = "xrTable171";
      this.xrTable171.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable171.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow171
      });
      this.xrTable171.SizeF = new SizeF(81.38892f, 25f);
      this.xrTable171.StylePriority.UseTextAlignment = false;
      this.xrTable171.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow171.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell171
      });
      this.xrTableRow171.Name = "xrTableRow171";
      this.xrTableRow171.Weight = 1.0;
      this.xrTableCell171.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell171.Font = new Font("Arial", 9.75f);
      this.xrTableCell171.Multiline = true;
      this.xrTableCell171.Name = "xrTableCell171";
      this.xrTableCell171.StylePriority.UseBorders = false;
      this.xrTableCell171.StylePriority.UseFont = false;
      this.xrTableCell171.StylePriority.UseTextAlignment = false;
      this.xrTableCell171.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell171.Weight = 1.0;
      this.xrTable170.LocationFloat = new PointFloat(682.6666f, 190f);
      this.xrTable170.Name = "xrTable170";
      this.xrTable170.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable170.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow170
      });
      this.xrTable170.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable170.StylePriority.UseTextAlignment = false;
      this.xrTable170.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow170.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell170
      });
      this.xrTableRow170.Name = "xrTableRow170";
      this.xrTableRow170.Weight = 1.0;
      this.xrTableCell170.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell170.Font = new Font("Arial", 9.75f);
      this.xrTableCell170.Multiline = true;
      this.xrTableCell170.Name = "xrTableCell170";
      this.xrTableCell170.StylePriority.UseBorders = false;
      this.xrTableCell170.StylePriority.UseFont = false;
      this.xrTableCell170.StylePriority.UseTextAlignment = false;
      this.xrTableCell170.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell170.Weight = 1.0;
      this.xrTable169.LocationFloat = new PointFloat(682.6666f, 165f);
      this.xrTable169.Name = "xrTable169";
      this.xrTable169.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable169.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow169
      });
      this.xrTable169.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable169.StylePriority.UseTextAlignment = false;
      this.xrTable169.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow169.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell169
      });
      this.xrTableRow169.Name = "xrTableRow169";
      this.xrTableRow169.Weight = 1.0;
      this.xrTableCell169.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell169.Font = new Font("Arial", 9.75f);
      this.xrTableCell169.Multiline = true;
      this.xrTableCell169.Name = "xrTableCell169";
      this.xrTableCell169.StylePriority.UseBorders = false;
      this.xrTableCell169.StylePriority.UseFont = false;
      this.xrTableCell169.StylePriority.UseTextAlignment = false;
      this.xrTableCell169.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell169.Weight = 1.0;
      this.xrTable168.LocationFloat = new PointFloat(682.6666f, 140f);
      this.xrTable168.Name = "xrTable168";
      this.xrTable168.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable168.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow168
      });
      this.xrTable168.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable168.StylePriority.UseTextAlignment = false;
      this.xrTable168.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow168.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell168
      });
      this.xrTableRow168.Name = "xrTableRow168";
      this.xrTableRow168.Weight = 1.0;
      this.xrTableCell168.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell168.Font = new Font("Arial", 9.75f);
      this.xrTableCell168.Multiline = true;
      this.xrTableCell168.Name = "xrTableCell168";
      this.xrTableCell168.StylePriority.UseBorders = false;
      this.xrTableCell168.StylePriority.UseFont = false;
      this.xrTableCell168.StylePriority.UseTextAlignment = false;
      this.xrTableCell168.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell168.Weight = 1.0;
      this.xrTable167.LocationFloat = new PointFloat(682.6666f, 115f);
      this.xrTable167.Name = "xrTable167";
      this.xrTable167.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable167.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow167
      });
      this.xrTable167.SizeF = new SizeF(81.66672f, 25f);
      this.xrTableRow167.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell167
      });
      this.xrTableRow167.Name = "xrTableRow167";
      this.xrTableRow167.Weight = 1.0;
      this.xrTableCell167.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell167.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell167.Multiline = true;
      this.xrTableCell167.Name = "xrTableCell167";
      this.xrTableCell167.StylePriority.UseBorders = false;
      this.xrTableCell167.StylePriority.UseFont = false;
      this.xrTableCell167.StylePriority.UseTextAlignment = false;
      this.xrTableCell167.Text = "Miktar";
      this.xrTableCell167.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell167.Weight = 1.0;
      this.xrTable166.LocationFloat = new PointFloat(415f, 115f);
      this.xrTable166.Name = "xrTable166";
      this.xrTable166.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable166.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow166
      });
      this.xrTable166.SizeF = new SizeF(81.66672f, 25f);
      this.xrTableRow166.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell166
      });
      this.xrTableRow166.Name = "xrTableRow166";
      this.xrTableRow166.Weight = 1.0;
      this.xrTableCell166.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell166.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell166.Multiline = true;
      this.xrTableCell166.Name = "xrTableCell166";
      this.xrTableCell166.StylePriority.UseBorders = false;
      this.xrTableCell166.StylePriority.UseFont = false;
      this.xrTableCell166.StylePriority.UseTextAlignment = false;
      this.xrTableCell166.Text = "Miktar";
      this.xrTableCell166.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell166.Weight = 1.0;
      this.xrTable165.LocationFloat = new PointFloat(415f, 140f);
      this.xrTable165.Name = "xrTable165";
      this.xrTable165.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable165.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow165
      });
      this.xrTable165.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable165.StylePriority.UseTextAlignment = false;
      this.xrTable165.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow165.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell165
      });
      this.xrTableRow165.Name = "xrTableRow165";
      this.xrTableRow165.Weight = 1.0;
      this.xrTableCell165.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell165.Font = new Font("Arial", 9.75f);
      this.xrTableCell165.Multiline = true;
      this.xrTableCell165.Name = "xrTableCell165";
      this.xrTableCell165.StylePriority.UseBorders = false;
      this.xrTableCell165.StylePriority.UseFont = false;
      this.xrTableCell165.StylePriority.UseTextAlignment = false;
      this.xrTableCell165.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell165.Weight = 1.0;
      this.xrTable164.LocationFloat = new PointFloat(415f, 165f);
      this.xrTable164.Name = "xrTable164";
      this.xrTable164.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable164.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow164
      });
      this.xrTable164.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable164.StylePriority.UseTextAlignment = false;
      this.xrTable164.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow164.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell164
      });
      this.xrTableRow164.Name = "xrTableRow164";
      this.xrTableRow164.Weight = 1.0;
      this.xrTableCell164.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell164.Font = new Font("Arial", 9.75f);
      this.xrTableCell164.Multiline = true;
      this.xrTableCell164.Name = "xrTableCell164";
      this.xrTableCell164.StylePriority.UseBorders = false;
      this.xrTableCell164.StylePriority.UseFont = false;
      this.xrTableCell164.StylePriority.UseTextAlignment = false;
      this.xrTableCell164.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell164.Weight = 1.0;
      this.xrTable163.LocationFloat = new PointFloat(415f, 190f);
      this.xrTable163.Name = "xrTable163";
      this.xrTable163.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable163.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow163
      });
      this.xrTable163.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable163.StylePriority.UseTextAlignment = false;
      this.xrTable163.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow163.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell163
      });
      this.xrTableRow163.Name = "xrTableRow163";
      this.xrTableRow163.Weight = 1.0;
      this.xrTableCell163.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell163.Font = new Font("Arial", 9.75f);
      this.xrTableCell163.Multiline = true;
      this.xrTableCell163.Name = "xrTableCell163";
      this.xrTableCell163.StylePriority.UseBorders = false;
      this.xrTableCell163.StylePriority.UseFont = false;
      this.xrTableCell163.StylePriority.UseTextAlignment = false;
      this.xrTableCell163.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell163.Weight = 1.0;
      this.xrTable162.LocationFloat = new PointFloat(415f, 215f);
      this.xrTable162.Name = "xrTable162";
      this.xrTable162.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable162.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow162
      });
      this.xrTable162.SizeF = new SizeF(81.38892f, 25f);
      this.xrTable162.StylePriority.UseTextAlignment = false;
      this.xrTable162.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow162.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell162
      });
      this.xrTableRow162.Name = "xrTableRow162";
      this.xrTableRow162.Weight = 1.0;
      this.xrTableCell162.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell162.Font = new Font("Arial", 9.75f);
      this.xrTableCell162.Multiline = true;
      this.xrTableCell162.Name = "xrTableCell162";
      this.xrTableCell162.StylePriority.UseBorders = false;
      this.xrTableCell162.StylePriority.UseFont = false;
      this.xrTableCell162.StylePriority.UseTextAlignment = false;
      this.xrTableCell162.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell162.Weight = 1.0;
      this.xrTable161.LocationFloat = new PointFloat(415f, 240f);
      this.xrTable161.Name = "xrTable161";
      this.xrTable161.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable161.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow161
      });
      this.xrTable161.SizeF = new SizeF(81.66672f, 25.00002f);
      this.xrTable161.StylePriority.UseTextAlignment = false;
      this.xrTable161.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow161.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell161
      });
      this.xrTableRow161.Name = "xrTableRow161";
      this.xrTableRow161.Weight = 1.0;
      this.xrTableCell161.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell161.Font = new Font("Arial", 9.75f);
      this.xrTableCell161.Multiline = true;
      this.xrTableCell161.Name = "xrTableCell161";
      this.xrTableCell161.StylePriority.UseBorders = false;
      this.xrTableCell161.StylePriority.UseFont = false;
      this.xrTableCell161.StylePriority.UseTextAlignment = false;
      this.xrTableCell161.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell161.Weight = 1.0;
      this.xrTable160.LocationFloat = new PointFloat(415f, 265.0001f);
      this.xrTable160.Name = "xrTable160";
      this.xrTable160.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable160.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow160
      });
      this.xrTable160.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable160.StylePriority.UseTextAlignment = false;
      this.xrTable160.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow160.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell160
      });
      this.xrTableRow160.Name = "xrTableRow160";
      this.xrTableRow160.Weight = 1.0;
      this.xrTableCell160.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell160.Font = new Font("Arial", 9.75f);
      this.xrTableCell160.Multiline = true;
      this.xrTableCell160.Name = "xrTableCell160";
      this.xrTableCell160.StylePriority.UseBorders = false;
      this.xrTableCell160.StylePriority.UseFont = false;
      this.xrTableCell160.StylePriority.UseTextAlignment = false;
      this.xrTableCell160.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell160.Weight = 1.0;
      this.xrTable159.LocationFloat = new PointFloat(496.6667f, 265f);
      this.xrTable159.Name = "xrTable159";
      this.xrTable159.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable159.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow159
      });
      this.xrTable159.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable159.StylePriority.UseTextAlignment = false;
      this.xrTable159.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow159.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell159
      });
      this.xrTableRow159.Name = "xrTableRow159";
      this.xrTableRow159.Weight = 1.0;
      this.xrTableCell159.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell159.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell159.Multiline = true;
      this.xrTableCell159.Name = "xrTableCell159";
      this.xrTableCell159.StylePriority.UseBorders = false;
      this.xrTableCell159.StylePriority.UseFont = false;
      this.xrTableCell159.StylePriority.UseTextAlignment = false;
      this.xrTableCell159.Text = "Antifiriz";
      this.xrTableCell159.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell159.Weight = 1.0;
      this.xrTable158.LocationFloat = new PointFloat(496.6667f, 240f);
      this.xrTable158.Name = "xrTable158";
      this.xrTable158.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable158.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow158
      });
      this.xrTable158.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable158.StylePriority.UseTextAlignment = false;
      this.xrTable158.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow158.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell158
      });
      this.xrTableRow158.Name = "xrTableRow158";
      this.xrTableRow158.Weight = 1.0;
      this.xrTableCell158.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell158.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell158.Multiline = true;
      this.xrTableCell158.Name = "xrTableCell158";
      this.xrTableCell158.StylePriority.UseBorders = false;
      this.xrTableCell158.StylePriority.UseFont = false;
      this.xrTableCell158.StylePriority.UseTextAlignment = false;
      this.xrTableCell158.Text = "20 W 150 Numara Yağ";
      this.xrTableCell158.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell158.Weight = 1.0;
      this.xrTable157.LocationFloat = new PointFloat(496.6667f, 215f);
      this.xrTable157.Name = "xrTable157";
      this.xrTable157.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable157.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow157
      });
      this.xrTable157.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable157.StylePriority.UseTextAlignment = false;
      this.xrTable157.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow157.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell157
      });
      this.xrTableRow157.Name = "xrTableRow157";
      this.xrTableRow157.Weight = 1.0;
      this.xrTableCell157.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell157.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell157.Multiline = true;
      this.xrTableCell157.Name = "xrTableCell157";
      this.xrTableCell157.StylePriority.UseBorders = false;
      this.xrTableCell157.StylePriority.UseFont = false;
      this.xrTableCell157.StylePriority.UseTextAlignment = false;
      this.xrTableCell157.Text = "130 Numara Yağ";
      this.xrTableCell157.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell157.Weight = 1.0;
      this.xrTable156.LocationFloat = new PointFloat(496.6667f, 190f);
      this.xrTable156.Name = "xrTable156";
      this.xrTable156.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable156.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow156
      });
      this.xrTable156.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable156.StylePriority.UseTextAlignment = false;
      this.xrTable156.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow156.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell156
      });
      this.xrTableRow156.Name = "xrTableRow156";
      this.xrTableRow156.Weight = 1.0;
      this.xrTableCell156.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell156.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell156.Multiline = true;
      this.xrTableCell156.Name = "xrTableCell156";
      this.xrTableCell156.StylePriority.UseBorders = false;
      this.xrTableCell156.StylePriority.UseFont = false;
      this.xrTableCell156.StylePriority.UseTextAlignment = false;
      this.xrTableCell156.Text = "Beyaz Gres Yağı";
      this.xrTableCell156.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell156.Weight = 1.0;
      this.xrTable155.LocationFloat = new PointFloat(496.6667f, 165f);
      this.xrTable155.Name = "xrTable155";
      this.xrTable155.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable155.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow155
      });
      this.xrTable155.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable155.StylePriority.UseTextAlignment = false;
      this.xrTable155.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow155.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell155
      });
      this.xrTableRow155.Name = "xrTableRow155";
      this.xrTableRow155.Weight = 1.0;
      this.xrTableCell155.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell155.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell155.Multiline = true;
      this.xrTableCell155.Name = "xrTableCell155";
      this.xrTableCell155.StylePriority.UseBorders = false;
      this.xrTableCell155.StylePriority.UseFont = false;
      this.xrTableCell155.StylePriority.UseTextAlignment = false;
      this.xrTableCell155.Text = "Kauçuklu Gres Yağı";
      this.xrTableCell155.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell155.Weight = 1.0;
      this.xrTable154.LocationFloat = new PointFloat(496.6667f, 140f);
      this.xrTable154.Name = "xrTable154";
      this.xrTable154.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable154.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow154
      });
      this.xrTable154.SizeF = new SizeF(185.9999f, 25f);
      this.xrTable154.StylePriority.UseTextAlignment = false;
      this.xrTable154.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow154.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell154
      });
      this.xrTableRow154.Name = "xrTableRow154";
      this.xrTableRow154.Weight = 1.0;
      this.xrTableCell154.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell154.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell154.Multiline = true;
      this.xrTableCell154.Name = "xrTableCell154";
      this.xrTableCell154.StylePriority.UseBorders = false;
      this.xrTableCell154.StylePriority.UseFont = false;
      this.xrTableCell154.StylePriority.UseTextAlignment = false;
      this.xrTableCell154.Text = "ATF Direksiyon Yağı";
      this.xrTableCell154.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell154.Weight = 1.0;
      this.xrTable153.LocationFloat = new PointFloat(496.6667f, 115f);
      this.xrTable153.Name = "xrTable153";
      this.xrTable153.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable153.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow153
      });
      this.xrTable153.SizeF = new SizeF(185.9999f, 25f);
      this.xrTableRow153.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell153
      });
      this.xrTableRow153.Name = "xrTableRow153";
      this.xrTableRow153.Weight = 1.0;
      this.xrTableCell153.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell153.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell153.Multiline = true;
      this.xrTableCell153.Name = "xrTableCell153";
      this.xrTableCell153.StylePriority.UseBorders = false;
      this.xrTableCell153.StylePriority.UseFont = false;
      this.xrTableCell153.StylePriority.UseTextAlignment = false;
      this.xrTableCell153.Text = "Yağın Cinsi";
      this.xrTableCell153.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell153.Weight = 1.0;
      this.xrTable152.LocationFloat = new PointFloat(248.3334f, 115f);
      this.xrTable152.Name = "xrTable152";
      this.xrTable152.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable152.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow152
      });
      this.xrTable152.SizeF = new SizeF(166.6667f, 25f);
      this.xrTableRow152.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell152
      });
      this.xrTableRow152.Name = "xrTableRow152";
      this.xrTableRow152.Weight = 1.0;
      this.xrTableCell152.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell152.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell152.Multiline = true;
      this.xrTableCell152.Name = "xrTableCell152";
      this.xrTableCell152.StylePriority.UseBorders = false;
      this.xrTableCell152.StylePriority.UseFont = false;
      this.xrTableCell152.StylePriority.UseTextAlignment = false;
      this.xrTableCell152.Text = "Yağın Cinsi";
      this.xrTableCell152.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell152.Weight = 1.0;
      this.xrTable151.LocationFloat = new PointFloat(248.3334f, 140f);
      this.xrTable151.Name = "xrTable151";
      this.xrTable151.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable151.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow151
      });
      this.xrTable151.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable151.StylePriority.UseTextAlignment = false;
      this.xrTable151.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow151.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell151
      });
      this.xrTableRow151.Name = "xrTableRow151";
      this.xrTableRow151.Weight = 1.0;
      this.xrTableCell151.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell151.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell151.Multiline = true;
      this.xrTableCell151.Name = "xrTableCell151";
      this.xrTableCell151.StylePriority.UseBorders = false;
      this.xrTableCell151.StylePriority.UseFont = false;
      this.xrTableCell151.StylePriority.UseTextAlignment = false;
      this.xrTableCell151.Text = "10 Numara Hidrolik Yağı";
      this.xrTableCell151.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell151.Weight = 1.0;
      this.xrTable150.LocationFloat = new PointFloat(248.3334f, 165f);
      this.xrTable150.Name = "xrTable150";
      this.xrTable150.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable150.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow150
      });
      this.xrTable150.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable150.StylePriority.UseTextAlignment = false;
      this.xrTable150.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow150.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell150
      });
      this.xrTableRow150.Name = "xrTableRow150";
      this.xrTableRow150.Weight = 1.0;
      this.xrTableCell150.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell150.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell150.Multiline = true;
      this.xrTableCell150.Name = "xrTableCell150";
      this.xrTableCell150.StylePriority.UseBorders = false;
      this.xrTableCell150.StylePriority.UseFont = false;
      this.xrTableCell150.StylePriority.UseTextAlignment = false;
      this.xrTableCell150.Text = "10 W 30 Şanzıman Yağı";
      this.xrTableCell150.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell150.Weight = 1.0;
      this.xrTable149.LocationFloat = new PointFloat(248.3334f, 190f);
      this.xrTable149.Name = "xrTable149";
      this.xrTable149.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable149.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow149
      });
      this.xrTable149.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable149.StylePriority.UseTextAlignment = false;
      this.xrTable149.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow149.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell149
      });
      this.xrTableRow149.Name = "xrTableRow149";
      this.xrTableRow149.Weight = 1.0;
      this.xrTableCell149.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell149.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.xrTableCell149.Multiline = true;
      this.xrTableCell149.Name = "xrTableCell149";
      this.xrTableCell149.StylePriority.UseBorders = false;
      this.xrTableCell149.StylePriority.UseFont = false;
      this.xrTableCell149.StylePriority.UseTextAlignment = false;
      this.xrTableCell149.Text = "30 Numara Şanzıman Yağ";
      this.xrTableCell149.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell149.Weight = 1.0;
      this.xrTable148.LocationFloat = new PointFloat(248.3334f, 215f);
      this.xrTable148.Name = "xrTable148";
      this.xrTable148.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable148.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow148
      });
      this.xrTable148.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable148.StylePriority.UseTextAlignment = false;
      this.xrTable148.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow148.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell148
      });
      this.xrTableRow148.Name = "xrTableRow148";
      this.xrTableRow148.Weight = 1.0;
      this.xrTableCell148.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell148.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell148.Multiline = true;
      this.xrTableCell148.Name = "xrTableCell148";
      this.xrTableCell148.StylePriority.UseBorders = false;
      this.xrTableCell148.StylePriority.UseFont = false;
      this.xrTableCell148.StylePriority.UseTextAlignment = false;
      this.xrTableCell148.Text = "80 W 90 Şanzıman Yağı";
      this.xrTableCell148.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell148.Weight = 1.0;
      this.xrTable147.LocationFloat = new PointFloat(248.3334f, 240f);
      this.xrTable147.Name = "xrTable147";
      this.xrTable147.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable147.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow147
      });
      this.xrTable147.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable147.StylePriority.UseTextAlignment = false;
      this.xrTable147.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow147.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell147
      });
      this.xrTableRow147.Name = "xrTableRow147";
      this.xrTableRow147.Weight = 1.0;
      this.xrTableCell147.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell147.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.xrTableCell147.Multiline = true;
      this.xrTableCell147.Name = "xrTableCell147";
      this.xrTableCell147.StylePriority.UseBorders = false;
      this.xrTableCell147.StylePriority.UseFont = false;
      this.xrTableCell147.StylePriority.UseTextAlignment = false;
      this.xrTableCell147.Text = "90 Numara Şanzıman Yağ";
      this.xrTableCell147.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell147.Weight = 1.0;
      this.xrTable146.LocationFloat = new PointFloat(248.3334f, 265f);
      this.xrTable146.Name = "xrTable146";
      this.xrTable146.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable146.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow146
      });
      this.xrTable146.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable146.StylePriority.UseTextAlignment = false;
      this.xrTable146.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow146.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell146
      });
      this.xrTableRow146.Name = "xrTableRow146";
      this.xrTableRow146.Weight = 1.0;
      this.xrTableCell146.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell146.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell146.Multiline = true;
      this.xrTableCell146.Name = "xrTableCell146";
      this.xrTableCell146.StylePriority.UseBorders = false;
      this.xrTableCell146.StylePriority.UseFont = false;
      this.xrTableCell146.StylePriority.UseTextAlignment = false;
      this.xrTableCell146.Text = "50 Numara Tandem Yağı";
      this.xrTableCell146.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell146.Weight = 1.0;
      this.xrTable145.LocationFloat = new PointFloat(166.6666f, 265.0001f);
      this.xrTable145.Name = "xrTable145";
      this.xrTable145.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable145.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow145
      });
      this.xrTable145.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable145.StylePriority.UseTextAlignment = false;
      this.xrTable145.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow145.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell145
      });
      this.xrTableRow145.Name = "xrTableRow145";
      this.xrTableRow145.Weight = 1.0;
      this.xrTableCell145.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell145.Font = new Font("Arial", 9.75f);
      this.xrTableCell145.Multiline = true;
      this.xrTableCell145.Name = "xrTableCell145";
      this.xrTableCell145.StylePriority.UseBorders = false;
      this.xrTableCell145.StylePriority.UseFont = false;
      this.xrTableCell145.StylePriority.UseTextAlignment = false;
      this.xrTableCell145.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell145.Weight = 1.0;
      this.xrTable144.LocationFloat = new PointFloat(166.6666f, 240f);
      this.xrTable144.Name = "xrTable144";
      this.xrTable144.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable144.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow144
      });
      this.xrTable144.SizeF = new SizeF(81.66672f, 25.00002f);
      this.xrTable144.StylePriority.UseTextAlignment = false;
      this.xrTable144.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow144.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell144
      });
      this.xrTableRow144.Name = "xrTableRow144";
      this.xrTableRow144.Weight = 1.0;
      this.xrTableCell144.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell144.Font = new Font("Arial", 9.75f);
      this.xrTableCell144.Multiline = true;
      this.xrTableCell144.Name = "xrTableCell144";
      this.xrTableCell144.StylePriority.UseBorders = false;
      this.xrTableCell144.StylePriority.UseFont = false;
      this.xrTableCell144.StylePriority.UseTextAlignment = false;
      this.xrTableCell144.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell144.Weight = 1.0;
      this.xrTable143.LocationFloat = new PointFloat(166.6666f, 215f);
      this.xrTable143.Name = "xrTable143";
      this.xrTable143.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable143.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow143
      });
      this.xrTable143.SizeF = new SizeF(81.38892f, 25f);
      this.xrTable143.StylePriority.UseTextAlignment = false;
      this.xrTable143.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow143.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell143
      });
      this.xrTableRow143.Name = "xrTableRow143";
      this.xrTableRow143.Weight = 1.0;
      this.xrTableCell143.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell143.Font = new Font("Arial", 9.75f);
      this.xrTableCell143.Multiline = true;
      this.xrTableCell143.Name = "xrTableCell143";
      this.xrTableCell143.StylePriority.UseBorders = false;
      this.xrTableCell143.StylePriority.UseFont = false;
      this.xrTableCell143.StylePriority.UseTextAlignment = false;
      this.xrTableCell143.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell143.Weight = 1.0;
      this.xrTable142.LocationFloat = new PointFloat(166.6666f, 190f);
      this.xrTable142.Name = "xrTable142";
      this.xrTable142.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable142.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow142
      });
      this.xrTable142.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable142.StylePriority.UseTextAlignment = false;
      this.xrTable142.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow142.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell142
      });
      this.xrTableRow142.Name = "xrTableRow142";
      this.xrTableRow142.Weight = 1.0;
      this.xrTableCell142.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell142.Font = new Font("Arial", 9.75f);
      this.xrTableCell142.Multiline = true;
      this.xrTableCell142.Name = "xrTableCell142";
      this.xrTableCell142.StylePriority.UseBorders = false;
      this.xrTableCell142.StylePriority.UseFont = false;
      this.xrTableCell142.StylePriority.UseTextAlignment = false;
      this.xrTableCell142.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell142.Weight = 1.0;
      this.xrTable141.LocationFloat = new PointFloat(166.6666f, 165f);
      this.xrTable141.Name = "xrTable141";
      this.xrTable141.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable141.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow141
      });
      this.xrTable141.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable141.StylePriority.UseTextAlignment = false;
      this.xrTable141.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow141.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell141
      });
      this.xrTableRow141.Name = "xrTableRow141";
      this.xrTableRow141.Weight = 1.0;
      this.xrTableCell141.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell141.Font = new Font("Arial", 9.75f);
      this.xrTableCell141.Multiline = true;
      this.xrTableCell141.Name = "xrTableCell141";
      this.xrTableCell141.StylePriority.UseBorders = false;
      this.xrTableCell141.StylePriority.UseFont = false;
      this.xrTableCell141.StylePriority.UseTextAlignment = false;
      this.xrTableCell141.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell141.Weight = 1.0;
      this.xrTable140.LocationFloat = new PointFloat(166.6666f, 140f);
      this.xrTable140.Name = "xrTable140";
      this.xrTable140.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable140.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow140
      });
      this.xrTable140.SizeF = new SizeF(81.66672f, 25f);
      this.xrTable140.StylePriority.UseTextAlignment = false;
      this.xrTable140.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow140.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell140
      });
      this.xrTableRow140.Name = "xrTableRow140";
      this.xrTableRow140.Weight = 1.0;
      this.xrTableCell140.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell140.Font = new Font("Arial", 9.75f);
      this.xrTableCell140.Multiline = true;
      this.xrTableCell140.Name = "xrTableCell140";
      this.xrTableCell140.StylePriority.UseBorders = false;
      this.xrTableCell140.StylePriority.UseFont = false;
      this.xrTableCell140.StylePriority.UseTextAlignment = false;
      this.xrTableCell140.TextAlignment = TextAlignment.MiddleLeft;
      this.xrTableCell140.Weight = 1.0;
      this.xrTable139.LocationFloat = new PointFloat(166.6666f, 115f);
      this.xrTable139.Name = "xrTable139";
      this.xrTable139.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable139.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow139
      });
      this.xrTable139.SizeF = new SizeF(81.66672f, 25f);
      this.xrTableRow139.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell139
      });
      this.xrTableRow139.Name = "xrTableRow139";
      this.xrTableRow139.Weight = 1.0;
      this.xrTableCell139.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell139.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell139.Multiline = true;
      this.xrTableCell139.Name = "xrTableCell139";
      this.xrTableCell139.StylePriority.UseBorders = false;
      this.xrTableCell139.StylePriority.UseFont = false;
      this.xrTableCell139.StylePriority.UseTextAlignment = false;
      this.xrTableCell139.Text = "Miktar";
      this.xrTableCell139.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell139.Weight = 1.0;
      this.xrTable138.LocationFloat = new PointFloat(0.0f, 265f);
      this.xrTable138.Name = "xrTable138";
      this.xrTable138.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable138.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow138
      });
      this.xrTable138.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable138.StylePriority.UseTextAlignment = false;
      this.xrTable138.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow138.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell138
      });
      this.xrTableRow138.Name = "xrTableRow138";
      this.xrTableRow138.Weight = 1.0;
      this.xrTableCell138.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell138.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell138.Multiline = true;
      this.xrTableCell138.Name = "xrTableCell138";
      this.xrTableCell138.StylePriority.UseBorders = false;
      this.xrTableCell138.StylePriority.UseFont = false;
      this.xrTableCell138.StylePriority.UseTextAlignment = false;
      this.xrTableCell138.Text = "68 Numara Hidrolik Yağı";
      this.xrTableCell138.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell138.Weight = 1.0;
      this.xrTable137.LocationFloat = new PointFloat(0.0f, 240f);
      this.xrTable137.Name = "xrTable137";
      this.xrTable137.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable137.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow137
      });
      this.xrTable137.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable137.StylePriority.UseTextAlignment = false;
      this.xrTable137.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow137.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell137
      });
      this.xrTableRow137.Name = "xrTableRow137";
      this.xrTableRow137.Weight = 1.0;
      this.xrTableCell137.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell137.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell137.Multiline = true;
      this.xrTableCell137.Name = "xrTableCell137";
      this.xrTableCell137.StylePriority.UseBorders = false;
      this.xrTableCell137.StylePriority.UseFont = false;
      this.xrTableCell137.StylePriority.UseTextAlignment = false;
      this.xrTableCell137.Text = "46 Numara Hidrolik Yağı";
      this.xrTableCell137.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell137.Weight = 1.0;
      this.xrTable136.LocationFloat = new PointFloat(0.0f, 215f);
      this.xrTable136.Name = "xrTable136";
      this.xrTable136.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable136.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow136
      });
      this.xrTable136.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable136.StylePriority.UseTextAlignment = false;
      this.xrTable136.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow136.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell136
      });
      this.xrTableRow136.Name = "xrTableRow136";
      this.xrTableRow136.Weight = 1.0;
      this.xrTableCell136.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell136.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.xrTableCell136.Multiline = true;
      this.xrTableCell136.Name = "xrTableCell136";
      this.xrTableCell136.StylePriority.UseBorders = false;
      this.xrTableCell136.StylePriority.UseFont = false;
      this.xrTableCell136.StylePriority.UseTextAlignment = false;
      this.xrTableCell136.Text = "85 W 140 Difarensiyel Yağ";
      this.xrTableCell136.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell136.Weight = 1.0;
      this.xrTable135.LocationFloat = new PointFloat(0.0f, 190f);
      this.xrTable135.Name = "xrTable135";
      this.xrTable135.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable135.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow135
      });
      this.xrTable135.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable135.StylePriority.UseTextAlignment = false;
      this.xrTable135.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow135.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell135
      });
      this.xrTableRow135.Name = "xrTableRow135";
      this.xrTableRow135.Weight = 1.0;
      this.xrTableCell135.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell135.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell135.Multiline = true;
      this.xrTableCell135.Name = "xrTableCell135";
      this.xrTableCell135.StylePriority.UseBorders = false;
      this.xrTableCell135.StylePriority.UseFont = false;
      this.xrTableCell135.StylePriority.UseTextAlignment = false;
      this.xrTableCell135.Text = "15 W 40 Motor Yağı";
      this.xrTableCell135.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell135.Weight = 1.0;
      this.xrTable134.LocationFloat = new PointFloat(0.0f, 165f);
      this.xrTable134.Name = "xrTable134";
      this.xrTable134.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable134.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow134
      });
      this.xrTable134.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable134.StylePriority.UseTextAlignment = false;
      this.xrTable134.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow134.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell134
      });
      this.xrTableRow134.Name = "xrTableRow134";
      this.xrTableRow134.Weight = 1.0;
      this.xrTableCell134.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell134.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell134.Multiline = true;
      this.xrTableCell134.Name = "xrTableCell134";
      this.xrTableCell134.StylePriority.UseBorders = false;
      this.xrTableCell134.StylePriority.UseFont = false;
      this.xrTableCell134.StylePriority.UseTextAlignment = false;
      this.xrTableCell134.Text = "10 W 40 Motor Yağı";
      this.xrTableCell134.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell134.Weight = 1.0;
      this.xrTable133.LocationFloat = new PointFloat(0.0f, 140f);
      this.xrTable133.Name = "xrTable133";
      this.xrTable133.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable133.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow133
      });
      this.xrTable133.SizeF = new SizeF(166.6667f, 25f);
      this.xrTable133.StylePriority.UseTextAlignment = false;
      this.xrTable133.TextAlignment = TextAlignment.TopLeft;
      this.xrTableRow133.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell133
      });
      this.xrTableRow133.Name = "xrTableRow133";
      this.xrTableRow133.Weight = 1.0;
      this.xrTableCell133.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell133.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell133.Multiline = true;
      this.xrTableCell133.Name = "xrTableCell133";
      this.xrTableCell133.StylePriority.UseBorders = false;
      this.xrTableCell133.StylePriority.UseFont = false;
      this.xrTableCell133.StylePriority.UseTextAlignment = false;
      this.xrTableCell133.Text = "5 W 30 Motor Yağı";
      this.xrTableCell133.TextAlignment = TextAlignment.TopLeft;
      this.xrTableCell133.Weight = 1.0;
      this.xrTable132.LocationFloat = new PointFloat(0.0f, 115f);
      this.xrTable132.Name = "xrTable132";
      this.xrTable132.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable132.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow132
      });
      this.xrTable132.SizeF = new SizeF(166.6667f, 25f);
      this.xrTableRow132.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell132
      });
      this.xrTableRow132.Name = "xrTableRow132";
      this.xrTableRow132.Weight = 1.0;
      this.xrTableCell132.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell132.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell132.Multiline = true;
      this.xrTableCell132.Name = "xrTableCell132";
      this.xrTableCell132.StylePriority.UseBorders = false;
      this.xrTableCell132.StylePriority.UseFont = false;
      this.xrTableCell132.StylePriority.UseTextAlignment = false;
      this.xrTableCell132.Text = "Yağın Cinsi";
      this.xrTableCell132.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell132.Weight = 1.0;
      this.xrTable131.LocationFloat = new PointFloat(567.4999f, 90f);
      this.xrTable131.Name = "xrTable131";
      this.xrTable131.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable131.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow131
      });
      this.xrTable131.SizeF = new SizeF(196.8333f, 25f);
      this.xrTableRow131.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell131
      });
      this.xrTableRow131.Name = "xrTableRow131";
      this.xrTableRow131.Weight = 1.0;
      this.xrTableCell131.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell131.Multiline = true;
      this.xrTableCell131.Name = "xrTableCell131";
      this.xrTableCell131.StylePriority.UseBorders = false;
      this.xrTableCell131.Weight = 1.0;
      this.xrTable130.LocationFloat = new PointFloat(436.1112f, 90f);
      this.xrTable130.Name = "xrTable130";
      this.xrTable130.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable130.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow130
      });
      this.xrTable130.SizeF = new SizeF(131.3888f, 25f);
      this.xrTableRow130.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell130
      });
      this.xrTableRow130.Name = "xrTableRow130";
      this.xrTableRow130.Weight = 1.0;
      this.xrTableCell130.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell130.Multiline = true;
      this.xrTableCell130.Name = "xrTableCell130";
      this.xrTableCell130.StylePriority.UseBorders = false;
      this.xrTableCell130.StylePriority.UseTextAlignment = false;
      this.xrTableCell130.Text = "Atık Yağ Miktarı:";
      this.xrTableCell130.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell130.Weight = 1.0;
      this.xrTable129.LocationFloat = new PointFloat(100f, 90f);
      this.xrTable129.Name = "xrTable129";
      this.xrTable129.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable129.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow129
      });
      this.xrTable129.SizeF = new SizeF(336.1112f, 25f);
      this.xrTableRow129.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell129
      });
      this.xrTableRow129.Name = "xrTableRow129";
      this.xrTableRow129.Weight = 1.0;
      this.xrTableCell129.Borders = BorderSide.Bottom;
      this.xrTableCell129.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?bakimyeri")
      });
      this.xrTableCell129.Multiline = true;
      this.xrTableCell129.Name = "xrTableCell129";
      this.xrTableCell129.StylePriority.UseBorders = false;
      this.xrTableCell129.Weight = 1.0;
      this.xrTable128.LocationFloat = new PointFloat(100f, 65f);
      this.xrTable128.Name = "xrTable128";
      this.xrTable128.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable128.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow128
      });
      this.xrTable128.SizeF = new SizeF(148.0556f, 25f);
      this.xrTableRow128.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell128
      });
      this.xrTableRow128.Name = "xrTableRow128";
      this.xrTableRow128.Weight = 1.0;
      this.xrTableCell128.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell128.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?km")
      });
      this.xrTableCell128.Multiline = true;
      this.xrTableCell128.Name = "xrTableCell128";
      this.xrTableCell128.StylePriority.UseBorders = false;
      this.xrTableCell128.Weight = 1.0;
      this.xrTable127.LocationFloat = new PointFloat(348.0556f, 65f);
      this.xrTable127.Name = "xrTable127";
      this.xrTable127.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable127.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow127
      });
      this.xrTable127.SizeF = new SizeF(184.8889f, 25f);
      this.xrTableRow127.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell127
      });
      this.xrTableRow127.Name = "xrTableRow127";
      this.xrTableRow127.Weight = 1.0;
      this.xrTableCell127.Borders = BorderSide.Bottom;
      this.xrTableCell127.Multiline = true;
      this.xrTableCell127.Name = "xrTableCell127";
      this.xrTableCell127.StylePriority.UseBorders = false;
      this.xrTableCell127.Weight = 1.0;
      this.xrTable126.LocationFloat = new PointFloat(248.0556f, 65f);
      this.xrTable126.Name = "xrTable126";
      this.xrTable126.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable126.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow126
      });
      this.xrTable126.SizeF = new SizeF(100f, 25f);
      this.xrTableRow126.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell126
      });
      this.xrTableRow126.Name = "xrTableRow126";
      this.xrTableRow126.Weight = 1.0;
      this.xrTableCell126.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell126.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell126.Multiline = true;
      this.xrTableCell126.Name = "xrTableCell126";
      this.xrTableCell126.StylePriority.UseBorders = false;
      this.xrTableCell126.StylePriority.UseFont = false;
      this.xrTableCell126.StylePriority.UseTextAlignment = false;
      this.xrTableCell126.Text = "Sonraki Km:";
      this.xrTableCell126.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell126.Weight = 1.0;
      this.xrTable125.LocationFloat = new PointFloat(632.9446f, 65f);
      this.xrTable125.Name = "xrTable125";
      this.xrTable125.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable125.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow125
      });
      this.xrTable125.SizeF = new SizeF(131.3887f, 25f);
      this.xrTableRow125.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell125
      });
      this.xrTableRow125.Name = "xrTableRow125";
      this.xrTableRow125.Weight = 1.0;
      this.xrTableCell125.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell125.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?ctarih")
      });
      this.xrTableCell125.Multiline = true;
      this.xrTableCell125.Name = "xrTableCell125";
      this.xrTableCell125.StylePriority.UseBorders = false;
      this.xrTableCell125.Weight = 1.0;
      this.xrTable124.LocationFloat = new PointFloat(532.9446f, 65f);
      this.xrTable124.Name = "xrTable124";
      this.xrTable124.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable124.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow124
      });
      this.xrTable124.SizeF = new SizeF(100f, 25f);
      this.xrTableRow124.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell124
      });
      this.xrTableRow124.Name = "xrTableRow124";
      this.xrTableRow124.Weight = 1.0;
      this.xrTableCell124.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell124.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell124.Multiline = true;
      this.xrTableCell124.Name = "xrTableCell124";
      this.xrTableCell124.StylePriority.UseBorders = false;
      this.xrTableCell124.StylePriority.UseFont = false;
      this.xrTableCell124.StylePriority.UseTextAlignment = false;
      this.xrTableCell124.Text = "Çıkış Tarihi:";
      this.xrTableCell124.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell124.Weight = 1.0;
      this.xrTable123.LocationFloat = new PointFloat(532.9446f, 40f);
      this.xrTable123.Name = "xrTable123";
      this.xrTable123.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable123.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow123
      });
      this.xrTable123.SizeF = new SizeF(100f, 25f);
      this.xrTableRow123.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell123
      });
      this.xrTableRow123.Name = "xrTableRow123";
      this.xrTableRow123.Weight = 1.0;
      this.xrTableCell123.Borders = BorderSide.Left | BorderSide.Bottom;
      this.xrTableCell123.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell123.Multiline = true;
      this.xrTableCell123.Name = "xrTableCell123";
      this.xrTableCell123.StylePriority.UseBorders = false;
      this.xrTableCell123.StylePriority.UseFont = false;
      this.xrTableCell123.StylePriority.UseTextAlignment = false;
      this.xrTableCell123.Text = "Giriş Tarihi:";
      this.xrTableCell123.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell123.Weight = 1.0;
      this.xrTable122.LocationFloat = new PointFloat(632.9446f, 40f);
      this.xrTable122.Name = "xrTable122";
      this.xrTable122.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable122.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow122
      });
      this.xrTable122.SizeF = new SizeF(131.3887f, 25f);
      this.xrTableRow122.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell122
      });
      this.xrTableRow122.Name = "xrTableRow122";
      this.xrTableRow122.Weight = 1.0;
      this.xrTableCell122.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell122.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?gsaat")
      });
      this.xrTableCell122.Multiline = true;
      this.xrTableCell122.Name = "xrTableCell122";
      this.xrTableCell122.StylePriority.UseBorders = false;
      this.xrTableCell122.Weight = 1.0;
      this.xrTable121.LocationFloat = new PointFloat(248.0556f, 40f);
      this.xrTable121.Name = "xrTable121";
      this.xrTable121.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable121.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow121
      });
      this.xrTable121.SizeF = new SizeF(100f, 25f);
      this.xrTableRow121.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell121
      });
      this.xrTableRow121.Name = "xrTableRow121";
      this.xrTableRow121.Weight = 1.0;
      this.xrTableCell121.Borders = BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell121.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell121.Multiline = true;
      this.xrTableCell121.Name = "xrTableCell121";
      this.xrTableCell121.StylePriority.UseBorders = false;
      this.xrTableCell121.StylePriority.UseFont = false;
      this.xrTableCell121.StylePriority.UseTextAlignment = false;
      this.xrTableCell121.Text = "İş Emri Kodu:";
      this.xrTableCell121.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell121.Weight = 1.0;
      this.xrTable120.LocationFloat = new PointFloat(348.0556f, 40f);
      this.xrTable120.Name = "xrTable120";
      this.xrTable120.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable120.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow120
      });
      this.xrTable120.SizeF = new SizeF(184.8889f, 25f);
      this.xrTableRow120.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell120
      });
      this.xrTableRow120.Name = "xrTableRow120";
      this.xrTableRow120.Weight = 1.0;
      this.xrTableCell120.Borders = BorderSide.Bottom;
      this.xrTableCell120.ExpressionBindings.AddRange(new ExpressionBinding[1]
      {
        new ExpressionBinding("BeforePrint", "Text", "?isEmirkod")
      });
      this.xrTableCell120.Multiline = true;
      this.xrTableCell120.Name = "xrTableCell120";
      this.xrTableCell120.StylePriority.UseBorders = false;
      this.xrTableCell120.Weight = 1.0;
      this.xrTable119.LocationFloat = new PointFloat(0.0f, 90f);
      this.xrTable119.Name = "xrTable119";
      this.xrTable119.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable119.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow119
      });
      this.xrTable119.SizeF = new SizeF(100f, 25f);
      this.xrTableRow119.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell119
      });
      this.xrTableRow119.Name = "xrTableRow119";
      this.xrTableRow119.Weight = 1.0;
      this.xrTableCell119.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell119.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell119.Multiline = true;
      this.xrTableCell119.Name = "xrTableCell119";
      this.xrTableCell119.StylePriority.UseBorders = false;
      this.xrTableCell119.StylePriority.UseFont = false;
      this.xrTableCell119.StylePriority.UseTextAlignment = false;
      this.xrTableCell119.Text = "Bakım Yeri:";
      this.xrTableCell119.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell119.Weight = 1.0;
      this.xrTable118.LocationFloat = new PointFloat(0.0f, 65f);
      this.xrTable118.Name = "xrTable118";
      this.xrTable118.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable118.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow118
      });
      this.xrTable118.SizeF = new SizeF(100f, 25f);
      this.xrTableRow118.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell118
      });
      this.xrTableRow118.Name = "xrTableRow118";
      this.xrTableRow118.Weight = 1.0;
      this.xrTableCell118.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell118.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell118.Multiline = true;
      this.xrTableCell118.Name = "xrTableCell118";
      this.xrTableCell118.StylePriority.UseBorders = false;
      this.xrTableCell118.StylePriority.UseFont = false;
      this.xrTableCell118.StylePriority.UseTextAlignment = false;
      this.xrTableCell118.Text = "Kilometre:";
      this.xrTableCell118.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell118.Weight = 1.0;
      this.xrLabel8.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(551.8333f, 580.4584f);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(95.83337f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "Birim Amiri";
      this.xrTable116.LocationFloat = new PointFloat(0.0f, 40f);
      this.xrTable116.Name = "xrTable116";
      this.xrTable116.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable116.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow116
      });
      this.xrTable116.SizeF = new SizeF(100f, 25f);
      this.xrTableRow116.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell116
      });
      this.xrTableRow116.Name = "xrTableRow116";
      this.xrTableRow116.Weight = 1.0;
      this.xrTableCell116.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTableCell116.Font = new Font("Arial", 9.75f, FontStyle.Bold);
      this.xrTableCell116.Multiline = true;
      this.xrTableCell116.Name = "xrTableCell116";
      this.xrTableCell116.StylePriority.UseBorders = false;
      this.xrTableCell116.StylePriority.UseFont = false;
      this.xrTableCell116.StylePriority.UseTextAlignment = false;
      this.xrTableCell116.Text = "Plaka:";
      this.xrTableCell116.TextAlignment = TextAlignment.TopRight;
      this.xrTableCell116.Weight = 1.0;
      this.xrTable115.LocationFloat = new PointFloat(0.0f, 0.0f);
      this.xrTable115.Name = "xrTable115";
      this.xrTable115.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable115.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow115
      });
      this.xrTable115.SizeF = new SizeF(764.3333f, 40f);
      this.xrTable115.StylePriority.UseTextAlignment = false;
      this.xrTable115.TextAlignment = TextAlignment.TopCenter;
      this.xrTableRow115.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell115
      });
      this.xrTableRow115.Name = "xrTableRow115";
      this.xrTableRow115.Weight = 1.0;
      this.xrTableCell115.Borders = BorderSide.All;
      this.xrTableCell115.Font = new Font("Arial", 12f, FontStyle.Bold);
      this.xrTableCell115.Multiline = true;
      this.xrTableCell115.Name = "xrTableCell115";
      this.xrTableCell115.StylePriority.UseBorders = false;
      this.xrTableCell115.StylePriority.UseFont = false;
      this.xrTableCell115.StylePriority.UseTextAlignment = false;
      this.xrTableCell115.Text = "İŞ EMRİ FORMU (YAĞ ve FİLTRE BAKIM)";
      this.xrTableCell115.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableCell115.Weight = 1.0;
      this.Detail.HeightF = 0.0f;
      this.Detail.Name = "Detail";
      this.plaka.Description = "Parameter1";
      this.plaka.Name = "plaka";
      this.aracBilgisi.Description = "Parameter2";
      this.aracBilgisi.Name = "aracBilgisi";
      this.aracBilgisi.Type = typeof (int);
      this.aracBilgisi.ValueInfo = "0";
      this.isEmirkod.Description = "Parameter3";
      this.isEmirkod.Name = "isEmirkod";
      this.isEmirkod.Type = typeof (int);
      this.isEmirkod.ValueInfo = "0";
      this.bariza.Description = "Parameter4";
      this.bariza.Name = "bariza";
      this.bakimyeri.Description = "Parameter5";
      this.bakimyeri.Name = "bakimyeri";
      this.bakimyeri.Type = typeof (int);
      this.bakimyeri.ValueInfo = "0";
      this.km.Description = "Parameter6";
      this.km.Name = "km";
      this.km.Type = typeof (int);
      this.km.ValueInfo = "0";
      this.ctarih.Description = "Parameter7";
      this.ctarih.Name = "ctarih";
      this.ctarih.Type = typeof (int);
      this.ctarih.ValueInfo = "0";
      this.gsaat.Description = "Parameter1";
      this.gsaat.Name = "gsaat";
      this.gsaat.Type = typeof (int);
      this.gsaat.ValueInfo = "0";
      this.csaat.Description = "Parameter2";
      this.csaat.Name = "csaat";
      this.csaat.Type = typeof (int);
      this.csaat.ValueInfo = "0";
      this.sofor.Description = "Parameter1";
      this.sofor.Name = "sofor";
      this.sofor.Type = typeof (int);
      this.sofor.ValueInfo = "0";
      this.atolyesef.Description = "Parameter2";
      this.atolyesef.Name = "atolyesef";
      this.atolyesef.Type = typeof (int);
      this.atolyesef.ValueInfo = "0";
      this.gtarih.Description = "Parameter1";
      this.gtarih.Name = "gtarih";
      this.gtarih.Type = typeof (int);
      this.gtarih.ValueInfo = "0";
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.Font = new Font("Arial", 9.75f);
      this.Margins = new Margins(0, 0, 96, 663);
      this.PageHeight = 827;
      this.PageWidth = 1169;
      this.PaperKind = PaperKind.A4Rotated;
      this.Parameters.AddRange(new Parameter[12]
      {
        this.plaka,
        this.aracBilgisi,
        this.isEmirkod,
        this.bariza,
        this.bakimyeri,
        this.km,
        this.ctarih,
        this.gsaat,
        this.csaat,
        this.sofor,
        this.atolyesef,
        this.gtarih
      });
      this.Version = "20.1";
      this.xrTable117.EndInit();
      this.xrTable228.EndInit();
      this.xrTable227.EndInit();
      this.xrTable226.EndInit();
      this.xrTable225.EndInit();
      this.xrTable224.EndInit();
      this.xrTable223.EndInit();
      this.xrTable222.EndInit();
      this.xrTable221.EndInit();
      this.xrTable220.EndInit();
      this.xrTable219.EndInit();
      this.xrTable218.EndInit();
      this.xrTable217.EndInit();
      this.xrTable216.EndInit();
      this.xrTable215.EndInit();
      this.xrTable214.EndInit();
      this.xrTable213.EndInit();
      this.xrTable212.EndInit();
      this.xrTable211.EndInit();
      this.xrTable210.EndInit();
      this.xrTable209.EndInit();
      this.xrTable208.EndInit();
      this.xrTable207.EndInit();
      this.xrTable206.EndInit();
      this.xrTable205.EndInit();
      this.xrTable204.EndInit();
      this.xrTable203.EndInit();
      this.xrTable202.EndInit();
      this.xrTable201.EndInit();
      this.xrTable200.EndInit();
      this.xrTable199.EndInit();
      this.xrTable198.EndInit();
      this.xrTable197.EndInit();
      this.xrTable196.EndInit();
      this.xrTable195.EndInit();
      this.xrTable194.EndInit();
      this.xrTable193.EndInit();
      this.xrTable192.EndInit();
      this.xrTable191.EndInit();
      this.xrTable190.EndInit();
      this.xrTable189.EndInit();
      this.xrTable188.EndInit();
      this.xrTable187.EndInit();
      this.xrTable186.EndInit();
      this.xrTable185.EndInit();
      this.xrTable184.EndInit();
      this.xrTable183.EndInit();
      this.xrTable182.EndInit();
      this.xrTable181.EndInit();
      this.xrTable180.EndInit();
      this.xrTable179.EndInit();
      this.xrTable178.EndInit();
      this.xrTable177.EndInit();
      this.xrTable176.EndInit();
      this.xrTable175.EndInit();
      this.xrTable174.EndInit();
      this.xrTable173.EndInit();
      this.xrTable172.EndInit();
      this.xrTable171.EndInit();
      this.xrTable170.EndInit();
      this.xrTable169.EndInit();
      this.xrTable168.EndInit();
      this.xrTable167.EndInit();
      this.xrTable166.EndInit();
      this.xrTable165.EndInit();
      this.xrTable164.EndInit();
      this.xrTable163.EndInit();
      this.xrTable162.EndInit();
      this.xrTable161.EndInit();
      this.xrTable160.EndInit();
      this.xrTable159.EndInit();
      this.xrTable158.EndInit();
      this.xrTable157.EndInit();
      this.xrTable156.EndInit();
      this.xrTable155.EndInit();
      this.xrTable154.EndInit();
      this.xrTable153.EndInit();
      this.xrTable152.EndInit();
      this.xrTable151.EndInit();
      this.xrTable150.EndInit();
      this.xrTable149.EndInit();
      this.xrTable148.EndInit();
      this.xrTable147.EndInit();
      this.xrTable146.EndInit();
      this.xrTable145.EndInit();
      this.xrTable144.EndInit();
      this.xrTable143.EndInit();
      this.xrTable142.EndInit();
      this.xrTable141.EndInit();
      this.xrTable140.EndInit();
      this.xrTable139.EndInit();
      this.xrTable138.EndInit();
      this.xrTable137.EndInit();
      this.xrTable136.EndInit();
      this.xrTable135.EndInit();
      this.xrTable134.EndInit();
      this.xrTable133.EndInit();
      this.xrTable132.EndInit();
      this.xrTable131.EndInit();
      this.xrTable130.EndInit();
      this.xrTable129.EndInit();
      this.xrTable128.EndInit();
      this.xrTable127.EndInit();
      this.xrTable126.EndInit();
      this.xrTable125.EndInit();
      this.xrTable124.EndInit();
      this.xrTable123.EndInit();
      this.xrTable122.EndInit();
      this.xrTable121.EndInit();
      this.xrTable120.EndInit();
      this.xrTable119.EndInit();
      this.xrTable118.EndInit();
      this.xrTable116.EndInit();
      this.xrTable115.EndInit();
      this.EndInit();
    }
  }
}
