// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.insankaynak.izindurumliste
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using DevExpress.Data;
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
using DevExpress.XtraReports;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using Makina_Ikmal.bellDataSet2TableAdapters;
using Makina_Ikmal.Classlar;
using Makina_Ikmal.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Makina_Ikmal.insankaynak
{
  public class izindurumliste : Form
  {
    private bellEntities db = new bellEntities();
    private IContainer components = (IContainer) null;
    private RibbonControl ribbonControl1;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem barButtonItem1;
    private BarButtonItem barButtonItem2;
    private BarButtonItem barButtonItem3;
    private BarButtonItem barButtonItem4;
    private BarButtonItem barButtonItem5;
    private RibbonPageGroup ribbonPageGroup2;
    private BarButtonItem barButtonItem6;
    private BarButtonItem barButtonItem7;
    private RibbonPageGroup ribbonPageGroup4;
    private PanelControl panelControl1;
    private PanelControl panelControl3;
    private GridControl gridControl3;
    private GridView gridView3;
    private PanelControl panelControl2;
    private GridControl gridControl2;
    private GridView gridView2;
    private GridControl gridControl1;
    private GridView gridView1;
    private bellDataSet2 bellDataSet2;
    private BindingSource tBLPERSONELBindingSource;
    private TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    private GridColumn colID;
    private GridColumn colTCKIMLIKNO;
    private GridColumn colADISOYADI;
    private GridColumn colPERSISTIHDAMIID;
    private GridColumn colGOREVYERI;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource;
    private TBLPERSONELISTIHDAMDURUMTableAdapter tBLPERSONELISTIHDAMDURUMTableAdapter;
    private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private BindingSource tBLPERSONELBindingSource1;
    private BindingSource tBLPERSONELISTIHDAMDURUMBindingSource1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn ID;
    private GridColumn izinhakki;
    private GridColumn kullan;
    private GridColumn kalan;
    private GridColumn yil;
    private ReportGenerator reportGenerator1;
    private GridColumn adi;
    private GridColumn istihdam;
    private GridColumn tc;
    private GridColumn yil10;
    private GridColumn yil11;
    private GridColumn yil12;
    private GridColumn yil13;
    private GridColumn yil14;
    private GridColumn yil15;
    private GridColumn yil16;
    private GridColumn yil17;
    private GridColumn yil19;
    private GridColumn yil20;
    private GridColumn yil21;
    private GridColumn yil22;
    private GridColumn topla_kalan;
    private GridColumn yil18;

    public izindurumliste() => this.InitializeComponent();

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      YetkiClass.secim = "kayıt";
      int num = (int) new izinhakkiekleme().ShowDialog();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.Fill(this.bellDataSet2.TBLPERSONELISTIHDAMDURUM);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.hesap();
    }

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new Ekle().Show();
    }

    private void datagrid_doldur()
    {
      IQueryable<TBLPERIZINYILLARI> source = this.db.TBLPERIZINYILLARI.Select<TBLPERIZINYILLARI, TBLPERIZINYILLARI>((Expression<System.Func<TBLPERIZINYILLARI, TBLPERIZINYILLARI>>) (hd => hd));
      this.dataGridView1.ColumnCount = 5 + source.Count<TBLPERIZINYILLARI>();
      int num = 0;
      this.dataGridView1.Columns[0].Name = "ID";
      this.dataGridView1.Columns[1].Name = "T.C";
      this.dataGridView1.Columns[2].Name = "Adı Soyadı";
      this.dataGridView1.Columns[3].Name = "İstihdamı";
      foreach (TBLPERIZINYILLARI tblperizinyillari in (IEnumerable<TBLPERIZINYILLARI>) source)
      {
        this.dataGridView1.Columns[num + 4].Name = tblperizinyillari.YIL;
        ++num;
      }
      this.dataGridView1.Columns[num + 4].Name = "Toplam İzin";
      DbSet<TBLPERSONEL> tblpersonel1 = this.db.TBLPERSONEL;
      Expression<System.Func<TBLPERSONEL, bool>> predicate = (Expression<System.Func<TBLPERSONEL, bool>>) (hp => hp.PERSDURUMID == (int?) 1);
      foreach (TBLPERSONEL tblpersonel2 in (IEnumerable<TBLPERSONEL>) tblpersonel1.Where<TBLPERSONEL>(predicate))
      {
        string str;
        try
        {
          str = this.db.TBLPERSONELISTIHDAMDURUM.Find(new object[1]
          {
            (object) tblpersonel2.PERSISTIHDAMIID
          }).ADI;
        }
        catch (Exception ex)
        {
          str = "";
        }
        this.dataGridView1.Rows.Add((object) tblpersonel2.ID, (object) tblpersonel2.TCKIMLIKNO, (object) tblpersonel2.ADISOYADI, (object) str);
      }
    }

    private void hesapla_izin()
    {
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridView1.Rows)
      {
        for (int index = 4; index < this.dataGridView1.ColumnCount - 1; ++index)
        {
          int deger = Convert.ToInt32(row.Cells[0].Value);
          IQueryable<\u003C\u003Ef__AnonymousType47<int?, int?, int?, int?>> queryable = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) deger)).GroupBy<TBLPERSIZINDURUM, int?>((Expression<System.Func<TBLPERSIZINDURUM, int?>>) (hd => hd.IZINYILI)).Select(g => new
          {
            PersonId = g.Key,
            izin = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (a => a.IZINHAKKI)),
            kul = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (b => b.KULLANILANIZIN)),
            izinyili = g.Key
          });
          try
          {
            foreach (var data in queryable)
            {
              if (this.dataGridView1.Columns[index].Name.ToString() == data.izinyili.ToString())
              {
                int num1 = Convert.ToInt32((object) data.izin) - Convert.ToInt32((object) data.kul);
                row.Cells[index].Value = (object) num1;
                int num2 = (int) XtraMessageBox.Show("pers:" + deger.ToString() + " içerdeki :" + this.dataGridView1.Columns[index].Name.ToString());
              }
            }
          }
          catch (Exception ex)
          {
          }
        }
      }
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.gridView3.SetRowCellValue(5, this.gridView3.Columns[20], (object) 90);

    private void hesap()
    {
      string str1 = "";
      BindingList<izindurumliste.tabloelemanlari> source = new BindingList<izindurumliste.tabloelemanlari>();
      DbSet<TBLPERSONEL> tblpersonel1 = this.db.TBLPERSONEL;
      Expression<System.Func<TBLPERSONEL, bool>> predicate = (Expression<System.Func<TBLPERSONEL, bool>>) (hp => hp.PERSDURUMID == (int?) 1);
      foreach (TBLPERSONEL tblpersonel2 in (IEnumerable<TBLPERSONEL>) tblpersonel1.Where<TBLPERSONEL>(predicate))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        izindurumliste.\u003C\u003Ec__DisplayClass9_0 cDisplayClass90 = new izindurumliste.\u003C\u003Ec__DisplayClass9_0();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass90.getbe = tblpersonel2;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        izindurumliste.\u003C\u003Ec__DisplayClass9_1 cDisplayClass91 = new izindurumliste.\u003C\u003Ec__DisplayClass9_1();
        string str2;
        try
        {
          ParameterExpression parameterExpression;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: method reference
          str2 = this.db.TBLPERSONELISTIHDAMDURUM.FirstOrDefault<TBLPERSONELISTIHDAMDURUM>(Expression.Lambda<System.Func<TBLPERSONELISTIHDAMDURUM, bool>>((Expression) Expression.Equal(x.ID, (Expression) Expression.Call(cDisplayClass90.getbe.PERSISTIHDAMIID, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (object.ToString)), Array.Empty<Expression>())), parameterExpression)).ADI;
        }
        catch (Exception ex)
        {
          str2 = "";
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        cDisplayClass91.deger = Convert.ToInt32(cDisplayClass90.getbe.ID);
        // ISSUE: reference to a compiler-generated field
        IQueryable<\u003C\u003Ef__AnonymousType47<int?, int?, int?, int?>> queryable = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) cDisplayClass91.deger)).GroupBy<TBLPERSIZINDURUM, int?>((Expression<System.Func<TBLPERSIZINDURUM, int?>>) (hd => hd.IZINYILI)).Select(g => new
        {
          PersonId = g.Key,
          izin = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (a => a.IZINHAKKI)),
          kul = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (b => b.KULLANILANIZIN)),
          izinyili = g.Key
        });
        string str3 = "";
        string str4 = "";
        string str5 = "";
        string str6 = "";
        string str7 = "";
        string str8 = "";
        string str9 = "";
        string str10 = "";
        string str11 = "";
        string str12 = "";
        string str13 = "";
        string str14 = "";
        string str15 = "";
        str1 = "";
        int num1 = 0;
        foreach (var data in queryable)
        {
          int num2 = Convert.ToInt32((object) data.izin) - Convert.ToInt32((object) data.kul);
          int? izinyili1 = data.izinyili;
          int num3 = 2010;
          if (izinyili1.GetValueOrDefault() == num3 & izinyili1.HasValue)
          {
            str3 = num2.ToString();
            num1 += Convert.ToInt32(str3);
          }
          int? izinyili2 = data.izinyili;
          int num4 = 2011;
          if (izinyili2.GetValueOrDefault() == num4 & izinyili2.HasValue)
          {
            str4 = num2.ToString();
            num1 += Convert.ToInt32(str4);
          }
          int? izinyili3 = data.izinyili;
          int num5 = 2012;
          if (izinyili3.GetValueOrDefault() == num5 & izinyili3.HasValue)
          {
            str5 = num2.ToString();
            num1 += Convert.ToInt32(str5);
          }
          int? izinyili4 = data.izinyili;
          int num6 = 2013;
          if (izinyili4.GetValueOrDefault() == num6 & izinyili4.HasValue)
          {
            str6 = num2.ToString();
            num1 += Convert.ToInt32(str6);
          }
          int? izinyili5 = data.izinyili;
          int num7 = 2014;
          if (izinyili5.GetValueOrDefault() == num7 & izinyili5.HasValue)
          {
            str7 = num2.ToString();
            num1 += Convert.ToInt32(str7);
          }
          int? izinyili6 = data.izinyili;
          int num8 = 2015;
          if (izinyili6.GetValueOrDefault() == num8 & izinyili6.HasValue)
          {
            str8 = num2.ToString();
            num1 += Convert.ToInt32(str8);
          }
          int? izinyili7 = data.izinyili;
          int num9 = 2016;
          if (izinyili7.GetValueOrDefault() == num9 & izinyili7.HasValue)
          {
            str9 = num2.ToString();
            num1 += Convert.ToInt32(str9);
          }
          int? izinyili8 = data.izinyili;
          int num10 = 2017;
          if (izinyili8.GetValueOrDefault() == num10 & izinyili8.HasValue)
          {
            str10 = num2.ToString();
            num1 += Convert.ToInt32(str10);
          }
          int? izinyili9 = data.izinyili;
          int num11 = 2018;
          if (izinyili9.GetValueOrDefault() == num11 & izinyili9.HasValue)
          {
            str11 = num2.ToString();
            num1 += Convert.ToInt32(str11);
          }
          int? izinyili10 = data.izinyili;
          int num12 = 2019;
          if (izinyili10.GetValueOrDefault() == num12 & izinyili10.HasValue)
          {
            str12 = num2.ToString();
            num1 += Convert.ToInt32(str12);
          }
          int? izinyili11 = data.izinyili;
          int num13 = 2020;
          if (izinyili11.GetValueOrDefault() == num13 & izinyili11.HasValue)
          {
            str13 = num2.ToString();
            num1 += Convert.ToInt32(str13);
          }
          int? izinyili12 = data.izinyili;
          int num14 = 2021;
          if (izinyili12.GetValueOrDefault() == num14 & izinyili12.HasValue)
          {
            str14 = num2.ToString();
            num1 += Convert.ToInt32(str14);
          }
          int? izinyili13 = data.izinyili;
          int num15 = 2022;
          if (izinyili13.GetValueOrDefault() == num15 & izinyili13.HasValue)
          {
            str15 = num2.ToString();
            num1 += Convert.ToInt32(str15);
          }
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        source.Add(new izindurumliste.tabloelemanlari()
        {
          id = cDisplayClass90.getbe.ID,
          tc = cDisplayClass90.getbe.TCKIMLIKNO,
          adi = cDisplayClass90.getbe.ADISOYADI,
          istihdam = str2,
          yil10 = str3,
          yil11 = str4,
          yil12 = str5,
          yil13 = str6,
          yil14 = str7,
          yil15 = str8,
          yil16 = str9,
          yil17 = str10,
          yil18 = str11,
          yil19 = str12,
          yil20 = str13,
          yil21 = str14,
          yil22 = str15,
          topla_kalan = num1
        });
      }
      this.gridControl3.DataSource = (object) source.ToList<izindurumliste.tabloelemanlari>();
    }

    private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      int num1 = 0;
      BindingList<izindurumliste.ElemanlarDurum> source1 = new BindingList<izindurumliste.ElemanlarDurum>();
      int deger = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      IQueryable<IGrouping<int?, TBLPERSIZINDURUM>> source2 = this.db.TBLPERSIZINDURUM.Where<TBLPERSIZINDURUM>((Expression<System.Func<TBLPERSIZINDURUM, bool>>) (hd => hd.PERSONELID == (int?) deger)).GroupBy<TBLPERSIZINDURUM, int?>((Expression<System.Func<TBLPERSIZINDURUM, int?>>) (hd => hd.IZINYILI));
      Expression<System.Func<IGrouping<int?, TBLPERSIZINDURUM>, \u003C\u003Ef__AnonymousType47<int?, int?, int?, int?>>> selector = g => new
      {
        PersonId = g.Key,
        izin = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (a => a.IZINHAKKI)),
        kul = g.Sum<TBLPERSIZINDURUM>((System.Func<TBLPERSIZINDURUM, int?>) (b => b.KULLANILANIZIN)),
        izinyili = g.Key
      };
      foreach (var data in source2.Select(selector))
      {
        int num2 = Convert.ToInt32((object) data.izin) - Convert.ToInt32((object) data.kul);
        source1.Add(new izindurumliste.ElemanlarDurum()
        {
          yil = Convert.ToInt32((object) data.izinyili),
          izinhakki = Convert.ToInt32((object) data.izin),
          kullan = Convert.ToInt32((object) data.kul),
          kalan = num2
        });
        num1 = 0;
      }
      this.gridControl2.DataSource = (object) source1.ToList<izindurumliste.ElemanlarDurum>();
    }

    private void gridView3_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
    {
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e) => new ReportPrintTool((IReport) new iz_oz()).ShowPreviewDialog();

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.Fill(this.bellDataSet2.TBLPERSONELISTIHDAMDURUM);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.tBLPERSONELTableAdapter.Fill(this.bellDataSet2.TBLPERSONEL);
      this.hesap();
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      YetkiClass.secim = "guncelle";
      YetkiClass.secim_id = Convert.ToInt32(this.gridView1.GetFocusedRowCellValue("ID"));
      new izinhakkiekleme().Show();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (izindurumliste));
      this.ribbonControl1 = new RibbonControl();
      this.barButtonItem1 = new BarButtonItem();
      this.barButtonItem2 = new BarButtonItem();
      this.barButtonItem3 = new BarButtonItem();
      this.barButtonItem4 = new BarButtonItem();
      this.barButtonItem5 = new BarButtonItem();
      this.barButtonItem6 = new BarButtonItem();
      this.barButtonItem7 = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonPageGroup4 = new RibbonPageGroup();
      this.panelControl1 = new PanelControl();
      this.panelControl3 = new PanelControl();
      this.gridControl3 = new GridControl();
      this.gridView3 = new GridView();
      this.adi = new GridColumn();
      this.istihdam = new GridColumn();
      this.tc = new GridColumn();
      this.yil10 = new GridColumn();
      this.yil11 = new GridColumn();
      this.yil12 = new GridColumn();
      this.yil13 = new GridColumn();
      this.yil14 = new GridColumn();
      this.yil15 = new GridColumn();
      this.yil16 = new GridColumn();
      this.yil17 = new GridColumn();
      this.yil18 = new GridColumn();
      this.yil19 = new GridColumn();
      this.yil20 = new GridColumn();
      this.yil21 = new GridColumn();
      this.yil22 = new GridColumn();
      this.topla_kalan = new GridColumn();
      this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELISTIHDAMDURUMBindingSource1 = new BindingSource(this.components);
      this.bellDataSet2 = new bellDataSet2();
      this.dataGridView1 = new DataGridView();
      this.ID = new DataGridViewTextBoxColumn();
      this.panelControl2 = new PanelControl();
      this.gridControl2 = new GridControl();
      this.gridView2 = new GridView();
      this.yil = new GridColumn();
      this.izinhakki = new GridColumn();
      this.kullan = new GridColumn();
      this.kalan = new GridColumn();
      this.gridControl1 = new GridControl();
      this.tBLPERSONELBindingSource = new BindingSource(this.components);
      this.gridView1 = new GridView();
      this.colID = new GridColumn();
      this.colTCKIMLIKNO = new GridColumn();
      this.colADISOYADI = new GridColumn();
      this.colPERSISTIHDAMIID = new GridColumn();
      this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
      this.tBLPERSONELISTIHDAMDURUMBindingSource = new BindingSource(this.components);
      this.colGOREVYERI = new GridColumn();
      this.tBLPERSONELBindingSource1 = new BindingSource(this.components);
      this.tBLPERSONELTableAdapter = new TBLPERSONELTableAdapter();
      this.tBLPERSONELISTIHDAMDURUMTableAdapter = new TBLPERSONELISTIHDAMDURUMTableAdapter();
      this.reportGenerator1 = new ReportGenerator(this.components);
      this.ribbonControl1.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.panelControl3.BeginInit();
      this.panelControl3.SuspendLayout();
      this.gridControl3.BeginInit();
      this.gridView3.BeginInit();
      this.repositoryItemLookUpEdit2.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource1).BeginInit();
      this.bellDataSet2.BeginInit();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.gridControl2.BeginInit();
      this.gridView2.BeginInit();
      this.gridControl1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).BeginInit();
      this.gridView1.BeginInit();
      this.repositoryItemLookUpEdit1.BeginInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).BeginInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).BeginInit();
      this.SuspendLayout();
      this.ribbonControl1.AllowKeyTips = false;
      this.ribbonControl1.AllowMdiChildButtons = false;
      this.ribbonControl1.AllowMinimizeRibbon = false;
      this.ribbonControl1.AllowTrimPageText = false;
      this.ribbonControl1.AutoUpdateMergedRibbons = DefaultBoolean.False;
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new BarItem[9]
      {
        (BarItem) this.ribbonControl1.ExpandCollapseItem,
        (BarItem) this.ribbonControl1.SearchEditItem,
        (BarItem) this.barButtonItem1,
        (BarItem) this.barButtonItem2,
        (BarItem) this.barButtonItem3,
        (BarItem) this.barButtonItem4,
        (BarItem) this.barButtonItem5,
        (BarItem) this.barButtonItem6,
        (BarItem) this.barButtonItem7
      });
      this.ribbonControl1.Location = new Point(0, 0);
      this.ribbonControl1.MaxItemId = 8;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl1.PopupShowMode = PopupShowMode.Classic;
      this.ribbonControl1.ShowApplicationButton = DefaultBoolean.False;
      this.ribbonControl1.ShowDisplayOptionsMenuButton = DefaultBoolean.False;
      this.ribbonControl1.ShowExpandCollapseButton = DefaultBoolean.False;
      this.ribbonControl1.ShowMoreCommandsButton = DefaultBoolean.False;
      this.ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
      this.ribbonControl1.ShowQatLocationSelector = false;
      this.ribbonControl1.ShowToolbarCustomizeItem = false;
      this.ribbonControl1.Size = new Size(1446, 122);
      this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
      this.ribbonControl1.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
      this.ribbonControl1.TransparentEditorsMode = DefaultBoolean.False;
      this.barButtonItem1.ActAsDropDown = true;
      this.barButtonItem1.ButtonStyle = BarButtonStyle.DropDown;
      this.barButtonItem1.Caption = "Yeni Kayıt";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.Image");
      this.barButtonItem1.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem1.ImageOptions.LargeImage");
      this.barButtonItem1.LargeWidth = 100;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.barButtonItem2.Caption = "Düzenle";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.Image");
      this.barButtonItem2.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem2.ImageOptions.LargeImage");
      this.barButtonItem2.LargeWidth = 100;
      this.barButtonItem2.Name = "barButtonItem2";
      this.barButtonItem2.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.barButtonItem3.Caption = "Sil";
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.Image");
      this.barButtonItem3.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem3.ImageOptions.LargeImage");
      this.barButtonItem3.LargeWidth = 100;
      this.barButtonItem3.Name = "barButtonItem3";
      this.barButtonItem3.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem3.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.barButtonItem4.Caption = "Raporlar";
      this.barButtonItem4.Id = 4;
      this.barButtonItem4.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.Image");
      this.barButtonItem4.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem4.ImageOptions.LargeImage");
      this.barButtonItem4.LargeWidth = 100;
      this.barButtonItem4.Name = "barButtonItem4";
      this.barButtonItem4.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem4.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem5.Caption = "Yenile";
      this.barButtonItem5.Id = 5;
      this.barButtonItem5.ImageOptions.Image = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.Image");
      this.barButtonItem5.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("barButtonItem5.ImageOptions.LargeImage");
      this.barButtonItem5.LargeWidth = 100;
      this.barButtonItem5.Name = "barButtonItem5";
      this.barButtonItem5.RibbonStyle = RibbonItemStyles.Large;
      this.barButtonItem5.ItemClick += new ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
      this.ribbonPage1.Groups.AddRange(new RibbonPageGroup[3]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2,
        this.ribbonPageGroup4
      });
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem1);
      this.ribbonPageGroup1.ItemLinks.Add((BarItem) this.barButtonItem3);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup2.ImageOptions.SvgImageSize = new Size(100, 0);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem4);
      this.ribbonPageGroup2.ItemLinks.Add((BarItem) this.barButtonItem5);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup4.Alignment = RibbonPageGroupAlignment.Far;
      this.ribbonPageGroup4.ImageOptions.Image = (Image) componentResourceManager.GetObject("ribbonPageGroup4.ImageOptions.Image");
      this.ribbonPageGroup4.ItemLinks.Add((BarItem) this.barButtonItem7);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.panelControl1.Controls.Add((Control) this.panelControl3);
      this.panelControl1.Controls.Add((Control) this.panelControl2);
      this.panelControl1.Dock = DockStyle.Fill;
      this.panelControl1.Location = new Point(0, 122);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1446, 980);
      this.panelControl1.TabIndex = 3;
      this.panelControl3.Controls.Add((Control) this.gridControl3);
      this.panelControl3.Controls.Add((Control) this.dataGridView1);
      this.panelControl3.Dock = DockStyle.Bottom;
      this.panelControl3.Location = new Point(2, 690);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new Size(1442, 288);
      this.panelControl3.TabIndex = 1;
      this.gridControl3.Dock = DockStyle.Fill;
      this.gridControl3.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl3.Location = new Point(2, 2);
      this.gridControl3.MainView = (BaseView) this.gridView3;
      this.gridControl3.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl3.Name = "gridControl3";
      this.gridControl3.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit2
      });
      this.gridControl3.Size = new Size(1438, 284);
      this.gridControl3.TabIndex = 3;
      this.gridControl3.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView3
      });
      this.gridView3.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView3.Appearance.Row.Options.UseFont = true;
      this.gridView3.Columns.AddRange(new GridColumn[17]
      {
        this.adi,
        this.istihdam,
        this.tc,
        this.yil10,
        this.yil11,
        this.yil12,
        this.yil13,
        this.yil14,
        this.yil15,
        this.yil16,
        this.yil17,
        this.yil18,
        this.yil19,
        this.yil20,
        this.yil21,
        this.yil22,
        this.topla_kalan
      });
      this.gridView3.GridControl = this.gridControl3;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsFind.FindNullPrompt = "Ara";
      this.gridView3.CustomUnboundColumnData += new CustomColumnDataEventHandler(this.gridView3_CustomUnboundColumnData);
      this.adi.Caption = "Adı Soyadı";
      this.adi.FieldName = "adi";
      this.adi.MinWidth = 25;
      this.adi.Name = "adi";
      this.adi.Visible = true;
      this.adi.VisibleIndex = 0;
      this.adi.Width = 338;
      this.istihdam.Caption = "İstihdam";
      this.istihdam.FieldName = "istihdam";
      this.istihdam.MinWidth = 25;
      this.istihdam.Name = "istihdam";
      this.istihdam.Visible = true;
      this.istihdam.VisibleIndex = 1;
      this.istihdam.Width = 161;
      this.tc.Caption = "T.c Numarsı";
      this.tc.FieldName = "tc";
      this.tc.MinWidth = 25;
      this.tc.Name = "tc";
      this.tc.Visible = true;
      this.tc.VisibleIndex = 2;
      this.tc.Width = 161;
      this.yil10.Caption = "2010";
      this.yil10.FieldName = "yil10";
      this.yil10.MinWidth = 25;
      this.yil10.Name = "yil10";
      this.yil10.Visible = true;
      this.yil10.VisibleIndex = 3;
      this.yil10.Width = 52;
      this.yil11.Caption = "2011";
      this.yil11.FieldName = "yil11";
      this.yil11.MinWidth = 25;
      this.yil11.Name = "yil11";
      this.yil11.Visible = true;
      this.yil11.VisibleIndex = 4;
      this.yil11.Width = 52;
      this.yil12.Caption = "2012";
      this.yil12.FieldName = "yil12";
      this.yil12.MinWidth = 25;
      this.yil12.Name = "yil12";
      this.yil12.Visible = true;
      this.yil12.VisibleIndex = 5;
      this.yil12.Width = 52;
      this.yil13.Caption = "2013";
      this.yil13.FieldName = "yil13";
      this.yil13.MinWidth = 25;
      this.yil13.Name = "yil13";
      this.yil13.Visible = true;
      this.yil13.VisibleIndex = 6;
      this.yil13.Width = 52;
      this.yil14.Caption = "2014";
      this.yil14.FieldName = "yil14";
      this.yil14.MinWidth = 25;
      this.yil14.Name = "yil14";
      this.yil14.Visible = true;
      this.yil14.VisibleIndex = 7;
      this.yil14.Width = 52;
      this.yil15.Caption = "2015";
      this.yil15.FieldName = "yil15";
      this.yil15.MinWidth = 25;
      this.yil15.Name = "yil15";
      this.yil15.Visible = true;
      this.yil15.VisibleIndex = 8;
      this.yil15.Width = 52;
      this.yil16.Caption = "2016";
      this.yil16.FieldName = "yil16";
      this.yil16.MinWidth = 25;
      this.yil16.Name = "yil16";
      this.yil16.Visible = true;
      this.yil16.VisibleIndex = 9;
      this.yil16.Width = 52;
      this.yil17.Caption = "2017";
      this.yil17.FieldName = "yil17";
      this.yil17.MinWidth = 25;
      this.yil17.Name = "yil17";
      this.yil17.Visible = true;
      this.yil17.VisibleIndex = 10;
      this.yil17.Width = 52;
      this.yil18.Caption = "2018";
      this.yil18.FieldName = "yil18";
      this.yil18.MinWidth = 25;
      this.yil18.Name = "yil18";
      this.yil18.Visible = true;
      this.yil18.VisibleIndex = 11;
      this.yil18.Width = 52;
      this.yil19.Caption = "2019";
      this.yil19.FieldName = "yil19";
      this.yil19.MinWidth = 25;
      this.yil19.Name = "yil19";
      this.yil19.Visible = true;
      this.yil19.VisibleIndex = 12;
      this.yil19.Width = 52;
      this.yil20.Caption = "2020";
      this.yil20.FieldName = "yil20";
      this.yil20.MinWidth = 25;
      this.yil20.Name = "yil20";
      this.yil20.Visible = true;
      this.yil20.VisibleIndex = 13;
      this.yil20.Width = 52;
      this.yil21.Caption = "2021";
      this.yil21.FieldName = "yil21";
      this.yil21.MinWidth = 25;
      this.yil21.Name = "yil21";
      this.yil21.Visible = true;
      this.yil21.VisibleIndex = 14;
      this.yil21.Width = 52;
      this.yil22.Caption = "2022";
      this.yil22.FieldName = "yil22";
      this.yil22.MinWidth = 25;
      this.yil22.Name = "yil22";
      this.yil22.Visible = true;
      this.yil22.VisibleIndex = 15;
      this.yil22.Width = 52;
      this.topla_kalan.Caption = "Toplam İzin";
      this.topla_kalan.FieldName = "topla_kalan";
      this.topla_kalan.MinWidth = 25;
      this.topla_kalan.Name = "topla_kalan";
      this.topla_kalan.Visible = true;
      this.topla_kalan.VisibleIndex = 16;
      this.topla_kalan.Width = 70;
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit2.DataSource = (object) this.tBLPERSONELISTIHDAMDURUMBindingSource1;
      this.repositoryItemLookUpEdit2.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      this.tBLPERSONELISTIHDAMDURUMBindingSource1.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource1.DataSource = (object) this.bellDataSet2;
      this.bellDataSet2.DataSetName = "bellDataSet2";
      this.bellDataSet2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ID);
      this.dataGridView1.Dock = DockStyle.Fill;
      this.dataGridView1.Location = new Point(2, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new Size(1438, 284);
      this.dataGridView1.TabIndex = 4;
      this.ID.DataPropertyName = "ID";
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.Visible = false;
      this.panelControl2.Controls.Add((Control) this.gridControl2);
      this.panelControl2.Controls.Add((Control) this.gridControl1);
      this.panelControl2.Dock = DockStyle.Top;
      this.panelControl2.Location = new Point(2, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(1442, 511);
      this.panelControl2.TabIndex = 0;
      this.gridControl2.Dock = DockStyle.Fill;
      this.gridControl2.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl2.Location = new Point(953, 2);
      this.gridControl2.MainView = (BaseView) this.gridView2;
      this.gridControl2.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl2.Name = "gridControl2";
      this.gridControl2.Size = new Size(487, 507);
      this.gridControl2.TabIndex = 3;
      this.gridControl2.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView2
      });
      this.gridView2.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.Appearance.Row.Options.UseFont = true;
      this.gridView2.AppearancePrint.FooterPanel.Font = new Font("Tahoma", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView2.AppearancePrint.FooterPanel.Options.UseFont = true;
      this.gridView2.Columns.AddRange(new GridColumn[4]
      {
        this.yil,
        this.izinhakki,
        this.kullan,
        this.kalan
      });
      this.gridView2.GridControl = this.gridControl2;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsBehavior.Editable = false;
      this.gridView2.OptionsFind.FindNullPrompt = "Ara";
      this.gridView2.OptionsView.ShowFooter = true;
      this.yil.Caption = "Yılı";
      this.yil.FieldName = "yil";
      this.yil.MinWidth = 25;
      this.yil.Name = "yil";
      this.yil.Visible = true;
      this.yil.VisibleIndex = 0;
      this.yil.Width = 94;
      this.izinhakki.Caption = "İzin Hakkı";
      this.izinhakki.FieldName = "izinhakki";
      this.izinhakki.MinWidth = 25;
      this.izinhakki.Name = "izinhakki";
      this.izinhakki.OptionsColumn.AllowEdit = false;
      this.izinhakki.OptionsColumn.ReadOnly = true;
      this.izinhakki.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "izinhakki", "İzin Hakkı={0:0.##}")
      });
      this.izinhakki.Visible = true;
      this.izinhakki.VisibleIndex = 1;
      this.izinhakki.Width = 94;
      this.kullan.Caption = "Kullanılan İzin";
      this.kullan.FieldName = "kullan";
      this.kullan.MinWidth = 25;
      this.kullan.Name = "kullan";
      this.kullan.OptionsColumn.AllowEdit = false;
      this.kullan.OptionsColumn.ReadOnly = true;
      this.kullan.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "kullan", "Kullanılan İzin={0:0.##}")
      });
      this.kullan.Visible = true;
      this.kullan.VisibleIndex = 2;
      this.kullan.Width = 94;
      this.kalan.Caption = "Kalan İzin";
      this.kalan.FieldName = "kalan";
      this.kalan.MinWidth = 25;
      this.kalan.Name = "kalan";
      this.kalan.OptionsColumn.AllowEdit = false;
      this.kalan.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "kalan", "Kalan İzin={0:0.##}")
      });
      this.kalan.Visible = true;
      this.kalan.VisibleIndex = 3;
      this.kalan.Width = 94;
      this.gridControl1.DataSource = (object) this.tBLPERSONELBindingSource;
      this.gridControl1.Dock = DockStyle.Left;
      this.gridControl1.Font = new Font("Comic Sans MS", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridControl1.Location = new Point(2, 2);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.MenuManager = (IDXMenuManager) this.ribbonControl1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemLookUpEdit1
      });
      this.gridControl1.Size = new Size(951, 507);
      this.gridControl1.TabIndex = 2;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource.DataSource = (object) this.bellDataSet2;
      this.gridView1.Appearance.Row.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.gridView1.Appearance.Row.Options.UseFont = true;
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.colID,
        this.colTCKIMLIKNO,
        this.colADISOYADI,
        this.colPERSISTIHDAMIID,
        this.colGOREVYERI
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsFind.FindNullPrompt = "Ara";
      this.gridView1.OptionsView.EnableAppearanceOddRow = true;
      this.gridView1.RowHeight = 40;
      this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
      this.gridView1.DoubleClick += new EventHandler(this.gridView1_DoubleClick);
      this.colID.FieldName = "ID";
      this.colID.MinWidth = 25;
      this.colID.Name = "colID";
      this.colID.Width = 94;
      this.colTCKIMLIKNO.Caption = "T.C ";
      this.colTCKIMLIKNO.FieldName = "TCKIMLIKNO";
      this.colTCKIMLIKNO.MinWidth = 25;
      this.colTCKIMLIKNO.Name = "colTCKIMLIKNO";
      this.colTCKIMLIKNO.Visible = true;
      this.colTCKIMLIKNO.VisibleIndex = 0;
      this.colTCKIMLIKNO.Width = 94;
      this.colADISOYADI.Caption = "Adı Soyadı";
      this.colADISOYADI.FieldName = "ADISOYADI";
      this.colADISOYADI.MinWidth = 25;
      this.colADISOYADI.Name = "colADISOYADI";
      this.colADISOYADI.Visible = true;
      this.colADISOYADI.VisibleIndex = 1;
      this.colADISOYADI.Width = 94;
      this.colPERSISTIHDAMIID.Caption = "Personel İstihdam";
      this.colPERSISTIHDAMIID.ColumnEdit = (RepositoryItem) this.repositoryItemLookUpEdit1;
      this.colPERSISTIHDAMIID.FieldName = "PERSISTIHDAMIID";
      this.colPERSISTIHDAMIID.MinWidth = 25;
      this.colPERSISTIHDAMIID.Name = "colPERSISTIHDAMIID";
      this.colPERSISTIHDAMIID.Visible = true;
      this.colPERSISTIHDAMIID.VisibleIndex = 2;
      this.colPERSISTIHDAMIID.Width = 94;
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemLookUpEdit1.DataSource = (object) this.tBLPERSONELISTIHDAMDURUMBindingSource;
      this.repositoryItemLookUpEdit1.DisplayMember = "ADI";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataMember = "TBLPERSONELISTIHDAMDURUM";
      this.tBLPERSONELISTIHDAMDURUMBindingSource.DataSource = (object) this.bellDataSet2;
      this.colGOREVYERI.Caption = "Görev Yeri";
      this.colGOREVYERI.FieldName = "GOREVYERI";
      this.colGOREVYERI.MinWidth = 25;
      this.colGOREVYERI.Name = "colGOREVYERI";
      this.colGOREVYERI.Visible = true;
      this.colGOREVYERI.VisibleIndex = 3;
      this.colGOREVYERI.Width = 94;
      this.tBLPERSONELBindingSource1.DataMember = "TBLPERSONEL";
      this.tBLPERSONELBindingSource1.DataSource = (object) this.bellDataSet2;
      this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
      this.tBLPERSONELISTIHDAMDURUMTableAdapter.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1446, 1102);
      this.Controls.Add((Control) this.panelControl1);
      this.Controls.Add((Control) this.ribbonControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (izindurumliste);
      this.Text = "Personel İzin Durumu";
      this.Load += new EventHandler(this.Form6_Load);
      this.ribbonControl1.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl3.EndInit();
      this.panelControl3.ResumeLayout(false);
      this.gridControl3.EndInit();
      this.gridView3.EndInit();
      this.repositoryItemLookUpEdit2.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource1).EndInit();
      this.bellDataSet2.EndInit();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.gridControl2.EndInit();
      this.gridView2.EndInit();
      this.gridControl1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource).EndInit();
      this.gridView1.EndInit();
      this.repositoryItemLookUpEdit1.EndInit();
      ((ISupportInitialize) this.tBLPERSONELISTIHDAMDURUMBindingSource).EndInit();
      ((ISupportInitialize) this.tBLPERSONELBindingSource1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class ElemanlarDurum
    {
      public int yil { get; set; }

      public int izinhakki { get; set; }

      public int kullan { get; set; }

      public int kalan { get; set; }
    }

    public class tabloelemanlari
    {
      public string adi { get; set; }

      public string istihdam { get; set; }

      public int id { get; set; }

      public string tc { get; set; }

      public string yil10 { get; set; }

      public string yil11 { get; set; }

      public string yil12 { get; set; }

      public string yil13 { get; set; }

      public string yil14 { get; set; }

      public string yil15 { get; set; }

      public string yil16 { get; set; }

      public string yil17 { get; set; }

      public string yil18 { get; set; }

      public string yil19 { get; set; }

      public string yil20 { get; set; }

      public string yil21 { get; set; }

      public string yil22 { get; set; }

      public int topla_kalan { get; set; }
    }
  }
}
