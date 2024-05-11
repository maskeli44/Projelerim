// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.DataSet1
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
  [XmlRoot("DataSet1")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class DataSet1 : DataSet
  {
    private DataSet1.TBLPERSIZINDURUMDataTable tableTBLPERSIZINDURUM;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataSet1()
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
    protected DataSet1(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLPERSIZINDURUM)] != null)
            base.Tables.Add((DataTable) new DataSet1.TBLPERSIZINDURUMDataTable(dataSet.Tables[nameof (TBLPERSIZINDURUM)]));
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
    public DataSet1.TBLPERSIZINDURUMDataTable TBLPERSIZINDURUM => this.tableTBLPERSIZINDURUM;

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
      DataSet1 dataSet1 = (DataSet1) base.Clone();
      dataSet1.InitVars();
      dataSet1.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dataSet1;
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
        if (dataSet.Tables["TBLPERSIZINDURUM"] != null)
          base.Tables.Add((DataTable) new DataSet1.TBLPERSIZINDURUMDataTable(dataSet.Tables["TBLPERSIZINDURUM"]));
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
      this.tableTBLPERSIZINDURUM = (DataSet1.TBLPERSIZINDURUMDataTable) base.Tables["TBLPERSIZINDURUM"];
      if (!initTable || this.tableTBLPERSIZINDURUM == null)
        return;
      this.tableTBLPERSIZINDURUM.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (DataSet1);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/DataSet1.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLPERSIZINDURUM = new DataSet1.TBLPERSIZINDURUMDataTable();
      base.Tables.Add((DataTable) this.tableTBLPERSIZINDURUM);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTBLPERSIZINDURUM() => false;

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
      DataSet1 dataSet1 = new DataSet1();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dataSet1.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
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
    public delegate void TBLPERSIZINDURUMRowChangeEventHandler(
      object sender,
      DataSet1.TBLPERSIZINDURUMRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLPERSIZINDURUMDataTable : TypedTableBase<DataSet1.TBLPERSIZINDURUMRow>
    {
      private DataColumn columnPERSONELID;
      private DataColumn columnIZINYILI;
      private DataColumn columnIZINHAKKI;
      private DataColumn columnKULLANILANIZIN;
      private DataColumn columnID;
      private DataColumn columnPERSONELIZINID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLPERSIZINDURUMDataTable()
      {
        this.TableName = "TBLPERSIZINDURUM";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLPERSIZINDURUMDataTable(DataTable table)
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
      protected TBLPERSIZINDURUMDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PERSONELIDColumn => this.columnPERSONELID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINYILIColumn => this.columnIZINYILI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IZINHAKKIColumn => this.columnIZINHAKKI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KULLANILANIZINColumn => this.columnKULLANILANIZIN;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PERSONELIZINIDColumn => this.columnPERSONELIZINID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataSet1.TBLPERSIZINDURUMRow this[int index] => (DataSet1.TBLPERSIZINDURUMRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event DataSet1.TBLPERSIZINDURUMRowChangeEventHandler TBLPERSIZINDURUMRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event DataSet1.TBLPERSIZINDURUMRowChangeEventHandler TBLPERSIZINDURUMRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event DataSet1.TBLPERSIZINDURUMRowChangeEventHandler TBLPERSIZINDURUMRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event DataSet1.TBLPERSIZINDURUMRowChangeEventHandler TBLPERSIZINDURUMRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTBLPERSIZINDURUMRow(DataSet1.TBLPERSIZINDURUMRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataSet1.TBLPERSIZINDURUMRow AddTBLPERSIZINDURUMRow(
        int PERSONELID,
        int IZINYILI,
        int IZINHAKKI,
        int KULLANILANIZIN,
        int PERSONELIZINID)
      {
        DataSet1.TBLPERSIZINDURUMRow row = (DataSet1.TBLPERSIZINDURUMRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) PERSONELID,
          (object) IZINYILI,
          (object) IZINHAKKI,
          (object) KULLANILANIZIN,
          null,
          (object) PERSONELIZINID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataSet1.TBLPERSIZINDURUMRow FindByID(int ID) => (DataSet1.TBLPERSIZINDURUMRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        DataSet1.TBLPERSIZINDURUMDataTable tblpersizindurumDataTable = (DataSet1.TBLPERSIZINDURUMDataTable) base.Clone();
        tblpersizindurumDataTable.InitVars();
        return (DataTable) tblpersizindurumDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new DataSet1.TBLPERSIZINDURUMDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnPERSONELID = this.Columns["PERSONELID"];
        this.columnIZINYILI = this.Columns["IZINYILI"];
        this.columnIZINHAKKI = this.Columns["IZINHAKKI"];
        this.columnKULLANILANIZIN = this.Columns["KULLANILANIZIN"];
        this.columnID = this.Columns["ID"];
        this.columnPERSONELIZINID = this.Columns["PERSONELIZINID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnPERSONELID = new DataColumn("PERSONELID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPERSONELID);
        this.columnIZINYILI = new DataColumn("IZINYILI", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINYILI);
        this.columnIZINHAKKI = new DataColumn("IZINHAKKI", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIZINHAKKI);
        this.columnKULLANILANIZIN = new DataColumn("KULLANILANIZIN", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKULLANILANIZIN);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnPERSONELIZINID = new DataColumn("PERSONELIZINID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPERSONELIZINID);
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
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataSet1.TBLPERSIZINDURUMRow NewTBLPERSIZINDURUMRow() => (DataSet1.TBLPERSIZINDURUMRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new DataSet1.TBLPERSIZINDURUMRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (DataSet1.TBLPERSIZINDURUMRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLPERSIZINDURUMRowChanged == null)
          return;
        this.TBLPERSIZINDURUMRowChanged((object) this, new DataSet1.TBLPERSIZINDURUMRowChangeEvent((DataSet1.TBLPERSIZINDURUMRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLPERSIZINDURUMRowChanging == null)
          return;
        this.TBLPERSIZINDURUMRowChanging((object) this, new DataSet1.TBLPERSIZINDURUMRowChangeEvent((DataSet1.TBLPERSIZINDURUMRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLPERSIZINDURUMRowDeleted == null)
          return;
        this.TBLPERSIZINDURUMRowDeleted((object) this, new DataSet1.TBLPERSIZINDURUMRowChangeEvent((DataSet1.TBLPERSIZINDURUMRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLPERSIZINDURUMRowDeleting == null)
          return;
        this.TBLPERSIZINDURUMRowDeleting((object) this, new DataSet1.TBLPERSIZINDURUMRowChangeEvent((DataSet1.TBLPERSIZINDURUMRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTBLPERSIZINDURUMRow(DataSet1.TBLPERSIZINDURUMRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        DataSet1 dataSet1 = new DataSet1();
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
          FixedValue = dataSet1.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLPERSIZINDURUMDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dataSet1.GetSchemaSerializable();
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

    public class TBLPERSIZINDURUMRow : DataRow
    {
      private DataSet1.TBLPERSIZINDURUMDataTable tableTBLPERSIZINDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TBLPERSIZINDURUMRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLPERSIZINDURUM = (DataSet1.TBLPERSIZINDURUMDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int PERSONELID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSIZINDURUM.PERSONELIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSIZINDURUM' tablosundaki 'PERSONELID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSIZINDURUM.PERSONELIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IZINYILI
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSIZINDURUM.IZINYILIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSIZINDURUM' tablosundaki 'IZINYILI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSIZINDURUM.IZINYILIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int IZINHAKKI
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSIZINDURUM.IZINHAKKIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSIZINDURUM' tablosundaki 'IZINHAKKI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSIZINDURUM.IZINHAKKIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int KULLANILANIZIN
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSIZINDURUM.KULLANILANIZINColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSIZINDURUM' tablosundaki 'KULLANILANIZIN' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSIZINDURUM.KULLANILANIZINColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLPERSIZINDURUM.IDColumn];
        set => this[this.tableTBLPERSIZINDURUM.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int PERSONELIZINID
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLPERSIZINDURUM.PERSONELIZINIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLPERSIZINDURUM' tablosundaki 'PERSONELIZINID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLPERSIZINDURUM.PERSONELIZINIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPERSONELIDNull() => this.IsNull(this.tableTBLPERSIZINDURUM.PERSONELIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPERSONELIDNull() => this[this.tableTBLPERSIZINDURUM.PERSONELIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINYILINull() => this.IsNull(this.tableTBLPERSIZINDURUM.IZINYILIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINYILINull() => this[this.tableTBLPERSIZINDURUM.IZINYILIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIZINHAKKINull() => this.IsNull(this.tableTBLPERSIZINDURUM.IZINHAKKIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIZINHAKKINull() => this[this.tableTBLPERSIZINDURUM.IZINHAKKIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKULLANILANIZINNull() => this.IsNull(this.tableTBLPERSIZINDURUM.KULLANILANIZINColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKULLANILANIZINNull() => this[this.tableTBLPERSIZINDURUM.KULLANILANIZINColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPERSONELIZINIDNull() => this.IsNull(this.tableTBLPERSIZINDURUM.PERSONELIZINIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPERSONELIZINIDNull() => this[this.tableTBLPERSIZINDURUM.PERSONELIZINIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TBLPERSIZINDURUMRowChangeEvent : EventArgs
    {
      private DataSet1.TBLPERSIZINDURUMRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TBLPERSIZINDURUMRowChangeEvent(DataSet1.TBLPERSIZINDURUMRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataSet1.TBLPERSIZINDURUMRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
