// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AracTrafikCeza
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

namespace Makina_Ikmal.Model
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("AracTrafikCeza")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AracTrafikCeza : DataSet
  {
    private AracTrafikCeza.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AracTrafikCeza()
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
    protected AracTrafikCeza(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new AracTrafikCeza.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public AracTrafikCeza.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      AracTrafikCeza aracTrafikCeza = (AracTrafikCeza) base.Clone();
      aracTrafikCeza.InitVars();
      aracTrafikCeza.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) aracTrafikCeza;
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
          base.Tables.Add((DataTable) new AracTrafikCeza.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (AracTrafikCeza.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AracTrafikCeza);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AracTrafikCeza.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new AracTrafikCeza.DataTable1DataTable();
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
      AracTrafikCeza aracTrafikCeza = new AracTrafikCeza();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = aracTrafikCeza.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = aracTrafikCeza.GetSchemaSerializable();
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
      AracTrafikCeza.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<AracTrafikCeza.DataTable1Row>
    {
      private DataColumn columnID;
      private DataColumn columnODEMEDURUM;
      private DataColumn columnKAYITTARIHI;
      private DataColumn columnPLAKA;
      private DataColumn columnFISNO;
      private DataColumn columnCEZATARIHI;
      private DataColumn columnCEZASAATI;
      private DataColumn columnCEZATUTARI;
      private DataColumn columnILGILINOT;
      private DataColumn columnADISOYADI;
      private DataColumn columnCEPTELEFON;
      private DataColumn columnCEZAACIKLAMA;
      private DataColumn columnARACDURUMID;
      private DataColumn columnARACTIPIID;

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
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ODEMEDURUMColumn => this.columnODEMEDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KAYITTARIHIColumn => this.columnKAYITTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FISNOColumn => this.columnFISNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEZATARIHIColumn => this.columnCEZATARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEZASAATIColumn => this.columnCEZASAATI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEZATUTARIColumn => this.columnCEZATUTARI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ILGILINOTColumn => this.columnILGILINOT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEPTELEFONColumn => this.columnCEPTELEFON;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEZAACIKLAMAColumn => this.columnCEZAACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACDURUMIDColumn => this.columnARACDURUMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACTIPIIDColumn => this.columnARACTIPIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracTrafikCeza.DataTable1Row this[int index] => (AracTrafikCeza.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracTrafikCeza.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracTrafikCeza.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracTrafikCeza.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AracTrafikCeza.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(AracTrafikCeza.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracTrafikCeza.DataTable1Row AddDataTable1Row(
        string ODEMEDURUM,
        DateTime KAYITTARIHI,
        string PLAKA,
        string FISNO,
        DateTime CEZATARIHI,
        DateTime CEZASAATI,
        Decimal CEZATUTARI,
        string ILGILINOT,
        string ADISOYADI,
        string CEPTELEFON,
        string CEZAACIKLAMA,
        int ARACDURUMID,
        int ARACTIPIID)
      {
        AracTrafikCeza.DataTable1Row row = (AracTrafikCeza.DataTable1Row) this.NewRow();
        object[] objArray = new object[14]
        {
          null,
          (object) ODEMEDURUM,
          (object) KAYITTARIHI,
          (object) PLAKA,
          (object) FISNO,
          (object) CEZATARIHI,
          (object) CEZASAATI,
          (object) CEZATUTARI,
          (object) ILGILINOT,
          (object) ADISOYADI,
          (object) CEPTELEFON,
          (object) CEZAACIKLAMA,
          (object) ARACDURUMID,
          (object) ARACTIPIID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracTrafikCeza.DataTable1Row FindByID(int ID) => (AracTrafikCeza.DataTable1Row) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AracTrafikCeza.DataTable1DataTable dataTable1DataTable = (AracTrafikCeza.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AracTrafikCeza.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnODEMEDURUM = this.Columns["ODEMEDURUM"];
        this.columnKAYITTARIHI = this.Columns["KAYITTARIHI"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnFISNO = this.Columns["FISNO"];
        this.columnCEZATARIHI = this.Columns["CEZATARIHI"];
        this.columnCEZASAATI = this.Columns["CEZASAATI"];
        this.columnCEZATUTARI = this.Columns["CEZATUTARI"];
        this.columnILGILINOT = this.Columns["ILGILINOT"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnCEPTELEFON = this.Columns["CEPTELEFON"];
        this.columnCEZAACIKLAMA = this.Columns["CEZAACIKLAMA"];
        this.columnARACDURUMID = this.Columns["ARACDURUMID"];
        this.columnARACTIPIID = this.Columns["ARACTIPIID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnODEMEDURUM = new DataColumn("ODEMEDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnODEMEDURUM);
        this.columnKAYITTARIHI = new DataColumn("KAYITTARIHI", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKAYITTARIHI);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnFISNO = new DataColumn("FISNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISNO);
        this.columnCEZATARIHI = new DataColumn("CEZATARIHI", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZATARIHI);
        this.columnCEZASAATI = new DataColumn("CEZASAATI", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZASAATI);
        this.columnCEZATUTARI = new DataColumn("CEZATUTARI", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZATUTARI);
        this.columnILGILINOT = new DataColumn("ILGILINOT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnILGILINOT);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnCEPTELEFON = new DataColumn("CEPTELEFON", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEPTELEFON);
        this.columnCEZAACIKLAMA = new DataColumn("CEZAACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZAACIKLAMA);
        this.columnARACDURUMID = new DataColumn("ARACDURUMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACDURUMID);
        this.columnARACTIPIID = new DataColumn("ARACTIPIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACTIPIID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnODEMEDURUM.MaxLength = 50;
        this.columnPLAKA.MaxLength = 50;
        this.columnFISNO.MaxLength = 50;
        this.columnILGILINOT.MaxLength = 250;
        this.columnADISOYADI.MaxLength = 100;
        this.columnCEPTELEFON.MaxLength = 50;
        this.columnCEZAACIKLAMA.MaxLength = 250;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracTrafikCeza.DataTable1Row NewDataTable1Row() => (AracTrafikCeza.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AracTrafikCeza.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AracTrafikCeza.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new AracTrafikCeza.DataTable1RowChangeEvent((AracTrafikCeza.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new AracTrafikCeza.DataTable1RowChangeEvent((AracTrafikCeza.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new AracTrafikCeza.DataTable1RowChangeEvent((AracTrafikCeza.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new AracTrafikCeza.DataTable1RowChangeEvent((AracTrafikCeza.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(AracTrafikCeza.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AracTrafikCeza aracTrafikCeza = new AracTrafikCeza();
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
          FixedValue = aracTrafikCeza.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = aracTrafikCeza.GetSchemaSerializable();
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
      private AracTrafikCeza.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (AracTrafikCeza.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableDataTable1.IDColumn];
        set => this[this.tableDataTable1.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ODEMEDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ODEMEDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ODEMEDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ODEMEDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime KAYITTARIHI
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.KAYITTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'KAYITTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.KAYITTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FISNO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.FISNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FISNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FISNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CEZATARIHI
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.CEZATARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CEZATARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CEZATARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DateTime CEZASAATI
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableDataTable1.CEZASAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CEZASAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CEZASAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal CEZATUTARI
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.CEZATUTARIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CEZATUTARI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CEZATUTARIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ILGILINOT
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ILGILINOTColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ILGILINOT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ILGILINOTColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEPTELEFON
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CEPTELEFONColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CEPTELEFON' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CEPTELEFONColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEZAACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CEZAACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CEZAACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CEZAACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACDURUMID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ARACDURUMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACDURUMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACDURUMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACTIPIID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.ARACTIPIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACTIPIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACTIPIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsODEMEDURUMNull() => this.IsNull(this.tableDataTable1.ODEMEDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetODEMEDURUMNull() => this[this.tableDataTable1.ODEMEDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKAYITTARIHINull() => this.IsNull(this.tableDataTable1.KAYITTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKAYITTARIHINull() => this[this.tableDataTable1.KAYITTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable1.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable1.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISNONull() => this.IsNull(this.tableDataTable1.FISNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISNONull() => this[this.tableDataTable1.FISNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZATARIHINull() => this.IsNull(this.tableDataTable1.CEZATARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZATARIHINull() => this[this.tableDataTable1.CEZATARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZASAATINull() => this.IsNull(this.tableDataTable1.CEZASAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZASAATINull() => this[this.tableDataTable1.CEZASAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZATUTARINull() => this.IsNull(this.tableDataTable1.CEZATUTARIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZATUTARINull() => this[this.tableDataTable1.CEZATUTARIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsILGILINOTNull() => this.IsNull(this.tableDataTable1.ILGILINOTColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetILGILINOTNull() => this[this.tableDataTable1.ILGILINOTColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableDataTable1.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableDataTable1.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEPTELEFONNull() => this.IsNull(this.tableDataTable1.CEPTELEFONColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEPTELEFONNull() => this[this.tableDataTable1.CEPTELEFONColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZAACIKLAMANull() => this.IsNull(this.tableDataTable1.CEZAACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZAACIKLAMANull() => this[this.tableDataTable1.CEZAACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACDURUMIDNull() => this.IsNull(this.tableDataTable1.ARACDURUMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACDURUMIDNull() => this[this.tableDataTable1.ARACDURUMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACTIPIIDNull() => this.IsNull(this.tableDataTable1.ARACTIPIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACTIPIIDNull() => this[this.tableDataTable1.ARACTIPIIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private AracTrafikCeza.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(AracTrafikCeza.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AracTrafikCeza.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
