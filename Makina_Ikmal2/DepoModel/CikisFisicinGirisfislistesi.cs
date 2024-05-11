// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.DepoModel.CikisFisicinGirisfislistesi
// Assembly: Makina_Ikmal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 37AF6E28-EA25-4A95-AAA2-C2BD57759ADD
// Assembly location: C:\Program Files (x86)\Bayer Yazılım\Buyuksehir_Ikmal\Makina_Ikmal.exe

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Makina_Ikmal.DepoModel
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("CikisFisicinGirisfislistesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class CikisFisicinGirisfislistesi : DataSet
  {
    private CikisFisicinGirisfislistesi.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public CikisFisicinGirisfislistesi()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected CikisFisicinGirisfislistesi(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (DataTable1)] != null)
            base.Tables.Add((DataTable) new CikisFisicinGirisfislistesi.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public CikisFisicinGirisfislistesi.DataTable1DataTable DataTable1 => this.tableDataTable1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataSet Clone()
    {
      CikisFisicinGirisfislistesi fisicinGirisfislistesi = (CikisFisicinGirisfislistesi) base.Clone();
      fisicinGirisfislistesi.InitVars();
      fisicinGirisfislistesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) fisicinGirisfislistesi;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["DataTable1"] != null)
          base.Tables.Add((DataTable) new CikisFisicinGirisfislistesi.DataTable1DataTable(dataSet.Tables["DataTable1"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableDataTable1 = (CikisFisicinGirisfislistesi.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (CikisFisicinGirisfislistesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/CikisFisicinGirisfislistesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new CikisFisicinGirisfislistesi.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      CikisFisicinGirisfislistesi fisicinGirisfislistesi = new CikisFisicinGirisfislistesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = fisicinGirisfislistesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = fisicinGirisfislistesi.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedDataSetSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedDataSetSchema;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable1RowChangeEventHandler(
      object sender,
      CikisFisicinGirisfislistesi.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<CikisFisicinGirisfislistesi.DataTable1Row>
    {
      private DataColumn columnİş_Emri_Kodu;
      private DataColumn columnARACID;
      private DataColumn columnDepo_Fiş_Kodu;
      private DataColumn columnTARIH;
      private DataColumn columnFIRMAID;
      private DataColumn columnFISTUTAR;
      private DataColumn columnTOPKDVTUTAR;
      private DataColumn columnTalep_Fiş_Kodu;
      private DataColumn columnIMZADEPOYETKILIID;
      private DataColumn columnISLEMTIPIID;
      private DataColumn columnISLEMTIPI;
      private DataColumn columnExpr1;
      private DataColumn columnExpr2;
      private DataColumn columnExpr3;
      private DataColumn columnExpr4;
      private DataColumn columnISEMRIID;
      private DataColumn columnKOD;
      private DataColumn columnSAAT;
      private DataColumn columnTALEPDURUMID;
      private DataColumn columnTALEPIPTALACIKLAMA;
      private DataColumn columnTALEPEDENUSTAID;
      private DataColumn columnATOLYESEFID;
      private DataColumn columnDEPOYETKILIID;
      private DataColumn columnMUDURID;
      private DataColumn columnMUDONAYZAMAN;
      private DataColumn columnTALEPKAYITID;
      private DataColumn columnSAVEUSER;
      private DataColumn columnSAVEDATE;
      private DataColumn columnEDITUSER;
      private DataColumn columnEDITDATE;
      private DataColumn columnSAVEMAC;
      private DataColumn columnEDITMAC;
      private DataColumn columnSAVEIP;
      private DataColumn columnEDITIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1DataTable()
      {
        this.TableName = "DataTable1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1DataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İş_Emri_KoduColumn => this.columnİş_Emri_Kodu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Depo_Fiş_KoduColumn => this.columnDepo_Fiş_Kodu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAIDColumn => this.columnFIRMAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FISTUTARColumn => this.columnFISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TOPKDVTUTARColumn => this.columnTOPKDVTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Talep_Fiş_KoduColumn => this.columnTalep_Fiş_Kodu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IMZADEPOYETKILIIDColumn => this.columnIMZADEPOYETKILIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIIDColumn => this.columnISLEMTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIColumn => this.columnISLEMTIPI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr2Column => this.columnExpr2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr3Column => this.columnExpr3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr4Column => this.columnExpr4;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISEMRIIDColumn => this.columnISEMRIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAATColumn => this.columnSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPDURUMIDColumn => this.columnTALEPDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPIPTALACIKLAMAColumn => this.columnTALEPIPTALACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPEDENUSTAIDColumn => this.columnTALEPEDENUSTAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ATOLYESEFIDColumn => this.columnATOLYESEFID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEPOYETKILIIDColumn => this.columnDEPOYETKILIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MUDURIDColumn => this.columnMUDURID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MUDONAYZAMANColumn => this.columnMUDONAYZAMAN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPKAYITIDColumn => this.columnTALEPKAYITID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEUSERColumn => this.columnSAVEUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEDATEColumn => this.columnSAVEDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITUSERColumn => this.columnEDITUSER;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITDATEColumn => this.columnEDITDATE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEMACColumn => this.columnSAVEMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITMACColumn => this.columnEDITMAC;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAVEIPColumn => this.columnSAVEIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn EDITIPColumn => this.columnEDITIP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public CikisFisicinGirisfislistesi.DataTable1Row this[int index] => (CikisFisicinGirisfislistesi.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event CikisFisicinGirisfislistesi.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event CikisFisicinGirisfislistesi.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event CikisFisicinGirisfislistesi.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event CikisFisicinGirisfislistesi.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(CikisFisicinGirisfislistesi.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public CikisFisicinGirisfislistesi.DataTable1Row AddDataTable1Row(
        string İş_Emri_Kodu,
        int ARACID,
        string Depo_Fiş_Kodu,
        DateTime TARIH,
        int FIRMAID,
        double FISTUTAR,
        double TOPKDVTUTAR,
        string Talep_Fiş_Kodu,
        int IMZADEPOYETKILIID,
        string ISLEMTIPIID,
        string ISLEMTIPI,
        DateTime Expr2,
        int Expr3,
        double Expr4,
        int ISEMRIID,
        string KOD,
        DateTime SAAT,
        int TALEPDURUMID,
        string TALEPIPTALACIKLAMA,
        int TALEPEDENUSTAID,
        int ATOLYESEFID,
        int DEPOYETKILIID,
        int MUDURID,
        DateTime MUDONAYZAMAN,
        int TALEPKAYITID,
        string SAVEUSER,
        DateTime SAVEDATE,
        string EDITUSER,
        DateTime EDITDATE,
        string SAVEMAC,
        string EDITMAC,
        string SAVEIP,
        string EDITIP)
      {
        CikisFisicinGirisfislistesi.DataTable1Row row = (CikisFisicinGirisfislistesi.DataTable1Row) this.NewRow();
        object[] objArray = new object[34]
        {
          (object) İş_Emri_Kodu,
          (object) ARACID,
          (object) Depo_Fiş_Kodu,
          (object) TARIH,
          (object) FIRMAID,
          (object) FISTUTAR,
          (object) TOPKDVTUTAR,
          (object) Talep_Fiş_Kodu,
          (object) IMZADEPOYETKILIID,
          (object) ISLEMTIPIID,
          (object) ISLEMTIPI,
          null,
          (object) Expr2,
          (object) Expr3,
          (object) Expr4,
          (object) ISEMRIID,
          (object) KOD,
          (object) SAAT,
          (object) TALEPDURUMID,
          (object) TALEPIPTALACIKLAMA,
          (object) TALEPEDENUSTAID,
          (object) ATOLYESEFID,
          (object) DEPOYETKILIID,
          (object) MUDURID,
          (object) MUDONAYZAMAN,
          (object) TALEPKAYITID,
          (object) SAVEUSER,
          (object) SAVEDATE,
          (object) EDITUSER,
          (object) EDITDATE,
          (object) SAVEMAC,
          (object) EDITMAC,
          (object) SAVEIP,
          (object) EDITIP
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public CikisFisicinGirisfislistesi.DataTable1Row FindByExpr1(int Expr1) => (CikisFisicinGirisfislistesi.DataTable1Row) this.Rows.Find(new object[1]
      {
        (object) Expr1
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        CikisFisicinGirisfislistesi.DataTable1DataTable dataTable1DataTable = (CikisFisicinGirisfislistesi.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new CikisFisicinGirisfislistesi.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnİş_Emri_Kodu = this.Columns["İş Emri Kodu"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnDepo_Fiş_Kodu = this.Columns["Depo Fiş Kodu"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnFIRMAID = this.Columns["FIRMAID"];
        this.columnFISTUTAR = this.Columns["FISTUTAR"];
        this.columnTOPKDVTUTAR = this.Columns["TOPKDVTUTAR"];
        this.columnTalep_Fiş_Kodu = this.Columns["Talep Fiş Kodu"];
        this.columnIMZADEPOYETKILIID = this.Columns["IMZADEPOYETKILIID"];
        this.columnISLEMTIPIID = this.Columns["ISLEMTIPIID"];
        this.columnISLEMTIPI = this.Columns["ISLEMTIPI"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnExpr2 = this.Columns["Expr2"];
        this.columnExpr3 = this.Columns["Expr3"];
        this.columnExpr4 = this.Columns["Expr4"];
        this.columnISEMRIID = this.Columns["ISEMRIID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnSAAT = this.Columns["SAAT"];
        this.columnTALEPDURUMID = this.Columns["TALEPDURUMID"];
        this.columnTALEPIPTALACIKLAMA = this.Columns["TALEPIPTALACIKLAMA"];
        this.columnTALEPEDENUSTAID = this.Columns["TALEPEDENUSTAID"];
        this.columnATOLYESEFID = this.Columns["ATOLYESEFID"];
        this.columnDEPOYETKILIID = this.Columns["DEPOYETKILIID"];
        this.columnMUDURID = this.Columns["MUDURID"];
        this.columnMUDONAYZAMAN = this.Columns["MUDONAYZAMAN"];
        this.columnTALEPKAYITID = this.Columns["TALEPKAYITID"];
        this.columnSAVEUSER = this.Columns["SAVEUSER"];
        this.columnSAVEDATE = this.Columns["SAVEDATE"];
        this.columnEDITUSER = this.Columns["EDITUSER"];
        this.columnEDITDATE = this.Columns["EDITDATE"];
        this.columnSAVEMAC = this.Columns["SAVEMAC"];
        this.columnEDITMAC = this.Columns["EDITMAC"];
        this.columnSAVEIP = this.Columns["SAVEIP"];
        this.columnEDITIP = this.Columns["EDITIP"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnİş_Emri_Kodu = new DataColumn("İş Emri Kodu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİş_Emri_Kodu);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnDepo_Fiş_Kodu = new DataColumn("Depo Fiş Kodu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDepo_Fiş_Kodu);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnFIRMAID = new DataColumn("FIRMAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAID);
        this.columnFISTUTAR = new DataColumn("FISTUTAR", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISTUTAR);
        this.columnTOPKDVTUTAR = new DataColumn("TOPKDVTUTAR", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPKDVTUTAR);
        this.columnTalep_Fiş_Kodu = new DataColumn("Talep Fiş Kodu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTalep_Fiş_Kodu);
        this.columnIMZADEPOYETKILIID = new DataColumn("IMZADEPOYETKILIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZADEPOYETKILIID);
        this.columnISLEMTIPIID = new DataColumn("ISLEMTIPIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPIID);
        this.columnISLEMTIPI = new DataColumn("ISLEMTIPI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPI);
        this.columnExpr1 = new DataColumn("Expr1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnExpr2 = new DataColumn("Expr2", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr2);
        this.columnExpr3 = new DataColumn("Expr3", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr3);
        this.columnExpr4 = new DataColumn("Expr4", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr4);
        this.columnISEMRIID = new DataColumn("ISEMRIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRIID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnSAAT = new DataColumn("SAAT", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAAT);
        this.columnTALEPDURUMID = new DataColumn("TALEPDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPDURUMID);
        this.columnTALEPIPTALACIKLAMA = new DataColumn("TALEPIPTALACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPIPTALACIKLAMA);
        this.columnTALEPEDENUSTAID = new DataColumn("TALEPEDENUSTAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPEDENUSTAID);
        this.columnATOLYESEFID = new DataColumn("ATOLYESEFID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnATOLYESEFID);
        this.columnDEPOYETKILIID = new DataColumn("DEPOYETKILIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEPOYETKILIID);
        this.columnMUDURID = new DataColumn("MUDURID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMUDURID);
        this.columnMUDONAYZAMAN = new DataColumn("MUDONAYZAMAN", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMUDONAYZAMAN);
        this.columnTALEPKAYITID = new DataColumn("TALEPKAYITID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPKAYITID);
        this.columnSAVEUSER = new DataColumn("SAVEUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEUSER);
        this.columnSAVEDATE = new DataColumn("SAVEDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEDATE);
        this.columnEDITUSER = new DataColumn("EDITUSER", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITUSER);
        this.columnEDITDATE = new DataColumn("EDITDATE", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITDATE);
        this.columnSAVEMAC = new DataColumn("SAVEMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEMAC);
        this.columnEDITMAC = new DataColumn("EDITMAC", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITMAC);
        this.columnSAVEIP = new DataColumn("SAVEIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAVEIP);
        this.columnEDITIP = new DataColumn("EDITIP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEDITIP);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnExpr1
        }, true));
        this.columnİş_Emri_Kodu.MaxLength = 50;
        this.columnDepo_Fiş_Kodu.MaxLength = 50;
        this.columnTalep_Fiş_Kodu.MaxLength = 50;
        this.columnISLEMTIPIID.MaxLength = 50;
        this.columnISLEMTIPI.MaxLength = 50;
        this.columnExpr1.AutoIncrement = true;
        this.columnExpr1.AutoIncrementSeed = -1L;
        this.columnExpr1.AutoIncrementStep = -1L;
        this.columnExpr1.AllowDBNull = false;
        this.columnExpr1.ReadOnly = true;
        this.columnExpr1.Unique = true;
        this.columnKOD.MaxLength = 50;
        this.columnTALEPIPTALACIKLAMA.MaxLength = 80;
        this.columnSAVEUSER.MaxLength = 50;
        this.columnEDITUSER.MaxLength = 50;
        this.columnSAVEMAC.MaxLength = 20;
        this.columnEDITMAC.MaxLength = 20;
        this.columnSAVEIP.MaxLength = 20;
        this.columnEDITIP.MaxLength = 20;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public CikisFisicinGirisfislistesi.DataTable1Row NewDataTable1Row() => (CikisFisicinGirisfislistesi.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new CikisFisicinGirisfislistesi.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (CikisFisicinGirisfislistesi.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new CikisFisicinGirisfislistesi.DataTable1RowChangeEvent((CikisFisicinGirisfislistesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new CikisFisicinGirisfislistesi.DataTable1RowChangeEvent((CikisFisicinGirisfislistesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new CikisFisicinGirisfislistesi.DataTable1RowChangeEvent((CikisFisicinGirisfislistesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new CikisFisicinGirisfislistesi.DataTable1RowChangeEvent((CikisFisicinGirisfislistesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(CikisFisicinGirisfislistesi.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        CikisFisicinGirisfislistesi fisicinGirisfislistesi = new CikisFisicinGirisfislistesi();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = fisicinGirisfislistesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = fisicinGirisfislistesi.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    public class DataTable1Row : DataRow
    {
      private CikisFisicinGirisfislistesi.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (CikisFisicinGirisfislistesi.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İş_Emri_Kodu
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.İş_Emri_KoduColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'İş Emri Kodu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İş_Emri_KoduColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Depo_Fiş_Kodu
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Depo_Fiş_KoduColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Depo Fiş Kodu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Depo_Fiş_KoduColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double FISTUTAR
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.FISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FISTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double TOPKDVTUTAR
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.TOPKDVTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TOPKDVTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TOPKDVTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Talep_Fiş_Kodu
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Talep_Fiş_KoduColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Talep Fiş Kodu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Talep_Fiş_KoduColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IMZADEPOYETKILIID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.IMZADEPOYETKILIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'IMZADEPOYETKILIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IMZADEPOYETKILIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISLEMTIPIID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ISLEMTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ISLEMTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISLEMTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISLEMTIPI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ISLEMTIPIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ISLEMTIPI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISLEMTIPIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Expr1
      {
        get => (int) this[this.tableDataTable1.Expr1Column];
        set => this[this.tableDataTable1.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime Expr2
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.Expr2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Expr3
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Expr3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr3' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public double Expr4
      {
        get
        {
          try
          {
            return (double) this[this.tableDataTable1.Expr4Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr4' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr4Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRIID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ISEMRIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ISEMRIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ISEMRIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAAT
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.SAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.TALEPDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TALEPDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TALEPDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TALEPIPTALACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TALEPIPTALACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TALEPIPTALACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TALEPIPTALACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPEDENUSTAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.TALEPEDENUSTAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TALEPEDENUSTAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TALEPEDENUSTAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ATOLYESEFID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ATOLYESEFIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ATOLYESEFID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ATOLYESEFIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int DEPOYETKILIID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.DEPOYETKILIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'DEPOYETKILIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEPOYETKILIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MUDURID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MUDURIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MUDURID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MUDURIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime MUDONAYZAMAN
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.MUDONAYZAMANColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MUDONAYZAMAN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MUDONAYZAMANColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPKAYITID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.TALEPKAYITIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TALEPKAYITID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TALEPKAYITIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SAVEUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SAVEUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SAVEUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime SAVEDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.SAVEDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SAVEDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SAVEDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITUSER
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.EDITUSERColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'EDITUSER' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.EDITUSERColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime EDITDATE
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.EDITDATEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'EDITDATE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.EDITDATEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SAVEMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SAVEMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SAVEMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITMAC
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.EDITMACColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'EDITMAC' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.EDITMACColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAVEIP
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SAVEIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'SAVEIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SAVEIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string EDITIP
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.EDITIPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'EDITIP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.EDITIPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİş_Emri_KoduNull() => this.IsNull(this.tableDataTable1.İş_Emri_KoduColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİş_Emri_KoduNull() => this[this.tableDataTable1.İş_Emri_KoduColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableDataTable1.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableDataTable1.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDepo_Fiş_KoduNull() => this.IsNull(this.tableDataTable1.Depo_Fiş_KoduColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDepo_Fiş_KoduNull() => this[this.tableDataTable1.Depo_Fiş_KoduColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable1.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable1.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMAIDNull() => this.IsNull(this.tableDataTable1.FIRMAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMAIDNull() => this[this.tableDataTable1.FIRMAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISTUTARNull() => this.IsNull(this.tableDataTable1.FISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISTUTARNull() => this[this.tableDataTable1.FISTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTOPKDVTUTARNull() => this.IsNull(this.tableDataTable1.TOPKDVTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTOPKDVTUTARNull() => this[this.tableDataTable1.TOPKDVTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTalep_Fiş_KoduNull() => this.IsNull(this.tableDataTable1.Talep_Fiş_KoduColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTalep_Fiş_KoduNull() => this[this.tableDataTable1.Talep_Fiş_KoduColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIMZADEPOYETKILIIDNull() => this.IsNull(this.tableDataTable1.IMZADEPOYETKILIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIMZADEPOYETKILIIDNull() => this[this.tableDataTable1.IMZADEPOYETKILIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPIIDNull() => this.IsNull(this.tableDataTable1.ISLEMTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPIIDNull() => this[this.tableDataTable1.ISLEMTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPINull() => this.IsNull(this.tableDataTable1.ISLEMTIPIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPINull() => this[this.tableDataTable1.ISLEMTIPIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr2Null() => this.IsNull(this.tableDataTable1.Expr2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr2Null() => this[this.tableDataTable1.Expr2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr3Null() => this.IsNull(this.tableDataTable1.Expr3Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr3Null() => this[this.tableDataTable1.Expr3Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr4Null() => this.IsNull(this.tableDataTable1.Expr4Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr4Null() => this[this.tableDataTable1.Expr4Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIIDNull() => this.IsNull(this.tableDataTable1.ISEMRIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIIDNull() => this[this.tableDataTable1.ISEMRIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableDataTable1.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableDataTable1.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAATNull() => this.IsNull(this.tableDataTable1.SAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAATNull() => this[this.tableDataTable1.SAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPDURUMIDNull() => this.IsNull(this.tableDataTable1.TALEPDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPDURUMIDNull() => this[this.tableDataTable1.TALEPDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPIPTALACIKLAMANull() => this.IsNull(this.tableDataTable1.TALEPIPTALACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPIPTALACIKLAMANull() => this[this.tableDataTable1.TALEPIPTALACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPEDENUSTAIDNull() => this.IsNull(this.tableDataTable1.TALEPEDENUSTAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPEDENUSTAIDNull() => this[this.tableDataTable1.TALEPEDENUSTAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsATOLYESEFIDNull() => this.IsNull(this.tableDataTable1.ATOLYESEFIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetATOLYESEFIDNull() => this[this.tableDataTable1.ATOLYESEFIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEPOYETKILIIDNull() => this.IsNull(this.tableDataTable1.DEPOYETKILIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEPOYETKILIIDNull() => this[this.tableDataTable1.DEPOYETKILIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMUDURIDNull() => this.IsNull(this.tableDataTable1.MUDURIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMUDURIDNull() => this[this.tableDataTable1.MUDURIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMUDONAYZAMANNull() => this.IsNull(this.tableDataTable1.MUDONAYZAMANColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMUDONAYZAMANNull() => this[this.tableDataTable1.MUDONAYZAMANColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPKAYITIDNull() => this.IsNull(this.tableDataTable1.TALEPKAYITIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPKAYITIDNull() => this[this.tableDataTable1.TALEPKAYITIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEUSERNull() => this.IsNull(this.tableDataTable1.SAVEUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEUSERNull() => this[this.tableDataTable1.SAVEUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEDATENull() => this.IsNull(this.tableDataTable1.SAVEDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEDATENull() => this[this.tableDataTable1.SAVEDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITUSERNull() => this.IsNull(this.tableDataTable1.EDITUSERColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITUSERNull() => this[this.tableDataTable1.EDITUSERColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITDATENull() => this.IsNull(this.tableDataTable1.EDITDATEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITDATENull() => this[this.tableDataTable1.EDITDATEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEMACNull() => this.IsNull(this.tableDataTable1.SAVEMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEMACNull() => this[this.tableDataTable1.SAVEMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITMACNull() => this.IsNull(this.tableDataTable1.EDITMACColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITMACNull() => this[this.tableDataTable1.EDITMACColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAVEIPNull() => this.IsNull(this.tableDataTable1.SAVEIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAVEIPNull() => this[this.tableDataTable1.SAVEIPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsEDITIPNull() => this.IsNull(this.tableDataTable1.EDITIPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetEDITIPNull() => this[this.tableDataTable1.EDITIPColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private CikisFisicinGirisfislistesi.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(
        CikisFisicinGirisfislistesi.DataTable1Row row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public CikisFisicinGirisfislistesi.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
