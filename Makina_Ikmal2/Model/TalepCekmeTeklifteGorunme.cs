// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TalepCekmeTeklifteGorunme
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
  [XmlRoot("TalepCekmeTeklifteGorunme")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class TalepCekmeTeklifteGorunme : DataSet
  {
    private TalepCekmeTeklifteGorunme.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TalepCekmeTeklifteGorunme()
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
    protected TalepCekmeTeklifteGorunme(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new TalepCekmeTeklifteGorunme.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public TalepCekmeTeklifteGorunme.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      TalepCekmeTeklifteGorunme cekmeTeklifteGorunme = (TalepCekmeTeklifteGorunme) base.Clone();
      cekmeTeklifteGorunme.InitVars();
      cekmeTeklifteGorunme.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) cekmeTeklifteGorunme;
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
          base.Tables.Add((DataTable) new TalepCekmeTeklifteGorunme.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (TalepCekmeTeklifteGorunme.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (TalepCekmeTeklifteGorunme);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/TalepCekmeTeklifteGorunme.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new TalepCekmeTeklifteGorunme.DataTable1DataTable();
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
      TalepCekmeTeklifteGorunme cekmeTeklifteGorunme = new TalepCekmeTeklifteGorunme();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = cekmeTeklifteGorunme.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = cekmeTeklifteGorunme.GetSchemaSerializable();
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
      TalepCekmeTeklifteGorunme.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<TalepCekmeTeklifteGorunme.DataTable1Row>
    {
      private DataColumn columnARACID;
      private DataColumn columnMARKA;
      private DataColumn columnBIRIMFIYAT;
      private DataColumn columnBIRIMID;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnFIRMA1ID;
      private DataColumn columnF1BIRIMFIYAT;
      private DataColumn columnF1TUTAR;
      private DataColumn columnFIRMA2ID;
      private DataColumn columnF2BIRIMFIYAT;
      private DataColumn columnF2TUTAR;
      private DataColumn columnFIRMA3ID;
      private DataColumn columnF3BIRIMFIYAT;
      private DataColumn columnF3TUTAR;
      private DataColumn columnFIRMA4ID;
      private DataColumn columnF4BIRIMFIYAT;
      private DataColumn columnF4TUTAR;
      private DataColumn columnFIRMA5ID;
      private DataColumn columnF5BIRIMFIYAT;
      private DataColumn columnF5TUTAR;
      private DataColumn columnFIRMA6ID;
      private DataColumn columnF6BIRIMFIYAT;
      private DataColumn columnF6TUTAR;
      private DataColumn columnFIRMA7ID;
      private DataColumn columnF7BIRIMFIYAT;
      private DataColumn columnF7TUTAR;
      private DataColumn columnFIRMA8ID;
      private DataColumn columnF8BIRIMFIYAT;
      private DataColumn columnF8TUTAR;
      private DataColumn columnMALZEMEID;
      private DataColumn columnTalepID;
      private DataColumn columnMALZACIKLAMA;
      private DataColumn columnMIKTAR;
      private DataColumn columnTUTAR;
      private DataColumn columnMARKA1;
      private DataColumn columnMALZEMEID1;
      private DataColumn columnHRKTID;

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
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MARKAColumn => this.columnMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMFIYATColumn => this.columnBIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA1IDColumn => this.columnFIRMA1ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F1BIRIMFIYATColumn => this.columnF1BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F1TUTARColumn => this.columnF1TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA2IDColumn => this.columnFIRMA2ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F2BIRIMFIYATColumn => this.columnF2BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F2TUTARColumn => this.columnF2TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA3IDColumn => this.columnFIRMA3ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F3BIRIMFIYATColumn => this.columnF3BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F3TUTARColumn => this.columnF3TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA4IDColumn => this.columnFIRMA4ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F4BIRIMFIYATColumn => this.columnF4BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F4TUTARColumn => this.columnF4TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA5IDColumn => this.columnFIRMA5ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F5BIRIMFIYATColumn => this.columnF5BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F5TUTARColumn => this.columnF5TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA6IDColumn => this.columnFIRMA6ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F6BIRIMFIYATColumn => this.columnF6BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F6TUTARColumn => this.columnF6TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA7IDColumn => this.columnFIRMA7ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F7BIRIMFIYATColumn => this.columnF7BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F7TUTARColumn => this.columnF7TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMA8IDColumn => this.columnFIRMA8ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F8BIRIMFIYATColumn => this.columnF8BIRIMFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn F8TUTARColumn => this.columnF8TUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEIDColumn => this.columnMALZEMEID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TalepIDColumn => this.columnTalepID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZACIKLAMAColumn => this.columnMALZACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TUTARColumn => this.columnTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MARKA1Column => this.columnMARKA1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEID1Column => this.columnMALZEMEID1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn HRKTIDColumn => this.columnHRKTID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepCekmeTeklifteGorunme.DataTable1Row this[int index] => (TalepCekmeTeklifteGorunme.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepCekmeTeklifteGorunme.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepCekmeTeklifteGorunme.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepCekmeTeklifteGorunme.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepCekmeTeklifteGorunme.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(TalepCekmeTeklifteGorunme.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepCekmeTeklifteGorunme.DataTable1Row AddDataTable1Row(
        int ARACID,
        int MARKA,
        Decimal BIRIMFIYAT,
        int BIRIMID,
        string MALZEMEADI,
        int FIRMA1ID,
        Decimal F1BIRIMFIYAT,
        Decimal F1TUTAR,
        int FIRMA2ID,
        Decimal F2BIRIMFIYAT,
        Decimal F2TUTAR,
        int FIRMA3ID,
        Decimal F3BIRIMFIYAT,
        Decimal F3TUTAR,
        int FIRMA4ID,
        Decimal F4BIRIMFIYAT,
        Decimal F4TUTAR,
        int FIRMA5ID,
        Decimal F5BIRIMFIYAT,
        Decimal F5TUTAR,
        int FIRMA6ID,
        Decimal F6BIRIMFIYAT,
        Decimal F6TUTAR,
        int FIRMA7ID,
        Decimal F7BIRIMFIYAT,
        Decimal F7TUTAR,
        int FIRMA8ID,
        Decimal F8BIRIMFIYAT,
        Decimal F8TUTAR,
        string MALZEMEID,
        string MALZACIKLAMA,
        Decimal MIKTAR,
        Decimal TUTAR,
        Decimal MARKA1,
        int MALZEMEID1)
      {
        TalepCekmeTeklifteGorunme.DataTable1Row row = (TalepCekmeTeklifteGorunme.DataTable1Row) this.NewRow();
        object[] objArray = new object[37]
        {
          (object) ARACID,
          (object) MARKA,
          (object) BIRIMFIYAT,
          (object) BIRIMID,
          (object) MALZEMEADI,
          (object) FIRMA1ID,
          (object) F1BIRIMFIYAT,
          (object) F1TUTAR,
          (object) FIRMA2ID,
          (object) F2BIRIMFIYAT,
          (object) F2TUTAR,
          (object) FIRMA3ID,
          (object) F3BIRIMFIYAT,
          (object) F3TUTAR,
          (object) FIRMA4ID,
          (object) F4BIRIMFIYAT,
          (object) F4TUTAR,
          (object) FIRMA5ID,
          (object) F5BIRIMFIYAT,
          (object) F5TUTAR,
          (object) FIRMA6ID,
          (object) F6BIRIMFIYAT,
          (object) F6TUTAR,
          (object) FIRMA7ID,
          (object) F7BIRIMFIYAT,
          (object) F7TUTAR,
          (object) FIRMA8ID,
          (object) F8BIRIMFIYAT,
          (object) F8TUTAR,
          (object) MALZEMEID,
          null,
          (object) MALZACIKLAMA,
          (object) MIKTAR,
          (object) TUTAR,
          (object) MARKA1,
          (object) MALZEMEID1,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        TalepCekmeTeklifteGorunme.DataTable1DataTable dataTable1DataTable = (TalepCekmeTeklifteGorunme.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepCekmeTeklifteGorunme.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnARACID = this.Columns["ARACID"];
        this.columnMARKA = this.Columns["MARKA"];
        this.columnBIRIMFIYAT = this.Columns["BIRIMFIYAT"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnFIRMA1ID = this.Columns["FIRMA1ID"];
        this.columnF1BIRIMFIYAT = this.Columns["F1BIRIMFIYAT"];
        this.columnF1TUTAR = this.Columns["F1TUTAR"];
        this.columnFIRMA2ID = this.Columns["FIRMA2ID"];
        this.columnF2BIRIMFIYAT = this.Columns["F2BIRIMFIYAT"];
        this.columnF2TUTAR = this.Columns["F2TUTAR"];
        this.columnFIRMA3ID = this.Columns["FIRMA3ID"];
        this.columnF3BIRIMFIYAT = this.Columns["F3BIRIMFIYAT"];
        this.columnF3TUTAR = this.Columns["F3TUTAR"];
        this.columnFIRMA4ID = this.Columns["FIRMA4ID"];
        this.columnF4BIRIMFIYAT = this.Columns["F4BIRIMFIYAT"];
        this.columnF4TUTAR = this.Columns["F4TUTAR"];
        this.columnFIRMA5ID = this.Columns["FIRMA5ID"];
        this.columnF5BIRIMFIYAT = this.Columns["F5BIRIMFIYAT"];
        this.columnF5TUTAR = this.Columns["F5TUTAR"];
        this.columnFIRMA6ID = this.Columns["FIRMA6ID"];
        this.columnF6BIRIMFIYAT = this.Columns["F6BIRIMFIYAT"];
        this.columnF6TUTAR = this.Columns["F6TUTAR"];
        this.columnFIRMA7ID = this.Columns["FIRMA7ID"];
        this.columnF7BIRIMFIYAT = this.Columns["F7BIRIMFIYAT"];
        this.columnF7TUTAR = this.Columns["F7TUTAR"];
        this.columnFIRMA8ID = this.Columns["FIRMA8ID"];
        this.columnF8BIRIMFIYAT = this.Columns["F8BIRIMFIYAT"];
        this.columnF8TUTAR = this.Columns["F8TUTAR"];
        this.columnMALZEMEID = this.Columns["MALZEMEID"];
        this.columnTalepID = this.Columns["TalepID"];
        this.columnMALZACIKLAMA = this.Columns["MALZACIKLAMA"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnTUTAR = this.Columns["TUTAR"];
        this.columnMARKA1 = this.Columns["MARKA1"];
        this.columnMALZEMEID1 = this.Columns["MALZEMEID1"];
        this.columnHRKTID = this.Columns["HRKTID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnMARKA = new DataColumn("MARKA", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMARKA);
        this.columnBIRIMFIYAT = new DataColumn("BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMFIYAT);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnFIRMA1ID = new DataColumn("FIRMA1ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA1ID);
        this.columnF1BIRIMFIYAT = new DataColumn("F1BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF1BIRIMFIYAT);
        this.columnF1TUTAR = new DataColumn("F1TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF1TUTAR);
        this.columnFIRMA2ID = new DataColumn("FIRMA2ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA2ID);
        this.columnF2BIRIMFIYAT = new DataColumn("F2BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF2BIRIMFIYAT);
        this.columnF2TUTAR = new DataColumn("F2TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF2TUTAR);
        this.columnFIRMA3ID = new DataColumn("FIRMA3ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA3ID);
        this.columnF3BIRIMFIYAT = new DataColumn("F3BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF3BIRIMFIYAT);
        this.columnF3TUTAR = new DataColumn("F3TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF3TUTAR);
        this.columnFIRMA4ID = new DataColumn("FIRMA4ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA4ID);
        this.columnF4BIRIMFIYAT = new DataColumn("F4BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF4BIRIMFIYAT);
        this.columnF4TUTAR = new DataColumn("F4TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF4TUTAR);
        this.columnFIRMA5ID = new DataColumn("FIRMA5ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA5ID);
        this.columnF5BIRIMFIYAT = new DataColumn("F5BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF5BIRIMFIYAT);
        this.columnF5TUTAR = new DataColumn("F5TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF5TUTAR);
        this.columnFIRMA6ID = new DataColumn("FIRMA6ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA6ID);
        this.columnF6BIRIMFIYAT = new DataColumn("F6BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF6BIRIMFIYAT);
        this.columnF6TUTAR = new DataColumn("F6TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF6TUTAR);
        this.columnFIRMA7ID = new DataColumn("FIRMA7ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA7ID);
        this.columnF7BIRIMFIYAT = new DataColumn("F7BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF7BIRIMFIYAT);
        this.columnF7TUTAR = new DataColumn("F7TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF7TUTAR);
        this.columnFIRMA8ID = new DataColumn("FIRMA8ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMA8ID);
        this.columnF8BIRIMFIYAT = new DataColumn("F8BIRIMFIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF8BIRIMFIYAT);
        this.columnF8TUTAR = new DataColumn("F8TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnF8TUTAR);
        this.columnMALZEMEID = new DataColumn("MALZEMEID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEID);
        this.columnTalepID = new DataColumn("TalepID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTalepID);
        this.columnMALZACIKLAMA = new DataColumn("MALZACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZACIKLAMA);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnTUTAR = new DataColumn("TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTUTAR);
        this.columnMARKA1 = new DataColumn("MARKA1", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMARKA1);
        this.columnMALZEMEID1 = new DataColumn("MALZEMEID1", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEID1);
        this.columnHRKTID = new DataColumn("HRKTID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnHRKTID);
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMALZEMEID.MaxLength = 50;
        this.columnTalepID.AutoIncrement = true;
        this.columnTalepID.AutoIncrementSeed = -1L;
        this.columnTalepID.AutoIncrementStep = -1L;
        this.columnTalepID.AllowDBNull = false;
        this.columnTalepID.ReadOnly = true;
        this.columnMALZACIKLAMA.MaxLength = 100;
        this.columnMARKA1.Caption = "MARKA";
        this.columnMALZEMEID1.Caption = "MALZEMEID";
        this.columnHRKTID.AutoIncrement = true;
        this.columnHRKTID.AutoIncrementSeed = -1L;
        this.columnHRKTID.AutoIncrementStep = -1L;
        this.columnHRKTID.AllowDBNull = false;
        this.columnHRKTID.ReadOnly = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepCekmeTeklifteGorunme.DataTable1Row NewDataTable1Row() => (TalepCekmeTeklifteGorunme.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepCekmeTeklifteGorunme.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (TalepCekmeTeklifteGorunme.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new TalepCekmeTeklifteGorunme.DataTable1RowChangeEvent((TalepCekmeTeklifteGorunme.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new TalepCekmeTeklifteGorunme.DataTable1RowChangeEvent((TalepCekmeTeklifteGorunme.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new TalepCekmeTeklifteGorunme.DataTable1RowChangeEvent((TalepCekmeTeklifteGorunme.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new TalepCekmeTeklifteGorunme.DataTable1RowChangeEvent((TalepCekmeTeklifteGorunme.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(TalepCekmeTeklifteGorunme.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepCekmeTeklifteGorunme cekmeTeklifteGorunme = new TalepCekmeTeklifteGorunme();
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
          FixedValue = cekmeTeklifteGorunme.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = cekmeTeklifteGorunme.GetSchemaSerializable();
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
      private TalepCekmeTeklifteGorunme.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (TalepCekmeTeklifteGorunme.DataTable1DataTable) this.Table;
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
      public int MARKA
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.BIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA1ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA1IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA1ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA1IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F1BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F1BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F1BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F1BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F1TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F1TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F1TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F1TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA2ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA2IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA2ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA2IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F2BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F2BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F2BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F2BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F2TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F2TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F2TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F2TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA3ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA3IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA3ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA3IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F3BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F3BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F3BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F3BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F3TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F3TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F3TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F3TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA4ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA4IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA4ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA4IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F4BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F4BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F4BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F4BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F4TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F4TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F4TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F4TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA5ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA5IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA5ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA5IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F5BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F5BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F5BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F5BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F5TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F5TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F5TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F5TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA6ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA6IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA6ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA6IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F6BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F6BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F6BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F6BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F6TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F6TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F6TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F6TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA7ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA7IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA7ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA7IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F7BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F7BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F7BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F7BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F7TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F7TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F7TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F7TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int FIRMA8ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.FIRMA8IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMA8ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMA8IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F8BIRIMFIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F8BIRIMFIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F8BIRIMFIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F8BIRIMFIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal F8TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.F8TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'F8TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.F8TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEID
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZEMEIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TalepID
      {
        get => (int) this[this.tableDataTable1.TalepIDColumn];
        set => this[this.tableDataTable1.TalepIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MARKA1
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.MARKA1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MARKA1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MARKA1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MALZEMEID1
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MALZEMEID1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MALZEMEID1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZEMEID1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int HRKTID
      {
        get => (int) this[this.tableDataTable1.HRKTIDColumn];
        set => this[this.tableDataTable1.HRKTIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableDataTable1.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableDataTable1.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMARKANull() => this.IsNull(this.tableDataTable1.MARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMARKANull() => this[this.tableDataTable1.MARKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMFIYATNull() => this.IsNull(this.tableDataTable1.BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMFIYATNull() => this[this.tableDataTable1.BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableDataTable1.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableDataTable1.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableDataTable1.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableDataTable1.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA1IDNull() => this.IsNull(this.tableDataTable1.FIRMA1IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA1IDNull() => this[this.tableDataTable1.FIRMA1IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF1BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F1BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF1BIRIMFIYATNull() => this[this.tableDataTable1.F1BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF1TUTARNull() => this.IsNull(this.tableDataTable1.F1TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF1TUTARNull() => this[this.tableDataTable1.F1TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA2IDNull() => this.IsNull(this.tableDataTable1.FIRMA2IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA2IDNull() => this[this.tableDataTable1.FIRMA2IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF2BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F2BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF2BIRIMFIYATNull() => this[this.tableDataTable1.F2BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF2TUTARNull() => this.IsNull(this.tableDataTable1.F2TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF2TUTARNull() => this[this.tableDataTable1.F2TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA3IDNull() => this.IsNull(this.tableDataTable1.FIRMA3IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA3IDNull() => this[this.tableDataTable1.FIRMA3IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF3BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F3BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF3BIRIMFIYATNull() => this[this.tableDataTable1.F3BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF3TUTARNull() => this.IsNull(this.tableDataTable1.F3TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF3TUTARNull() => this[this.tableDataTable1.F3TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA4IDNull() => this.IsNull(this.tableDataTable1.FIRMA4IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA4IDNull() => this[this.tableDataTable1.FIRMA4IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF4BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F4BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF4BIRIMFIYATNull() => this[this.tableDataTable1.F4BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF4TUTARNull() => this.IsNull(this.tableDataTable1.F4TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF4TUTARNull() => this[this.tableDataTable1.F4TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA5IDNull() => this.IsNull(this.tableDataTable1.FIRMA5IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA5IDNull() => this[this.tableDataTable1.FIRMA5IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF5BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F5BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF5BIRIMFIYATNull() => this[this.tableDataTable1.F5BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF5TUTARNull() => this.IsNull(this.tableDataTable1.F5TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF5TUTARNull() => this[this.tableDataTable1.F5TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA6IDNull() => this.IsNull(this.tableDataTable1.FIRMA6IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA6IDNull() => this[this.tableDataTable1.FIRMA6IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF6BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F6BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF6BIRIMFIYATNull() => this[this.tableDataTable1.F6BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF6TUTARNull() => this.IsNull(this.tableDataTable1.F6TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF6TUTARNull() => this[this.tableDataTable1.F6TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA7IDNull() => this.IsNull(this.tableDataTable1.FIRMA7IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA7IDNull() => this[this.tableDataTable1.FIRMA7IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF7BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F7BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF7BIRIMFIYATNull() => this[this.tableDataTable1.F7BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF7TUTARNull() => this.IsNull(this.tableDataTable1.F7TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF7TUTARNull() => this[this.tableDataTable1.F7TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMA8IDNull() => this.IsNull(this.tableDataTable1.FIRMA8IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMA8IDNull() => this[this.tableDataTable1.FIRMA8IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF8BIRIMFIYATNull() => this.IsNull(this.tableDataTable1.F8BIRIMFIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF8BIRIMFIYATNull() => this[this.tableDataTable1.F8BIRIMFIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsF8TUTARNull() => this.IsNull(this.tableDataTable1.F8TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetF8TUTARNull() => this[this.tableDataTable1.F8TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEIDNull() => this.IsNull(this.tableDataTable1.MALZEMEIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEIDNull() => this[this.tableDataTable1.MALZEMEIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZACIKLAMANull() => this.IsNull(this.tableDataTable1.MALZACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZACIKLAMANull() => this[this.tableDataTable1.MALZACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableDataTable1.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableDataTable1.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTUTARNull() => this.IsNull(this.tableDataTable1.TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTUTARNull() => this[this.tableDataTable1.TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMARKA1Null() => this.IsNull(this.tableDataTable1.MARKA1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMARKA1Null() => this[this.tableDataTable1.MARKA1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEID1Null() => this.IsNull(this.tableDataTable1.MALZEMEID1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEID1Null() => this[this.tableDataTable1.MALZEMEID1Column] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private TalepCekmeTeklifteGorunme.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(
        TalepCekmeTeklifteGorunme.DataTable1Row row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepCekmeTeklifteGorunme.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
