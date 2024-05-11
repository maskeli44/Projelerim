// Decompiled with JetBrains decompiler
// Type: Makina_Ikmal.Model.MalzemeEkstresiKemal
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
  [XmlRoot("MalzemeEkstresiKemal")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class MalzemeEkstresiKemal : DataSet
  {
    private MalzemeEkstresiKemal.DataTable1DataTable tableDataTable1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public MalzemeEkstresiKemal()
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
    protected MalzemeEkstresiKemal(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new MalzemeEkstresiKemal.DataTable1DataTable(dataSet.Tables[nameof (DataTable1)]));
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
    public MalzemeEkstresiKemal.DataTable1DataTable DataTable1 => this.tableDataTable1;

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
      MalzemeEkstresiKemal malzemeEkstresiKemal = (MalzemeEkstresiKemal) base.Clone();
      malzemeEkstresiKemal.InitVars();
      malzemeEkstresiKemal.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) malzemeEkstresiKemal;
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
          base.Tables.Add((DataTable) new MalzemeEkstresiKemal.DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
      this.tableDataTable1 = (MalzemeEkstresiKemal.DataTable1DataTable) base.Tables["DataTable1"];
      if (!initTable || this.tableDataTable1 == null)
        return;
      this.tableDataTable1.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (MalzemeEkstresiKemal);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/MalzemeEkstresiKemal.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableDataTable1 = new MalzemeEkstresiKemal.DataTable1DataTable();
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
      MalzemeEkstresiKemal malzemeEkstresiKemal = new MalzemeEkstresiKemal();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = malzemeEkstresiKemal.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = malzemeEkstresiKemal.GetSchemaSerializable();
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
      MalzemeEkstresiKemal.DataTable1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class DataTable1DataTable : TypedTableBase<MalzemeEkstresiKemal.DataTable1Row>
    {
      private DataColumn columnİşlem_Tipi;
      private DataColumn columnİş_Emri_Kod;
      private DataColumn columnPlaka;
      private DataColumn columnTARIH;
      private DataColumn columnFISNO;
      private DataColumn columnMalzeme_Adı;
      private DataColumn columnMALZMARKAID;
      private DataColumn columnBIRIMID;
      private DataColumn columnGIRISMIKTAR;
      private DataColumn columnCIKISMIKTAR;
      private DataColumn columnMALZSERINO;
      private DataColumn columnMALZURTTARIH;
      private DataColumn columnDEGISIMKMSI;
      private DataColumn columnSONRAKIDEGKM;
      private DataColumn columnDEPOID;

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
      public DataColumn İşlem_TipiColumn => this.columnİşlem_Tipi;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn İş_Emri_KodColumn => this.columnİş_Emri_Kod;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn PlakaColumn => this.columnPlaka;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn TARIHColumn => this.columnTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn FISNOColumn => this.columnFISNO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn Malzeme_AdıColumn => this.columnMalzeme_Adı;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZMARKAIDColumn => this.columnMALZMARKAID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn BIRIMIDColumn => this.columnBIRIMID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn GIRISMIKTARColumn => this.columnGIRISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CIKISMIKTARColumn => this.columnCIKISMIKTAR;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZSERINOColumn => this.columnMALZSERINO;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn MALZURTTARIHColumn => this.columnMALZURTTARIH;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEGISIMKMSIColumn => this.columnDEGISIMKMSI;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn SONRAKIDEGKMColumn => this.columnSONRAKIDEGKM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn DEPOIDColumn => this.columnDEPOID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiKemal.DataTable1Row this[int index] => (MalzemeEkstresiKemal.DataTable1Row) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEkstresiKemal.DataTable1RowChangeEventHandler DataTable1RowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEkstresiKemal.DataTable1RowChangeEventHandler DataTable1RowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEkstresiKemal.DataTable1RowChangeEventHandler DataTable1RowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event MalzemeEkstresiKemal.DataTable1RowChangeEventHandler DataTable1RowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddDataTable1Row(MalzemeEkstresiKemal.DataTable1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiKemal.DataTable1Row AddDataTable1Row(
        string İşlem_Tipi,
        string İş_Emri_Kod,
        int Plaka,
        DateTime TARIH,
        string FISNO,
        int Malzeme_Adı,
        int MALZMARKAID,
        int BIRIMID,
        string GIRISMIKTAR,
        string CIKISMIKTAR,
        string MALZSERINO,
        string MALZURTTARIH,
        string DEGISIMKMSI,
        string SONRAKIDEGKM,
        int DEPOID)
      {
        MalzemeEkstresiKemal.DataTable1Row row = (MalzemeEkstresiKemal.DataTable1Row) this.NewRow();
        object[] objArray = new object[15]
        {
          (object) İşlem_Tipi,
          (object) İş_Emri_Kod,
          (object) Plaka,
          (object) TARIH,
          (object) FISNO,
          (object) Malzeme_Adı,
          (object) MALZMARKAID,
          (object) BIRIMID,
          (object) GIRISMIKTAR,
          (object) CIKISMIKTAR,
          (object) MALZSERINO,
          (object) MALZURTTARIH,
          (object) DEGISIMKMSI,
          (object) SONRAKIDEGKM,
          (object) DEPOID
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        MalzemeEkstresiKemal.DataTable1DataTable dataTable1DataTable = (MalzemeEkstresiKemal.DataTable1DataTable) base.Clone();
        dataTable1DataTable.InitVars();
        return (DataTable) dataTable1DataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new MalzemeEkstresiKemal.DataTable1DataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnİşlem_Tipi = this.Columns["İşlem Tipi"];
        this.columnİş_Emri_Kod = this.Columns["İş Emri Kod"];
        this.columnPlaka = this.Columns["Plaka"];
        this.columnTARIH = this.Columns["TARIH"];
        this.columnFISNO = this.Columns["FISNO"];
        this.columnMalzeme_Adı = this.Columns["Malzeme Adı"];
        this.columnMALZMARKAID = this.Columns["MALZMARKAID"];
        this.columnBIRIMID = this.Columns["BIRIMID"];
        this.columnGIRISMIKTAR = this.Columns["GIRISMIKTAR"];
        this.columnCIKISMIKTAR = this.Columns["CIKISMIKTAR"];
        this.columnMALZSERINO = this.Columns["MALZSERINO"];
        this.columnMALZURTTARIH = this.Columns["MALZURTTARIH"];
        this.columnDEGISIMKMSI = this.Columns["DEGISIMKMSI"];
        this.columnSONRAKIDEGKM = this.Columns["SONRAKIDEGKM"];
        this.columnDEPOID = this.Columns["DEPOID"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnİşlem_Tipi = new DataColumn("İşlem Tipi", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİşlem_Tipi);
        this.columnİş_Emri_Kod = new DataColumn("İş Emri Kod", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnİş_Emri_Kod);
        this.columnPlaka = new DataColumn("Plaka", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPlaka);
        this.columnTARIH = new DataColumn("TARIH", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTARIH);
        this.columnFISNO = new DataColumn("FISNO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFISNO);
        this.columnMalzeme_Adı = new DataColumn("Malzeme Adı", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMalzeme_Adı);
        this.columnMALZMARKAID = new DataColumn("MALZMARKAID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZMARKAID);
        this.columnBIRIMID = new DataColumn("BIRIMID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBIRIMID);
        this.columnGIRISMIKTAR = new DataColumn("GIRISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGIRISMIKTAR);
        this.columnCIKISMIKTAR = new DataColumn("CIKISMIKTAR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCIKISMIKTAR);
        this.columnMALZSERINO = new DataColumn("MALZSERINO", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZSERINO);
        this.columnMALZURTTARIH = new DataColumn("MALZURTTARIH", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMALZURTTARIH);
        this.columnDEGISIMKMSI = new DataColumn("DEGISIMKMSI", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEGISIMKMSI);
        this.columnSONRAKIDEGKM = new DataColumn("SONRAKIDEGKM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSONRAKIDEGKM);
        this.columnDEPOID = new DataColumn("DEPOID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDEPOID);
        this.columnİşlem_Tipi.MaxLength = 50;
        this.columnİş_Emri_Kod.MaxLength = 50;
        this.columnFISNO.MaxLength = 50;
        this.columnGIRISMIKTAR.MaxLength = 50;
        this.columnCIKISMIKTAR.MaxLength = 50;
        this.columnMALZSERINO.MaxLength = 50;
        this.columnMALZURTTARIH.MaxLength = 50;
        this.columnDEGISIMKMSI.MaxLength = 50;
        this.columnSONRAKIDEGKM.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiKemal.DataTable1Row NewDataTable1Row() => (MalzemeEkstresiKemal.DataTable1Row) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new MalzemeEkstresiKemal.DataTable1Row(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (MalzemeEkstresiKemal.DataTable1Row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.DataTable1RowChanged == null)
          return;
        this.DataTable1RowChanged((object) this, new MalzemeEkstresiKemal.DataTable1RowChangeEvent((MalzemeEkstresiKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.DataTable1RowChanging == null)
          return;
        this.DataTable1RowChanging((object) this, new MalzemeEkstresiKemal.DataTable1RowChangeEvent((MalzemeEkstresiKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.DataTable1RowDeleted == null)
          return;
        this.DataTable1RowDeleted((object) this, new MalzemeEkstresiKemal.DataTable1RowChangeEvent((MalzemeEkstresiKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.DataTable1RowDeleting == null)
          return;
        this.DataTable1RowDeleting((object) this, new MalzemeEkstresiKemal.DataTable1RowChangeEvent((MalzemeEkstresiKemal.DataTable1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemoveDataTable1Row(MalzemeEkstresiKemal.DataTable1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        MalzemeEkstresiKemal malzemeEkstresiKemal = new MalzemeEkstresiKemal();
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
          FixedValue = malzemeEkstresiKemal.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (DataTable1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = malzemeEkstresiKemal.GetSchemaSerializable();
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
      private MalzemeEkstresiKemal.DataTable1DataTable tableDataTable1;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal DataTable1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableDataTable1 = (MalzemeEkstresiKemal.DataTable1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İşlem_Tipi
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.İşlem_TipiColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'İşlem Tipi' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İşlem_TipiColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string İş_Emri_Kod
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.İş_Emri_KodColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'İş Emri Kod' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.İş_Emri_KodColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Plaka
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.PlakaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Plaka' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.PlakaColumn] = (object) value;
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
            throw new StrongTypingException("The value for column 'TARIH' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.TARIHColumn] = (object) value;
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
            throw new StrongTypingException("The value for column 'FISNO' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.FISNOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Malzeme_Adı
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.Malzeme_AdıColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Malzeme Adı' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.Malzeme_AdıColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int MALZMARKAID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.MALZMARKAIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZMARKAID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZMARKAIDColumn] = (object) value;
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
            throw new StrongTypingException("The value for column 'BIRIMID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.BIRIMIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string GIRISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.GIRISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GIRISMIKTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.GIRISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string CIKISMIKTAR
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.CIKISMIKTARColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CIKISMIKTAR' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.CIKISMIKTARColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZSERINO
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZSERINOColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZSERINO' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZSERINOColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string MALZURTTARIH
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.MALZURTTARIHColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'MALZURTTARIH' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.MALZURTTARIHColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string DEGISIMKMSI
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.DEGISIMKMSIColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DEGISIMKMSI' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEGISIMKMSIColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string SONRAKIDEGKM
      {
        get
        {
          try
          {
            return (string) this[this.tableDataTable1.SONRAKIDEGKMColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SONRAKIDEGKM' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.SONRAKIDEGKMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int DEPOID
      {
        get
        {
          try
          {
            return (int) this[this.tableDataTable1.DEPOIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DEPOID' in table 'DataTable1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableDataTable1.DEPOIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİşlem_TipiNull() => this.IsNull(this.tableDataTable1.İşlem_TipiColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİşlem_TipiNull() => this[this.tableDataTable1.İşlem_TipiColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Isİş_Emri_KodNull() => this.IsNull(this.tableDataTable1.İş_Emri_KodColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Setİş_Emri_KodNull() => this[this.tableDataTable1.İş_Emri_KodColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsPlakaNull() => this.IsNull(this.tableDataTable1.PlakaColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetPlakaNull() => this[this.tableDataTable1.PlakaColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsTARIHNull() => this.IsNull(this.tableDataTable1.TARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetTARIHNull() => this[this.tableDataTable1.TARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsFISNONull() => this.IsNull(this.tableDataTable1.FISNOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetFISNONull() => this[this.tableDataTable1.FISNOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMalzeme_AdıNull() => this.IsNull(this.tableDataTable1.Malzeme_AdıColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMalzeme_AdıNull() => this[this.tableDataTable1.Malzeme_AdıColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZMARKAIDNull() => this.IsNull(this.tableDataTable1.MALZMARKAIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZMARKAIDNull() => this[this.tableDataTable1.MALZMARKAIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsBIRIMIDNull() => this.IsNull(this.tableDataTable1.BIRIMIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetBIRIMIDNull() => this[this.tableDataTable1.BIRIMIDColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsGIRISMIKTARNull() => this.IsNull(this.tableDataTable1.GIRISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetGIRISMIKTARNull() => this[this.tableDataTable1.GIRISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsCIKISMIKTARNull() => this.IsNull(this.tableDataTable1.CIKISMIKTARColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetCIKISMIKTARNull() => this[this.tableDataTable1.CIKISMIKTARColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZSERINONull() => this.IsNull(this.tableDataTable1.MALZSERINOColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZSERINONull() => this[this.tableDataTable1.MALZSERINOColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsMALZURTTARIHNull() => this.IsNull(this.tableDataTable1.MALZURTTARIHColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetMALZURTTARIHNull() => this[this.tableDataTable1.MALZURTTARIHColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEGISIMKMSINull() => this.IsNull(this.tableDataTable1.DEGISIMKMSIColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEGISIMKMSINull() => this[this.tableDataTable1.DEGISIMKMSIColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsSONRAKIDEGKMNull() => this.IsNull(this.tableDataTable1.SONRAKIDEGKMColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetSONRAKIDEGKMNull() => this[this.tableDataTable1.SONRAKIDEGKMColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsDEPOIDNull() => this.IsNull(this.tableDataTable1.DEPOIDColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetDEPOIDNull() => this[this.tableDataTable1.DEPOIDColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class DataTable1RowChangeEvent : EventArgs
    {
      private MalzemeEkstresiKemal.DataTable1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataTable1RowChangeEvent(MalzemeEkstresiKemal.DataTable1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public MalzemeEkstresiKemal.DataTable1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
