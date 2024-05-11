// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MalzemeEksteresi
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
  [XmlRoot("MalzemeEksteresi")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class MalzemeEksteresi : DataSet
  {
    private MalzemeEksteresi.MalzemeEkstresiGetirDataTable tableMalzemeEkstresiGetir;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public MalzemeEksteresi()
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
    protected MalzemeEksteresi(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (MalzemeEkstresiGetir)] != null)
            base.Tables.Add((DataTable) new MalzemeEksteresi.MalzemeEkstresiGetirDataTable(dataSet.Tables[nameof (MalzemeEkstresiGetir)]));
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
    public MalzemeEksteresi.MalzemeEkstresiGetirDataTable MalzemeEkstresiGetir => this.tableMalzemeEkstresiGetir;

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
      MalzemeEksteresi malzemeEksteresi = (MalzemeEksteresi) base.Clone();
      malzemeEksteresi.InitVars();
      malzemeEksteresi.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) malzemeEksteresi;
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
        if (dataSet.Tables["MalzemeEkstresiGetir"] != null)
          base.Tables.Add((DataTable) new MalzemeEksteresi.MalzemeEkstresiGetirDataTable(dataSet.Tables["MalzemeEkstresiGetir"]));
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
      this.tableMalzemeEkstresiGetir = (MalzemeEksteresi.MalzemeEkstresiGetirDataTable) base.Tables["MalzemeEkstresiGetir"];
      if (!initTable || this.tableMalzemeEkstresiGetir == null)
        return;
      this.tableMalzemeEkstresiGetir.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (MalzemeEksteresi);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/MalzemeEksteresi.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableMalzemeEkstresiGetir = new MalzemeEksteresi.MalzemeEkstresiGetirDataTable();
      base.Tables.Add((DataTable) this.tableMalzemeEkstresiGetir);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializeMalzemeEkstresiGetir() => false;

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
      MalzemeEksteresi malzemeEksteresi = new MalzemeEksteresi();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = malzemeEksteresi.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = malzemeEksteresi.GetSchemaSerializable();
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
    public delegate void MalzemeEkstresiGetirRowChangeEventHandler(
      object sender,
      MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class MalzemeEkstresiGetirDataTable : 
      TypedTableBase<MalzemeEksteresi.MalzemeEkstresiGetirRow>
    {
      private DataColumn columnISLEMTIPI;
      private DataColumn columnPLAKA;
      private DataColumn columnMALZEMEADI;
      private DataColumn columnBIRIMADI;
      private DataColumn columnGIRISMIKTAR;
      private DataColumn columnCIKISMIKTAR;
      private DataColumn columnDEGISIMKMSI;
      private DataColumn columnDEPOADI;
      private DataColumn columnID;
      private DataColumn columnMalzeme_ID;
      private DataColumn columnMALZURTTARIH;
      private DataColumn columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiGetirDataTable()
      {
        this.TableName = "MalzemeEkstresiGetir";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal MalzemeEkstresiGetirDataTable(DataTable table)
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
      protected MalzemeEkstresiGetirDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ISLEMTIPIColumn => this.columnISLEMTIPI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PLAKAColumn => this.columnPLAKA;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZEMEADIColumn => this.columnMALZEMEADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMADIColumn => this.columnBIRIMADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISMIKTARColumn => this.columnGIRISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISMIKTARColumn => this.columnCIKISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEGISIMKMSIColumn => this.columnDEGISIMKMSI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEPOADIColumn => this.columnDEPOADI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn IDColumn => this.columnID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Malzeme_IDColumn => this.columnMalzeme_ID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZURTTARIHColumn => this.columnMALZURTTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn KODColumn => this.columnKOD;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEksteresi.MalzemeEkstresiGetirRow this[int index] => (MalzemeEksteresi.MalzemeEkstresiGetirRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEventHandler MalzemeEkstresiGetirRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEventHandler MalzemeEkstresiGetirRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEventHandler MalzemeEkstresiGetirRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEventHandler MalzemeEkstresiGetirRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddMalzemeEkstresiGetirRow(MalzemeEksteresi.MalzemeEkstresiGetirRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEksteresi.MalzemeEkstresiGetirRow AddMalzemeEkstresiGetirRow(
        string ISLEMTIPI,
        string PLAKA,
        string MALZEMEADI,
        string BIRIMADI,
        string GIRISMIKTAR,
        string CIKISMIKTAR,
        string DEGISIMKMSI,
        string DEPOADI,
        string MALZURTTARIH,
        string KOD)
      {
        MalzemeEksteresi.MalzemeEkstresiGetirRow row = (MalzemeEksteresi.MalzemeEkstresiGetirRow) this.NewRow();
        object[] objArray = new object[12]
        {
          (object) ISLEMTIPI,
          (object) PLAKA,
          (object) MALZEMEADI,
          (object) BIRIMADI,
          (object) GIRISMIKTAR,
          (object) CIKISMIKTAR,
          (object) DEGISIMKMSI,
          (object) DEPOADI,
          null,
          null,
          (object) MALZURTTARIH,
          (object) KOD
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        MalzemeEksteresi.MalzemeEkstresiGetirDataTable ekstresiGetirDataTable = (MalzemeEksteresi.MalzemeEkstresiGetirDataTable) base.Clone();
        ekstresiGetirDataTable.InitVars();
        return (DataTable) ekstresiGetirDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new MalzemeEksteresi.MalzemeEkstresiGetirDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnISLEMTIPI = this.Columns["ISLEMTIPI"];
        this.columnPLAKA = this.Columns["PLAKA"];
        this.columnMALZEMEADI = this.Columns["MALZEMEADI"];
        this.columnBIRIMADI = this.Columns["BIRIMADI"];
        this.columnGIRISMIKTAR = this.Columns["GIRISMIKTAR"];
        this.columnCIKISMIKTAR = this.Columns["CIKISMIKTAR"];
        this.columnDEGISIMKMSI = this.Columns["DEGISIMKMSI"];
        this.columnDEPOADI = this.Columns["DEPOADI"];
        this.columnID = this.Columns["ID"];
        this.columnMalzeme_ID = this.Columns["Malzeme ID"];
        this.columnMALZURTTARIH = this.Columns["MALZURTTARIH"];
        this.columnKOD = this.Columns["KOD"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnISLEMTIPI = new DataColumn("ISLEMTIPI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnISLEMTIPI);
        this.columnPLAKA = new DataColumn("PLAKA", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPLAKA);
        this.columnMALZEMEADI = new DataColumn("MALZEMEADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZEMEADI);
        this.columnBIRIMADI = new DataColumn("BIRIMADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMADI);
        this.columnGIRISMIKTAR = new DataColumn("GIRISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISMIKTAR);
        this.columnCIKISMIKTAR = new DataColumn("CIKISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISMIKTAR);
        this.columnDEGISIMKMSI = new DataColumn("DEGISIMKMSI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEGISIMKMSI);
        this.columnDEPOADI = new DataColumn("DEPOADI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEPOADI);
        this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnMalzeme_ID = new DataColumn("Malzeme ID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMalzeme_ID);
        this.columnMALZURTTARIH = new DataColumn("MALZURTTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZURTTARIH);
        this.columnKOD = new DataColumn("KOD", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnKOD);
        this.columnISLEMTIPI.MaxLength = 50;
        this.columnPLAKA.MaxLength = 50;
        this.columnMALZEMEADI.MaxLength = 80;
        this.columnBIRIMADI.MaxLength = 50;
        this.columnGIRISMIKTAR.MaxLength = 50;
        this.columnCIKISMIKTAR.MaxLength = 50;
        this.columnDEGISIMKMSI.MaxLength = 50;
        this.columnDEPOADI.MaxLength = 50;
        this.columnID.AutoIncrement = true;
        this.columnID.AutoIncrementSeed = -1L;
        this.columnID.AutoIncrementStep = -1L;
        this.columnID.AllowDBNull = false;
        this.columnID.ReadOnly = true;
        this.columnMalzeme_ID.AutoIncrement = true;
        this.columnMalzeme_ID.AutoIncrementSeed = -1L;
        this.columnMalzeme_ID.AutoIncrementStep = -1L;
        this.columnMalzeme_ID.ReadOnly = true;
        this.columnMALZURTTARIH.MaxLength = 50;
        this.columnKOD.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEksteresi.MalzemeEkstresiGetirRow NewMalzemeEkstresiGetirRow() => (MalzemeEksteresi.MalzemeEkstresiGetirRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new MalzemeEksteresi.MalzemeEkstresiGetirRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (MalzemeEksteresi.MalzemeEkstresiGetirRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.MalzemeEkstresiGetirRowChanged == null)
          return;
        this.MalzemeEkstresiGetirRowChanged((object) this, new MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEvent((MalzemeEksteresi.MalzemeEkstresiGetirRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.MalzemeEkstresiGetirRowChanging == null)
          return;
        this.MalzemeEkstresiGetirRowChanging((object) this, new MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEvent((MalzemeEksteresi.MalzemeEkstresiGetirRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.MalzemeEkstresiGetirRowDeleted == null)
          return;
        this.MalzemeEkstresiGetirRowDeleted((object) this, new MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEvent((MalzemeEksteresi.MalzemeEkstresiGetirRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.MalzemeEkstresiGetirRowDeleting == null)
          return;
        this.MalzemeEkstresiGetirRowDeleting((object) this, new MalzemeEksteresi.MalzemeEkstresiGetirRowChangeEvent((MalzemeEksteresi.MalzemeEkstresiGetirRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveMalzemeEkstresiGetirRow(MalzemeEksteresi.MalzemeEkstresiGetirRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        MalzemeEksteresi malzemeEksteresi = new MalzemeEksteresi();
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
          FixedValue = malzemeEksteresi.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (MalzemeEkstresiGetirDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = malzemeEksteresi.GetSchemaSerializable();
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

    public class MalzemeEkstresiGetirRow : DataRow
    {
      private MalzemeEksteresi.MalzemeEkstresiGetirDataTable tableMalzemeEkstresiGetir;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal MalzemeEkstresiGetirRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableMalzemeEkstresiGetir = (MalzemeEksteresi.MalzemeEkstresiGetirDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string ISLEMTIPI
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.ISLEMTIPIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ISLEMTIPI' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.ISLEMTIPIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string PLAKA
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.PLAKAColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'PLAKA' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.PLAKAColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZEMEADI
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.MALZEMEADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZEMEADI' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.MALZEMEADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string BIRIMADI
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.BIRIMADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BIRIMADI' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.BIRIMADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.GIRISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GIRISMIKTAR' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.GIRISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.CIKISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CIKISMIKTAR' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.CIKISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DEGISIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.DEGISIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DEGISIMKMSI' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.DEGISIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DEPOADI
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.DEPOADIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DEPOADI' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.DEPOADIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int ID
      {
        get => (int) this[this.tableMalzemeEkstresiGetir.IDColumn];
        set => this[this.tableMalzemeEkstresiGetir.IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Malzeme_ID
      {
        get
        {
          try
          {
            return (int) this[this.tableMalzemeEkstresiGetir.Malzeme_IDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Malzeme ID' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.Malzeme_IDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZURTTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.MALZURTTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZURTTARIH' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.MALZURTTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string KOD
      {
        get
        {
          try
          {
            return (string) this[this.tableMalzemeEkstresiGetir.KODColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'KOD' in table 'MalzemeEkstresiGetir' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableMalzemeEkstresiGetir.KODColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsISLEMTIPINull() => this.IsNull(this.tableMalzemeEkstresiGetir.ISLEMTIPIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetISLEMTIPINull() => this[this.tableMalzemeEkstresiGetir.ISLEMTIPIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPLAKANull() => this.IsNull(this.tableMalzemeEkstresiGetir.PLAKAColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPLAKANull() => this[this.tableMalzemeEkstresiGetir.PLAKAColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZEMEADINull() => this.IsNull(this.tableMalzemeEkstresiGetir.MALZEMEADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZEMEADINull() => this[this.tableMalzemeEkstresiGetir.MALZEMEADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMADINull() => this.IsNull(this.tableMalzemeEkstresiGetir.BIRIMADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMADINull() => this[this.tableMalzemeEkstresiGetir.BIRIMADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISMIKTARNull() => this.IsNull(this.tableMalzemeEkstresiGetir.GIRISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISMIKTARNull() => this[this.tableMalzemeEkstresiGetir.GIRISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISMIKTARNull() => this.IsNull(this.tableMalzemeEkstresiGetir.CIKISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISMIKTARNull() => this[this.tableMalzemeEkstresiGetir.CIKISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEGISIMKMSINull() => this.IsNull(this.tableMalzemeEkstresiGetir.DEGISIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEGISIMKMSINull() => this[this.tableMalzemeEkstresiGetir.DEGISIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEPOADINull() => this.IsNull(this.tableMalzemeEkstresiGetir.DEPOADIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEPOADINull() => this[this.tableMalzemeEkstresiGetir.DEPOADIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMalzeme_IDNull() => this.IsNull(this.tableMalzemeEkstresiGetir.Malzeme_IDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMalzeme_IDNull() => this[this.tableMalzemeEkstresiGetir.Malzeme_IDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZURTTARIHNull() => this.IsNull(this.tableMalzemeEkstresiGetir.MALZURTTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZURTTARIHNull() => this[this.tableMalzemeEkstresiGetir.MALZURTTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsKODNull() => this.IsNull(this.tableMalzemeEkstresiGetir.KODColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetKODNull() => this[this.tableMalzemeEkstresiGetir.KODColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class MalzemeEkstresiGetirRowChangeEvent : EventArgs
    {
      private MalzemeEksteresi.MalzemeEkstresiGetirRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiGetirRowChangeEvent(
        MalzemeEksteresi.MalzemeEkstresiGetirRow row,
        DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEksteresi.MalzemeEkstresiGetirRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
