// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.AKemalModel.GirisFisTalepFisEkleme
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

namespace Makina_Ikmal.AKemalModel
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("GirisFisTalepFisEkleme")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class GirisFisTalepFisEkleme : DataSet
  {
    private GirisFisTalepFisEkleme.girisfisDataTable tablegirisfis;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public GirisFisTalepFisEkleme()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected GirisFisTalepFisEkleme(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (girisfis)] != null)
            base.Tables.Add((DataTable) new GirisFisTalepFisEkleme.girisfisDataTable(dataSet.Tables[nameof (girisfis)]));
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public GirisFisTalepFisEkleme.girisfisDataTable girisfis => this.tablegirisfis;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataSet Clone()
    {
      GirisFisTalepFisEkleme fisTalepFisEkleme = (GirisFisTalepFisEkleme) base.Clone();
      fisTalepFisEkleme.InitVars();
      fisTalepFisEkleme.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) fisTalepFisEkleme;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["girisfis"] != null)
          base.Tables.Add((DataTable) new GirisFisTalepFisEkleme.girisfisDataTable(dataSet.Tables["girisfis"]));
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tablegirisfis = (GirisFisTalepFisEkleme.girisfisDataTable) base.Tables["girisfis"];
      if (!initTable || this.tablegirisfis == null)
        return;
      this.tablegirisfis.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (GirisFisTalepFisEkleme);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/GirisFisTalepFisEkleme.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tablegirisfis = new GirisFisTalepFisEkleme.girisfisDataTable();
      base.Tables.Add((DataTable) this.tablegirisfis);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private bool ShouldSerializegirisfis() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      GirisFisTalepFisEkleme fisTalepFisEkleme = new GirisFisTalepFisEkleme();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = fisTalepFisEkleme.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = fisTalepFisEkleme.GetSchemaSerializable();
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public delegate void girisfisRowChangeEventHandler(
      object sender,
      GirisFisTalepFisEkleme.girisfisRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class girisfisDataTable : TypedTableBase<GirisFisTalepFisEkleme.girisfisRow>
    {
      private DataColumn columnKOD;
      private DataColumn columnExpr1;
      private DataColumn columnARACID;
      private DataColumn columnTARIH;
      private DataColumn columnGİRİŞ_FİŞ_KODU;
      private DataColumn columnGCKOD;
      private DataColumn columnExpr3;
      private DataColumn columnFISNO;
      private DataColumn columnFIRMAID;
      private DataColumn columnISLEMTIPIID;
      private DataColumn columnID;
      private DataColumn columnIMZADEPOYETKILIID;
      private DataColumn columnTOPTUTAR;
      private DataColumn columnTOPKDVTUTAR;
      private DataColumn columnFISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public girisfisDataTable()
      {
        this.TableName = "girisfis";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal girisfisDataTable(DataTable table)
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
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected girisfisDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn GİRİŞ_FİŞ_KODUColumn => this.columnGİRİŞ_FİŞ_KODU;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn GCKODColumn => this.columnGCKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn Expr3Column => this.columnExpr3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn FISNOColumn => this.columnFISNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn FIRMAIDColumn => this.columnFIRMAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn ISLEMTIPIIDColumn => this.columnISLEMTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn IMZADEPOYETKILIIDColumn => this.columnIMZADEPOYETKILIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn TOPTUTARColumn => this.columnTOPTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn TOPKDVTUTARColumn => this.columnTOPKDVTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn FISTUTARColumn => this.columnFISTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public GirisFisTalepFisEkleme.girisfisRow this[int index] => (GirisFisTalepFisEkleme.girisfisRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event GirisFisTalepFisEkleme.girisfisRowChangeEventHandler girisfisRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event GirisFisTalepFisEkleme.girisfisRowChangeEventHandler girisfisRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event GirisFisTalepFisEkleme.girisfisRowChangeEventHandler girisfisRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event GirisFisTalepFisEkleme.girisfisRowChangeEventHandler girisfisRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void AddgirisfisRow(GirisFisTalepFisEkleme.girisfisRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public GirisFisTalepFisEkleme.girisfisRow AddgirisfisRow(
        string KOD,
        string Expr1,
        int ARACID,
        DateTime TARIH,
        string GİRİŞ_FİŞ_KODU,
        string GCKOD,
        string FISNO,
        int FIRMAID,
        string ISLEMTIPIID,
        int IMZADEPOYETKILIID,
        double TOPTUTAR,
        double TOPKDVTUTAR,
        double FISTUTAR)
      {
        GirisFisTalepFisEkleme.girisfisRow row = (GirisFisTalepFisEkleme.girisfisRow) this.NewRow();
        object[] objArray = new object[15]
        {
          (object) KOD,
          (object) Expr1,
          (object) ARACID,
          (object) TARIH,
          (object) GİRİŞ_FİŞ_KODU,
          (object) GCKOD,
          null,
          (object) FISNO,
          (object) FIRMAID,
          (object) ISLEMTIPIID,
          null,
          (object) IMZADEPOYETKILIID,
          (object) TOPTUTAR,
          (object) TOPKDVTUTAR,
          (object) FISTUTAR
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public override DataTable Clone()
      {
        GirisFisTalepFisEkleme.girisfisDataTable girisfisDataTable = (GirisFisTalepFisEkleme.girisfisDataTable) base.Clone();
        girisfisDataTable.InitVars();
        return (DataTable) girisfisDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new GirisFisTalepFisEkleme.girisfisDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal void InitVars()
      {
        this.columnKOD = this.Columns["KOD"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnGİRİŞ_FİŞ_KODU = this.Columns["GİRİŞ FİŞ KODU"];
        this.columnGCKOD = this.Columns["GCKOD"];
        this.columnExpr3 = this.Columns["Expr3"];
        this.columnFISNO = this.Columns["FISNO"];
        this.columnFIRMAID = this.Columns["FIRMAID"];
        this.columnISLEMTIPIID = this.Columns["ISLEMTIPIID"];
        this.columnID = this.Columns["ID"];
        this.columnIMZADEPOYETKILIID = this.Columns["IMZADEPOYETKILIID"];
        this.columnTOPTUTAR = this.Columns["TOPTUTAR"];
        this.columnTOPKDVTUTAR = this.Columns["TOPKDVTUTAR"];
        this.columnFISTUTAR = this.Columns["FISTUTAR"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      private void InitClass()
      {
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnGİRİŞ_FİŞ_KODU = new DataColumn("GİRİŞ FİŞ KODU", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGİRİŞ_FİŞ_KODU);
        this.columnGCKOD = new DataColumn("GCKOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGCKOD);
        this.columnExpr3 = new DataColumn("Expr3", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr3);
        this.columnFISNO = new DataColumn("FISNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISNO);
        this.columnFIRMAID = new DataColumn("FIRMAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAID);
        this.columnISLEMTIPIID = new DataColumn("ISLEMTIPIID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPIID);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnIMZADEPOYETKILIID = new DataColumn("IMZADEPOYETKILIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIMZADEPOYETKILIID);
        this.columnTOPTUTAR = new DataColumn("TOPTUTAR", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPTUTAR);
        this.columnTOPKDVTUTAR = new DataColumn("TOPKDVTUTAR", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTOPKDVTUTAR);
        this.columnFISTUTAR = new DataColumn("FISTUTAR", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISTUTAR);
        this.columnKOD.MaxLength = 50;
        this.columnExpr1.MaxLength = 50;
        this.columnGİRİŞ_FİŞ_KODU.MaxLength = 50;
        this.columnGCKOD.MaxLength = 50;
        this.columnExpr3.AutoIncrement = true;
        this.columnExpr3.AutoIncrementSeed = -1L;
        this.columnExpr3.AutoIncrementStep = -1L;
        this.columnExpr3.AllowDBNull = false;
        this.columnExpr3.ReadOnly = true;
        this.columnFISNO.MaxLength = 50;
        this.columnISLEMTIPIID.MaxLength = 50;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public GirisFisTalepFisEkleme.girisfisRow NewgirisfisRow() => (GirisFisTalepFisEkleme.girisfisRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new GirisFisTalepFisEkleme.girisfisRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override Type GetRowType() => typeof (GirisFisTalepFisEkleme.girisfisRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.girisfisRowChanged == null)
          return;
        this.girisfisRowChanged((object) this, new GirisFisTalepFisEkleme.girisfisRowChangeEvent((GirisFisTalepFisEkleme.girisfisRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.girisfisRowChanging == null)
          return;
        this.girisfisRowChanging((object) this, new GirisFisTalepFisEkleme.girisfisRowChangeEvent((GirisFisTalepFisEkleme.girisfisRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.girisfisRowDeleted == null)
          return;
        this.girisfisRowDeleted((object) this, new GirisFisTalepFisEkleme.girisfisRowChangeEvent((GirisFisTalepFisEkleme.girisfisRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.girisfisRowDeleting == null)
          return;
        this.girisfisRowDeleting((object) this, new GirisFisTalepFisEkleme.girisfisRowChangeEvent((GirisFisTalepFisEkleme.girisfisRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void RemovegirisfisRow(GirisFisTalepFisEkleme.girisfisRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        GirisFisTalepFisEkleme fisTalepFisEkleme = new GirisFisTalepFisEkleme();
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
          FixedValue = fisTalepFisEkleme.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (girisfisDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = fisTalepFisEkleme.GetSchemaSerializable();
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

    public class girisfisRow : DataRow
    {
      private GirisFisTalepFisEkleme.girisfisDataTable tablegirisfis;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal girisfisRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tablegirisfis = (GirisFisTalepFisEkleme.girisfisDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tablegirisfis.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DateTime TARIH
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablegirisfis.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string GİRİŞ_FİŞ_KODU
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.GİRİŞ_FİŞ_KODUColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'GİRİŞ FİŞ KODU' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.GİRİŞ_FİŞ_KODUColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string GCKOD
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.GCKODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'GCKOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.GCKODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int Expr3
      {
        get => (int) this[this.tablegirisfis.Expr3Column];
        set => this[this.tablegirisfis.Expr3Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string FISNO
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.FISNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'FISNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.FISNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int FIRMAID
      {
        get
        {
          try
          {
            return (int) this[this.tablegirisfis.FIRMAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'FIRMAID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.FIRMAIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string ISLEMTIPIID
      {
        get
        {
          try
          {
            return (string) this[this.tablegirisfis.ISLEMTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'ISLEMTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.ISLEMTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int ID
      {
        get => (int) this[this.tablegirisfis.IDColumn];
        set => this[this.tablegirisfis.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int IMZADEPOYETKILIID
      {
        get
        {
          try
          {
            return (int) this[this.tablegirisfis.IMZADEPOYETKILIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'IMZADEPOYETKILIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.IMZADEPOYETKILIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public double TOPTUTAR
      {
        get
        {
          try
          {
            return (double) this[this.tablegirisfis.TOPTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'TOPTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.TOPTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public double TOPKDVTUTAR
      {
        get
        {
          try
          {
            return (double) this[this.tablegirisfis.TOPKDVTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'TOPKDVTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.TOPKDVTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public double FISTUTAR
      {
        get
        {
          try
          {
            return (double) this[this.tablegirisfis.FISTUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'girisfis' tablosundaki 'FISTUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tablegirisfis.FISTUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tablegirisfis.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetKODNull() => this[this.tablegirisfis.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tablegirisfis.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetExpr1Null() => this[this.tablegirisfis.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tablegirisfis.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetARACIDNull() => this[this.tablegirisfis.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tablegirisfis.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetTARIHNull() => this[this.tablegirisfis.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsGİRİŞ_FİŞ_KODUNull() => this.IsNull(this.tablegirisfis.GİRİŞ_FİŞ_KODUColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetGİRİŞ_FİŞ_KODUNull() => this[this.tablegirisfis.GİRİŞ_FİŞ_KODUColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsGCKODNull() => this.IsNull(this.tablegirisfis.GCKODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetGCKODNull() => this[this.tablegirisfis.GCKODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsFISNONull() => this.IsNull(this.tablegirisfis.FISNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetFISNONull() => this[this.tablegirisfis.FISNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsFIRMAIDNull() => this.IsNull(this.tablegirisfis.FIRMAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetFIRMAIDNull() => this[this.tablegirisfis.FIRMAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsISLEMTIPIIDNull() => this.IsNull(this.tablegirisfis.ISLEMTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetISLEMTIPIIDNull() => this[this.tablegirisfis.ISLEMTIPIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsIMZADEPOYETKILIIDNull() => this.IsNull(this.tablegirisfis.IMZADEPOYETKILIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetIMZADEPOYETKILIIDNull() => this[this.tablegirisfis.IMZADEPOYETKILIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsTOPTUTARNull() => this.IsNull(this.tablegirisfis.TOPTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetTOPTUTARNull() => this[this.tablegirisfis.TOPTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsTOPKDVTUTARNull() => this.IsNull(this.tablegirisfis.TOPKDVTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetTOPKDVTUTARNull() => this[this.tablegirisfis.TOPKDVTUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsFISTUTARNull() => this.IsNull(this.tablegirisfis.FISTUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetFISTUTARNull() => this[this.tablegirisfis.FISTUTARColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public class girisfisRowChangeEvent : EventArgs
    {
      private GirisFisTalepFisEkleme.girisfisRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public girisfisRowChangeEvent(GirisFisTalepFisEkleme.girisfisRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public GirisFisTalepFisEkleme.girisfisRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
