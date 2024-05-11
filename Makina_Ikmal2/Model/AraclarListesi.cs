// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.AraclarListesi
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
  [XmlRoot("AraclarListesi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class AraclarListesi : DataSet
  {
    private AraclarListesi.DataTable1DataTable tableDataTable1;
    private AraclarListesi.DataTable2DataTable tableDataTable2;
    private AraclarListesi.DataTable3DataTable tableDataTable3;
    private AraclarListesi.TrafikListesiDataTable tableTrafikListesi;
    private AraclarListesi.DataTable4DataTable tableDataTable4;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AraclarListesi()
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
    protected AraclarListesi(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new AraclarListesi.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
          if (dataSet.Tables[nameof (DataTable2)] != null)
            base.Tables.Add((DataTable) new AraclarListesi.DataTable2DataTable(dataSet.Tables[nameof (DataTable2)]));
          if (dataSet.Tables[nameof (DataTable3)] != null)
            base.Tables.Add((DataTable) new AraclarListesi.DataTable3DataTable(dataSet.Tables[nameof (DataTable3)]));
          if (dataSet.Tables[nameof (TrafikListesi)] != null)
            base.Tables.Add((DataTable) new AraclarListesi.TrafikListesiDataTable(dataSet.Tables[nameof (TrafikListesi)]));
          if (dataSet.Tables[nameof (DataTable4)] != null)
            base.Tables.Add((DataTable) new AraclarListesi.DataTable4DataTable(dataSet.Tables[nameof (DataTable4)]));
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
    public AraclarListesi.DataTable1DataTable DataTable1 => this.tableDataTable1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public AraclarListesi.DataTable2DataTable DataTable2 => this.tableDataTable2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public AraclarListesi.DataTable3DataTable DataTable3 => this.tableDataTable3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public AraclarListesi.TrafikListesiDataTable TrafikListesi => this.tableTrafikListesi;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public AraclarListesi.DataTable4DataTable DataTable4 => this.tableDataTable4;

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
      AraclarListesi araclarListesi = (AraclarListesi) base.Clone();
      araclarListesi.InitVars();
      araclarListesi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) araclarListesi;
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
          base.Tables.Add((DataTable) new AraclarListesi.DataTable1DataTable(dataSet.Tables["DataTable1"]));
        if (dataSet.Tables["DataTable2"] != null)
          base.Tables.Add((DataTable) new AraclarListesi.DataTable2DataTable(dataSet.Tables["DataTable2"]));
        if (dataSet.Tables["DataTable3"] != null)
          base.Tables.Add((DataTable) new AraclarListesi.DataTable3DataTable(dataSet.Tables["DataTable3"]));
        if (dataSet.Tables["TrafikListesi"] != null)
          base.Tables.Add((DataTable) new AraclarListesi.TrafikListesiDataTable(dataSet.Tables["TrafikListesi"]));
        if (dataSet.Tables["DataTable4"] != null)
          base.Tables.Add((DataTable) new AraclarListesi.DataTable4DataTable(dataSet.Tables["DataTable4"]));
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
      this.tableDataTable1 = (AraclarListesi.DataTable1DataTable) base.Tables["DataTable1"];
      if (initTable && this.tableDataTable1 != null)
        this.tableDataTable1.InitVars();
      this.tableDataTable2 = (AraclarListesi.DataTable2DataTable) base.Tables["DataTable2"];
      if (initTable && this.tableDataTable2 != null)
        this.tableDataTable2.InitVars();
      this.tableDataTable3 = (AraclarListesi.DataTable3DataTable) base.Tables["DataTable3"];
      if (initTable && this.tableDataTable3 != null)
        this.tableDataTable3.InitVars();
      this.tableTrafikListesi = (AraclarListesi.TrafikListesiDataTable) base.Tables["TrafikListesi"];
      if (initTable && this.tableTrafikListesi != null)
        this.tableTrafikListesi.InitVars();
      this.tableDataTable4 = (AraclarListesi.DataTable4DataTable) base.Tables["DataTable4"];
      if (!initTable || this.tableDataTable4 == null)
        return;
      this.tableDataTable4.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (AraclarListesi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/AraclarListesi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new AraclarListesi.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
      this.tableDataTable2 = new AraclarListesi.DataTable2DataTable();
      base.Tables.Add((DataTable) this.tableDataTable2);
      this.tableDataTable3 = new AraclarListesi.DataTable3DataTable();
      base.Tables.Add((DataTable) this.tableDataTable3);
      this.tableTrafikListesi = new AraclarListesi.TrafikListesiDataTable();
      base.Tables.Add((DataTable) this.tableTrafikListesi);
      this.tableDataTable4 = new AraclarListesi.DataTable4DataTable();
      base.Tables.Add((DataTable) this.tableDataTable4);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable2() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable3() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTrafikListesi() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable4() => false;

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
      AraclarListesi araclarListesi = new AraclarListesi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = araclarListesi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable2DataTable : TypedTableBase<AraclarListesi.DataTable2Row>
    {
      private DataColumn columnTARIH;
      private DataColumn columnBELDMUDURLUKID;
      private DataColumn columnExpr2;
      private DataColumn columnSAAT;
      private DataColumn columnARACID;
      private DataColumn columnZIMMETALANID;
      private DataColumn columnTAHSISEDILENID;
      private DataColumn columnONCEKIARACI;
      private DataColumn columnBELDBIRIMID;
      private DataColumn columnILGILINOT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable2DataTable()
      {
        this.TableName = "DataTable2";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable2DataTable(DataTable table)
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
      protected DataTable2DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDMUDURLUKIDColumn => this.columnBELDMUDURLUKID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr2Column => this.columnExpr2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SAATColumn => this.columnSAAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACIDColumn => this.columnARACID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ZIMMETALANIDColumn => this.columnZIMMETALANID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TAHSISEDILENIDColumn => this.columnTAHSISEDILENID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ONCEKIARACIColumn => this.columnONCEKIARACI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMIDColumn => this.columnBELDBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ILGILINOTColumn => this.columnILGILINOT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable2Row this[int index] => (AraclarListesi.DataTable2Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable2RowChangeEventHandler DataTable2RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable2RowChangeEventHandler DataTable2RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable2RowChangeEventHandler DataTable2RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable2RowChangeEventHandler DataTable2RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable2Row(AraclarListesi.DataTable2Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable2Row AddDataTable2Row(
        string TARIH,
        int BELDMUDURLUKID,
        int Expr2,
        string SAAT,
        int ARACID,
        int ZIMMETALANID,
        int TAHSISEDILENID,
        string ONCEKIARACI,
        int BELDBIRIMID,
        string ILGILINOT)
      {
        AraclarListesi.DataTable2Row row = (AraclarListesi.DataTable2Row) this.NewRow();
        object[] objArray = new object[10]
        {
          (object) TARIH,
          (object) BELDMUDURLUKID,
          (object) Expr2,
          (object) SAAT,
          (object) ARACID,
          (object) ZIMMETALANID,
          (object) TAHSISEDILENID,
          (object) ONCEKIARACI,
          (object) BELDBIRIMID,
          (object) ILGILINOT
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AraclarListesi.DataTable2DataTable dataTable2DataTable = (AraclarListesi.DataTable2DataTable) base.Clone();
        dataTable2DataTable.InitVars();
        return (DataTable) dataTable2DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AraclarListesi.DataTable2DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnTARIH = this.Columns["TARIH"];
        this.columnBELDMUDURLUKID = this.Columns["BELDMUDURLUKID"];
        this.columnExpr2 = this.Columns["Expr2"];
        this.columnSAAT = this.Columns["SAAT"];
        this.columnARACID = this.Columns["ARACID"];
        this.columnZIMMETALANID = this.Columns["ZIMMETALANID"];
        this.columnTAHSISEDILENID = this.Columns["TAHSISEDILENID"];
        this.columnONCEKIARACI = this.Columns["ONCEKIARACI"];
        this.columnBELDBIRIMID = this.Columns["BELDBIRIMID"];
        this.columnILGILINOT = this.Columns["ILGILINOT"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnTARIH = new DataColumn("TARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnBELDMUDURLUKID = new DataColumn("BELDMUDURLUKID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDMUDURLUKID);
        this.columnExpr2 = new DataColumn("Expr2", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr2);
        this.columnSAAT = new DataColumn("SAAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSAAT);
        this.columnARACID = new DataColumn("ARACID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACID);
        this.columnZIMMETALANID = new DataColumn("ZIMMETALANID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnZIMMETALANID);
        this.columnTAHSISEDILENID = new DataColumn("TAHSISEDILENID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTAHSISEDILENID);
        this.columnONCEKIARACI = new DataColumn("ONCEKIARACI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnONCEKIARACI);
        this.columnBELDBIRIMID = new DataColumn("BELDBIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMID);
        this.columnILGILINOT = new DataColumn("ILGILINOT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnILGILINOT);
        this.columnTARIH.MaxLength = 19;
        this.columnSAAT.MaxLength = 16;
        this.columnONCEKIARACI.MaxLength = 20;
        this.columnILGILINOT.MaxLength = 87;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable2Row NewDataTable2Row() => (AraclarListesi.DataTable2Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AraclarListesi.DataTable2Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AraclarListesi.DataTable2Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable2RowChanged == null)
          return;
        this.DataTable2RowChanged((object) this, new AraclarListesi.DataTable2RowChangeEvent((AraclarListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable2RowChanging == null)
          return;
        this.DataTable2RowChanging((object) this, new AraclarListesi.DataTable2RowChangeEvent((AraclarListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable2RowDeleted == null)
          return;
        this.DataTable2RowDeleted((object) this, new AraclarListesi.DataTable2RowChangeEvent((AraclarListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable2RowDeleting == null)
          return;
        this.DataTable2RowDeleting((object) this, new AraclarListesi.DataTable2RowChangeEvent((AraclarListesi.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable2Row(AraclarListesi.DataTable2Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AraclarListesi araclarListesi = new AraclarListesi();
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
          FixedValue = araclarListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable1RowChangeEventHandler(
      object sender,
      AraclarListesi.DataTable1RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable2RowChangeEventHandler(
      object sender,
      AraclarListesi.DataTable2RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable3RowChangeEventHandler(
      object sender,
      AraclarListesi.DataTable3RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void TrafikListesiRowChangeEventHandler(
      object sender,
      AraclarListesi.TrafikListesiRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable4RowChangeEventHandler(
      object sender,
      AraclarListesi.DataTable4RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<AraclarListesi.DataTable1Row>
    {
      private DataColumn columnPLAKA;
      private DataColumn columnVERILDIGIILILCE;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnTESCILSIRANO;
      private DataColumn columnILKTESCILTARIHI;
      private DataColumn columnESKIPLAKA;
      private DataColumn columnTAHSPLKTARIH;
      private DataColumn columnTAHSPLAKA;
      private DataColumn columnMODEL;
      private DataColumn columnCINSI;
      private DataColumn columnTICARIADI;
      private DataColumn columnRENGI;
      private DataColumn columnGOREVDURUM;
      private DataColumn columnGOREVBITIMTARIH;
      private DataColumn columnARACMARKA;
      private DataColumn columnGRUPADI;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnFIRMAADI;
      private DataColumn columnID;
      private DataColumn columnExpr1;

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
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn VERILDIGIILILCEColumn => this.columnVERILDIGIILILCE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TESCILSIRANOColumn => this.columnTESCILSIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ILKTESCILTARIHIColumn => this.columnILKTESCILTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ESKIPLAKAColumn => this.columnESKIPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TAHSPLKTARIHColumn => this.columnTAHSPLKTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TAHSPLAKAColumn => this.columnTAHSPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MODELColumn => this.columnMODEL;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CINSIColumn => this.columnCINSI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TICARIADIColumn => this.columnTICARIADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn RENGIColumn => this.columnRENGI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVDURUMColumn => this.columnGOREVDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVBITIMTARIHColumn => this.columnGOREVBITIMTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACMARKAColumn => this.columnARACMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPADIColumn => this.columnGRUPADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIRMAADIColumn => this.columnFIRMAADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable1Row this[int index] => (AraclarListesi.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(AraclarListesi.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable1Row AddDataTable1Row(
        string PLAKA,
        string VERILDIGIILILCE,
        string ARACACIKLAMA,
        string TESCILSIRANO,
        string ILKTESCILTARIHI,
        string ESKIPLAKA,
        string TAHSPLKTARIH,
        string TAHSPLAKA,
        string MODEL,
        string CINSI,
        string TICARIADI,
        string RENGI,
        string GOREVDURUM,
        string GOREVBITIMTARIH,
        string ARACMARKA,
        string GRUPADI,
        string BELDBIRIMADI,
        string FIRMAADI,
        int ID,
        string Expr1)
      {
        AraclarListesi.DataTable1Row row = (AraclarListesi.DataTable1Row) this.NewRow();
        object[] objArray = new object[20]
        {
          (object) PLAKA,
          (object) VERILDIGIILILCE,
          (object) ARACACIKLAMA,
          (object) TESCILSIRANO,
          (object) ILKTESCILTARIHI,
          (object) ESKIPLAKA,
          (object) TAHSPLKTARIH,
          (object) TAHSPLAKA,
          (object) MODEL,
          (object) CINSI,
          (object) TICARIADI,
          (object) RENGI,
          (object) GOREVDURUM,
          (object) GOREVBITIMTARIH,
          (object) ARACMARKA,
          (object) GRUPADI,
          (object) BELDBIRIMADI,
          (object) FIRMAADI,
          (object) ID,
          (object) Expr1
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AraclarListesi.DataTable1DataTable dataTable1DataTable = (AraclarListesi.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AraclarListesi.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnVERILDIGIILILCE = this.Columns["VERILDIGIILILCE"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnTESCILSIRANO = this.Columns["TESCILSIRANO"];
        this.columnILKTESCILTARIHI = this.Columns["ILKTESCILTARIHI"];
        this.columnESKIPLAKA = this.Columns["ESKIPLAKA"];
        this.columnTAHSPLKTARIH = this.Columns["TAHSPLKTARIH"];
        this.columnTAHSPLAKA = this.Columns["TAHSPLAKA"];
        this.columnMODEL = this.Columns["MODEL"];
        this.columnCINSI = this.Columns["CINSI"];
        this.columnTICARIADI = this.Columns["TICARIADI"];
        this.columnRENGI = this.Columns["RENGI"];
        this.columnGOREVDURUM = this.Columns["GOREVDURUM"];
        this.columnGOREVBITIMTARIH = this.Columns["GOREVBITIMTARIH"];
        this.columnARACMARKA = this.Columns["ARACMARKA"];
        this.columnGRUPADI = this.Columns["GRUPADI"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnFIRMAADI = this.Columns["FIRMAADI"];
        this.columnID = this.Columns["ID"];
        this.columnExpr1 = this.Columns["Expr1"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnVERILDIGIILILCE = new DataColumn("VERILDIGIILILCE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnVERILDIGIILILCE);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnTESCILSIRANO = new DataColumn("TESCILSIRANO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTESCILSIRANO);
        this.columnILKTESCILTARIHI = new DataColumn("ILKTESCILTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnILKTESCILTARIHI);
        this.columnESKIPLAKA = new DataColumn("ESKIPLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnESKIPLAKA);
        this.columnTAHSPLKTARIH = new DataColumn("TAHSPLKTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTAHSPLKTARIH);
        this.columnTAHSPLAKA = new DataColumn("TAHSPLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTAHSPLAKA);
        this.columnMODEL = new DataColumn("MODEL", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMODEL);
        this.columnCINSI = new DataColumn("CINSI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCINSI);
        this.columnTICARIADI = new DataColumn("TICARIADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTICARIADI);
        this.columnRENGI = new DataColumn("RENGI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRENGI);
        this.columnGOREVDURUM = new DataColumn("GOREVDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVDURUM);
        this.columnGOREVBITIMTARIH = new DataColumn("GOREVBITIMTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVBITIMTARIH);
        this.columnARACMARKA = new DataColumn("ARACMARKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACMARKA);
        this.columnGRUPADI = new DataColumn("GRUPADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPADI);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnFIRMAADI = new DataColumn("FIRMAADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIRMAADI);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnPLAKA.MaxLength = 16;
        this.columnVERILDIGIILILCE.MaxLength = 29;
        this.columnARACACIKLAMA.MaxLength = 50;
        this.columnTESCILSIRANO.MaxLength = 6;
        this.columnILKTESCILTARIHI.MaxLength = 19;
        this.columnESKIPLAKA.MaxLength = 9;
        this.columnTAHSPLKTARIH.MaxLength = 19;
        this.columnTAHSPLAKA.MaxLength = 8;
        this.columnMODEL.MaxLength = 4;
        this.columnCINSI.MaxLength = 50;
        this.columnTICARIADI.MaxLength = 30;
        this.columnRENGI.MaxLength = 50;
        this.columnGOREVDURUM.MaxLength = 20;
        this.columnGOREVBITIMTARIH.MaxLength = 20;
        this.columnARACMARKA.MaxLength = 22;
        this.columnGRUPADI.MaxLength = 20;
        this.columnBELDBIRIMADI.MaxLength = 43;
        this.columnFIRMAADI.MaxLength = 46;
        this.columnExpr1.MaxLength = 11;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable1Row NewDataTable1Row() => (AraclarListesi.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AraclarListesi.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AraclarListesi.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new AraclarListesi.DataTable1RowChangeEvent((AraclarListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new AraclarListesi.DataTable1RowChangeEvent((AraclarListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new AraclarListesi.DataTable1RowChangeEvent((AraclarListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new AraclarListesi.DataTable1RowChangeEvent((AraclarListesi.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(AraclarListesi.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AraclarListesi araclarListesi = new AraclarListesi();
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
          FixedValue = araclarListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable3DataTable : TypedTableBase<AraclarListesi.DataTable3Row>
    {
      private DataColumn columnID;
      private DataColumn columnADISOYADI;
      private DataColumn columnExpr1;
      private DataColumn columnPLAKA;
      private DataColumn columnARACMARKA;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnBELDMUDURLUK;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable3DataTable()
      {
        this.TableName = "DataTable3";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable3DataTable(DataTable table)
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
      protected DataTable3DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACMARKAColumn => this.columnARACMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDMUDURLUKColumn => this.columnBELDMUDURLUK;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable3Row this[int index] => (AraclarListesi.DataTable3Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable3RowChangeEventHandler DataTable3RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable3RowChangeEventHandler DataTable3RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable3RowChangeEventHandler DataTable3RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable3RowChangeEventHandler DataTable3RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable3Row(AraclarListesi.DataTable3Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable3Row AddDataTable3Row(
        int ID,
        string ADISOYADI,
        string Expr1,
        string PLAKA,
        string ARACMARKA,
        string BELDBIRIMADI,
        string BELDMUDURLUK)
      {
        AraclarListesi.DataTable3Row row = (AraclarListesi.DataTable3Row) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) ID,
          (object) ADISOYADI,
          (object) Expr1,
          (object) PLAKA,
          (object) ARACMARKA,
          (object) BELDBIRIMADI,
          (object) BELDMUDURLUK
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AraclarListesi.DataTable3DataTable dataTable3DataTable = (AraclarListesi.DataTable3DataTable) base.Clone();
        dataTable3DataTable.InitVars();
        return (DataTable) dataTable3DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AraclarListesi.DataTable3DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACMARKA = this.Columns["ARACMARKA"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnBELDMUDURLUK = this.Columns["BELDMUDURLUK"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACMARKA = new DataColumn("ARACMARKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACMARKA);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnBELDMUDURLUK = new DataColumn("BELDMUDURLUK", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDMUDURLUK);
        this.columnADISOYADI.MaxLength = 50;
        this.columnExpr1.MaxLength = 50;
        this.columnPLAKA.MaxLength = 16;
        this.columnARACMARKA.MaxLength = 22;
        this.columnBELDBIRIMADI.MaxLength = 43;
        this.columnBELDMUDURLUK.MaxLength = 49;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable3Row NewDataTable3Row() => (AraclarListesi.DataTable3Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AraclarListesi.DataTable3Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AraclarListesi.DataTable3Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable3RowChanged == null)
          return;
        this.DataTable3RowChanged((object) this, new AraclarListesi.DataTable3RowChangeEvent((AraclarListesi.DataTable3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable3RowChanging == null)
          return;
        this.DataTable3RowChanging((object) this, new AraclarListesi.DataTable3RowChangeEvent((AraclarListesi.DataTable3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable3RowDeleted == null)
          return;
        this.DataTable3RowDeleted((object) this, new AraclarListesi.DataTable3RowChangeEvent((AraclarListesi.DataTable3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable3RowDeleting == null)
          return;
        this.DataTable3RowDeleting((object) this, new AraclarListesi.DataTable3RowChangeEvent((AraclarListesi.DataTable3Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable3Row(AraclarListesi.DataTable3Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AraclarListesi araclarListesi = new AraclarListesi();
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
          FixedValue = araclarListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable3DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TrafikListesiDataTable : TypedTableBase<AraclarListesi.TrafikListesiRow>
    {
      private DataColumn columnID;
      private DataColumn columnPLAKA;
      private DataColumn columnBELDMUDURLUK;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnKAYITTARIHI;
      private DataColumn columnFISNO;
      private DataColumn columnCEZATARIHI;
      private DataColumn columnCEZASAATI;
      private DataColumn columnCEZAACIKLAMA;
      private DataColumn columnCEZATUTARI;
      private DataColumn columnODEMEDURUM;
      private DataColumn columnILGILINOT;
      private DataColumn columnGOREVDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TrafikListesiDataTable()
      {
        this.TableName = "TrafikListesi";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TrafikListesiDataTable(DataTable table)
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
      protected TrafikListesiDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDMUDURLUKColumn => this.columnBELDMUDURLUK;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KAYITTARIHIColumn => this.columnKAYITTARIHI;

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
      public DataColumn CEZAACIKLAMAColumn => this.columnCEZAACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CEZATUTARIColumn => this.columnCEZATUTARI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ODEMEDURUMColumn => this.columnODEMEDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ILGILINOTColumn => this.columnILGILINOT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GOREVDURUMColumn => this.columnGOREVDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.TrafikListesiRow this[int index] => (AraclarListesi.TrafikListesiRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.TrafikListesiRowChangeEventHandler TrafikListesiRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.TrafikListesiRowChangeEventHandler TrafikListesiRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.TrafikListesiRowChangeEventHandler TrafikListesiRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.TrafikListesiRowChangeEventHandler TrafikListesiRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTrafikListesiRow(AraclarListesi.TrafikListesiRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.TrafikListesiRow AddTrafikListesiRow(
        int ID,
        string PLAKA,
        string BELDMUDURLUK,
        string BELDBIRIMADI,
        string KAYITTARIHI,
        string FISNO,
        string CEZATARIHI,
        string CEZASAATI,
        string CEZAACIKLAMA,
        Decimal CEZATUTARI,
        string ODEMEDURUM,
        string ILGILINOT,
        string GOREVDURUM)
      {
        AraclarListesi.TrafikListesiRow row = (AraclarListesi.TrafikListesiRow) this.NewRow();
        object[] objArray = new object[13]
        {
          (object) ID,
          (object) PLAKA,
          (object) BELDMUDURLUK,
          (object) BELDBIRIMADI,
          (object) KAYITTARIHI,
          (object) FISNO,
          (object) CEZATARIHI,
          (object) CEZASAATI,
          (object) CEZAACIKLAMA,
          (object) CEZATUTARI,
          (object) ODEMEDURUM,
          (object) ILGILINOT,
          (object) GOREVDURUM
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AraclarListesi.TrafikListesiDataTable listesiDataTable = (AraclarListesi.TrafikListesiDataTable) base.Clone();
        listesiDataTable.InitVars();
        return (DataTable) listesiDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AraclarListesi.TrafikListesiDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnBELDMUDURLUK = this.Columns["BELDMUDURLUK"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnKAYITTARIHI = this.Columns["KAYITTARIHI"];
        this.columnFISNO = this.Columns["FISNO"];
        this.columnCEZATARIHI = this.Columns["CEZATARIHI"];
        this.columnCEZASAATI = this.Columns["CEZASAATI"];
        this.columnCEZAACIKLAMA = this.Columns["CEZAACIKLAMA"];
        this.columnCEZATUTARI = this.Columns["CEZATUTARI"];
        this.columnODEMEDURUM = this.Columns["ODEMEDURUM"];
        this.columnILGILINOT = this.Columns["ILGILINOT"];
        this.columnGOREVDURUM = this.Columns["GOREVDURUM"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnBELDMUDURLUK = new DataColumn("BELDMUDURLUK", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDMUDURLUK);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnKAYITTARIHI = new DataColumn("KAYITTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKAYITTARIHI);
        this.columnFISNO = new DataColumn("FISNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISNO);
        this.columnCEZATARIHI = new DataColumn("CEZATARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZATARIHI);
        this.columnCEZASAATI = new DataColumn("CEZASAATI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZASAATI);
        this.columnCEZAACIKLAMA = new DataColumn("CEZAACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZAACIKLAMA);
        this.columnCEZATUTARI = new DataColumn("CEZATUTARI", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCEZATUTARI);
        this.columnODEMEDURUM = new DataColumn("ODEMEDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnODEMEDURUM);
        this.columnILGILINOT = new DataColumn("ILGILINOT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnILGILINOT);
        this.columnGOREVDURUM = new DataColumn("GOREVDURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGOREVDURUM);
        this.columnPLAKA.MaxLength = 16;
        this.columnBELDMUDURLUK.MaxLength = 49;
        this.columnBELDBIRIMADI.MaxLength = 43;
        this.columnKAYITTARIHI.MaxLength = 19;
        this.columnFISNO.MaxLength = 20;
        this.columnCEZATARIHI.MaxLength = 19;
        this.columnCEZASAATI.MaxLength = 16;
        this.columnCEZAACIKLAMA.MaxLength = 44;
        this.columnODEMEDURUM.MaxLength = 13;
        this.columnILGILINOT.MaxLength = 100;
        this.columnGOREVDURUM.MaxLength = 20;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.TrafikListesiRow NewTrafikListesiRow() => (AraclarListesi.TrafikListesiRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AraclarListesi.TrafikListesiRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AraclarListesi.TrafikListesiRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TrafikListesiRowChanged == null)
          return;
        this.TrafikListesiRowChanged((object) this, new AraclarListesi.TrafikListesiRowChangeEvent((AraclarListesi.TrafikListesiRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TrafikListesiRowChanging == null)
          return;
        this.TrafikListesiRowChanging((object) this, new AraclarListesi.TrafikListesiRowChangeEvent((AraclarListesi.TrafikListesiRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TrafikListesiRowDeleted == null)
          return;
        this.TrafikListesiRowDeleted((object) this, new AraclarListesi.TrafikListesiRowChangeEvent((AraclarListesi.TrafikListesiRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TrafikListesiRowDeleting == null)
          return;
        this.TrafikListesiRowDeleting((object) this, new AraclarListesi.TrafikListesiRowChangeEvent((AraclarListesi.TrafikListesiRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTrafikListesiRow(AraclarListesi.TrafikListesiRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AraclarListesi araclarListesi = new AraclarListesi();
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
          FixedValue = araclarListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TrafikListesiDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable4DataTable : TypedTableBase<AraclarListesi.DataTable4Row>
    {
      private DataColumn columnID;
      private DataColumn columnVERILDIGIILILCE;
      private DataColumn columnPLAKA;
      private DataColumn columnARACACIKLAMA;
      private DataColumn columnTAHSPLKTARIH;
      private DataColumn columnESKIPLAKA;
      private DataColumn columnTESCILSIRANO;
      private DataColumn columnILKTESCILTARIHI;
      private DataColumn columnTESCILTARIHI;
      private DataColumn columnARACMARKA;
      private DataColumn columnBELDBIRIMADI;
      private DataColumn columnADISOYADI;
      private DataColumn columnExpr1;
      private DataColumn columnGRUPADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable4DataTable()
      {
        this.TableName = "DataTable4";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable4DataTable(DataTable table)
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
      protected DataTable4DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn VERILDIGIILILCEColumn => this.columnVERILDIGIILILCE;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACACIKLAMAColumn => this.columnARACACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TAHSPLKTARIHColumn => this.columnTAHSPLKTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ESKIPLAKAColumn => this.columnESKIPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TESCILSIRANOColumn => this.columnTESCILSIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ILKTESCILTARIHIColumn => this.columnILKTESCILTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TESCILTARIHIColumn => this.columnTESCILTARIHI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ARACMARKAColumn => this.columnARACMARKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BELDBIRIMADIColumn => this.columnBELDBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ADISOYADIColumn => this.columnADISOYADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Expr1Column => this.columnExpr1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GRUPADIColumn => this.columnGRUPADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable4Row this[int index] => (AraclarListesi.DataTable4Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable4RowChangeEventHandler DataTable4RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable4RowChangeEventHandler DataTable4RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable4RowChangeEventHandler DataTable4RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event AraclarListesi.DataTable4RowChangeEventHandler DataTable4RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable4Row(AraclarListesi.DataTable4Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable4Row AddDataTable4Row(
        string VERILDIGIILILCE,
        string PLAKA,
        string ARACACIKLAMA,
        string TAHSPLKTARIH,
        string ESKIPLAKA,
        string TESCILSIRANO,
        string ILKTESCILTARIHI,
        string TESCILTARIHI,
        string ARACMARKA,
        string BELDBIRIMADI,
        string ADISOYADI,
        string Expr1,
        string GRUPADI)
      {
        AraclarListesi.DataTable4Row row = (AraclarListesi.DataTable4Row) this.NewRow();
        object[] objArray = new object[14]
        {
          null,
          (object) VERILDIGIILILCE,
          (object) PLAKA,
          (object) ARACACIKLAMA,
          (object) TAHSPLKTARIH,
          (object) ESKIPLAKA,
          (object) TESCILSIRANO,
          (object) ILKTESCILTARIHI,
          (object) TESCILTARIHI,
          (object) ARACMARKA,
          (object) BELDBIRIMADI,
          (object) ADISOYADI,
          (object) Expr1,
          (object) GRUPADI
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable4Row FindByID(int ID) => (AraclarListesi.DataTable4Row) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        AraclarListesi.DataTable4DataTable dataTable4DataTable = (AraclarListesi.DataTable4DataTable) base.Clone();
        dataTable4DataTable.InitVars();
        return (DataTable) dataTable4DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new AraclarListesi.DataTable4DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnVERILDIGIILILCE = this.Columns["VERILDIGIILILCE"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnARACACIKLAMA = this.Columns["ARACACIKLAMA"];
        this.columnTAHSPLKTARIH = this.Columns["TAHSPLKTARIH"];
        this.columnESKIPLAKA = this.Columns["ESKIPLAKA"];
        this.columnTESCILSIRANO = this.Columns["TESCILSIRANO"];
        this.columnILKTESCILTARIHI = this.Columns["ILKTESCILTARIHI"];
        this.columnTESCILTARIHI = this.Columns["TESCILTARIHI"];
        this.columnARACMARKA = this.Columns["ARACMARKA"];
        this.columnBELDBIRIMADI = this.Columns["BELDBIRIMADI"];
        this.columnADISOYADI = this.Columns["ADISOYADI"];
        this.columnExpr1 = this.Columns["Expr1"];
        this.columnGRUPADI = this.Columns["GRUPADI"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnVERILDIGIILILCE = new DataColumn("VERILDIGIILILCE", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnVERILDIGIILILCE);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnARACACIKLAMA = new DataColumn("ARACACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACACIKLAMA);
        this.columnTAHSPLKTARIH = new DataColumn("TAHSPLKTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTAHSPLKTARIH);
        this.columnESKIPLAKA = new DataColumn("ESKIPLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnESKIPLAKA);
        this.columnTESCILSIRANO = new DataColumn("TESCILSIRANO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTESCILSIRANO);
        this.columnILKTESCILTARIHI = new DataColumn("ILKTESCILTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnILKTESCILTARIHI);
        this.columnTESCILTARIHI = new DataColumn("TESCILTARIHI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTESCILTARIHI);
        this.columnARACMARKA = new DataColumn("ARACMARKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnARACMARKA);
        this.columnBELDBIRIMADI = new DataColumn("BELDBIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBELDBIRIMADI);
        this.columnADISOYADI = new DataColumn("ADISOYADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADISOYADI);
        this.columnExpr1 = new DataColumn("Expr1", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExpr1);
        this.columnGRUPADI = new DataColumn("GRUPADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGRUPADI);
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
        this.columnVERILDIGIILILCE.MaxLength = 50;
        this.columnPLAKA.MaxLength = 50;
        this.columnARACACIKLAMA.MaxLength = 100;
        this.columnTAHSPLKTARIH.MaxLength = 50;
        this.columnESKIPLAKA.MaxLength = 50;
        this.columnTESCILSIRANO.MaxLength = 50;
        this.columnILKTESCILTARIHI.MaxLength = 50;
        this.columnTESCILTARIHI.MaxLength = 50;
        this.columnARACMARKA.MaxLength = 50;
        this.columnBELDBIRIMADI.MaxLength = 50;
        this.columnADISOYADI.MaxLength = 50;
        this.columnExpr1.MaxLength = 50;
        this.columnGRUPADI.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable4Row NewDataTable4Row() => (AraclarListesi.DataTable4Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new AraclarListesi.DataTable4Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (AraclarListesi.DataTable4Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable4RowChanged == null)
          return;
        this.DataTable4RowChanged((object) this, new AraclarListesi.DataTable4RowChangeEvent((AraclarListesi.DataTable4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable4RowChanging == null)
          return;
        this.DataTable4RowChanging((object) this, new AraclarListesi.DataTable4RowChangeEvent((AraclarListesi.DataTable4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable4RowDeleted == null)
          return;
        this.DataTable4RowDeleted((object) this, new AraclarListesi.DataTable4RowChangeEvent((AraclarListesi.DataTable4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable4RowDeleting == null)
          return;
        this.DataTable4RowDeleting((object) this, new AraclarListesi.DataTable4RowChangeEvent((AraclarListesi.DataTable4Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable4Row(AraclarListesi.DataTable4Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        AraclarListesi araclarListesi = new AraclarListesi();
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
          FixedValue = araclarListesi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable4DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = araclarListesi.GetSchemaSerializable();
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
      private AraclarListesi.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (AraclarListesi.DataTable1DataTable) this.Table;
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
      public string VERILDIGIILILCE
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.VERILDIGIILILCEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'VERILDIGIILILCE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.VERILDIGIILILCEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TESCILSIRANO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TESCILSIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TESCILSIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TESCILSIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ILKTESCILTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ILKTESCILTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ILKTESCILTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ILKTESCILTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ESKIPLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ESKIPLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ESKIPLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ESKIPLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TAHSPLKTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TAHSPLKTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TAHSPLKTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TAHSPLKTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TAHSPLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TAHSPLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TAHSPLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TAHSPLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MODEL
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MODELColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'MODEL' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MODELColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CINSI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CINSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'CINSI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CINSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TICARIADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.TICARIADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TICARIADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TICARIADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string RENGI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.RENGIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'RENGI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.RENGIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GOREVDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GOREVDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GOREVDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVBITIMTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GOREVBITIMTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GOREVBITIMTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GOREVBITIMTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACMARKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.ARACMARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ARACMARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.ARACMARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GRUPADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GRUPADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'GRUPADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GRUPADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FIRMAADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.FIRMAADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIRMAADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIRMAADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable1.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable1.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsVERILDIGIILILCENull() => this.IsNull(this.tableDataTable1.VERILDIGIILILCEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetVERILDIGIILILCENull() => this[this.tableDataTable1.VERILDIGIILILCEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableDataTable1.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableDataTable1.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTESCILSIRANONull() => this.IsNull(this.tableDataTable1.TESCILSIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTESCILSIRANONull() => this[this.tableDataTable1.TESCILSIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsILKTESCILTARIHINull() => this.IsNull(this.tableDataTable1.ILKTESCILTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetILKTESCILTARIHINull() => this[this.tableDataTable1.ILKTESCILTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsESKIPLAKANull() => this.IsNull(this.tableDataTable1.ESKIPLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetESKIPLAKANull() => this[this.tableDataTable1.ESKIPLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTAHSPLKTARIHNull() => this.IsNull(this.tableDataTable1.TAHSPLKTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTAHSPLKTARIHNull() => this[this.tableDataTable1.TAHSPLKTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTAHSPLAKANull() => this.IsNull(this.tableDataTable1.TAHSPLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTAHSPLAKANull() => this[this.tableDataTable1.TAHSPLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMODELNull() => this.IsNull(this.tableDataTable1.MODELColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMODELNull() => this[this.tableDataTable1.MODELColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCINSINull() => this.IsNull(this.tableDataTable1.CINSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCINSINull() => this[this.tableDataTable1.CINSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTICARIADINull() => this.IsNull(this.tableDataTable1.TICARIADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTICARIADINull() => this[this.tableDataTable1.TICARIADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsRENGINull() => this.IsNull(this.tableDataTable1.RENGIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetRENGINull() => this[this.tableDataTable1.RENGIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVDURUMNull() => this.IsNull(this.tableDataTable1.GOREVDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVDURUMNull() => this[this.tableDataTable1.GOREVDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVBITIMTARIHNull() => this.IsNull(this.tableDataTable1.GOREVBITIMTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVBITIMTARIHNull() => this[this.tableDataTable1.GOREVBITIMTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACMARKANull() => this.IsNull(this.tableDataTable1.ARACMARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACMARKANull() => this[this.tableDataTable1.ARACMARKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPADINull() => this.IsNull(this.tableDataTable1.GRUPADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPADINull() => this[this.tableDataTable1.GRUPADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableDataTable1.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableDataTable1.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIRMAADINull() => this.IsNull(this.tableDataTable1.FIRMAADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIRMAADINull() => this[this.tableDataTable1.FIRMAADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableDataTable1.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableDataTable1.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable1.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable1.Expr1Column] = Convert.DBNull;
    }

    public class DataTable2Row : DataRow
    {
      private AraclarListesi.DataTable2DataTable tableDataTable2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable2 = (AraclarListesi.DataTable2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.TARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BELDMUDURLUKID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.BELDMUDURLUKIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BELDMUDURLUKID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BELDMUDURLUKIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Expr2
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.Expr2Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'Expr2' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.Expr2Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SAAT
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.SAATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'SAAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.SAATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ARACID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.ARACIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ARACID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ARACIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ZIMMETALANID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.ZIMMETALANIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ZIMMETALANID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ZIMMETALANIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TAHSISEDILENID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.TAHSISEDILENIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TAHSISEDILENID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TAHSISEDILENIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ONCEKIARACI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.ONCEKIARACIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ONCEKIARACI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ONCEKIARACIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int BELDBIRIMID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.BELDBIRIMIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BELDBIRIMID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BELDBIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ILGILINOT
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.ILGILINOTColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ILGILINOT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ILGILINOTColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable2.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable2.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDMUDURLUKIDNull() => this.IsNull(this.tableDataTable2.BELDMUDURLUKIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDMUDURLUKIDNull() => this[this.tableDataTable2.BELDMUDURLUKIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr2Null() => this.IsNull(this.tableDataTable2.Expr2Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr2Null() => this[this.tableDataTable2.Expr2Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSAATNull() => this.IsNull(this.tableDataTable2.SAATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSAATNull() => this[this.tableDataTable2.SAATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACIDNull() => this.IsNull(this.tableDataTable2.ARACIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACIDNull() => this[this.tableDataTable2.ARACIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsZIMMETALANIDNull() => this.IsNull(this.tableDataTable2.ZIMMETALANIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetZIMMETALANIDNull() => this[this.tableDataTable2.ZIMMETALANIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTAHSISEDILENIDNull() => this.IsNull(this.tableDataTable2.TAHSISEDILENIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTAHSISEDILENIDNull() => this[this.tableDataTable2.TAHSISEDILENIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsONCEKIARACINull() => this.IsNull(this.tableDataTable2.ONCEKIARACIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetONCEKIARACINull() => this[this.tableDataTable2.ONCEKIARACIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMIDNull() => this.IsNull(this.tableDataTable2.BELDBIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMIDNull() => this[this.tableDataTable2.BELDBIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsILGILINOTNull() => this.IsNull(this.tableDataTable2.ILGILINOTColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetILGILINOTNull() => this[this.tableDataTable2.ILGILINOTColumn] = Convert.DBNull;
    }

    public class DataTable3Row : DataRow
    {
      private AraclarListesi.DataTable3DataTable tableDataTable3;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable3Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable3 = (AraclarListesi.DataTable3DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable3.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACMARKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.ARACMARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'ARACMARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.ARACMARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDMUDURLUK
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable3.BELDMUDURLUKColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable3' tablosundaki 'BELDMUDURLUK' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable3.BELDMUDURLUKColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableDataTable3.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableDataTable3.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableDataTable3.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableDataTable3.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable3.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable3.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable3.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable3.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACMARKANull() => this.IsNull(this.tableDataTable3.ARACMARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACMARKANull() => this[this.tableDataTable3.ARACMARKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableDataTable3.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableDataTable3.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDMUDURLUKNull() => this.IsNull(this.tableDataTable3.BELDMUDURLUKColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDMUDURLUKNull() => this[this.tableDataTable3.BELDMUDURLUKColumn] = Convert.DBNull;
    }

    public class TrafikListesiRow : DataRow
    {
      private AraclarListesi.TrafikListesiDataTable tableTrafikListesi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TrafikListesiRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTrafikListesi = (AraclarListesi.TrafikListesiDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get
        {
          try
          {
            return (int) this[this.tableTrafikListesi.IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'ID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDMUDURLUK
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.BELDMUDURLUKColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'BELDMUDURLUK' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.BELDMUDURLUKColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KAYITTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.KAYITTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'KAYITTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.KAYITTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string FISNO
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.FISNOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'FISNO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.FISNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEZATARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.CEZATARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'CEZATARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.CEZATARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEZASAATI
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.CEZASAATIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'CEZASAATI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.CEZASAATIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CEZAACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.CEZAACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'CEZAACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.CEZAACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal CEZATUTARI
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTrafikListesi.CEZATUTARIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'CEZATUTARI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.CEZATUTARIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ODEMEDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.ODEMEDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'ODEMEDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.ODEMEDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ILGILINOT
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.ILGILINOTColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'ILGILINOT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.ILGILINOTColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GOREVDURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableTrafikListesi.GOREVDURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TrafikListesi' tablosundaki 'GOREVDURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTrafikListesi.GOREVDURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsIDNull() => this.IsNull(this.tableTrafikListesi.IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetIDNull() => this[this.tableTrafikListesi.IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableTrafikListesi.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableTrafikListesi.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDMUDURLUKNull() => this.IsNull(this.tableTrafikListesi.BELDMUDURLUKColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDMUDURLUKNull() => this[this.tableTrafikListesi.BELDMUDURLUKColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableTrafikListesi.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableTrafikListesi.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKAYITTARIHINull() => this.IsNull(this.tableTrafikListesi.KAYITTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKAYITTARIHINull() => this[this.tableTrafikListesi.KAYITTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISNONull() => this.IsNull(this.tableTrafikListesi.FISNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISNONull() => this[this.tableTrafikListesi.FISNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZATARIHINull() => this.IsNull(this.tableTrafikListesi.CEZATARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZATARIHINull() => this[this.tableTrafikListesi.CEZATARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZASAATINull() => this.IsNull(this.tableTrafikListesi.CEZASAATIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZASAATINull() => this[this.tableTrafikListesi.CEZASAATIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZAACIKLAMANull() => this.IsNull(this.tableTrafikListesi.CEZAACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZAACIKLAMANull() => this[this.tableTrafikListesi.CEZAACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCEZATUTARINull() => this.IsNull(this.tableTrafikListesi.CEZATUTARIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCEZATUTARINull() => this[this.tableTrafikListesi.CEZATUTARIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsODEMEDURUMNull() => this.IsNull(this.tableTrafikListesi.ODEMEDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetODEMEDURUMNull() => this[this.tableTrafikListesi.ODEMEDURUMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsILGILINOTNull() => this.IsNull(this.tableTrafikListesi.ILGILINOTColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetILGILINOTNull() => this[this.tableTrafikListesi.ILGILINOTColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGOREVDURUMNull() => this.IsNull(this.tableTrafikListesi.GOREVDURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGOREVDURUMNull() => this[this.tableTrafikListesi.GOREVDURUMColumn] = Convert.DBNull;
    }

    public class DataTable4Row : DataRow
    {
      private AraclarListesi.DataTable4DataTable tableDataTable4;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable4Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable4 = (AraclarListesi.DataTable4DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableDataTable4.IDColumn];
        set => this[this.tableDataTable4.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string VERILDIGIILILCE
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.VERILDIGIILILCEColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'VERILDIGIILILCE' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.VERILDIGIILILCEColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.ARACACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'ARACACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.ARACACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TAHSPLKTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.TAHSPLKTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'TAHSPLKTARIH' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.TAHSPLKTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ESKIPLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.ESKIPLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'ESKIPLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.ESKIPLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TESCILSIRANO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.TESCILSIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'TESCILSIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.TESCILSIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ILKTESCILTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.ILKTESCILTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'ILKTESCILTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.ILKTESCILTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string TESCILTARIHI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.TESCILTARIHIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'TESCILTARIHI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.TESCILTARIHIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ARACMARKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.ARACMARKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'ARACMARKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.ARACMARKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BELDBIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.BELDBIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'BELDBIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.BELDBIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ADISOYADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.ADISOYADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'ADISOYADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.ADISOYADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Expr1
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.Expr1Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'Expr1' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.Expr1Column] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GRUPADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable4.GRUPADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable4' tablosundaki 'GRUPADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable4.GRUPADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsVERILDIGIILILCENull() => this.IsNull(this.tableDataTable4.VERILDIGIILILCEColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetVERILDIGIILILCENull() => this[this.tableDataTable4.VERILDIGIILILCEColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable4.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable4.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACACIKLAMANull() => this.IsNull(this.tableDataTable4.ARACACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACACIKLAMANull() => this[this.tableDataTable4.ARACACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTAHSPLKTARIHNull() => this.IsNull(this.tableDataTable4.TAHSPLKTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTAHSPLKTARIHNull() => this[this.tableDataTable4.TAHSPLKTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsESKIPLAKANull() => this.IsNull(this.tableDataTable4.ESKIPLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetESKIPLAKANull() => this[this.tableDataTable4.ESKIPLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTESCILSIRANONull() => this.IsNull(this.tableDataTable4.TESCILSIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTESCILSIRANONull() => this[this.tableDataTable4.TESCILSIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsILKTESCILTARIHINull() => this.IsNull(this.tableDataTable4.ILKTESCILTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetILKTESCILTARIHINull() => this[this.tableDataTable4.ILKTESCILTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTESCILTARIHINull() => this.IsNull(this.tableDataTable4.TESCILTARIHIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTESCILTARIHINull() => this[this.tableDataTable4.TESCILTARIHIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsARACMARKANull() => this.IsNull(this.tableDataTable4.ARACMARKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetARACMARKANull() => this[this.tableDataTable4.ARACMARKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBELDBIRIMADINull() => this.IsNull(this.tableDataTable4.BELDBIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBELDBIRIMADINull() => this[this.tableDataTable4.BELDBIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsADISOYADINull() => this.IsNull(this.tableDataTable4.ADISOYADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetADISOYADINull() => this[this.tableDataTable4.ADISOYADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsExpr1Null() => this.IsNull(this.tableDataTable4.Expr1Column);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetExpr1Null() => this[this.tableDataTable4.Expr1Column] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGRUPADINull() => this.IsNull(this.tableDataTable4.GRUPADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGRUPADINull() => this[this.tableDataTable4.GRUPADIColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private AraclarListesi.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(AraclarListesi.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable2RowChangeEvent : EventArgs
    {
      private AraclarListesi.DataTable2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable2RowChangeEvent(AraclarListesi.DataTable2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable3RowChangeEvent : EventArgs
    {
      private AraclarListesi.DataTable3Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable3RowChangeEvent(AraclarListesi.DataTable3Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable3Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TrafikListesiRowChangeEvent : EventArgs
    {
      private AraclarListesi.TrafikListesiRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TrafikListesiRowChangeEvent(AraclarListesi.TrafikListesiRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.TrafikListesiRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable4RowChangeEvent : EventArgs
    {
      private AraclarListesi.DataTable4Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable4RowChangeEvent(AraclarListesi.DataTable4Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public AraclarListesi.DataTable4Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
