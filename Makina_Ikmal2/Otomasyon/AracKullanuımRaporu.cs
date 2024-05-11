// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Otomasyon.AracKullanuımRaporu
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Makina_Ikmal.Model;
using Makina_Ikmal.Otomasyon.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Makina_Ikmal.Otomasyon
{
  public class AracKullanuımRaporu : XtraForm
  {
    private bellEntities db = new bellEntities();
    private GunlukMesafeRaporu gunlukMesafeRaporu = new GunlukMesafeRaporu();
    private AnaGrubaGore anaGrubaGore = new AnaGrubaGore();
    private AracKullanimRapor aracKullanimRapor = new AracKullanimRapor();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonPageGroup ribbonPageGroup4;
    private RepositoryItemTextEdit repositoryItemTextEdit1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem8;
    private BarButtonItem barButtonItem9;
    private BarEditItem barEditItem2;
    private RepositoryItemDateEdit repositoryItemDateEdit1;
    private BarEditItem barEditItem3;
    private RepositoryItemDateEdit repositoryItemDateEdit3;
    private RibbonPageGroup ribbonPageGroup3;
    private RibbonPageGroup ribbonPageGroup6;
    private RibbonPageGroup ribbonPageGroup5;
    private RepositoryItemComboBox repositoryItemComboBox1;
    private RepositoryItemDateEdit repositoryItemDateEdit2;
    private GridControl gridControl1;
    private GridView gridView1;
    private BarEditItem barEditItem1;
    private RepositoryItemSearchControl repositoryItemSearchControl1;
    private PopupMenu popupMenu1;
    private BarButtonItem birimlereBtn;
    private BarButtonItem anaGrubaBtn;
    private BarButtonItem listeBtn;
    private GridColumn colTARIHSAAT;
    private GridColumn colPLAKA;
    private GridColumn colMESAIICI;
    private GridColumn colMESAIDISI;
    private GridColumn colTOPLAMKM;
    private GridColumn colCALISMASURESI;
    private GridColumn colBELDBIRIMADI;
    private GridColumn colGRUPADI;
    private GridColumn colADISOYADI;
    private GridColumn colCEPTELEFON;
    private GridColumn colUNVAN;
    private GridColumn colaracID;
    private GridColumn colmesafeID;
    private RepositoryItemSearchLookUpEdit plaka;
    private GridView repositoryItemSearchLookUpEdit1View;

    public AracKullanuımRaporu() => this.InitializeComponent();

    private void AracKullanuımRaporu_Load(object sender, EventArgs e) => this.Listele();

    private void Listele()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AracKullanuımRaporu.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60 = new AracKullanuımRaporu.\u003C\u003Ec__DisplayClass6_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.\u003C\u003E4__this = this;
      IQueryable<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>> queryable = this.db.TBLARACZIMMET.OrderByDescending<TBLARACZIMMET, int>((Expression<System.Func<TBLARACZIMMET, int>>) (hd => hd.ID)).Select(hd => new
      {
        BELDBIRIMID = hd.BELDBIRIMID,
        ARACID = hd.ARACID,
        ZIMMETALANID = hd.ZIMMETALANID,
        TARIH = hd.TARIH
      });
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.zimmet = queryable;
      ParameterExpression parameterExpression1;
      ParameterExpression parameterExpression2;
      ParameterExpression parameterExpression3;
      ParameterExpression parameterExpression4;
      ParameterExpression parameterExpression5;
      ParameterExpression parameterExpression6;
      ParameterExpression parameterExpression7;
      ParameterExpression parameterExpression8;
      ParameterExpression parameterExpression9;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      this.gridControl1.DataSource = (object) this.db.TBLARACMESTKP.Join((IEnumerable<TBLARACLAR>) this.db.TBLARACLAR, (Expression<System.Func<TBLARACMESTKP, string>>) (hd => hd.PLAKA), (Expression<System.Func<TBLARACLAR, string>>) (ht => ht.PLAKA), (hd, ht) => new
      {
        hd = hd,
        ht = ht
      }).Join((IEnumerable<TBLBELDBIRIMLER>) this.db.TBLBELDBIRIMLER, data => data.ht.BELDBIRIMID, (Expression<System.Func<TBLBELDBIRIMLER, int?>>) (hp => (int?) hp.ID), (data, hp) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        hp = hp
      }).Join((IEnumerable<TBLARACGRUBU>) this.db.TBLARACGRUBU, data => data.\u003C\u003Eh__TransparentIdentifier0.ht.ARACGRUBUID, (Expression<System.Func<TBLARACGRUBU, int?>>) (hl => (int?) hl.ID), (data, hl) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        hl = hl
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.ht.TAKIPVARYOKID == (int?) 1).Select(data => new
      {
        TARIHSAAT = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TARIHSAAT,
        PLAKA = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.PLAKA,
        MESAIICI = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MESAIICI,
        MESAIDISI = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.MESAIDISI,
        TOPLAMKM = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.TOPLAMKM,
        CALISMASURESI = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.CALISMASURESI,
        BELDBIRIMADI = this.db.TBLBELDBIRIMLER.FirstOrDefault<TBLBELDBIRIMLER>((Expression<System.Func<TBLBELDBIRIMLER, bool>>) (y => (int?) y.ID == cDisplayClass60.zimmet.Where(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.Equal(r.ARACID, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_ht), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACLAR.get_ID))), typeof (int?))), parameterExpression2)).FirstOrDefault(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.LessThanOrEqual(x.TARIH, (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_hd), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACMESTKP.get_TARIHSAAT))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), parameterExpression3)).BELDBIRIMID)).BELDBIRIMADI,
        GRUPADI = data.hl.GRUPADI,
        ADISOYADI = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (y => (int?) y.ID == cDisplayClass60.zimmet.Where(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.Equal(r.ARACID, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_ht), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACLAR.get_ID))), typeof (int?))), parameterExpression4)).FirstOrDefault(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.LessThanOrEqual(x.TARIH, (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_hd), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACMESTKP.get_TARIHSAAT))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), parameterExpression5)).ZIMMETALANID)).ADISOYADI,
        CEPTELEFON = this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (y => (int?) y.ID == cDisplayClass60.zimmet.Where(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.Equal(r.ARACID, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_ht), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACLAR.get_ID))), typeof (int?))), parameterExpression6)).FirstOrDefault(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.LessThanOrEqual(x.TARIH, (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_hd), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACMESTKP.get_TARIHSAAT))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), parameterExpression7)).ZIMMETALANID)).CEPTELEFON,
        UNVAN = this.db.TBLPERSUNVAN.FirstOrDefault<TBLPERSUNVAN>((Expression<System.Func<TBLPERSUNVAN, bool>>) (z => (int?) z.ID == this.db.TBLPERSONEL.FirstOrDefault<TBLPERSONEL>((Expression<System.Func<TBLPERSONEL, bool>>) (y => (int?) y.ID == cDisplayClass60.zimmet.Where(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.Equal(r.ARACID, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_ht), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACLAR.get_ID))), typeof (int?))), parameterExpression8)).FirstOrDefault(Expression.Lambda<System.Func<\u003C\u003Ef__AnonymousType52<int?, int?, int?, DateTime?>, bool>>((Expression) Expression.LessThanOrEqual(x.TARIH, (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>.get_\u003C\u003Eh__TransparentIdentifier1), __typeref (\u003C\u003Ef__AnonymousType54<\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>, TBLARACGRUBU>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>.get_\u003C\u003Eh__TransparentIdentifier0), __typeref (\u003C\u003Ef__AnonymousType53<\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>, TBLBELDBIRIMLER>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>.get_hd), __typeref (\u003C\u003Ef__AnonymousType40<TBLARACMESTKP, TBLARACLAR>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TBLARACMESTKP.get_TARIHSAAT))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), parameterExpression9)).ZIMMETALANID)).UNVANID)).UNVAN,
        aracID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.ht.ID,
        mesafeID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.hd.ID
      }).OrderByDescending(x => x.TARIHSAAT).ToList();
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      int num = (int) new MesafeListesi().ShowDialog();
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      DateTime basla = Convert.ToDateTime(this.barEditItem2.EditValue);
      DateTime sona = Convert.ToDateTime(this.barEditItem3.EditValue);
      IQueryable<TBLARACMESTKP> source = this.db.TBLARACMESTKP.Where<TBLARACMESTKP>((Expression<System.Func<TBLARACMESTKP, bool>>) (hd => hd.TARIHSAAT <= (DateTime?) sona));
      Expression<System.Func<TBLARACMESTKP, bool>> predicate = (Expression<System.Func<TBLARACMESTKP, bool>>) (hd => hd.TARIHSAAT >= (DateTime?) basla);
      foreach (TBLARACMESTKP tblaracmestkp in (IEnumerable<TBLARACMESTKP>) source.Where<TBLARACMESTKP>(predicate))
      {
        TBLARACMESTKP item = tblaracmestkp;
        this.db.TBLARACMESTKP.Remove(this.db.TBLARACMESTKP.FirstOrDefault<TBLARACMESTKP>((Expression<System.Func<TBLARACMESTKP, bool>>) (x => x.ID == item.ID)));
      }
      this.db.SaveChanges();
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      string fileName = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable();
      table.Equals((object) this.db.TBLARACMESTKP);
      dataSet.Tables.Add(table);
      dataSet.WriteXmlSchema(fileName);
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
    {
      string str = "c:\\users\\" + Environment.UserName + "\\documents\\" + this.Text + ".xlsx";
      this.gridControl1.ExportToXlsx(str);
      Process.Start(str);
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e) => this.AracKullanuımRaporu_Load(sender, (EventArgs) e);

    private void birimlereBtn_ItemClick(object sender, ItemClickEventArgs e)
    {
      IQueryable<TBLBELDBIRIMLER> source = this.db.TBLBELDBIRIMLER.Select<TBLBELDBIRIMLER, TBLBELDBIRIMLER>((Expression<System.Func<TBLBELDBIRIMLER, TBLBELDBIRIMLER>>) (hd => hd));
      if (source.Count<TBLBELDBIRIMLER>() <= 0)
        return;
      foreach (TBLBELDBIRIMLER tblbeldbirimler in (IEnumerable<TBLBELDBIRIMLER>) source)
      {
        AnaGrubaGore anaGrubaGore = new AnaGrubaGore();
        anaGrubaGore.Parameters["id"].Value = (object) tblbeldbirimler.ID;
        anaGrubaGore.Parameters["id"].Visible = false;
        anaGrubaGore.Parameters["tarih1"].Value = (object) Convert.ToDateTime(this.barEditItem2.EditValue);
        anaGrubaGore.Parameters["tarih1"].Visible = false;
        anaGrubaGore.Parameters["tarih2"].Value = (object) Convert.ToDateTime(this.barEditItem3.EditValue);
        anaGrubaGore.Parameters["tarih2"].Visible = false;
        PdfExportOptions options = new PdfExportOptions()
        {
          PdfACompatibility = PdfACompatibility.PdfA1b
        };
        string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\" + tblbeldbirimler.BELDBIRIMADI + ".pdf";
        anaGrubaGore.ExportToPdf(path, options);
        Thread.Sleep(2000);
      }
    }

    private void anaGrubaBtn_ItemClick(object sender, ItemClickEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AracKullanuımRaporu));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem4 = new BarButtonItem();
      this.popupMenu1 = new PopupMenu(this.components);
      this.birimlereBtn = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem8 = new BarButtonItem();
      this.barButtonItem9 = new BarButtonItem();
      this.barEditItem2 = new BarEditItem();
      this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
      this.barEditItem3 = new BarEditItem();
      this.repositoryItemDateEdit3 = new RepositoryItemDateEdit();
      this.barEditItem1 = new BarEditItem();
      this.repositoryItemSearchControl1 = new RepositoryItemSearchControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.colTARIHSAAT = new GridColumn();
      this.colPLAKA = new GridColumn();
      this.colMESAIICI = new GridColumn();
      this.colMESAIDISI = new GridColumn();
      this.colTOPLAMKM = new GridColumn();
      this.colCALISMASURESI = new GridColumn();
      this.colBELDBIRIMADI = new GridColumn();
      this.colGRUPADI = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colCEPTELEFON = new GridColumn();
      this.colUNVAN = new GridColumn();
      this.colaracID = new GridColumn();
      this.plaka = new RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new GridView();
      this.colmesafeID = new GridColumn();
      this.anaGrubaBtn = new BarButtonItem();
      this.listeBtn = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup3 = new RibbonPageGroup();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup6 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.ribbonPageGroup5 = new RibbonPageGroup();
      this.repositoryItemTextEdit1 = new RepositoryItemTextEdit();
      this.repositoryItemComboBox1 = new RepositoryItemComboBox();
      this.repositoryItemDateEdit2 = new RepositoryItemDateEdit();
      this.ribbonControl1.BeginInit();
      this.popupMenu1.BeginInit();
      this.repositoryItemDateEdit1.BeginInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.BeginInit();
      this.repositoryItemDateEdit3.BeginInit();
      this.repositoryItemDateEdit3.CalendarTimeProperties.BeginInit();
      this.repositoryItemSearchControl1.BeginInit();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.plaka.BeginInit();
      this.repositoryItemSearchLookUpEdit1View.BeginInit();
      this.repositoryItemTextEdit1.BeginInit();
      this.repositoryItemComboBox1.BeginInit();
      this.repositoryItemDateEdit2.BeginInit();
      this.repositoryItemDateEdit2.CalendarTimeProperties.BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[17]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem8,
        (BarItem) this.barButtonItem9,
        (BarItem) this.barEditItem2,
        (BarItem) this.barEditItem3,
        (BarItem) this.barEditItem1,
        (BarItem) this.birimlereBtn,
        (BarItem) this.anaGrubaBtn,
        (BarItem) this.listeBtn
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.Margin = new Padding(2);
      this.ribbonControl1.MaxItemId = 22;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.OptionsMenuMinWidth = 247;
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.RepositoryItems.AddRange(new RepositoryItem[6]
      {
        (RepositoryItem) this.repositoryItemTextEdit1,
        (RepositoryItem) this.repositoryItemComboBox1,
        (RepositoryItem) this.repositoryItemDateEdit1,
        (RepositoryItem) this.repositoryItemDateEdit2,
        (RepositoryItem) this.repositoryItemDateEdit3,
        (RepositoryItem) this.repositoryItemSearchControl1
      });
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1347, 100);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem4.ActAsDropDown = true;
      this.barButtonItem4.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.DropDownControl = (PopupControl) this.popupMenu1;
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.popupMenu1.ItemLinks.Add((BarItem) this.birimlereBtn);
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      this.birimlereBtn.Caption = "Birimlere Göre Yazdır";
      this.birimlereBtn.Id = 19;
      this.birimlereBtn.Name = "birimlereBtn";
      this.birimlereBtn.ItemClick += new ItemClickEventHandler(this.birimlereBtn_ItemClick);
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem6.Caption = "Kapat";
      this.barButtonItem6.Id = 6;
      this.barButtonItem6.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.Image");
      this.barButtonItem6.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem6.ImageOptions.LargeImage");
      this.barButtonItem6.Name = "barButtonItem6";
      this.barButtonItem7.Caption = "Kapat";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.Image");
      this.barButtonItem7.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem7.ImageOptions.LargeImage");
      this.barButtonItem7.LargeWidth = 100;
      this.barButtonItem7.Name = "barButtonItem7";
      this.barButtonItem7.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem7.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
      this.barButtonItem1.Caption = "Şablon";
      this.barButtonItem1.Id = 9;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Yükle";
      this.barButtonItem2.Id = 10;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 11;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem8.Caption = "Yenile";
      this.barButtonItem8.Id = 12;
      this.barButtonItem8.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.Image");
      this.barButtonItem8.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem8.ImageOptions.LargeImage");
      this.barButtonItem8.LargeWidth = 100;
      this.barButtonItem8.Name = "barButtonItem8";
      this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
      this.barButtonItem9.Caption = "Excel";
      this.barButtonItem9.Id = 13;
      this.barButtonItem9.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.Image");
      this.barButtonItem9.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem9.ImageOptions.LargeImage");
      this.barButtonItem9.LargeWidth = 100;
      this.barButtonItem9.Name = "barButtonItem9";
      this.barButtonItem9.ItemClick += new ItemClickEventHandler(this.barButtonItem9_ItemClick);
      this.barEditItem2.Edit = (RepositoryItem) this.repositoryItemDateEdit1;
      this.barEditItem2.EditHeight = 25;
      this.barEditItem2.EditWidth = 140;
      this.barEditItem2.Id = 15;
      this.barEditItem2.Name = "barEditItem2";
      this.repositoryItemDateEdit1.AutoHeight = false;
      this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
      this.repositoryItemDateEdit1.NullText = "Başlama Tarihi";
      this.barEditItem3.Edit = (RepositoryItem) this.repositoryItemDateEdit3;
      this.barEditItem3.EditHeight = 25;
      this.barEditItem3.EditWidth = 140;
      this.barEditItem3.Id = 17;
      this.barEditItem3.Name = "barEditItem3";
      this.repositoryItemDateEdit3.AutoHeight = false;
      this.repositoryItemDateEdit3.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
      this.repositoryItemDateEdit3.NullText = "Bitiş Tarihi";
      this.barEditItem1.Edit = (RepositoryItem) this.repositoryItemSearchControl1;
      this.barEditItem1.EditHeight = 25;
      this.barEditItem1.EditWidth = 140;
      this.barEditItem1.Id = 18;
      this.barEditItem1.Name = "barEditItem1";
      this.repositoryItemSearchControl1.AutoHeight = false;
      this.repositoryItemSearchControl1.Buttons.AddRange(new EditorButton[2]
      {
        (EditorButton) new ClearButton(),
        (EditorButton) new SearchButton()
      });
      this.repositoryItemSearchControl1.Client = (ISearchControlClient) this.gridControl1;
      this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(0, 100);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.plaka
      });
      this.gridControl1.Size = new Size(1347, 510);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[13]
      {
        this.colTARIHSAAT,
        this.colPLAKA,
        this.colMESAIICI,
        this.colMESAIDISI,
        this.colTOPLAMKM,
        this.colCALISMASURESI,
        this.colBELDBIRIMADI,
        this.colGRUPADI,
        this.colADISOYADI,
        this.colCEPTELEFON,
        this.colUNVAN,
        this.colaracID,
        this.colmesafeID
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.colTARIHSAAT.Caption = "Tarih-Saat";
      this.colTARIHSAAT.FieldName = "TARIHSAAT";
      this.colTARIHSAAT.MinWidth = 21;
      this.colTARIHSAAT.Name = "colTARIHSAAT";
      this.colTARIHSAAT.Visible = true;
      this.colTARIHSAAT.VisibleIndex = 0;
      this.colTARIHSAAT.Width = 81;
      this.colPLAKA.Caption = "Plaka";
      this.colPLAKA.FieldName = "PLAKA";
      this.colPLAKA.MinWidth = 21;
      this.colPLAKA.Name = "colPLAKA";
      this.colPLAKA.Visible = true;
      this.colPLAKA.VisibleIndex = 1;
      this.colPLAKA.Width = 81;
      this.colMESAIICI.Caption = "Mesai İçi";
      this.colMESAIICI.FieldName = "MESAIICI";
      this.colMESAIICI.MinWidth = 21;
      this.colMESAIICI.Name = "colMESAIICI";
      this.colMESAIICI.Visible = true;
      this.colMESAIICI.VisibleIndex = 2;
      this.colMESAIICI.Width = 81;
      this.colMESAIDISI.Caption = "Mesai Dışı";
      this.colMESAIDISI.FieldName = "MESAIDISI";
      this.colMESAIDISI.MinWidth = 21;
      this.colMESAIDISI.Name = "colMESAIDISI";
      this.colMESAIDISI.Visible = true;
      this.colMESAIDISI.VisibleIndex = 3;
      this.colMESAIDISI.Width = 81;
      this.colTOPLAMKM.Caption = "Toplam Km";
      this.colTOPLAMKM.FieldName = "TOPLAMKM";
      this.colTOPLAMKM.MinWidth = 21;
      this.colTOPLAMKM.Name = "colTOPLAMKM";
      this.colTOPLAMKM.Visible = true;
      this.colTOPLAMKM.VisibleIndex = 4;
      this.colTOPLAMKM.Width = 81;
      this.colCALISMASURESI.Caption = "Çalışma Süresi";
      this.colCALISMASURESI.FieldName = "CALISMASURESI";
      this.colCALISMASURESI.MinWidth = 21;
      this.colCALISMASURESI.Name = "colCALISMASURESI";
      this.colCALISMASURESI.Visible = true;
      this.colCALISMASURESI.VisibleIndex = 5;
      this.colCALISMASURESI.Width = 81;
      this.colBELDBIRIMADI.Caption = "Birim Adı";
      this.colBELDBIRIMADI.FieldName = "BELDBIRIMADI";
      this.colBELDBIRIMADI.MinWidth = 21;
      this.colBELDBIRIMADI.Name = "colBELDBIRIMADI";
      this.colBELDBIRIMADI.Visible = true;
      this.colBELDBIRIMADI.VisibleIndex = 6;
      this.colBELDBIRIMADI.Width = 81;
      this.colGRUPADI.Caption = "Grup Adı";
      this.colGRUPADI.FieldName = "GRUPADI";
      this.colGRUPADI.MinWidth = 21;
      this.colGRUPADI.Name = "colGRUPADI";
      this.colGRUPADI.Visible = true;
      this.colGRUPADI.VisibleIndex = 7;
      this.colGRUPADI.Width = 81;
      this.colADISOYADI.Caption = "Adı Soyadı";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 21;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 8;
      this.colADISOYADI.Width = 81;
      this.colCEPTELEFON.Caption = "Cep Telefon";
      this.colCEPTELEFON.FieldName = "CEPTELEFON";
      this.colCEPTELEFON.MinWidth = 21;
      this.colCEPTELEFON.Name = "colCEPTELEFON";
      this.colCEPTELEFON.Visible = true;
      this.colCEPTELEFON.VisibleIndex = 9;
      this.colCEPTELEFON.Width = 81;
      this.colUNVAN.Caption = "Ünvan";
      this.colUNVAN.FieldName = "UNVAN";
      this.colUNVAN.MinWidth = 21;
      this.colUNVAN.Name = "colUNVAN";
      this.colUNVAN.Visible = true;
      this.colUNVAN.VisibleIndex = 10;
      this.colUNVAN.Width = 81;
      this.colaracID.Caption = "Plaka";
      this.colaracID.ColumnEdit = (RepositoryItem) this.plaka;
      this.colaracID.FieldName = "aracID";
      this.colaracID.MinWidth = 21;
      this.colaracID.Name = "colaracID";
      this.colaracID.Width = 81;
      this.plaka.AutoHeight = false;
      this.plaka.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.plaka.DisplayMember = "PLAKA";
      this.plaka.Name = "plaka";
      this.plaka.NullText = "";
      this.plaka.PopupView = (ColumnView) this.repositoryItemSearchLookUpEdit1View;
      this.plaka.ValueMember = "ID";
      this.repositoryItemSearchLookUpEdit1View.DetailHeight = 284;
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.colmesafeID.FieldName = "mesafeID";
      this.colmesafeID.MinWidth = 21;
      this.colmesafeID.Name = "colmesafeID";
      this.colmesafeID.Width = 81;
      this.anaGrubaBtn.Caption = "Ana Gruba Göre Yazdır";
      this.anaGrubaBtn.Id = 20;
      this.anaGrubaBtn.Name = "anaGrubaBtn";
      this.anaGrubaBtn.VisibleInSearchMenu = false;
      this.anaGrubaBtn.ItemClick += new ItemClickEventHandler(this.anaGrubaBtn_ItemClick);
      this.listeBtn.Caption = "Listeyi Yazdır";
      this.listeBtn.Id = 21;
      this.listeBtn.Name = "listeBtn";
      this.listeBtn.VisibleInSearchMenu = false;
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[6]
      {
        this.ribbonPageGroup3,
        this.ribbonPageGroup1,
        this.ribbonPageGroup6,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4,
        this.ribbonPageGroup5
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup3.ItemLinks.Add((BarItem) this.barEditItem1);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem2);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barEditItem2);
      this.ribbonPageGroup6.ItemLinks.Add((BarItem) this.barEditItem3);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem8);
      this.ribbonPageGroup5.ItemLinks.Add((BarItem) this.barButtonItem9);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      this.repositoryItemComboBox1.AutoHeight = false;
      this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
      this.repositoryItemDateEdit2.AutoHeight = false;
      this.repositoryItemDateEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1347, 610);
      this.Controls.Add((Control) this.gridControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.Name = nameof (AracKullanuımRaporu);
      this.Text = "Araç Kullanuım Raporu";
      this.Load += new EventHandler(this.AracKullanuımRaporu_Load);
      this.ribbonControl1.EndInit();
      this.popupMenu1.EndInit();
      this.repositoryItemDateEdit1.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit1.EndInit();
      this.repositoryItemDateEdit3.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit3.EndInit();
      this.repositoryItemSearchControl1.EndInit();
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.plaka.EndInit();
      this.repositoryItemSearchLookUpEdit1View.EndInit();
      this.repositoryItemTextEdit1.EndInit();
      this.repositoryItemComboBox1.EndInit();
      this.repositoryItemDateEdit2.CalendarTimeProperties.EndInit();
      this.repositoryItemDateEdit2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
