// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.TalepKayitTabloCek
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
  [XmlRoot("TalepKayitTabloCek")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class TalepKayitTabloCek : DataSet
  {
    private TalepKayitTabloCek.DataTable1DataTable tableDataTable1;
    private TalepKayitTabloCek.DataTable2DataTable tableDataTable2;
    private TalepKayitTabloCek.TalepToplamlariCekDataTable tableTalepToplamlariCek;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TalepKayitTabloCek()
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
    protected TalepKayitTabloCek(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new TalepKayitTabloCek.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
          if (dataSet.Tables[nameof (DataTable2)] != null)
            base.Tables.Add((DataTable) new TalepKayitTabloCek.DataTable2DataTable(dataSet.Tables[nameof (DataTable2)]));
          if (dataSet.Tables[nameof (TalepToplamlariCek)] != null)
            base.Tables.Add((DataTable) new TalepKayitTabloCek.TalepToplamlariCekDataTable(dataSet.Tables[nameof (TalepToplamlariCek)]));
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
    public TalepKayitTabloCek.DataTable1DataTable DataTable1 => this.tableDataTable1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public TalepKayitTabloCek.DataTable2DataTable DataTable2 => this.tableDataTable2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public TalepKayitTabloCek.TalepToplamlariCekDataTable TalepToplamlariCek => this.tableTalepToplamlariCek;

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
      TalepKayitTabloCek talepKayitTabloCek = (TalepKayitTabloCek) base.Clone();
      talepKayitTabloCek.InitVars();
      talepKayitTabloCek.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) talepKayitTabloCek;
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
          base.Tables.Add((DataTable) new TalepKayitTabloCek.DataTable1DataTable(dataSet.Tables["DataTable1"]));
        if (dataSet.Tables["DataTable2"] != null)
          base.Tables.Add((DataTable) new TalepKayitTabloCek.DataTable2DataTable(dataSet.Tables["DataTable2"]));
        if (dataSet.Tables["TalepToplamlariCek"] != null)
          base.Tables.Add((DataTable) new TalepKayitTabloCek.TalepToplamlariCekDataTable(dataSet.Tables["TalepToplamlariCek"]));
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
      this.tableDataTable1 = (TalepKayitTabloCek.DataTable1DataTable) base.Tables["DataTable1"];
      if (initTable && this.tableDataTable1 != null)
        this.tableDataTable1.InitVars();
      this.tableDataTable2 = (TalepKayitTabloCek.DataTable2DataTable) base.Tables["DataTable2"];
      if (initTable && this.tableDataTable2 != null)
        this.tableDataTable2.InitVars();
      this.tableTalepToplamlariCek = (TalepKayitTabloCek.TalepToplamlariCekDataTable) base.Tables["TalepToplamlariCek"];
      if (!initTable || this.tableTalepToplamlariCek == null)
        return;
      this.tableTalepToplamlariCek.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (TalepKayitTabloCek);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/TalepKayitTabloCek.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new TalepKayitTabloCek.DataTable1DataTable();
      base.Tables.Add((DataTable) this.tableDataTable1);
      this.tableDataTable2 = new TalepKayitTabloCek.DataTable2DataTable();
      base.Tables.Add((DataTable) this.tableDataTable2);
      this.tableTalepToplamlariCek = new TalepKayitTabloCek.TalepToplamlariCekDataTable();
      base.Tables.Add((DataTable) this.tableTalepToplamlariCek);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable1() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeDataTable2() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeTalepToplamlariCek() => false;

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
      TalepKayitTabloCek talepKayitTabloCek = new TalepKayitTabloCek();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = talepKayitTabloCek.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = talepKayitTabloCek.GetSchemaSerializable();
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
      TalepKayitTabloCek.DataTable1RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void DataTable2RowChangeEventHandler(
      object sender,
      TalepKayitTabloCek.DataTable2RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void TalepToplamlariCekRowChangeEventHandler(
      object sender,
      TalepKayitTabloCek.TalepToplamlariCekRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<TalepKayitTabloCek.DataTable1Row>
    {
      private DataColumn columnISEMRIID;
      private DataColumn columnKOD;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnMALZACIKLAMA;
      private DataColumn columnPLAKA;
      private DataColumn columnMIKTAR;
      private DataColumn columnFIYAT;
      private DataColumn columnTUTAR;
      private DataColumn columnTALEPFISID;

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
      public DataColumn ISEMRIIDColumn => this.columnISEMRIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZACIKLAMAColumn => this.columnMALZACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIYATColumn => this.columnFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TUTARColumn => this.columnTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPFISIDColumn => this.columnTALEPFISID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable1Row this[int index] => (TalepKayitTabloCek.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(TalepKayitTabloCek.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable1Row AddDataTable1Row(
        int ISEMRIID,
        string KOD,
        string MALZEMEADI,
        string MALZACIKLAMA,
        string PLAKA,
        Decimal MIKTAR,
        Decimal FIYAT,
        Decimal TUTAR,
        int TALEPFISID)
      {
        TalepKayitTabloCek.DataTable1Row row = (TalepKayitTabloCek.DataTable1Row) this.NewRow();
        object[] objArray = new object[9]
        {
          (object) ISEMRIID,
          (object) KOD,
          (object) MALZEMEADI,
          (object) MALZACIKLAMA,
          (object) PLAKA,
          (object) MIKTAR,
          (object) FIYAT,
          (object) TUTAR,
          (object) TALEPFISID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        TalepKayitTabloCek.DataTable1DataTable dataTable1DataTable = (TalepKayitTabloCek.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepKayitTabloCek.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnISEMRIID = this.Columns["ISEMRIID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnMALZACIKLAMA = this.Columns["MALZACIKLAMA"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnFIYAT = this.Columns["FIYAT"];
        this.columnTUTAR = this.Columns["TUTAR"];
        this.columnTALEPFISID = this.Columns["TALEPFISID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnISEMRIID = new DataColumn("ISEMRIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRIID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnMALZACIKLAMA = new DataColumn("MALZACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZACIKLAMA);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnFIYAT = new DataColumn("FIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIYAT);
        this.columnTUTAR = new DataColumn("TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTUTAR);
        this.columnTALEPFISID = new DataColumn("TALEPFISID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPFISID);
        this.columnKOD.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMALZACIKLAMA.MaxLength = 150;
        this.columnPLAKA.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable1Row NewDataTable1Row() => (TalepKayitTabloCek.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepKayitTabloCek.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (TalepKayitTabloCek.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new TalepKayitTabloCek.DataTable1RowChangeEvent((TalepKayitTabloCek.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new TalepKayitTabloCek.DataTable1RowChangeEvent((TalepKayitTabloCek.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new TalepKayitTabloCek.DataTable1RowChangeEvent((TalepKayitTabloCek.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new TalepKayitTabloCek.DataTable1RowChangeEvent((TalepKayitTabloCek.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(TalepKayitTabloCek.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepKayitTabloCek talepKayitTabloCek = new TalepKayitTabloCek();
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
          FixedValue = talepKayitTabloCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepKayitTabloCek.GetSchemaSerializable();
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
    public class DataTable2DataTable : TypedTableBase<TalepKayitTabloCek.DataTable2Row>
    {
      private DataColumn columnISEMRIID;
      private DataColumn columnKOD;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnMALZACIKLAMA;
      private DataColumn columnPLAKA;
      private DataColumn columnMIKTAR;
      private DataColumn columnFIYAT;
      private DataColumn columnTUTAR;
      private DataColumn columnTALEPFISID;
      private DataColumn columnTALEPKAYITID;
      private DataColumn columnBIRIMADI;

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
      public DataColumn ISEMRIIDColumn => this.columnISEMRIID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZACIKLAMAColumn => this.columnMALZACIKLAMA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FIYATColumn => this.columnFIYAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TUTARColumn => this.columnTUTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPFISIDColumn => this.columnTALEPFISID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TALEPKAYITIDColumn => this.columnTALEPKAYITID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable2Row this[int index] => (TalepKayitTabloCek.DataTable2Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable2RowChangeEventHandler DataTable2RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable2RowChangeEventHandler DataTable2RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable2RowChangeEventHandler DataTable2RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.DataTable2RowChangeEventHandler DataTable2RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable2Row(TalepKayitTabloCek.DataTable2Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable2Row AddDataTable2Row(
        int ISEMRIID,
        string KOD,
        string MALZEMEADI,
        string MALZACIKLAMA,
        string PLAKA,
        Decimal MIKTAR,
        Decimal FIYAT,
        Decimal TUTAR,
        int TALEPFISID,
        int TALEPKAYITID,
        string BIRIMADI)
      {
        TalepKayitTabloCek.DataTable2Row row = (TalepKayitTabloCek.DataTable2Row) this.NewRow();
        object[] objArray = new object[11]
        {
          (object) ISEMRIID,
          (object) KOD,
          (object) MALZEMEADI,
          (object) MALZACIKLAMA,
          (object) PLAKA,
          (object) MIKTAR,
          (object) FIYAT,
          (object) TUTAR,
          (object) TALEPFISID,
          (object) TALEPKAYITID,
          (object) BIRIMADI
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        TalepKayitTabloCek.DataTable2DataTable dataTable2DataTable = (TalepKayitTabloCek.DataTable2DataTable) base.Clone();
        dataTable2DataTable.InitVars();
        return (DataTable) dataTable2DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepKayitTabloCek.DataTable2DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnISEMRIID = this.Columns["ISEMRIID"];
        this.columnKOD = this.Columns["KOD"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnMALZACIKLAMA = this.Columns["MALZACIKLAMA"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
        this.columnFIYAT = this.Columns["FIYAT"];
        this.columnTUTAR = this.Columns["TUTAR"];
        this.columnTALEPFISID = this.Columns["TALEPFISID"];
        this.columnTALEPKAYITID = this.Columns["TALEPKAYITID"];
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnISEMRIID = new DataColumn("ISEMRIID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISEMRIID);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnMALZACIKLAMA = new DataColumn("MALZACIKLAMA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZACIKLAMA);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.columnFIYAT = new DataColumn("FIYAT", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFIYAT);
        this.columnTUTAR = new DataColumn("TUTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTUTAR);
        this.columnTALEPFISID = new DataColumn("TALEPFISID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPFISID);
        this.columnTALEPKAYITID = new DataColumn("TALEPKAYITID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTALEPKAYITID);
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnKOD.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnMALZACIKLAMA.MaxLength = 150;
        this.columnPLAKA.MaxLength = 50;
        this.columnBIRIMADI.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable2Row NewDataTable2Row() => (TalepKayitTabloCek.DataTable2Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepKayitTabloCek.DataTable2Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (TalepKayitTabloCek.DataTable2Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable2RowChanged == null)
          return;
        this.DataTable2RowChanged((object) this, new TalepKayitTabloCek.DataTable2RowChangeEvent((TalepKayitTabloCek.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable2RowChanging == null)
          return;
        this.DataTable2RowChanging((object) this, new TalepKayitTabloCek.DataTable2RowChangeEvent((TalepKayitTabloCek.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable2RowDeleted == null)
          return;
        this.DataTable2RowDeleted((object) this, new TalepKayitTabloCek.DataTable2RowChangeEvent((TalepKayitTabloCek.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable2RowDeleting == null)
          return;
        this.DataTable2RowDeleting((object) this, new TalepKayitTabloCek.DataTable2RowChangeEvent((TalepKayitTabloCek.DataTable2Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable2Row(TalepKayitTabloCek.DataTable2Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepKayitTabloCek talepKayitTabloCek = new TalepKayitTabloCek();
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
          FixedValue = talepKayitTabloCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable2DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepKayitTabloCek.GetSchemaSerializable();
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
    public class TalepToplamlariCekDataTable : 
      TypedTableBase<TalepKayitTabloCek.TalepToplamlariCekRow>
    {
      private DataColumn columnMALZEMEADI;
      private DataColumn columnID;
      private DataColumn columnBIRIMADI;
      private DataColumn columnMALZEMEGRUP;
      private DataColumn columnBOLUMADI;
      private DataColumn columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepToplamlariCekDataTable()
      {
        this.TableName = "TalepToplamlariCek";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TalepToplamlariCekDataTable(DataTable table)
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
      protected TalepToplamlariCekDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEGRUPColumn => this.columnMALZEMEGRUP;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BOLUMADIColumn => this.columnBOLUMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MIKTARColumn => this.columnMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.TalepToplamlariCekRow this[int index] => (TalepKayitTabloCek.TalepToplamlariCekRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.TalepToplamlariCekRowChangeEventHandler TalepToplamlariCekRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.TalepToplamlariCekRowChangeEventHandler TalepToplamlariCekRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.TalepToplamlariCekRowChangeEventHandler TalepToplamlariCekRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event TalepKayitTabloCek.TalepToplamlariCekRowChangeEventHandler TalepToplamlariCekRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddTalepToplamlariCekRow(TalepKayitTabloCek.TalepToplamlariCekRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.TalepToplamlariCekRow AddTalepToplamlariCekRow(
        string MALZEMEADI,
        string BIRIMADI,
        string MALZEMEGRUP,
        string BOLUMADI,
        Decimal MIKTAR)
      {
        TalepKayitTabloCek.TalepToplamlariCekRow row = (TalepKayitTabloCek.TalepToplamlariCekRow) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) MALZEMEADI,
          null,
          (object) BIRIMADI,
          (object) MALZEMEGRUP,
          (object) BOLUMADI,
          (object) MIKTAR
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.TalepToplamlariCekRow FindByID(int ID) => (TalepKayitTabloCek.TalepToplamlariCekRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        TalepKayitTabloCek.TalepToplamlariCekDataTable toplamlariCekDataTable = (TalepKayitTabloCek.TalepToplamlariCekDataTable) base.Clone();
        toplamlariCekDataTable.InitVars();
        return (DataTable) toplamlariCekDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new TalepKayitTabloCek.TalepToplamlariCekDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnID = this.Columns["ID"];
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
        this.columnMALZEMEGRUP = this.Columns["MALZEMEGRUP"];
        this.columnBOLUMADI = this.Columns["BOLUMADI"];
        this.columnMIKTAR = this.Columns["MIKTAR"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnMALZEMEGRUP = new DataColumn("MALZEMEGRUP", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEGRUP);
        this.columnBOLUMADI = new DataColumn("BOLUMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBOLUMADI);
        this.columnMIKTAR = new DataColumn("MIKTAR", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMIKTAR);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnID.Unique = true;
        this.columnBIRIMADI.MaxLength = 50;
        this.columnMALZEMEGRUP.MaxLength = 50;
        this.columnBOLUMADI.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.TalepToplamlariCekRow NewTalepToplamlariCekRow() => (TalepKayitTabloCek.TalepToplamlariCekRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new TalepKayitTabloCek.TalepToplamlariCekRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (TalepKayitTabloCek.TalepToplamlariCekRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TalepToplamlariCekRowChanged == null)
          return;
        this.TalepToplamlariCekRowChanged((object) this, new TalepKayitTabloCek.TalepToplamlariCekRowChangeEvent((TalepKayitTabloCek.TalepToplamlariCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TalepToplamlariCekRowChanging == null)
          return;
        this.TalepToplamlariCekRowChanging((object) this, new TalepKayitTabloCek.TalepToplamlariCekRowChangeEvent((TalepKayitTabloCek.TalepToplamlariCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TalepToplamlariCekRowDeleted == null)
          return;
        this.TalepToplamlariCekRowDeleted((object) this, new TalepKayitTabloCek.TalepToplamlariCekRowChangeEvent((TalepKayitTabloCek.TalepToplamlariCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TalepToplamlariCekRowDeleting == null)
          return;
        this.TalepToplamlariCekRowDeleting((object) this, new TalepKayitTabloCek.TalepToplamlariCekRowChangeEvent((TalepKayitTabloCek.TalepToplamlariCekRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveTalepToplamlariCekRow(TalepKayitTabloCek.TalepToplamlariCekRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        TalepKayitTabloCek talepKayitTabloCek = new TalepKayitTabloCek();
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
          FixedValue = talepKayitTabloCek.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TalepToplamlariCekDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = talepKayitTabloCek.GetSchemaSerializable();
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
      private TalepKayitTabloCek.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (TalepKayitTabloCek.DataTable1DataTable) this.Table;
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
      public Decimal FIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable1.FIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'FIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FIYATColumn] = (object) value;
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
      public int TALEPFISID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.TALEPFISIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable1' tablosundaki 'TALEPFISID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TALEPFISIDColumn] = (object) value;
      }

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
      public bool IsMALZEMEADINull() => this.IsNull(this.tableDataTable1.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableDataTable1.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZACIKLAMANull() => this.IsNull(this.tableDataTable1.MALZACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZACIKLAMANull() => this[this.tableDataTable1.MALZACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable1.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable1.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableDataTable1.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableDataTable1.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIYATNull() => this.IsNull(this.tableDataTable1.FIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIYATNull() => this[this.tableDataTable1.FIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTUTARNull() => this.IsNull(this.tableDataTable1.TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTUTARNull() => this[this.tableDataTable1.TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPFISIDNull() => this.IsNull(this.tableDataTable1.TALEPFISIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPFISIDNull() => this[this.tableDataTable1.TALEPFISIDColumn] = Convert.DBNull;
    }

    public class DataTable2Row : DataRow
    {
      private TalepKayitTabloCek.DataTable2DataTable tableDataTable2;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable2Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable2 = (TalepKayitTabloCek.DataTable2DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ISEMRIID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.ISEMRIIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'ISEMRIID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.ISEMRIIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'KOD' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZACIKLAMA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.MALZACIKLAMAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'MALZACIKLAMA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.MALZACIKLAMAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'PLAKA' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable2.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal FIYAT
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable2.FIYATColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'FIYAT' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.FIYATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal TUTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableDataTable2.TUTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TUTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TUTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPFISID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.TALEPFISIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TALEPFISID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TALEPFISIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int TALEPKAYITID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable2.TALEPKAYITIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'TALEPKAYITID' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.TALEPKAYITIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable2.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'DataTable2' tablosundaki 'BIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable2.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISEMRIIDNull() => this.IsNull(this.tableDataTable2.ISEMRIIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISEMRIIDNull() => this[this.tableDataTable2.ISEMRIIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableDataTable2.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableDataTable2.KODColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableDataTable2.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableDataTable2.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZACIKLAMANull() => this.IsNull(this.tableDataTable2.MALZACIKLAMAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZACIKLAMANull() => this[this.tableDataTable2.MALZACIKLAMAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableDataTable2.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableDataTable2.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableDataTable2.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableDataTable2.MIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFIYATNull() => this.IsNull(this.tableDataTable2.FIYATColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFIYATNull() => this[this.tableDataTable2.FIYATColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTUTARNull() => this.IsNull(this.tableDataTable2.TUTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTUTARNull() => this[this.tableDataTable2.TUTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPFISIDNull() => this.IsNull(this.tableDataTable2.TALEPFISIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPFISIDNull() => this[this.tableDataTable2.TALEPFISIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTALEPKAYITIDNull() => this.IsNull(this.tableDataTable2.TALEPKAYITIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTALEPKAYITIDNull() => this[this.tableDataTable2.TALEPKAYITIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableDataTable2.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableDataTable2.BIRIMADIColumn] = Convert.DBNull;
    }

    public class TalepToplamlariCekRow : DataRow
    {
      private TalepKayitTabloCek.TalepToplamlariCekDataTable tableTalepToplamlariCek;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal TalepToplamlariCekRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTalepToplamlariCek = (TalepKayitTabloCek.TalepToplamlariCekDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepToplamlariCek.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepToplamlariCek' tablosundaki 'MALZEMEADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepToplamlariCek.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableTalepToplamlariCek.IDColumn];
        set => this[this.tableTalepToplamlariCek.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepToplamlariCek.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepToplamlariCek' tablosundaki 'BIRIMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepToplamlariCek.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEGRUP
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepToplamlariCek.MALZEMEGRUPColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepToplamlariCek' tablosundaki 'MALZEMEGRUP' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepToplamlariCek.MALZEMEGRUPColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BOLUMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableTalepToplamlariCek.BOLUMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepToplamlariCek' tablosundaki 'BOLUMADI' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepToplamlariCek.BOLUMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal MIKTAR
      {
        get
        {
          try
          {
            return (Decimal) this[this.tableTalepToplamlariCek.MIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("'TalepToplamlariCek' tablosundaki 'MIKTAR' sütunun değeri DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTalepToplamlariCek.MIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableTalepToplamlariCek.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableTalepToplamlariCek.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableTalepToplamlariCek.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableTalepToplamlariCek.BIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEGRUPNull() => this.IsNull(this.tableTalepToplamlariCek.MALZEMEGRUPColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEGRUPNull() => this[this.tableTalepToplamlariCek.MALZEMEGRUPColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBOLUMADINull() => this.IsNull(this.tableTalepToplamlariCek.BOLUMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBOLUMADINull() => this[this.tableTalepToplamlariCek.BOLUMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMIKTARNull() => this.IsNull(this.tableTalepToplamlariCek.MIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMIKTARNull() => this[this.tableTalepToplamlariCek.MIKTARColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private TalepKayitTabloCek.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(TalepKayitTabloCek.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable2RowChangeEvent : EventArgs
    {
      private TalepKayitTabloCek.DataTable2Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable2RowChangeEvent(TalepKayitTabloCek.DataTable2Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.DataTable2Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class TalepToplamlariCekRowChangeEvent : EventArgs
    {
      private TalepKayitTabloCek.TalepToplamlariCekRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepToplamlariCekRowChangeEvent(
        TalepKayitTabloCek.TalepToplamlariCekRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public TalepKayitTabloCek.TalepToplamlariCekRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
