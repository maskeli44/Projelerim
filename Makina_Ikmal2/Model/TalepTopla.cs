// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TalepTopla
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
  [XmlRoot("TalepTopla")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class TalepTopla : DataSet
  {
    private TalepTopla.TBLTALEPTEKNIKSARTDataTable tableTBLTALEPTEKNIKSART;
    private TalepTopla.TBLTEKNIKSARTHRKTDataTable tableTBLTEKNIKSARTHRKT;
    private TalepTopla.TalebiYukleDataTable tableTalebiYukle;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TalepTopla()
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
    protected TalepTopla(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (TBLTALEPTEKNIKSART)] != null)
            base.Tables.Add((DataTable) new TalepTopla.TBLTALEPTEKNIKSARTDataTable(dataSet.Tables[nameof (TBLTALEPTEKNIKSART)]));
          if (dataSet.Tables[nameof (TBLTEKNIKSARTHRKT)] != null)
            base.Tables.Add((DataTable) new TalepTopla.TBLTEKNIKSARTHRKTDataTable(dataSet.Tables[nameof (TBLTEKNIKSARTHRKT)]));
          if (dataSet.Tables[nameof (TalebiYukle)] != null)
            base.Tables.Add((DataTable) new TalepTopla.TalebiYukleDataTable(dataSet.Tables[nameof (TalebiYukle)]));
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
    public TalepTopla.TBLTALEPTEKNIKSARTDataTable TBLTALEPTEKNIKSART => this.tableTBLTALEPTEKNIKSART;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public TalepTopla.TBLTEKNIKSARTHRKTDataTable TBLTEKNIKSARTHRKT => this.tableTBLTEKNIKSARTHRKT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public TalepTopla.TalebiYukleDataTable TalebiYukle => this.tableTalebiYukle;

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
      TalepTopla talepTopla = (TalepTopla) base.Clone();
      talepTopla.InitVars();
      talepTopla.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) talepTopla;
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
        if (dataSet.Tables["TBLTALEPTEKNIKSART"] != null)
          base.Tables.Add((DataTable) new TalepTopla.TBLTALEPTEKNIKSARTDataTable(dataSet.Tables["TBLTALEPTEKNIKSART"]));
        if (dataSet.Tables["TBLTEKNIKSARTHRKT"] != null)
          base.Tables.Add((DataTable) new TalepTopla.TBLTEKNIKSARTHRKTDataTable(dataSet.Tables["TBLTEKNIKSARTHRKT"]));
        if (dataSet.Tables["TalebiYukle"] != null)
          base.Tables.Add((DataTable) new TalepTopla.TalebiYukleDataTable(dataSet.Tables["TalebiYukle"]));
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
      this.tableTBLTALEPTEKNIKSART = (TalepTopla.TBLTALEPTEKNIKSARTDataTable) base.Tables["TBLTALEPTEKNIKSART"];
      if (initTable && this.tableTBLTALEPTEKNIKSART != null)
        this.tableTBLTALEPTEKNIKSART.InitVars();
      this.tableTBLTEKNIKSARTHRKT = (TalepTopla.TBLTEKNIKSARTHRKTDataTable) base.Tables["TBLTEKNIKSARTHRKT"];
      if (initTable && this.tableTBLTEKNIKSARTHRKT != null)
        this.tableTBLTEKNIKSARTHRKT.InitVars();
      this.tableTalebiYukle = (TalepTopla.TalebiYukleDataTable) base.Tables["TalebiYukle"];
      if (!initTable || this.tableTalebiYukle == null)
        return;
      this.tableTalebiYukle.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (TalepTopla);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/TalepTopla.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableTBLTALEPTEKNIKSART = new TalepTopla.TBLTALEPTEKNIKSARTDataTable();
      base.Tables.Add((DataTable) this.tableTBLTALEPTEKNIKSART);
      this.tableTBLTEKNIKSARTHRKT = new TalepTopla.TBLTEKNIKSARTHRKTDataTable();
      base.Tables.Add((DataTable) this.tableTBLTEKNIKSARTHRKT);
      this.tableTalebiYukle = new TalepTopla.TalebiYukleDataTable();
      base.Tables.Add((DataTable) this.tableTalebiYukle);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private bool ShouldSerializeTBLTALEPTEKNIKSART() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private bool ShouldSerializeTBLTEKNIKSARTHRKT() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private bool ShouldSerializeTalebiYukle() => false;

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
      TalepTopla talepTopla = new TalepTopla();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = talepTopla.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = talepTopla.GetSchemaSerializable();
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
    public delegate void TBLTALEPTEKNIKSARTRowChangeEventHandler(
      object sender,
      TalepTopla.TBLTALEPTEKNIKSARTRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public delegate void TBLTEKNIKSARTHRKTRowChangeEventHandler(
      object sender,
      TalepTopla.TBLTEKNIKSARTHRKTRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public delegate void TalebiYukleRowChangeEventHandler(
      object sender,
      TalepTopla.TalebiYukleRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TBLTALEPTEKNIKSARTDataTable : TypedTableBase<TalepTopla.TBLTALEPTEKNIKSARTRow>
    {
      private DataColumn columnSIRANO;
      private DataColumn columnACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TBLTALEPTEKNIKSARTDataTable()
      {
        this.TableName = "TBLTALEPTEKNIKSART";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TBLTALEPTEKNIKSARTDataTable(DataTable table)
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
      protected TBLTALEPTEKNIKSARTDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn SIRANOColumn => this.columnSIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn ACIKLAMAColumn => this.columnACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTALEPTEKNIKSARTRow this[int index] => (TalepTopla.TBLTALEPTEKNIKSARTRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTALEPTEKNIKSARTRowChangeEventHandler TBLTALEPTEKNIKSARTRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTALEPTEKNIKSARTRowChangeEventHandler TBLTALEPTEKNIKSARTRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTALEPTEKNIKSARTRowChangeEventHandler TBLTALEPTEKNIKSARTRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTALEPTEKNIKSARTRowChangeEventHandler TBLTALEPTEKNIKSARTRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void AddTBLTALEPTEKNIKSARTRow(TalepTopla.TBLTALEPTEKNIKSARTRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTALEPTEKNIKSARTRow AddTBLTALEPTEKNIKSARTRow(
        string SIRANO,
        string ACIKLAMA)
      {
        TalepTopla.TBLTALEPTEKNIKSARTRow row = (TalepTopla.TBLTALEPTEKNIKSARTRow) this.NewRow();
        object[] objArray = new object[2]
        {
          (object) SIRANO,
          (object) ACIKLAMA
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public override DataTable Clone()
      {
        TalepTopla.TBLTALEPTEKNIKSARTDataTable tbltaleptekniksartDataTable = (TalepTopla.TBLTALEPTEKNIKSARTDataTable) base.Clone();
        tbltaleptekniksartDataTable.InitVars();
        return (DataTable) tbltaleptekniksartDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepTopla.TBLTALEPTEKNIKSARTDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal void InitVars()
      {
        this.columnSIRANO = this.Columns["SIRANO"];
        this.columnACIKLAMA = this.Columns["ACIKLAMA"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      private void InitClass()
      {
        this.columnSIRANO = new DataColumn("SIRANO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSIRANO);
        this.columnACIKLAMA = new DataColumn("ACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnACIKLAMA);
        this.columnSIRANO.MaxLength = 50;
        this.columnACIKLAMA.MaxLength = 250;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTALEPTEKNIKSARTRow NewTBLTALEPTEKNIKSARTRow() => (TalepTopla.TBLTALEPTEKNIKSARTRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepTopla.TBLTALEPTEKNIKSARTRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override Type GetRowType() => typeof (TalepTopla.TBLTALEPTEKNIKSARTRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLTALEPTEKNIKSARTRowChanged == null)
          return;
        this.TBLTALEPTEKNIKSARTRowChanged((object) this, new TalepTopla.TBLTALEPTEKNIKSARTRowChangeEvent((TalepTopla.TBLTALEPTEKNIKSARTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLTALEPTEKNIKSARTRowChanging == null)
          return;
        this.TBLTALEPTEKNIKSARTRowChanging((object) this, new TalepTopla.TBLTALEPTEKNIKSARTRowChangeEvent((TalepTopla.TBLTALEPTEKNIKSARTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLTALEPTEKNIKSARTRowDeleted == null)
          return;
        this.TBLTALEPTEKNIKSARTRowDeleted((object) this, new TalepTopla.TBLTALEPTEKNIKSARTRowChangeEvent((TalepTopla.TBLTALEPTEKNIKSARTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLTALEPTEKNIKSARTRowDeleting == null)
          return;
        this.TBLTALEPTEKNIKSARTRowDeleting((object) this, new TalepTopla.TBLTALEPTEKNIKSARTRowChangeEvent((TalepTopla.TBLTALEPTEKNIKSARTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void RemoveTBLTALEPTEKNIKSARTRow(TalepTopla.TBLTALEPTEKNIKSARTRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepTopla talepTopla = new TalepTopla();
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
          FixedValue = talepTopla.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLTALEPTEKNIKSARTDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepTopla.GetSchemaSerializable();
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
    public class TBLTEKNIKSARTHRKTDataTable : TypedTableBase<TalepTopla.TBLTEKNIKSARTHRKTRow>
    {
      private DataColumn columnSIRANO;
      private DataColumn columnACIKLAMA;
      private DataColumn columnDURUM;
      private DataColumn columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TBLTEKNIKSARTHRKTDataTable()
      {
        this.TableName = "TBLTEKNIKSARTHRKT";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TBLTEKNIKSARTHRKTDataTable(DataTable table)
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
      protected TBLTEKNIKSARTHRKTDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn SIRANOColumn => this.columnSIRANO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn ACIKLAMAColumn => this.columnACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn DURUMColumn => this.columnDURUM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTEKNIKSARTHRKTRow this[int index] => (TalepTopla.TBLTEKNIKSARTHRKTRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTEKNIKSARTHRKTRowChangeEventHandler TBLTEKNIKSARTHRKTRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTEKNIKSARTHRKTRowChangeEventHandler TBLTEKNIKSARTHRKTRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTEKNIKSARTHRKTRowChangeEventHandler TBLTEKNIKSARTHRKTRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TBLTEKNIKSARTHRKTRowChangeEventHandler TBLTEKNIKSARTHRKTRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void AddTBLTEKNIKSARTHRKTRow(TalepTopla.TBLTEKNIKSARTHRKTRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTEKNIKSARTHRKTRow AddTBLTEKNIKSARTHRKTRow(
        int SIRANO,
        string ACIKLAMA,
        string DURUM)
      {
        TalepTopla.TBLTEKNIKSARTHRKTRow row = (TalepTopla.TBLTEKNIKSARTHRKTRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) SIRANO,
          (object) ACIKLAMA,
          (object) DURUM,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTEKNIKSARTHRKTRow FindByID(int ID) => (TalepTopla.TBLTEKNIKSARTHRKTRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public override DataTable Clone()
      {
        TalepTopla.TBLTEKNIKSARTHRKTDataTable tbltekniksarthrktDataTable = (TalepTopla.TBLTEKNIKSARTHRKTDataTable) base.Clone();
        tbltekniksarthrktDataTable.InitVars();
        return (DataTable) tbltekniksarthrktDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepTopla.TBLTEKNIKSARTHRKTDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal void InitVars()
      {
        this.columnSIRANO = this.Columns["SIRANO"];
        this.columnACIKLAMA = this.Columns["ACIKLAMA"];
        this.columnDURUM = this.Columns["DURUM"];
        this.columnID = this.Columns["ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      private void InitClass()
      {
        this.columnSIRANO = new DataColumn("SIRANO", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSIRANO);
        this.columnACIKLAMA = new DataColumn("ACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnACIKLAMA);
        this.columnDURUM = new DataColumn("DURUM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDURUM);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnACIKLAMA.MaxLength = 300;
        this.columnDURUM.MaxLength = 50;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTEKNIKSARTHRKTRow NewTBLTEKNIKSARTHRKTRow() => (TalepTopla.TBLTEKNIKSARTHRKTRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepTopla.TBLTEKNIKSARTHRKTRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override Type GetRowType() => typeof (TalepTopla.TBLTEKNIKSARTHRKTRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TBLTEKNIKSARTHRKTRowChanged == null)
          return;
        this.TBLTEKNIKSARTHRKTRowChanged((object) this, new TalepTopla.TBLTEKNIKSARTHRKTRowChangeEvent((TalepTopla.TBLTEKNIKSARTHRKTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TBLTEKNIKSARTHRKTRowChanging == null)
          return;
        this.TBLTEKNIKSARTHRKTRowChanging((object) this, new TalepTopla.TBLTEKNIKSARTHRKTRowChangeEvent((TalepTopla.TBLTEKNIKSARTHRKTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TBLTEKNIKSARTHRKTRowDeleted == null)
          return;
        this.TBLTEKNIKSARTHRKTRowDeleted((object) this, new TalepTopla.TBLTEKNIKSARTHRKTRowChangeEvent((TalepTopla.TBLTEKNIKSARTHRKTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TBLTEKNIKSARTHRKTRowDeleting == null)
          return;
        this.TBLTEKNIKSARTHRKTRowDeleting((object) this, new TalepTopla.TBLTEKNIKSARTHRKTRowChangeEvent((TalepTopla.TBLTEKNIKSARTHRKTRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void RemoveTBLTEKNIKSARTHRKTRow(TalepTopla.TBLTEKNIKSARTHRKTRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepTopla talepTopla = new TalepTopla();
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
          FixedValue = talepTopla.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TBLTEKNIKSARTHRKTDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepTopla.GetSchemaSerializable();
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
    public class TalebiYukleDataTable : TypedTableBase<TalepTopla.TalebiYukleRow>
    {
      private DataColumn columnTarih;
      private DataColumn columnSayı;
      private DataColumn columnKonu;
      private DataColumn columnKOD;
      private DataColumn columnTekif;
      private DataColumn columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalebiYukleDataTable()
      {
        this.TableName = "TalebiYukle";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TalebiYukleDataTable(DataTable table)
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
      protected TalebiYukleDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn TarihColumn => this.columnTarih;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn SayıColumn => this.columnSayı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn KonuColumn => this.columnKonu;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn TekifColumn => this.columnTekif;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TalebiYukleRow this[int index] => (TalepTopla.TalebiYukleRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TalebiYukleRowChangeEventHandler TalebiYukleRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TalebiYukleRowChangeEventHandler TalebiYukleRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TalebiYukleRowChangeEventHandler TalebiYukleRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public event TalepTopla.TalebiYukleRowChangeEventHandler TalebiYukleRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void AddTalebiYukleRow(TalepTopla.TalebiYukleRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TalebiYukleRow AddTalebiYukleRow(
        DateTime Tarih,
        string Sayı,
        string Konu,
        string KOD,
        string Tekif)
      {
        TalepTopla.TalebiYukleRow row = (TalepTopla.TalebiYukleRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) Tarih,
          (object) Sayı,
          (object) Konu,
          (object) KOD,
          (object) Tekif,
          null
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TalebiYukleRow FindByID(int ID) => (TalepTopla.TalebiYukleRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public override DataTable Clone()
      {
        TalepTopla.TalebiYukleDataTable talebiYukleDataTable = (TalepTopla.TalebiYukleDataTable) base.Clone();
        talebiYukleDataTable.InitVars();
        return (DataTable) talebiYukleDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepTopla.TalebiYukleDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal void InitVars()
      {
        this.columnTarih = this.Columns["Tarih"];
        this.columnSayı = this.Columns["Sayı"];
        this.columnKonu = this.Columns["Konu"];
        this.columnKOD = this.Columns["KOD"];
        this.columnTekif = this.Columns["Tekif"];
        this.columnID = this.Columns["ID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      private void InitClass()
      {
        this.columnTarih = new DataColumn("Tarih", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTarih);
        this.columnSayı = new DataColumn("Sayı", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSayı);
        this.columnKonu = new DataColumn("Konu", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKonu);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnTekif = new DataColumn("Tekif", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTekif);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnSayı.MaxLength = 50;
        this.columnKonu.MaxLength = 50;
        this.columnKOD.MaxLength = 50;
        this.columnTekif.MaxLength = 50;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TalebiYukleRow NewTalebiYukleRow() => (TalepTopla.TalebiYukleRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepTopla.TalebiYukleRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override Type GetRowType() => typeof (TalepTopla.TalebiYukleRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TalebiYukleRowChanged == null)
          return;
        this.TalebiYukleRowChanged((object) this, new TalepTopla.TalebiYukleRowChangeEvent((TalepTopla.TalebiYukleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TalebiYukleRowChanging == null)
          return;
        this.TalebiYukleRowChanging((object) this, new TalepTopla.TalebiYukleRowChangeEvent((TalepTopla.TalebiYukleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TalebiYukleRowDeleted == null)
          return;
        this.TalebiYukleRowDeleted((object) this, new TalepTopla.TalebiYukleRowChangeEvent((TalepTopla.TalebiYukleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TalebiYukleRowDeleting == null)
          return;
        this.TalebiYukleRowDeleting((object) this, new TalepTopla.TalebiYukleRowChangeEvent((TalepTopla.TalebiYukleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void RemoveTalebiYukleRow(TalepTopla.TalebiYukleRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepTopla talepTopla = new TalepTopla();
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
          FixedValue = talepTopla.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TalebiYukleDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepTopla.GetSchemaSerializable();
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

    public class TBLTALEPTEKNIKSARTRow : DataRow
    {
      private TalepTopla.TBLTALEPTEKNIKSARTDataTable tableTBLTALEPTEKNIKSART;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TBLTALEPTEKNIKSARTRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLTALEPTEKNIKSART = (TalepTopla.TBLTALEPTEKNIKSARTDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string SIRANO
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLTALEPTEKNIKSART.SIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLTALEPTEKNIKSART' tablosundaki 'SIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLTALEPTEKNIKSART.SIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string ACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLTALEPTEKNIKSART.ACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLTALEPTEKNIKSART' tablosundaki 'ACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLTALEPTEKNIKSART.ACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsSIRANONull() => this.IsNull(this.tableTBLTALEPTEKNIKSART.SIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetSIRANONull() => this[this.tableTBLTALEPTEKNIKSART.SIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsACIKLAMANull() => this.IsNull(this.tableTBLTALEPTEKNIKSART.ACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetACIKLAMANull() => this[this.tableTBLTALEPTEKNIKSART.ACIKLAMAColumn] = Convert.DBNull;
    }

    public class TBLTEKNIKSARTHRKTRow : DataRow
    {
      private TalepTopla.TBLTEKNIKSARTHRKTDataTable tableTBLTEKNIKSARTHRKT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TBLTEKNIKSARTHRKTRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTBLTEKNIKSARTHRKT = (TalepTopla.TBLTEKNIKSARTHRKTDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int SIRANO
      {
        get
        {
          try
          {
            return (int) this[this.tableTBLTEKNIKSARTHRKT.SIRANOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLTEKNIKSARTHRKT' tablosundaki 'SIRANO' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLTEKNIKSARTHRKT.SIRANOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string ACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLTEKNIKSARTHRKT.ACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLTEKNIKSARTHRKT' tablosundaki 'ACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLTEKNIKSARTHRKT.ACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string DURUM
      {
        get
        {
          try
          {
            return (string) this[this.tableTBLTEKNIKSARTHRKT.DURUMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TBLTEKNIKSARTHRKT' tablosundaki 'DURUM' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTBLTEKNIKSARTHRKT.DURUMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTBLTEKNIKSARTHRKT.IDColumn];
        set => this[this.tableTBLTEKNIKSARTHRKT.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsSIRANONull() => this.IsNull(this.tableTBLTEKNIKSARTHRKT.SIRANOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetSIRANONull() => this[this.tableTBLTEKNIKSARTHRKT.SIRANOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsACIKLAMANull() => this.IsNull(this.tableTBLTEKNIKSARTHRKT.ACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetACIKLAMANull() => this[this.tableTBLTEKNIKSARTHRKT.ACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsDURUMNull() => this.IsNull(this.tableTBLTEKNIKSARTHRKT.DURUMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetDURUMNull() => this[this.tableTBLTEKNIKSARTHRKT.DURUMColumn] = Convert.DBNull;
    }

    public class TalebiYukleRow : DataRow
    {
      private TalepTopla.TalebiYukleDataTable tableTalebiYukle;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      internal TalebiYukleRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTalebiYukle = (TalepTopla.TalebiYukleDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DateTime Tarih
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableTalebiYukle.TarihColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalebiYukle' tablosundaki 'Tarih' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalebiYukle.TarihColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string Sayı
      {
        get
        {
          try
          {
            return (string) this[this.tableTalebiYukle.SayıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalebiYukle' tablosundaki 'Sayı' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalebiYukle.SayıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string Konu
      {
        get
        {
          try
          {
            return (string) this[this.tableTalebiYukle.KonuColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalebiYukle' tablosundaki 'Konu' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalebiYukle.KonuColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableTalebiYukle.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalebiYukle' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalebiYukle.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public string Tekif
      {
        get
        {
          try
          {
            return (string) this[this.tableTalebiYukle.TekifColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalebiYukle' tablosundaki 'Tekif' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalebiYukle.TekifColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTalebiYukle.IDColumn];
        set => this[this.tableTalebiYukle.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsTarihNull() => this.IsNull(this.tableTalebiYukle.TarihColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetTarihNull() => this[this.tableTalebiYukle.TarihColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsSayıNull() => this.IsNull(this.tableTalebiYukle.SayıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetSayıNull() => this[this.tableTalebiYukle.SayıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsKonuNull() => this.IsNull(this.tableTalebiYukle.KonuColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetKonuNull() => this[this.tableTalebiYukle.KonuColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableTalebiYukle.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetKODNull() => this[this.tableTalebiYukle.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public bool IsTekifNull() => this.IsNull(this.tableTalebiYukle.TekifColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public void SetTekifNull() => this[this.tableTalebiYukle.TekifColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public class TBLTALEPTEKNIKSARTRowChangeEvent : EventArgs
    {
      private TalepTopla.TBLTALEPTEKNIKSARTRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TBLTALEPTEKNIKSARTRowChangeEvent(
        TalepTopla.TBLTALEPTEKNIKSARTRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTALEPTEKNIKSARTRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public class TBLTEKNIKSARTHRKTRowChangeEvent : EventArgs
    {
      private TalepTopla.TBLTEKNIKSARTHRKTRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TBLTEKNIKSARTHRKTRowChangeEvent(
        TalepTopla.TBLTEKNIKSARTHRKTRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TBLTEKNIKSARTHRKTRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public class TalebiYukleRowChangeEvent : EventArgs
    {
      private TalepTopla.TalebiYukleRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalebiYukleRowChangeEvent(TalepTopla.TalebiYukleRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public TalepTopla.TalebiYukleRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
